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
        BDUSUARIOS bdusuarios = new BDUSUARIOS();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == bdusuarios.usuario[0,0] && txtContra.Text == bdusuarios.usuario[1, 0])
            {
                this.Hide();
                MessageBox.Show("Bienvenido/a");
                FormInformacion formInformacion = new FormInformacion();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }
    }
}
