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
    public partial class Interfaz_Entrada : Form
    {
        public Interfaz_Entrada()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form UserAdmin = new VentanaAdmin();
            UserAdmin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new VentanaLogin();
            login.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            Form login = new VentanaLogin();
            login.Show();
            this.Hide();

        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
           /* muestra  la fecha estatica
           // lblHora.Text = DateTime.Now.ToLongDateString();
             lblHora.Text = DateTime.Now.ToShortDateString();
              lblHora.Text = DateTime.Now.ToString("h:mm:ss");
         */
         //lblHora.Text = DateTime.Now.ToShortTimeString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();

            //lblFecha.Text = DateTime.Now.ToLongDateString();



        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
