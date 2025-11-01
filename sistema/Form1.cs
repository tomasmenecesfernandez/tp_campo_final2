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
namespace sistema
{
    public partial class Form1 : Form,Iobservertraduccion
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLLusuario bllusuario = new BLLusuario();
        bllregistro bllregistro = new bllregistro();
        usuarios u;
        sesion1 s;
        idioma idi;
        sistema sist;
        Cliente c;
        BLLtraducciones traducciones = new BLLtraducciones();
         public idiomas idiomas = new idiomas();

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u = new usuarios();
            cerrar_formularios();
            u.MdiParent = this;
            u.Dock = DockStyle.Fill;
            u.FormBorderStyle = FormBorderStyle.None;
            u.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = new sesion1(this);
            cerrar_formularios();
            s.MdiParent = this;
            s.Dock = DockStyle.Fill;
            s.FormBorderStyle = FormBorderStyle.None;
            s.Show();
        }
        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            idi = new idioma();
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
            idiomas = new idiomas("Español");
            if (sesion.instancia != null)
            {
                activar_y_desactivar_login_logout();
            }
        }
        public void poner_nombre_usuario_label()
        {
            label1.Text = "USER: " + bllusuario.desencrytar_nombre(sesion.instancia.usuario.nombre);
        }
        public void activar_permisos()
        {
            desactivar_form();
            permisos_menu.DropDownItems.Clear();
            try
            {
                if (sesion.instancia.usuario.permisos != null)
                {
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
                                clientes_menu.Enabled = true;
                                permisos_menu.DropDownItems.Add("ABM_clientes");
                                break;
                            case "Ver_Bitacora":
                                form1_bitacora_menu.Enabled = true;
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
            usuarios_menu.Text = traducciones.traducir(usuarios_menu.Name);
            login_menu.Text = traducciones.traducir(login_menu.Name);
            reportes_menu.Text = traducciones.traducir(reportes_menu.Name);
            idioma_menu.Text = traducciones.traducir(idioma_menu.Name);
            sistema_menu.Text = traducciones.traducir(sistema_menu.Name);
            CERRAR_SESION_MENU.Text = traducciones.traducir(CERRAR_SESION_MENU.Name);
            permisos_menu.Text = traducciones.traducir(permisos_menu.Name);
            idioma2_menu.Text = traducciones.traducir(idioma2_menu.Name);
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
                CERRAR_SESION_MENU.Enabled = false;
                desactivar_form();
                label1.Text = "";// label de usuario
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
            form1_bitacora_menu.Enabled = false;
            reportes_menu.Enabled = false;
            idioma2_menu.Enabled = false;
            sistema_menu.Enabled = false;
            clientes_menu.Enabled = false;
            usuarios_menu.Enabled = false;
        }
        public void cerrar_formularios()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        private void idioma_menu_Click(object sender, EventArgs e)
        {
            mostrar_idiomas(idiomas.leer_idiomas());
        }
        public void mostrar_idiomas(List<idiomas> lista)
        {
            idioma_menu.DropDownItems.Clear();
            foreach (idiomas idioma in lista) {
                ToolStripMenuItem idiomaItem = new ToolStripMenuItem(idioma.Idioma);

                idiomaItem.Click += (x, e) =>
                {
                    idiomas = new idiomas(idioma.Idioma);
                    actualizar_idioma();
                    if (u != null)
                    {
                        u.actualizar_idioma();
                    }
                    if (s != null)
                    {
                        s.actualizar_idioma();
                    }
                    if (idi!=null)
                    {
                        idi.actualizar_idioma();
                    }
                    if(sist!=null){
                        sist.actualizar_idioma();
                    }
                };
                idioma_menu.DropDownItems.Add(idiomaItem);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sist = new sistema();
            cerrar_formularios();
            sist.MdiParent = this;
            sist.Dock = DockStyle.Fill;
            sist.FormBorderStyle = FormBorderStyle.None;
            sist.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = new Cliente();
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
            composite c = new composite();
            cerrar_formularios();
            c.MdiParent = this;
            c.Dock = DockStyle.Fill;
            c.FormBorderStyle = FormBorderStyle.None;
            c.Show();
        }

        private void bitacoraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bitacora b = new bitacora();
            cerrar_formularios();
            b.MdiParent = this;
            b.Dock = DockStyle.Fill;
            b.FormBorderStyle = FormBorderStyle.None;
            b.Show();
        }
    }
}
