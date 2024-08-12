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
    public partial class Ejercicio3 : Form
    {
        private void InicializarControles()
        {
            nudN1.Minimum = -20;
            nudN1.Maximum = 35;
            nudN1.DecimalPlaces = 1;
            nudN1.Increment = 2;
            nudN2.Minimum = -20;
            nudN2.Maximum = 35;
            nudN2.DecimalPlaces = 1;
            nudN2.Increment = 2;
            cmbOperaciones.Items.Add("1. Suma");
            cmbOperaciones.Items.Add("2. Resta");
            cmbOperaciones.Items.Add("3. Multiplicación");
            cmbOperaciones.Items.Add("4. División");
            cmbOperaciones.Items.Add("5. Potencia");

            cmbOperaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            lblresul.Text = "(RESULTADO)";
        }
        private void SumarEstosNumeros()
        {
            double su;
            su = Convert.ToDouble(nudN1.Value) + Convert.ToDouble(nudN2.Value);
            MostrarResultado(su, 1);
        }
        private void MostrarResultado(double R, int Oper, Boolean hayError = false)
        {
            string descripOpe = cmbOperaciones.Text;
            if (!hayError)
            {
                lblresul.BackColor = Color.Green;
                lblresul.ForeColor = Color.White;
                lblresul.Text = descripOpe + "es " + Convert.ToString(R);
            }
            else
            {
                lblresul.BackColor = Color.Red;
                lblresul.ForeColor = Color.Yellow;
                lblresul.Text = "(ERROR, DIVISION POR CERO)";
            }
        }
        private double Potencia(double A, double B)
        {
            return Math.Pow(A, B);
        }
        private void Multiplicar(double x, double y, ref double M)
        {
            M = x * y;
        }
        private Boolean Dividir(double x, double y, ref double d)
        {
            if (y == 0.0)
            {
                return (false);
            }
            else
            {
                d = x / y;
                return true;
            }
        }
        private void RestarA(double a, double b)
        {
            double su;
            int opc;
            su = a - b;
            opc = cmbOperaciones.SelectedIndex + 1;
            MostrarResultado(su, 1);
        }

        private void HacerOperacion(int numOperac)
        {
            switch (numOperac)
            {
                case 1:
                    SumarEstosNumeros();
                    break;
                case 2:
                    RestarA(Convert.ToDouble(nudN1.Value), Convert.ToDouble(nudN2.Value));
                    break;
                case 3:
                    double prod = 0;
                    Multiplicar(Convert.ToDouble(nudN1.Value), Convert.ToDouble(nudN2.Value), ref prod);
                    MostrarResultado(prod, 3, false);
                    break;
                case 4:
                    double division = 0;
                    if (Dividir(Convert.ToDouble(nudN1.Value), Convert.ToDouble(nudN2.Value), ref division))
                    {
                        MostrarResultado(division, 3);
                    }
                    else
                    {
                        MostrarResultado(division, 4, true);
                    }
                    break;
                case 5:

                    MostrarResultado(Potencia(Convert.ToDouble(nudN1.Value), Convert.ToDouble(nudN2.Value)), 5);
                    break;
                default:
                    MessageBox.Show("Operación solicitada no valida", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    break;
            }
        }
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void cmbOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nop;
            nop = cmbOperaciones.SelectedIndex + 1;
            HacerOperacion(nop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Show();
            this.Close();

        }
    }
}
