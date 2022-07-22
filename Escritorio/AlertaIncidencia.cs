using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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

            notificacion();

            this.Close();
        }


        private static string notificacion()
        {
            //Empresa e = EmpresaLogica.DevolverEmpresa(i.ID_EMPRESA);
            string response;
            try
            {
                string serverKey = "AAAAdy6Gk2s:APA91bHmboJatuttNsWKrbNKhxvDzSg3HUK8iM0fsyJJWV9yyXp53qZdoGrrAAHTkq8i8_odL9LRlqm_UXRemu9h9wmW6RN3f2cmpe7j5yT5nwQJxO2DBx-HvXuxr5mPfLCqmiQRMKbq";
                string senderID = "511881679723";
                string deviceID = "/topics/proyecto";
                WebRequest peticion = WebRequest.Create("https://fcm.googleapis.com/fcm/send");

                peticion.Method = "post";
                peticion.ContentType = "application/json";

                var datos = new
                {
                    to = deviceID,
                    notification = new
                    {
                        body = "Alerta en la empresa",
                        title = "Alerta",
                        sound = "Enabled"
                    }
                };

                var serializer = new JavaScriptSerializer();
                var json = serializer.Serialize(datos);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                peticion.Headers.Add(string.Format("Authorization: key={0}", serverKey));
                peticion.Headers.Add(string.Format("Sender: id={0}", senderID));
                peticion.ContentLength = byteArray.Length;

                using (Stream dataStream = peticion.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = peticion.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                response = sResponseFromServer;
                                Console.WriteLine(response);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }

            return response;
        }
        }
    }
