using ProyectoDesarrolloGUI.Base_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDesarrolloGUI
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioAgregarProducto formAgregar = new FormularioAgregarProducto();
            formAgregar.StartPosition = FormStartPosition.CenterScreen; // Asegura que se abra centrado
            formAgregar.ShowDialog();

            formAgregar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto modificado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                bool resultado = true;
                if (resultado)
                {
                    MessageBox.Show("Producto eliminado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios guardados exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Listado()
        {
            ConsultarInventario datos = new ConsultarInventario();
            dgvProductos.DataSource = datos.ConsInventario();
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            this.Listado();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }
        private void BuscarProducto()
        {
            if (int.TryParse(txtb_Buscar.Text, out int id)) // Verifica si el ID es un número válido
            {
                ConsultarInventario consulta = new ConsultarInventario();
                DataTable resultado = consulta.BuscarProductoPorID(id);

                if (resultado.Rows.Count > 0)
                {
                    dgvProductos.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductos.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
