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
    public partial class idioma : Form,Iobservertraduccion
    {
        public idioma()
        {
            InitializeComponent();
        }
        
        BEtraducciones traduccion = new BEtraducciones();
        idiomas idiomas1;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="") {
                idiomas1 = new idiomas(textBox1.Text);
                idiomas1.agregar_idioma(idiomas1);
                cargar_data1();
            }
        }
        public void cargar_data1()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = idiomas.leer_idiomas();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()) ;
            }
            }
        private void idioma_Load(object sender, EventArgs e)
        {
            idiomas1 = new idiomas();
            cargar_data1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idiomas1 = (idiomas)dataGridView1.CurrentRow.DataBoundItem;
            textBox1.Text = idiomas1.idioma;
            mostrar_data2();
        }
        
        public void mostrar_data2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = BLLtraducciones.leer_traducciones(idiomas1.idioma);

        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && traduccion!=null)
            {
                traduccion.valor = textBox2.Text;
                BLLtraducciones.modificar_traduccion(traduccion);
                mostrar_data2();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            traduccion = (BEtraducciones)dataGridView2.CurrentRow.DataBoundItem;
            textBox2.Text = traduccion.valor;

        }

        public void actualizar_idioma()
        {
            label_idioma_idioma.Text = BLLtraducciones.traducir(label_idioma_idioma.Name);
            label_traduccion_idioma.Text = BLLtraducciones.traducir(label_traduccion_idioma.Name);
            btnAgregar_idioma.Text = BLLtraducciones.traducir(btnAgregar_idioma.Name);
            btnModificar_idioma.Text = BLLtraducciones.traducir(btnModificar_idioma.Name);
        }
    }
}
