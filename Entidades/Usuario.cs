namespace Entidades
{
    public class Usuario
    {
        public Usuario()
        {

        }

        public Usuario(int iD_USU, string nOMBRE_USU, string cLAVE_USU, string rOL_USU, string cEDULA_USU, string nOMBRE_CLI, string aPELLIDO_CLI, string tELEFONO_CLI, int iD_EMPRESA)
        {
            ID_USU = iD_USU;
            NOMBRE_USU = nOMBRE_USU;
            CLAVE_USU = cLAVE_USU;
            ROL_USU = rOL_USU;
            CEDULA_USU = cEDULA_USU;
            NOMBRE_CLI = nOMBRE_CLI;
            APELLIDO_CLI = aPELLIDO_CLI;
            TELEFONO_CLI = tELEFONO_CLI;
            ID_EMPRESA = iD_EMPRESA;
        }

        public Usuario(string nOMBRE_USU, string cLAVE_USU, string rOL_USU, string cEDULA_USU, string nOMBRE_CLI, string aPELLIDO_CLI, string tELEFONO_CLI, int iD_EMPRESA, string eSTADO)
        {
            NOMBRE_USU = nOMBRE_USU;
            CLAVE_USU = cLAVE_USU;
            ROL_USU = rOL_USU;
            CEDULA_USU = cEDULA_USU;
            NOMBRE_CLI = nOMBRE_CLI;
            APELLIDO_CLI = aPELLIDO_CLI;
            TELEFONO_CLI = tELEFONO_CLI;
            ID_EMPRESA = iD_EMPRESA;
            ESTADO = eSTADO;
        }

        public int ID_USU { get; set; }
        public string NOMBRE_USU { get; set; }
        public string CLAVE_USU { get; set; }
        public string ROL_USU { get; set; }
        public string CEDULA_USU { get; set; }
        public string NOMBRE_CLI { get; set; }
        public string APELLIDO_CLI { get; set; }
        public string TELEFONO_CLI { get; set; }
        public int ID_EMPRESA { get; set; }
        public string ESTADO { get; set; }
    }
}
