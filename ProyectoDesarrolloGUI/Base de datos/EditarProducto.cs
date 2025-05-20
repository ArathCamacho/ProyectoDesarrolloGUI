using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoDesarrolloGUI.Base_de_datos
{
    public class EditarProducto
    {
        public void ActualizarProducto(int id, string nombre, string descripcion, decimal precio, string codigoBarras, int stock)
        {
            using (SqlConnection sqlcon = Conexion.GetInstancia().CrearConexion())
            {
                string sql = "UPDATE Productos SET NombreProducto = @nombre, Descripcion = @descripcion, PrecioUnitario = @precio, CodigoBarras = @codigo, Stock = @stock WHERE ProductoID = @id";
                using (SqlCommand comando = new SqlCommand(sql, sqlcon))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@codigo", codigoBarras);
                    comando.Parameters.AddWithValue("@stock", stock);

                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
