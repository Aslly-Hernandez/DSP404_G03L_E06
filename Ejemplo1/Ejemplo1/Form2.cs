using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form2 : Form
    {
        private double TasaI;
         public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rdbInteres1_CheckedChanged(object sender, EventArgs e) {
            TasaI = 0.12;
        }

        private void rdbInteres3_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (rdbInteres3.Checked == true)
                {
                    txtTasaInterEX.Enabled = true;
                    txtTasaInterEX.Focus();
                }
                else
                {
                    txtTasaInterEX.Text = "0";
                    txtTasaInterEX.Enabled = false;
                }
            }
        }

        private void rdbInteres2_CheckedChanged(object sender, EventArgs e)
        {
            TasaI = 0.235;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            string nomEmpre;
            double montoInic = 0, montoFin = 0;
            int tiempo;

            nomEmpre = txtEmpresa.Text;
            nomEmpre = nomEmpre.Trim();

            if (nomEmpre.Length == 0)
            {
                MessageBox.Show("Debe indicar un nombre de la empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus();
                return;
            }
            if (!IsNumeric(txtMonto.Text))
            {
                MessageBox.Show("Valor monto incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus();
                return;
            }
            else {
                montoInic = Convert.ToDouble(txtMonto.Text);
                if (!(montoInic > 0)){
                    MessageBox.Show("Valor monto no puede ser negativo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus();
                    return;
                }
            }
            tiempo = Convert.ToInt32(txtTiempo.Text);
            txtTasaInterEX.Text = txtTasaInterEX.Text.Trim();

            if (rdbInteres3.Checked == true) {
                if ( txtTasaInterEX.Text.Length > 0) {
                        if (!(IsNumeric(txtTasaInterEX.Text) == true))
                                {
                                MessageBox.Show("Tasa de interes incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtTasaInterEX.Text = "0";
                                txtTasaInterEX.Focus();
                                return;
                            }
                            else {
                                TasaI = Convert.ToDouble(txtTasaInterEX.Text) / 100;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aún no ha indicado una tasa de interes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTasaInterEX.Focus();
                            return;
                        }
                    }
            montoFin = (1 + TasaI);
            montoFin = montoInic * (Math.Pow(Convert.ToDouble(montoFin), tiempo));
            TasaI *= 100;

            //Muestra respuesta de monto a pagar
            lstResul.Items.Clear();
            lstResul.Items.Add("Empresa: " + txtEmpresa.Text);
            lstResul.Items.Add("Monto: $" + montoInic + " ,tasa anual: " + TasaI);
            lstResul.Items.Add("Monto a pagar: $" + montoFin);
                }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ventana3 = new Form3();
            ventana3.Show();
        }
    }

        }

    

