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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoDesarrolloGUI
{
    public partial class Devolucion : Form
    {
        private int productoIDSeleccionado = -1;

        public Devolucion()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txt_IdTicket.Clear();
            txt_Cantidad.Clear();
            txt_Motivo.Clear();
            txt_FechaCompra.Clear();
            txt_MetodoPago.Clear();
            cmb_TipoDevolucion.SelectedIndex = -1;
            dgv_DetallesVenta.DataSource = null;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_IdTicket.Text, out int ventaID))
            {
                MessageBox.Show("ID de ticket inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productoIDSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_Cantidad.Text, out int cantidadDevuelta))
            {
                MessageBox.Show("Ingrese una cantidad válida para la devolución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoDevolucion = cmb_TipoDevolucion.SelectedItem?.ToString() ?? "";

            try
            {
                var devolucionesBD = new DevolucionesBD();
                devolucionesBD.RegistrarDevolucion(ventaID, productoIDSeleccionado, cantidadDevuelta, txt_Motivo.Text, tipoDevolucion);

                MessageBox.Show("Devolución realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar controles después de confirmar
                txt_Cantidad.Text = "";
                txt_Motivo.Text = "";
                cmb_TipoDevolucion.SelectedIndex = -1;

                // Refrescar la información del ticket si quieres actualizar el dgv u otros datos
                btn_buscarticket.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar devolución: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class DetalleVentaView
        {
            public int ProductoID { get; set; }
            public string Descripcion { get; set; }
            public int CantidadVendida { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Subtotal { get; set; }
        }
        private void btn_buscarticket_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_IdTicket.Text, out int idTicket))
            {
                MessageBox.Show("Por favor, ingrese un ID de ticket válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var devolucionesBD = new DevolucionesBD();

            try
            {
                var venta = devolucionesBD.ObtenerVentaPorID(idTicket);

                if (venta == null)
                {
                    MessageBox.Show("No se encontró ninguna venta con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpia campos y grilla
                    txt_FechaCompra.Text = "";
                    txt_MetodoPago.Text = "";
                    dgv_DetallesVenta.DataSource = null;
                    dgv_DetallesVenta.Columns.Clear();
                    return;
                }

                // Mostrar fecha y método de pago
                txt_FechaCompra.Text = venta.Value.FechaCompra.ToString("yyyy-MM-dd HH:mm:ss");
                txt_MetodoPago.Text = venta.Value.MetodoPago;

                // Obtener detalles y llenar DataGridView
                var detalles = devolucionesBD.ObtenerDetalleVentaPorID(idTicket);

                dgv_DetallesVenta.DataSource = null;
                dgv_DetallesVenta.Columns.Clear();

                if (detalles.Count > 0)
                {
                    dgv_DetallesVenta.DataSource = detalles;

                    // Opcional: ajustar ancho columnas
                    dgv_DetallesVenta.AutoResizeColumns();
                    dgv_DetallesVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No hay productos asociados a esta venta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_DetallesVenta.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_DetallesVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_DetallesVenta.Rows[e.RowIndex];
                productoIDSeleccionado = Convert.ToInt32(fila.Cells["ProductoID"].Value);

                txt_Cantidad.Text = fila.Cells["CantidadVendida"].Value.ToString();
            }
        }

        private void dgv_DetallesVenta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DetallesVenta.SelectedRows.Count > 0)
            {
                var fila = dgv_DetallesVenta.SelectedRows[0];
                productoIDSeleccionado = Convert.ToInt32(fila.Cells["ProductoID"].Value);
                string descripcion = fila.Cells["Descripcion"].Value.ToString();
                int cantidadVendida = Convert.ToInt32(fila.Cells["CantidadVendida"].Value);
                txt_Cantidad.Text = cantidadVendida.ToString();
                txt_Motivo.Text = "";
                cmb_TipoDevolucion.SelectedIndex = -1;

                txt_Cantidad.Enabled = true;
                txt_Motivo.Enabled = true;
                cmb_TipoDevolucion.Enabled = true;
                btnConfirmar.Enabled = true;
            }
        }
    }
}
