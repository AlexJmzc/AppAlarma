using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class IncidenciaLogica
    {
        public static List<Incidencia> DevolverListaIncidencias()
        {
            return IncidenciaDatos.DevolverListaIncidencias();
        }

        public static List<Incidencia> DevolverListaIncidenciasEmpresa(int id)
        {
            return IncidenciaDatos.DevolverListaIncidenciasEmpresa(id);
        }

        public static List<Incidencia> DevolverListaIncidenciasUsuario(int id)
        {
            return IncidenciaDatos.DevolverListaIncidenciasUsuario(id);
        }

        public static List<Incidencia> DevolverListaIncidenciasNombreEmpresa(string nombre)
        {
            return IncidenciaDatos.DevolverListaIncidenciasNombreEmpresa(nombre);
        }

        public static List<Incidencia> DevolverListaIncidenciasFecha(DateTime fecha)
        {
            return IncidenciaDatos.DevolverListaIncidenciasFecha(fecha);
        }

        public static List<Incidencia> DevolverListaIncidenciasCoordenadas(string coordenadas)
        {
            return IncidenciaDatos.DevolverListaIncidenciasCoordenadas(coordenadas);
        }

        public static List<Incidencia> DevolverListaIncidenciasEstado(string estado)
        {
            return IncidenciaDatos.DevolverListaIncidenciasEstado(estado);
        }

        public static Incidencia DevolverIncidenciaID(int id)
        {
            return IncidenciaDatos.DevolverIncidenciaID(id);
        }

        public static Incidencia Nuevo(Incidencia incidencia)
        {
            return IncidenciaDatos.Nuevo(incidencia);
        }

        public static void ActualizarEstado(int id, string estado)
        {
            IncidenciaDatos.ActualizarEstado(id, estado);
        }

        public static void EliminarIncidencia(int id)
        {
            IncidenciaDatos.EliminarIncidencia(id);
        }
    }
}
