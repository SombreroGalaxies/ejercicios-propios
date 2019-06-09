using System;
using BandClass;
using GenreClass;
using SongClass;
using AlbumClass;
using System.Collections.Generic;

namespace EjerciciosJuliten
{
    class Program
    {
        static void Main(string[] args)
        {
            Album TheBoyWhoKnewTooMuch = new Album();
            Band mika = new Band();
            mika.name= "MIKA";   
            Genre pop = new Genre();
            pop.nameOfGenre = "POP";
            TheBoyWhoKnewTooMuch.Genre = pop;
            TheBoyWhoKnewTooMuch.Banda = mika;
            TheBoyWhoKnewTooMuch.Name = "The boy who knew too much";       
              

            Song first = new Song();
            first.name = "Primer Temita";
            first.lenght = 1.23F;

            Song second = new Song();
            second.name = "Segundo Temita";
            second.lenght = 3.56F;


            Album InaTidalWaveOfMystery = new Album();
            InaTidalWaveOfMystery.Name = "In a Tidal Wave of Mystery";
            Band capitalCities = new Band();
            capitalCities.name = "Capital Cities";
            InaTidalWaveOfMystery.Genre = pop;

            Song firstCap = new Song();
            firstCap.name = "primero de capi";
            firstCap.lenght = 6.3F;

            Song secondCap = new Song();
            secondCap.name = "segundo de capi";
            secondCap.lenght = 2.30F;

            InaTidalWaveOfMystery.ListOfSongs.Add(firstCap);
            InaTidalWaveOfMystery.ListOfSongs.Add(secondCap);

            TheBoyWhoKnewTooMuch.ListOfSongs.Add(first);
            TheBoyWhoKnewTooMuch.ListOfSongs.Add(second);

            float duracion = TheBoyWhoKnewTooMuch.DevolverDuracion();
            Console.WriteLine("La duración de "+ TheBoyWhoKnewTooMuch.Name + " es " + duracion);

            float duration = InaTidalWaveOfMystery.DevolverDuracion();
            Console.WriteLine("La duración de "+ InaTidalWaveOfMystery.Name + " es " + duration);

            Console.ReadLine();

        }

    }
}
