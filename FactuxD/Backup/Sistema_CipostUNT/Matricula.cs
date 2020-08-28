using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MyLibreri;



namespace FactuxD
{
    public partial class Matricula : Form
    {
        
 
        public Matricula()
        {
            InitializeComponent();
        }
       

        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        public DataSet LLenarGridviw(string Tabla)
        {
            DataSet DS;
            string cmd = string.Format("select * from " + Tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        private void Matricula_Load(object sender, EventArgs e)
        {
           // DatGrivwMatricula.DataSource = LLenarGridviw("Matricula").Tables[0];
            
            
        }
        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format(" exec SpActualizarMatricula '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", txtCodMatricula.Text.Trim(),
                   txtTipoMatricula.Text.Trim(), txtCodAlumno.Text.Trim(), txtCodPrograma.Text.Trim(), txtCodHorario.Text.Trim(),
                   txtPeriodo.Text.Trim(), txtFecha.Text.Trim());
                Utilidades.Ejecutar(cmd);
                //MessageBox.Show("se a Actualizado ");
               // return true;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
               // return false;
            }
            MessageBox.Show("se a Actualizado ");
        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            SqlDataAdapter dc = new SqlDataAdapter(" select * from Matricula", cn);
            DataTable TC = new DataTable();
            dc.Fill(TC);
            if (checConsultarAlumno.Checked == true)
                DatGrivwMatricula.DataSource = TC;
            else
                DatGrivwMatricula.DataSource = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dc = new SqlDataAdapter("select * from Programa", cn);
            DataTable TC = new DataTable();
            dc.Fill(TC);
            if (checConsultarPrograma.Checked == true)
                DatGrivwMatricula.DataSource = TC;
            else
               DatGrivwMatricula.DataSource = false;
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Desea Cerrar?", "Aviso", MessageBoxButtons.YesNo);
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DatGrivwMatricula.DataSource = null;
            txtCodMatricula.Clear();
            txtTipoMatricula.Clear();
            txtCodAlumno.Clear();
            txtCodPrograma.Clear();
            txtCodHorario.Clear();
            txtFecha.Clear();
            txtPeriodo.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
             
                try {
                string cmd = string.Format(" exec spRegistarMatricula '{0}','{1}','{2}','{3}','{4}','{5}','{6}'"
                    , txtCodAlumno.Text.Trim(), txtTipoMatricula.Text.Trim(), txtCodAlumno.Text.Trim(),
                    txtCodPrograma.Text.Trim(), txtCodHorario.Text.Trim(), txtPeriodo.Text.Trim(), txtFecha.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se a guardado correctamente");
                txtCodMatricula.Clear();
                txtTipoMatricula.Clear();
                txtCodAlumno.Clear();
                txtCodPrograma.Clear();
                txtCodHorario.Clear();
                txtPeriodo.Clear();
                txtFecha.Clear();

            }
            catch (Exception error)
            {
                MessageBox.Show("A ocurrido un error"+ error.Message);
            }
            
        }

        //agregando un metodo para exportar 
        public void ExportarDatos(DataGridView DatGrivwMatricula)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in DatGrivwMatricula.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in DatGrivwMatricula.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in DatGrivwMatricula.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;

        }
        private void DatGrivwMatricula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    
            //ubica a vaada lado en la posicion de los texbox
            txtCodMatricula.Text = DatGrivwMatricula.CurrentRow.Cells[0].Value.ToString();
            txtTipoMatricula.Text = DatGrivwMatricula.CurrentRow.Cells[1].Value.ToString();
            txtCodAlumno.Text = DatGrivwMatricula.CurrentRow.Cells[4].Value.ToString();
            txtCodPrograma.Text = DatGrivwMatricula.CurrentRow.Cells[7].Value.ToString();
            txtCodHorario.Text = DatGrivwMatricula.CurrentRow.Cells[9].Value.ToString();

            txtPeriodo.Text = DatGrivwMatricula.CurrentRow.Cells[2].Value.ToString();
            txtFecha.Text = DatGrivwMatricula.CurrentRow.Cells[3].Value.ToString();
            
                
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ExportarDatos(DatGrivwMatricula);
        }

        private void checConsultarCursos_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dc = new SqlDataAdapter(" select * from curso", cn);
            DataTable TC = new DataTable();
            dc.Fill(TC);
            if (checConsultarCursos.Checked == true)
                DatGrivwMatricula.DataSource = TC;
            else
                DatGrivwMatricula.DataSource = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format(" exec SpEliminaMatricula '{0}'", txtCodMatricula.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se a liminado");
                txtCodMatricula.Clear();
                txtTipoMatricula.Clear();
                txtCodAlumno.Clear();
                txtCodPrograma.Clear();
                txtCodHorario.Clear();
                txtPeriodo.Clear();
                txtFecha.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show("a ocurrido un error"+ error.Message);
            }
        }
    }
}
