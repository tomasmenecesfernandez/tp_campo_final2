using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BElocalidad
    {
        public string localidad { get; set; }
        public int codigo { get; set; }
        public BElocalidad() { }

        public BElocalidad(string lod)
        {
            localidad = lod;
        }
        public override string ToString()
        {
            return $"{codigo} {localidad}";
        }
    }
}
