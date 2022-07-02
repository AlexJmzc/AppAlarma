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
    public partial class FormularioEmpresas : Form
    {
        public FormularioEmpresas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void cargarTabla()
        {
            this.dtgEmpresas.DataSource = EmpresaLogica.DevolverListaEmpresas();
        }

        



        private void cargarCasosEnControles(int id)
        {
            Empresa empresa = EmpresaLogica.DevolverEmpresa(id);
            txtID.Text = empresa.ID_EMP.ToString();
            txtNombreEmpresa.Text = empresa.NOMBRE_EMP;
            txtDireccion.Text = empresa.DIRECCION_EMP;
            txtCoordenadas.Text = empresa.COORDENADAS_EMP;
            txtDescripcion.Text = empresa.DESCRIPCION_EMP;
            txtTelefono.Text = empresa.TELEFONO_EMP;
        }

        private void FormularioEmpresas_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void dtgEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dtgEmpresas.Rows[e.RowIndex].Cells["ID_EMP"].Value.ToString());
            cargarCasosEnControles(id);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtID.Text.ToString());
            var nombre = txtNombreEmpresa.Text;
            var direccion = txtDireccion.Text;
            var coordenadas = txtCoordenadas.Text;
            var descripcion = txtDescripcion.Text;
            var telefono = txtTelefono.Text;
            Empresa empresa = new Empresa(id, nombre, direccion, coordenadas, descripcion, telefono);
            EmpresaLogica.Actualizar(empresa);
            cargarTabla();
            vaciarTXT();
        }

        private void vaciarTXT()
        {
            txtID.Clear();
            txtNombreEmpresa.Clear();
            txtDireccion.Clear();
            txtCoordenadas.Clear();
            txtDescripcion.Clear();
            txtTelefono.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe seleccionarla empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var id = Convert.ToInt32(txtID.Text.ToString());
                EmpresaLogica.EliminarEmpresa(id);
                cargarTabla();
                vaciarTXT();
            }
        }
    }
}
