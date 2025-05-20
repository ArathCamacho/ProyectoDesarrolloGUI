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
            if (string.IsNullOrWhiteSpace(txt_IdTicket.Text) ||
            string.IsNullOrWhiteSpace(txt_Cantidad.Text) ||
            string.IsNullOrWhiteSpace(txt_Motivo.Text) ||
            string.IsNullOrWhiteSpace(cmb_TipoDevolucion.Text) ||
            dgv_DetallesVenta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Completa todos los campos y selecciona un producto para realizar la devolución.",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int ventaID = Convert.ToInt32(txt_IdTicket.Text);
                int cantidadDevuelta = Convert.ToInt32(txt_Cantidad.Text);
                string motivo = txt_Motivo.Text.Trim();
                string tipo = cmb_TipoDevolucion.Text.Trim();

                // Obtener el ProductoID desde la fila seleccionada del DataGridView
                DataGridViewRow filaSeleccionada = dgv_DetallesVenta.SelectedRows[0];
                int productoID = Convert.ToInt32(filaSeleccionada.Cells["ProductoID"].Value);
                int cantidadVendida = Convert.ToInt32(filaSeleccionada.Cells["CantidadVendida"].Value);

                // Validar que la cantidad a devolver no supere la cantidad vendida
                if (cantidadDevuelta > cantidadVendida)
                {
                    MessageBox.Show("La cantidad a devolver no puede ser mayor a la cantidad vendida.",
                                    "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Realizar la devolución
                DevolucionesBD db = new DevolucionesBD();
                db.InsertarDevolucion(ventaID, productoID, cantidadDevuelta, motivo, tipo);

                if (tipo.ToLower().Contains("stock") || tipo.ToLower().Contains("producto"))
                {
                    db.ReintegrarStock(productoID, cantidadDevuelta);
                }

                MessageBox.Show("Devolución registrada correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la devolución: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_buscarticket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_IdTicket.Text))
            {
                MessageBox.Show("Ingresa el ID del ticket.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int ventaID = Convert.ToInt32(txt_IdTicket.Text);
                DevolucionesBD db = new DevolucionesBD();
                DataTable venta = db.ObtenerDatosVenta(ventaID);

                if (venta.Rows.Count > 0)
                {
                    txt_FechaCompra.Text = venta.Rows[0]["FechaVenta"].ToString();
                    txt_MetodoPago.Text = venta.Rows[0]["MetodoPago"].ToString();
                    dgv_DetallesVenta.DataSource = venta;
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna venta con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
