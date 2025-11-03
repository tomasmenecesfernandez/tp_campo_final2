using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.observer;
using BLL;
namespace sistema
{
    public partial class formulario_datos_compostite : Form,Iobservertraduccion
    {
        public formulario_datos_compostite(composite form_papa,  string caso, idiomas idiomas)
        {
            InitializeComponent();
            form_padre = form_papa;
            caso_actual = caso;
            actualizar_idioma();
        }
        composite form_padre;
        string caso_actual;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="") {
                if (caso_actual == "modificar")
                {
                    form_padre.modificar_rol_formulario(textBox1.Text);
                }
                else if (caso_actual == "agregar_nodo")
                {
                    form_padre.agregar_rol_formulario(textBox1.Text);
                }
                this.Close();
            }
            else { MessageBox.Show("error, complete el cuadro de texto."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formulario_datos_compostite_Load(object sender, EventArgs e)
        {

        }

        public void actualizar_idioma()
        {
            btm_guardar.Text = BLLtraducciones.traducir(btm_guardar.Name);
            btm_cancelar.Text = BLLtraducciones.traducir(btm_cancelar.Name);
            form_extra_label_nombre_rol.Text = BLLtraducciones.traducir(form_extra_label_nombre_rol.Name);
        }

        private void formulario_datos_compostite_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void formulario_datos_compostite_LocationChanged(object sender, EventArgs e)
        {

        }
    }
}
