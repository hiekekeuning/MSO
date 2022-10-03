using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace MusicApp
{
    public static class Spotify
    {
        static readonly string key = "BQDoVYYgDOfDt3kIJ0CR4vyhT1dALbFvw1neiw6rt5rbknLb_-q9h-KYLx3NFazXwyUVUiPuc50-CXbzPUukR88T9h3rx3NEmobN-RYWnEvraTkmzyqL4Ig4lMBk4d5NETOoi5mMFTtu3CyPzqsCCZBcwfWnZXOjmDxN2SXW2g";
   

        public static async Task SearchCodeArtists()
        {
            var spotify = new SpotifyClient(key);
            var res = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.Artist, "code"));
            Console.WriteLine("\nArtists with CODE\n----------");
            foreach (var item in res.Artists.Items)
            {
                Console.Write(item.Name + "( ");
                foreach (var genre in item.Genres)
                {
                    Console.Write(genre + " ");
                }
                Console.WriteLine(")");
            }
        }

        public static async Task SearchPatternTitles()
        {
            var spotify = new SpotifyClient(key);
            var res = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.Album, "pattern"));
            Console.WriteLine("\nAlbums with PATTERNS\n----------");
            foreach (var item in res.Albums.Items)
            {
                Console.WriteLine($"{item.Name} by {item.Artists[0].Name}");
            }
        }
    }
        
   }
