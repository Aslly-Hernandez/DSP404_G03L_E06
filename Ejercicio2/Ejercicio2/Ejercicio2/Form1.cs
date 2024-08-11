using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private Dictionary<int, decimal> cuentas = new Dictionary<int, decimal>()
    {
        { 1000001, 400m },
        { 1000002, 200m },
        { 1000004, 500m }
    };

        private int cuentaActual;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarCuenta_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroCuenta.Text, out cuentaActual) && cuentas.ContainsKey(cuentaActual))
            {
                lblMensaje.Text = $"Bienvenido, cuenta {cuentaActual}";
                MostrarMenu();
            }
            else
            {
                lblMensaje.Text = "Número de cuenta no válido. Inténtelo de nuevo.";
            }

        }
        private void MostrarMenu()
        {
            lblMensaje.Text += "\nSeleccione una opción:\n" +
                "1. Consulta de saldo\n" +
                "2. Retiro de fondos\n" +
                "3. Consignaciones\n" +
                "4. Transferencias\n" +
                "5. Salir";
        }
    }
}
