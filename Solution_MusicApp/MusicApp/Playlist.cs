using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Playlist
    {
        private readonly List<Song> list = new();
        private SongRecommender _songRec;

        public Playlist(SongRecommender songRec)
        {
            _songRec = songRec;
        }
        public void AddSong(Song s) 
        { 
            list.Add(s); 
        }

        public void Start()
        {
            Console.WriteLine("*Playlist started*");

            foreach (Song s in list)
            {
                s.Play();
            }

            var recSong = _songRec.SuggestSong(list);
            Console.WriteLine("*Playlist finished*");
            recSong.Play();
        }

    }
}

