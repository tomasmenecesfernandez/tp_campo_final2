
namespace sistema
{
    partial class composite
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.composite_rbtm_permiso = new System.Windows.Forms.RadioButton();
            this.composite_rbtm_rol = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.btm_modificar = new System.Windows.Forms.Button();
            this.btm_borrar = new System.Windows.Forms.Button();
            this.composite_seleccionado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(212, 45);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(677, 460);
            this.treeView1.TabIndex = 25;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // composite_rbtm_permiso
            // 
            this.composite_rbtm_permiso.AutoSize = true;
            this.composite_rbtm_permiso.Location = new System.Drawing.Point(23, 33);
            this.composite_rbtm_permiso.Name = "composite_rbtm_permiso";
            this.composite_rbtm_permiso.Size = new System.Drawing.Size(80, 21);
            this.composite_rbtm_permiso.TabIndex = 24;
            this.composite_rbtm_permiso.TabStop = true;
            this.composite_rbtm_permiso.Text = "Permiso";
            this.composite_rbtm_permiso.UseVisualStyleBackColor = true;
            this.composite_rbtm_permiso.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // composite_rbtm_rol
            // 
            this.composite_rbtm_rol.AutoSize = true;
            this.composite_rbtm_rol.Location = new System.Drawing.Point(23, 6);
            this.composite_rbtm_rol.Name = "composite_rbtm_rol";
            this.composite_rbtm_rol.Size = new System.Drawing.Size(50, 21);
            this.composite_rbtm_rol.TabIndex = 23;
            this.composite_rbtm_rol.TabStop = true;
            this.composite_rbtm_rol.Text = "Rol";
            this.composite_rbtm_rol.UseVisualStyleBackColor = true;
            this.composite_rbtm_rol.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(23, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 24);
            this.comboBox2.TabIndex = 22;
            // 
            // btm_agregar
            // 
            this.btm_agregar.Location = new System.Drawing.Point(23, 96);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(116, 40);
            this.btm_agregar.TabIndex = 21;
            this.btm_agregar.Text = "AGREGAR";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btm_modificar
            // 
            this.btm_modificar.Location = new System.Drawing.Point(23, 142);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(116, 40);
            this.btm_modificar.TabIndex = 20;
            this.btm_modificar.Text = "MODIFICAR";
            this.btm_modificar.UseVisualStyleBackColor = true;
            this.btm_modificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btm_borrar
            // 
            this.btm_borrar.Location = new System.Drawing.Point(23, 188);
            this.btm_borrar.Name = "btm_borrar";
            this.btm_borrar.Size = new System.Drawing.Size(116, 40);
            this.btm_borrar.TabIndex = 19;
            this.btm_borrar.Text = "BORRAR";
            this.btm_borrar.UseVisualStyleBackColor = true;
            this.btm_borrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // composite_seleccionado
            // 
            this.composite_seleccionado.AutoSize = true;
            this.composite_seleccionado.Location = new System.Drawing.Point(8, 13);
            this.composite_seleccionado.Name = "composite_seleccionado";
            this.composite_seleccionado.Size = new System.Drawing.Size(165, 17);
            this.composite_seleccionado.TabIndex = 26;
            this.composite_seleccionado.Text = "NODO SELECCIONADO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = ".";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "CREAR NUEVO ROL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.btm_borrar);
            this.groupBox2.Controls.Add(this.btm_modificar);
            this.groupBox2.Controls.Add(this.btm_agregar);
            this.groupBox2.Controls.Add(this.composite_rbtm_rol);
            this.groupBox2.Controls.Add(this.composite_rbtm_permiso);
            this.groupBox2.Location = new System.Drawing.Point(6, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 242);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".";
            // 
            // composite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 735);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.composite_seleccionado);
            this.Controls.Add(this.treeView1);
            this.Name = "composite";
            this.Text = "composite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.composite_FormClosing);
            this.Load += new System.EventHandler(this.composite_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton composite_rbtm_permiso;
        private System.Windows.Forms.RadioButton composite_rbtm_rol;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.Button btm_modificar;
        private System.Windows.Forms.Button btm_borrar;
        private System.Windows.Forms.Label composite_seleccionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}