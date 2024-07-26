using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dsicusion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Generate_Click(object sender, EventArgs e)
        {
            int dimension;

            if (int.TryParse(txtDimension.Text, out dimension) && dimension > 0)
            {
                int[,] matrix = GenerateMatrix(dimension);
                int[,] transposedMatrix = TransposeMatrix(matrix);

                DisplayMatrix(dataGridView2Original, matrix);
                DisplayMatrix(dataGridView1Transposed, transposedMatrix);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una dimensión válida.");
            }
        }

        private int[,] GenerateMatrix(int dimension)
        {
            Random rand = new Random();
            int[,] matrix = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matrix[i, j] = rand.Next(0, 100); //
                }
            }

            return matrix;
        }

        private int[,] TransposeMatrix(int[,] matrix)
        {
            int dimension = matrix.GetLength(0);
            int[,] transposedMatrix = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }

            return transposedMatrix;
        }

        private void DisplayMatrix(DataGridView dataGridView, int[,] matrix)
        {
            dataGridView.ColumnCount = matrix.GetLength(1);
            dataGridView.RowCount = matrix.GetLength(0);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView[j, i].Value = matrix[i, j];
                }
            }
        }
    }
}   


