using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BLL

{
    public class BLL_buzos {
        static DAL_ropa dal = new DAL_ropa();
        public static void alta(BEropa r, int codigo_cliente)
        {
            dal.alta(r, codigo_cliente);
        }
        public void modificar(BEbuzos r)
        {
           // mppbuzo.modificar(r);
        }
        public void borrar(BEropa r, int codigo_cliente)
        {
            //mppbuzo.borrar(r,codigo_cliente);
        }
        public void guardar_cliete_buzo(BEbuzos b,BEcliente c)
        {
            //mppbuzo.guardar_cliete_buzo(b,c);
        }
        public int obtener_codigo() => 0;
        //{
        //  return  mppbuzo.obtener_codigo();
        //}


    }
}
