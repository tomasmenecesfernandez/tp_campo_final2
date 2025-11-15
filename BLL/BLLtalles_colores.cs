using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
namespace BLL
{
    public class BLLtalles_colores
    {
        DAL_talles_colores dal = new DAL_talles_colores();
        public void agregar_variable(BEtalles_colores variable)
        {
            dal.agregar_variable(variable);
        }
        public void borrar_variable(int codigo)
        {
            dal.borrar_variable(codigo);
        }
        public void agregar_variable_ropa(int codigo_ropa, int codigo_variable)
        {
            dal.agregar_variable_ropa(codigo_ropa,codigo_variable);
        }
        public void verificar_si_ya_esta_vinculada(List<BEtalles_colores> lista, BEtalles_colores variable)
        {
            foreach (BEtalles_colores elemento in lista)
            {
                if (elemento.variable==variable.variable)
                {
                    throw new Exception("error, el elemento que quiere agregar ya existe en la prenda.");
                }
            }
        }
        public void borrar_variable_ropa(int codigo_ropa,int codigo_variable)
        {
            dal.borrar_variable_ropa(codigo_ropa, codigo_variable);
        }
        public List<BEtalles_colores> leer_talles()
        {
            return dal.leer_variable(true);
        }
        public List<BEtalles_colores> leer_colores()
        {
            return dal.leer_variable(false);
        }
        public List<BEtalles_colores> leer_talles_ropa(int codigo_ropa)
        {
            return dal.leer_variables_ropa(codigo_ropa,true);
        }
        public List<BEtalles_colores> leer_colores_ropa(int codigo_ropa)
        {
            return dal.leer_variables_ropa(codigo_ropa, false);
        }
    }
}
