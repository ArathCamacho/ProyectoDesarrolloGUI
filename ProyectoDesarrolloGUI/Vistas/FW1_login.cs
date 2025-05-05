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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string usuarioValido = "admin";
            string contraseñaValida = "1234";
            //command.Parameters.AddWithValue("@usuario", usuarioIngresado);
            //command.Parameters.AddWithValue("@contraseña", contraseñaIngresada);
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnl_borrar_Click(object sender, EventArgs e)
        {
            txtbox_1.Clear();
            txtbox_2.Clear();
            txtbox_1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
