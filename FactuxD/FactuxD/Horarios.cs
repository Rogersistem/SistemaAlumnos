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
    public partial class Horarios : FormMantenimiento
    {
        public Horarios()
        {
            InitializeComponent();
        }


        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        public override Boolean Guardar()
        {
            try
            {
                string cmd = string.Format("exec SpRegistrarHorarios '{0}','{1}','{2}','{3}'",txtCodHorario.Text.Trim(),
                    txtHoraInicio.Text.Trim(),txtHoraFin.Text.Trim(),cboTurnos.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha registrado");
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("a ocurrido un error"+error.Message);
                return false;
            }
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("exec SpEliminaHorario '{0}'",txtCodHorario.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha eliminado");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("exec SpActualizaHorario '{0}','{1}','{2}','{3}'", txtCodHorario.Text.Trim(),
                       txtHoraInicio.Text.Trim(), txtHoraFin.Text.Trim(), cboTurnos.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("el registro a sido  Actualizó ");
            }
            catch (Exception error)
            {
                MessageBox.Show("no se a podido actualizar"+error.Message);
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            txtCodHorario.Clear();
        }
        public override void Nuevo()
        {
            txtCodHorario.Clear();
            txtHoraFin.Clear();
            txtHoraInicio.Clear();
            cboTurnos.SelectedIndex = 0;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            dataGriviewHorarios.Visible = false;
            txtCodHorario.Focus();
        }
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dc = new SqlDataAdapter("exec SpConsultaHorario", cn);

            DataTable TC = new DataTable();

            dc.Fill(TC);

            dataGriviewHorarios.DataSource = TC;
            dataGriviewHorarios.Visible = true;
        
        }

        private void dataGriviewHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodHorario.Text = dataGriviewHorarios.CurrentRow.Cells[0].Value.ToString();
            txtHoraInicio.Text = dataGriviewHorarios.CurrentRow.Cells[1].Value.ToString();
            txtHoraFin.Text = dataGriviewHorarios.CurrentRow.Cells[2].Value.ToString();
            cboTurnos.Text = dataGriviewHorarios.CurrentRow.Cells[3].Value.ToString();
            dataGriviewHorarios.Visible = false;


        }
    }
}
