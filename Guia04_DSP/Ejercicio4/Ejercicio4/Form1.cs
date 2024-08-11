using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        private bool Validar(string nombre, string pwd)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese su nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("Por favor, ingrese su contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpwd.Focus();
                return false;
            }
            string usuarioValido = "usuario";
            string passwordValido = "usuario";


            if (nombre == usuarioValido && pwd == passwordValido)
            {
                DialogResult respuesta = MessageBox.Show("Bienvenido " + nombre, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (respuesta == DialogResult.OK)
                {
                    Form1 formulario2 = new Form1();
                    formulario2.Show();
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpwd.Clear();
                txtpwd.Focus();

                return false;

                string clave = nombre;
                string pasword = "usuario";
                DialogResult respuesta;
                if (nombre == clave && pwd == pasword)
                {
                    respuesta = MessageBox.Show("Bienvenido" + " " + nombre, "Acceso",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (respuesta == DialogResult.OK)
                    {
                        Form1 formulario2 = new Form1();
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
        }
        public Form1()
        {
            InitializeComponent();
            txtusuario.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar(txtusuario.Text, txtpwd.Text))
            {
                this.Hide();
            }
        }
    }
}
