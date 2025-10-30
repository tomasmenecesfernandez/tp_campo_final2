using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEpermiso : BEpermisoComponente
    {
        public BEpermiso(string nom):base (nom)
        {
            nombre = nom;
        }
        public override void agregar_componente(BEpermisoComponente componente)
        {
        }

        public override List<BEpermisoComponente> obtener_hijos()
        {
          List<BEpermisoComponente> lista=new List<BEpermisoComponente>();
            return lista;

        }

        public override bool tiene_permiso(BEpermisoComponente permiso)
        {
            return false;
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
