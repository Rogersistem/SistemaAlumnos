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

namespace FactuxD
{
    public partial class BackupDba : Form
    {
        public BackupDba()
        {
            InitializeComponent();
        }
        void botones(bool op)
        {
            btnBackup.Enabled = !op;

         

        }
        void Casilleros(bool op)
        {
            btnBackup.Enabled = op;
           
           
        }


        //declaramo la conección 
        // SqlConnection conectar = new SqlConnection("SERVER=MSSQLSERVER16;DATABASE=DBA_CIPOST2019;User ID=sa;Password=sql");
        SqlConnection cn = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
        private void btnBackup_Click(object sender, EventArgs e)
        {
            String copia=(System.DateTime.Today.Day.ToString()+"-"+ System.DateTime.Today.Month.ToString()+"-"+System.DateTime.Today.Year.ToString()+"-"+System.DateTime.Now.Hour.ToString()+"-"+System.DateTime.Now.Minute.ToString()+"-"+System.DateTime.Now.Second.ToString()+ "DBA_CIPOST2019");
            //establecemos el comnado de la consulta
            String Comando = "BACKUP DATABASE [DBA_CIPOST2019] TO  DISK = N'D:\\Backups\\" + copia + "' WITH NOFORMAT, NOINIT,  NAME = N'DBA_CIPOST2019-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            SqlCommand cmd = new SqlCommand(Comando,cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("La copia a sido creada Satisfactoriamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("si desea realizar otra copi de seguridad, cerrar el formulario e intente nuevamente"+error.Message);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }


        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Hbilotar?", "Aviso", MessageBoxButtons.OK);

            btnBackup.Enabled = true;

          

        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnBackup.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
