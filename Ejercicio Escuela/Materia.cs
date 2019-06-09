using System;
using System.Collections.Generic;
using AlumnoClass;
using ProfeClass;

namespace MateriaClass
{
    public class Materia
    {
        public string Name{get; set;}
        public Proffesor ProfesorTitular{get;set;}
        public Proffesor ProfesorAdjunto{get;set;}
        public List <Alumno> ListaDeAlumnos{get;set;}
        public string Horario{get;set;}
        public int NumeroAula{get;set;}
    
        public override string ToString()
        {
            return "Profesor Adjunto: " + ProfesorAdjunto.nombre + "Profesor Titular: " + ProfesorTitular.nombre + "Cantidad de Alumnos: " + ListaDeAlumnos.Count;
        }


        public Materia()
        {
            this.ListaDeAlumnos = new List <Alumno>();
        }

    }
}