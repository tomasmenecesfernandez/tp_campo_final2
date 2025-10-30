using System;
using System.Collections;
using System.Collections.Generic;
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
