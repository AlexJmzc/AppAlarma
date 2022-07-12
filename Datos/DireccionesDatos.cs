using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DireccionesDatos
    {

        public static List<Direcciones> DevolverListaDirecciones()
        {
            try
            {
                List<Direcciones> lista = new List<Direcciones>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [DIRECCION]
                                      ,[COORDENADAS]
                                    FROM [dbo].[Direcciones]";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Direcciones direccion = new Direcciones();
                        direccion.Direccion = dr["DIRECCION"].ToString();
                        direccion.Coordenadas = dr["COORDENADAS"].ToString();
                        
                        lista.Add(direccion);
                    }
                }


                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }



        }

        public static Direcciones DevolverDireccion(string direccion)
        {
            try
            {
                Direcciones d = new Direcciones();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [DIRECCION]
                                      ,[COORDENADAS]
                                    FROM [dbo].[Direcciones] where [DIRECCION] = @direccion";

                cmd.Parameters.AddWithValue("direccion", direccion);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        d.Direccion = dr["DIRECCION"].ToString();
                        d.Coordenadas = dr["COORDENADAS"].ToString();
                    }
                }


                conexion.Close();

                return d;
            }
            catch (Exception ex)
            {

                throw;
            }



        }
    }
}
