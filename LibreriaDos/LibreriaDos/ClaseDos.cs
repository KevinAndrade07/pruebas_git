using System;
using LibreriaUno;

namespace LibreriaDos
{
    public class ClaseDos
    {
        // --- Forma 1: Recibir propiedades directamente ---

        public string? Texto { get; set; }
        public double NumeroDecimal { get; set; }
        public int NumeroEntero { get; set; }
        public DateTime Fecha { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine("Aquí está la DLL2:");
            Console.WriteLine($"Texto: {Texto}, Decimal: {NumeroDecimal}, Entero: {NumeroEntero}, Fecha: {Fecha}");
        }


        //// --- Forma 2: Recibir variable tipo clase ---
        //public void Recibir(ClaseUno obj)
        //{
        //    Console.WriteLine("Aquí está la DLL2:");
        //    Console.WriteLine($"Texto: {obj.Texto}, Decimal: {obj.NumeroDecimal}, Entero: {obj.NumeroEntero}, Fecha: {obj.Fecha}");
        //}
    }
}
