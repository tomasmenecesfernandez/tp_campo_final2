using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEusuario
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public int codigo { get; set; }
        public BErol rol { get; set; }
        public List<BEpermiso> permisos { get; set; }
        public BEusuario()
        {

        }
        public BEusuario(string nom,string contra)
        {
            nombre = nom;
            contraseña = contra;
        }

        public override string ToString()
        {
            return nombre + "-" + contraseña;
        }
    }
}
