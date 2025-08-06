using System;
using LibreriaUno;
using LibreriaDos;

namespace ProyectoCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseUno objUno = new ClaseUno
            {
                Texto = "Hola probando proyecto CMD",
                NumeroDecimal = 111.55,
                NumeroEntero = 78,
                Fecha = DateTime.Now
            };

            objUno.Procesar();

            Console.ReadKey();
        }


    }
}
