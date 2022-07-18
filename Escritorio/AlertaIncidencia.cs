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
    public partial class AlertaIncidencia : Form

    {

        Incidencia i;

        public AlertaIncidencia(Incidencia incidencia)
        {
            i = incidencia;
            Empresa e = EmpresaLogica.DevolverEmpresa(incidencia.ID_EMPRESA);
            Usuario u = UsuarioLogica.DevolverUsuarioID(incidencia.ID_USU);
            string nombre = e.NOMBRE_EMP;
            string direccion = e.DIRECCION_EMP;
            string coordenadas = e.COORDENADAS_EMP;
            string nombreusuario = u.NOMBRE_CLI + " " + u.APELLIDO_CLI;
            InitializeComponent();

            lblTexto.Text = nombreusuario + " ha activado la alarma de la empresa " + nombre + "\n"
                + " ubicada en la " + direccion + ", coordenadas " + coordenadas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            IncidenciaLogica.ActualizarEstado(i.ID_INCIDENCIA, "En Espera");

            MessageBox.Show("La policía fue avisada y está en camino", "Aviso",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }
    }
}
