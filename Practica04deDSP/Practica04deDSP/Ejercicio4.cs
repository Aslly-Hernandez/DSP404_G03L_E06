using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Practica04deDSP
{
    public partial class Ejercicio4 : Form
    {
        private Boolean validar(string nombre, string pwd)
        {
            string clave = nombre;
            string pasword = "usuario";

            DialogResult respuesta;


            if (nombre == clave && pwd == pasword)
            {
                respuesta = MessageBox.Show("Bienvenido" + " " + nombre, "Acceso",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (respuesta == DialogResult.OK)
                {
                    Ejercicio4parte2 formulario2 = new Ejercicio4parte2();
                    formulario2.Show(); 
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar(txtUsuario.Text, txtpwd.Text))
            {
                this.Hide();
            }
        }
    }
}
