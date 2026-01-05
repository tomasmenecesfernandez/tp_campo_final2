
namespace sistema_de_ropa
{
    partial class sistema1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TEXTO_FECHA_PEDIDO = new System.Windows.Forms.Label();
            this.sistema_fecha1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sistema_btm_ir_form_cliente = new System.Windows.Forms.Button();
            this.sistema_filtro = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sistema_label_buscar_cliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TEXTO_DESCUENTO = new System.Windows.Forms.Label();
            this.sistema_descuento1 = new System.Windows.Forms.Label();
            this.TEXTO_TOTAL_ROPA = new System.Windows.Forms.Label();
            this.sistema_total1 = new System.Windows.Forms.Label();
            this.sistema_groupbox_pedidos = new System.Windows.Forms.GroupBox();
            this.sistema_cantidad_ropa = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.sistema_descuento = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sistema_fecha = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sistema_total = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sistema_btm_personalizar_pedido = new System.Windows.Forms.Button();
            this.btm_borrar = new System.Windows.Forms.Button();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sistema_groupbox_pedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema.Properties.Resources.clothing_shop_icon_192653;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // TEXTO_FECHA_PEDIDO
            // 
            this.TEXTO_FECHA_PEDIDO.AutoSize = true;
            this.TEXTO_FECHA_PEDIDO.Location = new System.Drawing.Point(572, 735);
            this.TEXTO_FECHA_PEDIDO.Name = "TEXTO_FECHA_PEDIDO";
            this.TEXTO_FECHA_PEDIDO.Size = new System.Drawing.Size(14, 23);
            this.TEXTO_FECHA_PEDIDO.TabIndex = 24;
            this.TEXTO_FECHA_PEDIDO.Text = ".";
            // 
            // sistema_fecha1
            // 
            this.sistema_fecha1.AutoSize = true;
            this.sistema_fecha1.Location = new System.Drawing.Point(507, 735);
            this.sistema_fecha1.Name = "sistema_fecha1";
            this.sistema_fecha1.Size = new System.Drawing.Size(65, 23);
            this.sistema_fecha1.TabIndex = 23;
            this.sistema_fecha1.Text = "FECHA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sistema_btm_ir_form_cliente);
            this.groupBox1.Controls.Add(this.sistema_filtro);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.sistema_label_buscar_cliente);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 266);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // sistema_btm_ir_form_cliente
            // 
            this.sistema_btm_ir_form_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema_btm_ir_form_cliente.Location = new System.Drawing.Point(12, 161);
            this.sistema_btm_ir_form_cliente.Name = "sistema_btm_ir_form_cliente";
            this.sistema_btm_ir_form_cliente.Size = new System.Drawing.Size(473, 53);
            this.sistema_btm_ir_form_cliente.TabIndex = 5;
            this.sistema_btm_ir_form_cliente.Text = "Ir al formulario cliente";
            this.sistema_btm_ir_form_cliente.UseVisualStyleBackColor = true;
            this.sistema_btm_ir_form_cliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // sistema_filtro
            // 
            this.sistema_filtro.AutoSize = true;
            this.sistema_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema_filtro.Location = new System.Drawing.Point(298, 38);
            this.sistema_filtro.Name = "sistema_filtro";
            this.sistema_filtro.Size = new System.Drawing.Size(56, 24);
            this.sistema_filtro.TabIndex = 3;
            this.sistema_filtro.Text = "Filtro:";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(367, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(118, 31);
            this.comboBox2.TabIndex = 2;
            // 
            // sistema_label_buscar_cliente
            // 
            this.sistema_label_buscar_cliente.AutoSize = true;
            this.sistema_label_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema_label_buscar_cliente.Location = new System.Drawing.Point(0, 43);
            this.sistema_label_buscar_cliente.Name = "sistema_label_buscar_cliente";
            this.sistema_label_buscar_cliente.Size = new System.Drawing.Size(141, 24);
            this.sistema_label_buscar_cliente.TabIndex = 1;
            this.sistema_label_buscar_cliente.Text = " Buscar Cliente:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(473, 38);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(511, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1325, 329);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TEXTO_DESCUENTO
            // 
            this.TEXTO_DESCUENTO.AutoSize = true;
            this.TEXTO_DESCUENTO.Location = new System.Drawing.Point(594, 775);
            this.TEXTO_DESCUENTO.Name = "TEXTO_DESCUENTO";
            this.TEXTO_DESCUENTO.Size = new System.Drawing.Size(14, 23);
            this.TEXTO_DESCUENTO.TabIndex = 7;
            this.TEXTO_DESCUENTO.Text = ".";
            // 
            // sistema_descuento1
            // 
            this.sistema_descuento1.AutoSize = true;
            this.sistema_descuento1.Location = new System.Drawing.Point(478, 775);
            this.sistema_descuento1.Name = "sistema_descuento1";
            this.sistema_descuento1.Size = new System.Drawing.Size(110, 23);
            this.sistema_descuento1.TabIndex = 6;
            this.sistema_descuento1.Text = "DESCUENTO:";
            // 
            // TEXTO_TOTAL_ROPA
            // 
            this.TEXTO_TOTAL_ROPA.AutoSize = true;
            this.TEXTO_TOTAL_ROPA.Location = new System.Drawing.Point(572, 696);
            this.TEXTO_TOTAL_ROPA.Name = "TEXTO_TOTAL_ROPA";
            this.TEXTO_TOTAL_ROPA.Size = new System.Drawing.Size(14, 23);
            this.TEXTO_TOTAL_ROPA.TabIndex = 5;
            this.TEXTO_TOTAL_ROPA.Text = ".";
            // 
            // sistema_total1
            // 
            this.sistema_total1.AutoSize = true;
            this.sistema_total1.Location = new System.Drawing.Point(507, 696);
            this.sistema_total1.Name = "sistema_total1";
            this.sistema_total1.Size = new System.Drawing.Size(61, 23);
            this.sistema_total1.TabIndex = 5;
            this.sistema_total1.Text = "TOTAL:";
            // 
            // sistema_groupbox_pedidos
            // 
            this.sistema_groupbox_pedidos.Controls.Add(this.sistema_cantidad_ropa);
            this.sistema_groupbox_pedidos.Controls.Add(this.textBox5);
            this.sistema_groupbox_pedidos.Controls.Add(this.sistema_descuento);
            this.sistema_groupbox_pedidos.Controls.Add(this.textBox4);
            this.sistema_groupbox_pedidos.Controls.Add(this.sistema_fecha);
            this.sistema_groupbox_pedidos.Controls.Add(this.textBox3);
            this.sistema_groupbox_pedidos.Controls.Add(this.sistema_total);
            this.sistema_groupbox_pedidos.Controls.Add(this.textBox1);
            this.sistema_groupbox_pedidos.Controls.Add(this.sistema_btm_personalizar_pedido);
            this.sistema_groupbox_pedidos.Controls.Add(this.btm_borrar);
            this.sistema_groupbox_pedidos.Controls.Add(this.btm_agregar);
            this.sistema_groupbox_pedidos.Location = new System.Drawing.Point(14, 354);
            this.sistema_groupbox_pedidos.Name = "sistema_groupbox_pedidos";
            this.sistema_groupbox_pedidos.Size = new System.Drawing.Size(491, 337);
            this.sistema_groupbox_pedidos.TabIndex = 4;
            this.sistema_groupbox_pedidos.TabStop = false;
            this.sistema_groupbox_pedidos.Text = "pedidos";
            this.sistema_groupbox_pedidos.Enter += new System.EventHandler(this.sistema_groupbox_pedidos_Enter);
            // 
            // sistema_cantidad_ropa
            // 
            this.sistema_cantidad_ropa.AutoSize = true;
            this.sistema_cantidad_ropa.Location = new System.Drawing.Point(6, 262);
            this.sistema_cantidad_ropa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sistema_cantidad_ropa.Name = "sistema_cantidad_ropa";
            this.sistema_cantidad_ropa.Size = new System.Drawing.Size(168, 23);
            this.sistema_cantidad_ropa.TabIndex = 33;
            this.sistema_cantidad_ropa.Text = "CANTIDAD DE ROPA";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(12, 291);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(206, 30);
            this.textBox5.TabIndex = 32;
            // 
            // sistema_descuento
            // 
            this.sistema_descuento.AutoSize = true;
            this.sistema_descuento.Location = new System.Drawing.Point(6, 192);
            this.sistema_descuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sistema_descuento.Name = "sistema_descuento";
            this.sistema_descuento.Size = new System.Drawing.Size(106, 23);
            this.sistema_descuento.TabIndex = 31;
            this.sistema_descuento.Text = "DESCUENTO";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(12, 219);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(206, 30);
            this.textBox4.TabIndex = 30;
            // 
            // sistema_fecha
            // 
            this.sistema_fecha.AutoSize = true;
            this.sistema_fecha.Location = new System.Drawing.Point(6, 110);
            this.sistema_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sistema_fecha.Name = "sistema_fecha";
            this.sistema_fecha.Size = new System.Drawing.Size(61, 23);
            this.sistema_fecha.TabIndex = 29;
            this.sistema_fecha.Text = "FECHA";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(12, 139);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(206, 30);
            this.textBox3.TabIndex = 28;
            // 
            // sistema_total
            // 
            this.sistema_total.AutoSize = true;
            this.sistema_total.Location = new System.Drawing.Point(6, 32);
            this.sistema_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sistema_total.Name = "sistema_total";
            this.sistema_total.Size = new System.Drawing.Size(57, 23);
            this.sistema_total.TabIndex = 27;
            this.sistema_total.Text = "TOTAL";
            this.sistema_total.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(206, 30);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sistema_btm_personalizar_pedido
            // 
            this.sistema_btm_personalizar_pedido.Image = global::sistema.Properties.Resources.edit_modify_icon_149488;
            this.sistema_btm_personalizar_pedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sistema_btm_personalizar_pedido.Location = new System.Drawing.Point(226, 219);
            this.sistema_btm_personalizar_pedido.Name = "sistema_btm_personalizar_pedido";
            this.sistema_btm_personalizar_pedido.Size = new System.Drawing.Size(265, 104);
            this.sistema_btm_personalizar_pedido.TabIndex = 25;
            this.sistema_btm_personalizar_pedido.Text = "Personalizar Pedido";
            this.sistema_btm_personalizar_pedido.UseVisualStyleBackColor = true;
            this.sistema_btm_personalizar_pedido.Click += new System.EventHandler(this.button6_Click);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Image = global::sistema.Properties.Resources.cart_minus_icon_137799__1_;
            this.btm_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_borrar.Location = new System.Drawing.Point(226, 139);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(265, 60);
            this.btm_borrar.TabIndex = 12;
            this.btm_borrar.Text = "BORRAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btm_agregar
            // 
            this.btm_agregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_agregar.Image = global::sistema.Properties.Resources.cart_outline_icon_139049;
            this.btm_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_agregar.Location = new System.Drawing.Point(226, 61);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btm_agregar.Size = new System.Drawing.Size(265, 60);
            this.btm_agregar.TabIndex = 13;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(511, 367);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1324, 326);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // sistema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TEXTO_FECHA_PEDIDO);
            this.Controls.Add(this.sistema_fecha1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TEXTO_DESCUENTO);
            this.Controls.Add(this.sistema_descuento1);
            this.Controls.Add(this.TEXTO_TOTAL_ROPA);
            this.Controls.Add(this.sistema_total1);
            this.Controls.Add(this.sistema_groupbox_pedidos);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "sistema1";
            this.Text = "sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sistema1_FormClosing);
            this.Load += new System.EventHandler(this.sistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sistema_groupbox_pedidos.ResumeLayout(false);
            this.sistema_groupbox_pedidos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btm_borrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox sistema_groupbox_pedidos;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.Label sistema_total1;
        private System.Windows.Forms.Label TEXTO_TOTAL_ROPA;
        private System.Windows.Forms.Label sistema_descuento1;
        private System.Windows.Forms.Label TEXTO_DESCUENTO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TEXTO_FECHA_PEDIDO;
        private System.Windows.Forms.Label sistema_fecha1;
        private System.Windows.Forms.Label sistema_filtro;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label sistema_label_buscar_cliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sistema_btm_ir_form_cliente;
        private System.Windows.Forms.Button sistema_btm_personalizar_pedido;
        private System.Windows.Forms.Label sistema_total;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sistema_descuento;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label sistema_fecha;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label sistema_cantidad_ropa;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}