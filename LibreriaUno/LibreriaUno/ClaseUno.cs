using LibreriaDos;

namespace LibreriaUno
{
    public class ClaseUno
    {
        public string? Texto { get; set; }
        public double NumeroDecimal { get; set; }
        public int NumeroEntero { get; set; }
        public DateTime Fecha { get; set; }

        public void Procesar()
        {
            Console.WriteLine("Esta es mi LibreriaUno y su DLL1:");
            Console.WriteLine($"Texto: {Texto}, Decimal: {NumeroDecimal}, Entero: {NumeroEntero}, Fecha: {Fecha}");

            // --- Forma 1: pasando propiedades 

            ClaseDos objDos = new ClaseDos
            {
                Texto = this.Texto,
                NumeroDecimal = this.NumeroDecimal,
                NumeroEntero = this.NumeroEntero,
                Fecha = this.Fecha
            };
            objDos.MostrarDatos();

            // --- Forma 2: pasando la clase completa (this) ---
            //ClaseDos objDos = new ClaseDos();
            //objDos.Recibir(this); // Se pasa una variable tipo clase
        }
    }
}
