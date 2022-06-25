using Datos;
using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class EmpresaLogica
    {
        public static List<Empresa> DevolverListaEmpresas()
        {
            return EmpresaDatos.DevolverListaEmpresas();
        }

        public static Empresa DevolverEmpresa(int id)
        {
            return EmpresaDatos.DevolverEmpresa(id);
        }

        public static Empresa NuevaEmpresa(Empresa empresa)
        {
            return EmpresaDatos.NuevaEmpresa(empresa);
        }

        public static Empresa Actualizar(Empresa empresa)
        {
            return EmpresaDatos.Actualizar(empresa);
        }

        public static void EliminarEmpresa(int id)
        {
            EmpresaDatos.EliminarEmpresa(id);
        }
    }
}
