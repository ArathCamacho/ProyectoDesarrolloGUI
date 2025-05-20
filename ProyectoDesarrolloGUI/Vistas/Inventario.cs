using ProyectoDesarrolloGUI.Base_de_datos;
using ProyectoDesarrolloGUI.Vistas;
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
            formAgregar.StartPosition = FormStartPosition.CenterScreen;

            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                // Refrescar la tabla de productos
                ConsultarInventario consulta = new ConsultarInventario();
                dgvProductos.DataSource = consulta.ConsInventario();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvProductos.SelectedRows[0];

                int id = Convert.ToInt32(fila.Cells["ProductoID"].Value);
                string nombre = fila.Cells["NombreProducto"].Value.ToString();
                string descripcion = fila.Cells["Descripcion"].Value.ToString();
                decimal precio = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value);
                string codigoBarras = fila.Cells["CodigoBarras"].Value.ToString();
                int stock = Convert.ToInt32(fila.Cells["Stock"].Value);

                FormularioEditarProducto formEditar = new FormularioEditarProducto();
                formEditar.ProductoID = id;
                formEditar.CargarDatos(nombre, descripcion, precio, codigoBarras, stock);
                formEditar.StartPosition = FormStartPosition.CenterScreen;

                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    // Recargar productos actualizados en el DataGridView
                    dgvProductos.DataSource = new ConsultarInventario().ConsInventario();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
            string texto = txtb_Buscar.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                // Si el TextBox está vacío, mostrar todo el inventario
                ConsultarInventario consulta = new ConsultarInventario();
                dgvProductos.DataSource = consulta.ConsInventario();
                return;
            }

            if (int.TryParse(texto, out int id)) // Verifica si el ID es un número válido
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
                // No mostrar mensaje si solo está escribiendo letras o caracteres
                // Podrías omitir este bloque o mostrar algo más amigable si deseas
            }
        }


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["ProductoID"].Value);

                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    ConsultarInventario consulta = new ConsultarInventario();
                    bool eliminado = consulta.EliminarProductoPorID(idProducto);

                    if (eliminado)
                    {
                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProductos.DataSource = consulta.ConsInventario(); // Refrescar la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
