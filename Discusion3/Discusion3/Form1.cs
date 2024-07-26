using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discusion3
{
    public partial class FormCargarDatos : Form
    {
        public FormCargarDatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            float[,] notas = new float[6, 5]
            {
                { 8.5f, 7.0f, 0f, 9.0f, 0f },
                { 6.5f, 8.0f, 7.0f, 0f, 0f },
                { 9.0f, 0f, 0f, 8.5f, 7.5f },
                { 0f, 6.0f, 0f, 5.5f, 7.0f },
                { 8.0f, 7.5f, 0f, 0f, 9.0f },
                { 0f, 0f, 8.0f, 7.0f, 6.5f }
            };

            // Configurar las columnas del DataGridView
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Alumno", "Alumno");
            for (int i = 1; i <= 5; i++)
            {
                dataGridView1.Columns.Add($"Asignatura{i}", $"Asignatura {i}");
            }
            dataGridView1.Columns.Add("Media", "Media");

            // Rellenar el DataGridView con los datos de la matriz
            for (int i = 0; i < 6; i++)
            {
                float sumaNotas = 0;
                int numAsignaturas = 0;
                var fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);

                fila.Cells[0].Value = $"Alumno {i + 1}";

                for (int j = 0; j < 5; j++)
                {
                    if (notas[i, j] != 0)
                    {
                        fila.Cells[j + 1].Value = notas[i, j].ToString("F1");
                        sumaNotas += notas[i, j];
                        numAsignaturas++;
                    }
                    else
                    {
                        fila.Cells[j + 1].Value = "-";
                    }
                }

                // Calcular la media
                if (numAsignaturas > 0)
                {
                    float media = sumaNotas / numAsignaturas;
                    fila.Cells[6].Value = media.ToString("F2");
                }
                else
                {
                    fila.Cells[6].Value = "-";
                }

                dataGridView1.Rows.Add(fila);
            }
        }
    }
}
