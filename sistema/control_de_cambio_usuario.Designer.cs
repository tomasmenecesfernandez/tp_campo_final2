
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.control_btm_revertir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(81, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(490, 140);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // control_btm_revertir
            // 
            this.control_btm_revertir.Image = global::sistema.Properties.Resources.undo_arrow_icon_icons_com_73353;
            this.control_btm_revertir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.control_btm_revertir.Location = new System.Drawing.Point(272, 216);
            this.control_btm_revertir.Name = "control_btm_revertir";
            this.control_btm_revertir.Size = new System.Drawing.Size(109, 42);
            this.control_btm_revertir.TabIndex = 22;
            this.control_btm_revertir.Text = "REVERTIR";
            this.control_btm_revertir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.control_btm_revertir.UseVisualStyleBackColor = true;
            this.control_btm_revertir.Click += new System.EventHandler(this.button4_Click);
            // 
            // control_de_cambio_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 337);
            this.Controls.Add(this.control_btm_revertir);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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