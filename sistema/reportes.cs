using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.observer;
using BE;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace sistema
{
    public partial class reportes : formulario_estilo,Iobservertraduccion
    {
        public reportes(idiomas idiomas)
        {
            InitializeComponent();
            idioma = idiomas;
            idiomas.guardar_observer(this);
            actualizar_idioma();
        }
        idiomas idioma;
        List<BEcliente> lista_clientes;
        List<BEusuario> lista_usuarios;
        BLL_cliente bll_cliente = new BLL_cliente();
        BLLusuario bll_usuario = new BLLusuario();
        DateTime fechaHasta;
        DateTime fechaDesde;
        Dictionary<string, double> lista_de_datos = new Dictionary<string, double>();

        private void reportes_Load(object sender, EventArgs e)
        {
            armar_listview();
            cargar_datos_sistema();
            cargar_reportes();
            mostrar_grafico();
            comboBox1.Text = "DESDE EL INICIO";
        }
        public void mostrar_grafico()
        {

            chart1.Titles.Clear();
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            Title titulo = new Title("Recaudaciones por fechas");
            chart1.Titles.Add(titulo);
            ChartArea area = new ChartArea();
            area.Area3DStyle.Enable3D = true;
            chart1.ChartAreas.Add(area);
            Series serie = new Series("recaudacion");
            serie.ChartType = SeriesChartType.Bar;
            serie.Points.DataBindXY(lista_de_datos.Keys, lista_de_datos.Values);
            chart1.Series.Add(serie);

            cargar_datos_grafico(fechaDesde,fechaHasta);
        }
        public void cargar_datos_grafico(DateTime fecha_inicio,DateTime fecha_final)
        {
            chart1.Series["recaudacion"].Points.Clear();
            foreach (BEcliente cliente in lista_clientes)
            {
                double totalCliente = cliente.pedidos
    .Where(p => p.fecha >= fecha_inicio && p.fecha <= fecha_final)
    .Sum(p => p.total);

                chart1.Series["recaudacion"].IsValueShownAsLabel = true;
                chart1.Series["recaudacion"].Points.AddXY(cliente.nombre_completo, totalCliente);
                chart1.Series["recaudacion"].LabelFormat = "C2";
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        public void armar_listview()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Descripción", 150);
            listView1.Columns.Add("Valor", 120);
        }
        public void cargar_datos_sistema()
        {
            lista_clientes = bll_cliente.leer_todo();
            lista_usuarios = bll_usuario.leer_usuario();
            fechaHasta = DateTime.Today;
            fechaDesde = fechaHasta.AddMonths(-1);
        }
        public double calcular_ventas_por_fecha(DateTime fecha_inicio,DateTime fecha_final)
        {
            double total = 0 ;

            foreach (BEcliente cliente in lista_clientes)
            {
                foreach (BEpedidos pedido in cliente.pedidos)
                {
                    if (pedido.fecha>=fecha_inicio && pedido.fecha<=fecha_final) {
                        foreach (BEpedidos_detalle pedido_detalle in pedido.lista_pedido_detalle)
                        {
                            total += (pedido_detalle.cantidad * pedido_detalle.precio_ropa)*(1 - pedido.descuento/100);
                        } 
                    }
                }
            }
            return total;
        }
        public int calcular_cantidad_de_pedidos(DateTime fecha_inicio, DateTime fecha_final)
        {
            int total = 0;

            foreach (BEcliente cliente in lista_clientes)
            {
                foreach (BEpedidos pedido in cliente.pedidos)
                {
                    if (pedido.fecha >= fecha_inicio && pedido.fecha <= fecha_final && pedido.total>0 )
                    {
                        total++;
                    }
                }
            }
            return total;
        }
        public int calcular_cantidad_de_prendas_vendidas(DateTime fecha_inicio, DateTime fecha_final)
        {
            int total = 0;

            foreach (BEcliente cliente in lista_clientes)
            {
                foreach (BEpedidos pedido in cliente.pedidos)
                {
                    if (pedido.fecha >= fecha_inicio && pedido.fecha <= fecha_final && pedido.total > 0)
                    {
                        total += pedido.cantidad_ropa;
                    }
                }
            }
            return total;
        }
        public void cargar_reportes()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Cantidad de Clientes:", lista_clientes.Count.ToString() })) ;
            listView1.Items.Add(new ListViewItem(new string[] { "Cantidad de Usuarios:", lista_usuarios.Count.ToString() })) ;
            listView1.Items.Add(new ListViewItem(new string[] { "Monto total de ventas del mes:", calcular_ventas_por_fecha(fechaDesde,fechaHasta).ToString() })) ;
            listView1.Items.Add(new ListViewItem(new string[] { "Cantidad total de pedidos hechos en el mes:", calcular_cantidad_de_pedidos(fechaDesde,fechaHasta).ToString() })) ;
            listView1.Items.Add(new ListViewItem(new string[] { "Cantidad total de prendas vendidas en el mes:", calcular_cantidad_de_prendas_vendidas(fechaDesde,fechaHasta).ToString() })) ;
        }

        public void actualizar_idioma()
        {
            lbl_fecha_inicio.Text = BLLtraducciones.traducir(lbl_fecha_inicio.Name);
            lbl_fecha_hasta.Text = BLLtraducciones.traducir(lbl_fecha_hasta.Name);
            boton_Exportar.Text = BLLtraducciones.traducir(boton_Exportar.Name);
            lbl_monto_total.Text = BLLtraducciones.traducir(lbl_monto_total.Name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case ("HOY"): cargar_datos_grafico(DateTime.Today, DateTime.Today);
                    actualizar_fechas_label(DateTime.Today, DateTime.Today);
                    label_monto_total.Text="$"+ calcular_ventas_por_fecha(DateTime.Today, DateTime.Today).ToString();
                    break;
                case ("ULTIMA SEMANA"): cargar_datos_grafico(DateTime.Today.AddDays(-7), DateTime.Today); 
                    actualizar_fechas_label(DateTime.Today.AddDays(-7), DateTime.Today);
                    label_monto_total.Text ="$"+ calcular_ventas_por_fecha(DateTime.Today.AddDays(-7), DateTime.Today).ToString();
                    break;
                case ("ULTIMO MES"): cargar_datos_grafico(DateTime.Today.AddMonths(-1), DateTime.Today);
                    actualizar_fechas_label(DateTime.Today.AddMonths(-1), DateTime.Today);
                    label_monto_total.Text= "$"+ calcular_ventas_por_fecha(DateTime.Today.AddMonths(-1), DateTime.Today).ToString();
                    break;
                case ("ULTIMO AÑO"):
                    cargar_datos_grafico(DateTime.Today.AddYears(-1), DateTime.Today);
                    actualizar_fechas_label(DateTime.Today.AddYears(-1), DateTime.Today);
                    label_monto_total.Text="$"+ calcular_ventas_por_fecha(DateTime.Today.AddYears(-1), DateTime.Today).ToString();
                    break;
                case ("DESDE EL INICIO"): cargar_datos_grafico(Convert.ToDateTime("01 / 01 / 2025"), DateTime.Today);
                    actualizar_fechas_label(Convert.ToDateTime("01 / 01 / 2025"), DateTime.Today);
                    label_monto_total.Text="$"+ calcular_ventas_por_fecha(Convert.ToDateTime("01 / 01 / 2025"), DateTime.Today).ToString();
                    break;
                default: break; 
            }
        }
        public void actualizar_fechas_label(DateTime fecha_i, DateTime fecha_f)
        {
            label_Fecha_inicio.Text = fecha_i.ToString("dd/MM/yyyy");
            label_fecha_final.Text = fecha_f.ToString("dd/MM/yyyy") ;
        }
        void cargar_pdf(){
        string file = conseguir_ruta_nueva() ;
            CrearPdfConReportes(lista_clientes, file);
        }

     void CrearPdfConReportes(List<BEcliente> lista, string filePath)
        {
        Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
        PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.OpenOrCreate));
        doc.Open();

        // Título
        Paragraph titulo = new Paragraph("Reporte del sistema", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
        titulo.Alignment = Element.ALIGN_CENTER;
        doc.Add(titulo);
        doc.Add(Chunk.NEWLINE);

        // Tabla
        PdfPTable tabla = new PdfPTable(2);
        tabla.WidthPercentage = 80;
        tabla.SetWidths(new float[] { 2,1});

        // Header
        tabla.AddCell("Descripción");
        tabla.AddCell("Valor");

        // Filas
            tabla.AddCell("Cantidad de Clientes:");
            tabla.AddCell(lista_clientes.Count.ToString()); 
            tabla.AddCell("Cantidad de Usuarios:");
            tabla.AddCell(lista_usuarios.Count.ToString());
            tabla.AddCell("Monto total de ventas del mes:");
            tabla.AddCell(calcular_ventas_por_fecha(fechaDesde, fechaHasta).ToString());
            tabla.AddCell("Monto total de ventas de la semana:");
            tabla.AddCell(calcular_ventas_por_fecha(DateTime.Today.AddDays(-7), DateTime.Today).ToString());
            tabla.AddCell("Monto total de ventas del dia:");
            tabla.AddCell(calcular_ventas_por_fecha(DateTime.Today, DateTime.Today).ToString());
            tabla.AddCell("Cantidad total de pedidos hechos en el mes:");
            tabla.AddCell(calcular_cantidad_de_pedidos(fechaDesde, fechaHasta).ToString());
            tabla.AddCell("Cantidad total de prendas vendidas en el mes:");
            tabla.AddCell(calcular_cantidad_de_prendas_vendidas(fechaDesde, fechaHasta).ToString());
            doc.Add(tabla);

            Paragraph texto_final = new Paragraph("Fin.", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
            titulo.Alignment = Element.ALIGN_LEFT;
            doc.Add(texto_final);
            doc.Close();
    }

        private void boton_Exportar_Click(object sender, EventArgs e)
        {
            cargar_pdf();
            MessageBox.Show("El archivo de pdf se creo correctamente", "Mensaje de exito", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public string conseguir_ruta_nueva()
        {
            int contador = 1;
            string ruta = @"C:\Users\user\Desktop\universidad\introducion a la programacion\3 año\wwwww\trabajo practico\reportes"+contador+".pdf";
            while (File.Exists(ruta))
            {
                contador++;
                ruta = @"C:\Users\user\Desktop\universidad\introducion a la programacion\3 año\wwwww\trabajo practico\reportes" +contador+ ".pdf";
            }

            return ruta;
        }
    }
}
