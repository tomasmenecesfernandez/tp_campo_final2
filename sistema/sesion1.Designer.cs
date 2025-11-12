
namespace sistema
{
    partial class sesion1
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
            this.contraseña_label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usuario_label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sesion_ingresar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_idioma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contraseña_label2
            // 
            this.contraseña_label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial;
            this.contraseña_label2.AutoSize = true;
            this.contraseña_label2.Location = new System.Drawing.Point(12, 77);
            this.contraseña_label2.Name = "contraseña_label2";
            this.contraseña_label2.Size = new System.Drawing.Size(103, 17);
            this.contraseña_label2.TabIndex = 12;
            this.contraseña_label2.Text = "CONTRASEÑA";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 28);
            this.textBox2.TabIndex = 11;
            // 
            // usuario_label2
            // 
            this.usuario_label2.AutoSize = true;
            this.usuario_label2.Location = new System.Drawing.Point(12, 12);
            this.usuario_label2.Name = "usuario_label2";
            this.usuario_label2.Size = new System.Drawing.Size(70, 17);
            this.usuario_label2.TabIndex = 10;
            this.usuario_label2.Text = "USUARIO";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 28);
            this.textBox1.TabIndex = 9;
            // 
            // sesion_ingresar
            // 
            this.sesion_ingresar.Location = new System.Drawing.Point(12, 146);
            this.sesion_ingresar.Name = "sesion_ingresar";
            this.sesion_ingresar.Size = new System.Drawing.Size(184, 40);
            this.sesion_ingresar.TabIndex = 8;
            this.sesion_ingresar.Text = "INGRESAR";
            this.sesion_ingresar.UseVisualStyleBackColor = true;
            this.sesion_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label_idioma
            // 
            this.label_idioma.AutoSize = true;
            this.label_idioma.Location = new System.Drawing.Point(240, 12);
            this.label_idioma.Name = "label_idioma";
            this.label_idioma.Size = new System.Drawing.Size(55, 17);
            this.label_idioma.TabIndex = 14;
            this.label_idioma.Text = "IDIOMA";
            // 
            // sesion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 216);
            this.Controls.Add(this.label_idioma);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.contraseña_label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usuario_label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sesion_ingresar);
            this.Name = "sesion1";
            this.Text = "sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sesion1_FormClosing);
            this.Load += new System.EventHandler(this.sesion1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contraseña_label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label usuario_label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sesion_ingresar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_idioma;
    }
}