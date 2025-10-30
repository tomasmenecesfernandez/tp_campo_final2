using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEcliente
    {
        public int codigo { get; set; }
        public string nombre_completo { get; set; }
        public int DNI { get; set; }
        public string provincia { get; set; }
        public string tipo { get; set; }
        public BElocalidad localidad { get; set; }
        public List<BEpedidos> pedidos = new List<BEpedidos>();
     
        public BEcliente()
        {

        }
        public BEcliente(string nombr, int DN, string provinci, BElocalidad localida)
        {
            nombre_completo = nombr;
            DNI = DN;
            provincia = provinci;
            localidad = localida;
        }
    }
}
