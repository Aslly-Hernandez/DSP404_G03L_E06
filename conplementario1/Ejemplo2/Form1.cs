using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // Inicializar el ComboBox de Meses
                comboBoxMes.Items.AddRange(new string[]
                {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
                });
                // Inicializar el ComboBox de Días (1 a 31)
                for (int i = 1; i <= 31; i++)
                {
                    comboBoxDia.Items.Add(i.ToString());
                }
            }
    }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
