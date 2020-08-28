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
    public partial class ReportAsistencia : Form
    {
        public ReportAsistencia()
        {
            InitializeComponent();
        }
        
        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        //agregando un metodo para exportar 
        public void ExportarDatos(DataGridView DgGridAsistencias)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in DgGridAsistencias.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in DgGridAsistencias.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in DgGridAsistencias.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
           

        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(DgGridAsistencias);
        }

        private void ReportAsistencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBA_CIPOST2019DataSet4.Asistencia' Puede moverla o quitarla según sea necesario.
            this.asistenciaTableAdapter.Fill(this.dBA_CIPOST2019DataSet4.Asistencia);
            // TODO: esta línea de código carga datos en la tabla 'dBA_CIPOST2019DataSet3.Alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.dBA_CIPOST2019DataSet3.Alumno);
            // TODO: esta línea de código carga datos en la tabla 'dBA_CIPOST2019DataSet2.Horario' Puede moverla o quitarla según sea necesario.
            this.horarioTableAdapter.Fill(this.dBA_CIPOST2019DataSet2.Horario);
            // TODO: esta línea de código carga datos en la tabla 'dBA_CIPOST2019DataSet1.Docente' Puede moverla o quitarla según sea necesario.
            this.docenteTableAdapter.Fill(this.dBA_CIPOST2019DataSet1.Docente);
            // TODO: esta línea de código carga datos en la tabla 'dBA_CIPOST2019DataSet.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.dBA_CIPOST2019DataSet.Curso);


            ///desactiba a los controles para evitar que ejecuten una acción
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DgGridAsistencias.Visible = false;
            PanelRegistroAsistencia.Visible = true;
            btnConsultar.Enabled = false;
            btnExportar.Enabled = false;


            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            DgGridAsistencias.Visible = false;
            PanelRegistroAsistencia.Visible = false;
        }

        private void listaAsistencia_Click(object sender, EventArgs e)
        {
            PanelRegistroAsistencia.Visible = false;
            try
            {
                SqlDataAdapter dc = new SqlDataAdapter("SpListaAsistencia", cn);

                DataTable TC = new DataTable();

                dc.Fill(TC);

                DgGridAsistencias.DataSource = TC;

                DgGridAsistencias.Visible = true;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void pictureOcultar_Click(object sender, EventArgs e)
        {
            PanelRegistroAsistencia.Visible = false;
        }

        private void llbConsultaAsistencias_Click(object sender, EventArgs e)
        {
            RegAsistencia.Visible = true;
            try
            {
                SqlDataAdapter dc = new SqlDataAdapter("SpConsultarAsistencias", cn);


                DataTable TC = new DataTable();

                dc.Fill(TC);

                RegAsistencia.DataSource = TC;

               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            RegAsistencia.DataSource = null;
        }

        private void RegAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboCursos.Text = RegAsistencia.CurrentRow.Cells[0].Value.ToString();
            cboCodDocente.Text = RegAsistencia.CurrentRow.Cells[1].Value.ToString();

            cboCodHorario.Text = RegAsistencia.CurrentRow.Cells[2].Value.ToString();
            cboCodAlumno.Text = RegAsistencia.CurrentRow.Cells[3].Value.ToString();
            cboFecha.Text = RegAsistencia.CurrentRow.Cells[4].Value.ToString();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            //oculta los siguintes controles
            PanelRegistroAsistencia.Visible = false;
            // se desactivan los controles 
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            //estos botones se activan luego de cerrar el formulario
            btnConsultar.Enabled = true;
            btnExportar.Enabled = true;
        }

       

      

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgGridAsistencias.Visible = false;
            PanelRegistroAsistencia.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("exec SpRegistraAsistecias '{0}','{1}','{2}','{3}','{4}'", cboCursos.Text.Trim(),
                    cboCodDocente.Text.Trim(), cboCodHorario.Text.Trim(), cboCodAlumno.Text.Trim(), cboFecha.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha registrado");
            }
            catch (Exception error)
            {
                MessageBox.Show("ha ocurrido un error" + error.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("exec SpActualizaAsistencia '{0}','{1}','{2}','{3}','{4}'", cboCursos.Text.Trim(),
                    cboCodDocente.Text.Trim(), cboCodHorario.Text.Trim(), cboCodAlumno.Text.Trim(), cboFecha.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha Actualizado");
            }
            catch (Exception error)
            {
                MessageBox.Show("ha ocurrido un error" + error.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("exec SpEliminaAsistencias '{0}'", cboCursos.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha Eliminado");
            }
            catch (Exception error)
            {
                MessageBox.Show("ha ocurrido un error" + error.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PanelRegistroAsistencia.Visible = false;
            try
            {
                SqlDataAdapter dc = new SqlDataAdapter("SpListaAsistencia", cn);


                DataTable TC = new DataTable();

                dc.Fill(TC);

                DgGridAsistencias.DataSource = TC;

                DgGridAsistencias.Visible = true;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            ExportarDatos(DgGridAsistencias);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DgGridAsistencias.Visible = false;
            PanelRegistroAsistencia.Visible = false;
        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            this.btnRegistrar.BackColor = ColorTranslator.FromHtml("#ECEAD9");
        }

        private void btnActualizar_MouseEnter(object sender, EventArgs e)
        {
            this.btnActualizar.BackColor = ColorTranslator.FromHtml("#ECEAD9");
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            this.btnEliminar.BackColor = ColorTranslator.FromHtml("#ECEAD9");
        }

        private void btnNuevo_MouseEnter(object sender, EventArgs e)
        {
            this.btnNuevo.BackColor = ColorTranslator.FromHtml("#ECEAD9");
        }

        private void btnConsultar_MouseEnter(object sender, EventArgs e)
        {
            this.btnConsultar.BackColor = ColorTranslator.FromHtml("#ECEAD9");
        }

        private void btnExportar_MouseEnter(object sender, EventArgs e)
        {
            this.btnExportar.BackColor = ColorTranslator.FromHtml("#ECEAD9");
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
