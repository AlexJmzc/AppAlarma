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


        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void cargarTabla()
        {
            
            this.dtgEmpresas.DataSource = EmpresaLogica.DevolverListaEmpresasEstado("Activo");
        }

        



        private void cargarCasosEnControles(int id)
        {
            Empresa empresa = EmpresaLogica.DevolverEmpresa(id);
            txtID.Text = empresa.ID_EMP.ToString();
            txtNombreEmpresa.Text = empresa.NOMBRE_EMP;
            cbxDirecciones.SelectedValue = empresa.DIRECCION_EMP;
            txtCoordenadas.Text = empresa.COORDENADAS_EMP;
            txtDescripcion.Text = empresa.DESCRIPCION_EMP;
            txtTelefono.Text = empresa.TELEFONO_EMP;
        }

        private void FormularioEmpresas_Load(object sender, EventArgs e)
        {
            cargarTabla();
            cargarCombo();
            //cargarComboEstados();
        }

        private void dtgEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dtgEmpresas.Rows[e.RowIndex].Cells["ID_EMP"].Value.ToString());
            cargarCasosEnControles(id);
        }

        private void cargarCombo()
        {
            Direcciones d = new Direcciones();
            d.Direccion = "";
            d.Coordenadas = "";
            List<Direcciones> lista = DireccionLogica.DevolverListaDirecciones();
            lista.Add(d);
            lista.Reverse();

            cbxDirecciones.DataSource = lista;
            cbxDirecciones.DisplayMember = "DIRECCION";
            cbxDirecciones.ValueMember = "DIRECCION";
            
        }


        /*private void cargarComboEstados()
        {
            List<String> lista = new List<String>();
            lista.Add("");
            lista.Add("Activo");
            lista.Add("No Activo");

            cbxEstado.DataSource = lista;
        }*/

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtID.Text.ToString());
            Empresa empresa = new Empresa();

            if (txtNombreEmpresa.Text.ToString() != "")
            {
                empresa.NOMBRE_EMP = txtNombreEmpresa.Text;
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la empresa", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cbxDirecciones.SelectedValue.ToString() != "")
            {
                empresa.DIRECCION_EMP = cbxDirecciones.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la dirección de la empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (txtCoordenadas.Text.ToString() != "")
            {
                empresa.COORDENADAS_EMP = txtCoordenadas.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una dirección", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtDescripcion.Text.ToString() != "")
            {
                empresa.DESCRIPCION_EMP = txtDescripcion.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar la descripción de la empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtTelefono.Text.ToString() != "")
            {
                empresa.TELEFONO_EMP = txtTelefono.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el teléfono de la empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            empresa.ESTADO = "Activo";
           
            
            
            EmpresaLogica.Actualizar(empresa);
            cargarTabla();
            vaciarTXT();
        }

        private void vaciarTXT()
        {
            txtID.Clear();
            txtNombreEmpresa.Clear();
            cbxDirecciones.SelectedValue = "";
            txtCoordenadas.Clear();
            txtDescripcion.Clear();
            txtTelefono.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe seleccionar la empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var id = Convert.ToInt32(txtID.Text.ToString());
                Empresa emp = new Empresa();
                emp.ID_EMP = id;
                emp.ESTADO = "No Activo";
                EmpresaLogica.ActualizarEstado(emp);
                cargarTabla();
                vaciarTXT();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();


            //NOMBRE
            if (txtNombreEmpresa.Text.ToString() != "")
            {
                emp.NOMBRE_EMP = txtNombreEmpresa.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //DIRECCION
            if (cbxDirecciones.SelectedValue.ToString() != "")
            {
                emp.DIRECCION_EMP = cbxDirecciones.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la dirección de la empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //COORDENADAS
            if (txtCoordenadas.Text.ToString() != "")
            {
                emp.COORDENADAS_EMP = txtCoordenadas.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una dirección", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //DESCRIPCION
            if (txtDescripcion.Text.ToString() != "")
            {
                emp.DESCRIPCION_EMP = txtDescripcion.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar la descripción de la empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //TELEFONO
            if (txtTelefono.Text.ToString() != "")
            {
                emp.TELEFONO_EMP = txtTelefono.Text.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar el teléfono de la empresa", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            emp.ESTADO = "Activo";
            
         
            EmpresaLogica.NuevaEmpresa(emp);
            
            cargarTabla();
            vaciarTXT();
        }

        private void cbxDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxDirecciones_TextChanged(object sender, EventArgs e)
        {
            string direccion = cbxDirecciones.SelectedValue.ToString();

            if (direccion != "")
            {
                Direcciones d = DireccionLogica.DevolverDireccion(direccion);
                txtCoordenadas.Text = d.Coordenadas;
            }
        }
    }
}
