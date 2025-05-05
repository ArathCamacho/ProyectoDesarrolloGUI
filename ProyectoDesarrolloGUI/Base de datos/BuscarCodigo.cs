using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoDesarrolloGUI.Base_de_datos
{
    public class BuscarCodigo
    {
        public DataTable BuscarProductoPorID(int id)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                string sql = "SELECT * FROM Productos WHERE ProductoID = @id";
                SqlCommand comando = new SqlCommand(sql, sqlcon);
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
    }
}
