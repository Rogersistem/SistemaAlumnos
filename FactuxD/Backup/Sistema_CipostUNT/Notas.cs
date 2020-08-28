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
    public partial class Notas : FormMantenimiento
    {
        public Notas()
        {
            InitializeComponent();
        }
        // codigo para llenear el datagragriview
        
        public DataSet LlenarData(string tabla)
        {
            DataSet Ds;
            string cmd = string.Format("exec SpConsultNotaporDniAlum " + tabla);
            Ds = Utilidades.Ejecutar(cmd);

            return Ds;
           
        }
         SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        public override Boolean Guardar()
        {
            try
            {
                string cmd = string.Format(" exec SPregistrarNotas '{0}','{1}','{2}'", txtCodigoAlumno.Text.Trim(),
                    txtCodgoCurso.Text.Trim(), txtNota.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se a registrado correctamente");
                return true;

            }
            catch(Exception error)
            {
                MessageBox.Show("a ocurrido un error...:"+ error.Message);
                return false;
            }
        }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format(" exec SPEliminar_Notas '{0}'", txtCodigoAlumno.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Desea Eliminar el Registro?", "Advertence", MessageBoxButtons.YesNo);
                //this.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("a ocurrido un error...:" + error.Message);

            }
        }
      
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format(" exec SPActualizarNotas '{0}','{1}','{2}'", txtCodigoAlumno.Text.Trim(),
                    txtCodgoCurso.Text.Trim(), txtNota.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se a actualizado correctamente");
                

            }
            catch (Exception error)
            {
                MessageBox.Show("a ocurrido un error...:" + error.Message);
              
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DataGrivNOtas.DataSource = null;
            txtCodigoAlumno.Clear();
            txtCodgoCurso.Clear();
            txtNota.Clear();
            txtCodigoAlumno.Focus();

        }

        private void txtCodigoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCodgoCurso.Focus();
            }
        }

        private void txtCodgoCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNota.Focus();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dc = new SqlDataAdapter("select * from Notas", cn);


            DataTable TC = new DataTable();

            dc.Fill(TC);

            DataGrivNOtas.DataSource = TC;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dc = new SqlDataAdapter("exec SPConsultarNotasAlumno", cn);

            DataTable TC = new DataTable();
            dc.Fill(TC);
            if (checkConsultaporNotas.Checked == true)
                DataGrivNOtas.DataSource = TC;
            else
                DataGrivNOtas.DataSource = false;
        }
        //agregando un metodo para exportar 
        public void ExportarDatos(DataGridView DataGrivNOtas)
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
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(DataGrivNOtas);
        }

        private void DataGrivNOtas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoAlumno.Text = DataGrivNOtas.CurrentRow.Cells[0].Value.ToString();
            txtCodgoCurso.Text = DataGrivNOtas.CurrentRow.Cells[1].Value.ToString();
            txtNota.Text = DataGrivNOtas.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {

            SqlDataAdapter dc = new SqlDataAdapter("exec SpConsultNotaporDniAlum ", cn);

            
            DataTable TC = new DataTable();

            dc.Fill(TC);
         

            DataGrivNOtas.DataSource = TC;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DataGrivNOtas.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            DataGrivNOtas.DataSource = LlenarData("Notas").Tables[0];
        }
    }
}
