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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private bool menuExpanded = true;  // Agregar esta variable al inicio de la clase

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuExpanded)
            {
                MenuVertical.Width = 30;
                menuExpanded = false;
            }
            else
            {
                MenuVertical.Width = 140;
                menuExpanded = true;
            }
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnVenta.Enabled = true;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Venta formVenta = new Venta();

            formVenta.Show();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar formconsultar = new Consultar();
            formconsultar.Show();
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            Devolucion formdevolucion = new Devolucion();
            formdevolucion.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy - hh:mm:ss tt");

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario forminventario = new Inventario();
            forminventario.Show();
        }
    }
}
