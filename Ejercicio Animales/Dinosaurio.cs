using ReptileClass;
using Ejercicio_Animales;

namespace Ejercicio_Animales
{
    public class Dinosaurio : Reptile, IAnimal
    {
        public bool CanPet()
        {
            return false;
        }

        public string HacerSonido()
        {
            return "Rawr";
        }
    }
}