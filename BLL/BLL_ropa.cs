using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BLL

{
    public abstract class BLL_ropa
    {
        public abstract void alta(BEropa ropa, int codigo_cliente);

        public abstract void modificar(BEropa ropa, BEropa ropa_actual);

        public abstract void borrar(BEropa r, int codigo_cliente);

        public abstract int obtener_codigo();
    }
}
