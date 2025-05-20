using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDesarrolloGUI.Base_de_datos;

namespace ProyectoDesarrolloGUI
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que el textbox no esté vacío
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor ingrese un ID de producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya ingresado un número
            if (!int.TryParse(textBox1.Text.Trim(), out int idProducto))
            {
                MessageBox.Show("El ID debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                BuscarCodigo buscador = new BuscarCodigo();
                DataTable resultado = buscador.BuscarProductoPorID(idProducto);

                if (resultado.Rows.Count > 0)
                {
                    // Mostrar resultado en un DataGridView o hacer lo que necesites
                    dgvProductos.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductos.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
