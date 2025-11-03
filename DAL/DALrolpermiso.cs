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
    public class DALrolpermiso
    {
        public acceso acceso = new acceso();
        public List<BEpermisoComponente> TraerArbolPermisos(int codigoraiz)
        {
            string comando = "traer_todos_hijos";
            Hashtable hash = new Hashtable();
            hash.Add("@codigoraiz", codigoraiz);

            DataTable tabla = acceso.leer_tabla(comando, hash);
            List<BEpermisoComponente> listaPermisos = new List<BEpermisoComponente>();

            foreach (DataRow row in tabla.Rows)
            {
                if ((bool)row["tipocompuesto"]) // Es un rol
                {
                    BErol rolHijo = new BErol(row["nombre"].ToString());
                    rolHijo.codigo = (int)row["codigo"];
                    List<BEpermisoComponente> hijos = TraerArbolPermisos(rolHijo.codigo);
                    rolHijo.hijos.AddRange(hijos);

                    listaPermisos.Add(rolHijo);
                }
                else // Es un permiso
                {
                    BEpermiso permiso = new BEpermiso(row["nombre"].ToString());
                    permiso.codigo = (int)row["codigo"];

                    listaPermisos.Add(permiso);
                }
            }

            return listaPermisos;
        }

        public void agregar_nodo(BEpermisoComponente rol, int codpadre, bool compuesto)
        {
            string comando = "agregar_nodo";
            Hashtable hash = new Hashtable();
            hash.Add("@codigo", rol.codigo);
            hash.Add("@nombre", rol.nombre);
            hash.Add("@tipocompuesto", compuesto);
            hash.Add("@codigo_padre", codpadre);
            acceso.escribir(comando, hash);
        }
        public void modificar_nodo(BEpermisoComponente rol,bool compuesto)
        {
            string comando = "modificar_elemento_composite";
            Hashtable hash = new Hashtable();
            hash.Add("@codigo", rol.codigo);
            hash.Add("@nombre", rol.nombre);
            hash.Add("@tipocompuesto", compuesto);
            acceso.escribir(comando,hash);
        }
        public void borrar_nodo(BEpermisoComponente rol,bool compuesto)
        {
            string comando = "borrar_elemento_composite";
            Hashtable hash = new Hashtable();
            hash.Add("@codigo", rol.codigo);
            hash.Add("@tipocompuesto", compuesto);
            acceso.escribir(comando, hash);
        }
        public List<int> traer_cod_roles_hijo(int cod_padre)
        {
            string comando = "traer_roles_hijos";
            Hashtable hash = new Hashtable();
            hash.Add("@codigo", cod_padre);
            DataTable tabla = acceso.leer_tabla(comando, hash);
            List<int> lista_codigos_roleshijos = new List<int>();
            foreach (DataRow row in tabla.Rows)
            {
                lista_codigos_roleshijos.Add(Convert.ToInt32(row["rolhijo"]));
            }
            return lista_codigos_roleshijos;
        }

        public List<BEpermisoComponente> traer_todos_los_roles()
        {
            string consulta = "traer_rol";
            DataTable tabla = acceso.leer_tabla(consulta, null);
            List<BEpermisoComponente> lista = new List<BEpermisoComponente>();
            foreach (DataRow row in tabla.Rows)
            {
                if (row["nombre"].ToString() != "sistema") { 
                BErol rol = new BErol(row["nombre"].ToString());
                rol.codigo = (int)(row["codigo"]);
                rol.hijos = TraerArbolPermisos(rol.codigo);
                lista.Add(rol); }
            }
            return lista;

        }
        public List<BEpermiso> leer_permisos()
        {
            string consulta = "leer_permisos";
            DataTable tabla = acceso.leer_tabla(consulta, null);
            List<BEpermiso> lista = new List<BEpermiso>();
            foreach (DataRow row in tabla.Rows)
            {
                BEpermiso permiso = new BEpermiso(row["nombre"].ToString());
                permiso.codigo = (int)(row["codigo"]);
                lista.Add(permiso);
            }
            return lista;
        }
        public List<BEpermisoComponente> traer_permisos_usuario(BEusuario usuario)
        {
            List<BEpermisoComponente> lista = new List<BEpermisoComponente>();
            string consulta = "leer_permisos_y_rol_del_usuario";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo_usuario",usuario.codigo);
            DataTable tabla = acceso.leer_tabla(consulta, hdatos);
            foreach (DataRow fila in tabla.Rows)
            {
                if (Convert.ToInt32(fila["tipocompuesto"])==1) {
                    BErol rol = new BErol(fila["nombre"].ToString());
                    rol.codigo = (int)(fila["codigo"]);
                    rol.hijos = TraerArbolPermisos(rol.codigo);
                    lista.Add(rol);
                }
                else
                {
                    BEpermiso permiso = new BEpermiso(fila["nombre"].ToString());
                    permiso.codigo = (int)(fila["codigo"]);
                    lista.Add(permiso);
                }
            }
            return lista;
        }
        public void agregar_permiso_usuario(BEpermisoComponente permiso, int codigo_usuario)
        {
            string consulta = "agregar_permisos_usuario";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo_usuario", codigo_usuario);
            hdatos.Add("@codigo_permiso", permiso.codigo);
            acceso.escribir(consulta, hdatos);
        }
        public void borrar_permiso_usuario(BEpermisoComponente permiso,int codigo_usuario)
        {
            string consulta = "borrar_usuario_permisos";
            Hashtable hdatos = new Hashtable();
            hdatos.Add("@codigo_usuario", codigo_usuario);
            hdatos.Add("@codigo_permisos", permiso.codigo );
            acceso.escribir(consulta, hdatos);
        }
    }
}
