using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_3
{
    public partial class Form1 : Form
    {
        private string noms, ape1, ape2;
        private double CUM;
        private int UV;

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        private void EvaluarCUM()
        {
            string nombrecompleto;
            nombrecompleto = noms + " " + ape1 + " " + ape2;
            nombrecompleto = nombrecompleto.ToUpper();
            if (CUM < 0 | CUM > 10)
            {
                MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0)", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
            }
            else
            {
                switch (Convert.ToInt16(CUM))
                {
                    case 8:
                    case 9:
                    case 10:
                        UV = 32;
                        break;
                    case 7:
                        UV = 24;
                        break;
                    case 6:
                        UV = 20;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        UV = 16;
                        break;
                    default:
                        UV = 0;
                        break;
                }
                txtResul.Text = nombrecompleto + "Puede cursar " + UV + "UV";


            }
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            noms = txtNom.Text;
            ape1 = txtApe1.Text;
            ape2 = txtApe2.Text;
            if (IsNumeric(txtCUM.Text))
            {
                CUM = double.Parse(txtCUM.Text);
                EvaluarCUM();
            }
            
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios");
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}