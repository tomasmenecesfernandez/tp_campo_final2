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
    public class DAL_usuario
    {
        acceso acceso = new acceso();
        public void agregar_usuario(BEusuario usuario)
        {
            string comando = "agregar_usuario";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@nombre", usuario.nombre);
            hdatos.Add("@contraseña", usuario.contraseña);
            hdatos.Add("@rol", usuario.rol.codigo);

            acceso.escribir(comando, hdatos);
        }
        public void modificar(BEusuario u)
        {
            string comando = "modificar_usuario";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@nombre", u.nombre);
            hdatos.Add("@contraseña", u.contraseña);
            hdatos.Add("@codigo", u.codigo);
            hdatos.Add("@rol", u.rol.codigo);
            acceso.escribir(comando, hdatos);
        }
        public void borrar(BEusuario u)
        {
            string comando = "borrar_usuario";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo", u.codigo);
            acceso.escribir(comando, hdatos);
        }

        public BEusuario verificar_usuario(BEusuario usuario)
        {
            string comando = "verificar_usuario";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@nombre", usuario.nombre);
            hdatos.Add("@contraseña", usuario.contraseña);
            DataTable tabla = acceso.leer_tabla(comando, hdatos);
            foreach (DataRow linea in tabla.Rows)
            {
                usuario.codigo = Convert.ToInt32(linea["codigo"].ToString());
                usuario.rol = new BErol(linea["nombrerol"].ToString());
                usuario.rol.codigo = Convert.ToInt32(linea["codigo_rol"]);
                return usuario;
            }
            throw new Exception("El usuario o contraseña incorrecta, vuelva a intentarlo.");
        }

        public List<BEusuario> leer_usuario()
        {
            string consulta = "leer_usuario";
            DataTable aux = acceso.leer_tabla(consulta,null);
            List<BEusuario> lista = new List<BEusuario>();
            foreach (DataRow fila in aux.Rows)
            {
                BEusuario usuario = new BEusuario();
                usuario.nombre = fila["nombre"].ToString();
                usuario.contraseña = fila["contraseña"].ToString();
                usuario.codigo = Convert.ToInt32(fila["codigo"]);
                usuario.rol = new BErol(fila["nombrerol"].ToString());
                usuario.rol.codigo = Convert.ToInt32(fila["rol"]);

                lista.Add(usuario);
            }
            return lista;
        }
    }
}
