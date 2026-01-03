
namespace sistema
{
    partial class formulario_datos_compostite
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.form_extra_label_nombre_rol = new System.Windows.Forms.Label();
            this.btm_guardar = new System.Windows.Forms.Button();
            this.btm_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(68, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 29;
            // 
            // form_extra_label_nombre_rol
            // 
            this.form_extra_label_nombre_rol.AutoSize = true;
            this.form_extra_label_nombre_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_extra_label_nombre_rol.Location = new System.Drawing.Point(68, 28);
            this.form_extra_label_nombre_rol.Name = "form_extra_label_nombre_rol";
            this.form_extra_label_nombre_rol.Size = new System.Drawing.Size(78, 17);
            this.form_extra_label_nombre_rol.TabIndex = 32;
            this.form_extra_label_nombre_rol.Text = "Nombre rol";
            // 
            // btm_guardar
            // 
            this.btm_guardar.Image = global::sistema.Properties.Resources.Things_34164;
            this.btm_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btm_guardar.Location = new System.Drawing.Point(68, 87);
            this.btm_guardar.Name = "btm_guardar";
            this.btm_guardar.Size = new System.Drawing.Size(142, 42);
            this.btm_guardar.TabIndex = 31;
            this.btm_guardar.Text = "GUARDAR";
            this.btm_guardar.UseVisualStyleBackColor = true;
            this.btm_guardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btm_cancelar
            // 
            this.btm_cancelar.Image = global::sistema.Properties.Resources.delete_delete_exit_1577;
            this.btm_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btm_cancelar.Location = new System.Drawing.Point(68, 136);
            this.btm_cancelar.Name = "btm_cancelar";
            this.btm_cancelar.Size = new System.Drawing.Size(142, 42);
            this.btm_cancelar.TabIndex = 30;
            this.btm_cancelar.Text = "CANCELAR";
            this.btm_cancelar.UseVisualStyleBackColor = true;
            this.btm_cancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // formulario_datos_compostite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 218);
            this.Controls.Add(this.form_extra_label_nombre_rol);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btm_guardar);
            this.Controls.Add(this.btm_cancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formulario_datos_compostite";
            this.Text = "formulario_datos_compostite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formulario_datos_compostite_FormClosing);
            this.Load += new System.EventHandler(this.formulario_datos_compostite_Load);
            this.LocationChanged += new System.EventHandler(this.formulario_datos_compostite_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btm_guardar;
        private System.Windows.Forms.Button btm_cancelar;
        private System.Windows.Forms.Label form_extra_label_nombre_rol;
    }
}