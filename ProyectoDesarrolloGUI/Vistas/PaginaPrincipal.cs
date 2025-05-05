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
            this.SuspendLayout(); // Detiene la actualización de la UI

            if (menuExpanded)
            {
                MenuVertical.Width = 30;
                menuExpanded = false;
            }
            else
            {
                MenuVertical.Width = 180;
                menuExpanded = true;
            }

            this.ResumeLayout(); // Reanuda la actualización de la UI
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

        private void button1_Click(object sender, EventArgs e)
        {

        }   

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void PaginaPrincipal_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaginaPrincipal_Shown(object sender, EventArgs e)
        {
            // Calcula la posición X para centrar el control horizontalmente
            // Ahora referenciamos el PictureBox llamado pbLogoG
            // Calcular la posición central del Panel
            int centerX_Panel1 = (this.ClientSize.Width - panel1.Width) / 2;
            int centerY_Panel1 = (this.ClientSize.Height - panel1.Height) / 2;

            // Establecer la nueva ubicación del Panel
            panel1.Location = new Point(centerX_Panel1, centerY_Panel1);
            int centerX_G = (this.ClientSize.Width - pictureBox4.Width) / 2 - 50;
            int centerY_G = (this.ClientSize.Height - pictureBox4.Height) / 2 - 30;
            //pictureBox4.Location = new Point(centerX_G, centerY_G);

            // Posicionar el Label de la hora centrado debajo de la "G"


        }

        private void lblFechaHora_Click(object sender, EventArgs e)
        {

        }
    }
}
