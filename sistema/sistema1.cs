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
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using sistema;
using Servicios;
using Servicios.observer;
namespace sistema_de_ropa
{
    public partial class sistema1 : Form,Iobservertraduccion
    {
        public sistema1(idiomas idiomas)
        {
            InitializeComponent();
            idioma = idiomas;
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        public static BEpedidos pedido_select { get; set; }
        public static List<BEcliente> lista_cliente { get; set; }
        BLL_cliente bll_cliente = new BLL_cliente();
        BEcliente cliente = new BEcliente();
        BLLPedido bllpedido = new BLLPedido();
        idiomas idioma;
        enum filtro
        { Nombre,DNI }
        enum provincias
        {
            Buenos_Aires, Catamarca, Chaco, Chubut, Córdoba, Corrientes, Entre_Ríos, Formosa, Jujuy, La_Pampa, La_Rioja, Mendoza, Misiones, Neuquén, Río_Negro, Salta, San_Juan, San_Luis, Santa_Cruz, Santa_Fe, Santiago_del_Estero, Tierra_del_Fuego, Tucumán
        }
        
        private void sistema_Load(object sender, EventArgs e)
        {
            limpiar_pedido();
            comboBox2.DataSource = Enum.GetValues(typeof(filtro));
            verificar_permiso_cliente();
            cargar_grilla();
        }
        private void verificar_permiso_cliente()
        {
            sistema_btm_ir_form_cliente.Enabled = false;
            foreach (BEpermiso permiso in sesion.instancia.usuario.permisos)
            {
                if (permiso.nombre == "ABM_clientes")sistema_btm_ir_form_cliente.Enabled = true;
            }
        }
        public void cargar_grilla()
        {
            List<BEcliente> aux = bll_cliente.leer_todo();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aux;
            lista_cliente = null;
            lista_cliente = aux;
        }
        public void limpiar_pedido()
        {
            TEXTO_DESCUENTO.Text = "";
            TEXTO_TOTAL_ROPA.Text = "";
            TEXTO_FECHA_PEDIDO.Text = "";
            listBox1.DataSource = null;
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItems!=null) {
                bllpedido.borrar(pedido_select);
                cargar_grilla();
                limpiar_pedido();

            }
            else { MessageBox.Show("seleccione alguna prenda"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    BEpedidos pedido = new BEpedidos();
                    pedido.descuento = bllpedido.calcular_descuento_pedido(cliente.tipo);
                    bllpedido.guardar_pedido(pedido, cliente.codigo);
                    cargar_grilla();
                    traer_pedidos_cliente();
                    limpiar_pedido();
                }
                else
                {
                    throw new Exception("seleccione un cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch { MessageBox.Show("error, vuelva a intentarlo."); 
        }
    }
        public void mostrar_pedidos()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cliente.pedidos;
            //TEXTO_TOTAL_ROPA.Text = cliente_select.pedido.total_pedido.ToString() ;
            //TEXTO_DESCUENTO.Text = cliente_select.pedido.descuento_de_pedido;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!=null) {
                pedido_select = (BEpedidos)listBox1.SelectedItem;
                TEXTO_TOTAL_ROPA.Text = pedido_select.total.ToString();
                TEXTO_FECHA_PEDIDO.Text = pedido_select.fecha.ToString("yyyy-MM-dd");
                TEXTO_DESCUENTO.Text = pedido_select.descuento.ToString() + "%";
                textBox1.Text= pedido_select.total.ToString();
                textBox3.Text= pedido_select.fecha.ToString("yyyy-MM-dd");
                textBox4.Text= pedido_select.descuento.ToString()+"%";
                textBox5.Text = pedido_select.cantidad_ropa.ToString();

            }
        }


       
        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        public void traer_pedidos_cliente()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cliente.pedidos;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente = (BEcliente)dataGridView1.CurrentRow.DataBoundItem;
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            traer_pedidos_cliente();
            if (cliente != null)
            {
                this.Enabled = true;
            }
            else { this.Enabled = false; }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void comboBox2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void comboBox2_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            buscar_cliente(textBox2.Text,comboBox2.Text);
        }
        public void buscar_cliente(string texto,string filtro)
        {
            if (filtro == "Nombre")
            {
                var filtrados = lista_cliente
                   .Where(c => c.nombre_completo.ToLower().Contains(texto))
                   .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtrados;
            } else if (filtro=="DNI")
            {
                var filtrados = lista_cliente.Where(c => c.DNI.ToString().Contains(texto))
                    .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtrados;
            }
        }

        public void actualizar_clientes()
        {
            lista_cliente = null;
            lista_cliente = bll_cliente.leer_todo();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(this,idioma);
            c.MdiParent = this.MdiParent;
            c.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pedido_select!=null) {
                detalle_pedido d = new detalle_pedido(this,idioma);
                d.MdiParent = this.MdiParent;
                d.Show();
            }
            else { MessageBox.Show("error seleccione un pedido."); }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (pedido_select != null)
            {
                detalle_pedido d = new detalle_pedido(this,idioma);
                d.MdiParent = this.MdiParent;
                d.Show();
            }
            else { MessageBox.Show("error seleccione un pedido."); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void actualizar_idioma()
        {
            sistema_label_buscar_cliente.Text = BLLtraducciones.traducir(sistema_label_buscar_cliente.Name);
            sistema_filtro.Text = BLLtraducciones.traducir(sistema_filtro.Name);
            sistema_btm_ir_form_cliente.Text = BLLtraducciones.traducir(sistema_btm_ir_form_cliente.Name);
            sistema_groupbox_pedidos.Text = BLLtraducciones.traducir(sistema_groupbox_pedidos.Name);
            sistema_total.Text = BLLtraducciones.traducir(sistema_total.Name);
            sistema_total1.Text = BLLtraducciones.traducir(sistema_total1.Name);
            sistema_fecha.Text = BLLtraducciones.traducir(sistema_fecha.Name);
            sistema_fecha1.Text = BLLtraducciones.traducir(sistema_fecha1.Name);
            sistema_descuento.Text = BLLtraducciones.traducir(sistema_descuento.Name);
            sistema_descuento1.Text = BLLtraducciones.traducir(sistema_descuento1.Name);
            sistema_cantidad_ropa.Text = BLLtraducciones.traducir(sistema_cantidad_ropa.Name);
            btm_agregar.Text = BLLtraducciones.traducir(btm_agregar.Name);
            btm_borrar.Text = BLLtraducciones.traducir(btm_borrar.Name);
            sistema_btm_personalizar_pedido.Text = BLLtraducciones.traducir(sistema_btm_personalizar_pedido.Name);

        }

        private void sistema_groupbox_pedidos_Enter(object sender, EventArgs e)
        {
        }

        private void sistema1_FormClosing(object sender, FormClosingEventArgs e)
        {
            idioma.eliminar_observer(this);
        }
    }
}
