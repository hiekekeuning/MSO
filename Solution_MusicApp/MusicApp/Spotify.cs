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
        static readonly string key = "BQCv2T427krZQ2Gby4U0eacFQr65S09sMolcXB-qEK7QpXpgE-rDBR5IMGYniPegFmjXGZUIr4DGyX1yuo3qaANDiGx9tF56RX9F9n_7HmPfM4jWjOc3R_I3AlT2iQfBiU6H_u_DuDICmQeJ4-qoSLgLc0KEGuO8poKcXjHwNg";
   

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
