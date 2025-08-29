using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0, memoria = 0;
        string operacion = "";
        bool nuevoNumero = false;

        public Form1()
        {
            InitializeComponent();
            txtResultado.Text = "0";
           
        }

        private void AgregarNumero(string numero)
        {
            if(txtResultado.Text == "0" || nuevoNumero)
            {
                txtResultado.Text = numero;
                nuevoNumero = false;
            }
            else
            {
                txtResultado.Text += numero;
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnCero.BackColor = Color.LightBlue;
            AgregarNumero("0");
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnUno.BackColor = Color.LightBlue;
            AgregarNumero("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnDos.BackColor = Color.LightBlue;
            AgregarNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnTres.BackColor = Color.LightBlue;
            AgregarNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnCuatro.BackColor = Color.LightBlue;
            AgregarNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnCinco.BackColor = Color.LightBlue;
            AgregarNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnSeis.BackColor = Color.LightBlue;
            AgregarNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnSiete.BackColor = Color.LightBlue;
            AgregarNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnOcho.BackColor = Color.LightBlue;
            AgregarNumero("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnNueve.BackColor = Color.LightBlue;
            AgregarNumero("9");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnResultado.BackColor = Color.LightBlue;
            valor2 = double.Parse(txtResultado.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+": resultado = valor1 + valor2; break;
                case "-": resultado = valor1 - valor2; break;
                case "*": resultado = valor1 * valor2; break;
                case "/":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        MessageBox.Show("Error, la division entre 0 no se puede realizar, intentalo con otro numero mayor a 0");
                    }
                    break;
                case "^": resultado = Math.Pow(valor1, valor2); break;
            }

            txtResultado.Text = resultado.ToString();
            nuevoNumero = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnClear.BackColor = Color.LightBlue;
            txtResultado.Text = "0";
            valor1 = valor2 = 0;
            operacion = "";
        }

        private void Operar(string op)
        {
            ResetearBotones();
            if (!string.IsNullOrEmpty(operacion))
            {
                
                btnResultado_Click(null, null);
            }

            valor1 = double.Parse(txtResultado.Text);
            operacion = op;
            nuevoNumero = true;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnSumar.BackColor = Color.LightBlue;
            Operar("+");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnResta.BackColor = Color.LightBlue;
            Operar("-");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnMultiplicacion.BackColor = Color.LightBlue;
            Operar("*");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnDivision.BackColor = Color.LightBlue;
            Operar("/");
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnSpace.BackColor = Color.LightBlue;
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
                
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnPorcentaje.BackColor = Color.LightBlue;

            if (!double.TryParse(txtResultado.Text, out double num))
            {
                MessageBox.Show("entrada no valida");
                return;
            }

            double porcentaje = 0;

            switch (operacion)
            {
                case "+": // a + (a * b%)
                case "-": // a - (a * b%)
                    porcentaje = valor1 * (num / 100.0);
                    break;
                default:  // sin operación pendiente (solo convierte)
                    porcentaje = num / 100.0;
                    break;
            }
            valor2 = porcentaje;
            txtResultado.Text = porcentaje.ToString();
            nuevoNumero = true;
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnCoseno.BackColor = Color.LightBlue;
            double num = double.Parse(txtResultado.Text);
            txtResultado.Text = Math.Cos(num * Math.PI / 180).ToString();
            nuevoNumero = true;

        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnTangente.BackColor = Color.LightBlue;
            double num = double.Parse(txtResultado.Text);
            txtResultado.Text = Math.Tan(num * Math.PI / 180).ToString();
            nuevoNumero = true;
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnFactorial.BackColor = Color.LightBlue;
            if (!double.TryParse(txtResultado.Text, out double d) || d < 0 || d % 1 != 0)
            {
                MessageBox.Show("el factorial solo se define para numero enteros positivos");
                return;
            }

            int n = (int)d;
            if (n > 20)
            {
                MessageBox.Show("el numero es demasiado grade, solo seria un maximo de 20 dijitos");
                return;
            }

            long fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;

            txtResultado.Text = fact.ToString();
            nuevoNumero = true;
        }

        private void btnLogaritmo_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnLogaritmo.BackColor = Color.LightBlue;
            double num = double.Parse(txtResultado.Text);
            txtResultado.Text = Math.Log10(num).ToString();
            nuevoNumero = true;
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnPI.BackColor = Color.LightBlue;
            txtResultado.Text = (double.Parse(txtResultado.Text) * Math.PI).ToString();
            nuevoNumero = true;
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnRaizCuadrada.BackColor = Color.LightBlue;
            double num = double.Parse(txtResultado.Text);
            txtResultado.Text = Math.Sqrt(num).ToString();
            nuevoNumero = true;
        }

        private void btnExponente_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnExponente.BackColor = Color.LightBlue;
            Operar("^");
        }

        private void btnMr_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnMr.BackColor = Color.LightBlue;
            txtResultado.Text = memoria.ToString();
            nuevoNumero = true;
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnMc.BackColor = Color.LightBlue;
            memoria = 0;
            MessageBox.Show("memoria borrada ", "calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMmenos_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnMmenos.BackColor = Color.LightBlue;
            memoria -= double.Parse(txtResultado.Text);
        }

        private void btnMmas_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            btnMmas.BackColor = Color.LightBlue;
            memoria += double.Parse(txtResultado.Text);
        }


        // FUNCIONES NECESARIAS PARA PODER CAMBIAR DE COLOR CADA BOTON AL SER PRESIONADO

        private void ResetearBotones()
        {
            foreach (Control c in this.Controls)
            {
                if(c is Button btn)
                {
                    btn.BackColor = SystemColors.Control;
                }   
            }
        }
    }
}
