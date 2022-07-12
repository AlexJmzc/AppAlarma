using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class DireccionLogica
    {

        public static List<Direcciones> DevolverListaDirecciones()
        {
            return DireccionesDatos.DevolverListaDirecciones();
        }

        public static Direcciones DevolverDireccion(string direccion)
        {
            return DireccionesDatos.DevolverDireccion(direccion);
        }
    }
}
