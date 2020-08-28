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

namespace FactuxD
{
    public partial class ReporteMatricula : Form
    {
        public ReporteMatricula()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dc = new SqlDataAdapter("exec SPConsultarMatricula", cn);

            DataTable TC = new DataTable();
            dc.Fill(TC);
         
                ReporMatricula.DataSource = TC;
           
               
        }

        private void btnExporta_Click(object sender, EventArgs e)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in ReporMatricula.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in ReporMatricula.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in ReporMatricula.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir?", "Aviso", MessageBoxButtons.YesNo);
            this.Close();

        }
    }
}
