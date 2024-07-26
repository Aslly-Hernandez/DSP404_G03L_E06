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
    public partial class Form3 : Form
    {
        private string non, ape1, ape2;
        private double cum;
        private int uv;

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        //CUM
        private void EvaluarCUM()
        {
            string nombreCompleto;
            nombreCompleto = non + " " + ape1 + " " + ape2;
            nombreCompleto = nombreCompleto.ToUpper();

            if (cum < 0 | cum > 10)
            {
                MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
            }
            else
            {
                switch (Convert.ToInt16(cum))
                {
                    case 8 - 10: uv = 32;
                        break;
                    case 7: uv = 24;
                        break;
                    case 6: uv = 20;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5: uv = 16;
                        break;
                    default: uv = 0;
                        break;
                }
                txtResul.Text = nombreCompleto + "Puede cursar " + uv + " UV";
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            string primerApe;
            string segunApe;
            string nom;
            double cum;

            primerApe = txtApe1.Text;
            primerApe = primerApe.Trim();
            segunApe = txtApe2.Text;
            segunApe = segunApe.Trim();
            nom = txtNom.Text;
            nom = nom.Trim();

            if (primerApe.Length == 0)
            {
                MessageBox.Show("Debe ingresar su primer apellido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApe1.Focus();
                return;
            }
            if (segunApe.Length == 0)
            {
                MessageBox.Show("Debe ingresar su segundo apellido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApe2.Focus();
                    return;
            }
            if (nom.Length == 0)
            {
                MessageBox.Show("Debe ingresar sus nombres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNom.Focus();
                return;
            }

            txtResul.Clear();
            EvaluarCUM();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblApe1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
