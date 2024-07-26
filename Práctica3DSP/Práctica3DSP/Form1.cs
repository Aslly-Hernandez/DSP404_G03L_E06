namespace Práctica3DSP
{
    public partial class Form1 : Form
    {
        int i;
        int[] matriz = new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (i <= 5)
            {
                matriz[i] = Convert.ToInt16(txtNum.Text);
                lstdesorden.Items.Add(matriz[i]);//agregamos los numeros a la lista
                i += 1;
                txtNum.Clear();
                txtNum.Select();
            }
            else
            {
                MessageBox.Show("No se puede ingresar mas datos", "Advertencia", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            int j, k, count;
            double valor;
            int Tam = 5;

            for (j = 0; j < Tam; j++)
            {
                for (k = 0; k < (Tam - 1); k++)
                {
                    if (matriz[k] > matriz[k + 1])
                    {
                        valor = matriz[k];
                        matriz[k] = matriz[k + 1];
                        matriz[k + 1] = Convert.ToInt16(valor);
                    }
                }
            }

            lstOrdenada.Items.Clear();
            for (count = 0; count < Tam; count++)
            {
                lstOrdenada.Items.Add(matriz[count]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();
            ventana2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ventana3 = new Form3();
            ventana3.Show();
        }
    }
}

