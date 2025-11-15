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
    public partial class sesion1 : formulario_estilo,Iobservertraduccion
    {
        public sesion1()
        {
            InitializeComponent();
        }
        public sesion1(Form1 form, idiomas idiomas1)
        {
            InitializeComponent();
            form_padre = form;
            idiomas = idiomas1;
            idioma = idiomas;
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        idiomas idioma;
        Form1 form_padre;
        public static BEusuario usuario;
        BLLusuario bllusuario = new BLLusuario();
        idiomas idiomas;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sesion.instancia == null) {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        usuario = new BEusuario(textBox1.Text.Trim(), textBox2.Text.Trim());
                        bllusuario.login(usuario);
                        BLLtraducciones.cargar_listatraducciones(comboBox1.Text);
                        idiomas = new idiomas();
                        idiomas.Idioma = comboBox1.Text;
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
                Form1 f = new Form1(idiomas);
                f.Show();
            }
            else
            {
                form_padre.activar_permisos();
                form_padre.cargar_idiomas_combobox(idiomas.Idioma);
                form_padre.activar_y_desactivar_login_logout();
                form_padre.poner_nombre_usuario_label();
            }

        }
        public  void actualizar_idioma()
        {
            usuario_label2.Text = BLLtraducciones.traducir(usuario_label2.Name);
            contraseña_label2.Text = BLLtraducciones.traducir(contraseña_label2.Name);
            sesion_ingresar.Text = BLLtraducciones.traducir(sesion_ingresar.Name);
            label_idioma.Text = BLLtraducciones.traducir(label_idioma.Name);
        }
        
        private void sesion1_Load(object sender, EventArgs e)
        {comboBox1.DataSource = null;
            comboBox1.DataSource= idiomas.leer_idiomas();
            textBox1.Text = "tomi";
            textBox2.Text = "1234";
        }

        private void sesion1_FormClosing(object sender, FormClosingEventArgs e)
        {
                if(form_padre!=null)idioma.eliminar_observer(this);
        }
    }
}
