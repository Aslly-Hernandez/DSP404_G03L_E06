using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_de_resultado_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btna_Click(object sender, EventArgs e)
        {
            List<double> numeros = ObtenerNumeros();
            if (numeros == null)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
                return;
            }

            var negativos = numeros.Where(n => n < 0).ToList();
            var positivos = numeros.Where(n => n >= 0).ToList();

            if (negativos.Count > 0)
            {
                double menorNegativo = negativos.Min();
                double mayorNegativo = negativos.Max();
                labelResultado.Text = $"Menor negativo: {menorNegativo}, Mayor negativo: {mayorNegativo}";
            }
            else
            {
                labelResultado.Text = "No hay números negativos.";
            }

            if (positivos.Count > 0)
            {
                double promedioPositivos = positivos.Average();
                labelResultado.Text += $", Promedio positivos: {promedioPositivos}";
            }
            else
            {
                labelResultado.Text += ", No hay números positivos.";
            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            List<double> numeros = ObtenerNumeros();
            if (numeros == null)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
                return;
            }

            double media = numeros.Average();
            labelResultado.Text = $"Media de la serie: {media}";
        }

        private List<double> ObtenerNumeros()
        {
            List<double> numeros = new List<double>();
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };

            foreach (var textBox in textBoxes)
            {
                if (double.TryParse(textBox.Text, out double numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    return null; // Devolver null si alguna entrada no es válida
                }
            }

            return numeros;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

