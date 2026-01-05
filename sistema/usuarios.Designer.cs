
namespace sistema
{
    partial class usuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btm_borrar1 = new System.Windows.Forms.Button();
            this.btm_agregar1 = new System.Windows.Forms.Button();
            this.usuario_rbtm_permiso = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.usuario_rbtm_rol = new System.Windows.Forms.RadioButton();
            this.usuario_btm_ir_historlal = new System.Windows.Forms.Button();
            this.contraceña_label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usuario_label1 = new System.Windows.Forms.Label();
            this.btm_borrar = new System.Windows.Forms.Button();
            this.btm_modificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.btm_borrar1);
            this.groupBox1.Controls.Add(this.btm_agregar1);
            this.groupBox1.Controls.Add(this.usuario_rbtm_permiso);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.usuario_rbtm_rol);
            this.groupBox1.Location = new System.Drawing.Point(44, 348);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1046, 399);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".";
            this.groupBox1.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(342, 14);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(695, 298);
            this.treeView1.TabIndex = 18;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btm_borrar1
            // 
            this.btm_borrar1.Image = global::sistema.Properties.Resources.delete_4219;
            this.btm_borrar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_borrar1.Location = new System.Drawing.Point(0, 162);
            this.btm_borrar1.Margin = new System.Windows.Forms.Padding(4);
            this.btm_borrar1.Name = "btm_borrar1";
            this.btm_borrar1.Size = new System.Drawing.Size(319, 30);
            this.btm_borrar1.TabIndex = 12;
            this.btm_borrar1.Text = "BORRAR";
            this.btm_borrar1.UseVisualStyleBackColor = true;
            this.btm_borrar1.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btm_agregar1
            // 
            this.btm_agregar1.Image = global::sistema.Properties.Resources.add_button_icon_icons_com_58943;
            this.btm_agregar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_agregar1.Location = new System.Drawing.Point(0, 123);
            this.btm_agregar1.Margin = new System.Windows.Forms.Padding(4);
            this.btm_agregar1.Name = "btm_agregar1";
            this.btm_agregar1.Size = new System.Drawing.Size(319, 31);
            this.btm_agregar1.TabIndex = 14;
            this.btm_agregar1.Text = "AGREGAR";
            this.btm_agregar1.UseVisualStyleBackColor = true;
            this.btm_agregar1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // usuario_rbtm_permiso
            // 
            this.usuario_rbtm_permiso.AutoSize = true;
            this.usuario_rbtm_permiso.Location = new System.Drawing.Point(178, 22);
            this.usuario_rbtm_permiso.Margin = new System.Windows.Forms.Padding(4);
            this.usuario_rbtm_permiso.Name = "usuario_rbtm_permiso";
            this.usuario_rbtm_permiso.Size = new System.Drawing.Size(91, 27);
            this.usuario_rbtm_permiso.TabIndex = 17;
            this.usuario_rbtm_permiso.TabStop = true;
            this.usuario_rbtm_permiso.Text = "Permiso";
            this.usuario_rbtm_permiso.UseVisualStyleBackColor = true;
            this.usuario_rbtm_permiso.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(0, 58);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(319, 31);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // usuario_rbtm_rol
            // 
            this.usuario_rbtm_rol.AutoSize = true;
            this.usuario_rbtm_rol.Location = new System.Drawing.Point(71, 22);
            this.usuario_rbtm_rol.Margin = new System.Windows.Forms.Padding(4);
            this.usuario_rbtm_rol.Name = "usuario_rbtm_rol";
            this.usuario_rbtm_rol.Size = new System.Drawing.Size(55, 27);
            this.usuario_rbtm_rol.TabIndex = 16;
            this.usuario_rbtm_rol.TabStop = true;
            this.usuario_rbtm_rol.Text = "Rol";
            this.usuario_rbtm_rol.UseVisualStyleBackColor = true;
            this.usuario_rbtm_rol.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // usuario_btm_ir_historlal
            // 
            this.usuario_btm_ir_historlal.Image = global::sistema.Properties.Resources.report_icon_216913;
            this.usuario_btm_ir_historlal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usuario_btm_ir_historlal.Location = new System.Drawing.Point(44, 305);
            this.usuario_btm_ir_historlal.Margin = new System.Windows.Forms.Padding(4);
            this.usuario_btm_ir_historlal.Name = "usuario_btm_ir_historlal";
            this.usuario_btm_ir_historlal.Size = new System.Drawing.Size(319, 35);
            this.usuario_btm_ir_historlal.TabIndex = 19;
            this.usuario_btm_ir_historlal.Text = "Ir al Historial de cambios";
            this.usuario_btm_ir_historlal.UseVisualStyleBackColor = true;
            this.usuario_btm_ir_historlal.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // contraceña_label1
            // 
            this.contraceña_label1.AutoSize = true;
            this.contraceña_label1.Location = new System.Drawing.Point(44, 110);
            this.contraceña_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contraceña_label1.Name = "contraceña_label1";
            this.contraceña_label1.Size = new System.Drawing.Size(119, 23);
            this.contraceña_label1.TabIndex = 7;
            this.contraceña_label1.Text = "CONTRASEÑA";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(44, 133);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 28);
            this.textBox2.TabIndex = 6;
            // 
            // usuario_label1
            // 
            this.usuario_label1.AutoSize = true;
            this.usuario_label1.Location = new System.Drawing.Point(44, 44);
            this.usuario_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuario_label1.Name = "usuario_label1";
            this.usuario_label1.Size = new System.Drawing.Size(82, 23);
            this.usuario_label1.TabIndex = 5;
            this.usuario_label1.Text = "USUARIO";
            // 
            // btm_borrar
            // 
            this.btm_borrar.Image = global::sistema.Properties.Resources.delete_4219;
            this.btm_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_borrar.Location = new System.Drawing.Point(44, 263);
            this.btm_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(319, 34);
            this.btm_borrar.TabIndex = 4;
            this.btm_borrar.Text = "BORRAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btm_modificar
            // 
            this.btm_modificar.Image = global::sistema.Properties.Resources.edit_modify_icon_1494881;
            this.btm_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_modificar.Location = new System.Drawing.Point(44, 221);
            this.btm_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(319, 34);
            this.btm_modificar.TabIndex = 3;
            this.btm_modificar.Text = "MODIFICAR";
            this.btm_modificar.UseVisualStyleBackColor = true;
            this.btm_modificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(386, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 306);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(44, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 28);
            this.textBox1.TabIndex = 1;
            // 
            // btm_agregar
            // 
            this.btm_agregar.Image = global::sistema.Properties.Resources.add_button_icon_icons_com_58943;
            this.btm_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_agregar.Location = new System.Drawing.Point(44, 179);
            this.btm_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(319, 34);
            this.btm_agregar.TabIndex = 0;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema.Properties.Resources.users_icon_icons_com_57999;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 25);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 1013);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usuario_btm_ir_historlal);
            this.Controls.Add(this.contraceña_label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usuario_label1);
            this.Controls.Add(this.btm_borrar);
            this.Controls.Add(this.btm_modificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btm_agregar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usuarios";
            this.Text = "usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.usuarios_FormClosing);
            this.Load += new System.EventHandler(this.usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button usuario_btm_ir_historlal;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btm_modificar;
        private System.Windows.Forms.Button btm_borrar;
        private System.Windows.Forms.Label usuario_label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label contraceña_label1;
        private System.Windows.Forms.RadioButton usuario_rbtm_rol;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton usuario_rbtm_permiso;
        private System.Windows.Forms.Button btm_agregar1;
        private System.Windows.Forms.Button btm_borrar1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}