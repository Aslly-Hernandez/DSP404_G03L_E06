using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica3DSP
{
    public partial class Form2 : Form
    {
        string[,] matriz = new string[3, 3];
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;

        public static bool IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            colum1 = 0;
            colum2 = 1;
            colum3 = 2;

            if (cbtipoinfo.SelectedIndex == 0)
            {
                if (txtInfo.Text == "") txtInfo.BackColor = Color.Bisque;
                else
                {
                    if (fila1 < 3)
                    {
                        matriz[fila1, colum1] = txtInfo.Text;
                        fila1 += 1;
                        txtInfo.Clear();
                    }
                    else MessageBox.Show("No se pueden agregar mas nombres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (cbtipoinfo.SelectedIndex == 1)

                    if (txtInfo.Text == "") txtInfo.BackColor = Color.Bisque;
                    else
                        if (fila2 < 3)
                    {
                        matriz[fila2, colum2] = txtInfo.Text;
                        fila2 += 1;
                        MessageBox.Show("Apellido ingresado exitosamente");
                        txtInfo.Clear();
                    }
                    else MessageBox.Show("No se pueden agregar mas apellidos");
                else MessageBox.Show("Seleccione una opcion");

                if (IsNumeric(txtEdad.Text) == true)
                    if (fila3 < 3)
                    {
                        matriz[fila3, colum3] = txtEdad.Text;
                        fila3 += 1;
                        MessageBox.Show("Edad ingresada exitosamente");
                        txtEdad.Clear();
                        countergen += 1;
                    }
                    else MessageBox.Show("No se pueden agregar mas edades");
                else txtEdad.BackColor = Color.Beige;
            }
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            dgdatos.Columns.Clear();
            //crear colummnas
            dgdatos.ColumnCount = 3;
            dgdatos.Columns[0].Name = "Nombre";
            dgdatos.Columns[1].Name = "Apellido";
            dgdatos.Columns[2].Name = "Edad";
            dgdatos.Rows.Add();
            dgdatos.Rows.Add();

            //agregando datos a la grilla

            //nombres
            dgdatos.Rows[0].Cells[0].Value = matriz[0, 0];
            dgdatos.Rows[0].Cells[1].Value = matriz[0, 1];
            dgdatos.Rows[0].Cells[2].Value = matriz[0, 2];

            //apellidos
            dgdatos.Rows[1].Cells[0].Value = matriz[1, 0];
            dgdatos.Rows[1].Cells[1].Value = matriz[1, 1];
            dgdatos.Rows[1].Cells[2].Value = matriz[1, 2];

            //edades
            dgdatos.Rows[2].Cells[0].Value = matriz[2, 0];
            dgdatos.Rows[2].Cells[1].Value = matriz[2, 1];
            dgdatos.Rows[2].Cells[2].Value = matriz[2, 2];
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ventana3 = new Form3();
            ventana3.Show();
            
        }
    }
}


