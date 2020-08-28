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
    public partial class MantAlumnos : FormMantenimiento
    {
        public MantAlumnos()
        {
            InitializeComponent();

        }
        //declaramo variables para la coneecion
       int Id;
        string conexion = "Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql";
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt;
        string Consulta;
       SqlCommand cmd;

        void CargarDatos()
        {
            Consulta = "select * from Alumno where aluCodigo  like '%" + txtCodigo.Text + "%'";
            cnn = new SqlConnection(conexion);
            cnn.Open();
            da = new SqlDataAdapter(Consulta, cnn);
            dt = new DataTable();
            da.Fill(dt);
            LISAlumnos.DataSource = dt;
            cnn.Close();
        }

        void botones(bool op)
        {
            btnCancela.Enabled = !op;
          
            btnNewvo.Enabled = op;
            
        }
        void Casilleros(bool op)
        {
            txtCodigo.Enabled = op;
            txtCodigo.Enabled = op;
            txtDNI.Enabled = op;
            txtApellidos.Enabled = op;
            txtNombre.Enabled = op;
            txtCelular.Enabled = op;
            DatefechaNac.Enabled = op;
            txtEMail.Enabled = op;
            txtDirecc.Enabled = op;
            txtPais.Enabled = op;
            txtDepto.Enabled = op;
            txtDistrito.Enabled = op;
            txtCodPrograma.Enabled = op;
            cboSexo.Enabled = op;

        }
        void Reestablecer()
        {
            txtCodigo.Clear();
            txtCodigo.Focus();
            txtDNI.Clear();
            txtApellidos.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            DatefechaNac.Text = "";
            txtEMail.Clear();
            txtDirecc.Clear();
            txtPais.Clear();
            txtDepto.Clear();
            txtDistrito.Clear();
            txtCodPrograma.Clear();
            cboSexo.SelectedIndex = -1;
            //LISAlumnos.Enabled = false;
        }
        void reconeccion()
        {
            try
            {
            cmd.Connection = cnn;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            CargarDatos();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");

      /*  public void mRegistraAlumnos(string codigo, string dni, string apellido, string nombre, char genero, char celular)
        {

        }*/

        public override bool Guardar()
        {

            try
            {
                string cmd = string.Format("Exec spRegistarAlmunos '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',{12}",
             txtCodigo.Text.Trim(), txtDNI.Text.Trim(), txtApellidos.Text.Trim(), txtNombre.Text.Trim(),
             cboSexo.Text.Trim(),
                   /* rdbFemenino.Checked = true,*/

                txtCelular.Text.Trim(), txtEMail.Text.Trim(), txtDirecc.Text.Trim(), DatefechaNac.Value, txtPais.Text.Trim(),
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
        public override void Nuevo()
        {
            txtCodigo.Clear();
            txtCodigo.Focus();
            txtDNI.Clear();
            txtApellidos.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            DatefechaNac.Text = "";
            txtEMail.Clear();
            txtDirecc.Clear();
            txtPais.Clear();
            txtDepto.Clear();
            txtDistrito.Clear();
            txtCodPrograma.Clear();
            LISAlumnos.Enabled = false;
            cboSexo.SelectedIndex = 0;
            txtBusquedas.Clear();
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("Exec spEliminarAlumno '{0}'", txtCodigo.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se a eliminado");
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

            }
            catch (Exception error)
            {
                MessageBox.Show("a ocurrido un error" + error.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            SqlDataAdapter dc = new SqlDataAdapter("SpConsultAlumnos", cn);


            DataTable TC = new DataTable();

            dc.Fill(TC);

            LISAlumnos.DataSource = TC;
            LISAlumnos.Visible = true;


        }

        //agregando un metodo para exportar 
        public void ExportarDatos(DataGridView LISAlumnos)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in LISAlumnos.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in LISAlumnos.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in LISAlumnos.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;

        }

        private void LISAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = LISAlumnos.CurrentRow.Cells[0].Value.ToString();
            txtDNI.Text = LISAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = LISAlumnos.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = LISAlumnos.CurrentRow.Cells[3].Value.ToString();
            cboSexo.Text = LISAlumnos.CurrentRow.Cells[4].Value.ToString();
            /*if (LISAlumnos.CurrentRow.Cells[4].Value.ToString() == "M")
                rdbMasculino.Checked = true;
            else
                rdbFemenino.Checked = true;*/
            txtCelular.Text = LISAlumnos.CurrentRow.Cells[5].Value.ToString();
            txtEMail.Text = LISAlumnos.CurrentRow.Cells[6].Value.ToString();
            txtDirecc.Text = LISAlumnos.CurrentRow.Cells[7].Value.ToString();
            DatefechaNac.Text = LISAlumnos.CurrentRow.Cells[8].Value.ToString();
            txtPais.Text = LISAlumnos.CurrentRow.Cells[9].Value.ToString();
            txtDepto.Text = LISAlumnos.CurrentRow.Cells[10].Value.ToString();
            txtDistrito.Text = LISAlumnos.CurrentRow.Cells[11].Value.ToString();
            txtCodPrograma.Text = LISAlumnos.CurrentRow.Cells[12].Value.ToString();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(LISAlumnos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void RegistroAlumnos_Load(object sender, EventArgs e)
        {

            CargarDatos();
            botones(true);
            Casilleros(false);
            /*//hacemos el llamado al metodo MostrarAlumnos al evento load
            MostrarAlumnos(); */

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                string cmd = string.Format("Exec spActualizarAlmuno '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',{12}",
             txtCodigo.Text.Trim(), txtDNI.Text.Trim(), txtApellidos.Text.Trim(), txtNombre.Text.Trim(),
             cboSexo.Text.Trim(), txtCelular.Text.Trim(), txtEMail.Text.Trim(), txtDirecc.Text.Trim(), DatefechaNac.Text, txtPais.Text.Trim(),
                  txtDepto.Text.Trim(), txtDistrito.Text.Trim(), txtCodPrograma.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se a Actualizado");

            }
            catch (Exception error)
            {
                MessageBox.Show("a ocurrido un error" + error.Message);

            }
        }

        private void LISAlumnos_DoubleClick(object sender, EventArgs e)
        {
            LISAlumnos.CurrentRow.Selected = true;
            txtCodigo.Text = LISAlumnos.CurrentRow.Cells[0].Value.ToString();
            txtDNI.Text = LISAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = LISAlumnos.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = LISAlumnos.CurrentRow.Cells[3].Value.ToString();
            cboSexo.Text = LISAlumnos.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = LISAlumnos.CurrentRow.Cells[5].Value.ToString();
            txtEMail.Text = LISAlumnos.CurrentRow.Cells[6].Value.ToString();
            txtDirecc.Text = LISAlumnos.CurrentRow.Cells[7].Value.ToString();
            DatefechaNac.Value = Convert.ToDateTime(LISAlumnos.CurrentRow.Cells[8].Value);
            txtPais.Text = LISAlumnos.CurrentRow.Cells[9].Value.ToString();
            txtDepto.Text = LISAlumnos.CurrentRow.Cells[10].Value.ToString();
            txtDistrito.Text = LISAlumnos.CurrentRow.Cells[11].Value.ToString();
            txtCodPrograma.Text = LISAlumnos.CurrentRow.Cells[12].Value.ToString();


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnNewvo_Click(object sender, EventArgs e)
        {
            botones(false);
            Casilleros(true);
            LISAlumnos.DataSource = null;
            LISAlumnos.Visible = false;
            txtBusquedas.Clear();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Casilleros(false);
            botones(true);
            Reestablecer();
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
         
        }
        //declaramos un metod privado para realizar Buscquedas
        private void Mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion;
                con.Open();
                //SqlCommand cmd = new SqlCommand();
                da = new SqlDataAdapter("SpBuscarAlporApelliyDni", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra",txtBusquedas.Text);
                da.Fill(dt);

                LISAlumnos.DataSource = dt;
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void txtBusquedas_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
            LISAlumnos.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LISAlumnos.DataSource = null;
        }
    }
  }

