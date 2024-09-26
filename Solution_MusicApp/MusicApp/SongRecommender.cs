using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public enum RecommenderMode {  Random, Wildcard, KnownArtist }

    public abstract class SongRecommender
    {
        protected readonly List<Song> _lib;
        public SongRecommender(IEnumerable<Song> lib)
        {
            this._lib = new List<Song>(lib);
        }
        public abstract Song SuggestSong(IList<Song> playlist);
    }

    public class RandomRecommender : SongRecommender
    {
        public RandomRecommender(IEnumerable<Song> lib): base(lib)
        {

        }
        
        public override Song SuggestSong(IList<Song> playlist)
        {
            int randomIndex = new Random().Next(_lib.Count - 1);
            return _lib[randomIndex];
        }
 
    }

    public class WildcardRecommender : SongRecommender
    {
        
        public WildcardRecommender(IEnumerable<Song> lib): base(lib)
        {
        }

        public override Song SuggestSong(IList<Song> playlist)
        {
            var myGenre = _lib.FindAll(s => s.Genre == playlist[0].Genre);
            int randomIndex = new Random().Next(myGenre.Count - 1);
            return myGenre[randomIndex];
 
        }
    }

    public class KnownArtistRecommender : SongRecommender
    {

        public KnownArtistRecommender(IEnumerable<Song> lib) : base(lib)
        {
        }

        public override Song SuggestSong(IList<Song> playlist)
        {
            var myPerformers = playlist.Select(s => s.Perfomer.Name);
            Song s = _lib.Find(s => myPerformers.Contains(s.Perfomer.Name));
            return s;
        }
    }

}
