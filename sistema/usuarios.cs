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
    public partial class usuarios : Form,Iobservertraduccion
    {
        public usuarios()
        {
            InitializeComponent();
        }
        public usuarios(idiomas idiomas)
        {
            InitializeComponent();
            idioma = idiomas;
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        idiomas idioma;
        List<BEusuario> lista_usuarios = new List<BEusuario>();
        List<BEpermiso> lista_permisos = new List<BEpermiso>();
        BEusuario usuario;
        BLLusuario bllusuario = new BLLusuario();
        BLLrol bllrol = new BLLrol();
        BEpermisoComponente nodo_seleccionado;
        BEcontrolCambioUsuario controlusuario_select = new BEcontrolCambioUsuario();
        BLLpermiso bllpermiso = new BLLpermiso();
        BLLcontrolUsuario bllcontrolusuario = new BLLcontrolUsuario();
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //SFSSSD
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    usuario = new BEusuario(textBox1.Text, textBox2.Text);
                    bllusuario.alta(usuario);
                    BEcontrolCambioUsuario control = new BEcontrolCambioUsuario(usuario);
                    bllcontrolusuario.agregar_control_usuario(control);
                    mostrar_data();   
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("complete los cuadros de texto."); }
        }
#region funciones_para_mostrar
        public void mostrar_data()
        {
            try {
                lista_usuarios = bllusuario.leer_usuario();
                dataGridView1.DataSource = lista_usuarios;
            }
            catch { }
        }
        public void mostrar_treeview(List<BEpermisoComponente> lista,TreeNodeCollection nodos)
        {


            foreach (BEpermisoComponente nodo in lista)
            {
                TreeNode nodo1 = new TreeNode(nodo.nombre);
                nodo1.Tag = nodo; // guardo el objeto en Tag para futuras referencias

                nodos.Add(nodo1);

                // Si tiene hijos, llamo recursivamente pasando los nodos hijos
                if (nodo.obtener_hijos().Count > 0)
                {
                    mostrar_treeview(nodo.obtener_hijos(), nodo1.Nodes);
                }

            }
        }
#endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario = (BEusuario)dataGridView1.CurrentRow.DataBoundItem;
            textBox1.Text = usuario.nombre;
            textBox2.Text = string.Empty;
            treeView1.Nodes.Clear();
            mostrar_treeview(bllrol.traer_permisos_usuario(usuario), treeView1.Nodes);
            treeView1.ExpandAll();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                try
                {
                    if (textBox1.Text!="" && textBox2.Text!="") {
                        usuario.nombre = textBox1.Text;
                        usuario.contraseña=textBox2.Text;
                        usuario = bllusuario.encrytar_usuario(usuario);
                        bllusuario.modificar(usuario);
                        BEcontrolCambioUsuario controlusuario = new BEcontrolCambioUsuario(usuario);
                        bllcontrolusuario.agregar_control_usuario(controlusuario);
                        mostrar_data();
                    }
                    else
                    {
                        throw new Exception("Complete los cuadros de nombre y contraseña.");
                    }
                }
                catch (Exception ex){ MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("seleccione un usuario.");
            }
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            usuario_rbtm_rol.Checked = true;
            lista_permisos = bllpermiso.leer_permisos();
            mostrar_data();

        }
        public void actualizar_idioma()
        {
                usuario_label1.Text = BLLtraducciones.traducir(usuario_label1.Name);
                contraceña_label1.Text = BLLtraducciones.traducir(contraceña_label1.Name);
                btm_agregar.Text = BLLtraducciones.traducir(btm_agregar.Name);
                btm_modificar.Text = BLLtraducciones.traducir(btm_modificar.Name);
                btm_borrar.Text = BLLtraducciones.traducir(btm_borrar.Name);
                usuario_btm_ir_historlal.Text = BLLtraducciones.traducir(usuario_btm_ir_historlal.Name);
                btm_borrar1.Text = BLLtraducciones.traducir(btm_borrar1.Name);
                btm_agregar1.Text = BLLtraducciones.traducir(btm_agregar.Name);
                usuario_rbtm_permiso.Text = BLLtraducciones.traducir(usuario_rbtm_permiso.Name);
                usuario_rbtm_rol.Text = BLLtraducciones.traducir(usuario_rbtm_rol.Name);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                try
                {
                    bllusuario.borrar(usuario);
                    mostrar_data();
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("seleccione un usuario.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                bllrol.verificar_permiso_no_existente(bllrol.traer_permisos_usuario(usuario), comboBox2.Text);
              bllrol.agregar_permiso_usuario((BEpermisoComponente)comboBox2.SelectedItem, usuario.codigo);
              treeView1.Nodes.Clear();
                mostrar_treeview(bllrol.traer_permisos_usuario(usuario), treeView1.Nodes);
                treeView1.ExpandAll();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = bllrol.traer_todos_los_roles();
            comboBox2.DisplayMember = "nombre";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                nodo_seleccionado = (BEpermisoComponente)treeView1.SelectedNode.Tag;
                if (nodo_seleccionado is BEpermiso)
                {
                    usuario_rbtm_permiso.Checked = true;
                }
                else if (nodo_seleccionado is BErol)
                {
                    usuario_rbtm_rol.Checked = true;
                }
            }
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (nodo_seleccionado != null)
                {
                    bllrol.borrar_permiso_usuario(nodo_seleccionado, usuario.codigo);
                    treeView1.Nodes.Clear();
                    mostrar_treeview(bllrol.traer_permisos_usuario(usuario), treeView1.Nodes);
                    treeView1.ExpandAll();
                    
                }
                else
                {
                    throw new Exception("no hay ningun nodo seleccionado.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (controlusuario_select != null && usuario!=null)
            {
                
                try
                {
                    controlusuario_select.usuario = bllusuario.encrytar_nombre(controlusuario_select.usuario);
                    usuario.nombre = controlusuario_select.usuario;
                    usuario.contraseña = controlusuario_select.contraseña;
                    bllusuario.modificar(usuario);
                    mostrar_data();
                }
                catch { MessageBox.Show("error"); }
            }
            else
            {
                MessageBox.Show("seleccione un usuario.");
            }
            
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = lista_permisos;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                control_de_cambio_usuario c = new control_de_cambio_usuario(usuario,this,idioma);
                c.MdiParent = this.MdiParent;
                c.Show();

            }
            else
            {
                MessageBox.Show("error, seleccione un usuario.");
            }
        }
    }

}
