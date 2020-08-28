using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace MyLibreri
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection coneccion = new SqlConnection("Data Source=ROGER\\MSSQLSERVER16;Initial Catalog=DBA_CIPOST2019;User ID=sa;Password=sql");
            //Abre mi conexion a la base de datos
            coneccion.Open();
            //CREAMO SUN DATASET QUE  ALAMACENE LO QUE YO QUIERO
            DataSet DS = new DataSet();
            //NECESITO ADAPTAR LO DATOS PARA GUARDAR
            SqlDataAdapter DT = new SqlDataAdapter(cmd, coneccion);

            //RELLENAR EL DATA SET
            DT.Fill(DS);
            //CERRAMOS LA CONNECION
            coneccion.Close();

            //DEVOLVER EL DATASET
            return DS;

        }
        //ESTE METODO ES PARA VALIDAR FORMULARIO
        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider errorProvider)
        {
            Boolean HayErrores = false;
            foreach (Control Item in Objeto.Controls)
            {
                if (Item is ErrortextBox)
                {
                    ErrortextBox obj = (ErrortextBox)Item;
                    if (obj.validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            errorProvider.SetError(obj, "No puede estar vacio");
                            HayErrores = true;
                        }
                    }
                    else
                    {
                        errorProvider.SetError(obj, "");
                    }
                }
            }
            return HayErrores;
        }
       }
   }

