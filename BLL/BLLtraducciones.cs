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
        DALtraducciones dal = new DALtraducciones();
        public string traducir(string clave)
        {
            foreach (BEtraducciones traduccion in idiomas.lista_traducciones)
            {
                if (traduccion.clave==clave)
                {
                    return traduccion.valor;
                }
            }
            return "no encontrado" + clave;
        }
        public List<BEtraducciones> leer_traducciones(string idioma_actual)
        {
           return dal.leer_traducciones(idioma_actual);
        }
        public void modificar_traduccion(BEtraducciones traduccion)
        {
            dal.modificar_traduccion(traduccion);
        }
    }
}
