using Datos;
using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class UsuarioLogica
    {
        public static bool IniciarSesion(string usuario, string clave)
        {
            return UsuarioDatos.IniciarSesion(usuario, clave);
        }

        public static List<Usuario> DevolverListaUsuariosEstado(string estado)
        {
            return UsuarioDatos.DevolverListaUsuariosEstado(estado);
        }

        public static Usuario DevolverUsuarioID(int id)
        {
            return UsuarioDatos.DevolverUsuarioID(id);
        }

        public static Usuario ActualizarEstadoUsuario(Usuario usu)
        {
            return UsuarioDatos.ActualizarEstadoUsuario(usu);
        }

        public static List<Usuario> DevolverListaUsuarios()
        {
            return UsuarioDatos.DevolverListaUsuarios();
        }

        public static List<Usuario> DevolverListaUsuariosEmpresa(int id)
        {
            return UsuarioDatos.DevolverListaUsuariosEmpresa(id);
        }

        public static Usuario DevolverUsuarioNombreUsu(string nombre_usuario)
        {
            return UsuarioDatos.DevolverUsuarioNombreUsu(nombre_usuario);
        }

        public static Usuario DevolverUsuarioCedula(string cedula)
        {
            return UsuarioDatos.DevolverUsuarioCedula(cedula);
        }

        public static Usuario Nuevo(Usuario usu)
        {
            return UsuarioDatos.Nuevo(usu);
        }

        public static Usuario ActualizarUsuario(Usuario usu)
        {
            return UsuarioDatos.ActualizarUsuario(usu);
        }

        public static void EliminarUsuario(int id)
        {
            UsuarioDatos.EliminarUsuario(id);
        }
    }
}
