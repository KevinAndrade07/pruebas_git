using System;

public partial class Animal
{
    // Método protegido: accesible en clases hijas
    protected void Respirar()
    {
        Console.WriteLine("El animal respira.");
    }

    // Método privado: solo accesible dentro de Animal
    private void Pensar()
    {
        Console.WriteLine("El animal piensa (privado).");
    }

    // Método estático: se llama sin crear objeto
    public static void DefinirAnimal()
    {
        Console.WriteLine("Un animal es un ser vivo que puede moverse, respirar y sentir.");
    }

    // Clase anidada: se accede desde fuera con Animal.Veterinario
    public class Veterinario
    {
        public void RevisarAnimal(Animal a)
        {
            Console.WriteLine($"El veterinario revisa a {a.Nombre}");
            a.Respirar(); // Puede acceder a métodos protected
        }
    }
}

