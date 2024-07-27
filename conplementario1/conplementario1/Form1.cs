using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace conplementario1
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

        private void btnopcionA_Click(object sender, EventArgs e)
        {
            {
                // Obtener los números del formulario
                double[] numeros = ObtenerNumerosDelFormulario();

                // Separar los números en positivos y negativos
                var positivos = numeros.Where(n => n > 0).ToList();
                var negativos = numeros.Where(n => n < 0).ToList();

                // Calcular el número menor y mayor de los negativos
                double? menorNegativo = negativos.Count > 0 ? (double?)negativos.Min() : null;
                double? mayorNegativo = negativos.Count > 0 ? (double?)negativos.Max() : null;

                // Calcular el promedio de los positivos
                double? promedioPositivos = positivos.Count > 0 ? (double?)positivos.Average() : null;
                // Mostrar los resultados
                if (menorNegativo.HasValue && mayorNegativo.HasValue)
                {
                    labelResultado.Text = $"Menor negativo: {menorNegativo.Value}\nMayor negativo: {mayorNegativo.Value}";
                }
                else
                {
                    labelResultado.Text = "No hay números negativos en la lista.";
                }
                if (promedioPositivos.HasValue)
                {
                    labelResultado.Text += $"\nPromedio de positivos: {promedioPositivos.Value}";
                }
                else
                {
                    labelResultado.Text += "\nNo hay números positivos en la lista.";
                }
            }

        }

        private void butnopcionB_Click(object sender, EventArgs e)
        {
            // Obtener los números del formulario
            double[] numeros = ObtenerNumerosDelFormulario();

            // Calcular la media de toda la serie
            double mediaTotal = numeros.Average();

            // Mostrar la media total
            labelResultado.Text = $"La media de toda la serie es: {mediaTotal}";
        }

        private void text10Numeros_TextChanged(object sender, EventArgs e)
        {
            // Obtener los números de los TextBox
            double[] numeros = new double[10];
            numeros[0] = double.Parse(textNum2,Text);
            numeros[1] = double.Parse(textNum7.Text);
            numeros[2] = double.Parse(textNum6.Text);
            numeros[3] = double.Parse(textNum5.Text);
            numeros[4] = double.Parse(textNum4.Text);
            numeros[5] = double.Parse(textNum3.Text);
            numeros[7] = double.Parse(textNum9.Text);
            numeros[8] = double.Parse(textNum8.Text);
            numeros[9] = double.Parse(textBox10.Text);
            return numeros;
        }
    }
    }
