using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class IncidenciaLogica
    {
        public static List<Incidencia> DevolverListaIncidencias()
        {
            return IncidenciaDatos.DevolverListaIncidencias();
        } //

        public static List<Incidencia> DevolverListaIncidenciasEmpresa(int id)
        {
            return IncidenciaDatos.DevolverListaIncidenciasEmpresa(id);
        } //

        public static List<Incidencia> DevolverListaIncidenciasUsuario(int id)
        {
            return IncidenciaDatos.DevolverListaIncidenciasUsuario(id);
        } //

        public static List<Incidencia> DevolverListaIncidenciasNombreEmpresa(string nombre)
        {
            return IncidenciaDatos.DevolverListaIncidenciasNombreEmpresa(nombre);
        } //

        public static List<Incidencia> DevolverListaIncidenciasFecha(string fecha)
        {
            return IncidenciaDatos.DevolverListaIncidenciasFecha(fecha);
        }//

        public static List<Incidencia> DevolverListaIncidenciasCoordenadas(string coordenadas)
        {
            return IncidenciaDatos.DevolverListaIncidenciasCoordenadas(coordenadas);
        }//

        public static List<Incidencia> DevolverListaIncidenciasEstado(string estado)
        {
            return IncidenciaDatos.DevolverListaIncidenciasEstado(estado);
        }//

        public static List<Incidencia> DevolverListaIncidenciasEstadoFecha(string estado, string fecha)
        {
            return IncidenciaDatos.DevolverListaIncidenciasEstadoFecha(estado, fecha);
        }//

        public static List<Incidencia> DevolverListaIncidenciasEmpresaFecha(string nombre, string fecha)
        {
            return IncidenciaDatos.DevolverListaIncidenciasEmpresaFecha(nombre, fecha);
        }//

        public static Incidencia DevolverIncidenciaID(int id)
        {
            return IncidenciaDatos.DevolverIncidenciaID(id);
        }//

        public static Incidencia Nuevo(Incidencia incidencia)
        {
            return IncidenciaDatos.Nuevo(incidencia);
        }//

        public static void ActualizarEstado(int id, string estado)
        {
            IncidenciaDatos.ActualizarEstado(id, estado);
        }//

        public static void EliminarIncidencia(int id)
        {
            IncidenciaDatos.EliminarIncidencia(id);
        }//

        public static List<Incidencia> DevolverListaIncidenciasEmpresaEstado(string nombre, string estado)
        {
            return IncidenciaDatos.DevolverListaIncidenciasEmpresaEstado(nombre, estado);
        }//

        public static List<Incidencia> DevolverListaIncidenciasEmpresaEstadoFecha(string nombre, string estado, string fecha)
        {
            return IncidenciaDatos.DevolverListaIncidenciasEmpresaEstadoFecha(nombre, estado, fecha);
        }
    }
}
