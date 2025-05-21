using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static ProyectoDesarrolloGUI.Devolucion;

namespace ProyectoDesarrolloGUI.Base_de_datos
{
    public class DevolucionesBD
    {
        public (DateTime FechaCompra, string MetodoPago)? ObtenerVentaPorID(int idTicket)
        {
            var conexion = Conexion.GetInstancia().CrearConexion();
            string consulta = "SELECT FechaVenta, MetodoPago FROM dbo.Ventas WHERE VentaID = @VentaID";

            using (SqlCommand cmd = new SqlCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("@VentaID", idTicket);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime fechaCompra = reader.GetDateTime(0);
                            string metodoPago = reader.GetString(1);
                            return (fechaCompra, metodoPago);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public List<DetalleVentaView> ObtenerDetalleVentaPorID(int idTicket)
        {
            var lista = new List<DetalleVentaView>();
            var conexion = Conexion.GetInstancia().CrearConexion();

            string consulta = @"
            SELECT dv.ProductoID, p.NombreProducto AS Descripcion, dv.CantidadVendida, dv.PrecioUnitario, dv.Subtotal
            FROM dbo.DetallesVenta dv
            INNER JOIN dbo.Productos p ON dv.ProductoID = p.ProductoID
            WHERE dv.VentaID = @VentaID";

            using (SqlCommand cmd = new SqlCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("@VentaID", idTicket);

                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new DetalleVentaView
                        {
                            ProductoID = reader.GetInt32(0),
                            Descripcion = reader.GetString(1),
                            CantidadVendida = reader.GetInt32(2),
                            PrecioUnitario = reader.GetDecimal(3),
                            Subtotal = reader.GetDecimal(4)
                        });
                    }
                }
                conexion.Close();
            }
            return lista;
        }
        public void RegistrarDevolucion(int ventaID, int productoID, int cantidadDevuelta, string motivo, string tipoDevolucion)
        {
            var conexion = Conexion.GetInstancia().CrearConexion();

            string consulta = @"
        INSERT INTO dbo.Devoluciones 
        (VentaID, ProductoID, CantidadDevuelta, FechaDevolucion, Motivo, TipoDevolucion)
        VALUES
        (@VentaID, @ProductoID, @CantidadDevuelta, @FechaDevolucion, @Motivo, @TipoDevolucion)";

            using (SqlCommand cmd = new SqlCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("@VentaID", ventaID);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.Parameters.AddWithValue("@CantidadDevuelta", cantidadDevuelta);
                cmd.Parameters.AddWithValue("@FechaDevolucion", DateTime.Now);
                cmd.Parameters.AddWithValue("@Motivo", motivo);
                cmd.Parameters.AddWithValue("@TipoDevolucion", tipoDevolucion);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
    
}
