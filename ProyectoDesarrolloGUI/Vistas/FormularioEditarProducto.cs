using ProyectoDesarrolloGUI.Base_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDesarrolloGUI.Vistas
{
    public partial class FormularioEditarProducto : Form
    {
        public int ProductoID { get; set; }

        public FormularioEditarProducto()
        {
            InitializeComponent();
        }
        private void FormularioEditarProducto_Load(object sender, EventArgs e)
        {

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                string codigoBarras = txtCodigo.Text;
                int stock = int.Parse(txtStock.Text);

                EditarProducto editar = new EditarProducto();
                editar.ActualizarProducto(ProductoID, nombre, descripcion, precio, codigoBarras, stock);

                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarDatos(string nombre, string descripcion, decimal precio, string codigoBarras, int stock)
        {
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtPrecio.Text = precio.ToString();
            txtCodigo.Text = codigoBarras;
            txtStock.Text = stock.ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
