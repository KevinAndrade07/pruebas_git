using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ConexionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cadena según tu configuración (Windows Authentication)
            string connectionString = "Server=TS-WSI-013\\SQLEXPRESS;Database=universidad;Trusted_Connection=True;TrustServerCertificate=True;";


            // Valores de prueba para insertar
            string nombre = "PruebaConexion02";
            string documento = "1231231234";
            string email = "pruebaconexion02@email.com";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_gestiones_estudiante", conn);
                cmd.CommandType = CommandType.StoredProcedure;

               
                cmd.Parameters.AddWithValue("@opcion", "R"); // R: Registrar
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@documento_identidad", documento);
                cmd.Parameters.AddWithValue("@email_estudiante", email);

                
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
                    Console.WriteLine("Resultado del SP: " + (string.IsNullOrEmpty(mensaje) ? "Sin mensaje" : mensaje));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar SP: " + ex.Message);
                }
            }

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
