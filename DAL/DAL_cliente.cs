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
    public class DAL_cliente
    {

        acceso acceso = new acceso();
        Hashtable hdatos;
        public void alta(BEcliente cliente)
        {
            string Consulta = "agregar_cliente";
            hdatos = new Hashtable();
            hdatos.Add("@nombre_completo", cliente.nombre_completo);
            hdatos.Add("@DNI", cliente.DNI);
            hdatos.Add("@provincia", cliente.provincia);
            hdatos.Add("@cod_localidad", cliente.localidad.codigo);
            acceso.escribir(Consulta, hdatos);
        }
        public void modificar(BEcliente cliente)
        {
            string Consulta = "modificar_cliente";
            hdatos = new Hashtable();
            hdatos.Add("@codigo", cliente.codigo);
            hdatos.Add("@nombre_completo", cliente.nombre_completo);
            hdatos.Add("@DNI", cliente.DNI);
            hdatos.Add("@provincia", cliente.provincia);
            hdatos.Add("@cod_localidad", cliente.localidad.codigo);
            acceso.escribir(Consulta, hdatos);
        }
        public void borrar(BEcliente c)
        {
            string Consulta = "borrar_cliente";
            hdatos = new Hashtable();
            hdatos.Add("@codigo", c.codigo);
            acceso.escribir(Consulta, hdatos);
        }

        public List<BEcliente> leer_todo()
        {
            List<BEcliente> lista_cliente = new List<BEcliente>();
            string consulta = "leer_cliente";
            DataTable tabla = new DataTable();
             tabla = acceso.leer_tabla(consulta, null);


            if (tabla.Rows.Count > 0)
            {
                lista_cliente.Clear();
                foreach (DataRow fila in tabla.Rows)
                {
                    BEcliente cliente = new BEcliente();
                    BElocalidad localidad = new BElocalidad();
                    cliente.codigo = Convert.ToInt32(fila["codigo"]);
                    cliente.nombre_completo = fila["nombre_completo"].ToString();
                    cliente.DNI = Convert.ToInt32(fila["DNI"]);
                    cliente.provincia = fila["provincia"].ToString();
                    localidad.localidad = fila["localidad"].ToString();
                    localidad.codigo = Convert.ToInt32(fila["codigo_localidad"]);
                    cliente.localidad = localidad;
                    consulta = "leer_pedidos_cliente";
                    Hashtable hdatos = new Hashtable();
                    hdatos.Add("@codigo_cliente",cliente.codigo);
                    DataTable tabla1 = acceso.leer_tabla(consulta, hdatos);

                    foreach (DataRow fila1 in tabla1.Rows)
                    {
                        BEpedidos pedido = new BEpedidos();
                        pedido.codigo = Convert.ToInt32(fila1["codigo"]);
                        pedido.cantidad_ropa = Convert.ToInt32(fila1["cantidad_ropa"]);
                        pedido.fecha = (DateTime)fila1["fecha"];
                        pedido.total= Convert.ToInt32(fila1["total"]);
                        pedido.descuento = Convert.ToInt32(fila1["descuento"]);
                        consulta = "leer_pedidos_detalles";
                        Hashtable hdatos1 = new Hashtable();
                        hdatos1.Add("@codigo_p", pedido.codigo);
                        DataTable tabla2 = acceso.leer_tabla(consulta, hdatos1);
                        pedido.lista_pedido_detalle = new List<BEpedidos_detalle>();
                        foreach (DataRow fila2 in tabla2.Rows)
                        {
                            BEpedidos_detalle pedido_detalle = new BEpedidos_detalle();
                            pedido_detalle.codigo = Convert.ToInt32(fila2["codigo_pd"]);
                            pedido_detalle.precio_ropa= Convert.ToInt32(fila2["precio_ropa"]);
                            pedido_detalle.cantidad = Convert.ToInt32(fila2["cantidad"]);
                            if (fila2["capucha"] is DBNull)//jogging
                            {

                                BEjogging jogg = new BEjogging();
                                jogg.codigo = Convert.ToInt32(fila2["codigo_r"]);
                                jogg.talles = fila2["talle"].ToString();
                                jogg.colores = fila2["color"].ToString();
                                pedido_detalle.ropa = jogg;
                            }
                            else //buzo
                            {
                                BEbuzos buzos = new BEbuzos();
                                buzos.codigo = Convert.ToInt32(fila2["codigo"]);
                                buzos.talles = fila2["talle"].ToString();
                                buzos.colores = fila2["color"].ToString();
                                buzos.capucha = fila2["capucha"].ToString();
                                pedido_detalle.ropa = buzos;
                            }
                                pedido.lista_pedido_detalle.Add(pedido_detalle);

                        }
                        cliente.pedidos.Add(pedido);
                    }
                    lista_cliente.Add(cliente);

                }
            }

            return lista_cliente;
        }

    }
}
