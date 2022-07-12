using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class EmpresaDatos
    {

        public static List<Empresa> DevolverListaEmpresas()
        {
            try
            {
                List<Empresa> lista = new List<Empresa>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_EMP]
                                      ,[NOMBRE_EMP]
                                      ,[DIRECCION_EMP]
                                      ,[COORDENADAS_EMP]
                                      ,[DESCRIPCION_EMP]
                                      ,[TELEFONO_EMP]
                                      ,[ESTADO]
                                    FROM [dbo].[Empresas]";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Empresa empresa = new Empresa();
                        empresa.ID_EMP = Convert.ToInt32(dr["ID_EMP"].ToString());
                        empresa.NOMBRE_EMP = dr["NOMBRE_EMP"].ToString();
                        empresa.DIRECCION_EMP = dr["DIRECCION_EMP"].ToString();
                        empresa.COORDENADAS_EMP = dr["COORDENADAS_EMP"].ToString();
                        empresa.DESCRIPCION_EMP = dr["DESCRIPCION_EMP"].ToString();
                        empresa.TELEFONO_EMP = dr["TELEFONO_EMP"].ToString();
                        empresa.ESTADO = dr["ESTADO"].ToString();

                        lista.Add(empresa);
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


        public static List<Empresa> DevolverListaEmpresasEstado(string estado)
        {
            try
            {
                List<Empresa> lista = new List<Empresa>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_EMP]
                                      ,[NOMBRE_EMP]
                                      ,[DIRECCION_EMP]
                                      ,[COORDENADAS_EMP]
                                      ,[DESCRIPCION_EMP]
                                      ,[TELEFONO_EMP]
                                      ,[ESTADO]
                                    FROM [dbo].[Empresas]
                                    WHERE [ESTADO] = @estado";

                cmd.Parameters.AddWithValue("@estado", estado);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Empresa empresa = new Empresa();
                        empresa.ID_EMP = Convert.ToInt32(dr["ID_EMP"].ToString());
                        empresa.NOMBRE_EMP = dr["NOMBRE_EMP"].ToString();
                        empresa.DIRECCION_EMP = dr["DIRECCION_EMP"].ToString();
                        empresa.COORDENADAS_EMP = dr["COORDENADAS_EMP"].ToString();
                        empresa.DESCRIPCION_EMP = dr["DESCRIPCION_EMP"].ToString();
                        empresa.TELEFONO_EMP = dr["TELEFONO_EMP"].ToString();
                        empresa.ESTADO = dr["ESTADO"].ToString();

                        lista.Add(empresa);
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

        public static Empresa DevolverEmpresa(int id)
        {
            try
            {
                Empresa empresa = new Empresa();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_EMP]
                                      ,[NOMBRE_EMP]
                                      ,[DIRECCION_EMP]
                                      ,[COORDENADAS_EMP]
                                      ,[DESCRIPCION_EMP]
                                      ,[TELEFONO_EMP]
                                      ,[ESTADO]
                                    FROM [dbo].[Empresas] WHERE [ID_EMP] = @id";

                cmd.Parameters.AddWithValue("id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        empresa.ID_EMP = Convert.ToInt32(dr["ID_EMP"].ToString());
                        empresa.NOMBRE_EMP = dr["NOMBRE_EMP"].ToString();
                        empresa.DIRECCION_EMP = dr["DIRECCION_EMP"].ToString();
                        empresa.COORDENADAS_EMP = dr["COORDENADAS_EMP"].ToString();
                        empresa.DESCRIPCION_EMP = dr["DESCRIPCION_EMP"].ToString();
                        empresa.TELEFONO_EMP = dr["TELEFONO_EMP"].ToString();
                        empresa.ESTADO = dr["ESTADO"].ToString();
                    }
                }


                conexion.Close();

                return empresa;
            }
            catch (Exception ex)
            {

                throw;
            }



        }


        public static Empresa NuevaEmpresa(Empresa empresa)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO [dbo].[Empresas]
                                 ([NOMBRE_EMP]
                                 ,[DIRECCION_EMP]
                                 ,[COORDENADAS_EMP]
                                 ,[DESCRIPCION_EMP]
                                 ,[TELEFONO_EMP]
                                 ,[ESTADO])
                                VALUES
                                (@nombreEmpresa
                                ,@direccionEmpresa
                                ,@coordenadasEmpresa
                                ,@descripcionEmpresa
                                ,@telefonoEmpresa
                                ,@estado);
                                SELECT SCOPE_IDENTITY();";

                cmd.Parameters.AddWithValue("@nombreEmpresa", empresa.NOMBRE_EMP);
                cmd.Parameters.AddWithValue("@direccionEmpresa", empresa.DIRECCION_EMP);
                cmd.Parameters.AddWithValue("@coordenadasEmpresa", empresa.COORDENADAS_EMP);
                cmd.Parameters.AddWithValue("@descripcionEmpresa", empresa.DESCRIPCION_EMP);
                cmd.Parameters.AddWithValue("@telefonoEmpresa", empresa.TELEFONO_EMP);
                cmd.Parameters.AddWithValue("@estado", empresa.ESTADO);


                int idEmpresa = Convert.ToInt32(cmd.ExecuteScalar());
                empresa.ID_EMP = idEmpresa;
                conexion.Close();

                return empresa;



            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static Empresa Actualizar(Empresa empresa)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Empresas]
                             SET [NOMBRE_EMP] = @nombreEmpresa,
                                 [DIRECCION_EMP] = @direccionEmpresa,
                                 [COORDENADAS_EMP] = @coordenadasEmpresa,
                                 [DESCRIPCION_EMP] = @descripcionEmpresa,
                                 [TELEFONO_EMP] = @telefonoEmpresa,
                                 [ESTADO] = @estado
                             WHERE [ID_EMP] = @id";

            cmd.Parameters.AddWithValue("@id", empresa.ID_EMP);
            cmd.Parameters.AddWithValue("@nombreEmpresa", empresa.NOMBRE_EMP);
            cmd.Parameters.AddWithValue("@direccionEmpresa", empresa.DIRECCION_EMP);
            cmd.Parameters.AddWithValue("@coordenadasEmpresa", empresa.COORDENADAS_EMP);
            cmd.Parameters.AddWithValue("@descripcionEmpresa", empresa.DESCRIPCION_EMP);
            cmd.Parameters.AddWithValue("@telefonoEmpresa", empresa.TELEFONO_EMP);
            cmd.Parameters.AddWithValue("@estado", empresa.ESTADO);

            cmd.ExecuteNonQuery();



            conexion.Close();

            return empresa;
        }


        public static Empresa ActualizarEstado(Empresa empresa)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Empresas]
                             SET 
                                 [ESTADO] = @estado
                             WHERE [ID_EMP] = @id";

            cmd.Parameters.AddWithValue("@id", empresa.ID_EMP);
            
            cmd.Parameters.AddWithValue("@estado", empresa.ESTADO);

            cmd.ExecuteNonQuery();



            conexion.Close();

            return empresa;
        }

        public static void EliminarEmpresa(int id)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"DELETE [dbo].[Empresas]
                             WHERE [ID_EMP] = @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }
    }
}
