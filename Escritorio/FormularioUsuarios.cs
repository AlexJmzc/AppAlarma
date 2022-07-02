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
            this.dtgUsuarios.DataSource = UsuarioLogica.DevolverListaUsuarios();
        }

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        

        private void cargarCasosEnControles(string id)
        {
            Usuario usuario = UsuarioLogica.DevolverUsuarioCedula(id);
            txtID.Text = usuario.ID_USU.ToString();
            txtUsuarioNombre.Text = usuario.NOMBRE_USU;
            txtClave.Text = usuario.CLAVE_USU;
            txtRol.Text = usuario.ROL_USU;
            txtNombre.Text = usuario.NOMBRE_CLI;
            txtApellido.Text = usuario.APELLIDO_CLI;
            txtCedula.Text = usuario.CEDULA_USU;
            txtTelefono.Text = usuario.TELEFONO_CLI;
            Empresa empresa = EmpresaLogica.DevolverEmpresa(usuario.ID_EMPRESA);
            txtEmpresa.Text = empresa.NOMBRE_EMP;
            txtIDEmpresa.Text = empresa.ID_EMP.ToString();
        }

        private void dtgUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var id = dtgUsuarios.Rows[e.RowIndex].Cells["CEDULA_USU"].Value.ToString();
            cargarCasosEnControles(id);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtID.Text.ToString());
            var nombreusu = txtUsuarioNombre.Text;
            var clave = txtClave.Text;
            var rol = txtRol.Text;
            var cedula = txtCedula.Text;
            var nombre = txtNombre.Text;
            var apellido = txtApellido.Text;
            var telefono = txtTelefono.Text;
            var empresa = Convert.ToInt32(txtIDEmpresa.Text.ToString());
            Usuario usuario = new Usuario(id, nombreusu, clave, rol, cedula, nombre, apellido, telefono, empresa);
            UsuarioLogica.ActualizarUsuario(usuario);
            cargarTabla();
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
                UsuarioLogica.EliminarUsuario(id);
                cargarTabla();
            }
        }
    }
}
