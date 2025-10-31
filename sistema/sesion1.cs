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
using Servicios;
using BLL;
using Servicios.observer;
namespace sistema
{
    public partial class sesion1 : Form,Iobservertraduccion
    {
        public sesion1()
        {
            InitializeComponent();
        }
        public sesion1(Form1 form)
        {
            InitializeComponent();
            form_padre = form;
        }
        Form1 form_padre;
        public static BEusuario usuario;
        BLLusuario bllusuario = new BLLusuario();
        BLLtraducciones blltraducciones = new BLLtraducciones();
        idiomas idiomas = new idiomas();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sesion.instancia == null) {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        usuario = new BEusuario(textBox1.Text.Trim(), textBox2.Text.Trim());
                        bllusuario.login(usuario);
                        abrir_formulario();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(" Complete los cuadros de textos usuario y contraseña.");
                    } 
                }
                else { MessageBox.Show("error, la sesion del usuario ya esta activa."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void abrir_formulario()
        {
            if (form_padre == null)
            {
                Form1 f = new Form1();
                f.Show();
            }

        }
        public  void actualizar_idioma()
        {
            usuario_label2.Text = blltraducciones.traducir(usuario_label2.Name);
            contraseña_label2.Text = blltraducciones.traducir(contraseña_label2.Name);
            agregar_boton2.Text = blltraducciones.traducir(agregar_boton2.Name);
        }
        public void verificar_digito_verificador()
        {
            try
            {
                idiomas.leer_idiomas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
        private void sesion1_Load(object sender, EventArgs e)
        {
            if(idiomas.lista_traducciones.Count>0)
            {
                actualizar_idioma();
            }
            verificar_digito_verificador();
            textBox1.Text = "tomi";
            textBox2.Text = "1234";
        }


    }
}
