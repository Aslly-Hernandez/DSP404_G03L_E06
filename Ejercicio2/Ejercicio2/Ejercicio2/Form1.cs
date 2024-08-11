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
        private string tipoOperacion;

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
            lblMensaje2.Text = "Seleccione una opción:\n" +
                "1. Consulta de saldo\n" +
                "2. Retiro de fondos\n" +
                "3. Consignaciones\n" +
                "4. Transferencias\n" +
                "5. Salir";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int opcion;
            if (int.TryParse(txtOpcionMenu.Text, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MostrarSaldo();
                        break;
                    case 2:
                        SolicitarCantidad("retiro");
                        break;
                    case 3:
                        SolicitarCantidad("consignación");
                        break;
                    case 4:
                        SolicitarCantidad("transferencia");
                        break;
                    case 5:
                        Application.Exit();
                        break;
                    default:
                        lblMensaje2.Text = "Opción no válida.";
                        break;
                }
            }
            else
            {
                lblMensaje2.Text = "Debe ingresar un número válido.";
            }
        }

        private void MostrarSaldo()
        {
            lblMensaje2.Text = $"El saldo actual de la cuenta {cuentaActual} es de ${cuentas[cuentaActual]}";
            
        }

        private void SolicitarCantidad(string operacion)
        {
            tipoOperacion = operacion;  
            lblMensaje2.Text = $"Ingrese la cantidad para {tipoOperacion}:";
            
        }

        private void btnConfirmarCantidad_Click(object sender, EventArgs e)
        {
            decimal cantidad;
            if (decimal.TryParse(txtCantidad.Text, out cantidad))
            {
                if (tipoOperacion == "retiro" && cantidad > cuentas[cuentaActual])
                {
                    lblMensaje2.Text = "Fondos insuficientes.";
                }
                else
                {
                    if (tipoOperacion == "retiro")
                        cuentas[cuentaActual] -= cantidad;
                    else if (tipoOperacion == "consignación")
                        cuentas[cuentaActual] += cantidad;
                    else if (tipoOperacion == "transferencia")
                    {
                       
                    }

                    lblMensaje2.Text = $"Operación exitosa. El saldo actual de la cuenta {cuentaActual} es de ${cuentas[cuentaActual]}";
                }
            }
            else
            {
                lblMensaje2.Text = "Cantidad no válida.";
            }

            MostrarMenu(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


