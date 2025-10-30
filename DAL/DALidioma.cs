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

    }
}
