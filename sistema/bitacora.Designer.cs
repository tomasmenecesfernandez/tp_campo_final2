
namespace sistema
{
    partial class bitacora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sistema_filtro = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_buscar_bitacora = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 878);
            this.dataGridView1.TabIndex = 0;
            // 
            // sistema_filtro
            // 
            this.sistema_filtro.AutoSize = true;
            this.sistema_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema_filtro.Location = new System.Drawing.Point(224, 67);
            this.sistema_filtro.Name = "sistema_filtro";
            this.sistema_filtro.Size = new System.Drawing.Size(56, 24);
            this.sistema_filtro.TabIndex = 9;
            this.sistema_filtro.Text = "Filtro:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nombre",
            "Fecha"});
            this.comboBox2.Location = new System.Drawing.Point(292, 69);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(118, 31);
            this.comboBox2.TabIndex = 8;
            // 
            // lbl_buscar_bitacora
            // 
            this.lbl_buscar_bitacora.AutoSize = true;
            this.lbl_buscar_bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_bitacora.Location = new System.Drawing.Point(14, 67);
            this.lbl_buscar_bitacora.Name = "lbl_buscar_bitacora";
            this.lbl_buscar_bitacora.Size = new System.Drawing.Size(150, 24);
            this.lbl_buscar_bitacora.TabIndex = 7;
            this.lbl_buscar_bitacora.Text = " Buscar Bitacora:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(18, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(394, 38);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 1055);
            this.Controls.Add(this.sistema_filtro);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbl_buscar_bitacora);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "bitacora";
            this.Text = "bitacora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bitacora_FormClosing);
            this.Load += new System.EventHandler(this.bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label sistema_filtro;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_buscar_bitacora;
        private System.Windows.Forms.TextBox textBox2;
    }
}