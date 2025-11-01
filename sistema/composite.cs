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
namespace sistema
{
    public partial class composite : Form
    {
        public composite()
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
        private void composite_Load(object sender, EventArgs e)
        {
            mostrar_treeview(bllrol.traer_nodos_hijos(0)[0], treeView1.Nodes);
            treeView1.ExpandAll();
        }
        public void mostrar_treeview(BEpermisoComponente componenteraiz, TreeNodeCollection nodos)
        {
            TreeNode nodo1 = new TreeNode(componenteraiz.nombre);
            nodo1.Tag = componenteraiz;
            nodos.Add(nodo1);

            foreach (BEpermisoComponente hijos in componenteraiz.obtener_hijos())
            {
                mostrar_treeview(hijos, nodo1.Nodes);
            }
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

        private void button1_Click(object sender, EventArgs e)
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
                            }
                            else
                            {
                                BErol rol = new BErol("");
                                rol = (BErol)comboBox2.SelectedItem;
                                bllrol.verificar_rol_bucle(rol, nodo_seleccionado.nombre);
                                bllrol.agregar_rol(rol, nodo_seleccionado.codigo);
                            }

                        }
                        else if (radioButton2.Checked)
                        {
                            BEpermiso permiso = (BEpermiso)(comboBox2.SelectedItem);
                            BErol rol_padre = (BErol)nodo_seleccionado;
                            bllpermiso.verificar_si_existe_permiso(rol_padre, permiso.nombre);
                            bllpermiso.agregar_permiso(permiso, nodo_seleccionado.codigo);
                        }
                        treeView1.Nodes.Clear();
                        mostrar_treeview(bllrol.traer_nodos_hijos(0)[0], treeView1.Nodes);
                        treeView1.ExpandAll();

                    }
                    else
                    {
                        throw new Exception("error no se puede agregar nodos a un permiso.");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
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
                treeView1.ExpandAll();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (nodo_seleccionado != null)
            {
                if (radioButton1.Checked)//rol
                {
                    bllrol.modificar_rol((BErol)nodo_seleccionado);
                }
                else if (radioButton2.Checked)
                {
                    bllpermiso.modificar_permiso((BEpermiso)nodo_seleccionado);
                }
                treeView1.Nodes.Clear();
                mostrar_treeview(bllrol.traer_nodos_hijos(0)[0], treeView1.Nodes);
                treeView1.ExpandAll();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = bllrol.traer_todos_los_roles();
            comboBox2.DisplayMember = "nombre";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = lista_permisos;
        }
    }
}
