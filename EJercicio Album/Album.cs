using System;
using BandClass;
using GenreClass;
using SongClass;
using System.Collections.Generic;

namespace AlbumClass
{
    public class Album 
    {   
        public string Name{get; set;}
        public Band Banda {get; set;}
        public Genre Genre {get; set;}
        public List <Song> ListOfSongs {get; set;}


        public float DevolverDuracion()
        {
            float duracionTotal = 0;
            foreach(var a in ListOfSongs)
            {   
                duracionTotal += a.lenght;                
            }
            return duracionTotal;
        }

        public Album ()
        {       
            ListOfSongs = new List<Song>();     
        }
    }

}