using System;
using Ejercicio_Figuras;

namespace RectanguloClass
{
    public class Rectangulo : IForma
    {
        public int Altura{get;set;}
        public int Ancho{get;set;}

        public double CalcularArea()
        {
            return Altura*Ancho;
        }

        public double CalcularPerimetro()
        {
            return (2*Altura) + (2*Ancho);
        }
    }
}