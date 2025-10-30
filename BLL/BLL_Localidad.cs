using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.Sql;
using DAL;
namespace BLL
{
    public class BLL_Localidad
    {
        DAL_localidad DAL = new DAL_localidad();    
        public void agregar(BElocalidad l)
        {
            DAL.alta(l);
        }
        public void borrar(BElocalidad l)
        {
            DAL.borrar(l);
        }
        public List<BElocalidad> leer_localidades()
        {
            return DAL.leer_localidad();
        }
    }
}
