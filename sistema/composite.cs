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
namespace sistema
{
    public partial class composite : formulario_estilo, Iobservertraduccion
    {
        public composite(idiomas idiomas)
        {
            InitializeComponent();
            BLLtraducciones.cargar_listatraducciones(idiomas.Idioma);
            idioma = idiomas;
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        idiomas idioma;
        List<BEpermiso> lista_permisos = new List<BEpermiso>();
        BLLrol bllrol = new BLLrol();
        BEpermisoComponente nodo_seleccionado;
        BLLpermiso bllpermiso = new BLLpermiso();
        private void composite_Load(object sender, EventArgs e)
        {
            mostrar_composite();
            treeView1.ExpandAll();
            lista_permisos = bllpermiso.leer_permisos();
        }
        public void mostrar_composite()
        {
            int i = (-1);
            foreach (BEpermisoComponente compo in bllrol.traer_nodos_hijos(6))
            {
                i++;
                mostrar_treeview(bllrol.traer_nodos_hijos(6)[i], treeView1.Nodes);
            }

        }
        public  void mostrar_treeview(BEpermisoComponente componenteraiz, TreeNodeCollection nodos)
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
                label2.Text = nodo_seleccionado.nombre;
                if (nodo_seleccionado is BEpermiso)
                {
                    comboBox2.Enabled = false;
                    btm_modificar.Enabled = false;
                    composite_rbtm_permiso.Checked = true;
                }
                else if (nodo_seleccionado is BErol)
                {
                    comboBox2.Enabled = true;
                    btm_modificar.Enabled = true;
                    composite_rbtm_rol.Checked = true;
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
                        if (composite_rbtm_rol.Checked)//rol
                        {
                            if (!bllrol.esUnRolNuevo(comboBox2.Text))
                            {
                                BErol rol = new BErol("");
                                rol = (BErol)comboBox2.SelectedItem;
                                bllrol.verificar_rol_bucle(rol, nodo_seleccionado.nombre);
                                bllrol.agregar_rol(rol, nodo_seleccionado.codigo);
                            }

                        }
                        else if (composite_rbtm_permiso.Checked)
                        {
                            BEpermiso permiso = (BEpermiso)(comboBox2.SelectedItem);
                            BErol rol_padre = (BErol)nodo_seleccionado;
                            bllpermiso.verificar_si_existe_permiso(rol_padre, permiso.nombre);
                            bllpermiso.agregar_permiso(permiso, nodo_seleccionado.codigo);
                        }
                        treeView1.Nodes.Clear();
                        mostrar_composite();
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
            try {
                if (nodo_seleccionado != null)
                {
                    DialogResult = MessageBox.Show("esta seguro de borrar rol/permiso?", "confirmación de error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes) {
                        bllrol.borrar_nodo(nodo_seleccionado);
                        comboBox2.DataSource = bllrol.traer_todos_los_roles();
                        comboBox2.DisplayMember = "nombre";
                        treeView1.Nodes.Clear();
                        mostrar_composite();
                        treeView1.ExpandAll();

                    }
                }
                else { throw new Exception("error, no selecciono un rol/permiso."); }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            formulario_datos_compostite fdc = new formulario_datos_compostite(this,"modificar",idioma);
            fdc.ShowDialog();

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

        public void actualizar_idioma()
        {
            composite_rbtm_rol.Text = BLLtraducciones.traducir(composite_rbtm_rol.Name);
            composite_rbtm_permiso.Text = BLLtraducciones.traducir(composite_rbtm_permiso.Name);
            btm_agregar.Text = BLLtraducciones.traducir(btm_agregar.Name);
            btm_modificar.Text = BLLtraducciones.traducir(btm_modificar.Name);
            btm_borrar.Text = BLLtraducciones.traducir(btm_borrar.Name);
            btm_crear_rol.Text = BLLtraducciones.traducir(btm_crear_rol.Name);
            composite_seleccionado.Text = BLLtraducciones.traducir(composite_seleccionado.Name);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formulario_datos_compostite fdc = new formulario_datos_compostite(this,"agregar_nodo",idioma);
            fdc.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        public void modificar_rol_formulario(string nombre)
        {
            if (nodo_seleccionado != null)
            {
                if (nodo_seleccionado is BErol)//rol
                {
                    nodo_seleccionado.nombre = nombre;
                    bllrol.modificar_rol((BErol)nodo_seleccionado);
                    treeView1.Nodes.Clear();
                    mostrar_composite();
                    treeView1.ExpandAll();
                    comboBox2.DataSource = bllrol.traer_todos_los_roles();
                    comboBox2.DisplayMember = "nombre";
                }
            }
            else { MessageBox.Show("error, seleccione un nodo."); }
        }
        public void agregar_rol_formulario(string nombre)
        {
            try
            {if (bllrol.esUnRolNuevo(nombre))
                {
                    BErol rol = new BErol(nombre);
                    bllrol.agregar_rol(rol, 6);
                    treeView1.Nodes.Clear();
                    mostrar_composite();
                    treeView1.ExpandAll();
                    groupBox2.Enabled = true;
                    lista_permisos = bllpermiso.leer_permisos();
                    comboBox2.DataSource = bllrol.traer_todos_los_roles();
                    comboBox2.DisplayMember = "nombre";
                }
                else
                {
                    throw new Exception("Error, ese rol ya existe.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;

        }

        private void composite_FormClosing(object sender, FormClosingEventArgs e)
        {
            idioma.eliminar_observer(this);
        }
    }
}
