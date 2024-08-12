using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica04deDSP
{
    public partial class Ejercicio2 : Form
    {
        int contaventas;
        public void inicializarControles()
        {
            /*prepara entorno de trabajo inicial al cargo Form
            Mostrara a la pagina 1 del TabControl1 */
            tabControl1.TabPages[0].Text = "Ventas efectuadas";
            tabControl1.TabPages[1].Text = "Estadisticas de venta";
            tabControl1.SelectedIndex = 0;

            dataGridView1.ReadOnly = true;

            dataGridView1.Columns.Add("numeventa", "#");
            dataGridView1.Columns.Add("montoventa", "Monto ($)");
            dataGridView1.Columns.Add("fechaventa", "Fecha Venta");
            dataGridView1.Columns.Add("Trime", "Trimestral(1-4)");

            dateTimePicker1.MaxDate = Convert.ToDateTime("31/12/2015");
            dateTimePicker1.MinDate = Convert.ToDateTime("01/01/2014");
            dateTimePicker1.Value = Convert.ToDateTime("01/01/2015");
            label3.Text = "Totales ventas promedio por trimestre";
            maskedTextBox1.Focus();
        }

        public void registrarVenta(decimal MontoVe, DateTime Fecha)
        {
            int Trimestre;
            switch (Convert.ToInt32(Fecha.Month))
            {
                case 1:
                case 2:
                case 3:
                    Trimestre = 1;
                    break;
                case 4:
                case 5:
                case 6:
                    Trimestre = 2;
                    break;
                case 7:
                case 8:
                case 9:
                    Trimestre = 3;
                    break;
                default:
                    Trimestre = 4;
                    break;
            }
            dataGridView1.Rows.Add();
            dataGridView1.Rows[contaventas].Cells[0].Value = contaventas + 1;
            dataGridView1.Rows[contaventas].Cells[1].Value = MontoVe;
            dataGridView1.Rows[contaventas].Cells[2].Value = Fecha;
            dataGridView1.Rows[contaventas].Cells[3].Value = Trimestre;
            contaventas += 1;
        }
        public void EvaluacionTrimestral()
        {
            /*Analiza los datos en el grid, para asi determinar:
             * a)Total ($) de ventas por trimestrs
               b)Fecga de la mayor y menor venta efectuada
            */
            decimal[] TotVentaTrim = new decimal[5];
            int c;
            int tri;

            for (c = 0; c <= (contaventas - 1); c++)
            {
                tri = Convert.ToInt32(dataGridView1.Rows[c].Cells["Trime"].Value);
                decimal x =
               Convert.ToDecimal(dataGridView1.Rows[c].Cells["montoventa"].Value);
                TotVentaTrim[tri] = TotVentaTrim[tri] + x;
            }
            for (c = 1; c < 5; c++)
            {
                listBox1.Items.Add("Trimestre" + Convert.ToString(c) + ":$" +
               Convert.ToString(TotVentaTrim[c]));
            }
        }
        public void ValidarDatos()
        {
            decimal montov;
            montov = Convert.ToDecimal(maskedTextBox1.Text);
            registrarVenta(montov, dateTimePicker1.Value);
            maskedTextBox1.Clear();
            maskedTextBox1.Focus();
        }

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EvaluacionTrimestral();
            tabControl1.SelectedIndex = 1;
            groupBox1.Enabled = false;
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            inicializarControles();
            contaventas = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Monto de venta incorrecto");
                maskedTextBox1.Focus();
            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
            this.Hide();
        }
    }
}
