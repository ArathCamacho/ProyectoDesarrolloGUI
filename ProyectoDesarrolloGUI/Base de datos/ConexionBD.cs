using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoDesarrolloGUI
{
    public class Conexion
    {
        private string Basedatos;
        private static Conexion Con = null;

        // Constructor privado para implementar el patrón Singleton
        private Conexion()
        {
            this.Basedatos = "Server=LAPTOPARATH\\SQLEXPRESS;Database=gorramania;Trusted_Connection=True;";
        }

        // Método para crear y devolver una conexión a la base de datos
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = this.Basedatos; // Se usa directamente la cadena correcta
            }
            catch (Exception ex)
            {
                Cadena = null;
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Mantiene el rastreo de la excepción original
            }
            return Cadena;
        }

        // Implementación del patrón Singleton
        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}