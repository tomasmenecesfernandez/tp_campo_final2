
namespace sistema
{
    partial class localidad
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.localidad_codigo = new System.Windows.Forms.Label();
            this.label_localidad = new System.Windows.Forms.Label();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.btm_borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(293, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(21, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 123);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 2;
            // 
            // localidad_codigo
            // 
            this.localidad_codigo.AutoSize = true;
            this.localidad_codigo.Location = new System.Drawing.Point(21, 32);
            this.localidad_codigo.Name = "localidad_codigo";
            this.localidad_codigo.Size = new System.Drawing.Size(63, 17);
            this.localidad_codigo.TabIndex = 3;
            this.localidad_codigo.Text = "CODIGO";
            // 
            // label_localidad
            // 
            this.label_localidad.AutoSize = true;
            this.label_localidad.Location = new System.Drawing.Point(21, 103);
            this.label_localidad.Name = "label_localidad";
            this.label_localidad.Size = new System.Drawing.Size(85, 17);
            this.label_localidad.TabIndex = 4;
            this.label_localidad.Text = "LOCALIDAD";
            // 
            // btm_agregar
            // 
            this.btm_agregar.Location = new System.Drawing.Point(55, 174);
            this.btm_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(107, 37);
            this.btm_agregar.TabIndex = 5;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Location = new System.Drawing.Point(55, 224);
            this.btm_borrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(107, 37);
            this.btm_borrar.TabIndex = 6;
            this.btm_borrar.Text = "ELIMINAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // localidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.btm_borrar);
            this.Controls.Add(this.btm_agregar);
            this.Controls.Add(this.label_localidad);
            this.Controls.Add(this.localidad_codigo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "localidad";
            this.Text = "localidad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.localidad_FormClosing);
            this.Load += new System.EventHandler(this.localidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label localidad_codigo;
        private System.Windows.Forms.Label label_localidad;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.Button btm_borrar;
    }
}