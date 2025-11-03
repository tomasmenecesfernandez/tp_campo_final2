using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Servicios.observer;
namespace sistema
{
    public partial class bitacora : Form,Iobservertraduccion
    {
        public bitacora(idiomas idiomas)
        {
            InitializeComponent();
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idioma = idiomas;
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        idiomas idioma;
        bllregistro bllregistro = new bllregistro();
        private void bitacora_Load(object sender, EventArgs e)
        {
            cargar_grilla();
        }
        public void cargar_grilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllregistro.leer_registros();
        }

        public void actualizar_idioma()
        {
            bitacora_label_bitacora.Text = BLLtraducciones.traducir(bitacora_label_bitacora.Name);

        }

        private void bitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            idioma.eliminar_observer(this);
        }
    }
}
