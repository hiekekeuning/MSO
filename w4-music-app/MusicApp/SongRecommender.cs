using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public enum RecommenderMode {  Random, Wildcard, KnownArtist }


    class SongRecommender
    {
        private readonly List<Song> _lib;

        public SongRecommender(IEnumerable<Song> lib)
        {
            this._lib = new List<Song>(lib);
        }

        public Song SuggestRandom(IList<Song> playlist)
        {
            int randomIndex = new Random().Next(_lib.Count-1);
            return _lib[randomIndex];
        }
        public Song SuggestWildcard(IList<Song> playlist)
        {
            var s = _lib.FindAll(s => s.Genre == playlist[0].Genre);
            return SuggestRandom(s);
        }

        public Song SuggestFromKnownArtist(IList<Song> playlist)
        {
            var myPerformers = playlist.Select(s => s.Perfomer.Name);
            Song s = _lib.Find(s => myPerformers.Contains(s.Perfomer.Name));
            return s;
        }
    }


}
