using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactuxD
{
    public partial class FormMantenimiento : Form
    {
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public virtual void Eliminar()
        {

        }
        public virtual void Nuevo()
        {

        }
        public virtual void Consultar()
        {

        }
        public virtual Boolean Guardar()
        {
            return false;
        }

        public virtual void Exportar()
        {

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }
    }
}
