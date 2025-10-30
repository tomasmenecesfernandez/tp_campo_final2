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
    public class DAL_localidad
    {
        acceso acceso = new acceso();

        public void alta(BElocalidad localidad)
        {
            string Consulta = "agregar_localidad";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@localidad", localidad.localidad);
            acceso.escribir(Consulta, hdatos);
        }
        public void borrar(BElocalidad localidad)
        {
            string Consulta = "borrar_localidad";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo", localidad.codigo);
            acceso.escribir(Consulta, hdatos);
        }
        public List<BElocalidad> leer_localidad()
        {
            List<BElocalidad> lista = new List<BElocalidad>();
            string consulta = "leer_localidad";
            DataTable tabla = acceso.leer_tabla(consulta, null);
            foreach (DataRow fila in tabla.Rows)
            {
                BElocalidad localidad = new BElocalidad();
                localidad.codigo = Convert.ToInt32(fila["codigo_localidad"]);
                localidad.localidad = fila["localidad"].ToString();
                lista.Add(localidad);
            }
            return lista;
        }
    }
}
