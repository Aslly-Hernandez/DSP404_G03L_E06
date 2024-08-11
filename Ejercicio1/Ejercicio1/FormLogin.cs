using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = txtContra.Text;

            if (usuario == "" || contra == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (usuario == "Usuario1" && contra == "contraseña")
            {
                FormInformacion formInformacion = new FormInformacion();
                formInformacion.Show();
                this.Hide();
                MessageBox.Show("Bienvenido/a");
             
            }
            else
            {
                if (usuario == "Usuario2" && contra == "contraseña")
                {
                    FormInformacion formInformacion = new FormInformacion();
                    formInformacion.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenido/a");

                }
                else
                {
                    MessageBox.Show("Usuario no registrado");
                    return;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
