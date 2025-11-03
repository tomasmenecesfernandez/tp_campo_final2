using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace BLL
{
    public class BLLpermiso
    {
        DALrolpermiso dal = new DALrolpermiso();
       public static List<BEpermiso> listapermiso = new List<BEpermiso>();

        public void agregar_permiso(BEpermiso permiso, int codpadre)
        {
            dal.agregar_nodo(permiso, codpadre, false);
        }
        public List<BEpermiso> leer_permisos()
        {
           return dal.leer_permisos();
        }
        public void verificar_si_existe_permiso(BErol rol_padre,string nombre_permiso)
        {
                foreach (BEpermisoComponente hijo in rol_padre.hijos)
                {
                    if (hijo is BEpermiso)
                    {
                        if (hijo.nombre == nombre_permiso)
                        {
                            throw new Exception("error, el permiso ya existe en el rol");
                        }
                    }
                    else
                {
                    BErol rol = (BErol)hijo;
                    verificar_si_existe_permiso(rol, nombre_permiso);
                }
                }
        }

    }
}
