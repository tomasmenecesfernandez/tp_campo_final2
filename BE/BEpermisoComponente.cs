using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEpermisoComponente
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public BEpermisoComponente(string nom)
        {
            nombre = nom;
        }

        public abstract void agregar_componente(BEpermisoComponente componente);
        public abstract bool tiene_permiso(BEpermisoComponente permiso);
        public abstract List<BEpermisoComponente> obtener_hijos();
    }
}
