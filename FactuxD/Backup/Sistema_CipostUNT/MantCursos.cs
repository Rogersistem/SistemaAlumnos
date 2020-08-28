﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using MyLibreri;

namespace FactuxD
{
    public partial class MantCursos : FormMantenimiento
    {
        public MantCursos()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format(" exec SpRegistrarCurso  '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                    txtCodigoCurso.Text.Trim(), txtNomCurso.Text.Trim(), txtCodPrograma.Text.Trim(), txtCodDocente.Text.Trim(),
                    txtAño.Text.Trim(), txtAula.Text.Trim(),txtHoraIncicio.Text.Trim(),txtHoraTermino.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                MessageBox.Show("se a guardado correctamente");
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            SqlDataAdapter dc = new SqlDataAdapter("  exec SpMostrarCursos", cn);

            DataTable TC = new DataTable();

            dc.Fill(TC);

            dgCursos.DataSource = TC;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("exec SpEliminarCurso '{0}'", txtCodigoCurso.Text.Trim());
            Utilidades.Ejecutar(cmd);
            MessageBox.Show("se a liminado");
            dgCursos.DataSource = null;

            txtCodigoCurso.Clear();
            txtNomCurso.Clear();
            txtCodPrograma.Clear();
            txtCodDocente.Clear();
            txtAño.Clear();
            txtAula.Clear();
            txtHoraIncicio.Clear();
            txtHoraTermino.Clear();

        }

        private void dgCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoCurso.Text = dgCursos.CurrentRow.Cells[0].Value.ToString();
            txtNomCurso.Text = dgCursos.CurrentRow.Cells[1].Value.ToString();
            txtCodPrograma.Text = dgCursos.CurrentRow.Cells[2].Value.ToString();
            txtCodDocente.Text = dgCursos.CurrentRow.Cells[3].Value.ToString();
            txtAño.Text = dgCursos.CurrentRow.Cells[4].Value.ToString();
            txtAula.Text = dgCursos.CurrentRow.Cells[5].Value.ToString();
            txtHoraIncicio.Text = dgCursos.CurrentRow.Cells[6].Value.ToString();
            txtHoraTermino.Text = dgCursos.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgCursos.DataSource = null;

            txtCodigoCurso.Clear();
            txtNomCurso.Clear();
            txtCodPrograma.Clear();
            txtCodDocente.Clear();
            txtAño.Clear();
            txtAula.Clear();
            txtHoraIncicio.Clear();
            txtHoraTermino.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("exec SpActualizaCurso '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                     txtCodigoCurso.Text.Trim(), txtNomCurso.Text.Trim(), txtCodPrograma.Text.Trim(), txtCodDocente.Text.Trim(),
                     txtAño.Text.Trim(), txtAula.Text.Trim(), txtHoraIncicio.Text.Trim(), txtHoraTermino.Text.Trim());
            Utilidades.Ejecutar(cmd);
            MessageBox.Show("se a Actualizado");
        }
    }
}
