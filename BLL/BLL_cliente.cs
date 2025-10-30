using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace BLL

{
    public class BLL_cliente
    {
        public DAL_cliente dal = new DAL_cliente();
        public void alta(BEcliente cliente1)
        {
            dal.alta(cliente1);
        }
        public void modificar(BEcliente cliente1)
        {
            dal.modificar(cliente1);
        }
        public void borrar(BEcliente cliente1)
        {
            dal.borrar(cliente1);

        }
        public string calcular_tipo_cliente(BEcliente cliente)
        {
            if (cliente.pedidos.Count < 5)
            {
                return  "Basico";
            }
            else if (cliente.pedidos.Count < 10)
            {
                return  "Plata";
            }
            else if (cliente.pedidos.Count >= 10)
            {
                return "Oro";
            }
            return null;
        }
        public List<BEcliente> leer_todo()
        {
            List<BEcliente> lista = new List<BEcliente>();
            foreach (BEcliente cliente in dal.leer_todo())
            {
                cliente.tipo = calcular_tipo_cliente(cliente);
                foreach(BEpedidos pedidos in cliente.pedidos)
                {
                    pedidos.total = 0;
                    pedidos.cantidad_ropa = 0;
                    foreach (BEpedidos_detalle pd in pedidos.lista_pedido_detalle) {
                        pedidos.total += (pd.precio_ropa*pd.cantidad)* (1-pedidos.descuento/100);
                        pedidos.cantidad_ropa += pd.cantidad;
                    } 
                }
                lista.Add(cliente);
            }
            return lista;
        }

    }
}
