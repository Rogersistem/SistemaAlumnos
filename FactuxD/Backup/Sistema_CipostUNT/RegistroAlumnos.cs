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
    public partial class RegistroAlumnos : FormMantenimiento
    {
        public RegistroAlumnos()
        {
            InitializeComponent();
          
        }

        public override bool Guardar() 
        {

                try
                {
                    string cmd = string.Format("Exec spRegistarAlmunos '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'",
                 txtCodigo.Text.Trim(), txtDNI.Text.Trim(), txtApellidos.Text.Trim(), txtNombre.Text.Trim(),
                 cboSexo.Text.Trim(), txtCelular.Text.Trim(), txtEMail.Text.Trim(), txtDirecc.Text.Trim(), DatefechaNac.Text, txtPais.Text.Trim(),
                      txtDepto.Text.Trim(), txtDistrito.Text.Trim(), txtCodPrograma.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se a guardado correctamente");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("a ocurrido un error" + error.Message);
                    return false;
              } 
           }
            
           
        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dc = new SqlDataAdapter("select * from Programa", cn);


            DataTable TC = new DataTable();

            dc.Fill(TC);

            dataGridRegistro.DataSource = TC;
        }
        public void ExportarDatos(DataGridView LISAlumnos)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in dataGridRegistro.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in dataGridRegistro.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in dataGridRegistro.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;

        }


        private void dataGridRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridRegistro.CurrentRow.Cells[0].Value.ToString();
            txtDNI.Text = dataGridRegistro.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dataGridRegistro.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = dataGridRegistro.CurrentRow.Cells[3].Value.ToString();
            txtCelular.Text = dataGridRegistro.CurrentRow.Cells[5].Value.ToString();
            txtEMail.Text = dataGridRegistro.CurrentRow.Cells[6].Value.ToString();
            txtDirecc.Text = dataGridRegistro.CurrentRow.Cells[7].Value.ToString();
            DatefechaNac.Text = dataGridRegistro.CurrentRow.Cells[8].Value.ToString();
            txtPais.Text = dataGridRegistro.CurrentRow.Cells[9].Value.ToString();
            txtDepto.Text = dataGridRegistro.CurrentRow.Cells[10].Value.ToString();
            txtDistrito.Text = dataGridRegistro.CurrentRow.Cells[11].Value.ToString();
            txtCodPrograma.Text =dataGridRegistro.CurrentRow.Cells[12].Value.ToString();
            MessageBox.Show("Data Cargada Correctamente");
            dataGridRegistro.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCodigo.Focus();
            txtDNI.Clear();
            txtApellidos.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            txtEMail.Clear();
            txtDirecc.Clear();
            txtPais.Clear();
            txtDepto.Clear();
            txtDistrito.Clear();
            txtCodPrograma.Clear();
            dataGridRegistro.DataSource = null;
            cboSexo.SelectedIndex = 0;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(dataGridRegistro);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCodigo.Focus();
            };
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDNI.Focus();
            };
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidos.Focus();
            };
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombre.Focus();
            };
        }
    }
}
