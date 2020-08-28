using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;//es para excel
using System.Drawing.Printing;
using MyLibreri;

namespace FactuxD
{
    public partial class Reporte_Pagos : Form
    {
        public Reporte_Pagos()
        {
            InitializeComponent();
        }

       // DataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = "Provider =Microsoft.Jet.OleDb.4.0; Data Source = C:/Users/Lenovo/Desktop/usuarios.xlsx;Extended Properties= \"Excel 8.0;HDR=Yes\"";
            OleDbConnection conector = default(OleDbConnection);
            conector = new OleDbConnection(conexion);
            conector.Open();
            OleDbCommand consulta = default(OleDbCommand);
            consulta = new OleDbCommand("select * from [Hoja1$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = consulta;
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            conector.Close();

            /*
   SqlConnection coneccionReceptora = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
            coneccionReceptora.Open();
            SqlBulkCopy exportar = default(SqlBulkCopy);
            exportar = new SqlBulkCopy(coneccionReceptora);
            exportar.DestinationTableName = "Usuarios";
            exportar.WriteToServer(ds.Tables[0]);

            coneccionReceptora.Close();

            MessageBox.Show("Exportacion exitosa");*/

            // ahora exportamos a la base de datos
            //Data Source=ROGER\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=***********
            SqlConnection coneccionReceptora = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
            coneccionReceptora.Open();

            SqlBulkCopy exportar = default(SqlBulkCopy);
            exportar = new SqlBulkCopy(coneccionReceptora)
            {
                DestinationTableName = "Usuarios"
            };
            exportar.WriteToServer(ds.Tables[0]);

            coneccionReceptora.Close();

            MessageBox.Show("Exportacion exitosa");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*PrintDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;*/
            printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bit = new Bitmap(this.ReportePagos.Width, this.ReportePagos.Height);
            ReportePagos.DrawToBitmap(bit, new Rectangle(0, 0, this.ReportePagos.Width, this.ReportePagos.Height));
            e.Graphics.DrawImage(bit, 10, 10);
        }
        DataTable dtt;
        private void Reporte_Pagos_Load(object sender, EventArgs e)
        {

            string conec = "Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql";
            SqlConnection con = new SqlConnection(conec);
            SqlDataAdapter da = new SqlDataAdapter("exec SpPagosAlumnos", con);
            dtt = new DataTable();
            da.Fill(dtt);
            ReportePagos.DataSource = dtt;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir?", "Aviso", MessageBoxButtons.YesNo);
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir?", "Aviso", MessageBoxButtons.YesNo);
            this.Close();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in ReportePagos.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in ReportePagos.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in ReportePagos.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;

        }
    }
}
