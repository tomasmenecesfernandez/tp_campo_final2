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
        public List<int> traer_cod_roles_hijo(int cod_padre)
        {
            return dal.traer_cod_roles_hijo(cod_padre);
        }
        public List<int> traer_cod_todos_hijos(int cod_padre)
        {
            return dal.traer_cod_todos_hijos(cod_padre);

        }
        public void agregar_rol_nuevo(BErol rol, int codpadre)
        {
            dal.agregar_nodo(rol, codpadre, true);
        }
        public void agregar_rol(BErol rol, int codpadre)
        {
            dal.agregar_nodo(rol, codpadre, true);
        }
        public void modificar_rol(BErol rol)
        {
            dal.modificar_nodo(rol, true);

        }
        public void borrar_rol(BErol rol)
        {
            dal.borrar_rol(rol, true);

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
        public void verificar_rol_bucle(BErol rol_padre,string nombre_rol_hijo)
        {
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
    }
}
