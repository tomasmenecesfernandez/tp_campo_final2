using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BErol:BEpermisoComponente
    {
        public  List<BEpermisoComponente> hijos ;
        public BErol(string nom):base(nom)
        {
            hijos = new List<BEpermisoComponente>();
        }

        public override void agregar_componente(BEpermisoComponente componente)
        {
            hijos.Add(componente);
        }


        public override List<BEpermisoComponente> obtener_hijos()
        {
            return hijos;
        }

        public override bool tiene_permiso(BEpermisoComponente permiso)
        {
            foreach (BEpermiso permisos in hijos)
            {
                if (permisos.tiene_permiso(permiso))
                {
                    return true;
                }
            }
            return false;

        }
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
