using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEbuzos:BEropa
    {
        public override int precio { get => 10000; set => throw new NotImplementedException(); }
        public string capucha { get; set; }
        public BEbuzos()
        {

        }
        public BEbuzos(string color, string tall, string capuch)
        {
            talles = tall;
            colores = color;
            capucha = capuch;
        }
        public override string ToString()
        {
            return $"BUZO Talles:{talles} Colores:{colores} capucha:{capucha}";
        }
    }
}
