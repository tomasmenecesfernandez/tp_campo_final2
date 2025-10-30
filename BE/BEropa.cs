using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEropa
    {
        public int codigo { get; set; }
        public string talles { get; set; }
        public string colores { get; set; }
        public abstract int precio{ get; set; }
    }
}
