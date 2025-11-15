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
using sistema_de_ropa;
using Servicios.observer;
namespace sistema
{
    public partial class detalle_pedido : formulario_estilo, Iobservertraduccion
    {
        public detalle_pedido(idiomas idiomas)
        {
            InitializeComponent();
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idiomas.guardar_observer(this);
            actualizar_idioma(); 
            idioma = idiomas;

        }
        public detalle_pedido(sistema1 s,idiomas idiomas)
        {
            InitializeComponent();
            sistema_padre = s;
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idiomas.guardar_observer(this);
            actualizar_idioma();
            idioma = idiomas;
        }
        idiomas idioma;
        sistema1 sistema_padre;
        BEpedidos_detalle pedido_select = new BEpedidos_detalle();
        BLLPedido bllpedido = new BLLPedido();
        BLLtalles_colores blltalles_colores = new BLLtalles_colores();
        
        enum si_no
        { SI, NO }
        private void detalle_pedido_Load(object sender, EventArgs e)
        {
            cargar_pedidos_detalles();
            cargar_combobox_tipo_prenda();
            cargar_combobox_talles_colores();
            comboBox1.DataSource = Enum.GetValues(typeof(si_no));
        }
        public void cargar_combobox_tipo_prenda()
        {
            comboBox4.DataSource = null;
            comboBox4.DisplayMember = "value";
            comboBox4.ValueMember = "key";
            comboBox4.DataSource = BLL_ropa.leer_tipo_de_ropa().ToList();
        }
        public void  cargar_combobox_talles_colores()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = blltalles_colores.leer_colores_ropa(((KeyValuePair<int, string>)comboBox4.SelectedItem).Key);
            comboBox3.DataSource = null;
            comboBox3.DataSource = blltalles_colores.leer_talles_ropa(((KeyValuePair<int, string>)comboBox4.SelectedItem).Key);

        }
        public void cargar_pedidos_detalles()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = bllpedido.leer_pedido_detalle(sistema1.pedido_select.codigo); 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                pedido_select = (BEpedidos_detalle)listBox1.SelectedItem;
                textBox1.Text = pedido_select.cantidad.ToString();
                Dictionary<string, int> elemento = new Dictionary<string, int>();
                if (pedido_select.ropa is BEbuzos)
                {
                    comboBox4.SelectedValue = 1; 
                }
                else if (pedido_select.ropa is BEjogging)
                {
                    comboBox4.SelectedValue = 2;
                }
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BEpedidos_detalle pedido_detalle = new BEpedidos_detalle();
                if (comboBox4.Text == "Buzos" )
                {
                    BEbuzos buzos = new BEbuzos(comboBox2.Text, comboBox3.Text, comboBox1.Text);
                    pedido_detalle.ropa = buzos;
                }
                else if (comboBox4.Text == "Jogging")
                {
                    BEjogging jogging = new BEjogging(comboBox2.Text.ToString(), comboBox3.Text);
                    pedido_detalle.ropa = jogging;
                }
                pedido_detalle.cantidad = Convert.ToInt32(textBox1.Text);
                pedido_detalle.codigo_pedido = sistema1.pedido_select.codigo;
                bllpedido.alta(pedido_detalle);
                cargar_pedidos_detalles();

            }
            catch { MessageBox.Show("error, vuelva a intentarlo."); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                BEpedidos_detalle pedido_detalle = new BEpedidos_detalle();
                if (listBox1.SelectedItem != null)
                {
                    if (comboBox4.Text=="Buzos" && pedido_select.ropa is BEbuzos)
                    {
                        BEbuzos buzos = new BEbuzos(comboBox2.Text,comboBox3.Text, comboBox1.Text);
                        pedido_detalle.ropa = buzos;
                    }
                    else if (comboBox4.Text == "Jogging" && pedido_select.ropa is BEjogging)
                    {
                        BEjogging jogging = new BEjogging(comboBox2.Text.ToString(), comboBox3.Text);
                        pedido_detalle.ropa = jogging;
                    }
                    else{ throw new Exception("error, no se puede modificar la misma prenda cambiado el tipo de ropa."); }
                    pedido_detalle.cantidad = Convert.ToInt32(textBox1.Text);
                    pedido_detalle.codigo_pedido = sistema1.pedido_select.codigo;
                    pedido_detalle.codigo = pedido_select.codigo;
                    pedido_detalle.ropa.codigo = pedido_select.ropa.codigo;
                    bllpedido.modificar(pedido_detalle);
                    cargar_pedidos_detalles();
                }
                else { throw new Exception("error, seleccione un detalle de pedido"); }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems != null)
            {
                DialogResult = MessageBox.Show("esta seguro que desea eliminar ese elemento del pedido","confirmar eliminación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                bllpedido.borrar_pedido_detalle(pedido_select);
                cargar_pedidos_detalles();
            }
            else { MessageBox.Show("seleccione alguna prenda"); }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void detalle_pedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            sistema_padre.cargar_grilla();
            sistema_padre.limpiar_pedido();
            idioma.eliminar_observer(this);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            detalle_capucha.Visible = false;
            comboBox1.Visible = false;
        }

        public void actualizar_idioma()
        {
            detalle_colores.Text = BLLtraducciones.traducir(detalle_colores.Name);
            detalle_talles.Text = BLLtraducciones.traducir(detalle_talles.Name);
            detalle_cantidad.Text = BLLtraducciones.traducir(detalle_cantidad.Name);
            detalle_capucha.Text = BLLtraducciones.traducir(detalle_capucha.Name);
            btm_agregar.Text = BLLtraducciones.traducir(btm_agregar.Name);
            btm_modificar.Text = BLLtraducciones.traducir(btm_modificar.Name);
            btm_borrar.Text = BLLtraducciones.traducir(btm_borrar.Name);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox4.Text == "Buzos") 
            {
                detalle_capucha.Visible = true;
                comboBox1.Visible = true;
                cargar_combobox_talles_colores();
            }
            else if(comboBox4.Text == "Jogging")
            {
                detalle_capucha.Visible = false;
                comboBox1.Visible = false;
                cargar_combobox_talles_colores();
            }
        }
    }
}
