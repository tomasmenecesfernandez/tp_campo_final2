using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;
using DAL;
namespace BLL

{
    public class BLLPedido
    {
        DAL_pedido dal = new DAL_pedido();
        public double calcular_total_pedido(BEpedidos pedido, BEcliente cliente)
        {
        //    if (pedido.ropa is BEbuzos)
        //    {
        //        if (pedido.descuento != 0)
        //        {
        //            return pedido.cantidad * 10000 * (1 - pedido.descuento / 100);
        //        }
        //        else
        //        {
        //            return pedido.cantidad * 10000;
        //        }
        //    }
        //    else
        //    {
        //        if (pedido.descuento != 0)
        //        {
        //            return pedido.cantidad * 7000 * (1 - pedido.descuento / 100);
        //        }
        //        else
        //        {
        //            return pedido.cantidad * 7000;
        //        }
        //    }
        return 0;

        }
        public void alta(BEpedidos_detalle pd)
        {
            dal.alta( pd);
        }
        public void modificar(BEpedidos_detalle pedido)
        {
            dal.modificar(pedido);
        }
        public void borrar(BEpedidos pedido)
        {
            dal.borrar(pedido);
        }
        public void borrar_pedido_detalle(BEpedidos_detalle pedido_d)
        {
            dal.borrar_pedido_detalle(pedido_d);
        }
        public int analizar_descuento(BEcliente cliente)
        {
            switch (cliente.tipo)
            {
                case "Basico": return 0;
                case "Plata": return 5;
                case "Oro": return 10;
            }
            return 0;
        }
        public List<BEpedidos_detalle> leer_pedido_detalle(int codigo_pedido)
        {
            return dal.leer_pedido_detalle(codigo_pedido);
        }
        public int calcular_descuento_pedido( string tipo)
        {
            if (tipo=="Basico")
            {
                return 0;
            }
            else if (tipo == "Plata") 
            {
                return 5;
            }
            else if (tipo=="Oro")
            {
                return 10;
            }
            return 0;
        }
        public void guardar_pedido(BEpedidos pedido,int cod_cliente)
        {
            dal.guardar_pedido(pedido,cod_cliente);
        }
    }
}
