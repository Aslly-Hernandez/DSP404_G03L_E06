using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    private void InicializarControles()
    {
        /*Prepara controles antes de mostrar form a usuario
         Define limites de c/control NumeriUpDown
         (rango valores que aceptara: de -20.0 hasta 35.0)
         */
        nudN1.Minimum = -20;
        nudN1.Maximum = 35;
        nudN1.DecimalPlaces = 1;
        nudN1.Increment = 2;

        nudN2.Minimum = -20;
        nudN2.Maximum = 35;
        nudN2.DecimalPlaces = 1;
        nudN2.Increment = 2;
        //Define presentacion de control cmbOperaciones
        cmb
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Hace operaciones matematicas especifica cuando usuario selecciona item del combo*/
            int nop;/*num de operacion selecciona en comobo
            toma indice(0-4) seleccionado actualmente del cmboperaciones,
            para obtener num operacion solicitada*/
            nop = cmbOperaciones.SelectedIndex + 1;
            //procede a realizar operacion matematica indicada
            HacerOperacion(nop);
        }
    }
}
