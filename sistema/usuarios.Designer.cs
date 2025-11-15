
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
            this.usuario_btm_ir_historlal = new System.Windows.Forms.Button();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btm_modificar = new System.Windows.Forms.Button();
            this.btm_borrar = new System.Windows.Forms.Button();
            this.usuario_label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contraceña_label1 = new System.Windows.Forms.Label();
            this.usuario_rbtm_rol = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.usuario_rbtm_permiso = new System.Windows.Forms.RadioButton();
            this.btm_agregar1 = new System.Windows.Forms.Button();
            this.btm_borrar1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuario_btm_ir_historlal
            // 
            this.usuario_btm_ir_historlal.Location = new System.Drawing.Point(335, 277);
            this.usuario_btm_ir_historlal.Name = "usuario_btm_ir_historlal";
            this.usuario_btm_ir_historlal.Size = new System.Drawing.Size(248, 42);
            this.usuario_btm_ir_historlal.TabIndex = 19;
            this.usuario_btm_ir_historlal.Text = "Ir al Historial de cambios";
            this.usuario_btm_ir_historlal.UseVisualStyleBackColor = true;
            this.usuario_btm_ir_historlal.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btm_agregar
            // 
            this.btm_agregar.Location = new System.Drawing.Point(51, 174);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(161, 42);
            this.btm_agregar.TabIndex = 0;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(51, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 24);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(490, 233);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btm_modificar
            // 
            this.btm_modificar.Location = new System.Drawing.Point(51, 223);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(161, 42);
            this.btm_modificar.TabIndex = 3;
            this.btm_modificar.Text = "MODIFICAR";
            this.btm_modificar.UseVisualStyleBackColor = true;
            this.btm_modificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Location = new System.Drawing.Point(51, 272);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(161, 42);
            this.btm_borrar.TabIndex = 4;
            this.btm_borrar.Text = "BORRAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // usuario_label1
            // 
            this.usuario_label1.AutoSize = true;
            this.usuario_label1.Location = new System.Drawing.Point(51, 38);
            this.usuario_label1.Name = "usuario_label1";
            this.usuario_label1.Size = new System.Drawing.Size(68, 19);
            this.usuario_label1.TabIndex = 5;
            this.usuario_label1.Text = "USUARIO";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(51, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 24);
            this.textBox2.TabIndex = 6;
            // 
            // contraceña_label1
            // 
            this.contraceña_label1.AutoSize = true;
            this.contraceña_label1.Location = new System.Drawing.Point(51, 107);
            this.contraceña_label1.Name = "contraceña_label1";
            this.contraceña_label1.Size = new System.Drawing.Size(96, 19);
            this.contraceña_label1.TabIndex = 7;
            this.contraceña_label1.Text = "CONTRASEÑA";
            // 
            // usuario_rbtm_rol
            // 
            this.usuario_rbtm_rol.AutoSize = true;
            this.usuario_rbtm_rol.Location = new System.Drawing.Point(0, 30);
            this.usuario_rbtm_rol.Name = "usuario_rbtm_rol";
            this.usuario_rbtm_rol.Size = new System.Drawing.Size(46, 23);
            this.usuario_rbtm_rol.TabIndex = 16;
            this.usuario_rbtm_rol.TabStop = true;
            this.usuario_rbtm_rol.Text = "Rol";
            this.usuario_rbtm_rol.UseVisualStyleBackColor = true;
            this.usuario_rbtm_rol.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(0, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 25);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // usuario_rbtm_permiso
            // 
            this.usuario_rbtm_permiso.AutoSize = true;
            this.usuario_rbtm_permiso.Location = new System.Drawing.Point(0, 58);
            this.usuario_rbtm_permiso.Name = "usuario_rbtm_permiso";
            this.usuario_rbtm_permiso.Size = new System.Drawing.Size(75, 23);
            this.usuario_rbtm_permiso.TabIndex = 17;
            this.usuario_rbtm_permiso.TabStop = true;
            this.usuario_rbtm_permiso.Text = "Permiso";
            this.usuario_rbtm_permiso.UseVisualStyleBackColor = true;
            this.usuario_rbtm_permiso.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btm_agregar1
            // 
            this.btm_agregar1.Location = new System.Drawing.Point(0, 125);
            this.btm_agregar1.Name = "btm_agregar1";
            this.btm_agregar1.Size = new System.Drawing.Size(161, 42);
            this.btm_agregar1.TabIndex = 14;
            this.btm_agregar1.Text = "AGREGAR";
            this.btm_agregar1.UseVisualStyleBackColor = true;
            this.btm_agregar1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btm_borrar1
            // 
            this.btm_borrar1.Location = new System.Drawing.Point(0, 184);
            this.btm_borrar1.Name = "btm_borrar1";
            this.btm_borrar1.Size = new System.Drawing.Size(161, 42);
            this.btm_borrar1.TabIndex = 12;
            this.btm_borrar1.Text = "BORRAR";
            this.btm_borrar1.UseVisualStyleBackColor = true;
            this.btm_borrar1.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(178, 22);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(490, 248);
            this.treeView1.TabIndex = 18;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.btm_borrar1);
            this.groupBox1.Controls.Add(this.btm_agregar1);
            this.groupBox1.Controls.Add(this.usuario_rbtm_permiso);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.usuario_rbtm_rol);
            this.groupBox1.Location = new System.Drawing.Point(51, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 295);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".";
            this.groupBox1.Visible = false;
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 749);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "usuarios";
            this.Text = "usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.usuarios_FormClosing);
            this.Load += new System.EventHandler(this.usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}