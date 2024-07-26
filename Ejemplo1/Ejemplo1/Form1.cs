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
    public partial class Form1 : Form
    {
        private string mensa;
        static private int conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Evento que se ejecutara cuando se ejecute el programa
            mensa = "Aún no ha presionado el boton contar";
            lbl1.Text = mensa;
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {
            // int conta = 0;
            conta = conta + 1;
            mensa = "Presiono botón contar, un total de " + Convert.ToString(conta) + " veces";
            lbl1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            conta = 0;
            mensa = "Presiono botón contar, un total de " + Convert.ToString(conta) + " veces";
            lbl1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();
            ventana2.Show();
        }
    }
}
