using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Security.Cryptography;
using BE;
using System.Collections;
using System.Data;
using Servicios;
namespace BLL
{
    public class BLLusuario 
    {
        DAL_usuario dal_usuario=new DAL_usuario();
        BLLrol bllrol = new BLLrol();
        BLLpermiso bllpermiso = new BLLpermiso();
        bllregistro bllregistro = new bllregistro();
        public string get_nombre(BEusuario usuario)
        {
            return encryptacion.desencryptar(usuario.nombre);
        }
        public void alta(BEusuario usuario)
        {
            dal_usuario.agregar_usuario(usuario);
        }
        public void modificar(BEusuario usuario)
        {
            dal_usuario.modificar(usuario);
        }
        public void borrar(BEusuario usuario)
        {
            dal_usuario.borrar(usuario);
        }
        public List<BEusuario> leer_usuario()
        {
            List<BEusuario> lista_usuarios = new List<BEusuario>();
            lista_usuarios.Clear();
            foreach (BEusuario usuario in dal_usuario.leer_usuario())
            {
                BEusuario usuario1 = new BEusuario();
                usuario1.nombre =desencrytar_nombre(usuario.nombre);
                usuario1.codigo = usuario.codigo;
                usuario1.contraseña = usuario.contraseña;
                usuario1.rol = usuario.rol;
                lista_usuarios.Add(usuario1);
            }
            return lista_usuarios;
        }
        public void login(BEusuario usuario)
        {
            usuario = encrytar_usuario(usuario);
            usuario = verificar_usuario(usuario);
            usuario.rol.hijos = bllrol.traer_nodos_hijos(usuario.rol.codigo);
            usuario.permisos = bllrol.traer_todos_los_permisos(usuario.rol);

            sesion.Login(usuario);
            BEregistro registro = new BEregistro(get_nombre(usuario), "inicio de sesion");
            bllregistro.guardar_registro(registro);
        }
        public BEusuario encrytar_usuario(BEusuario usuario)
        {
            usuario.nombre = encrytar_nombre(usuario.nombre);
            usuario.contraseña = encrytar_contraseña(usuario.contraseña);
            return usuario;
        }
        public string generar_hash(string texto)
        {
           return encryptacion.Hash(texto);
        }
        public string encrytar_nombre(string nombre)
        {
            return encryptacion.encriptar(nombre); ;
        }
        public string encrytar_contraseña(string contraseña)
        {
            return encryptacion.Hash(contraseña);
        }

        public string desencrytar_nombre(string nombre)
        {
            return encryptacion.desencryptar(nombre);
        }
        public BEusuario verificar_usuario(BEusuario usuario)
        {
            return dal_usuario.verificar_usuario(usuario);
        }


        //public bool Login(string name, string pass)
        //{
        //    if (SingletonSession.Instance.IsLogged())
        //    {
        //        throw new Exception("Ya hay una sesión iniciada");
        //    }
        //    else
        //    {
        //        name = acceso.encryptar(name);
        //        pass = Encrypt.Hash(pass);
        //        if (DALuser.Login(name, pass))
        //        {
        //            BE_User user = new BE_User();
        //            user.Name = Encrypt.Decrypt(name);
        //            user.Password = pass;
        //            SingletonSession.Instance.Login(user);
        //            return true;
        //        }
        //        return false;
        //    }
        //}

        //public bool Logout()
        //{
        //    if (!SingletonSession.Instance.IsLogged())
        //    {
        //        throw new Exception("No hay una sesion iniciada");
        //    }
        //    SingletonSession.Instance.Logout();
        //    return true;
        //}
    }
}
