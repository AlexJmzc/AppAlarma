using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Direcciones
    {
        public Direcciones()
        {

        }

        public Direcciones(string direccion, string coordenadas)
        {
            Direccion = direccion;
            Coordenadas = coordenadas;
        }

        public string Direccion { get; set; }
        public string Coordenadas { get; set; }
    }
}
