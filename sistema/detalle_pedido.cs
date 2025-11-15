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
        enum si_no
        { SI, NO }
        public void activar_checklistbox()
        {
            checkedListBox1.ClearSelected();
            checkedListBox2.ClearSelected();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }
            string[] lista;
            lista = pedido_select.ropa.talles.Split(',');
            foreach (string talle in lista)
            {
                string talle1 = talle.Trim().ToUpper();
                switch (talle1)
                {
                    case "M": checkedListBox1.SetItemChecked(0, true); break;
                    case "L": checkedListBox1.SetItemChecked(1, true); break;
                    case "XL": checkedListBox1.SetItemChecked(2, true); break;
                    case "XXL": checkedListBox1.SetItemChecked(3, true); break;
                    case "XXXL": checkedListBox1.SetItemChecked(4, true); break;
                }
            }
            string[] lista1;
            lista1 = pedido_select.ropa.colores.Split(',');
            foreach (string color in lista1)
            {
                string color1 = color.Trim().ToUpper();
                switch (color1)
                {
                    case "NEGRO": checkedListBox2.SetItemChecked(0, true); break;
                    case "BLANCO": checkedListBox2.SetItemChecked(1, true); break;
                    case "BORDO": checkedListBox2.SetItemChecked(2, true); break;
                    case "MARRON": checkedListBox2.SetItemChecked(3, true); break;
                    case "VERDE": checkedListBox2.SetItemChecked(4, true); break;
                    case "BEIGE": checkedListBox2.SetItemChecked(5, true); break;
                }

            }
        }
        private void detalle_pedido_Load(object sender, EventArgs e)
        {
            cargar_pedidos_detalles();
            comboBox1.DataSource = Enum.GetValues(typeof(si_no));
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
                activar_checklistbox();
                if (pedido_select.ropa is BEbuzos)
                {
                    detalle_rbtm_buzos.Checked = true;
                }
                else if (pedido_select.ropa is BEjogging)
                {
                    detalle_rbtm_jogging.Checked = true;
                }
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            checkedListBox2.ItemCheck -= checkedListBox2_ItemCheck;

            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (i != e.Index)
                    checkedListBox2.SetItemChecked(i, false);
            }

            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BEpedidos_detalle pedido_detalle = new BEpedidos_detalle();
                if (detalle_rbtm_buzos.Checked) 
                {
                    BEbuzos buzos = new BEbuzos(checkedListBox2.CheckedItems[0].ToString(), checkedListBox1.CheckedItems[0].ToString(),comboBox1.Text);
                    pedido_detalle.ropa = buzos;
                }
                else if(detalle_rbtm_jogging.Checked)
                {
                    BEjogging jogging = new BEjogging(checkedListBox2.CheckedItems[0].ToString(), checkedListBox1.CheckedItems[0].ToString());
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
                    if (detalle_rbtm_buzos.Checked && pedido_select.ropa is BEbuzos)
                    {
                        BEbuzos buzos = new BEbuzos(checkedListBox2.CheckedItems[0].ToString(), checkedListBox1.CheckedItems[0].ToString(), comboBox1.Text);
                        pedido_detalle.ropa = buzos;
                    }
                    else if (detalle_rbtm_jogging.Checked && pedido_select.ropa is BEjogging)
                    {
                        BEjogging jogging = new BEjogging(checkedListBox2.CheckedItems[0].ToString(), checkedListBox1.CheckedItems[0].ToString());
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

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != e.Index)
                    checkedListBox1.SetItemChecked(i, false);
            }

            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            detalle_capucha.Visible = true;
                comboBox1.Visible= true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            detalle_capucha.Visible = false;
            comboBox1.Visible = false;
        }

        public void actualizar_idioma()
        {
            detalle_rbtm_buzos.Text = BLLtraducciones.traducir(detalle_rbtm_buzos.Name);
            detalle_rbtm_jogging.Text = BLLtraducciones.traducir(detalle_rbtm_jogging.Name);
            detalle_colores.Text = BLLtraducciones.traducir(detalle_colores.Name);
            detalle_talles.Text = BLLtraducciones.traducir(detalle_talles.Name);
            detalle_cantidad.Text = BLLtraducciones.traducir(detalle_cantidad.Name);
            detalle_capucha.Text = BLLtraducciones.traducir(detalle_capucha.Name);
            btm_agregar.Text = BLLtraducciones.traducir(btm_agregar.Name);
            btm_modificar.Text = BLLtraducciones.traducir(btm_modificar.Name);
            btm_borrar.Text = BLLtraducciones.traducir(btm_borrar.Name);
        }
    }
}
