using Mamifero;
using Ejercicio_Animales;

namespace Ejercicio_Animales
{
    public class Gato : Mammal
    {
        public bool CanPet()
        {
            return true;
        }

        public string HacerSonido()
        {
            return "Miau";
        }
    }
}