using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibreri;

namespace FactuxD
{
    public partial class RegistroUsuarios : FormMantenimiento
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            try
            {
                string cmd = string.Format("exec spRegistrarUsuarios '{0}','{1}','{2}','{3}','{4}','{5}'",txtCodigoUsuario.Text.Trim(),
                    txtNombre.Text.Trim(),txtCuenta.Text.Trim(),txtContraseña.Text.Trim(),txtTipoUsuario.Text.Trim(),
                    txtFoto.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Usuario Registrado");
                
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("A ocurrido un error"+ error.Message);
                return false;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaLogin log = new VentanaLogin();
            log.Show();
            this.Hide();
        }
    }
}
