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
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        //vARIABLES GLOBALES
        public static String Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //recibe la consulta //debuelve los datos de la  fila entera de la tablatabla 
            /*Utilidades.Ejecutar("select * from Cliente where id_clientes = 1; ");*/
           
            {
                try
                {
                    //declaramos variables
                    string CMD = string.Format("select * from Usuarios where cuenta='{0}'and Password='{1}'", txtAccount.Text.Trim(), txtPassword.Text.Trim());
                    //SE GUARDA EN EL DATASET //utilidades es referenciada de Mylibrery
                    DataSet ds = Utilidades.Ejecutar(CMD);

                    Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                    string cuenta = ds.Tables[0].Rows[0]["cuenta"].ToString().Trim();
                    string contra = ds.Tables[0].Rows[0]["Password"].ToString().Trim();

                    if (cuenta == txtAccount.Text.Trim() && contra == txtPassword.Text.Trim())
                    {
                        MessageBox.Show("Se a iniciado sesion");
                        if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_Admin"]) == true)
                        {
                            VentanaAdmin venAd = new VentanaAdmin();
                            //sirve para esconder la ventana
                            this.Hide();
                            venAd.Show();
                        }
                        else
                        {

                            //si no cumple con la bentana adminstrador entonces ingresa un usuario
                            VentanaUser ventUse = new VentanaUser();
                            this.Hide();
                            ventUse.Show();
                        }
                    }


                }
                catch (Exception error)
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta..." + error);
                }

            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            Form noew = new RegistroUsuarios();
            noew.Show();
            this.Hide();
        }
    }
       }



