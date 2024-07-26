using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2DSP
{
    public partial class frmFactorial : Form
    {
        public static Boolean IsNumeric (string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            long factorial = 1;
            int i;

            if (IsNumeric (txtNumero.Text))
            {
                for (i = Convert.ToInt32(txtNumero.Text); i >= 1; i--)
                {
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
           
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            } 

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCesar ventana2 = new frmCesar();
            this.Hide();
            ventana2.Show();
           
            

        }
    }
}
