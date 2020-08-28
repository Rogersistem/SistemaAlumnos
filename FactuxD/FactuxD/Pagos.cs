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
    public partial class Pagos : FormMantenimiento
    {
        public Pagos()
        {
            InitializeComponent();
        }

        string conexion = "Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql";
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt;
        string Consulta;
        SqlCommand cmd;


        public override Boolean Guardar()
        {
            try
            {
                string cmd = string.Format(" exec spReistrarPagos '{0}','{1}','{2}'",
                    txtCodigoAlumno.Text.Trim(), txtFechaPago.Text.Trim(), txtMOntoPago.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se a registrado Correctamente");
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("ha ocurrido un error" + error.Message);
                return false;
            }
        }
        public override void Nuevo()
        {
            txtCodigoPago.Clear();
            txtCodigoAlumno.Clear();
            txtMOntoPago.Clear();
            txtBusquedas.Clear();
            dataGrwPagos.Visible = false;
            dataGrwPagos.DataSource = null;
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("exec SpEliminarPago '{0}'", txtCodigoPago.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("ha sido Elimnado");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        public override void Consultar()
        {
            //realizamos el adaptador para mostrar el procediemito almacendo consultar pagos
            SqlDataAdapter dc = new SqlDataAdapter("SpConsultarPagos", cn);


            DataTable TC = new DataTable();

            dc.Fill(TC);

            dataGrwPagos.DataSource = TC;
            //el datagriview se hace visuble Mostrando los datos
            dataGrwPagos.Visible = true;


        }

        //agregando un metodo para exportar 
        public void ExportarDatos(DataGridView dataGrwPagos)
        {
            //crreamos un obejeto de aplicacion de microsoft office
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in dataGrwPagos.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in dataGrwPagos.Rows)
            {
                IndiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in dataGrwPagos.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[IndiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;

        }

        //se hace el llamado al evento del boton
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(dataGrwPagos);
        }

        private void dataGrwPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtCodigoPago.Text = dataGrwPagos.CurrentRow.Cells[0].Value.ToString();
            txtCodigoAlumno.Text = dataGrwPagos.CurrentRow.Cells[0].Value.ToString();
            txtFechaPago.Text = dataGrwPagos.CurrentRow.Cells[1].Value.ToString();
            txtMOntoPago.Text = dataGrwPagos.CurrentRow.Cells[2].Value.ToString();
         
        }

        private void btnActualizarPagos_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("spActualizaPagos '{0}','{1}','{2}'",
                       txtCodigoAlumno.Text.Trim(), txtFechaPago.Text.Trim(), txtMOntoPago.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha Actualizado!");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                MessageBox.Show("cambia la coma por punto en el deciaml del monto","Actualizar Pago",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            //este codigo evitar poder ser editado al dato que sale por el textox
            txtCodigoPago.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtFechaPago.Clear();
        }
        //declaramos un metod privado para realizar Buscquedas por Dni
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
                da = new SqlDataAdapter("SpBuscarpagoporDniAlum", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@dni", txtBusquedas.Text);
                da.Fill(dt);

                dataGrwPagos.DataSource = dt;
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void txtBusquedas_TextChanged(object sender, EventArgs e)
        {
           // hacemos el llamado al metodo Mostrar
            Mostrar();
            dataGrwPagos.Visible = true;
        }
    }

    }
