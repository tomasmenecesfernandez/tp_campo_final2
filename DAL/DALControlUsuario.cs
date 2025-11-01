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
    public class DALControlUsuario
    {
        acceso acceso = new acceso();
        public void agregar_control_usuario(BEcontrolCambioUsuario controlUsuario)
        {
            string consulta = "agregar_registro_usuario";
            Hashtable hash = new Hashtable();
            hash.Add("@codigo", controlUsuario.codigo_usuario);
            hash.Add("@usuario", controlUsuario.usuario);
            hash.Add("@contraseña", controlUsuario.contraseña);
            hash.Add("@fecha", controlUsuario.fecha);
            acceso.escribir(consulta, hash);
        }
        public List<BEcontrolCambioUsuario> leer_Registros(int codigo_usuario)
        {
            List<BEcontrolCambioUsuario> Lista = new List<BEcontrolCambioUsuario>();
            string consulta = "leer_registro_usuario";
            Hashtable hash = new Hashtable();
            hash.Add("@codigo",codigo_usuario);
            DataTable tabla = acceso.leer_tabla(consulta, hash);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                        BEcontrolCambioUsuario controlusuario = new BEcontrolCambioUsuario();
                        controlusuario.codigo_usuario = Convert.ToInt32(row["codigo_usuario"]);
                        controlusuario.codigo = Convert.ToInt32(row["codigo"]);
                        controlusuario.usuario = row["usuario"].ToString();
                        controlusuario.fecha = Convert.ToDateTime(row["fecha"]);
                        controlusuario.contraseña = row["contraseña"].ToString();
                    
                    Lista.Add(controlusuario);
                }

            }
            return Lista;
        } 
    }
}
