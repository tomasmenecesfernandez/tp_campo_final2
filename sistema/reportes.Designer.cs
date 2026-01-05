
namespace sistema
{
    partial class reportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.lbl_fecha_hasta = new System.Windows.Forms.Label();
            this.label_Fecha_inicio = new System.Windows.Forms.Label();
            this.label_fecha_final = new System.Windows.Forms.Label();
            this.lbl_monto_total = new System.Windows.Forms.Label();
            this.label_monto_total = new System.Windows.Forms.Label();
            this.boton_Exportar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 121);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 349);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(476, 121);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(552, 470);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "HOY",
            "ULTIMA SEMANA",
            "ULTIMO MES",
            "ULTIMO AÑO",
            "DESDE EL INICIO"});
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HOY",
            "ULTIMA SEMANA",
            "ULTIMO MES",
            "ULTIMO AÑO",
            "DESDE EL INICIO"});
            this.comboBox1.Location = new System.Drawing.Point(472, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 31);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(472, 76);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(110, 23);
            this.lbl_fecha_inicio.TabIndex = 3;
            this.lbl_fecha_inicio.Text = "Fecha Desde:";
            // 
            // lbl_fecha_hasta
            // 
            this.lbl_fecha_hasta.AutoSize = true;
            this.lbl_fecha_hasta.Location = new System.Drawing.Point(733, 76);
            this.lbl_fecha_hasta.Name = "lbl_fecha_hasta";
            this.lbl_fecha_hasta.Size = new System.Drawing.Size(106, 23);
            this.lbl_fecha_hasta.TabIndex = 4;
            this.lbl_fecha_hasta.Text = "Fecha Hasta:";
            // 
            // label_Fecha_inicio
            // 
            this.label_Fecha_inicio.AutoSize = true;
            this.label_Fecha_inicio.Location = new System.Drawing.Point(579, 76);
            this.label_Fecha_inicio.Name = "label_Fecha_inicio";
            this.label_Fecha_inicio.Size = new System.Drawing.Size(14, 23);
            this.label_Fecha_inicio.TabIndex = 5;
            this.label_Fecha_inicio.Text = ".";
            // 
            // label_fecha_final
            // 
            this.label_fecha_final.AutoSize = true;
            this.label_fecha_final.Location = new System.Drawing.Point(834, 76);
            this.label_fecha_final.Name = "label_fecha_final";
            this.label_fecha_final.Size = new System.Drawing.Size(14, 23);
            this.label_fecha_final.TabIndex = 6;
            this.label_fecha_final.Text = ".";
            // 
            // lbl_monto_total
            // 
            this.lbl_monto_total.AutoSize = true;
            this.lbl_monto_total.Location = new System.Drawing.Point(468, 608);
            this.lbl_monto_total.Name = "lbl_monto_total";
            this.lbl_monto_total.Size = new System.Drawing.Size(281, 23);
            this.lbl_monto_total.TabIndex = 7;
            this.lbl_monto_total.Text = "Monto Total De Ventas Por Periodo:";
            // 
            // label_monto_total
            // 
            this.label_monto_total.AutoSize = true;
            this.label_monto_total.Location = new System.Drawing.Point(696, 608);
            this.label_monto_total.Name = "label_monto_total";
            this.label_monto_total.Size = new System.Drawing.Size(14, 23);
            this.label_monto_total.TabIndex = 8;
            this.label_monto_total.Text = ".";
            // 
            // boton_Exportar
            // 
            this.boton_Exportar.Location = new System.Drawing.Point(12, 477);
            this.boton_Exportar.Name = "boton_Exportar";
            this.boton_Exportar.Size = new System.Drawing.Size(385, 50);
            this.boton_Exportar.TabIndex = 9;
            this.boton_Exportar.Text = "Exportar a pdf";
            this.boton_Exportar.UseVisualStyleBackColor = true;
            this.boton_Exportar.Click += new System.EventHandler(this.boton_Exportar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema.Properties.Resources.report_icon_216913;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 45);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boton_Exportar);
            this.Controls.Add(this.label_monto_total);
            this.Controls.Add(this.lbl_monto_total);
            this.Controls.Add(this.label_fecha_final);
            this.Controls.Add(this.label_Fecha_inicio);
            this.Controls.Add(this.lbl_fecha_hasta);
            this.Controls.Add(this.lbl_fecha_inicio);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.Name = "reportes";
            this.Text = "reportes";
            this.Load += new System.EventHandler(this.reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.Label lbl_fecha_hasta;
        private System.Windows.Forms.Label label_Fecha_inicio;
        private System.Windows.Forms.Label label_fecha_final;
        private System.Windows.Forms.Label lbl_monto_total;
        private System.Windows.Forms.Label label_monto_total;
        private System.Windows.Forms.Button boton_Exportar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}