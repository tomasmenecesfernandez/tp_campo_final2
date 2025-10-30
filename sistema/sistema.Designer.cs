
namespace sistema
{
    partial class sistema
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
            this.btm_comprar_sistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btm_comprar_sistema
            // 
            this.btm_comprar_sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_comprar_sistema.Location = new System.Drawing.Point(246, 164);
            this.btm_comprar_sistema.Name = "btm_comprar_sistema";
            this.btm_comprar_sistema.Size = new System.Drawing.Size(291, 77);
            this.btm_comprar_sistema.TabIndex = 0;
            this.btm_comprar_sistema.Text = "COMPRAR";
            this.btm_comprar_sistema.UseVisualStyleBackColor = true;
            this.btm_comprar_sistema.Click += new System.EventHandler(this.button1_Click);
            // 
            // sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btm_comprar_sistema);
            this.Name = "sistema";
            this.Text = "sistema";
            this.Load += new System.EventHandler(this.sistema_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btm_comprar_sistema;
    }
}