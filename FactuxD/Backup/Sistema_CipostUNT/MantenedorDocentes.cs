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
    public partial class MantenedorDocentes : FormMantenimiento
    {
        public MantenedorDocentes()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format(" exec SpRegistrarDocente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", txtCodDocente.Text.Trim(),
                    txtDni.Text.Trim(), txtApellidos.Text.Trim(), txtNombres.Text.Trim(), cboGenero.Text.Trim(), txtCelular.Text.Trim(),
                    txtEmail.Text.Trim(), txtDireccion.Text.Trim(), cboPais.Text.Trim(), cboDistrito.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se a registrado");

            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrió un error"+error.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("exec SpActualizaDocente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", txtCodDocente.Text.Trim(),
                    txtDni.Text.Trim(), txtApellidos.Text.Trim(), txtNombres.Text.Trim(), cboGenero.Text.Trim(), txtCelular.Text.Trim(),
                    txtEmail.Text.Trim(), txtDireccion.Text.Trim(), cboPais.Text.Trim(), cboDistrito.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se a Actualizado");

            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrió un error" + error.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("exec SpActualizaDocente '{0}'", txtCodDocente.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se a Eliminado de la DBA");

            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrió un error" + error.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cboDistrito.SelectedIndex = 0;
            cboGenero.SelectedIndex = 0;
            cboPais.SelectedIndex = 0;
            txtCodDocente.Clear();
            txtDni.Clear();
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
    
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
                SqlDataAdapter dc = new SqlDataAdapter(" exec SpConsultaDocentres", cn);


                DataTable TC = new DataTable();

                dc.Fill(TC);

                DatagriviwDocentes.DataSource = TC;

            
        }

        private void MantenedorDocentes_Load(object sender, EventArgs e)
        {

        }
    }
}
