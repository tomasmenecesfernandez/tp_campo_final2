using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEpedidos
    {
        public int codigo { get; set; }
        public DateTime fecha { get; set; }
        public List<BEpedidos_detalle> lista_pedido_detalle { get; set; }
        public int cantidad_ropa { get; set; }
        public float descuento { get; set; }
        public double total { get; set; }
        public BEpedidos() 
        {
            fecha = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Fecha: {fecha.ToString("dd/MM/yyyy")}, Total: {total}, Cantidad Ropa: {cantidad_ropa}";
        }

    }
}
