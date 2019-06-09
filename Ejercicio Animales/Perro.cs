using Mamifero;
using Ejercicio_Animales;

namespace Ejercicio_Animales
{
    public class Perro : Mammal, IAnimal
    {
        public bool CanPet()
        {
            return true;
        }

        public string HacerSonido()
        {
            return "Guau";
        }
    }
}