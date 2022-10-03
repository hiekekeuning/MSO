using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public enum Continent { NorthAmerica, SouthAmerica, Europe, Asia, Africa }

    public class SmartRecommender
    {
        private IEnumerable<Song> _songDB;
        public SmartRecommender(IEnumerable<Song> songDB)
        {
            _songDB = songDB;
        }
        public Tuple<string, string> DoSmartRecommendation(int age, Continent continent)
        {
            //.. smart algorithm
            var selected = _songDB.First(s => s.NrOfPlays > 3);
            return new Tuple<string,string>(selected.Title, selected.Perfomer.Name);
        }

    }
}
