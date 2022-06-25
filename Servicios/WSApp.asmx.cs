using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace Servicios
{
    /// <summary>
    /// Descripción breve de WSApp
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSApp : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Empresa> DevolverListaEmpresas()
        {
            return EmpresaLogica.DevolverListaEmpresas();
        }

        [WebMethod]
        public Empresa DevolverEmpresa(int id)
        {
            return EmpresaLogica.DevolverEmpresa(id);
        }

        [WebMethod]
        public Empresa NuevaEmpresa(string nombre, string direccion, string coordenadas, string descripcion, string telefono)
        {
            Empresa empresa = new Empresa(nombre, direccion, coordenadas, descripcion, telefono);
            return EmpresaLogica.NuevaEmpresa(empresa);
        }

        [WebMethod]
        public Empresa Actualizar(int id, string nombre, string direccion, string coordenadas, string descripcion, string telefono)
        {
            Empresa empresa = new Empresa(id, nombre, direccion, coordenadas, descripcion, telefono);
            return EmpresaLogica.Actualizar(empresa);
        }

        [WebMethod]
        public void EliminarEmpresa(int id)
        {
            EmpresaLogica.EliminarEmpresa(id);
        }

        [WebMethod]
        public bool IniciarSesion(string usuario, string clave)
        {
            return UsuarioLogica.IniciarSesion(usuario, clave);
        }

        [WebMethod]
        public List<Usuario> DevolverListaUsuarios()
        {
            return UsuarioLogica.DevolverListaUsuarios();
        }

        [WebMethod]
        public List<Usuario> DevolverListaUsuariosEmpresa(int id)
        {
            return UsuarioLogica.DevolverListaUsuariosEmpresa(id);
        }

        [WebMethod]
        public Usuario DevolverUsuarioNombreUsu(string nombre_usuario)
        {
            return UsuarioLogica.DevolverUsuarioNombreUsu(nombre_usuario);
        }

        [WebMethod]
        public Usuario DevolverUsuarioCedula(string cedula)
        {
            return UsuarioLogica.DevolverUsuarioCedula(cedula);
        }

        [WebMethod]
        public Usuario Nuevo(string nombreUsu, string clave, string rol, string cedula, string nombre, string apellido, string telefono, int idEmpresa)
        {
            Usuario usu = new Usuario(nombreUsu, clave, rol, cedula, nombre, apellido, telefono, idEmpresa);
            return UsuarioLogica.Nuevo(usu);
        }

        [WebMethod]
        public Usuario ActualizarUsuario(int id, string nombreUsu, string clave, string rol, string cedula, string nombre, string apellido, string telefono, int idEmpresa)
        {
            Usuario usu = new Usuario(id, nombreUsu, clave, rol, cedula, nombre, apellido, telefono, idEmpresa);
            return UsuarioLogica.ActualizarUsuario(usu);
        }

        [WebMethod]
        public void EliminarUsuario(int id)
        {
            UsuarioLogica.EliminarUsuario(id);
        }

        [WebMethod]
        public List<Incidencia> DevolverListaIncidencias()
        {
            return IncidenciaLogica.DevolverListaIncidencias();
        }

        [WebMethod]
        public List<Incidencia> DevolverListaIncidenciasEmpresa(int id)
        {
            return IncidenciaLogica.DevolverListaIncidenciasEmpresa(id);
        }

        [WebMethod]
        public List<Incidencia> DevolverListaIncidenciasUsuario(int id)
        {
            return IncidenciaLogica.DevolverListaIncidenciasUsuario(id);
        }

        [WebMethod]
        public List<Incidencia> DevolverListaIncidenciasNombreEmpresa(string nombre)
        {
            return IncidenciaLogica.DevolverListaIncidenciasNombreEmpresa(nombre);
        }

        [WebMethod]
        public List<Incidencia> DevolverListaIncidenciasFecha(DateTime fecha)
        {
            return IncidenciaLogica.DevolverListaIncidenciasFecha(fecha);
        }

        [WebMethod]
        public List<Incidencia> DevolverListaIncidenciasCoordenadas(string coordenadas)
        {
            return IncidenciaLogica.DevolverListaIncidenciasCoordenadas(coordenadas);
        }

        [WebMethod]
        public List<Incidencia> DevolverListaIncidenciasEstado(string estado)
        {
            return IncidenciaLogica.DevolverListaIncidenciasEstado(estado);
        }

        [WebMethod]
        public Incidencia DevolverIncidenciaID(int id)
        {
            return IncidenciaLogica.DevolverIncidenciaID(id);
        }

        [WebMethod]
        public Incidencia Nuevo(int idUsuario, int idEmpresa, string nombreEmpresa, string coordenadas, DateTime fecha, string estado)
        {
            Incidencia incidencia = new Incidencia(idUsuario, idEmpresa, nombreEmpresa, coordenadas, fecha, estado);
            return IncidenciaLogica.Nuevo(incidencia);
        }

        [WebMethod]
        public void ActualizarEstado(int id, string estado)
        {
            IncidenciaLogica.ActualizarEstado(id, estado);
        }

        [WebMethod]
        public void EliminarIncidencia(int id)
        {
            IncidenciaLogica.EliminarIncidencia(id);
        }

    }
}
