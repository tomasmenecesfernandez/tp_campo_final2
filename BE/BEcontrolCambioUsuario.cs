using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEcontrolCambioUsuario
    {
        public int codigo { get; set; }
        public int codigo_usuario { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public DateTime fecha { get; set; }
        public int codigorol { get; set; }

        public BEcontrolCambioUsuario(BEusuario usuario1)
        {
            codigo_usuario = usuario1.codigo;
            usuario = usuario1.nombre;
            contraseña = usuario1.contraseña;
            codigorol = usuario1.rol.codigo;
            fecha = DateTime.Now;

        }
        public BEcontrolCambioUsuario()
        {
        }
    }
}
