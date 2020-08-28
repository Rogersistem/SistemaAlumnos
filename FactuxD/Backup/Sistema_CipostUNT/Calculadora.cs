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
    public partial class Calculadora : Form
    {

        double primero;
        double segundo;
        // trae resutado del primero con el segundo
        double Resultado;
        // que operacion se hizo
        String Operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtpantalla.Clear();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
           // txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "0";
          
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
           // txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
           // txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "8";
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //txtpantalla.Clear();
            txtpantalla.Text = txtpantalla.Text + "9";
            
        }

        private void btnparencerrar_Click(object sender, EventArgs e)
        {
            Operador = "Raiz";
            primero = double.Parse(txtpantalla.Text);
            Resultado = primero;
            txtpantalla.Text = Math.Sqrt(primero).ToString();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtpantalla.Text);
            switch (Operador)
            {
                case "+":
                    Resultado = primero + segundo;
                    txtpantalla.Text = Resultado.ToString();
              
                    break;
                case "-":
                    Resultado = primero - segundo;
                    txtpantalla.Text = Resultado.ToString();
                    break;
                case "*":
                    Resultado = primero * segundo;
                    txtpantalla.Text = Resultado.ToString();
                    break;
                case "/":
                    Resultado = primero / segundo;
                    txtpantalla.Text = Resultado.ToString();
                    break;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + ".";
        }

        private void btnparentesis_Click(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Operador = "+";
            primero = double.Parse(txtpantalla.Text);

            txtpantalla.Text = "+";
            txtpantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            
            Operador = "/";
            primero = double.Parse(txtpantalla.Text);
            
           txtpantalla.Clear();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Operador = "*";
            primero = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operador = "-";
            primero = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
