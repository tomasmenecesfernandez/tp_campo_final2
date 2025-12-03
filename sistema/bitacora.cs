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
using Servicios;

namespace sistema
{
    public partial class bitacora : formulario_estilo, Iobservertraduccion
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
        List<BEregistro> lista_de_registro = new List<BEregistro>();
        private void bitacora_Load(object sender, EventArgs e)
        {
            cargar_grilla1();
            comboBox2.Text = "Nombre";
        }

        public void buscar_bitacora(string texto, string filtro)
        {
            if (filtro == "Nombre")
            {
                var filtrados = lista_de_registro
                    .Where(c => c.nombre.ToLower().Contains(texto))
                   .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtrados;
            }
            else if (filtro == "Fecha")
            {
                var filtrados = lista_de_registro.Where(c => c.fecha.ToString().Contains(texto))
                    .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtrados;
            }
        }
        public void cargar_grilla1()
        {
            dataGridView1.DataSource = null;
            lista_de_registro = serializacion.LeerObjetos<BEregistro>();
            dataGridView1.DataSource = lista_de_registro;
        }

        public void actualizar_idioma()
        {
            lbl_buscar_bitacora.Text = BLLtraducciones.traducir(lbl_buscar_bitacora.Name);
            sistema_filtro.Text = BLLtraducciones.traducir(sistema_filtro.Name);

        }

        private void bitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            idioma.eliminar_observer(this);
        }

        private void bitacora_label_bitacora_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            buscar_bitacora(textBox2.Text, comboBox2.Text);
        }
    }
}
