using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEtalles_colores
    {
        public int codigo { get; set; }
        public string variable { get; set; }
        private bool EsTalle { get; set; }
        public BEtalles_colores()
        {
        }
        public BEtalles_colores(string variabl,bool EsTall)
        {
            variable = variabl;
            EsTalle = EsTall;
        }
        public bool get_estalle()
        {
            return EsTalle; 
        }
        public void set_estalle(bool v)
        {
            EsTalle = v;
        }
        public override string ToString()
        {
            return variable;
        }
    }
}
