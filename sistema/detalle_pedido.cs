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
namespace sistema
{
    public partial class detalle_pedido : Form
    {
        public detalle_pedido()
        {
            InitializeComponent();
        }
        public detalle_pedido(sistema1 s)
        {
            InitializeComponent();
            sistema_padre = s;
        }
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
                    radioButton1.Checked = true;
                }
                else if (pedido_select.ropa is BEjogging)
                {
                    radioButton2.Checked = true;
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
                if (radioButton1.Checked) 
                {
                    BEbuzos buzos = new BEbuzos(get_iteam_marcado("caso1").ToString(), get_iteam_marcado("caso2").ToString(),comboBox1.Text);
                    pedido_detalle.ropa = buzos;
                }
                else if(radioButton2.Checked)
                {
                    BEjogging jogging = new BEjogging(get_iteam_marcado("caso1").ToString(), get_iteam_marcado("caso2").ToString());
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
                    if (radioButton1.Checked)
                    {
                        BEbuzos buzos = new BEbuzos(checkedListBox2.SelectedItem.ToString(), checkedListBox1.SelectedItem.ToString(), comboBox1.Text);
                        pedido_detalle.ropa = buzos;
                    }
                    else if (radioButton2.Checked)
                    {
                        BEjogging jogging = new BEjogging(checkedListBox2.SelectedItem.ToString(), checkedListBox1.SelectedItem.ToString());
                        pedido_detalle.ropa = jogging;
                    }
                    pedido_detalle.cantidad = Convert.ToInt32(textBox1.Text);
                    pedido_detalle.codigo_pedido = sistema1.pedido_select.codigo;
                    pedido_detalle.codigo = pedido_select.codigo;
                    pedido_detalle.ropa.codigo = pedido_select.ropa.codigo;
                    bllpedido.modificar(pedido_detalle);
                    cargar_pedidos_detalles();
                }
            }
            catch { MessageBox.Show("error, vuelva a intentarlo."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems != null)
            {
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
        }

        public object get_iteam_marcado(string caso)
        {
            if (caso=="caso2") {
                if (checkedListBox1.CheckedItems.Count == 0)
                {
                    return null;
                }
                else
                {
                    return checkedListBox1.CheckedItems[0];
                } 
            }else if (caso == "caso1")
            {
                if (checkedListBox2.CheckedItems.Count == 0)
                {
                    return null;
                }
                else
                {
                    return checkedListBox2.CheckedItems[0];
                }
            }
            return null;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
                comboBox1.Visible= true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            comboBox1.Visible = false;
        }
    }
}
