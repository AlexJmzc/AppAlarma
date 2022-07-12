namespace Entidades
{
    public class Empresa
    {
        public Empresa()
        {

        }

        public Empresa(int iD_EMP, string nOMBRE_EMP, string dIRECCION_EMP, string cOORDENADAS_EMP, string dESCRIPCION_EMP, string tELEFONO_EMP, string eSTADO)
        {
            ID_EMP = iD_EMP;
            NOMBRE_EMP = nOMBRE_EMP;
            DIRECCION_EMP = dIRECCION_EMP;
            COORDENADAS_EMP = cOORDENADAS_EMP;
            DESCRIPCION_EMP = dESCRIPCION_EMP;
            TELEFONO_EMP = tELEFONO_EMP;
            ESTADO = eSTADO;
        }

        public Empresa(string nOMBRE_EMP, string dIRECCION_EMP, string cOORDENADAS_EMP, string dESCRIPCION_EMP, string tELEFONO_EMP, string eSTADO)
        {
            NOMBRE_EMP = nOMBRE_EMP;
            DIRECCION_EMP = dIRECCION_EMP;
            COORDENADAS_EMP = cOORDENADAS_EMP;
            DESCRIPCION_EMP = dESCRIPCION_EMP;
            TELEFONO_EMP = tELEFONO_EMP;
            ESTADO = eSTADO;
        }

        public int ID_EMP { get; set; }
        public string NOMBRE_EMP { get; set; }
        public string DIRECCION_EMP { get; set; }
        public string COORDENADAS_EMP { get; set; }
        public string DESCRIPCION_EMP { get; set; }
        public string TELEFONO_EMP { get; set; }
        public string ESTADO { get; set; }
    }
}
