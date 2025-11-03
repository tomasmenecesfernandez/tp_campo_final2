
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
            this.btm_agregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btm_modificar = new System.Windows.Forms.Button();
            this.btm_borrar = new System.Windows.Forms.Button();
            this.usuario_label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contraceña_label1 = new System.Windows.Forms.Label();
            this.btm_agregar1 = new System.Windows.Forms.Button();
            this.btm_borrar1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.usuario_rbtm_rol = new System.Windows.Forms.RadioButton();
            this.usuario_rbtm_permiso = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.usuario_btm_ir_historlal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btm_agregar
            // 
            this.btm_agregar.Location = new System.Drawing.Point(15, 202);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(116, 40);
            this.btm_agregar.TabIndex = 0;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 28);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 219);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btm_modificar
            // 
            this.btm_modificar.Location = new System.Drawing.Point(15, 248);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(116, 40);
            this.btm_modificar.TabIndex = 3;
            this.btm_modificar.Text = "MODIFICAR";
            this.btm_modificar.UseVisualStyleBackColor = true;
            this.btm_modificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Location = new System.Drawing.Point(15, 294);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(116, 40);
            this.btm_borrar.TabIndex = 4;
            this.btm_borrar.Text = "BORRAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // usuario_label1
            // 
            this.usuario_label1.AutoSize = true;
            this.usuario_label1.Location = new System.Drawing.Point(12, 23);
            this.usuario_label1.Name = "usuario_label1";
            this.usuario_label1.Size = new System.Drawing.Size(70, 17);
            this.usuario_label1.TabIndex = 5;
            this.usuario_label1.Text = "USUARIO";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 28);
            this.textBox2.TabIndex = 6;
            // 
            // contraceña_label1
            // 
            this.contraceña_label1.AutoSize = true;
            this.contraceña_label1.Location = new System.Drawing.Point(12, 88);
            this.contraceña_label1.Name = "contraceña_label1";
            this.contraceña_label1.Size = new System.Drawing.Size(103, 17);
            this.contraceña_label1.TabIndex = 7;
            this.contraceña_label1.Text = "CONTRASEÑA";
            // 
            // btm_agregar1
            // 
            this.btm_agregar1.Location = new System.Drawing.Point(804, 120);
            this.btm_agregar1.Name = "btm_agregar1";
            this.btm_agregar1.Size = new System.Drawing.Size(116, 40);
            this.btm_agregar1.TabIndex = 14;
            this.btm_agregar1.Text = "AGREGAR";
            this.btm_agregar1.UseVisualStyleBackColor = true;
            this.btm_agregar1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btm_borrar1
            // 
            this.btm_borrar1.Location = new System.Drawing.Point(804, 175);
            this.btm_borrar1.Name = "btm_borrar1";
            this.btm_borrar1.Size = new System.Drawing.Size(116, 40);
            this.btm_borrar1.TabIndex = 12;
            this.btm_borrar1.Text = "BORRAR";
            this.btm_borrar1.UseVisualStyleBackColor = true;
            this.btm_borrar1.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(804, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 24);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // usuario_rbtm_rol
            // 
            this.usuario_rbtm_rol.AutoSize = true;
            this.usuario_rbtm_rol.Location = new System.Drawing.Point(804, 30);
            this.usuario_rbtm_rol.Name = "usuario_rbtm_rol";
            this.usuario_rbtm_rol.Size = new System.Drawing.Size(50, 21);
            this.usuario_rbtm_rol.TabIndex = 16;
            this.usuario_rbtm_rol.TabStop = true;
            this.usuario_rbtm_rol.Text = "Rol";
            this.usuario_rbtm_rol.UseVisualStyleBackColor = true;
            this.usuario_rbtm_rol.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // usuario_rbtm_permiso
            // 
            this.usuario_rbtm_permiso.AutoSize = true;
            this.usuario_rbtm_permiso.Location = new System.Drawing.Point(804, 57);
            this.usuario_rbtm_permiso.Name = "usuario_rbtm_permiso";
            this.usuario_rbtm_permiso.Size = new System.Drawing.Size(80, 21);
            this.usuario_rbtm_permiso.TabIndex = 17;
            this.usuario_rbtm_permiso.TabStop = true;
            this.usuario_rbtm_permiso.Text = "Permiso";
            this.usuario_rbtm_permiso.UseVisualStyleBackColor = true;
            this.usuario_rbtm_permiso.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(985, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(545, 234);
            this.treeView1.TabIndex = 18;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // usuario_btm_ir_historlal
            // 
            this.usuario_btm_ir_historlal.Location = new System.Drawing.Point(301, 260);
            this.usuario_btm_ir_historlal.Name = "usuario_btm_ir_historlal";
            this.usuario_btm_ir_historlal.Size = new System.Drawing.Size(284, 40);
            this.usuario_btm_ir_historlal.TabIndex = 19;
            this.usuario_btm_ir_historlal.Text = "Ir al Historial de cambios";
            this.usuario_btm_ir_historlal.UseVisualStyleBackColor = true;
            this.usuario_btm_ir_historlal.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 812);
            this.Controls.Add(this.usuario_btm_ir_historlal);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.usuario_rbtm_permiso);
            this.Controls.Add(this.usuario_rbtm_rol);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btm_agregar1);
            this.Controls.Add(this.btm_borrar1);
            this.Controls.Add(this.contraceña_label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usuario_label1);
            this.Controls.Add(this.btm_borrar);
            this.Controls.Add(this.btm_modificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btm_agregar);
            this.Name = "usuarios";
            this.Text = "usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.usuarios_FormClosing);
            this.Load += new System.EventHandler(this.usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btm_modificar;
        private System.Windows.Forms.Button btm_borrar;
        private System.Windows.Forms.Label usuario_label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label contraceña_label1;
        private System.Windows.Forms.Button btm_agregar1;
        private System.Windows.Forms.Button btm_borrar1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton usuario_rbtm_rol;
        private System.Windows.Forms.RadioButton usuario_rbtm_permiso;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button usuario_btm_ir_historlal;
    }
}