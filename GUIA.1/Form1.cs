using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIA._1
{
    public partial class Form1 : Form
    {
        int intentos = 0;
        int maximo_intentos = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = 0, altura = 0;
            if (!double.TryParse(txtPeso.Text, out peso) || !double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("ingrese los valores numericos del peso y la altura para hacer los calculos");
            }

            if (peso <= 0 || altura <= 0)
            {
                MessageBox.Show("tanto la altura como el peso deben ser mayores que 0");
                return;
            }

            double imc = peso / (Math.Pow(altura, 2));
            string categoria;

            if (imc < 18.5)
            {
                categoria = "bajo peso";
            }
            else if (imc < 24.9)
            {
                categoria = "peso normal";
            }
            else if (imc < 29.9)
            {
                categoria = "sobrepeso";
            }
            else
            {
                categoria = "obesidad";
            }
            lblResultado.Text = categoria;
            txtAltura.Clear();
            txtPeso.Clear();
            lblResultado.Text.Clone();

        }

        int contador = 0;
        private void btnClick_Click(object sender, EventArgs e)
        {
            contador++;

            lbl_contador.Text = $"haz presionado {contador} veces";

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double selsius, farenheit;

            if (!string.IsNullOrWhiteSpace(txtCelsius.Text) && double.TryParse(txtCelsius.Text, out selsius))
            {
                farenheit = (selsius * 9 / 5) + 32;
                txtFahrenheit.Text = farenheit.ToString("F2") + " F";
            }
            else if (!string.IsNullOrWhiteSpace(txtFahrenheit.Text) && double.TryParse(txtFahrenheit.Text, out farenheit))
            {
                selsius = (farenheit - 32) * 5 / 9;
                txtCelsius.Text = selsius.ToString("F2") + " C";
            }
            else
            {
                MessageBox.Show("Por favor, escriba un valor numérico en uno de los dos cuadros de texto.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txtFahrenheit.Clear();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario, clave;

            usuario = txtUsuario.Text;
            clave = txtClave.Text;

            if (usuario == "admin" && clave == "admin123")
            {
                MessageBox.Show("sea bienvenido " + "'" + usuario + "'");
                txtUsuario.Clear();
                txtClave.Clear();
                txtUsuario.Focus();
            }
            else
            {
                intentos++;

                int restante = maximo_intentos - intentos;

                if (restante > 0)
                {
                    MessageBox.Show("datos erroneos te quedan " + restante + " intentos");
                    txtUsuario.Clear();
                    txtClave.Clear();
                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("se ha superado la cantidad de intentos, la aplicacion se cerrara!!");
                    Close();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_contador.Text = string.Empty;
            contador = 0;
        }
    }
}
