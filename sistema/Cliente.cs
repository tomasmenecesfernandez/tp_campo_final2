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
using BE;
using sistema_de_ropa;
using Servicios.observer;
namespace sistema
{
    public partial class Cliente : formulario_estilo, Iobservertraduccion
    {
        public Cliente(idiomas idiomas)
        {
            InitializeComponent();
            idioma = idiomas;
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        public Cliente(sistema1 s,idiomas idiomas)
        {
            InitializeComponent();
            form_padre = s;
            idioma = idiomas;
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        idiomas idioma;
        sistema1 form_padre;
        BLL_Localidad bll_localidad = new BLL_Localidad();
        BEcliente cliente = new BEcliente();
        BLL_cliente bll_cliente = new BLL_cliente();
        public static List<BEcliente> lista_cliente { get; set; }
        
        enum provincias
        {
            Buenos_Aires, Catamarca, Chaco, Chubut, Córdoba, Corrientes, Entre_Ríos, Formosa, Jujuy, La_Pampa, La_Rioja, Mendoza, Misiones, Neuquén, Río_Negro, Salta, San_Juan, San_Luis, Santa_Cruz, Santa_Fe, Santiago_del_Estero, Tierra_del_Fuego, Tucumán
        }
        public void cargar_localidades()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = bll_localidad.leer_localidades();
        }
        public void cargar_grilla()
        {
            List<BEcliente> aux = bll_cliente.leer_todo();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aux;
            lista_cliente = null;
            lista_cliente = aux;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text!="" && textBox3.Text!="") {
                    cliente = new BEcliente(textBox2.Text, Convert.ToInt32(textBox3.Text), comboBox3.Text, (BElocalidad)comboBox2.SelectedItem);
                    bll_cliente.alta(cliente);
                    cargar_grilla();
                }
                else { throw new Exception("complete los datos de los cuadros."); }

            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    if (textBox2.Text != "" && textBox3.Text != "" && comboBox2.Text!="" && comboBox3.Text!="")
                    {
                        int codigo_actual = cliente.codigo;
                    cliente = new BEcliente(textBox2.Text, Convert.ToInt32(textBox3.Text), comboBox3.Text, (BElocalidad)comboBox2.SelectedItem);
                    cliente.codigo = codigo_actual;
                    bll_cliente.modificar(cliente);
                    cargar_grilla();
                    }
                    else { throw new Exception("complete los datos de los cuadros."); }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("seleccione algun cliente."); }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    bll_cliente.borrar(cliente);
                    cargar_grilla();
                }
                catch { MessageBox.Show("error datos incorrectos."); }
            }
            else { MessageBox.Show("seleccione algun cliente."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            localidad l = new localidad(this,idioma);
            l.MdiParent = this.MdiParent;
            l.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente = (BEcliente)dataGridView1.CurrentRow.DataBoundItem;
            textBox2.Text = cliente.nombre_completo;
            textBox3.Text = cliente.DNI.ToString();
            comboBox3.Text = cliente.provincia;
            comboBox2.Text = cliente.localidad.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            comboBox3.DataSource = Enum.GetValues(typeof(provincias));
            cargar_grilla();
            cargar_localidades();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
                if(form_padre!=null)form_padre.cargar_grilla();
            idioma.eliminar_observer(this);
        }

        public void actualizar_idioma()
        {
            clientes_groupbox_cliente.Text = BLLtraducciones.traducir(clientes_groupbox_cliente.Name);
            clientes_nombre_completo.Text = BLLtraducciones.traducir(clientes_nombre_completo.Name);
            clientes_DNI.Text = BLLtraducciones.traducir(clientes_DNI.Name);
            clientes_provincia.Text = BLLtraducciones.traducir(clientes_provincia.Name);
            label_localidad.Text = BLLtraducciones.traducir(label_localidad.Name);
            clientes_btm_form_localidad.Text = BLLtraducciones.traducir(clientes_btm_form_localidad.Name);
            btm_agregar.Text = BLLtraducciones.traducir(btm_agregar.Name);
            btm_modificar.Text = BLLtraducciones.traducir(btm_modificar.Name);
            btm_borrar.Text = BLLtraducciones.traducir(btm_borrar.Name);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_localidad_Click(object sender, EventArgs e)
        {

        }

        private void clientes_provincia_Click(object sender, EventArgs e)
        {

        }
    }
}
