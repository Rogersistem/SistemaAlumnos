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
using MyLibreri;

namespace FactuxD
{
    public partial class ListEvaluacion : Form
    {
        public ListEvaluacion()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;;Password=sql");
        private void btnEvaluacion_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dc = new SqlDataAdapter("SpListaEvaluacion", cn);


                DataTable TC = new DataTable();

                dc.Fill(TC);

                dataGridEvaluacion.DataSource = TC;

                dataGridEvaluacion.Visible = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //agregando un metodo para exportar 
        public void ExportarDatos(DataGridView dataGridEvaluacion)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in dataGridEvaluacion.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in dataGridEvaluacion.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in dataGridEvaluacion.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;

        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            //hacemos el llamado al metodo exportar a excel
            ExportarDatos(dataGridEvaluacion);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridEvaluacion.DataSource = null;
        }
    }
}
