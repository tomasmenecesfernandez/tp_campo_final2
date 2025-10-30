
namespace sistema
{
    partial class idioma
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnModificar_idioma = new System.Windows.Forms.Button();
            this.btnAgregar_idioma = new System.Windows.Forms.Button();
            this.label_idioma_idioma = new System.Windows.Forms.Label();
            this.label_traduccion_idioma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(659, 193);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 189);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(638, 257);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(563, 165);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 8;
            // 
            // btnModificar_idioma
            // 
            this.btnModificar_idioma.Location = new System.Drawing.Point(659, 225);
            this.btnModificar_idioma.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar_idioma.Name = "btnModificar_idioma";
            this.btnModificar_idioma.Size = new System.Drawing.Size(212, 42);
            this.btnModificar_idioma.TabIndex = 7;
            this.btnModificar_idioma.Tag = "btnCreate";
            this.btnModificar_idioma.Text = "Modificar";
            this.btnModificar_idioma.UseVisualStyleBackColor = true;
            this.btnModificar_idioma.Click += new System.EventHandler(this.btnModificar1_Click);
            // 
            // btnAgregar_idioma
            // 
            this.btnAgregar_idioma.Location = new System.Drawing.Point(568, 72);
            this.btnAgregar_idioma.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar_idioma.Name = "btnAgregar_idioma";
            this.btnAgregar_idioma.Size = new System.Drawing.Size(171, 42);
            this.btnAgregar_idioma.TabIndex = 6;
            this.btnAgregar_idioma.Tag = "btnAdd";
            this.btnAgregar_idioma.Text = "Agregar";
            this.btnAgregar_idioma.UseVisualStyleBackColor = true;
            this.btnAgregar_idioma.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // label_idioma_idioma
            // 
            this.label_idioma_idioma.AutoSize = true;
            this.label_idioma_idioma.Location = new System.Drawing.Point(568, 13);
            this.label_idioma_idioma.Name = "label_idioma_idioma";
            this.label_idioma_idioma.Size = new System.Drawing.Size(55, 17);
            this.label_idioma_idioma.TabIndex = 12;
            this.label_idioma_idioma.Text = "IDIOMA";
            // 
            // label_traduccion_idioma
            // 
            this.label_traduccion_idioma.AutoSize = true;
            this.label_traduccion_idioma.Location = new System.Drawing.Point(656, 172);
            this.label_traduccion_idioma.Name = "label_traduccion_idioma";
            this.label_traduccion_idioma.Size = new System.Drawing.Size(98, 17);
            this.label_traduccion_idioma.TabIndex = 13;
            this.label_traduccion_idioma.Text = "TRADUCCION";
            this.label_traduccion_idioma.Click += new System.EventHandler(this.label2_Click);
            // 
            // idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 484);
            this.Controls.Add(this.label_traduccion_idioma);
            this.Controls.Add(this.label_idioma_idioma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModificar_idioma);
            this.Controls.Add(this.btnAgregar_idioma);
            this.Name = "idioma";
            this.Text = "idioma";
            this.Load += new System.EventHandler(this.idioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnModificar_idioma;
        private System.Windows.Forms.Button btnAgregar_idioma;
        private System.Windows.Forms.Label label_idioma_idioma;
        private System.Windows.Forms.Label label_traduccion_idioma;
    }
}