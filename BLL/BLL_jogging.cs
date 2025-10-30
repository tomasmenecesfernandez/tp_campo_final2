using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_jogging : BLL_ropa
    {
        DAL_ropa dal = new DAL_ropa();
        public override void alta(BEropa ropa,int codigo_cliente)
        {
            dal.alta(ropa, codigo_cliente);
        }

        public override void borrar(BEropa r, int codigo_cliente)
        {
            throw new NotImplementedException();
        }

        public override void modificar(BEropa ropa, BEropa ropa_actual)
        {
            throw new NotImplementedException();
        }

        public override int obtener_codigo()
        {
            throw new NotImplementedException();
        }
    }
}
