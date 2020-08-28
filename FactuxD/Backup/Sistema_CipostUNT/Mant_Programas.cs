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

namespace FactuxD
{
    public partial class Mant_Programas : Form
    {
        
        void MostrarPrograma()
        {
            SqlDataAdapter objectAdaptador = new SqlDataAdapter("select * from Programa", objeconexion);

            objectAdaptador.Fill(coleccion);
            DataColumn[] claveprimaria = new DataColumn[1];
            claveprimaria[0] = coleccion.Tables[0].Columns["codPrograma"];
            coleccion.Tables[0].PrimaryKey=claveprimaria;


            dataGrePrograma.DataSource = coleccion.Tables[0];
            dataGrePrograma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
        void LimpiarDatos()
        {
            txtCodigoPrograma.Clear();
            txtDescripcion.Clear();
            txtCostoPrograma.Clear();
        }


        SqlConnection objeconexion = new SqlConnection(
            ConfigurationManager.ConnectionStrings["FactuxD"].ConnectionString);
        //declaramos el dataset
        DataSet coleccion = new DataSet();
        public Mant_Programas()
        {
            InitializeComponent();
        }

        private void Programas_Load(object sender, EventArgs e)
        {
            MostrarPrograma();
        }

        private void dataGrePrograma_DoubleClick(object sender, EventArgs e)
        {
            dataGrePrograma.CurrentRow.Selected = true;
            txtCodigoPrograma.Text = dataGrePrograma.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dataGrePrograma.CurrentRow.Cells[1].Value.ToString();
            txtCostoPrograma.Text = dataGrePrograma.CurrentRow.Cells[2].Value.ToString();
            txtCodigoPrograma.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            dataGrePrograma.Enabled = false;
            txtCodigoPrograma.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            dataGrePrograma.Enabled = false;
            txtCodigoPrograma.Enabled = true;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //busca el ID Ingresado
                DataRow registro = coleccion.Tables[0].Rows.Find(txtCodigoPrograma.Text);
                //si no existen se agregan los datos
                if (registro == null)
                {
                    registro = coleccion.Tables[0].NewRow();
                    registro[0]= txtCodigoPrograma.Text;
                    registro[1] = txtDescripcion.Text;
                    registro[2] = Convert.ToDecimal(string.Format("{0:0.00}",
                        Convert.ToDecimal(txtCostoPrograma.Text))).ToString();
                    coleccion.Tables[0].Rows.Add(registro);
                    MessageBox.Show("Programa Registrado....");
                    LimpiarDatos();
                    dataGrePrograma.Enabled = true;
                }
                //si ya existe mostrará un mensaje
            }
            catch (Exception ex)
            {
                MessageBox.Show(  ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] registro;
                string condicion = "codPrograma='" + txtCodigoPrograma.Text + "'";
                //seleccionamos el registro a modificar
                registro = coleccion.Tables[0].Select(condicion);
                registro[0][0] = txtCodigoPrograma.Text;
                registro[0][1] = txtDescripcion.Text;
                registro[0][2] = Convert.ToDecimal(string.Format("{0:0.00}",
                Convert.ToDecimal(txtCostoPrograma.Text))).ToString();
                MessageBox.Show("Programa modificado...");
                LimpiarDatos();
                txtCodigoPrograma.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnElimnar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rpta = MessageBox.Show("¿Seguro de elimnar el registro?", "Cipost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rpta==DialogResult.Yes)
                {
                    DataRow[] registro;
                    string condicion = "codPrograma='" + txtCodigoPrograma.Text + "'";
                    registro = coleccion.Tables[0].Select(condicion);
                    registro[0].Delete();
                    MessageBox.Show("Programa eliminado...");
                    LimpiarDatos();
                    txtCodigoPrograma.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter objAdaptador = new SqlDataAdapter("select * from programa", objeconexion);
                SqlCommandBuilder sql=new SqlCommandBuilder(objAdaptador);
                objAdaptador.Update(coleccion.Tables[0]);
                MessageBox.Show("Base de datos actualizada...");
                coleccion.Tables[0].AcceptChanges();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                coleccion.Tables[0].RejectChanges();
            }
        }

        private void dataGrePrograma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoPrograma.Text = dataGrePrograma.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dataGrePrograma.CurrentRow.Cells[1].Value.ToString();
            txtCostoPrograma.Text = dataGrePrograma.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
