using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEregistro
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string accion { get; set; }
        public DateTime fecha { get; set; }
        public BEregistro() { }
        public BEregistro(string nombr,string accio)
        {
            nombre = nombr;
            accion = accio;
            fecha = DateTime.Now;
        }

    }
}
