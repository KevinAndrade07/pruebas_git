using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un texto para generar SHA256: ");
        string textoOriginal = Console.ReadLine();

        string hashGenerado = ObtenerSHA256(textoOriginal);

        Console.WriteLine("\nTexto original: " + textoOriginal);
        Console.WriteLine("Hash SHA256: " + hashGenerado);

        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }

    static string ObtenerSHA256(string texto)
    {
        // Convertir el texto a bytes
        byte[] bytesTexto = Encoding.UTF8.GetBytes(texto);

        // Crear instancia de SHA256
        using (SHA256 sha256 = SHA256.Create())
        {
            // Obtener el hash en forma de arreglo de bytes
            byte[] hashBytes = sha256.ComputeHash(bytesTexto);

            // Convertir a texto hexadecimal
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2")); 
            }

            return sb.ToString();
        }
    }
}
