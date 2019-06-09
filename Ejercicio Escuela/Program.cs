using System;
using PersonaClass;
using MateriaClass;
using ProfeClass;
using AlumnoClass;
using System.Collections.Generic;

namespace Ejercicio_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Proffesor profe1 = new Proffesor();
            profe1.nombre = "Octavio";
            profe1.DNI = 38865598;

            Proffesor profe2 = new Proffesor();
            profe2.nombre = "Juan";
            profe2.DNI = 45622516;

            Proffesor profe3 = new Proffesor();
            profe3.nombre = "Javier";
            profe3.DNI = 12365489;

            Proffesor profe4 = new Proffesor();
            profe4.nombre = "Mabel";
            profe4.DNI = 38862845;

            Alumno alumno1 = new Alumno();
            alumno1.nombre = "Alumno1";
            
            Alumno alumno2 = new Alumno();
            alumno2.nombre = "Alumno2";

            Alumno alumno3 = new Alumno();
            alumno3.nombre = "Alumno3";

            Alumno alumno4 = new Alumno();
            alumno4.nombre = "Alumno4";


            Materia matematica = new Materia();
            matematica.Name = "Matemática";
            matematica.ProfesorAdjunto = profe1;
            matematica.ProfesorTitular = profe2;
            matematica.ListaDeAlumnos.Add(alumno1);
            matematica.ListaDeAlumnos.Add(alumno2);
            matematica.ListaDeAlumnos.Add(alumno3);
            matematica.ListaDeAlumnos.Add(alumno4);
            matematica.Horario = "11:00hs";
            matematica.NumeroAula = 5;

            Materia lengua = new Materia();
            lengua.Name = "Prácticas del Lenguaje";
            lengua.ProfesorTitular = profe3;
            lengua.ProfesorAdjunto = profe4;
            lengua.ListaDeAlumnos.Add(alumno1);
            lengua.ListaDeAlumnos.Add(alumno4);
            lengua.Horario = "13:00";
            lengua.NumeroAula = 4;

            Console.WriteLine("Matemática: " + matematica.ToString());
            Console.WriteLine("Lengua: " + lengua.ToString());

            Console.ReadLine();




        }
    }
}
