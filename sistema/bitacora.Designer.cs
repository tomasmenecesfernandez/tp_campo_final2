
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
            this.sistema_label_buscar_cliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bitacora_label_bitacora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(466, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // sistema_filtro
            // 
            this.sistema_filtro.AutoSize = true;
            this.sistema_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema_filtro.Location = new System.Drawing.Point(149, 38);
            this.sistema_filtro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sistema_filtro.Name = "sistema_filtro";
            this.sistema_filtro.Size = new System.Drawing.Size(45, 18);
            this.sistema_filtro.TabIndex = 9;
            this.sistema_filtro.Text = "Filtro:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nombre",
            "Fecha"});
            this.comboBox2.Location = new System.Drawing.Point(195, 39);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // sistema_label_buscar_cliente
            // 
            this.sistema_label_buscar_cliente.AutoSize = true;
            this.sistema_label_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema_label_buscar_cliente.Location = new System.Drawing.Point(9, 38);
            this.sistema_label_buscar_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sistema_label_buscar_cliente.Name = "sistema_label_buscar_cliente";
            this.sistema_label_buscar_cliente.Size = new System.Drawing.Size(122, 18);
            this.sistema_label_buscar_cliente.TabIndex = 7;
            this.sistema_label_buscar_cliente.Text = " Buscar Bitacora:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 32);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bitacora_label_bitacora
            // 
            this.bitacora_label_bitacora.AutoSize = true;
            this.bitacora_label_bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitacora_label_bitacora.Location = new System.Drawing.Point(509, 9);
            this.bitacora_label_bitacora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bitacora_label_bitacora.Name = "bitacora_label_bitacora";
            this.bitacora_label_bitacora.Size = new System.Drawing.Size(113, 24);
            this.bitacora_label_bitacora.TabIndex = 1;
            this.bitacora_label_bitacora.Text = "BITACORA";
            this.bitacora_label_bitacora.Click += new System.EventHandler(this.bitacora_label_bitacora_Click);
            // 
            // bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 609);
            this.Controls.Add(this.sistema_filtro);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.sistema_label_buscar_cliente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bitacora_label_bitacora);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label sistema_label_buscar_cliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label bitacora_label_bitacora;
    }
}