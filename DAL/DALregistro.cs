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
    public class DALregistro
    {
        
        acceso DAL = new acceso();
        public void guardar_registro(BEregistro registro)
        {
            string consulta = "guardar_registro";
            Hashtable hash = new Hashtable();
            hash.Add("@nombre", registro.nombre);
            hash.Add("@accion", registro.accion);
            hash.Add("@fecha", registro.fecha);
            DAL.escribir(consulta, hash);
        }

        public List<BEregistro> leer_Registros()
        {
            List<BEregistro> Lista = new List<BEregistro>();
            string consulta = "leer_registro";
            DataTable tabla = DAL.leer_tabla(consulta, null);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    BEregistro registro = new BEregistro();
                    registro.codigo = Convert.ToInt32(row["codigo"]);
                    registro.nombre = row["Nombre"].ToString();
                    DateTime d= Convert.ToDateTime(row["Fecha"]);
                    registro.fecha = Convert.ToDateTime(d.ToString("dd/MM/yyyy"));
                    registro.accion = row["accion"].ToString();

                    Lista.Add(registro);
                }

            }
            return Lista;
        }
    }
}
