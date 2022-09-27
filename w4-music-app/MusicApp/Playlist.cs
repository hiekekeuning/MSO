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
        
        public void AddSong(Song s) 
        { 
            list.Add(s); 
        }

        public void Start(RecommenderMode recMode)
        {
            Console.WriteLine("*Playlist started*");

            foreach (Song s in list)
            {
                s.Play();
            }

            var rec = new SongRecommender(SongDB.LoadSongDB());
            Song recSong;
            switch (recMode)
            {
                case RecommenderMode.Random:
                    recSong = rec.SuggestRandom(list);
                    break;
                case RecommenderMode.Wildcard:
                    recSong = rec.SuggestWildcard(list);
                    break;
                case RecommenderMode.KnownArtist:
                    recSong = rec.SuggestFromKnownArtist(list);
                    break;
                default:
                    recSong = rec.SuggestRandom(list);
                    break;
            }
            Console.WriteLine("*Playlist finished*");
            recSong.Play();
        }

    }
}

