using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form
    {
        private string mensa;
        private int conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mensa = "Aun no ha presionado boton Contar";
            label1.Text = mensa;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int conta = 0;
            conta = conta + 1;
            mensa = "Presiono boton Contar, un total de " + Convert.ToString(conta) + " veces ";
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            conta = 0;
            mensa = "Presiono boton Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
