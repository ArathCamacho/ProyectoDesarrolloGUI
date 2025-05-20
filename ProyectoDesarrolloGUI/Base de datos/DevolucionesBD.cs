using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoDesarrolloGUI.Base_de_datos
{
    public class DevolucionesBD
    {
        // 1. Obtener datos de la venta por ID de ticket
        public DataTable ObtenerDatosVenta(int ventaID)
        {
            using (SqlConnection sqlcon = Conexion.GetInstancia().CrearConexion())
            {
                string sql = @"SELECT V.FechaVenta, V.MetodoPago, V.Total, DV.ProductoID, P.NombreProducto, DV.CantidadVendida, DV.Subtotal
                               FROM Ventas V
                               INNER JOIN DetallesVenta DV ON V.VentaID = DV.VentaID
                               INNER JOIN Productos P ON DV.ProductoID = P.ProductoID
                               WHERE V.VentaID = @ventaID";

                using (SqlCommand comando = new SqlCommand(sql, sqlcon))
                {
                    comando.Parameters.AddWithValue("@ventaID", ventaID);
                    sqlcon.Open();

                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // 2. Insertar una devolución
        public void InsertarDevolucion(int ventaID, int productoID, int cantidadDevuelta, string motivo, string tipoDevolucion)
        {
            using (SqlConnection sqlcon = Conexion.GetInstancia().CrearConexion())
            {
                string sql = @"INSERT INTO Devoluciones (VentaID, ProductoID, CantidadDevuelta, FechaDevolucion, Motivo, TipoDevolucion)
                               VALUES (@ventaID, @productoID, @cantidadDevuelta, GETDATE(), @motivo, @tipoDevolucion)";

                using (SqlCommand comando = new SqlCommand(sql, sqlcon))
                {
                    comando.Parameters.AddWithValue("@ventaID", ventaID);
                    comando.Parameters.AddWithValue("@productoID", productoID);
                    comando.Parameters.AddWithValue("@cantidadDevuelta", cantidadDevuelta);
                    comando.Parameters.AddWithValue("@motivo", motivo);
                    comando.Parameters.AddWithValue("@tipoDevolucion", tipoDevolucion);

                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // 3. Actualizar el stock (opcional: si es devolución con reintegro al inventario)
        public void ReintegrarStock(int productoID, int cantidad)
        {
            using (SqlConnection sqlcon = Conexion.GetInstancia().CrearConexion())
            {
                string sql = "UPDATE Productos SET Stock = Stock + @cantidad WHERE ProductoID = @productoID";

                using (SqlCommand comando = new SqlCommand(sql, sqlcon))
                {
                    comando.Parameters.AddWithValue("@productoID", productoID);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);

                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
