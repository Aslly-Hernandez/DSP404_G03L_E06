using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMes.Items.AddRange(new string[]
    {
        "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
        "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"});

            for (int i = 1; i <= 31; i++)
            {
                comboBoxDia.Items.Add(i);
            }
            for (int i = 1900; i <= 2100; i++)
            {
                comboBoxAno.Items.Add(i);
            }
            comboBoxMes.SelectedIndex = 0;
            comboBoxDia.SelectedIndex = 0;
            comboBoxAno.SelectedIndex = 0;
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            int mes = comboBoxMes.SelectedIndex + 1;
            int dia = (int)comboBoxDia.SelectedItem;
            int ano = (int)comboBoxAno.SelectedItem;

            if (EsFechaValida(mes, dia, ano))
            {
                labelMensaje.Text = "Fecha válida";
            }
            else
            {
                labelMensaje.Text = "Fecha no válida";
            }
        }
        private bool EsFechaValida(int mes, int dia, int ano)
        {
            bool esBisiesto = DateTime.IsLeapYear(ano);

            switch (mes)
            {
                case 2: // Febrero
                    if (esBisiesto)
                    {
                        return dia <= 29;
                    }
                    else
                    {
                        return dia <= 28;
                    }
                case 4: // Abril
                case 6: // Junio
                case 9: // Septiembre
                case 11: // Noviembre
                    return dia <= 30;
                default: // Meses con 31 días
                    return dia <= 31;
            }
        }
    }
}   
