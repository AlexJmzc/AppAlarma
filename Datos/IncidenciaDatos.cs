using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class IncidenciaDatos
    {

        public static List<Incidencia> DevolverListaIncidencias()
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias]";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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

        public static List<Incidencia> DevolverListaIncidenciasEmpresa(int id)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [ID_EMPRESA] = @id";

                cmd.Parameters.AddWithValue("id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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

        public static List<Incidencia> DevolverListaIncidenciasUsuario(int id)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [ID_USU] = @id";

                cmd.Parameters.AddWithValue("id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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

        public static List<Incidencia> DevolverListaIncidenciasNombreEmpresa(string nombre)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [NOMBRE_EMPRESA] = @nombre";

                cmd.Parameters.AddWithValue("nombre", nombre);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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


        public static List<Incidencia> DevolverListaIncidenciasEmpresaFecha(string nombre, string fecha)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [NOMBRE_EMPRESA] = @nombre AND
                                                             [FECHA_INC] = @fecha";

                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("fecha", fecha);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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


        public static List<Incidencia> DevolverListaIncidenciasEstadoFecha(string estado, string fecha)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE
                                                             [ESTADO_INC] = @estado AND
                                                             [FECHA_INC] = @fecha";


                cmd.Parameters.AddWithValue("estado", estado);
                cmd.Parameters.AddWithValue("fecha", fecha);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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

        public static List<Incidencia> DevolverListaIncidenciasEmpresaEstado(string nombre, string estado)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [NOMBRE_EMPRESA] = @nombre AND
                                                             [ESTADO_INC] = @estado";

                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("estado", estado);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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


        public static List<Incidencia> DevolverListaIncidenciasEmpresaEstadoFecha(string nombre, string estado, string fecha)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [NOMBRE_EMPRESA] = @nombre AND
                                                             [ESTADO_INC] = @estado AND
                                                             [FECHA_INC] = @fecha";

                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("estado", estado);
                cmd.Parameters.AddWithValue("fecha", fecha);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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

        public static List<Incidencia> DevolverListaIncidenciasFecha(string fecha)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [FECHA_INC] LIKE @fecha";

                cmd.Parameters.AddWithValue("fecha", fecha);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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

        public static List<Incidencia> DevolverListaIncidenciasCoordenadas(string coordenadas)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [COORDENADAS] = @coordenadas";

                cmd.Parameters.AddWithValue("coordenadas", coordenadas);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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

        public static List<Incidencia> DevolverListaIncidenciasEstado(string estado)
        {
            try
            {
                List<Incidencia> lista = new List<Incidencia>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [ESTADO_INC] = @estado";

                cmd.Parameters.AddWithValue("estado", estado);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Incidencia incidencia = new Incidencia();
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                        lista.Add(incidencia);
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

        public static Incidencia DevolverIncidenciaID(int id)
        {
            try
            {
                Incidencia incidencia = new Incidencia();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_INCIDENCIA]
                                      ,[ID_USU]
                                      ,[ID_EMPRESA]
                                      ,[NOMBRE_EMPRESA]
                                      ,[COORDENADAS]
                                      ,[FECHA_INC]
                                      ,[ESTADO_INC]
                                    FROM [dbo].[Incidencias] WHERE [ID_INCIDENCIA] = @id";

                cmd.Parameters.AddWithValue("id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
         
                        incidencia.ID_INCIDENCIA = Convert.ToInt32(dr["ID_INCIDENCIA"].ToString());
                        incidencia.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        incidencia.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        incidencia.NOMBRE_EMPRESA = dr["NOMBRE_EMPRESA"].ToString();
                        incidencia.COORDENADAS = dr["COORDENADAS"].ToString();
                        incidencia.FECHA = Convert.ToDateTime(dr["FECHA_INC"].ToString());
                        incidencia.ESTADO = dr["ESTADO_INC"].ToString();
                       
                    }
                }


                conexion.Close();

                return incidencia;
            }
            catch (Exception ex)
            {

                throw;
            }



        }

        public static Incidencia Nuevo(Incidencia incidencia)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO [dbo].[Incidencias]
                                 ([ID_USU]
                                 ,[ID_EMPRESA]
                                 ,[NOMBRE_EMPRESA]
                                 ,[COORDENADAS]
                                 ,[FECHA_INC]
                                 ,[ESTADO_INC]
                                VALUES
                                (@idUsuario
                                ,@idEmpresa
                                ,@nombreEmpresa
                                ,@Coordenadas
                                ,@fecha
                                ,@estado)";

                cmd.Parameters.AddWithValue("@idUsuario", incidencia.ID_USU);
                cmd.Parameters.AddWithValue("@idEmpresa", incidencia.ID_EMPRESA);
                cmd.Parameters.AddWithValue("@nombreEmpresa", incidencia.NOMBRE_EMPRESA);
                cmd.Parameters.AddWithValue("@Coordenadas", incidencia.COORDENADAS);
                cmd.Parameters.AddWithValue("@fecha", incidencia.FECHA);
                cmd.Parameters.AddWithValue("@estado", incidencia.ESTADO);

                int idIncidencia = Convert.ToInt32(cmd.ExecuteScalar());
                incidencia.ID_INCIDENCIA = idIncidencia;

                return incidencia;

                cmd.ExecuteNonQuery();

                conexion.Close();

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static void ActualizarEstado(int id, string estado)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Incidencias]
                             SET [ESTADO_INC] = @estado
                             WHERE [ID_INCIDENCIA] = @id";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@estado", estado);

            cmd.ExecuteNonQuery();



            conexion.Close();
        }

        public static void EliminarIncidencia(int id)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"DELETE [dbo].[Incidencias]
                             WHERE [ID_INCIDENCIA] = @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }
    }
}
