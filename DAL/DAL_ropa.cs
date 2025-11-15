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
    public class DAL_ropa
    {
        public acceso acceso = new acceso();
        public void alta(BEropa ropa,int codigo_cliente)
        {
            if (ropa is BEbuzos)
            {
                BEbuzos buzo = (BEbuzos)ropa;
                string comando = "agregar_pedido";
                Hashtable hdatos = new Hashtable();
                hdatos.Add("@talles", buzo.talles);
                hdatos.Add("@colores", buzo.colores);
                hdatos.Add("@capucha", buzo.capucha);
                hdatos.Add("@codigo_usuario", codigo_cliente);

                acceso.escribir(comando, hdatos);
            } else if (ropa is BEjogging)
            {
                BEjogging jogging = (BEjogging)ropa;
                string comando = "agregar_pedido";
                Hashtable hdatos = new Hashtable();
                hdatos.Add("@talles", jogging.talles);
                hdatos.Add("@colores", jogging.colores);
                hdatos.Add("@capucha", "nada");
                hdatos.Add("@codigo_usuario", codigo_cliente);
                acceso.escribir(comando, hdatos);
            }
        }
        public Dictionary<int, string> leer_tipo_ropa()
        {
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            string comando = "leer_tipo_de_ropa";
            DataTable tabla = acceso.leer_tabla(comando, null);
            foreach (DataRow fila in tabla.Rows)
            {
                diccionario.Add((int)fila["codigo"], fila["prenda"].ToString()) ;
            }
            return diccionario;
        }
        public void modificar(BEropa ropa)
        {
            if (ropa is BEbuzos)
            {
                BEbuzos buzo = (BEbuzos)ropa;
                string comando = "modificar_pedido";
                Hashtable hdatos = new Hashtable();
                hdatos.Add("@talles", buzo.talles);
                hdatos.Add("@colores", buzo.colores);
                hdatos.Add("@capucha", buzo.capucha);
                acceso.escribir(comando, hdatos);
            }
            else if (ropa is BEjogging)
            {
                BEjogging jogging = (BEjogging)ropa;
                string comando = "modificar_pedido";
                Hashtable hdatos = new Hashtable();
                hdatos.Add("@talles", jogging.talles);
                hdatos.Add("@colores", jogging.colores);
                acceso.escribir(comando, hdatos);
            }
        }
    }
}
