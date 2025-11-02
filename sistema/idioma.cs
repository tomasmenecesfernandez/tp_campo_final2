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
        public idioma(idiomas idioma)
        {
            InitializeComponent();
            idioma.guardar_observer(this);
            actualizar_idioma();
        }
        
        BEtraducciones traduccion = new BEtraducciones();
        idiomas idiomas1 = new idiomas();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    idiomas1 = new idiomas(textBox1.Text);
                    idiomas1.agregar_idioma(idiomas1);
                    cargar_data1();
                }
                else
                {
                    throw new Exception("error, complete el cuadro idioma.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            btm_agregar.Text = BLLtraducciones.traducir(btm_agregar.Name);
            btm_modificar.Text = BLLtraducciones.traducir(btm_modificar.Name);
            btm_borrar.Text = BLLtraducciones.traducir(btm_borrar.Name);
        }

        private void btm_borrar_Click(object sender, EventArgs e)
        {
            if (idiomas1!=null)
            {
                idiomas1.borrar_idioma(idiomas1.codigo);
                cargar_data1();
                dataGridView2.DataSource = null;
            }
            else { MessageBox.Show("error, seleccione un idioma."); }
        }
    }
}
