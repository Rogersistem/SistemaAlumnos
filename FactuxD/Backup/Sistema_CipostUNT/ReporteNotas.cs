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
    public partial class ReporteNotas : Form
    {
        public ReporteNotas()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        private void checkConsultaporNotas_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dc = new SqlDataAdapter("exec SPConsultarNotasAlumno", cn);

            DataTable TC = new DataTable();
            dc.Fill(TC);
            if (checkConsultaporNotas.Checked == true)
                DataGrivNOtas.DataSource = TC;
            else
                DataGrivNOtas.DataSource = false;
        }
      
        /// acción para exportar a excel
     
        private void btnExportar_Click(object sender, EventArgs e)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in DataGrivNOtas.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in DataGrivNOtas.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in DataGrivNOtas.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir?", "Aviso", MessageBoxButtons.YesNo);
            this.Close();
        }
    }
}
