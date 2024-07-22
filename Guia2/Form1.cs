using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Guia2
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }
        // Metodo Estatico IsNumeric
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Declaracion de Variables
            long factorial = 1;
            int i;

            // Con la funcion InNumeric verificamos que el TxtNumero contenga un dato numerico 
            if (IsNumeric(txtNumero.Text))
            {
                // Se realiza ub for desde el numero ingresado hasta llegar a uno
                for (i = Convert.ToInt32(txtNumero.Text); i >= 1; i--)
                {
                    // Se multiplica el factorial por todos los numeros menores factorial = factorial*i;
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un numero!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();   // Cerrara el Programa
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }
    }
   }

