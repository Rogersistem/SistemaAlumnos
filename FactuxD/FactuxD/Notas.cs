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
       
        string conexion = "Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql";
        
        int Id;
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt;
        string Consulta;
        SqlCommand cmd;
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
                string cmd = string.Format(" exec SpRegistarNotas '{0}','{1}','{2}','{3}','{4}','{5}','{6}'",
                  txtCodigoAlumno.Text.Trim(),txtCodgoCurso.Text.Trim(), txtNota1.Text.Trim(),
                  txtNota2.Text.Trim(),txtNota3.Text.Trim(),txtNota4.Text.Trim(),txtNota5.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha registrado");
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
                string cmd = string.Format("exec SpEliminaNotas '{0}'", txtCodgoCurso.Text.Trim());
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
            Eliminar();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format(" exec SpActualizaNotas '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                     txtCodNotas.Text.Trim(), txtCodigoAlumno.Text.Trim(),
                    txtCodgoCurso.Text.Trim(), txtNota1.Text.Trim(), txtNota2.Text.Trim(), txtNota3.Text.Trim(),
                    txtNota4.Text.Trim(), txtNota5.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha actualizado");
                

            }
            catch (Exception error)
            {
                MessageBox.Show("a ocurrido un error...:" + error.Message);
                MessageBox.Show("el separador decimal de cada Nota debe ser un Punto","Actualiza Notas",MessageBoxButtons.OK,MessageBoxIcon.Information);
              
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBuscaporCodigAlu.Clear();
            txtCodigoAlumno.Clear();
            txtCodgoCurso.Clear();
            txtNota1.Clear();
            txtCodigoAlumno.Focus();
            ConsultaNotas.DataSource = null;
            txtDNI.Clear();
            ConsultaNotas.Visible = false;
            DataGrivNOtas.Visible =false;

            PanelRegistroNotas.Visible = false;
            groupBoxRegistNotas.Visible = false;

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
                txtNota1.Focus();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dc = new SqlDataAdapter("SpPromedioNotas", cn);


            DataTable TC = new DataTable();

            dc.Fill(TC);

            ConsultaNotas.DataSource = TC;

            ConsultaNotas.Visible = true;
            DataGrivNOtas.Visible = false;
            //se habilita el boton prar exportar al excel
            btnExportar.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DataGrivNOtas.Visible = true;
            SqlDataAdapter dc = new SqlDataAdapter("exec SpListaEvaluacion", cn);

            DataTable TC = new DataTable();
            dc.Fill(TC);
            if (checkConsultaporNotas.Checked == true)
                DataGrivNOtas.DataSource = TC;
            else
                DataGrivNOtas.Visible = false;

            btnExportar.Enabled = false;

            //ConsultaNotas.Visible = true;

        }
        //agregando un metodo para exportar 
        public void ExportarDatos(DataGridView DataGrivNOtas)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in ConsultaNotas.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in ConsultaNotas.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in ConsultaNotas.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;

        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(ConsultaNotas);
        }

        private void DataGrivNOtas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoAlumno.Text = DataGrivNOtas.CurrentRow.Cells[0].Value.ToString();
            txtCodgoCurso.Text = DataGrivNOtas.CurrentRow.Cells[1].Value.ToString();
            txtNota1.Text = DataGrivNOtas.CurrentRow.Cells[2].Value.ToString();
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
        //metodo privado
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
                da = new SqlDataAdapter("SpConsultNotaporDniAlum", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Dni", txtDNI.Text);
                da.Fill(dt);
                ConsultaNotas.DataSource = dt;
              
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            ConsultaNotas.Visible = true;
            Mostrar();
            DataGrivNOtas.Visible = false;
        }
        private void MostraralumCodigo()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
           
                con.ConnectionString = conexion;
                con.Open();
                //SqlCommand cmd = new SqlCommand();
                da = new SqlDataAdapter("SPmostrarNotasporId", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id", txtBuscaporCodigAlu.Text);
                da.Fill(dt);
                ConsultaNotas.DataSource = dt;

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void txtBuscaporCodigAlu_TextChanged(object sender, EventArgs e)
        {  
            MostraralumCodigo();
            ConsultaNotas.Visible = true;
            DataGrivNOtas.Visible = false;
        }

        private void btnRegistroNotas_Click(object sender, EventArgs e)
        {
            PanelRegistroNotas.Visible = true;
            groupBoxRegistNotas.Visible = true;
            DataGrivNOtas.Visible = false;
        }

        private void btnConsultaNotas_Click(object sender, EventArgs e)
        {

            SqlDataAdapter dc = new SqlDataAdapter("SpConsultaNotas", cn);


            DataTable TC = new DataTable();

            dc.Fill(TC);

            ConsultaNotas.DataSource = TC;
            ConsultaNotas.Visible = true;
            PanelRegistroNotas.Visible = false;
        }

        private void ConsultaNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodNotas.Text = ConsultaNotas.CurrentRow.Cells[0].Value.ToString();
            txtCodigoAlumno.Text = ConsultaNotas.CurrentRow.Cells[1].Value.ToString();
            txtCodgoCurso.Text = ConsultaNotas.CurrentRow.Cells[2].Value.ToString();
            txtNota1.Text = ConsultaNotas.CurrentRow.Cells[3].Value.ToString();
            txtNota2.Text = ConsultaNotas.CurrentRow.Cells[4].Value.ToString();
            txtNota3.Text = ConsultaNotas.CurrentRow.Cells[5].Value.ToString();
            txtNota4.Text = ConsultaNotas.CurrentRow.Cells[6].Value.ToString();
            txtNota5.Text = ConsultaNotas.CurrentRow.Cells[7].Value.ToString();
            PanelRegistroNotas.Visible = true;
            ConsultaNotas.Visible = false;

        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            PanelRegistroNotas.Visible = false;
        }
    }
}
