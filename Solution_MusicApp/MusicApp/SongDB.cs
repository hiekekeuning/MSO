using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class SongDB
    {
        public static IEnumerable<Song> LoadSongDB()
        {
            Artist bach = new("Bach");
            Artist bey = new("Beyonce");
            Artist dg = new("David Guetta");
            Artist sf = new("Suzan & Freek");

            List<Song> db = new()
            {
                new("Single ladies", bey, Genre.Pop),
                new("Run the world", bey, Genre.Pop),
                new("Matthaus", bach, Genre.Classical),
                new("I'm good", dg, Genre.Dance),
                new("Titanium", dg, Genre.Dance),
                new("As it was", new Artist("Harry Styles"), Genre.Pop),
                new("Through the looking glass", new Artist("Di-rect"), Genre.Rock),
                new("Sharks", new Artist("Imagine dragons"), Genre.Rock),
                new("Concert0", bach, Genre.Classical),
                new("Kwijt", sf, Genre.Pop),
                new("Goud", sf, Genre.Pop)
            };
            return db;
        }

       
    }
}
