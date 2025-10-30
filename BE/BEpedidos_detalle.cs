using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEpedidos_detalle
    {
        public int codigo { get; set; }
        public BEropa ropa { get; set; }
        public int cantidad{ get; set; }
        public double precio_ropa{ get; set; }
        public int codigo_pedido { get; set; }
        public BEpedidos_detalle() 
        { 
        }
        public BEpedidos_detalle(int codig,int cantida, double tota)
        {
            codigo = codig;
            cantidad = cantida;
        }
        public override string ToString()
        {
            if (this.ropa is BEbuzos) {
                BEbuzos BUZO = (BEbuzos)this.ropa;
                return $"BUZOS COD: {codigo}, CANTIDAD: {cantidad}, COLORES: {this.ropa.colores}, TALLES: {this.ropa.talles}, CAPUCHA: {BUZO.capucha}";
            }
            else 
            { 
                return $"JOGGING COD: {codigo}, CANTIDAD: {cantidad}, COLORES: {this.ropa.colores}, TALLES: {this.ropa.talles}";
            }
        }

    }
}
