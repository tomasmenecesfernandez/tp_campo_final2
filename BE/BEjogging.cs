using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEjogging:BEropa
    {
        public override int precio { get => 8000; set => throw new NotImplementedException(); }

        public BEjogging() { }
        public BEjogging(string color, string tall)
        {
            talles = tall;
            colores = color;
        }
        public override string ToString()
        {
            return $"JOGGING Talles:{talles} Colores:{colores}. ";
        }
    }
}
