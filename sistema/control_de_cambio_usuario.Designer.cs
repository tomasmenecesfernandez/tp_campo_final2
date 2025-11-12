
namespace sistema
{
    partial class control_de_cambio_usuario
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
            this.control_btm_revertir = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // control_btm_revertir
            // 
            this.control_btm_revertir.Location = new System.Drawing.Point(290, 204);
            this.control_btm_revertir.Name = "control_btm_revertir";
            this.control_btm_revertir.Size = new System.Drawing.Size(116, 40);
            this.control_btm_revertir.TabIndex = 22;
            this.control_btm_revertir.Text = "REVERTIR";
            this.control_btm_revertir.UseVisualStyleBackColor = true;
            this.control_btm_revertir.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(93, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(560, 132);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // control_de_cambio_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 317);
            this.Controls.Add(this.control_btm_revertir);
            this.Controls.Add(this.dataGridView2);
            this.Name = "control_de_cambio_usuario";
            this.Text = "control_de_cambio_usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.control_de_cambio_usuario_FormClosing);
            this.Load += new System.EventHandler(this.control_de_cambio_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button control_btm_revertir;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}