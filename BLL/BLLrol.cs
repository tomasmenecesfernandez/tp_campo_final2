using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BLL
{
    public class BLLrol
    {
        DALrolpermiso dal = new DALrolpermiso();
         public List<BEpermisoComponente> traer_nodos_hijos(int cod)
        {
            List<BEpermisoComponente> lista = new List<BEpermisoComponente>();
            lista = (dal.TraerArbolPermisos(cod));
            return lista;
        }
        public void agregar_rol(BErol rol, int codpadre)
        {
            dal.agregar_nodo(rol, codpadre, true);
        }
        public void modificar_rol(BErol rol)
        {
            dal.modificar_nodo(rol, true);

        }
        public void borrar_nodo(BEpermisoComponente componente)
        {
            if (componente is BErol)
            {
                dal.borrar_nodo(componente, true);
            }
            else
            {
                dal.borrar_nodo(componente, false);

            }

        }
        public List<BEpermisoComponente> traer_todos_los_roles()
        {
            return dal.traer_todos_los_roles();
        }
        public BErol recuperar_rol(int codigo)
        {
            List<BEpermisoComponente> lista = new List<BEpermisoComponente>();
            lista = dal.traer_todos_los_roles();
            foreach (BErol rol in lista)
            {
                if (rol.codigo == codigo) {
                    return rol;
                }
            }
            return null;
        }
        public List<BEpermiso> traer_todos_los_permisos_usuario(BEusuario usuario)
        {
            List<BEpermiso> lista = new List<BEpermiso>();
            foreach(BEpermisoComponente nodo in traer_permisos_usuario(usuario))
            {
                if (nodo is BErol) {
                    lista.AddRange(traer_todos_los_permisos((BErol)nodo));
                }else
                {
                    lista.Add((BEpermiso)nodo);
                }
            }
            return lista;
        }
            public List<BEpermiso> traer_todos_los_permisos(BErol rol, List<BEpermiso>lista=null )
        {
            if (lista == null) lista = new List<BEpermiso>();
            foreach (BEpermisoComponente hijo in rol.hijos)
            {
                if (hijo is BEpermiso)
                {
                    if(!lista.Contains((BEpermiso)hijo)) lista.Add((BEpermiso)hijo);
                }
                else
                {
                    traer_todos_los_permisos((BErol)hijo,lista);
                }
            }
            return lista;
        }
        public bool esUnRolNuevo(string nombrerol)
        {
            foreach (BErol rol in traer_todos_los_roles())
            {
                if (rol.nombre == nombrerol)
                {
                    return false;
                }
            }
            return true;
        }
        public void verificar_permiso_no_existente(List<BEpermisoComponente>lista,string nombre_permiso)
        {
            foreach ( BEpermisoComponente nodo in lista )
            {
                if (nodo is BErol)
                {
                    if (nodo.nombre == nombre_permiso) throw new Exception("error, el permiso ya se encuentra en la lista de permisos del usuario.");

                    BErol rol = (BErol)nodo;
                    verificar_permiso_no_existente(rol.hijos, nombre_permiso);
                }
                else
                {
                    if (nodo.nombre == nombre_permiso) throw new Exception("error, el permiso ya se encuentra en la lista de permisos del usuario.");
                }
            }
        }
        public void verificar_rol_bucle(BErol rol_padre,string nombre_rol_hijo)
        {
            if(rol_padre.nombre == nombre_rol_hijo){
                throw new Exception("error, al agregar el rol seleccionado genera un bucle infinito.");
            }
            foreach (BEpermisoComponente hijo in rol_padre.hijos)
            {
                if (hijo is BErol)
                {
                    if (hijo.nombre == nombre_rol_hijo)
                    {
                        throw new Exception("error, al agregar el rol seleccionado genera un bucle infinito.");
                    }
                    BErol rol = (BErol)hijo;
                    verificar_rol_bucle(rol, nombre_rol_hijo);
                }
            }
        }
        public List<BEpermisoComponente> traer_permisos_usuario(BEusuario usuario)
        {
            return dal.traer_permisos_usuario(usuario);
        }
        public void agregar_permiso_usuario(BEpermisoComponente rol, int codpadre)
        {
            dal.agregar_permiso_usuario(rol, codpadre);
        }
        public void borrar_permiso_usuario(BEpermisoComponente rol,int codigo_usuario)
        {
            dal.borrar_permiso_usuario(rol, codigo_usuario);

        }
    }
}
