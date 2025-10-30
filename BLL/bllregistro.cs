using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace BLL
{
    public class bllregistro
    {
        DALregistro dal = new DALregistro();
        public void guardar_registro(BEregistro registro)
        {
            dal.guardar_registro(registro);
        }
        public List<BEregistro> leer_registros()
        {
            return dal.leer_Registros();
        }
    }
}
