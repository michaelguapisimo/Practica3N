using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3N
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            }

            if (txtUsuario.Text == "Admin" && txtContraseña.Text == "1234")
            {
                MessageBox.Show("Bienvenido, admin!. Te amamos", "Inicio de Sesión Exitoso");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error");
            }
        }
    }
}
