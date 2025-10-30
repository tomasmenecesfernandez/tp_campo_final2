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
    public class DALtraducciones
    {
        acceso acceso = new acceso();
        public List<BEtraducciones> leer_traducciones(string idioma)
        {
            string consulta = "traer_traduccion";
            Hashtable hash = new Hashtable();
            hash.Add("@idioma",idioma);
            DataTable tabla = acceso.leer_tabla(consulta,hash);
            List<BEtraducciones> lista = new List<BEtraducciones>();
            foreach (DataRow fila in tabla.Rows)
            {
                BEtraducciones traduccion = new BEtraducciones();
                traduccion.id_idioma = (int)fila["codigo_idioma"];
                traduccion.id_clave = (int)fila["ClaveID"];
                traduccion.clave = fila["NombreClave"].ToString();
                traduccion.valor = fila["Texto"].ToString();
                lista.Add(traduccion);
            }
            return lista;
        }
        public void modificar_traduccion(BEtraducciones traduccion)
        {
            string consulta = "modificar_traduccion";
            Hashtable hash = new Hashtable();
            hash.Add("@codigo_idioma", traduccion.id_idioma);
            hash.Add("@ClaveID", traduccion.id_clave);
            hash.Add("@valor", traduccion.valor);
            acceso.escribir(consulta, hash);
        }
    }
}
