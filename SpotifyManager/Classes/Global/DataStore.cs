using Newtonsoft.Json;
using SpotifyManager.Classes.Models.RootObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyManager.Classes.Global
{
    public class DataStore
    {
        public Profile MyProfile { get; set; }
        public Playlists MyPlaylists { get; set; }

        public async Task<bool> RefreshDataStore()
        {
            // List<Task> webCalls = new List<Task>();

            //MyProfile
            string myProfileJson = await Globals.Requester.MakeRequestAsync("https://api.spotify.com/v1/me");
            MyProfile = JsonConvert.DeserializeObject<Profile>(myProfileJson);

            //MyPlaylists
            string myPlaylistsJson = await Globals.Requester.MakeRequestAsync("https://api.spotify.com/v1/me/playlists");
            MyPlaylists = JsonConvert.DeserializeObject<Playlists>(myPlaylistsJson);

            //returns success
            return true;
        }
    }
}
