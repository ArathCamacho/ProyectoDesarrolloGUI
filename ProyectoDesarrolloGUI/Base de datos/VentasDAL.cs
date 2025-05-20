using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyectoDesarrolloGUI.Base_de_datos;


namespace ProyectoDesarrolloGUI.Base_de_datos
{
    public class VentasDAL
    {
        public int InsertarVenta(DateTime fecha, decimal total, string metodoPago, int empleadoID, decimal subtotal, decimal descuento, decimal iva)
        {
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                string sql = @"INSERT INTO Ventas (FechaVenta, TotalVenta, MetodoPago, EmpleadoID, Subtotal, Descuento, IVA) 
                               OUTPUT INSERTED.VentaID 
                               VALUES (@fecha, @total, @metodoPago, @empleadoID, @subtotal, @descuento, @iva)";

                SqlCommand comando = new SqlCommand(sql, sqlcon);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@metodoPago", metodoPago);
                comando.Parameters.AddWithValue("@empleadoID", empleadoID);
                comando.Parameters.AddWithValue("@subtotal", subtotal);
                comando.Parameters.AddWithValue("@descuento", descuento);
                comando.Parameters.AddWithValue("@iva", iva);

                sqlcon.Open();
                int ventaID = Convert.ToInt32(comando.ExecuteScalar());
                return ventaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public bool InsertarDetalleVenta(int ventaID, int productoID, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                string sql = @"INSERT INTO DetallesVenta (VentaID, ProductoID, CantidadVendida, PrecioUnitario, Subtotal)
               VALUES (@ventaID, @productoID, @cantidad, @precioUnitario, @subtotal)";

                SqlCommand comando = new SqlCommand(sql, sqlcon);
                comando.Parameters.AddWithValue("@ventaID", ventaID);
                comando.Parameters.AddWithValue("@productoID", productoID);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                comando.Parameters.AddWithValue("@subtotal", subtotal);

                sqlcon.Open();
                int filas = comando.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public bool DescontarStock(int productoID, int cantidad)
        {
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                string sql = "UPDATE Productos SET Stock = Stock - @cantidad WHERE ProductoID = @productoID";

                SqlCommand comando = new SqlCommand(sql, sqlcon);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@productoID", productoID);

                sqlcon.Open();
                int filas = comando.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }
    }

}
