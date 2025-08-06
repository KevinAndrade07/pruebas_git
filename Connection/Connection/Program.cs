using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        var service = new EstudianteService();
        service.RegistrarEstudiante("PruebaConexion02", "1112023334", "pruebaconexion02@email.com");

        Console.WriteLine("Se imprime mensaje...");
        Console.ReadKey();
    }
}

public class EstudianteService
{
    // Usamos la cadena de conexión estática de tu clase ConexionDB
    private string _connectionString = Connection.ConexionDB.ConexionBD.CadenaConexion;

    public void RegistrarEstudiante(string nombre, string documento, string email)
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand("sp_gestiones_estudiante", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros de entrada
            cmd.Parameters.AddWithValue("@opcion", "R"); // R: Registrar
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@documento_identidad", documento);
            cmd.Parameters.AddWithValue("@email_estudiante", email);

            // Parámetro de salida
            SqlParameter paramError = new SqlParameter("@error", SqlDbType.VarChar, 100)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramError);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

                string mensaje = paramError.Value?.ToString();
                Console.WriteLine("📤 Resultado del SP: " + (string.IsNullOrEmpty(mensaje) ? "Sin mensaje" : mensaje));
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al ejecutar SP: " + ex.Message);
            }
        }

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
