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
    public partial class frmULAM : Form
    {
        public static Boolean IsNumeric (string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public frmULAM()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            lstLista.ClearSelected();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (IsNumeric (txtnumero.Text) && (long.Parse(txtnumero.Text) > 0))
            {
                long numero = long.Parse(txtnumero.Text);
                txtnumero.Text = numero.ToString();

            }
        }
    }
}
