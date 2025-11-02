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
    public partial class localidad : Form,Iobservertraduccion
    {
        public localidad(idiomas idiomas)
        {
            InitializeComponent();
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        public localidad(Cliente form_cliente)
        {
            InitializeComponent();
            form_padre = form_cliente;
        }
        Cliente form_padre;
        BElocalidad localidad_select = new BElocalidad();
        BLL_Localidad bll_loc = new BLL_Localidad();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            localidad_select = (BElocalidad)dataGridView1.CurrentRow.DataBoundItem;
            textBox1.Text = localidad_select.codigo.ToString();
            textBox2.Text = localidad_select.localidad;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!=string.Empty) {
                BElocalidad localidad = new BElocalidad(textBox2.Text);
                bll_loc.agregar(localidad);
                cargar_datagrip();
            }
            else
            {
                MessageBox.Show("error.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (localidad_select!=null)
            {
                bll_loc.borrar(localidad_select);
                cargar_datagrip();
            }
            else
            {
                MessageBox.Show("error.");
            }
        }

        private void localidad_Load(object sender, EventArgs e)
        {
            cargar_datagrip();
        }
        public void cargar_datagrip()
        {
            dataGridView1.DataSource = bll_loc.leer_localidades();
        }

        private void localidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_padre.cargar_localidades();
        }

        public void actualizar_idioma()
        {
            localidad_codigo.Text = BLLtraducciones.traducir(localidad_codigo.Name);
            label_localidad.Text = BLLtraducciones.traducir(label_localidad.Name);
            btm_agregar.Text = BLLtraducciones.traducir(btm_agregar.Name);
            btm_borrar.Text = BLLtraducciones.traducir(btm_borrar.Name);

        }
    }
}
