using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using Servicios.observer;
namespace BLL
{
    public class BLLtraducciones 
    {
        static DALtraducciones dal = new DALtraducciones();
        public static List<BEtraducciones> lista_traducciones = new List<BEtraducciones>();

        public static string traducir(string clave)
        {
            foreach (BEtraducciones traduccion in lista_traducciones)
            {
                if (traduccion.clave==clave)
                {
                    return traduccion.valor;
                }
            }
            return "no encontrado" + clave;
        }
        public static void cargar_listatraducciones(string idioma_actual)
        {
            lista_traducciones.Clear();
            lista_traducciones = dal.leer_traducciones(idioma_actual);
        }
        public static List<BEtraducciones> leer_traducciones(string idioma_actual)
        {
           return dal.leer_traducciones(idioma_actual);
        }
        public static void modificar_traduccion(BEtraducciones traduccion)
        {
            dal.modificar_traduccion(traduccion);
        }
    }
}
