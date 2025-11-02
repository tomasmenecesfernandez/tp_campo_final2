using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Servicios.observer;
namespace sistema
{
    public partial class control_de_cambio_usuario : Form,Iobservertraduccion
    {
        public control_de_cambio_usuario(BEusuario usuario1, usuarios form1,idiomas idiomas)
        {
            InitializeComponent();
            form_padre = form1;
            usuario=usuario1;
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        usuarios form_padre;
        BEusuario usuario;
        BLLusuario bllusuario = new BLLusuario();
        BLLcontrolUsuario bllcontrolusuario = new BLLcontrolUsuario();
        BEcontrolCambioUsuario controlusuario_select = new BEcontrolCambioUsuario();
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlusuario_select = (BEcontrolCambioUsuario)dataGridView2.CurrentRow.DataBoundItem;

        }
        private void button4_Click(object sender, EventArgs e)
        {

            if (controlusuario_select != null && usuario != null)
            {

                try
                {
                    controlusuario_select.usuario = bllusuario.encrytar_nombre(controlusuario_select.usuario);
                    usuario.nombre = controlusuario_select.usuario;
                    usuario.contraseña = controlusuario_select.contraseña;
                    bllusuario.modificar(usuario);
                }
                catch { MessageBox.Show("error"); }
            }
            else
            {
                MessageBox.Show("seleccione un usuario.");
            }
        }

        private void control_de_cambio_usuario_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bllcontrolusuario.leer_Registros(usuario.codigo);
        }

        private void control_de_cambio_usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_padre.mostrar_data();
        }

        public void actualizar_idioma()
        {
            control_btm_revertir.Text = BLLtraducciones.traducir(control_btm_revertir.Name);

        }
    }
}
