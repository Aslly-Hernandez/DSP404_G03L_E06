using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_Guia2
{
    public partial class frmULAM : Form
    {
        public frmULAM()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {   
            // Se declaran las variables
            int numero;
            string resultado = "";

            // Verificar que el txtNumero contenga un dato numerico
            if (int.TryParse(txtNumero.Text, out numero))
            {
                // Verificamos si el numero es positivo
                if (numero > 0)
                {
                    //Se genera la susecion de ULAM
                    
                    while (numero != 1)
                    {
                        lstLista.Items.Add(numero.ToString());
                        if (numero % 2 == 0)
                        {
                            numero /= 2;
                        } else
                        {
                            numero = 3 * numero + 1;
                        }
                        
                    }
                    lstLista.Items.Add("1"); // Agregar el último número que es 1
                    
                } else
                {
                    MessageBox.Show("Ingrese un numero positivo mayor que 0", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero.Clear();
                    lstLista.Items.Clear();
                    txtNumero.Focus();
                }
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un numero valido!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                lstLista.Items.Clear();
                txtNumero.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia los valores
            txtNumero.Clear();
            lstLista.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicacion
            Close();
        }
    }
}
