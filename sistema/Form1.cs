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
using Servicios;
using Servicios.observer;
using sistema_de_ropa;
namespace sistema
{
    public partial class Form1 : Form,Iobservertraduccion
    {
        public Form1(idiomas idiomas)
        {
            InitializeComponent();
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idioma = idiomas;
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        idiomas idioma;
        BLLusuario bllusuario = new BLLusuario();
        bllregistro bllregistro = new bllregistro();
        usuarios u;
        sesion1 s;
        idioma idi;
        sistema1 sist;
        Cliente c;
        

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u = new usuarios(idioma);
            cerrar_formularios();
            u.MdiParent = this;
            u.Dock = DockStyle.Fill;
            u.FormBorderStyle = FormBorderStyle.None;
            u.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = new sesion1(this,idioma);
            cerrar_formularios();
            s.MdiParent = this;
            s.Dock = DockStyle.Fill;
            s.FormBorderStyle = FormBorderStyle.None;
            s.Show();
        }
        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            idi = new idioma(this,idioma);
            cerrar_formularios();
            idi.MdiParent = this;
            idi.Dock = DockStyle.Fill;
            idi.FormBorderStyle = FormBorderStyle.None;
            idi.Show();

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            poner_nombre_usuario_label();
            activar_permisos();
            cargar_idiomas_combobox(idioma.Idioma);
            if (sesion.instancia != null)
            {
                activar_y_desactivar_login_logout();
            }
        }
        public void cargar_idiomas_combobox(string idioma_actual)
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = idiomas.leer_idiomas();
            comboBox1.Text = idioma_actual;
        }
        public void poner_nombre_usuario_label()
        {
            label2.Text =bllusuario.desencrytar_nombre(sesion.instancia.usuario.nombre);
        }
        public void activar_permisos()
        {
            desactivar_form();
            permisos_menu.DropDownItems.Clear();
            try
            {
                if (sesion.instancia.usuario.permisos != null)
                {
                    permisos_menu.Enabled = true;
                    foreach (BEpermiso permiso in sesion.instancia.usuario.permisos)
                    {
                        switch (permiso.nombre)
                        {
                            case "Ver_reportes":
                                reportes_menu.Enabled = true;
                                permisos_menu.DropDownItems.Add("Ver_reportes");
                                break;

                            case "Entrar_Sistema":
                                sistema_menu.Enabled = true;
                                permisos_menu.DropDownItems.Add("Entrar_Sistema");
                                break;
                            case "ABM_Idioma":
                                idioma2_menu.Enabled = true;
                                permisos_menu.DropDownItems.Add("ABM_Idioma");
                                break;
                            case "ABM_usuario":
                                usuarios_menu.Enabled = true;
                                permisos_menu.DropDownItems.Add("ABM_usuario");
                                break;
                            case "ABM_clientes":
                                menu_clientes.Enabled = true;
                                permisos_menu.DropDownItems.Add("ABM_clientes");
                                break;
                            case "ABM_permisos":
                                menu_ABMPermisos.Enabled = true;
                                permisos_menu.DropDownItems.Add("ABM_permisos");
                                break;
                            case "Ver_bitacora":
                                menu_bitacora.Enabled = true;
                                permisos_menu.DropDownItems.Add("Ver_Bitacora");
                                break;
                            default:
                                break;
                        }


                    }
                }
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        public void actualizar_idioma()
        {
            usuarios_menu.Text = BLLtraducciones.traducir(usuarios_menu.Name);
            login_menu.Text = BLLtraducciones.traducir(login_menu.Name);
            reportes_menu.Text = BLLtraducciones.traducir(reportes_menu.Name);
            sistema_menu.Text = BLLtraducciones.traducir(sistema_menu.Name);
            CERRAR_SESION_MENU.Text = BLLtraducciones.traducir(CERRAR_SESION_MENU.Name);
            permisos_menu.Text = BLLtraducciones.traducir(permisos_menu.Name);
            idioma2_menu.Text = BLLtraducciones.traducir(idioma2_menu.Name);
            menu_label_usuario.Text = BLLtraducciones.traducir(menu_label_usuario.Name);
            menu_clientes.Text = BLLtraducciones.traducir(menu_clientes.Name);
            menu_bitacora.Text = BLLtraducciones.traducir(menu_bitacora.Name);

        }
        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ingles_menu_Click(object sender, EventArgs e)
        {
        }

        private void reportes_menu_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sesion.instancia != null)
            {
                BEregistro registro = new BEregistro(bllusuario.get_nombre(sesion.instancia.usuario), "cerrar sesion");
                bllregistro.guardar_registro(registro);
                sesion.Logout();
                cerrar_formularios();
                login_menu.Enabled = true;
                label2.Text = "";
                CERRAR_SESION_MENU.Enabled = false;
                desactivar_form();
                menu_label_usuario.Text = "";// label de usuario
                MessageBox.Show("Se cerro sesion con exito.");
                
            }
            else 
            {
                MessageBox.Show("error, La sesion ya estaba cerrada.");
            }
        }
        public void activar_y_desactivar_login_logout()
        {
            login_menu.Enabled = false;
            CERRAR_SESION_MENU.Enabled = true;
        }
        public void desactivar_form()
        {
            permisos_menu.Enabled = false;
            menu_ABMPermisos.Enabled = false;
            menu_bitacora.Enabled = false;
            reportes_menu.Enabled = false;
            idioma2_menu.Enabled = false;
            sistema_menu.Enabled = false;
            menu_clientes.Enabled = false;
            usuarios_menu.Enabled = false;
        }
        public void cerrar_formularios()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sist = new sistema1(idioma);
            cerrar_formularios();
            sist.MdiParent = this;
            sist.Dock = DockStyle.Fill;
            sist.FormBorderStyle = FormBorderStyle.None;
            sist.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = new Cliente(idioma);
            cerrar_formularios();
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.FormBorderStyle = FormBorderStyle.None;
            
            c.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aBMPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            composite c = new composite(idioma);
            cerrar_formularios();
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.FormBorderStyle = FormBorderStyle.None;
            c.Show();
        }

        private void bitacoraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bitacora b = new bitacora(idioma);
            cerrar_formularios();
            b.MdiParent = this;
            b.Dock = DockStyle.Fill;
            b.FormBorderStyle = FormBorderStyle.None;
            b.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BLLtraducciones.cargar_listatraducciones(comboBox1.Text);
            idioma.Idioma=comboBox1.Text;
        }
    }
}
