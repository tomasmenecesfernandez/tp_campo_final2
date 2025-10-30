using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Servicios;
namespace BLL
{
    public class BLLcontrolUsuario
    {
        DALControlUsuario dalcontrol = new DALControlUsuario();
        public void agregar_control_usuario(BEcontrolCambioUsuario controlUsuario)
        {
            dalcontrol.agregar_control_usuario(controlUsuario);
        }
        public List<BEcontrolCambioUsuario> leer_Registros(int codigo)
        {
            List<BEcontrolCambioUsuario> lista = new List<BEcontrolCambioUsuario>();
            foreach ( BEcontrolCambioUsuario control in dalcontrol.leer_Registros(codigo))
            {
                control.usuario = encryptacion.desencryptar(control.usuario);
                lista.Add(control);
            }
            return lista;
        }
    }
}
