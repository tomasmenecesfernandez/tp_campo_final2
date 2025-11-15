
namespace sistema
{
    partial class detalle_pedido
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.detalle_capucha = new System.Windows.Forms.Label();
            this.detalle_cantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btm_modificar = new System.Windows.Forms.Button();
            this.btm_borrar = new System.Windows.Forms.Button();
            this.detalle_colores = new System.Windows.Forms.Label();
            this.detalle_talles = new System.Windows.Forms.Label();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.detalle_capucha);
            this.groupBox2.Controls.Add(this.detalle_cantidad);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btm_modificar);
            this.groupBox2.Controls.Add(this.btm_borrar);
            this.groupBox2.Controls.Add(this.detalle_colores);
            this.groupBox2.Controls.Add(this.detalle_talles);
            this.groupBox2.Controls.Add(this.btm_agregar);
            this.groupBox2.Location = new System.Drawing.Point(17, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 598);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "pedidos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(145, 38);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(173, 31);
            this.comboBox4.TabIndex = 32;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(9, 201);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(310, 31);
            this.comboBox3.TabIndex = 31;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(8, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(311, 31);
            this.comboBox2.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 347);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 31);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Visible = false;
            // 
            // detalle_capucha
            // 
            this.detalle_capucha.AutoSize = true;
            this.detalle_capucha.Location = new System.Drawing.Point(9, 322);
            this.detalle_capucha.Name = "detalle_capucha";
            this.detalle_capucha.Size = new System.Drawing.Size(88, 23);
            this.detalle_capucha.TabIndex = 28;
            this.detalle_capucha.Text = "CAPUCHA";
            this.detalle_capucha.Visible = false;
            // 
            // detalle_cantidad
            // 
            this.detalle_cantidad.AutoSize = true;
            this.detalle_cantidad.Location = new System.Drawing.Point(8, 251);
            this.detalle_cantidad.Name = "detalle_cantidad";
            this.detalle_cantidad.Size = new System.Drawing.Size(94, 23);
            this.detalle_cantidad.TabIndex = 24;
            this.detalle_cantidad.Text = "CANTIDAD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 30);
            this.textBox1.TabIndex = 23;
            // 
            // btm_modificar
            // 
            this.btm_modificar.Location = new System.Drawing.Point(14, 439);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(304, 35);
            this.btm_modificar.TabIndex = 21;
            this.btm_modificar.Text = "modificar";
            this.btm_modificar.UseVisualStyleBackColor = true;
            this.btm_modificar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Location = new System.Drawing.Point(14, 482);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(304, 35);
            this.btm_borrar.TabIndex = 12;
            this.btm_borrar.Text = "BORRAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // detalle_colores
            // 
            this.detalle_colores.AutoSize = true;
            this.detalle_colores.Location = new System.Drawing.Point(4, 91);
            this.detalle_colores.Name = "detalle_colores";
            this.detalle_colores.Size = new System.Drawing.Size(82, 23);
            this.detalle_colores.TabIndex = 13;
            this.detalle_colores.Text = "COLORES";
            // 
            // detalle_talles
            // 
            this.detalle_talles.AutoSize = true;
            this.detalle_talles.Location = new System.Drawing.Point(10, 175);
            this.detalle_talles.Name = "detalle_talles";
            this.detalle_talles.Size = new System.Drawing.Size(63, 23);
            this.detalle_talles.TabIndex = 17;
            this.detalle_talles.Text = "TALLES";
            // 
            // btm_agregar
            // 
            this.btm_agregar.Location = new System.Drawing.Point(13, 398);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(305, 35);
            this.btm_agregar.TabIndex = 13;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(371, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(842, 602);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // detalle_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 871);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "detalle_pedido";
            this.Text = "detalle_pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.detalle_pedido_FormClosing);
            this.Load += new System.EventHandler(this.detalle_pedido_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label detalle_capucha;
        private System.Windows.Forms.Label detalle_cantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btm_modificar;
        private System.Windows.Forms.Button btm_borrar;
        private System.Windows.Forms.Label detalle_colores;
        private System.Windows.Forms.Label detalle_talles;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}