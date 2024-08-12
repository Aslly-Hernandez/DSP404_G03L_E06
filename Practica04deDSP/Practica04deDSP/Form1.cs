namespace Practica04deDSP
{
    public partial class Ejercicio1 : Form
    {
        private void presentacInic()
        {
            grbResult.Visible = false;
            nupBase.Focus();
        }
        private void HacerCalculos(Decimal N)
        {
            int c;
            decimal res;
            lstTabla1.Items.Clear();
            c = 1;
            do
            {
                res = N * c;
                lstTabla1.Items.Add(N.ToString() + "X" + c.ToString() + "=" + res.ToString());
                c += 1;
            } while (!(c > 10));

            lstTabla2.Items.Clear();
            c = 1;
            do
            {
                res = Elevar(N, c);
                lstTabla2.Items.Add(N.ToString() + " a la " + c.ToString() + "=" + res.ToString());
                c += 1;
            } while (c <= 10);
        }
        private decimal Elevar(decimal B, int expo)
        {
            int i = 1;
            decimal r = 1;
            do
            {
                r *= B;
                i += 1;
            } while (!(i > expo));
            return r;
        }
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            presentacInic();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            decimal n = nupBase.Value;
            HacerCalculos(n);
            grbResult.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
            this.Hide();
        }
    }
}
