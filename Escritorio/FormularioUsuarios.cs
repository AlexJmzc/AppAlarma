using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Escritorio
{
    public partial class FormularioUsuarios : Form
    {
        public FormularioUsuarios()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarTabla()
        {
            this.dtgUsuarios.DataSource = UsuarioLogica.DevolverListaUsuariosEstado("Activo");
        }

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {
            cargarTabla();
            cargarCombos();
        }

        

        private void cargarCasosEnControles(string id)
        {
            Usuario usuario = UsuarioLogica.DevolverUsuarioCedula(id);
            txtID.Text = usuario.ID_USU.ToString();
            txtUsuarioNombre.Text = usuario.NOMBRE_USU;
            txtClave.Text = usuario.CLAVE_USU;
            cbxRoles.SelectedItem = usuario.ROL_USU;
            txtNombre.Text = usuario.NOMBRE_CLI;
            txtApellido.Text = usuario.APELLIDO_CLI;
            txtCedula.Text = usuario.CEDULA_USU;
            txtTelefono.Text = usuario.TELEFONO_CLI;
            Empresa empresa = EmpresaLogica.DevolverEmpresa(usuario.ID_EMPRESA);
            cbxEmpresas.SelectedValue = empresa.ID_EMP;
            
            txtIDEmpresa.Text = empresa.ID_EMP.ToString();
        }

        private void dtgUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var id = dtgUsuarios.Rows[e.RowIndex].Cells["CEDULA_USU"].Value.ToString();
            cargarCasosEnControles(id);
        }


        private void cargarCBXRoles()
        {
            List<String> lista = new List<string>();
            lista.Add("");
            lista.Add("Administrador");
            lista.Add("Empleado");
            
            cbxRoles.DataSource = lista;
            
        }

        private void cargarCBXEmpresas()
        {
            Empresa e = new Empresa();
            e.NOMBRE_EMP = "Ninguna";
            e.ID_EMP = 0;
            List<Empresa> lista = EmpresaLogica.DevolverListaEmpresasEstado("Activo");
            lista.Add(e);
            lista.Reverse();
            cbxEmpresas.DataSource = lista;
            cbxEmpresas.DisplayMember = "NOMBRE_EMP";
            cbxEmpresas.ValueMember = "ID_EMP";
        }

        private void cargarCombos()
        {
            cargarCBXEmpresas();
            cargarCBXRoles();
        }

        private void borrarTxt()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuarioNombre.Clear();
            txtClave.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            cbxRoles.SelectedIndex = 0;
            cbxEmpresas.SelectedIndex = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtID.Text.ToString());

            Usuario usuario = new Usuario();

            usuario.ID_USU = id;

            if (txtUsuarioNombre.Text.ToString() != "")
            {
                usuario.NOMBRE_USU = txtUsuarioNombre.Text;
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de usuario", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtClave.Text.ToString() != "")
            {
                usuario.CLAVE_USU = txtClave.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar la clave", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cbxRoles.SelectedItem.ToString() != "")
            {
                usuario.ROL_USU = cbxRoles.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtCedula.Text.ToString() != "")
            {
                usuario.CEDULA_USU = txtCedula.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar la cedula", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtNombre.Text.ToString() != "")
            {
                usuario.NOMBRE_CLI = txtNombre.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (txtApellido.Text.ToString() != "")
            {
                usuario.APELLIDO_CLI = txtApellido.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el apellido", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtTelefono.Text.ToString() != "")
            {
                usuario.TELEFONO_CLI = txtTelefono.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el teléfono", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cbxEmpresas.SelectedItem.ToString() != "Ninguna")
            {
                usuario.ID_EMPRESA = Convert.ToInt32(cbxEmpresas.SelectedValue);
            }
            else
            {
                MessageBox.Show(cbxEmpresas.SelectedItem.ToString(), "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            usuario.ESTADO = "Activo";
            
            UsuarioLogica.ActualizarUsuario(usuario);
            cargarTabla();
            borrarTxt();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe seleccionar el usuario", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var id = Convert.ToInt32(txtID.Text.ToString());
                Usuario usu = new Usuario();
                usu.ID_USU = id;
                usu.ESTADO = "No Activo";

                UsuarioLogica.ActualizarEstadoUsuario(usu);

                cargarTabla();
                borrarTxt();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            
            //NOMBRE USUARIO
            if (txtUsuarioNombre.Text.ToString() != "")
            {
                usu.NOMBRE_USU = txtUsuarioNombre.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de usuario", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //CLAVE
            if (txtClave.Text.ToString() != "")
            {
                usu.CLAVE_USU = txtClave.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar la clave", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ROL
            if (cbxRoles.SelectedItem.ToString() != "")
            {
                usu.ROL_USU = cbxRoles.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el rol", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //CEDULA
            if (txtCedula.Text.ToString() != "")
            {
                usu.CEDULA_USU = txtCedula.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar la cedula", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //NOMBRE
            if (txtNombre.Text.ToString() != "")
            {
                usu.NOMBRE_CLI = txtNombre.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //APELLIDO
            if (txtApellido.Text.ToString() != "")
            {
                usu.APELLIDO_CLI = txtApellido.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el apellido", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //TELEFONO
            if (txtTelefono.Text.ToString() != "")
            {
                usu.TELEFONO_CLI = txtTelefono.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el teléfono", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //EMPRESA
            if (cbxEmpresas.SelectedItem.ToString() != "Ninguna")
            {
                usu.ID_EMPRESA = Convert.ToInt32(cbxEmpresas.SelectedValue);
            }
            else
            {
                MessageBox.Show("Debe seleccionar la empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            usu.ESTADO = "Activo";

            UsuarioLogica.Nuevo(usu);
            cargarTabla();
            borrarTxt();
            
        }
    }
}
