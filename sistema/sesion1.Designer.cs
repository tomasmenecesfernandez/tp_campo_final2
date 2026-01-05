
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseña_label2
            // 
            this.contraseña_label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial;
            this.contraseña_label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contraseña_label2.AutoSize = true;
            this.contraseña_label2.Location = new System.Drawing.Point(38, 109);
            this.contraseña_label2.Name = "contraseña_label2";
            this.contraseña_label2.Size = new System.Drawing.Size(119, 23);
            this.contraseña_label2.TabIndex = 12;
            this.contraseña_label2.Text = "CONTRASEÑA";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(38, 132);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(353, 28);
            this.textBox2.TabIndex = 11;
            // 
            // usuario_label2
            // 
            this.usuario_label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usuario_label2.AutoSize = true;
            this.usuario_label2.Location = new System.Drawing.Point(38, 54);
            this.usuario_label2.Name = "usuario_label2";
            this.usuario_label2.Size = new System.Drawing.Size(82, 23);
            this.usuario_label2.TabIndex = 10;
            this.usuario_label2.Text = "USUARIO";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(38, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 28);
            this.textBox1.TabIndex = 9;
            // 
            // sesion_ingresar
            // 
            this.sesion_ingresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sesion_ingresar.BackColor = System.Drawing.Color.SteelBlue;
            this.sesion_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sesion_ingresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sesion_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sesion_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesion_ingresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sesion_ingresar.Location = new System.Drawing.Point(38, 199);
            this.sesion_ingresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sesion_ingresar.Name = "sesion_ingresar";
            this.sesion_ingresar.Size = new System.Drawing.Size(353, 57);
            this.sesion_ingresar.TabIndex = 8;
            this.sesion_ingresar.Text = "INGRESAR";
            this.sesion_ingresar.UseVisualStyleBackColor = false;
            this.sesion_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 77);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 31);
            this.comboBox1.TabIndex = 13;
            // 
            // label_idioma
            // 
            this.label_idioma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_idioma.AutoSize = true;
            this.label_idioma.Location = new System.Drawing.Point(411, 54);
            this.label_idioma.Name = "label_idioma";
            this.label_idioma.Size = new System.Drawing.Size(71, 23);
            this.label_idioma.TabIndex = 14;
            this.label_idioma.Text = "IDIOMA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema.Properties.Resources.login_80010;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 40);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // sesion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(635, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_idioma);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.contraseña_label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usuario_label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sesion_ingresar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "sesion1";
            this.Text = "sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sesion1_FormClosing);
            this.Load += new System.EventHandler(this.sesion1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label contraseña_label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label usuario_label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sesion_ingresar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_idioma;
    }
}