using System;

namespace Ejercicio_Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro doggo = new Perro ();
            Console.WriteLine("El sonido del perro es: " + doggo.HacerSonido());
            if(doggo.CanPet())
            {
                Console.WriteLine("El perro se puede acariciar");
            }
            else
            {
                Console.WriteLine("El perro no se puede acariciar)");
            }
            

            Gato cat = new Gato();
            Console.WriteLine("El sonido del gato es: " + cat.HacerSonido());
            if(cat.CanPet())
            {
                Console.WriteLine("El gato se puede acariciar");
            }
            else
            {
                Console.WriteLine("El gato no se puede acariciar");
            }

            Dinosaurio dino = new Dinosaurio();
            Console.WriteLine("El sonido del dinosaurio es: " + dino.HacerSonido());
            if(dino.CanPet())
            {
                Console.WriteLine("El dinosaurio se puede acariciar");
            }
            else
            {
                Console.WriteLine("El dinosaurio no se puede acariciar)");
            }

            Console.ReadLine();
        }
    }
}
