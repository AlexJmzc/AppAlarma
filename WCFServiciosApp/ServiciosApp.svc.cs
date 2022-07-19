using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace WCFServiciosApp
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiciosApp" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiciosApp.svc o ServiciosApp.svc.cs en el Explorador de soluciones e inicie la depuración.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiciosApp : IServiciosApp
    {
//--------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS DE LISTAR 

        //EMPRESAS

        //TODA LA LISTA DE EMPRESAS
        public List<Empresa> DevolverListaEmpresas()
        {
            return EmpresaLogica.DevolverListaEmpresas();
        }

        
        //EMPRESA POR ID
        public Empresa DevolverEmpresa(int id)
        {
            return EmpresaLogica.DevolverEmpresa(id);
        }

        public List<Empresa> DevolverListaEmpresasEstado(string estado)
        {
            return EmpresaLogica.DevolverListaEmpresasEstado(estado);
        }



        //USUARIOS


        //LISTA DE TODOS LOS USUARIOS
        public List<Usuario> DevolverListaUsuarios()
        {
            return UsuarioLogica.DevolverListaUsuarios();
        }


        //LISTA DE USUARIOS POR EMPRESA
        public List<Usuario> DevolverListaUsuariosEmpresa(int idEmpresa)
        {
            return UsuarioLogica.DevolverListaUsuariosEmpresa(idEmpresa);
        }


        //USUARIO POR NOMBRE DE USUARIO
        public Usuario DevolverUsuarioNombreUsu(string nombreUsuario)
        {
            return UsuarioLogica.DevolverUsuarioNombreUsu(nombreUsuario);
        }


        //USUARIO POR CEDULA
        public Usuario DevolverUsuarioCedula(string cedula)
        {
            return UsuarioLogica.DevolverUsuarioCedula(cedula);
        }


        //USUARIOS POR ESTADO
        public List<Usuario> DevolverListaUsuariosEstado(string estado)
        {
            return UsuarioLogica.DevolverListaUsuariosEstado(estado);
        }


        //USUARIO POR ID
        public Usuario DevolverUsuarioID(int id)
        {
            return UsuarioLogica.DevolverUsuarioID(id);
        }



        //INCIDENCIAS


        //LISTA DE TODAS LAS INCIDENCIAS
        public List<Incidencia> DevolverListaIncidencias()
        {
            return IncidenciaLogica.DevolverListaIncidencias();
        }


        //LISTA DE INCIDENCIAS POR EMPRESA
        public List<Incidencia> DevolverListaIncidenciasEmpresa(int idEmpresa)
        {
            return IncidenciaLogica.DevolverListaIncidenciasEmpresa(idEmpresa);
        }


        //LISTA DE INCIDENCIAS POR USUARIO
        public List<Incidencia> DevolverListaIncidenciasUsuario(int idUsuario)
        {
            return IncidenciaLogica.DevolverListaIncidenciasUsuario(idUsuario);
        }


        //LISTA DE INCIDENCIAS POR NOMBRE DE EMPRESA
        public List<Incidencia> DevolverListaIncidenciasNombreEmpresa(string nombreEmpresa)
        {
            return IncidenciaLogica.DevolverListaIncidenciasNombreEmpresa(nombreEmpresa);
        }


        //LISTA DE INCIDENCIAS POR FECHA
        public List<Incidencia> DevolverListaIncidenciasFecha(string fecha)
        {
            return IncidenciaLogica.DevolverListaIncidenciasFecha(fecha);
        }


        //LISTA DE INCIDENCIAS POR COORDENADAS
        public List<Incidencia> DevolverListaIncidenciasCoordenadas(string coordenadasEmpresa)
        {
            return IncidenciaLogica.DevolverListaIncidenciasCoordenadas(coordenadasEmpresa);
        }


        //LISTA DE INCIDENCIAS POR ESTADO
        public List<Incidencia> DevolverListaIncidenciasEstado(string estado)
        {
            return IncidenciaLogica.DevolverListaIncidenciasEstado(estado);
        }


        //INCIDENCIA POR ID 
        public Incidencia DevolverIncidenciaID(int idIncidencia)
        {
            return IncidenciaLogica.DevolverIncidenciaID(idIncidencia);
        }


        //INCIDENCIAS POR ESTADO Y FECHA
        public List<Incidencia> DevolverListaIncidenciasEstadoFecha(string estado, string fecha)
        {
            return IncidenciaLogica.DevolverListaIncidenciasEstadoFecha(estado, fecha);
        }


        //INCIDENCIAS POR EMPRESA Y FECHA
        public List<Incidencia> DevolverListaIncidenciasEmpresaFecha(string nombre, string fecha)
        {
            return IncidenciaLogica.DevolverListaIncidenciasEmpresaFecha(nombre, fecha);
        }


        //INCIDENCIAS POR EMPRESA Y ESTADO
        public List<Incidencia> DevolverListaIncidenciasEmpresaEstado(string nombre, string estado)
        {
            return IncidenciaLogica.DevolverListaIncidenciasEmpresaEstado(nombre, estado);
        }


        //INCIDENCIAS POR EMPRESA, ESTADO Y FECHA
        public List<Incidencia> DevolverListaIncidenciasEmpresaEstadoFecha(string nombre, string estado, string fecha)
        {
            return IncidenciaLogica.DevolverListaIncidenciasEmpresaEstadoFecha(nombre, estado, fecha);
        }



        //DIRECCIONES


        //LISTA DE TODAS LAS DIRECCIONES
        public List<Direcciones> DevolverListaDirecciones()
        {
            return DireccionLogica.DevolverListaDirecciones();
        }


        //DIRECCION POR ID
        public Direcciones DevolverDireccion(string direccion)
        {
            return DireccionLogica.DevolverDireccion(direccion);
        }


//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //MÉTODOS DE NUEVO

        //EMPRESA
        public Empresa NuevaEmpresa(string nombreEmpresa, string direccionEmpresa, string coordenadasEmpresa, string descripcionEmpresa, string telefonoEmpresa, string estado)
        {
            Empresa empresa = new Empresa(nombreEmpresa, direccionEmpresa, coordenadasEmpresa, descripcionEmpresa, telefonoEmpresa, estado);
            return EmpresaLogica.NuevaEmpresa(empresa);
        }



        //USUARIO
        public Usuario NuevoUsuario(string nombreUsuario, string claveUsuario, string rolUsuario, string cedula, string nombre, string apellido, string telefono, int idEmpresa, string estado)
        {
            Usuario usu = new Usuario(nombreUsuario, claveUsuario, rolUsuario, cedula, nombre, apellido, telefono, idEmpresa, estado);
            return UsuarioLogica.Nuevo(usu);
        }



        //INCIDENCIA
        public Incidencia NuevaIncidencia(int idUsuario, int idEmpresa, string nombreEmpresa, string coordenadasEmpresa, DateTime fecha, string estado)
        {
            Incidencia incidencia = new Incidencia(idUsuario, idEmpresa, nombreEmpresa, coordenadasEmpresa, fecha, estado);
            return IncidenciaLogica.Nuevo(incidencia);
        }



//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //MÉTODOS DE ACTUALIZAR

        //EMPRESA
        public Empresa ActualizarEmpresa(int idEmpresa, string nombreEmpresa, string direccionEmpresa, string coordenadasEmpresa, string descripcionEmpresa, string telefonoEmpresa, string estado)
        {
            Empresa empresa = new Empresa(idEmpresa, nombreEmpresa, direccionEmpresa, coordenadasEmpresa, descripcionEmpresa, telefonoEmpresa, estado);
            return EmpresaLogica.Actualizar(empresa);
        }


        public Empresa ActualizarEstadoEmpresa(int idEmpresa, string nombreEmpresa, string direccionEmpresa, string coordenadasEmpresa, string descripcionEmpresa, string telefonoEmpresa, string estado)
        {
            Empresa empresa = new Empresa(idEmpresa, nombreEmpresa, direccionEmpresa, coordenadasEmpresa, descripcionEmpresa, telefonoEmpresa, estado);
            return EmpresaLogica.ActualizarEstado(empresa);
        }



        //USUARIO
        public Usuario ActualizarUsuario(int idUsuario, string nombreUsuario, string claveUsuario, string rolUsuario, string cedula, string nombre, string apellido, string telefono, int idEmpresa)
        {
            Usuario usu = new Usuario(idUsuario, nombreUsuario, claveUsuario, rolUsuario, cedula, nombre, apellido, telefono, idEmpresa);
            return UsuarioLogica.ActualizarUsuario(usu);
        }


        public Usuario ActualizarEstadoUsuario(int idUsuario, string nombreUsuario, string claveUsuario, string rolUsuario, string cedula, string nombre, string apellido, string telefono, int idEmpresa)
        {
            Usuario usu = new Usuario(idUsuario, nombreUsuario, claveUsuario, rolUsuario, cedula, nombre, apellido, telefono, idEmpresa);
            return UsuarioLogica.ActualizarEstadoUsuario(usu);
        }



        //ACTUALIZAR ESTADO DE LA INCIDENCIA
        public void ActualizarEstado(int idIncidencia, string estado)
        {
            IncidenciaLogica.ActualizarEstado(idIncidencia, estado);
        }


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //MÉTODOS DE ELIMINAR

        //EMPRESA
        public void EliminarEmpresa(int idEmpresa)
        {
            EmpresaLogica.EliminarEmpresa(idEmpresa);
        }


        //USUARIO
        public void EliminarUsuario(int idUsuario)
        {
            UsuarioLogica.EliminarUsuario(idUsuario);
        }


        //INCIDENCIA
        public void EliminarIncidencia(int idIncidencia)
        {
            IncidenciaLogica.EliminarIncidencia(idIncidencia);
        }


//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //MÉTODO DE INICIAR SESIÓN

        public bool IniciarSesion(string usuario, string clave)
        {
            return UsuarioLogica.IniciarSesion(usuario, clave);
        }
       
        
    }
}
