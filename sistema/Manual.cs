using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }
        string ruta= @"C:\Users\user\Desktop\universidad\introducion a la programacion\3 año\wwwww\trabajo practico\MANUAL DE USUARIO.pdf";
        private void Manual_Load(object sender, EventArgs e)
        {
            mostrar_manual();
        }
        void mostrar_manual()
        {
            if (File.Exists(ruta))
                webView21.Source = new Uri(ruta);
            else
                MessageBox.Show("No se encontró el PDF.");
        }
    }
}
