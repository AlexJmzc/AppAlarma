using Entidades;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFServiciosApp
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiciosApp" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiciosApp
    {
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODOS DE LISTAR

        //EMPRESAS

        //TODA LA LISTA DE EMPRESAS
        [OperationContract]
        [WebGet(UriTemplate = "ListaEmpresas",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Empresa> DevolverListaEmpresas();


        //EMPRESA POR ID
        [OperationContract]
        [WebInvoke(UriTemplate = "DevolverEmpresa?id={id}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Empresa DevolverEmpresa(int id);



        //USUARIOS

        //LISTA DE TODOS LOS USUARIOS
        [OperationContract]
        [WebGet(UriTemplate = "ListaUsuarios",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> DevolverListaUsuarios();


        //LISTA DE USUARIOS POR EMPRESA
        [OperationContract]
        [WebInvoke(UriTemplate = "ListaUsuariosEmpresa?idEmpresa={idEmpresa}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> DevolverListaUsuariosEmpresa(int idEmpresa);


        //USUARIO POR NOMBRE DE USUARIO
        [OperationContract]
        [WebInvoke(UriTemplate = "UsuarioNombreUsu?nombreUsuario={nombreUsuario}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Usuario DevolverUsuarioNombreUsu(string nombreUsuario);


        //USUARIO POR CEDULA
        [OperationContract]
        [WebInvoke(UriTemplate = "UsuarioCedula?cedula={cedula}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Usuario DevolverUsuarioCedula(string cedula);



        //INCIDENCIAS


        //LISTA DE TODAS LAS INCIDENCIAS
        [OperationContract]
        [WebGet(UriTemplate = "ListaIncidencias",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Incidencia> DevolverListaIncidencias();


        //LISTA DE INCIDENCIAS POR EMPRESA
        [OperationContract]
        [WebInvoke(UriTemplate = "ListaIncidenciasEmpresa?idEmpresa={idEmpresa}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Incidencia> DevolverListaIncidenciasEmpresa(int idEmpresa);


        //LISTA DE INCIDENCIAS POR USUARIO
        [OperationContract]
        [WebInvoke(UriTemplate = "ListaIncidenciasUsuario?idUsuario={idUsuario}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Incidencia> DevolverListaIncidenciasUsuario(int idUsuario);


        //LISTA DE INCIDENCIAS POR NOMBRE DE EMPRESA
        [OperationContract]
        [WebInvoke(UriTemplate = "ListaIncidenciasNombreEmpresa?nombreEmpresa={nombreEmpresa}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Incidencia> DevolverListaIncidenciasNombreEmpresa(string nombreEmpresa);


        //LISTA DE INCIDENCIAS POR FECHA
        [OperationContract]
        [WebInvoke(UriTemplate = "ListaIncidenciasFecha?fecha={fecha}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Incidencia> DevolverListaIncidenciasFecha(DateTime fecha);


        //LISTA DE INCIDENCIAS POR COORDENADAS
        [OperationContract]
        [WebInvoke(UriTemplate = "ListaIncidenciasCoordenadas?coordenadasEmpresa={coordenadasEmpresa}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Incidencia> DevolverListaIncidenciasCoordenadas(string coordenadasEmpresa);


        //LISTA DE INCIDENCIAS POR ESTADO
        [OperationContract]
        [WebInvoke(UriTemplate = "ListaIncidenciasEstado?estado={estado}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Incidencia> DevolverListaIncidenciasEstado(string estado);


        //INCIDENCIA POR ID 
        [OperationContract]
        [WebInvoke(UriTemplate = "IncidenciaID?idIncidencia={idIncidencia}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Incidencia DevolverIncidenciaID(int idIncidencia);


//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
       
        //METODOS NUEVO


        //EMPRESA
        [OperationContract]
        [WebInvoke(UriTemplate = "NuevaEmpresa?nombreEmpresa={nombreEmpresa}&direccionEmpresa={direccionEmpresa}" +
            "&coordenadasEmpresa={coordenadasEmpresa}&descripcionEmpresa={descripcionEmpresa}&telefonoEmpresa={telefonoEmpresa}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Empresa NuevaEmpresa(string nombreEmpresa, string direccionEmpresa, string coordenadasEmpresa, string descripcionEmpresa, string telefonoEmpresa);


        //INCIDENCIA
        [OperationContract]
        [WebInvoke(UriTemplate = "NuevaIncidencia?idUsuario={idUsuario}&idEmpresa={idEmpresa}" +
            "&nombreEmpresa={nombreEmpresa}&coordenadasEmpresa={coordenadasEmpresa}&fecha={fecha}&estado={estado}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Incidencia NuevaIncidencia(int idUsuario, int idEmpresa, string nombreEmpresa, string coordenadasEmpresa, DateTime fecha, string estado);


        //USUARIO
        [OperationContract]
        [WebInvoke(UriTemplate = "NuevoUsuario?nombreUsuario={nombreUsuario}&claveUsuario={claveUsuario}" +
            "&rolUsuario={rolUsuario}&cedula={cedula}&nombre={nombre}&apellido={apellido}" +
            "&telefono={telefono}&idEmpresa={idEmpresa}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Usuario NuevoUsuario(string nombreUsuario, string claveUsuario, string rolUsuario, string cedula, string nombre, string apellido, string telefono, int idEmpresa);
        
        
        
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
        
        //MÉTODOS ACTUALIZAR  
        

        //EMPRESA
        [OperationContract]
        [WebInvoke(UriTemplate = "ActualizarEmpresa?idEmpresa={idEmpresa}& nombreEmpresa={nombreEmpresa}&direccionEmpresa={direccionEmpresa}" +
            "&coordenadasEmpresa={coordenadasEmpresa}&descripcionEmpresa={descripcionEmpresa}" +
            "&telefonoEmpresa={telefonoEmpresa}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Empresa ActualizarEmpresa(int idEmpresa, string nombreEmpresa, string direccionEmpresa, string coordenadasEmpresa, string descripcionEmpresa, string telefonoEmpresa);


        //USUARIO
        [OperationContract]
        [WebInvoke(UriTemplate = "ActualizarUsuario?idUsuario={idUsuario}& nombreUsuario={nombreUsuario}&claveUsuario={claveUsuario}" +
            "&rolUsuario={rolUsuario}&cedula={cedula}" +
            "&nombre={nombre}&apellido={apellido}&telefono={telefono}&idEmpresa={idEmpresa}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Usuario ActualizarUsuario(int idUsuario, string nombreUsuario, string claveUsuario, string rolUsuario, string cedula, string nombre, string apellido, string telefono, int idEmpresa);


        //INCIDENCIA
        [OperationContract]
        [WebInvoke(UriTemplate = "ActualizarEstadoIncidencia?idIncidencia={idIncidencia}&estado={estado}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void ActualizarEstado(int idIncidencia, string estado);



//------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        //MÉTODOS ELIMINAR


        //EMPRESA
        [OperationContract]
        [WebInvoke(UriTemplate = "EliminarEmpresa?idEmpresa={idEmpresa}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void EliminarEmpresa(int idEmpresa);


        //USUARIO
        [OperationContract]
        [WebInvoke(UriTemplate = "EliminarUsuario?idUsuario={idUsuario}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void EliminarUsuario(int idUsuario);


        //INCIDENCIA
        [OperationContract]
        [WebInvoke(UriTemplate = "EliminarIncidencia?idIncidencia={idIncidencia}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void EliminarIncidencia(int idIncidencia);



//----------------------------------------------------------------------------------------------------------------------------------------------------------
        
        //MÉTODO INICIAR SESIÓN

        [OperationContract]
        [WebInvoke(UriTemplate = "IniciarSesion?usuario={usuario}&clave={clave}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        bool IniciarSesion(string usuario, string clave);  
        
    }
}
