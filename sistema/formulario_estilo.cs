using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema
{
    public partial class formulario_estilo: Form
    {
        public formulario_estilo()
        {
            InitializeComponent();
        }

        private void formulario_estilo_Load(object sender, EventArgs e)
        {
            AplicarEstilo(this);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {

        }


        protected virtual void AplicarEstilo(Control control)
        {
            this.BackColor = ColorTranslator.FromHtml("#F4F4F4");
            this.Font = new Font("Segoe UI", 10F);

            foreach (Control c in control.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#252850");
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    btn.Height = 35;
                    btn.Cursor = Cursors.Hand;
                    btn.MouseEnter += (s, e) => btn.BackColor = ColorTranslator.FromHtml("#252850");
                    btn.MouseLeave += (s, e) => btn.BackColor = ColorTranslator.FromHtml("#252850");
                }

                if (c is Label lbl)
                {
                    lbl.Font = new Font("Segoe UI", 10F);
                    lbl.Font = new Font(lbl.Font,FontStyle.Italic);
                    lbl.ForeColor = ColorTranslator.FromHtml("#000000");
                }

                if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.GridColor = ColorTranslator.FromHtml("#535852");
                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
                    dgv.DefaultCellStyle.ForeColor = Color.Black;
                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#535852");
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.EnableHeadersVisualStyles = false;
                }

                if (c.HasChildren)
                    AplicarEstilo(c);
            }
        }
    }
    
}
