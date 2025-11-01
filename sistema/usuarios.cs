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

        List<BEusuario> lista_usuarios = new List<BEusuario>();
        List<BEpermiso> lista_permisos = new List<BEpermiso>();
        BEusuario usuario;
        BLLusuario bllusuario = new BLLusuario();
        BLLrol bllrol = new BLLrol();
        BLLtraducciones traducciones = new BLLtraducciones();
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
                    BErol rol_seleccionado = (BErol)comboBox1.SelectedItem;
                    usuario.rol = rol_seleccionado;
                    usuario = bllusuario.encrytar_usuario(usuario);
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
        public void mostrar_treeview(BEpermisoComponente componenteraiz,TreeNodeCollection nodos)
        {
            TreeNode nodo1 =new TreeNode(componenteraiz.nombre);
            nodo1.Tag = componenteraiz;
            nodos.Add(nodo1);

            foreach (BEpermisoComponente hijos in componenteraiz.obtener_hijos())
            {
                mostrar_treeview(hijos,nodo1.Nodes);
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
            dataGridView2.DataSource = bllcontrolusuario.leer_Registros(usuario.codigo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                try
                {
                    if (textBox1.Text!="" && textBox2.Text!="") {
                        usuario.nombre = bllusuario.encrytar_nombre(textBox1.Text);
                        usuario.contraseña = bllusuario.encrytar_contraseña(textBox2.Text);
                        BErol rol_seleccionado = (BErol)comboBox1.SelectedItem;
                        usuario.rol = rol_seleccionado;
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
            if(idiomas.lista_traducciones.Count>0 ) actualizar_idioma();
            radioButton1.Checked = true;
            lista_permisos = bllpermiso.leer_permisos();
            añadir_roles_combobox();
            mostrar_data();
            mostrar_treeview(bllrol.traer_nodos_hijos(0)[0],treeView1.Nodes);
        }
        public void añadir_roles_combobox()
        { 
        comboBox1.DataSource = bllrol.traer_todos_los_roles();
        comboBox1.DisplayMember = "nombre";
        }
        public void actualizar_idioma()
        {
            usuario_label1.Text = traducciones.traducir(usuario_label1.Name);
                contraceña_label1.Text = traducciones.traducir(contraceña_label1.Name);
                rol_label1.Text = traducciones.traducir(rol_label1.Name);
                agregar_boton1.Text = traducciones.traducir(agregar_boton1.Name);
                modificar_boton1.Text = traducciones.traducir(modificar_boton1.Name);
                borrar_boton1.Text = traducciones.traducir(borrar_boton1.Name);
            
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
                if (nodo_seleccionado != null)
                {
                    if (nodo_seleccionado is BErol)
                    {
                        if (radioButton1.Checked)//rol
                        {
                            if (bllrol.esUnRolNuevo(comboBox2.Text))
                            {
                                BErol rol = new BErol(comboBox2.Text);
                                bllrol.agregar_rol(rol, nodo_seleccionado.codigo);
                                añadir_roles_combobox();
                            }
                            else
                            {
                                BErol rol = new BErol("");
                                rol = (BErol)comboBox2.SelectedItem;
                                bllrol.verificar_rol_bucle(rol,nodo_seleccionado.nombre);
                                bllrol.agregar_rol(rol, nodo_seleccionado.codigo);
                                añadir_roles_combobox();
                            }

                        }
                        else if (radioButton2.Checked)
                        {
                            BEpermiso permiso = (BEpermiso)(comboBox2.SelectedItem);
                            BErol rol_padre=(BErol) nodo_seleccionado;
                            bllpermiso.verificar_si_existe_permiso(rol_padre, permiso.nombre);
                            bllpermiso.agregar_permiso(permiso, nodo_seleccionado.codigo);
                        }
                        treeView1.Nodes.Clear();
                        mostrar_treeview(bllrol.traer_nodos_hijos(0)[0], treeView1.Nodes);
                    }
                    else
                    {
                        throw new Exception("error no se puede agregar nodos a un permiso.");
                    }
                }
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
                    radioButton2.Checked = true;
                }
                else if (nodo_seleccionado is BErol)
                {
                    radioButton1.Checked = true;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (nodo_seleccionado != null)
            {
                if (radioButton1.Checked)//rol
                {
                    bllrol.modificar_rol((BErol)nodo_seleccionado);
                    añadir_roles_combobox();
                }
                else if (radioButton2.Checked)
                { 
                    bllpermiso.modificar_permiso((BEpermiso)nodo_seleccionado);
                }
                treeView1.Nodes.Clear();
                mostrar_treeview(bllrol.traer_nodos_hijos(0)[0], treeView1.Nodes);

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (nodo_seleccionado != null)
            {
                if (nodo_seleccionado.nombre == "sistema") throw new Exception("no se puede borrar el nodo sistema");
                if (radioButton1.Checked)//rol
                {
                    bllrol.borrar_rol((BErol)nodo_seleccionado);
                }
                else if (radioButton2.Checked)
                {
                    bllpermiso.borrar_permiso((BEpermiso)nodo_seleccionado);
                }
                treeView1.Nodes.Clear();
                mostrar_treeview(bllrol.traer_nodos_hijos(0)[0], treeView1.Nodes);

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
                    BErol rol = new BErol("");
                    rol = bllrol.recuperar_rol(controlusuario_select.codigorol);
                    usuario.rol = rol;
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlusuario_select = (BEcontrolCambioUsuario)dataGridView2.CurrentRow.DataBoundItem;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = lista_permisos;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
