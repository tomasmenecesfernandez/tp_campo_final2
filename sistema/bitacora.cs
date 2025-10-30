using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace sistema
{
    public partial class bitacora : Form
    {
        public bitacora()
        {
            InitializeComponent();
        }
        bllregistro bllregistro = new bllregistro();
        private void bitacora_Load(object sender, EventArgs e)
        {
            cargar_grilla();
        }
        public void cargar_grilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllregistro.leer_registros();
        }
    }
}
