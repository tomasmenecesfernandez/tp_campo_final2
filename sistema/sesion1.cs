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
                        idiomas = new idiomas(comboBox1.Text);
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
            else
            {
                form_padre.activar_permisos();
                form_padre.activar_y_desactivar_login_logout();
                form_padre.poner_nombre_usuario_label();
            }

        }
        public  void actualizar_idioma()
        {
            usuario_label2.Text = BLLtraducciones.traducir(usuario_label2.Name);
            contraseña_label2.Text = BLLtraducciones.traducir(contraseña_label2.Name);
            agregar_boton2.Text = BLLtraducciones.traducir(agregar_boton2.Name);
        }
        
        private void sesion1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource= idiomas.leer_idiomas();
            textBox1.Text = "tomi";
            textBox2.Text = "1234";
        }


    }
}
