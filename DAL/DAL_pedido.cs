using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
    public class DAL_pedido
    {
        acceso acceso = new acceso();

        public void alta(BEpedidos_detalle pedido_detalle)
        {
            string comando = "agregar_pedido_detalle";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@talles", pedido_detalle.ropa.talles);
            hdatos.Add("@cantidad", pedido_detalle.cantidad);
            hdatos.Add("@colores", pedido_detalle.ropa.colores);
            hdatos.Add("@codigo_pd", pedido_detalle.codigo_pedido);
            hdatos.Add("@precio", pedido_detalle.ropa.precio) ;

            if (pedido_detalle.ropa is BEjogging)
            {
                hdatos.Add("@capucha", "nada");
            }
            else if (pedido_detalle.ropa is BEbuzos)
            {
                BEbuzos buzo = (BEbuzos)pedido_detalle.ropa;
                hdatos.Add("@capucha", buzo.capucha);
            }
            acceso.escribir(comando, hdatos);

        }
        public void modificar(BEpedidos_detalle pedido_detalle)
        {
            if (pedido_detalle.ropa is BEbuzos)
            {
                BEbuzos buzo = (BEbuzos)pedido_detalle.ropa;
                string comando = "modificar_pedido_detalle";
                Hashtable hdatos = new Hashtable();
                hdatos.Add("@codigo_pd", pedido_detalle.codigo);
                hdatos.Add("@codigo_r", pedido_detalle.ropa.codigo);
                hdatos.Add("@cantidad", pedido_detalle.cantidad);
                hdatos.Add("@talles", buzo.talles);
                hdatos.Add("@colores", buzo.colores);
                hdatos.Add("@precio", pedido_detalle.ropa.precio) ;
                hdatos.Add("@capucha", buzo.capucha);
                acceso.escribir(comando, hdatos);
            }
            else if (pedido_detalle.ropa is BEjogging)
            {
                BEjogging jogging = (BEjogging)pedido_detalle.ropa;
                string comando = "modificar_pedido_detalle";
                Hashtable hdatos = new Hashtable();
                hdatos.Add("@codigo_pd", pedido_detalle.codigo);
                hdatos.Add("@codigo_r", pedido_detalle.ropa.codigo);
                hdatos.Add("@cantidad", pedido_detalle.cantidad);
                hdatos.Add("@precio", pedido_detalle.ropa.precio) ;
                hdatos.Add("@talles", jogging.talles);
                hdatos.Add("@colores", jogging.colores);
                hdatos.Add("@capucha", "NADA");
                acceso.escribir(comando, hdatos);
            }
        }
public void borrar_pedido_detalle(BEpedidos_detalle pedido_detalle)
        {
            string comando = "borrar_pedido_detalle";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo_pd", pedido_detalle.codigo);
            acceso.escribir(comando, hdatos);
        }
        public void borrar (BEpedidos pedido)
        {
            string comando = "borrar_pedido";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo_p", pedido.codigo);
            acceso.escribir(comando, hdatos);
        }
        public List<BEpedidos_detalle> leer_pedido_detalle(int codigo_pedido)
        {
            string comando = "leer_pedidos_detalles";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo_p", codigo_pedido);
            DataTable tabla= acceso.leer_tabla(comando, hdatos);
            List<BEpedidos_detalle> lista = new List<BEpedidos_detalle>();
            foreach (DataRow fila in tabla.Rows)
            {
                BEpedidos_detalle pedido_detalle = new BEpedidos_detalle();
                pedido_detalle.codigo = Convert.ToInt32(fila["codigo_pd"]);
                pedido_detalle.cantidad = Convert.ToInt32(fila["cantidad"]);
                if (fila["capucha"] is DBNull)//jogging
                {

                    BEjogging jogg = new BEjogging();
                    jogg.codigo = Convert.ToInt32(fila["codigo_r"]);
                    jogg.talles = fila["talle"].ToString();
                    jogg.colores = fila["color"].ToString();
                    pedido_detalle.ropa = jogg;
                }
                else //buzo
                {
                    BEbuzos buzos = new BEbuzos();
                    buzos.codigo = Convert.ToInt32(fila["codigo"]);
                    buzos.talles = fila["talle"].ToString();
                    buzos.colores = fila["color"].ToString();
                    buzos.capucha = fila["capucha"].ToString();
                    pedido_detalle.ropa = buzos;
                }
                lista.Add(pedido_detalle);

            }
            return lista;
        }
        public void guardar_pedido(BEpedidos pedido,int cod_cliente)
        {
            if (pedido.codigo==0) { 
            string comando = "guardar_pedido1";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@fecha", Convert.ToDateTime(pedido.fecha));
            hdatos.Add("@codigo_cliente", cod_cliente);
            hdatos.Add("@descuento", pedido.descuento);
                acceso.escribir(comando, hdatos);
        }else 
            {
                string comando = "guardar_pedido2";
                Hashtable hdatos = new Hashtable();
                hdatos.Add("@cantidad", pedido.cantidad_ropa);
                hdatos.Add("@total", pedido.total);
                acceso.escribir(comando, hdatos);
            }
        }

    }
}
