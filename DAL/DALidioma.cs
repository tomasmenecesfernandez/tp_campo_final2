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
    public class DALidioma
    {
        acceso acceso = new acceso();
        public void agregar_idioma(string idioma,int dv)
        {
            string comando = "agregar_idioma";
            Hashtable hash = new Hashtable();
            hash.Add("@idioma", idioma);
            hash.Add("@dv", dv);
            acceso.escribir(comando, hash);
        }
        public void borrar_idioma(int codigo)
        {
            string comando = "borrar_idioma";
            Hashtable hash = new Hashtable();
            hash.Add("@codigo_idioma", codigo);
            acceso.escribir(comando, hash);
        }
        public List<BE_Idioma> leer_idiomas()
        {
            string comando = "leer_idiomas";
            DataTable tabla = acceso.leer_tabla(comando, null);
            List<BE_Idioma> lista = new List<BE_Idioma>();
            foreach (DataRow fila in tabla.Rows)
            {
                BE_Idioma idioma = new BE_Idioma(fila["Nombre"].ToString());
                idioma.codigo = (int)fila["codigo"];
                idioma.digito_verificador = (int)fila["digito_verificador"];
                lista.Add(idioma);
 }

            return lista;
        }
    }
}
