
namespace sistema
{
    partial class Cliente
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
            this.clientes_groupbox_cliente = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.btm_borrar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btm_modificar = new System.Windows.Forms.Button();
            this.clientes_btm_form_localidad = new System.Windows.Forms.Button();
            this.label_localidad = new System.Windows.Forms.Label();
            this.clientes_provincia = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clientes_nombre_completo = new System.Windows.Forms.Label();
            this.clientes_DNI = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientes_groupbox_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientes_groupbox_cliente
            // 
            this.clientes_groupbox_cliente.Controls.Add(this.comboBox3);
            this.clientes_groupbox_cliente.Controls.Add(this.btm_agregar);
            this.clientes_groupbox_cliente.Controls.Add(this.btm_borrar);
            this.clientes_groupbox_cliente.Controls.Add(this.comboBox2);
            this.clientes_groupbox_cliente.Controls.Add(this.btm_modificar);
            this.clientes_groupbox_cliente.Controls.Add(this.clientes_btm_form_localidad);
            this.clientes_groupbox_cliente.Controls.Add(this.label_localidad);
            this.clientes_groupbox_cliente.Controls.Add(this.clientes_provincia);
            this.clientes_groupbox_cliente.Controls.Add(this.textBox2);
            this.clientes_groupbox_cliente.Controls.Add(this.clientes_nombre_completo);
            this.clientes_groupbox_cliente.Controls.Add(this.clientes_DNI);
            this.clientes_groupbox_cliente.Controls.Add(this.textBox3);
            this.clientes_groupbox_cliente.Location = new System.Drawing.Point(40, 40);
            this.clientes_groupbox_cliente.Name = "clientes_groupbox_cliente";
            this.clientes_groupbox_cliente.Size = new System.Drawing.Size(423, 595);
            this.clientes_groupbox_cliente.TabIndex = 24;
            this.clientes_groupbox_cliente.TabStop = false;
            this.clientes_groupbox_cliente.Text = "CLIENTE";
            this.clientes_groupbox_cliente.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(22, 213);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(394, 28);
            this.comboBox3.TabIndex = 16;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btm_agregar
            // 
            this.btm_agregar.Location = new System.Drawing.Point(21, 354);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(395, 49);
            this.btm_agregar.TabIndex = 19;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Location = new System.Drawing.Point(21, 463);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(395, 49);
            this.btm_borrar.TabIndex = 21;
            this.btm_borrar.Text = "BORRAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "fgdgf",
            "fggf"});
            this.comboBox2.Location = new System.Drawing.Point(22, 292);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(394, 28);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btm_modificar
            // 
            this.btm_modificar.Location = new System.Drawing.Point(21, 408);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(395, 49);
            this.btm_modificar.TabIndex = 20;
            this.btm_modificar.Text = "MODIFICAR";
            this.btm_modificar.UseVisualStyleBackColor = true;
            this.btm_modificar.Click += new System.EventHandler(this.button6_Click);
            // 
            // clientes_btm_form_localidad
            // 
            this.clientes_btm_form_localidad.Location = new System.Drawing.Point(21, 518);
            this.clientes_btm_form_localidad.Name = "clientes_btm_form_localidad";
            this.clientes_btm_form_localidad.Size = new System.Drawing.Size(395, 65);
            this.clientes_btm_form_localidad.TabIndex = 11;
            this.clientes_btm_form_localidad.Text = "formulario localidad";
            this.clientes_btm_form_localidad.UseVisualStyleBackColor = true;
            this.clientes_btm_form_localidad.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_localidad
            // 
            this.label_localidad.AutoSize = true;
            this.label_localidad.Location = new System.Drawing.Point(22, 260);
            this.label_localidad.Name = "label_localidad";
            this.label_localidad.Size = new System.Drawing.Size(100, 23);
            this.label_localidad.TabIndex = 12;
            this.label_localidad.Text = "LOCALIDAD";
            this.label_localidad.Click += new System.EventHandler(this.label_localidad_Click);
            // 
            // clientes_provincia
            // 
            this.clientes_provincia.AutoSize = true;
            this.clientes_provincia.Location = new System.Drawing.Point(22, 185);
            this.clientes_provincia.Name = "clientes_provincia";
            this.clientes_provincia.Size = new System.Drawing.Size(99, 23);
            this.clientes_provincia.TabIndex = 18;
            this.clientes_provincia.Text = "PROVINCIA";
            this.clientes_provincia.Click += new System.EventHandler(this.clientes_provincia_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(21, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(394, 27);
            this.textBox2.TabIndex = 13;
            // 
            // clientes_nombre_completo
            // 
            this.clientes_nombre_completo.AutoSize = true;
            this.clientes_nombre_completo.Location = new System.Drawing.Point(21, 30);
            this.clientes_nombre_completo.Name = "clientes_nombre_completo";
            this.clientes_nombre_completo.Size = new System.Drawing.Size(172, 23);
            this.clientes_nombre_completo.TabIndex = 14;
            this.clientes_nombre_completo.Text = "NOMBRE COMPLETO";
            // 
            // clientes_DNI
            // 
            this.clientes_DNI.AutoSize = true;
            this.clientes_DNI.Location = new System.Drawing.Point(22, 111);
            this.clientes_DNI.Name = "clientes_DNI";
            this.clientes_DNI.Size = new System.Drawing.Size(40, 23);
            this.clientes_DNI.TabIndex = 16;
            this.clientes_DNI.Text = "DNI";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(22, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(394, 27);
            this.textBox3.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(480, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 595);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 684);
            this.Controls.Add(this.clientes_groupbox_cliente);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cliente_FormClosing);
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.clientes_groupbox_cliente.ResumeLayout(false);
            this.clientes_groupbox_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clientes_groupbox_cliente;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.Button btm_borrar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btm_modificar;
        private System.Windows.Forms.Button clientes_btm_form_localidad;
        private System.Windows.Forms.Label label_localidad;
        private System.Windows.Forms.Label clientes_provincia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label clientes_nombre_completo;
        private System.Windows.Forms.Label clientes_DNI;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}