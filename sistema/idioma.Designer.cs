
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
            this.btm_modificar = new System.Windows.Forms.Button();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.label_idioma_idioma = new System.Windows.Forms.Label();
            this.label_traduccion_idioma = new System.Windows.Forms.Label();
            this.btm_borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(658, 289);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 28);
            this.textBox2.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 186);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(636, 257);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(636, 165);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(659, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 28);
            this.textBox1.TabIndex = 8;
            // 
            // btm_modificar
            // 
            this.btm_modificar.Location = new System.Drawing.Point(658, 321);
            this.btm_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(212, 42);
            this.btm_modificar.TabIndex = 7;
            this.btm_modificar.Tag = "btnCreate";
            this.btm_modificar.Text = "Modificar";
            this.btm_modificar.UseVisualStyleBackColor = true;
            this.btm_modificar.Click += new System.EventHandler(this.btnModificar1_Click);
            // 
            // btm_agregar
            // 
            this.btm_agregar.Location = new System.Drawing.Point(659, 71);
            this.btm_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(212, 42);
            this.btm_agregar.TabIndex = 6;
            this.btm_agregar.Tag = "btnAdd";
            this.btm_agregar.Text = "Agregar";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // label_idioma_idioma
            // 
            this.label_idioma_idioma.AutoSize = true;
            this.label_idioma_idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idioma_idioma.Location = new System.Drawing.Point(659, 13);
            this.label_idioma_idioma.Name = "label_idioma_idioma";
            this.label_idioma_idioma.Size = new System.Drawing.Size(75, 24);
            this.label_idioma_idioma.TabIndex = 12;
            this.label_idioma_idioma.Text = "IDIOMA";
            // 
            // label_traduccion_idioma
            // 
            this.label_traduccion_idioma.AutoSize = true;
            this.label_traduccion_idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_traduccion_idioma.Location = new System.Drawing.Point(654, 261);
            this.label_traduccion_idioma.Name = "label_traduccion_idioma";
            this.label_traduccion_idioma.Size = new System.Drawing.Size(133, 24);
            this.label_traduccion_idioma.TabIndex = 13;
            this.label_traduccion_idioma.Text = "TRADUCCION";
            this.label_traduccion_idioma.Click += new System.EventHandler(this.label2_Click);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Location = new System.Drawing.Point(659, 121);
            this.btm_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(212, 42);
            this.btm_borrar.TabIndex = 14;
            this.btm_borrar.Tag = "btnAdd";
            this.btm_borrar.Text = "Borrar";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.btm_borrar_Click);
            // 
            // idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 484);
            this.Controls.Add(this.btm_borrar);
            this.Controls.Add(this.label_traduccion_idioma);
            this.Controls.Add(this.label_idioma_idioma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btm_modificar);
            this.Controls.Add(this.btm_agregar);
            this.Name = "idioma";
            this.Text = "idioma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.idioma_FormClosing);
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
        private System.Windows.Forms.Button btm_modificar;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.Label label_idioma_idioma;
        private System.Windows.Forms.Label label_traduccion_idioma;
        private System.Windows.Forms.Button btm_borrar;
    }
}