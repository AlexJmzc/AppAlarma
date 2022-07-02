using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;

namespace Escritorio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, System.EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtUsuario_Leave(object sender, System.EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        private void txtClave_Enter(object sender, System.EventArgs e)
        {
            if (txtClave.Text == "CONTRASEÑA")
            {
                txtClave.Text = "";
                txtClave.ForeColor = System.Drawing.Color.LightGray;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, System.EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "CONTRASEÑA";
                txtClave.ForeColor = System.Drawing.Color.DimGray;
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if(txtUsuario.Text != "USUARIO")
            {
                if (txtClave.Text != "CONTRASEÑA")
                {
                    
                    var resultado = UsuarioLogica.IniciarSesion(txtUsuario.Text, txtClave.Text);
                   
                    if(resultado == true)
                    {
                        var usuario = UsuarioLogica.DevolverUsuarioNombreUsu(txtUsuario.Text);
                        Principal mainMenu = new Principal(usuario);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos");
                        txtUsuario.Text = "USUARIO";
                        txtClave.Text = "CONTRASEÑA";
                        txtClave.UseSystemPasswordChar = false;
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    msgError("Ingrese la contraseña");
                }
            }
            else
            {
                msgError("Ingrese el usuario");
            }
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "        " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Text = "USUARIO";
            txtClave.Text = "CONTRASEÑA";
            txtClave.UseSystemPasswordChar = false;
            lblErrorMessage.Visible = false;
            this.Show();
            //txtUsuario.Focus();
        }
    }
}
