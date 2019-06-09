using System;
using CirculoClass;
using TrianguloClass;
using RectanguloClass;

namespace Ejercicio_Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangle = new Triangulo();
            triangle.Altura = 3;
            triangle.Base = 2;
            triangle.Lado2 = 1;
            triangle.Lado3 = 6;
            Console.WriteLine("El Area del triangulo es: " + triangle.CalcularArea() + "El perimetro del triangulo es: " + triangle.CalcularPerimetro());

            Rectangulo rectangle = new Rectangulo();
            rectangle.Altura = 5;
            rectangle.Ancho = 6;
            Console.WriteLine("El Area del rectangulo es: " + rectangle.CalcularArea() + "El perimetro del rectángulo es: " + rectangle.CalcularPerimetro());



        }
    }
}
