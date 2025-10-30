using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using BE;
using sistema_de_ropa;
using Servicios.observer;
using BLL;
namespace sistema
{
    public partial class sistema : Form,Iobservertraduccion
    {
        public sistema()
        {
            InitializeComponent();
        }
        BLLtraducciones blltraducciones = new BLLtraducciones();
        public void activar_permisos_interfaz(BEpermiso permiso)
        {
            if (permiso.nombre=="hacer_pedido")
            {
                btm_comprar_sistema.Enabled = true;
            }

        }

        public void actualizar_idioma()
        {
            btm_comprar_sistema.Text = blltraducciones.traducir(btm_comprar_sistema.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sistema1 s = new sistema1();
            s.MdiParent = this.MdiParent;
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void sistema_Load(object sender, EventArgs e)
        {
            if (idiomas.lista_traducciones.Count > 0) actualizar_idioma();
        }
    }
}
