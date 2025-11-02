
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
            this.idioma2_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistema_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_bitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ABMPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.permisos_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.CERRAR_SESION_MENU = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_label_usuario = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menu_clientes,
            this.sistema_menu,
            this.menu_bitacora,
            this.menu_ABMPermisos,
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
            // idioma2_menu
            // 
            this.idioma2_menu.Enabled = false;
            this.idioma2_menu.Name = "idioma2_menu";
            this.idioma2_menu.Size = new System.Drawing.Size(108, 24);
            this.idioma2_menu.Text = "ABM_idioma";
            this.idioma2_menu.Click += new System.EventHandler(this.idiomaToolStripMenuItem_Click);
            // 
            // menu_clientes
            // 
            this.menu_clientes.Enabled = false;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(75, 24);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // sistema_menu
            // 
            this.sistema_menu.Enabled = false;
            this.sistema_menu.Name = "sistema_menu";
            this.sistema_menu.Size = new System.Drawing.Size(73, 24);
            this.sistema_menu.Text = "sistema";
            this.sistema_menu.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // menu_bitacora
            // 
            this.menu_bitacora.Enabled = false;
            this.menu_bitacora.Name = "menu_bitacora";
            this.menu_bitacora.Size = new System.Drawing.Size(78, 24);
            this.menu_bitacora.Text = "Bitacora";
            this.menu_bitacora.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click_1);
            // 
            // menu_ABMPermisos
            // 
            this.menu_ABMPermisos.Name = "menu_ABMPermisos";
            this.menu_ABMPermisos.Size = new System.Drawing.Size(119, 24);
            this.menu_ABMPermisos.Text = "ABM_Permisos";
            this.menu_ABMPermisos.Click += new System.EventHandler(this.aBMPermisosToolStripMenuItem_Click);
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
            // menu_label_usuario
            // 
            this.menu_label_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_label_usuario.AutoSize = true;
            this.menu_label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_label_usuario.Location = new System.Drawing.Point(1328, 4);
            this.menu_label_usuario.Name = "menu_label_usuario";
            this.menu_label_usuario.Size = new System.Drawing.Size(53, 20);
            this.menu_label_usuario.TabIndex = 3;
            this.menu_label_usuario.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1178, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "IDIOMAS";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1406, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menu_label_usuario);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ToolStripMenuItem CERRAR_SESION_MENU;
        private System.Windows.Forms.ToolStripMenuItem idioma2_menu;
        private System.Windows.Forms.ToolStripMenuItem permisos_menu;
        private System.Windows.Forms.ToolStripMenuItem sistema_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes;
        private System.Windows.Forms.ToolStripMenuItem menu_ABMPermisos;
        private System.Windows.Forms.Label menu_label_usuario;
        private System.Windows.Forms.ToolStripMenuItem menu_bitacora;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

