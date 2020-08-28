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
        //int Id;
        string conexion = "Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql";
       /* SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt;
        string Consulta;
        SqlCommand cmd;*/
        public override Boolean Guardar() 
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
                    MessageBox.Show(error.Message);
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
            SqlDataAdapter dc = new SqlDataAdapter("SpConsultaprogramas", cn);
            

            DataTable TC = new DataTable();

            dc.Fill(TC);

            dataGridRegistro.DataSource = TC;

            dataGridRegistro.Visible = true;
        }
     

        private void dataGridRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txtCodigo.Text = dataGridRegistro.CurrentRow.Cells[0].Value.ToString();
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
            */
            txtCodPrograma.Text = dataGridRegistro.CurrentRow.Cells[0].Value.ToString();
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
            GridviewbuscaAlumnos.Visible = false;
            dataGridRegistro.Visible = false;
            txtBuscaAlumno.Clear();
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
                da.SelectCommand.Parameters.AddWithValue("@letra", txtBuscaAlumno.Text);
                da.Fill(dt);
                GridviewbuscaAlumnos.DataSource = dt;
                //dataGridRegistro.DataSource = dt;
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
       private void txtBuscaAlumno_TextChanged(object sender, EventArgs e)
        {
            GridviewbuscaAlumnos.DataSource = null;
            Mostrar();
            GridviewbuscaAlumnos.Visible = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridviewbuscaAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = GridviewbuscaAlumnos.CurrentRow.Cells[0].Value.ToString();
            txtDNI.Text = GridviewbuscaAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = GridviewbuscaAlumnos.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = GridviewbuscaAlumnos.CurrentRow.Cells[3].Value.ToString();
            cboSexo.Text = GridviewbuscaAlumnos.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = GridviewbuscaAlumnos.CurrentRow.Cells[5].Value.ToString();
            txtEMail.Text = GridviewbuscaAlumnos.CurrentRow.Cells[6].Value.ToString();
            txtDirecc.Text = GridviewbuscaAlumnos.CurrentRow.Cells[7].Value.ToString();
            DatefechaNac.Text = GridviewbuscaAlumnos.CurrentRow.Cells[8].Value.ToString();
            txtPais.Text = GridviewbuscaAlumnos.CurrentRow.Cells[9].Value.ToString();
            txtDepto.Text = GridviewbuscaAlumnos.CurrentRow.Cells[10].Value.ToString();
            txtDistrito.Text = GridviewbuscaAlumnos.CurrentRow.Cells[11].Value.ToString();
            txtCodPrograma.Text = GridviewbuscaAlumnos.CurrentRow.Cells[12].Value.ToString();
            MessageBox.Show("Data Cargada Correctamente");
            dataGridRegistro.Show();
        }
    }
}
