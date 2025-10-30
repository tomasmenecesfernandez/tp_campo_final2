using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEtraducciones 
    {
        public int id_idioma { get; set; }
        public int id_clave { get; set; }
        public string clave { get; set; }
        public string valor { get; set; }
        public BEtraducciones() { }
        public BEtraducciones(string clav, string valo)
        {
            clave = clav;
            valor = valo;
        }
    }
}
