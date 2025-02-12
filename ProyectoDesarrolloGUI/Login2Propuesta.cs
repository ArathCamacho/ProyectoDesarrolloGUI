using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDesarrolloGUI
{
    public partial class Login2Propuesta : Form
    {
        public Login2Propuesta()
        {
            InitializeComponent();
        }

        private void txtbox_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_1_Enter(object sender, EventArgs e)
        {
            if (txtbox_1.Text == "Usuario") {
                txtbox_1.Text = "";

            }
        }

        private void txtbox_1_Leave(object sender, EventArgs e)
        {
            if (txtbox_1.Text==""){
                txtbox_1.Text = "USUARIO";

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string usuarioValido = "admin";
            string contraseñaValida = "1234";
            if (txtbox_1.Text == usuarioValido && txtbox_2.Text == contraseñaValida)
            {
                PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
                paginaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtelo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_1.Clear();
                txtbox_2.Clear();
                txtbox_1.Focus();
            }
        }
    }
}
