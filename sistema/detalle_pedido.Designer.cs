
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.detalle_capucha = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.detalle_cantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btm_modificar = new System.Windows.Forms.Button();
            this.detalle_rbtm_buzos = new System.Windows.Forms.RadioButton();
            this.btm_borrar = new System.Windows.Forms.Button();
            this.detalle_colores = new System.Windows.Forms.Label();
            this.detalle_talles = new System.Windows.Forms.Label();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.detalle_rbtm_jogging = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.detalle_capucha);
            this.groupBox2.Controls.Add(this.checkedListBox2);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.detalle_cantidad);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btm_modificar);
            this.groupBox2.Controls.Add(this.detalle_rbtm_buzos);
            this.groupBox2.Controls.Add(this.btm_borrar);
            this.groupBox2.Controls.Add(this.detalle_colores);
            this.groupBox2.Controls.Add(this.detalle_talles);
            this.groupBox2.Controls.Add(this.btm_agregar);
            this.groupBox2.Controls.Add(this.detalle_rbtm_jogging);
            this.groupBox2.Location = new System.Drawing.Point(15, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 416);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "pedidos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 382);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Visible = false;
            // 
            // detalle_capucha
            // 
            this.detalle_capucha.AutoSize = true;
            this.detalle_capucha.Location = new System.Drawing.Point(3, 361);
            this.detalle_capucha.Name = "detalle_capucha";
            this.detalle_capucha.Size = new System.Drawing.Size(73, 17);
            this.detalle_capucha.TabIndex = 28;
            this.detalle_capucha.Text = "CAPUCHA";
            this.detalle_capucha.Visible = false;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "NEGRO",
            "BLANCO",
            "BORDO",
            "MARRON",
            "VERDE",
            "BEIGE"});
            this.checkedListBox2.Location = new System.Drawing.Point(5, 80);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(145, 89);
            this.checkedListBox2.TabIndex = 26;
            this.checkedListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox2_ItemCheck);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.checkedListBox1.Location = new System.Drawing.Point(5, 214);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(145, 72);
            this.checkedListBox1.TabIndex = 25;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // detalle_cantidad
            // 
            this.detalle_cantidad.AutoSize = true;
            this.detalle_cantidad.Location = new System.Drawing.Point(3, 311);
            this.detalle_cantidad.Name = "detalle_cantidad";
            this.detalle_cantidad.Size = new System.Drawing.Size(77, 17);
            this.detalle_cantidad.TabIndex = 24;
            this.detalle_cantidad.Text = "CANTIDAD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 332);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 23;
            // 
            // btm_modificar
            // 
            this.btm_modificar.Location = new System.Drawing.Point(159, 140);
            this.btm_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(100, 42);
            this.btm_modificar.TabIndex = 21;
            this.btm_modificar.Text = "modificar";
            this.btm_modificar.UseVisualStyleBackColor = true;
            this.btm_modificar.Click += new System.EventHandler(this.button5_Click);
            // 
            // detalle_rbtm_buzos
            // 
            this.detalle_rbtm_buzos.AutoSize = true;
            this.detalle_rbtm_buzos.Location = new System.Drawing.Point(12, 26);
            this.detalle_rbtm_buzos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detalle_rbtm_buzos.Name = "detalle_rbtm_buzos";
            this.detalle_rbtm_buzos.Size = new System.Drawing.Size(77, 21);
            this.detalle_rbtm_buzos.TabIndex = 0;
            this.detalle_rbtm_buzos.TabStop = true;
            this.detalle_rbtm_buzos.Text = "BUZOS";
            this.detalle_rbtm_buzos.UseVisualStyleBackColor = true;
            this.detalle_rbtm_buzos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Location = new System.Drawing.Point(159, 203);
            this.btm_borrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(100, 42);
            this.btm_borrar.TabIndex = 12;
            this.btm_borrar.Text = "BORRAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // detalle_colores
            // 
            this.detalle_colores.AutoSize = true;
            this.detalle_colores.Location = new System.Drawing.Point(4, 60);
            this.detalle_colores.Name = "detalle_colores";
            this.detalle_colores.Size = new System.Drawing.Size(75, 17);
            this.detalle_colores.TabIndex = 13;
            this.detalle_colores.Text = "COLORES";
            // 
            // detalle_talles
            // 
            this.detalle_talles.AutoSize = true;
            this.detalle_talles.Location = new System.Drawing.Point(4, 194);
            this.detalle_talles.Name = "detalle_talles";
            this.detalle_talles.Size = new System.Drawing.Size(60, 17);
            this.detalle_talles.TabIndex = 17;
            this.detalle_talles.Text = "TALLES";
            // 
            // btm_agregar
            // 
            this.btm_agregar.Location = new System.Drawing.Point(159, 82);
            this.btm_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(100, 42);
            this.btm_agregar.TabIndex = 13;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.button4_Click);
            // 
            // detalle_rbtm_jogging
            // 
            this.detalle_rbtm_jogging.AutoSize = true;
            this.detalle_rbtm_jogging.Location = new System.Drawing.Point(95, 26);
            this.detalle_rbtm_jogging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detalle_rbtm_jogging.Name = "detalle_rbtm_jogging";
            this.detalle_rbtm_jogging.Size = new System.Drawing.Size(93, 21);
            this.detalle_rbtm_jogging.TabIndex = 0;
            this.detalle_rbtm_jogging.TabStop = true;
            this.detalle_rbtm_jogging.Text = "JOGGING";
            this.detalle_rbtm_jogging.UseVisualStyleBackColor = true;
            this.detalle_rbtm_jogging.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(419, 60);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(659, 308);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // detalle_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label detalle_cantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btm_modificar;
        private System.Windows.Forms.RadioButton detalle_rbtm_buzos;
        private System.Windows.Forms.Button btm_borrar;
        private System.Windows.Forms.Label detalle_colores;
        private System.Windows.Forms.Label detalle_talles;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.RadioButton detalle_rbtm_jogging;
        private System.Windows.Forms.ListBox listBox1;
    }
}