using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace Servicios
{
    public class sesion
    {
        public static sesion instancia;

        public BEusuario usuario { get; set; }
        public static sesion obtener_instancia
        {
            get
            {
                if (instancia == null) throw new Exception("la sesión no fue iniciada");
                return instancia;
            }
        }
        private static Object _lock = new object();
        public static void Login(BEusuario usuario1)
        {
            try
            {
                lock (_lock)
                {
                    if (instancia == null)
                    {
                        instancia = new sesion();
                        instancia.usuario = usuario1;
                    }
                    else
                    {
                        throw new Exception("Sesión no iniciada.");
                    }
                }
            }catch
                {
                    throw new Exception("error usuario");
                }
            
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (instancia!=null)
                {
                    instancia = null;
                }
                else
                {
                    throw new Exception("error sesion no iniciada.");
                }
            }
        }
        public static bool controlador_sesion()
        {
            if (instancia!=null)
            {
                return true;
            }else
            {
                return false;
            }
        }

    }
}
