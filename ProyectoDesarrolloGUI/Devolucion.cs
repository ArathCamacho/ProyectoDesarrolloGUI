using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoDesarrolloGUI
{
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "";
            txtbox2.Text = "";
            txtbox3.Text = "";
            txtbox4.Text = "";
            txtbox5.Text = "";
            txtbox6.Text = "";
            txtbox7.Text = "";
            comboBox_Dev.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Devolución confirmada", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
