using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte3_Guia2
{
    public partial class frmReves : Form
    {
        public static Boolean IsNumeric(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }
        public frmReves()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (IsNumeric(txtNumero.Text) && (long.Parse(txtNumero.Text) > 0))
            {
                long numero = long.Parse(txtNumero.Text);
                // para poner al reves un numero hay que ir dividiendo el numero 
                // para sacar al digitomas significativo y colocarlo en el nuevo 
                // numero osea en el digito menos significativo y asi sucesivamente
                long r, div, reves = 0, multi = 1;
                txtNumero.Text = numero.ToString();

                if (numero >= 100000 & numero <= 999999)
                    div = 100000;
                else if (numero >= 10000 & numero <= 99999)
                    div = 10000;
                else if (numero >= 1000 & numero <= 9999)
                    div = 1000;
                else if (numero >= 100 & numero <= 999)
                    div = 100;
                else if (numero >= 10 & numero <= 99)
                    div = 10;
                else
                {
                    MessageBox.Show("Numero fuera de rango (1-999999)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.BackColor = Color.Red;
                    return;
                }
                do
                {
                    // capturamos el digito mas significativo 
                    r = numero / div;
                    // restamos ese digito al numero
                    numero = numero - r * div;
                    // calculamos el siguiente divisor
                    div = div / 10;
                    // multiplicamos el digito segun su peso y los sumamos al nuevo numero
                    reves = reves + (r * multi);
                    // calculamos el siguiente multiplicador
                    multi = multi * 10;
                    // el proceso se repite hasta que el numero es igual a cero
                } while (numero != 0);
                    txtReves.Text = reves.ToString();
            } else
            {
                MessageBox.Show("El dato que se ingreso no es un numero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
                return;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.BackColor= Color.White;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtReves.Clear();
        }
    }
}
