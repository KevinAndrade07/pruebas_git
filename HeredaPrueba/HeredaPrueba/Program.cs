using System;

class Program
{
    static void Main()
    {
        // Llamar al método estático sin crear objeto
        Animal.DefinirAnimal();

        // Crear instancia de Perro (hereda de Animal)
        Perro perro = new Perro("Firulais", 3, "Canino", "Labrador");

        // Llamar a métodos de instancia
        perro.Ladrar();
        perro.MostrarInfo();

        // Usar clase anidada
        Animal.Veterinario vet = new Animal.Veterinario();
        vet.RevisarAnimal(perro);

        Console.ReadLine();
    }
}


