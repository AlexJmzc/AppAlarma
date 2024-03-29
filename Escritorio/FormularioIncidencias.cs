﻿using System;
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
    public partial class FormularioIncidencias : Form
    {
        public FormularioIncidencias()
        {
            InitializeComponent();
        }

        private void cargarTabla() //0 0 0
        {
            this.dtgIncidencias.DataSource = IncidenciaLogica.DevolverListaIncidencias();
            
            
        }


        private void cargarTablaFiltroEmpresa_Estado_Fecha(string nombre, string estado, string fecha)  //1 1 1
        {
            this.dtgIncidencias.DataSource = IncidenciaLogica.DevolverListaIncidenciasEmpresaEstadoFecha(nombre, estado, fecha);
        }

        private void cargarTablaFiltroFecha(string fecha) // 0 0 1
        {
            this.dtgIncidencias.DataSource = IncidenciaLogica.DevolverListaIncidenciasFecha(fecha);
        }

        private void cargarTablaFiltroEstado(string estado) // 0 1 0
        {
            this.dtgIncidencias.DataSource = IncidenciaLogica.DevolverListaIncidenciasEstado(estado);
        }

        private void cargarTablaFiltroEmpresa(string nombre) // 1 0 0
        {
            this.dtgIncidencias.DataSource = IncidenciaLogica.DevolverListaIncidenciasNombreEmpresa(nombre);
        }

        private void cargarTablaFiltroEstado_Fecha(string estado, string fecha) // 0 1 1
        {
            this.dtgIncidencias.DataSource = IncidenciaLogica.DevolverListaIncidenciasEstadoFecha(estado, fecha);
        }

        private void cargarTablaFiltroEmpresa_Fecha(string nombre, string fecha) // 1 0 1
        {
            this.dtgIncidencias.DataSource = IncidenciaLogica.DevolverListaIncidenciasEmpresaFecha(nombre, fecha);
        }

        private void cargarTablaFiltroEmpresa_Estado(string nombre, string estado) // 1 0 1
        {
            this.dtgIncidencias.DataSource = IncidenciaLogica.DevolverListaIncidenciasEmpresaEstado(nombre, estado);
        }








        private void dtgIncidencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormularioIncidencias_Load(object sender, EventArgs e)
        {
            cargarTabla();
            cargarCombos();

        }

        private void dtgIncidencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if(this.dtgIncidencias.Columns[e.ColumnIndex].Name.ToString() == "ESTADO")
            {   
                if (Convert.ToString(e.Value).Contains("Alerta"))
                {
                    e.CellStyle.BackColor = Color.Red;
                    
                }
                else 
                if (Convert.ToString(e.Value).Contains("En Espera"))
                {
                    
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else
                if (Convert.ToString(e.Value).Contains("Atendida"))
                {
                   
                    e.CellStyle.BackColor = Color.Green;
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCombos()
        {
            cargarComboEmpresas();
            cargarComboEstados();
        }

        private void cargarComboEmpresas()
        {
            Empresa e = new Empresa();
            e.NOMBRE_EMP = "Ninguna";
            e.ID_EMP = 0;
            List<Empresa> lista = EmpresaLogica.DevolverListaEmpresas();
            lista.Add(e);
            lista.Reverse();
            cbxEmpresas.DataSource = lista;
            cbxEmpresas.DisplayMember = "NOMBRE_EMP";
            cbxEmpresas.ValueMember = "NOMBRE_EMP";
        }

        private void cargarComboEstados()
        {
            List<String> lista = new List<string>();
            lista.Add("Ninguno");
            lista.Add("Alerta");
            lista.Add("En Espera");
            lista.Add("Atendida");
            cbxEstados.DataSource = lista;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbxEmpresas.SelectedIndex = 0;
            cbxEstados.SelectedIndex = 0;
            cargarTabla();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
           
            String fecha1 = dtpFecha.Value.Year.ToString() + "-" + dtpFecha.Value.Month.ToString() + "-" + dtpFecha.Value.Day.ToString();
            DateTime f = Convert.ToDateTime(dtpFecha.Value.ToString("yyyy-MM-dd"));
            
          
            if (!cbxEmpresas.SelectedValue.ToString().Contains("Ninguna") && cbxEstados.SelectedItem.ToString() != "Ninguno" && fecha1 != "2019-12-31") //1 1 1
            {
                var emp = cbxEmpresas.SelectedItem as Empresa;
                String estado = cbxEstados.SelectedItem.ToString();
                cargarTablaFiltroEmpresa_Estado_Fecha(emp.NOMBRE_EMP, estado, dtpFecha.Value.ToString("yyyy-MM-dd"));
            }
            else if (cbxEmpresas.SelectedValue.ToString().Contains("Ninguna") && cbxEstados.SelectedItem.ToString() == "Ninguno" && fecha1 != "2019-12-31") // 0 0 1
            {
                cargarTablaFiltroFecha(dtpFecha.Value.ToString("yyyy-MM-dd"));
            }
            else if (cbxEmpresas.SelectedValue.ToString().Contains("Ninguna") && cbxEstados.SelectedItem.ToString() != "Ninguno" && fecha1 == "2019-12-31") // 0 1 0
            {
                cargarTablaFiltroEstado(cbxEstados.SelectedItem.ToString());
            }
            else if (!cbxEmpresas.SelectedValue.ToString().Contains("Ninguna") && cbxEstados.SelectedItem.ToString() == "Ninguno" && fecha1 == "2019-12-31") // 1 0 0
            {
                var emp = cbxEmpresas.SelectedItem as Empresa;
                cargarTablaFiltroEmpresa(emp.NOMBRE_EMP);
            }
            else if (cbxEmpresas.SelectedValue.ToString().Contains("Ninguna") && cbxEstados.SelectedItem.ToString() != "Ninguno" && fecha1 != "2019-12-31") // 0 1 1
            {
                cargarTablaFiltroEstado_Fecha(cbxEstados.SelectedItem.ToString(), dtpFecha.Value.ToString("yyyy-MM-dd"));
            }
            else if (!cbxEmpresas.SelectedValue.ToString().Contains("Ninguna") && cbxEstados.SelectedItem.ToString() == "Ninguno" && fecha1 != "2019-12-31") // 1 0 1
            {
                var emp = cbxEmpresas.SelectedItem as Empresa;
                cargarTablaFiltroEmpresa_Fecha(emp.NOMBRE_EMP, dtpFecha.Value.ToString("yyyy-MM-dd"));
            }
            else if (!cbxEmpresas.SelectedValue.ToString().Contains("Ninguna") && cbxEstados.SelectedItem.ToString() != "Ninguno" && fecha1 == "2019-12-31") // 1 1 0
            {
                var emp = cbxEmpresas.SelectedItem as Empresa;
                cargarTablaFiltroEmpresa_Estado(emp.NOMBRE_EMP, cbxEstados.SelectedItem.ToString());
            }
            else
            {
                cargarTabla();
            }


        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtEstado.Text == "")
            {
                MessageBox.Show("Debe seleccionar una incidencia primero", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if(txtEstado.Text.Contains("En Espera"))
            {
                
               MessageBox.Show("La policía ya está en camino para atender esta incidencia", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtEstado.Text.Contains("Atendida"))
            {
                MessageBox.Show("Esta incidencia ya fue atendida", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtEstado.Text.Contains("Alerta"))
            {
                var id = Convert.ToInt32(txtID.Text.ToString());

                IncidenciaLogica.ActualizarEstado(id , "En Espera");

                MessageBox.Show("La policía fue avisada y está en camino", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cargarTabla();

            }
        }

        private void dtgIncidencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dtgIncidencias.Rows[e.RowIndex].Cells["ID_INCIDENCIA"].Value.ToString());
          
            cargarCasosEnControles(id);
        }

        private void cargarCasosEnControles(int id)
        {
            Incidencia inc = IncidenciaLogica.DevolverIncidenciaID(id);
            if (inc != null)
            {
                txtEstado.Text = inc.ESTADO;
                txtID.Text = inc.ID_INCIDENCIA.ToString();
            }
            else
            {
                MessageBox.Show("Error", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }
    }
}
