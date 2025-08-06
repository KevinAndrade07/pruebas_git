using System;

public class Perro : Animal
{
    public string Raza;

    public Perro(string nombre, int edad, string especie, string raza) 
        : base(nombre, edad, especie)
    {
        Raza = raza;
    }

    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} dice: ¡Hola Mundo, bienvenidos al tsunami!");
        Console.WriteLine($"Raza: {Raza}");

        // Edad es protected → se puede acceder
        Console.WriteLine($"Edad del perro: {Edad}");

        // Respirar es protected → se puede usar
        Respirar();

        // Especie es private ----> no se puede acceder desde aquí
        // Pensar() también es private ----> tampoco se puede usar
    }
}
