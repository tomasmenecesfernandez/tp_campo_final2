
namespace sistema
{
    partial class personalizar_ropa_talle_color
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
            this.group_box_administrador_variables = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.detalle_capucha = new System.Windows.Forms.Label();
            this.detalle_rbtm_color = new System.Windows.Forms.RadioButton();
            this.btm_borrar = new System.Windows.Forms.Button();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.detalle_rbtm_talles = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.combobox_tipo_ropa = new System.Windows.Forms.Label();
            this.groupBox_vinculacion_variable = new System.Windows.Forms.GroupBox();
            this.detalle_rbtm_color1 = new System.Windows.Forms.RadioButton();
            this.detalle_rbtm_talles1 = new System.Windows.Forms.RadioButton();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.group_box_administrador_variables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_vinculacion_variable.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_box_administrador_variables
            // 
            this.group_box_administrador_variables.Controls.Add(this.textBox1);
            this.group_box_administrador_variables.Controls.Add(this.comboBox1);
            this.group_box_administrador_variables.Controls.Add(this.detalle_capucha);
            this.group_box_administrador_variables.Controls.Add(this.detalle_rbtm_color);
            this.group_box_administrador_variables.Controls.Add(this.btm_borrar);
            this.group_box_administrador_variables.Controls.Add(this.btm_agregar);
            this.group_box_administrador_variables.Controls.Add(this.detalle_rbtm_talles);
            this.group_box_administrador_variables.Location = new System.Drawing.Point(15, 39);
            this.group_box_administrador_variables.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.group_box_administrador_variables.Name = "group_box_administrador_variables";
            this.group_box_administrador_variables.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.group_box_administrador_variables.Size = new System.Drawing.Size(295, 233);
            this.group_box_administrador_variables.TabIndex = 8;
            this.group_box_administrador_variables.TabStop = false;
            this.group_box_administrador_variables.Text = "ADMINISTRADOR DE VARIABLES";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 25);
            this.textBox1.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 583);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 25);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Visible = false;
            // 
            // detalle_capucha
            // 
            this.detalle_capucha.AutoSize = true;
            this.detalle_capucha.Location = new System.Drawing.Point(2, 551);
            this.detalle_capucha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.detalle_capucha.Name = "detalle_capucha";
            this.detalle_capucha.Size = new System.Drawing.Size(73, 19);
            this.detalle_capucha.TabIndex = 28;
            this.detalle_capucha.Text = "CAPUCHA";
            this.detalle_capucha.Visible = false;
            // 
            // detalle_rbtm_color
            // 
            this.detalle_rbtm_color.AutoSize = true;
            this.detalle_rbtm_color.Location = new System.Drawing.Point(12, 35);
            this.detalle_rbtm_color.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.detalle_rbtm_color.Name = "detalle_rbtm_color";
            this.detalle_rbtm_color.Size = new System.Drawing.Size(87, 23);
            this.detalle_rbtm_color.TabIndex = 0;
            this.detalle_rbtm_color.TabStop = true;
            this.detalle_rbtm_color.Text = "COLORES";
            this.detalle_rbtm_color.UseVisualStyleBackColor = true;
            this.detalle_rbtm_color.CheckedChanged += new System.EventHandler(this.detalle_rbtm_color_CheckedChanged);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Image = global::sistema.Properties.Resources.delete_4219;
            this.btm_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_borrar.Location = new System.Drawing.Point(12, 174);
            this.btm_borrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(269, 27);
            this.btm_borrar.TabIndex = 12;
            this.btm_borrar.Text = "BORRAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.btm_borrar_Click);
            // 
            // btm_agregar
            // 
            this.btm_agregar.Image = global::sistema.Properties.Resources.add_button_icon_icons_com_58943;
            this.btm_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_agregar.Location = new System.Drawing.Point(12, 120);
            this.btm_agregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(269, 27);
            this.btm_agregar.TabIndex = 13;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.btm_agregar_Click);
            // 
            // detalle_rbtm_talles
            // 
            this.detalle_rbtm_talles.AutoSize = true;
            this.detalle_rbtm_talles.Location = new System.Drawing.Point(211, 35);
            this.detalle_rbtm_talles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.detalle_rbtm_talles.Name = "detalle_rbtm_talles";
            this.detalle_rbtm_talles.Size = new System.Drawing.Size(70, 23);
            this.detalle_rbtm_talles.TabIndex = 0;
            this.detalle_rbtm_talles.TabStop = true;
            this.detalle_rbtm_talles.Text = "TALLES";
            this.detalle_rbtm_talles.UseVisualStyleBackColor = true;
            this.detalle_rbtm_talles.CheckedChanged += new System.EventHandler(this.detalle_rbtm_talles_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 233);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(131, 41);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 25);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // combobox_tipo_ropa
            // 
            this.combobox_tipo_ropa.AutoSize = true;
            this.combobox_tipo_ropa.Location = new System.Drawing.Point(9, 44);
            this.combobox_tipo_ropa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.combobox_tipo_ropa.Name = "combobox_tipo_ropa";
            this.combobox_tipo_ropa.Size = new System.Drawing.Size(116, 19);
            this.combobox_tipo_ropa.TabIndex = 11;
            this.combobox_tipo_ropa.Text = "TIPO DE PRENDA";
            // 
            // groupBox_vinculacion_variable
            // 
            this.groupBox_vinculacion_variable.Controls.Add(this.detalle_rbtm_color1);
            this.groupBox_vinculacion_variable.Controls.Add(this.detalle_rbtm_talles1);
            this.groupBox_vinculacion_variable.Controls.Add(this.comboBox4);
            this.groupBox_vinculacion_variable.Controls.Add(this.combobox_tipo_ropa);
            this.groupBox_vinculacion_variable.Controls.Add(this.comboBox3);
            this.groupBox_vinculacion_variable.Controls.Add(this.comboBox5);
            this.groupBox_vinculacion_variable.Controls.Add(this.label1);
            this.groupBox_vinculacion_variable.Controls.Add(this.button1);
            this.groupBox_vinculacion_variable.Controls.Add(this.button2);
            this.groupBox_vinculacion_variable.Location = new System.Drawing.Point(15, 294);
            this.groupBox_vinculacion_variable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_vinculacion_variable.Name = "groupBox_vinculacion_variable";
            this.groupBox_vinculacion_variable.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_vinculacion_variable.Size = new System.Drawing.Size(295, 260);
            this.groupBox_vinculacion_variable.TabIndex = 31;
            this.groupBox_vinculacion_variable.TabStop = false;
            this.groupBox_vinculacion_variable.Text = "VINCULACIÓN ROPA";
            this.groupBox_vinculacion_variable.UseCompatibleTextRendering = true;
            this.groupBox_vinculacion_variable.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // detalle_rbtm_color1
            // 
            this.detalle_rbtm_color1.AutoSize = true;
            this.detalle_rbtm_color1.Location = new System.Drawing.Point(12, 84);
            this.detalle_rbtm_color1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.detalle_rbtm_color1.Name = "detalle_rbtm_color1";
            this.detalle_rbtm_color1.Size = new System.Drawing.Size(87, 23);
            this.detalle_rbtm_color1.TabIndex = 31;
            this.detalle_rbtm_color1.TabStop = true;
            this.detalle_rbtm_color1.Text = "COLORES";
            this.detalle_rbtm_color1.UseVisualStyleBackColor = true;
            this.detalle_rbtm_color1.CheckedChanged += new System.EventHandler(this.detalle_rbtm_color1_CheckedChanged);
            // 
            // detalle_rbtm_talles1
            // 
            this.detalle_rbtm_talles1.AutoSize = true;
            this.detalle_rbtm_talles1.Location = new System.Drawing.Point(211, 84);
            this.detalle_rbtm_talles1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.detalle_rbtm_talles1.Name = "detalle_rbtm_talles1";
            this.detalle_rbtm_talles1.Size = new System.Drawing.Size(70, 23);
            this.detalle_rbtm_talles1.TabIndex = 32;
            this.detalle_rbtm_talles1.TabStop = true;
            this.detalle_rbtm_talles1.Text = "TALLES";
            this.detalle_rbtm_talles1.UseVisualStyleBackColor = true;
            this.detalle_rbtm_talles1.CheckedChanged += new System.EventHandler(this.detalle_rbtm_talles1_CheckedChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 112);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(270, 25);
            this.comboBox4.TabIndex = 30;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(7, 583);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(141, 25);
            this.comboBox5.TabIndex = 29;
            this.comboBox5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 551);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "CAPUCHA";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = global::sistema.Properties.Resources.delete_4219;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "BORRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::sistema.Properties.Resources.add_button_icon_icons_com_58943;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 154);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "AGREGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(315, 294);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 242);
            this.listBox1.TabIndex = 32;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // personalizar_ropa_talle_color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox_vinculacion_variable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.group_box_administrador_variables);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "personalizar_ropa_talle_color";
            this.Text = "personalizar_ropa_talle_color";
            this.Load += new System.EventHandler(this.personalizar_ropa_talle_color_Load);
            this.group_box_administrador_variables.ResumeLayout(false);
            this.group_box_administrador_variables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_vinculacion_variable.ResumeLayout(false);
            this.groupBox_vinculacion_variable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_box_administrador_variables;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label detalle_capucha;
        private System.Windows.Forms.RadioButton detalle_rbtm_color;
        private System.Windows.Forms.Button btm_borrar;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.RadioButton detalle_rbtm_talles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label combobox_tipo_ropa;
        private System.Windows.Forms.GroupBox groupBox_vinculacion_variable;
        private System.Windows.Forms.RadioButton detalle_rbtm_color1;
        private System.Windows.Forms.RadioButton detalle_rbtm_talles1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}