using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Incidencia
    {
        public Incidencia()
        {

        }

        public Incidencia(int iD_INCIDENCIA, int iD_USU, int iD_EMPRESA, string nOMBRE_EMPRESA, string cOORDENADAS, DateTime fECHA, string eSTADO)
        {
            ID_INCIDENCIA = iD_INCIDENCIA;
            ID_USU = iD_USU;
            ID_EMPRESA = iD_EMPRESA;
            NOMBRE_EMPRESA = nOMBRE_EMPRESA;
            COORDENADAS = cOORDENADAS;
            FECHA = fECHA;
            ESTADO = eSTADO;
        }

        public int ID_INCIDENCIA { get; set; }
        public int ID_USU { get; set; }
        public int ID_EMPRESA { get; set; }
        public string NOMBRE_EMPRESA { get; set; }
        public string COORDENADAS { get; set; }
        public DateTime FECHA { get; set; }
        public string ESTADO { get; set; }
    }
}
