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
    public partial class personalizar_ropa_talle_color : formulario_estilo,Iobservertraduccion
    {
        public personalizar_ropa_talle_color(idiomas idiomas)
        {
            InitializeComponent();
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idioma = idiomas;
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        idiomas idioma;
        BLLtalles_colores blltalles_colores = new BLLtalles_colores();
        BEtalles_colores variable_select;
        BEtalles_colores variable_ropa_select;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void detalle_rbtm_color_CheckedChanged(object sender, EventArgs e)
        {
            cargar_colores();
        }
        public void actualizar_combobox_ropa()
        {
            if (detalle_rbtm_color1.Checked)
            {
                detalle_rbtm_color1.Checked = false;
                detalle_rbtm_color1.Checked = true;
            }
            else if (detalle_rbtm_talles1.Checked)
            {
                detalle_rbtm_talles1.Checked = false;
                detalle_rbtm_talles1.Checked = true;
            }
        }
        private void btm_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (variable_select==null) throw new Exception("error, seleccione un elemento para borrar.");
                blltalles_colores.borrar_variable(variable_select.codigo);
                if (detalle_rbtm_color.Checked)
                {
                    cargar_colores();
                }else if (detalle_rbtm_talles.Checked)
                {
                    cargar_talle();
                }
                actualizar_combobox_ropa();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btm_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") throw new Exception("error, complete el cuadro de texto.");
                if (detalle_rbtm_color.Checked)
                {
                    BEtalles_colores color = new BEtalles_colores(textBox1.Text,false);
                    blltalles_colores.agregar_variable(color);
                    cargar_colores();
                    
                }else if (detalle_rbtm_talles.Checked)
                {
                    BEtalles_colores talle = new BEtalles_colores(textBox1.Text, true);
                    blltalles_colores.agregar_variable(talle);
                    cargar_talle();
                }
                actualizar_combobox_ropa();


            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void detalle_rbtm_talles_CheckedChanged(object sender, EventArgs e)
        {
            cargar_talle();
        }

        private void personalizar_ropa_talle_color_Load(object sender, EventArgs e)
        {
            cargar_combobox();
            detalle_rbtm_talles.Checked = true;
        }
        public void cargar_combobox()
        {
            comboBox3.DataSource = null;
            comboBox3.DisplayMember = "value";
            comboBox3.ValueMember = "key";
            comboBox3.DataSource = BLL_ropa.leer_tipo_de_ropa().ToList();

        }
        public void cargar_talle()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = blltalles_colores.leer_talles();
        }
        public void cargar_colores()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = blltalles_colores.leer_colores();
        }
        public void cargar_talles_ropa() {
            listBox1.DataSource= null;
            var kv = (KeyValuePair<int, string>)comboBox3.SelectedItem;
            listBox1.DataSource = blltalles_colores.leer_talles_ropa(kv.Key) ;

        }
        public void cargar_colores_ropa()
        {
            listBox1.DataSource = null;
            var kv = (KeyValuePair<int, string>)comboBox3.SelectedItem;
            listBox1.DataSource = blltalles_colores.leer_colores_ropa(kv.Key);
        }

        private void detalle_rbtm_talles1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.DataSource = null;
            comboBox4.DataSource = blltalles_colores.leer_talles();
            cargar_talles_ropa();
        }

        private void detalle_rbtm_color1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.DataSource = null;
            comboBox4.DataSource = blltalles_colores.leer_colores();
            cargar_colores_ropa();

        }

        public void actualizar_idioma()
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variable_select = (BEtalles_colores)dataGridView1.CurrentRow.DataBoundItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.Text == "") throw new Exception("error, seleccione un elemento del cuadro de texto.");
                BEtalles_colores variable = (BEtalles_colores)comboBox4.SelectedItem;
                blltalles_colores.verificar_si_ya_esta_vinculada((List<BEtalles_colores>)listBox1.DataSource,variable);
                blltalles_colores.agregar_variable_ropa(((KeyValuePair<int, string>)comboBox3.SelectedItem).Key,((BEtalles_colores)comboBox4.SelectedItem).codigo);
                if (detalle_rbtm_color1.Checked)
                {
                    cargar_colores_ropa();
                }
                else if (detalle_rbtm_talles1.Checked)
                {
                    cargar_talles_ropa();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (variable_ropa_select == null) throw new Exception("error, seleccione un elemento para borrar.");
                blltalles_colores.borrar_variable_ropa(((KeyValuePair<int, string>)comboBox3.SelectedItem).Key,variable_ropa_select.codigo);
                if (detalle_rbtm_color1.Checked)
                {
                    cargar_colores_ropa();
                }
                else if (detalle_rbtm_talles1.Checked)
                {
                    cargar_talles_ropa();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text=="Buzos") 
            {
                if (detalle_rbtm_color1.Checked)
                {
                    detalle_rbtm_color1.Checked = false;
                    detalle_rbtm_color1.Checked=true;
                }
                else if(detalle_rbtm_talles1.Checked){
                    detalle_rbtm_talles1.Checked = false;
                    detalle_rbtm_talles1.Checked = true;
                }
            }
            else if (comboBox3.Text=="Jogging")
            {
                if (detalle_rbtm_color1.Checked)
                {
                    detalle_rbtm_color1.Checked = false;
                    detalle_rbtm_color1.Checked = true;
                }
                else if (detalle_rbtm_talles1.Checked)
                {
                    detalle_rbtm_talles1.Checked = false;
                    detalle_rbtm_talles1.Checked = true;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            variable_ropa_select = (BEtalles_colores)listBox1.SelectedItem;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
