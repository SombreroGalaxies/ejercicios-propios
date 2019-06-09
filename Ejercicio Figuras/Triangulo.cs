using System;
using Ejercicio_Figuras;

namespace TrianguloClass
{
    public class Triangulo : IForma 
    {
        public int Base{get;set;}
        public int Lado2{get;set;}
        public int Lado3{get;set;}
        public int Altura{get;set;}

        public double CalcularArea()
        {
            return (Base*Altura)/2;
        }

        public double CalcularPerimetro()
        {
            return Base + Lado2 + Lado3;
        }
    }
}