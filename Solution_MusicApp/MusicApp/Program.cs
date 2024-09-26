using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace MusicApp
{
    public class Program
    {
        
        public static async Task Main()
        {
            // load DB
            var songDB = new List<Song>(SongDB.LoadSongDB());
            
            // Load preferences
            var recommenderSetting = RecommenderMode.KnownArtist;

            SongRecommender recommender = recommenderSetting switch
            {
                RecommenderMode.Random      => new RandomRecommender(songDB),
                RecommenderMode.Wildcard    => new WildcardRecommender(songDB),
                RecommenderMode.KnownArtist => new KnownArtistRecommender(songDB),
                _                           => new RandomRecommender(songDB),
            }; 
            
            // Create playlist
            var p = new Playlist(recommender);
            p.AddSong(new Song("Crazy what love can do", new Artist("David Guetta"), Genre.Pop));
            p.AddSong(new Song("As it was", new Artist("Harry Styles"), Genre.Pop));
            p.AddSong(new Song("Nemo", new Artist("Nightwish"), Genre.Metal));
            p.AddSong(new Song("Words", new Artist("Alesso"), Genre.Dance));
            p.AddSong(new Song("Snap", new Artist("Rosa Linn"), Genre.Rock));

            // Start playlist
            p.Start();

            // for the API exercise
            // await Spotify.SearchCodeArtists();
            // await Spotify.SearchPatternTitles();
        }
   

    
    }

    

    
  

    

    

}

