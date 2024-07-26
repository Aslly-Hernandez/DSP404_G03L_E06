using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2DSP
{
    public partial class frmCesar : Form
    {
        public static Boolean IsNumeric (string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public frmCesar()
        {
            InitializeComponent();
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmCesar_Load(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (IsNumeric (txtLlave.Text) && (Convert.ToInt16(txtLlave.Text) > 0))
            {
                txtResultado.Clear();
                int ascii;

                foreach (int c in txtTexto.Text)
                {
                    if (rdbEncriptar.Checked == true)
                    {
                        ascii = (int)c + Convert.ToInt16(txtLlave.Text);
                    }
                    else
                    {
                        ascii = (int)c + Convert.ToInt16(txtLlave.Text);
                    }
                    txtResultado.Text += (char)ascii;
                }
                lblresultado.Text = "Texto encriptado: ";
               
            }
            else
            {
                MessageBox.Show("El dato introducido en la llave es incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLlave.Focus();
                txtLlave.Clear();
                txtLlave.BackColor = Color.Red;
            }
        }

        private void txtLlave_TextChanged(object sender, EventArgs e)
        {
            txtLlave.BackColor = Color.White;
        }

        private void rdbEncriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEncriptar.Checked == true)
            {
                btnEncriptar.Text = "Encriptar";
            }
        }

        private void rdbDesencriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDesencriptar.Checked == true)
            {
                btnEncriptar.Text = "Desencriptar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReves ventana3 = new frmReves();
            this.Hide();
            ventana3.Show();
           
            
            
        }
    }
}
