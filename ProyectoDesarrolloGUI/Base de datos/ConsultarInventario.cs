using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoDesarrolloGUI.Base_de_datos
{
    public class ConsultarInventario
    {
        public DataTable ConsInventario() 
        { 
        SqlDataReader resultado;
        DataTable tabla = new DataTable();
        SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon= Conexion.GetInstancia().CrearConexion();
                string sql_tarea = "select * from Productos";
                SqlCommand comando = new SqlCommand(sql_tarea, sqlcon);
                sqlcon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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
        public DataTable BuscarProductoPorID(int id)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                string sql_tarea = "SELECT * FROM Productos WHERE ProductoID = @id";
                SqlCommand comando = new SqlCommand(sql_tarea, sqlcon);
                comando.Parameters.AddWithValue("@id", id);
                sqlcon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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
        public bool EliminarProductoPorID(int id)
        {
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                string sql = "DELETE FROM Productos WHERE ProductoID = @id";
                SqlCommand comando = new SqlCommand(sql, sqlcon);
                comando.Parameters.AddWithValue("@id", id);
                sqlcon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0; // Devuelve true si se eliminó algo
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
        public bool AgregarProducto(string nombre, string descripcion, decimal precioUnitario, string codigoBarras, int stock)
        {
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                string sql = "INSERT INTO Productos (NombreProducto, Descripcion, PrecioUnitario, CodigoBarras, Stock) " +
                             "VALUES (@nombre, @descripcion, @precio, @codigo, @stock)";
                SqlCommand comando = new SqlCommand(sql, sqlcon);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio", precioUnitario);
                comando.Parameters.AddWithValue("@codigo", codigoBarras);
                comando.Parameters.AddWithValue("@stock", stock);

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
