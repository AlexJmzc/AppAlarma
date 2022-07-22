using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class UsuarioDatos
    {
        public static bool IniciarSesion(string usuario, string clave)
        {

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT [NOMBRE_USU]
                              ,[CLAVE_USU]
                              FROM [dbo].[Usuarios]
                              WHERE NOMBRE_USU = @usuario AND CLAVE_USU = @clave";

            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("clave", clave);


            using (var dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    return true;
                }

            }
            return false;

        }

        public static List<Usuario> DevolverListaUsuarios()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_USU]
                                      ,[NOMBRE_USU]
                                      ,[CLAVE_USU]
                                      ,[ROL_USU]
                                      ,[CEDULA_USU]
                                      ,[NOMBRE_CLI]
                                      ,[APELLIDO_CLI]
                                      ,[TELEFONO_CLI]
                                      ,[ID_EMPRESA]
                                    FROM [dbo].[Usuarios]";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Usuario usu = new Usuario();
                        usu.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        usu.CEDULA_USU = dr["CEDULA_USU"].ToString();
                        usu.NOMBRE_CLI = dr["NOMBRE_CLI"].ToString();
                        usu.APELLIDO_CLI = dr["APELLIDO_CLI"].ToString();
                        usu.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        usu.TELEFONO_CLI = dr["TELEFONO_CLI"].ToString();
                        usu.NOMBRE_USU = dr["NOMBRE_USU"].ToString();
                        usu.CLAVE_USU = dr["CLAVE_USU"].ToString();
                        usu.ROL_USU = dr["ROL_USU"].ToString();
                        usu.ESTADO = dr["ESTADO"].ToString();
                        lista.Add(usu);
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

        public static List<Usuario> DevolverListaUsuariosEstado(string estado)
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_USU]
                                      ,[NOMBRE_USU]
                                      ,[CLAVE_USU]
                                      ,[ROL_USU]
                                      ,[CEDULA_USU]
                                      ,[NOMBRE_CLI]
                                      ,[APELLIDO_CLI]
                                      ,[TELEFONO_CLI]
                                      ,[ID_EMPRESA]
                                      ,[ESTADO]
                                    FROM [dbo].[Usuarios] WHERE [ESTADO] = @estado";

                cmd.Parameters.AddWithValue("estado", estado);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Usuario usu = new Usuario();
                        usu.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        usu.CEDULA_USU = dr["CEDULA_USU"].ToString();
                        usu.NOMBRE_CLI = dr["NOMBRE_CLI"].ToString();
                        usu.APELLIDO_CLI = dr["APELLIDO_CLI"].ToString();
                        usu.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        usu.TELEFONO_CLI = dr["TELEFONO_CLI"].ToString();
                        usu.NOMBRE_USU = dr["NOMBRE_USU"].ToString();
                        usu.CLAVE_USU = dr["CLAVE_USU"].ToString();
                        usu.ROL_USU = dr["ROL_USU"].ToString();
                        usu.ESTADO = dr["ESTADO"].ToString();
                        lista.Add(usu);
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


        public static List<Usuario> DevolverListaUsuariosEmpresa(int id)
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_USU]
                                      ,[NOMBRE_USU]
                                      ,[CLAVE_USU]
                                      ,[ROL_USU]
                                      ,[CEDULA_USU]
                                      ,[NOMBRE_CLI]
                                      ,[APELLIDO_CLI]
                                      ,[TELEFONO_CLI]
                                      ,[ID_EMPRESA]
                                      ,[ESTADO]
                                    FROM [dbo].[Usuarios] WHERE [ID_EMPRESA] = @id";

                cmd.Parameters.AddWithValue("id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Usuario usu = new Usuario();
                        usu.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        usu.CEDULA_USU = dr["CEDULA_USU"].ToString();
                        usu.NOMBRE_CLI = dr["NOMBRE_CLI"].ToString();
                        usu.APELLIDO_CLI = dr["APELLIDO_CLI"].ToString();
                        usu.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        usu.TELEFONO_CLI = dr["TELEFONO_CLI"].ToString();
                        usu.NOMBRE_USU = dr["NOMBRE_USU"].ToString();
                        usu.CLAVE_USU = dr["CLAVE_USU"].ToString();
                        usu.ROL_USU = dr["ROL_USU"].ToString();
                        usu.ESTADO = dr["ESTADO"].ToString();
                        lista.Add(usu);
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

        public static Usuario DevolverUsuarioNombreUsu(string nombre_usuario)
        {
            try
            {
                Usuario usu = new Usuario();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_USU]
                                      ,[NOMBRE_USU]
                                      ,[CLAVE_USU]
                                      ,[ROL_USU]
                                      ,[CEDULA_USU]
                                      ,[NOMBRE_CLI]
                                      ,[APELLIDO_CLI]
                                      ,[TELEFONO_CLI]
                                      ,[ID_EMPRESA]
                                      ,[ESTADO]
                                    FROM [dbo].[Usuarios] WHERE [NOMBRE_USU] = @nombre_usu";

                cmd.Parameters.AddWithValue("nombre_usu", nombre_usuario);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        usu.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        usu.CEDULA_USU = dr["CEDULA_USU"].ToString();
                        usu.NOMBRE_CLI = dr["NOMBRE_CLI"].ToString();
                        usu.APELLIDO_CLI = dr["APELLIDO_CLI"].ToString();
                        usu.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        usu.TELEFONO_CLI = dr["TELEFONO_CLI"].ToString();
                        usu.NOMBRE_USU = dr["NOMBRE_USU"].ToString();
                        usu.CLAVE_USU = dr["CLAVE_USU"].ToString();
                        usu.ROL_USU = dr["ROL_USU"].ToString();
                        usu.ESTADO = dr["ESTADO"].ToString();
                    }
                }

                conexion.Close();

                return usu;

            }
            catch (Exception ex)
            {

                throw;
            }



        }


        public static Usuario DevolverUsuarioCedula(string cedula)
        {
            try
            {
                Usuario usu = new Usuario();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_USU]
                                      ,[NOMBRE_USU]
                                      ,[CLAVE_USU]
                                      ,[ROL_USU]
                                      ,[CEDULA_USU]
                                      ,[NOMBRE_CLI]
                                      ,[APELLIDO_CLI]
                                      ,[TELEFONO_CLI]
                                      ,[ID_EMPRESA]
                                      ,[ESTADO]
                                    FROM [dbo].[Usuarios] WHERE [CEDULA_USU] = @cedula";

                cmd.Parameters.AddWithValue("cedula", cedula);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        usu.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        usu.CEDULA_USU = dr["CEDULA_USU"].ToString();
                        usu.NOMBRE_CLI = dr["NOMBRE_CLI"].ToString();
                        usu.APELLIDO_CLI = dr["APELLIDO_CLI"].ToString();
                        usu.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        usu.TELEFONO_CLI = dr["TELEFONO_CLI"].ToString();
                        usu.NOMBRE_USU = dr["NOMBRE_USU"].ToString();
                        usu.CLAVE_USU = dr["CLAVE_USU"].ToString();
                        usu.ROL_USU = dr["ROL_USU"].ToString();
                        usu.ESTADO = dr["ESTADO"].ToString();
                    }

                }

                conexion.Close();

                return usu;

            }
            catch (Exception ex)
            {

                throw;
            }



        }


        public static Usuario DevolverUsuarioID(int id)
        {
            try
            {
                Usuario usu = new Usuario();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_USU]
                                      ,[NOMBRE_USU]
                                      ,[CLAVE_USU]
                                      ,[ROL_USU]
                                      ,[CEDULA_USU]
                                      ,[NOMBRE_CLI]
                                      ,[APELLIDO_CLI]
                                      ,[TELEFONO_CLI]
                                      ,[ID_EMPRESA]
                                      ,[ESTADO]
                                    FROM [dbo].[Usuarios] WHERE [ID_USU] = @id";

                cmd.Parameters.AddWithValue("id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        usu.ID_USU = Convert.ToInt32(dr["ID_USU"].ToString());
                        usu.CEDULA_USU = dr["CEDULA_USU"].ToString();
                        usu.NOMBRE_CLI = dr["NOMBRE_CLI"].ToString();
                        usu.APELLIDO_CLI = dr["APELLIDO_CLI"].ToString();
                        usu.ID_EMPRESA = Convert.ToInt32(dr["ID_EMPRESA"].ToString());
                        usu.TELEFONO_CLI = dr["TELEFONO_CLI"].ToString();
                        usu.NOMBRE_USU = dr["NOMBRE_USU"].ToString();
                        usu.CLAVE_USU = dr["CLAVE_USU"].ToString();
                        usu.ROL_USU = dr["ROL_USU"].ToString();
                        usu.ESTADO = dr["ESTADO"].ToString();
                    }

                }

                conexion.Close();

                return usu;

            }
            catch (Exception ex)
            {

                throw;
            }



        }

        public static Usuario Nuevo(Usuario usu)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO [dbo].[Usuarios]
                                 ([NOMBRE_USU]
                                 ,[CLAVE_USU]
                                 ,[ROL_USU]
                                 ,[CEDULA_USU]
                                 ,[NOMBRE_CLI]
                                 ,[APELLIDO_CLI]
                                 ,[TELEFONO_CLI]
                                 ,[ID_EMPRESA]
                                 ,[ESTADO])
                                VALUES
                                (@nombreUsuario
                                ,@claveUsuario
                                ,@rolUsuario
                                ,@cedulaUsuario
                                ,@nombrecliente
                                ,@apellidocliente                                                                
                                ,@telefonocliente
                                ,@idEmpresa
                                ,@estado);
                                SELECT SCOPE_IDENTITY();";

                cmd.Parameters.AddWithValue("@nombreUsuario", usu.NOMBRE_USU);
                cmd.Parameters.AddWithValue("@claveUsuario", usu.CLAVE_USU);
                cmd.Parameters.AddWithValue("@rolUsuario", usu.ROL_USU);
                cmd.Parameters.AddWithValue("@cedulaUsuario", usu.CEDULA_USU);
                cmd.Parameters.AddWithValue("@nombreCliente", usu.NOMBRE_CLI);
                cmd.Parameters.AddWithValue("@apellidoCliente", usu.APELLIDO_CLI);
                cmd.Parameters.AddWithValue("@telefonoCliente", usu.TELEFONO_CLI);
                cmd.Parameters.AddWithValue("@idEmpresa", usu.ID_EMPRESA);
                cmd.Parameters.AddWithValue("@estado", usu.ESTADO);

                int idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
                usu.ID_USU = idUsuario;
                conexion.Close();

                return usu;


            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static Usuario ActualizarUsuario(Usuario usu)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Usuarios]
                             SET 
                                 [NOMBRE_USU] = @nombreUsu,
                                 [CLAVE_USU] = @claveUsu,
                                 [ROL_USU] = @rolUsu,
                                 [NOMBRE_CLI] = @nombreCli,
                                 [APELLIDO_CLI] = @apellidoCli,
                                 [TELEFONO_CLI] = @telefonoCli,
                                 [ID_EMPRESA] = @idEmpresa,
                                 [ESTADO] = @estado
                             WHERE [CEDULA_USU] = @cedula AND [ID_USU] = @idUsuario";

            cmd.Parameters.AddWithValue("@idUsuario", usu.ID_USU);
            cmd.Parameters.AddWithValue("@cedula", usu.CEDULA_USU);
            cmd.Parameters.AddWithValue("@nombreUsu", usu.NOMBRE_USU);
            cmd.Parameters.AddWithValue("@claveUsu", usu.CLAVE_USU);
            cmd.Parameters.AddWithValue("@rolUsu", usu.ROL_USU);
            cmd.Parameters.AddWithValue("@nombreCli", usu.NOMBRE_CLI);
            cmd.Parameters.AddWithValue("@apellidoCLi", usu.APELLIDO_CLI);
            cmd.Parameters.AddWithValue("@telefonoCli", usu.TELEFONO_CLI);
            cmd.Parameters.AddWithValue("@idEmpresa", usu.ID_EMPRESA);
            cmd.Parameters.AddWithValue("@estado", usu.ESTADO);

            cmd.ExecuteNonQuery();



            conexion.Close();

            return usu;
        }

        public static Usuario ActualizarEstadoUsuario(Usuario usu)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Usuarios]
                             SET 
                                 
                                 [ESTADO] = @estado
                             WHERE [ID_USU] = @idUsuario";

            cmd.Parameters.AddWithValue("@idUsuario", usu.ID_USU);
            cmd.Parameters.AddWithValue("@estado", usu.ESTADO);

            cmd.ExecuteNonQuery();



            conexion.Close();

            return usu;
        }

        public static void EliminarUsuario(int id)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"DELETE [dbo].[Usuarios]
                             WHERE [ID_USU] = @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }



    }
}
