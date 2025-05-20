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
            if (dgv_productos.Columns[e.ColumnIndex].Name == "Acción" && e.RowIndex >= 0)
            {
                // Obtener la fila
                DataGridViewRow fila = dgv_productos.Rows[e.RowIndex];

                int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value);

                if (cantidad > 1)
                {
                    cantidad--;
                    fila.Cells["Cantidad"].Value = cantidad;
                    fila.Cells["Subtotal"].Value = (cantidad * precio).ToString("0.00");
                }
                else
                {
                    dgv_productos.Rows.RemoveAt(e.RowIndex);
                }

                // Recalcular totales después de modificar cantidad
                CalcularSubtotal();
            }
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
            CalcularSubtotal();
        }

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarProducto();
                e.Handled = true;
                e.SuppressKeyPress = true; // Evita el beep o salto de línea
            }
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_productos.Columns[e.ColumnIndex].Name == "Accion")
            {
                DialogResult result = MessageBox.Show("¿Deseas eliminar este producto de la venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgv_productos.Rows[e.RowIndex];
                    int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);

                    if (cantidadActual > 1)
                    {
                        cantidadActual--;
                        row.Cells["Cantidad"].Value = cantidadActual;
                        row.Cells["Subtotal"].Value = cantidadActual * precioUnitario;
                    }
                    else
                    {
                        dgv_productos.Rows.RemoveAt(e.RowIndex);
                    }

                    CalcularSubtotal();
                }
            }
        }

        private void CalcularSubtotal()
        {
            decimal subtotal = 0;

            // 1. Sumar subtotales de productos
            foreach (DataGridViewRow row in dgv_productos.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    decimal filaSubtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                    subtotal += filaSubtotal;
                }
            }

            // 2. Calcular IVA (16%)
            decimal iva = subtotal * 0.16m;

            // 3. Sumar total antes del descuento
            decimal totalSinDescuento = subtotal + iva;

            // 4. Obtener descuento desde el textbox (porcentaje)
            decimal descuentoPorcentaje = 0;
            if (decimal.TryParse(btn_descuento.Text, out decimal descuentoUsuario))
            {
                if (descuentoUsuario >= 0 && descuentoUsuario <= 100)
                {
                    descuentoPorcentaje = descuentoUsuario;
                }
            }

            // 5. Calcular el monto del descuento
            decimal montoDescuento = totalSinDescuento * (descuentoPorcentaje / 100);

            // 6. Calcular total final con descuento
            decimal totalConDescuento = totalSinDescuento - montoDescuento;

            // 7. Mostrar valores en los TextBoxes
            btn_Subtotal.Text = $"${subtotal:0.00}";
            txt_iva.Text = $"{iva:0.00}";
            txt_Total.Text = $"{totalConDescuento:0.00}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_descuento_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tb_Efectivo.Text, out decimal efectivo))
            {
                if (decimal.TryParse(txt_Total.Text, out decimal total))
                {
                    if (efectivo >= total)
                    {
                        decimal cambio = efectivo - total;
                        tb_cambio.Text = cambio.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("El efectivo es menor que el total a pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb_cambio.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El total no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad de efectivo válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RegistrarV_Click(object sender, EventArgs e)
        {
            if (dgv_productos.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(tb_Efectivo.Text, out decimal efectivo) || efectivo <= 0)
            {
                MessageBox.Show("Ingrese un monto válido de efectivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txt_Total.Text, out decimal total))
            {
                MessageBox.Show("El total es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (efectivo < total)
            {
                MessageBox.Show("El efectivo ingresado es menor al total a pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal descuento = 0;
            decimal iva = 0;
            decimal cambio = efectivo - total;

            decimal.TryParse(btn_descuento.Text, out descuento);
            decimal.TryParse(txt_iva.Text, out iva);

            // 1. Registrar encabezado de la venta
            VentasDAL ventasDAL = new VentasDAL();
            int ventaID = ventasDAL.InsertarVenta(DateTime.Now, total, "Efectivo", 1, total - descuento, descuento, iva);

            if (ventaID == 0)
            {
                MessageBox.Show("Error al registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dgv_productos.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar la fila vacía del DataGridView

                int productoID = Convert.ToInt32(row.Cells["ProductoID"].Value);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                if (cantidad == 0)
                {
                    MessageBox.Show($"El producto con ID {productoID} tiene una cantidad de 0. Verifica los datos antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                decimal precioUnitario = subtotal / cantidad;

                ventasDAL.InsertarDetalleVenta(ventaID, productoID, cantidad, precioUnitario, subtotal);
                ventasDAL.DescontarStock(productoID, cantidad);
            }


            MessageBox.Show("Venta registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 4. Limpiar formulario
            dgv_productos.Rows.Clear();
            tb_Efectivo.Clear();
            tb_cambio.Clear();
            btn_descuento.Text = "0";
            txt_iva.Text = "0.00";
            btn_Subtotal.Text = "0.00";
            txt_Total.Text = "0.00";
        }
    }
}
