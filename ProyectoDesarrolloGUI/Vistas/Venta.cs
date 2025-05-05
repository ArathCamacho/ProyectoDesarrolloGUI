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

namespace ProyectoDesarrolloGUI
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }
        private void BuscarProducto()
        {
            int codigo;

            if (!int.TryParse(txt_buscar.Text.Trim(), out codigo))
            {
                MessageBox.Show("Ingresa un ID válido.");
                return;
            }

            BuscarCodigo buscador = new BuscarCodigo();
            DataTable resultado = buscador.BuscarProductoPorID(codigo);

            if (resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                string id = fila["ProductoID"].ToString();
                string descripcion = fila["Descripcion"].ToString();
                decimal precio = Convert.ToDecimal(fila["PrecioUnitario"]);

                bool productoExistente = false;

                // Buscar si ya existe en el DataGridView
                foreach (DataGridViewRow row in dgv_productos.Rows)
                {
                    if (row.Cells["ProductoID"].Value?.ToString() == id)
                    {
                        int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        cantidadActual++;
                        row.Cells["Cantidad"].Value = cantidadActual;
                        row.Cells["Subtotal"].Value = cantidadActual * precio;
                        productoExistente = true;
                        break;
                    }
                }

                if (!productoExistente)
                {
                    dgv_productos.Rows.Add(
                        id,
                        descripcion,
                        1, // Cantidad inicial
                        precio.ToString("0.00"),
                        precio.ToString("0.00"),
                        "Eliminar"
                    );
                }
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }

            txt_buscar.Clear();
            txt_buscar.Focus();
        }

    }
}
