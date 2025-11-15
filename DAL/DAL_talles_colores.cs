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
    public class DAL_talles_colores
    {
        acceso dal = new acceso();
        public void agregar_variable(BEtalles_colores variable)
        {
            string consulta = "agregar_variable";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@variable",variable.variable);
            hdatos.Add("@estalle", variable.get_estalle());
            dal.escribir(consulta,hdatos);
        }
        public void borrar_variable(int codigo)
        {
            string consulta = "borrar_variable";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo", codigo);
            dal.escribir(consulta, hdatos);
        }
        public void agregar_variable_ropa(int codigo_ropa,int codigo_variable)
        {
            string consulta = "agregar_variable_ropa";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo_ropa", codigo_ropa);
            hdatos.Add("@codigo_variable", codigo_variable);
            dal.escribir(consulta, hdatos);
        }
        public void borrar_variable_ropa(int codigo_ropa, int codigo_variable)
        {
            string consulta = "borrar_ropa_variable";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo_ropa", codigo_ropa);
            hdatos.Add("@codigo_variable",codigo_variable);
            dal.escribir(consulta, hdatos);
        }
        public List<BEtalles_colores> leer_variable(bool estalle)
        {
            List<BEtalles_colores> lista = new List<BEtalles_colores>();
            string consulta = "leer_variables";
            DataTable tabla = dal.leer_tabla(consulta, null);
            foreach (DataRow fila in tabla.Rows)
            {
                if (estalle == Convert.ToBoolean(fila["EsTalle"]))
                {
                    BEtalles_colores variable = new BEtalles_colores();
                    variable.codigo = Convert.ToInt32(fila["id"]);
                    variable.variable = fila["variable"].ToString();
                    variable.set_estalle( Convert.ToBoolean(fila["EsTalle"]));
                    lista.Add(variable);
                }
                
            }
            return lista;
        }
        public List<BEtalles_colores> leer_variables_ropa(int codigo_ropa,bool estalle)
        {
            List<BEtalles_colores> lista = new List<BEtalles_colores>();
            string consulta = "leer_variables_ropa";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo_ropa", codigo_ropa);
            DataTable tabla = dal.leer_tabla(consulta, hdatos);
            foreach (DataRow fila in tabla.Rows)
            {
                if (estalle == Convert.ToBoolean(fila["EsTalle"]))
                {
                    BEtalles_colores variable = new BEtalles_colores();
                    variable.codigo = Convert.ToInt32(fila["id"]);
                    variable.variable = fila["variable"].ToString();
                    variable.set_estalle( Convert.ToBoolean(fila["EsTalle"]));
                    lista.Add(variable);
                }
            }
            return lista;
        }
    }
}
