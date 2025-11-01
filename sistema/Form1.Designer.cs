
namespace sistema
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarios_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.login_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportes_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.idioma_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.idioma2_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.sistema_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.permisos_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.CERRAR_SESION_MENU = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.form1_bitacora_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarios_menu,
            this.login_menu,
            this.reportes_menu,
            this.idioma2_menu,
            this.clientes_menu,
            this.sistema_menu,
            this.form1_bitacora_menu,
            this.aBMPermisosToolStripMenuItem,
            this.idioma_menu,
            this.permisos_menu,
            this.CERRAR_SESION_MENU});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1471, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usuarios_menu
            // 
            this.usuarios_menu.Enabled = false;
            this.usuarios_menu.Name = "usuarios_menu";
            this.usuarios_menu.Size = new System.Drawing.Size(77, 24);
            this.usuarios_menu.Text = "usuarios";
            this.usuarios_menu.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // login_menu
            // 
            this.login_menu.Name = "login_menu";
            this.login_menu.Size = new System.Drawing.Size(57, 24);
            this.login_menu.Text = "login";
            this.login_menu.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // reportes_menu
            // 
            this.reportes_menu.Enabled = false;
            this.reportes_menu.Name = "reportes_menu";
            this.reportes_menu.Size = new System.Drawing.Size(78, 24);
            this.reportes_menu.Text = "reportes";
            this.reportes_menu.Click += new System.EventHandler(this.reportes_menu_Click);
            // 
            // idioma_menu
            // 
            this.idioma_menu.Name = "idioma_menu";
            this.idioma_menu.Size = new System.Drawing.Size(76, 24);
            this.idioma_menu.Text = "IDIOMA";
            this.idioma_menu.Click += new System.EventHandler(this.idioma_menu_Click);
            // 
            // idioma2_menu
            // 
            this.idioma2_menu.Enabled = false;
            this.idioma2_menu.Name = "idioma2_menu";
            this.idioma2_menu.Size = new System.Drawing.Size(108, 24);
            this.idioma2_menu.Text = "ABM_idioma";
            this.idioma2_menu.Click += new System.EventHandler(this.idiomaToolStripMenuItem_Click);
            // 
            // clientes_menu
            // 
            this.clientes_menu.Enabled = false;
            this.clientes_menu.Name = "clientes_menu";
            this.clientes_menu.Size = new System.Drawing.Size(75, 24);
            this.clientes_menu.Text = "Clientes";
            this.clientes_menu.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // sistema_menu
            // 
            this.sistema_menu.Enabled = false;
            this.sistema_menu.Name = "sistema_menu";
            this.sistema_menu.Size = new System.Drawing.Size(73, 24);
            this.sistema_menu.Text = "sistema";
            this.sistema_menu.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // permisos_menu
            // 
            this.permisos_menu.Name = "permisos_menu";
            this.permisos_menu.Size = new System.Drawing.Size(83, 24);
            this.permisos_menu.Text = "permisos";
            // 
            // CERRAR_SESION_MENU
            // 
            this.CERRAR_SESION_MENU.Name = "CERRAR_SESION_MENU";
            this.CERRAR_SESION_MENU.Size = new System.Drawing.Size(131, 24);
            this.CERRAR_SESION_MENU.Text = "CERRAR SESION";
            this.CERRAR_SESION_MENU.Click += new System.EventHandler(this.cERRARSESIONToolStripMenuItem_Click);
            // 
            // aBMPermisosToolStripMenuItem
            // 
            this.aBMPermisosToolStripMenuItem.Name = "aBMPermisosToolStripMenuItem";
            this.aBMPermisosToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aBMPermisosToolStripMenuItem.Text = "ABM_Permisos";
            this.aBMPermisosToolStripMenuItem.Click += new System.EventHandler(this.aBMPermisosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1339, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // form1_bitacora_menu
            // 
            this.form1_bitacora_menu.Enabled = false;
            this.form1_bitacora_menu.Name = "form1_bitacora_menu";
            this.form1_bitacora_menu.Size = new System.Drawing.Size(78, 24);
            this.form1_bitacora_menu.Text = "Bitacora";
            this.form1_bitacora_menu.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarios_menu;
        private System.Windows.Forms.ToolStripMenuItem login_menu;
        private System.Windows.Forms.ToolStripMenuItem reportes_menu;
        private System.Windows.Forms.ToolStripMenuItem idioma_menu;
        private System.Windows.Forms.ToolStripMenuItem CERRAR_SESION_MENU;
        private System.Windows.Forms.ToolStripMenuItem idioma2_menu;
        private System.Windows.Forms.ToolStripMenuItem permisos_menu;
        private System.Windows.Forms.ToolStripMenuItem sistema_menu;
        private System.Windows.Forms.ToolStripMenuItem clientes_menu;
        private System.Windows.Forms.ToolStripMenuItem aBMPermisosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem form1_bitacora_menu;
    }
}

