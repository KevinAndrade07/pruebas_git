using System;

public partial class Animal
{
    public string Nombre;
    protected int Edad;
    private string Especie;

    public Animal(string nombre, int edad, string especie)
    {
        Nombre = nombre;
        Edad = edad;
        Especie = especie;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"(Privado) Especie: {Especie}");
    }
}
