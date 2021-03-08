using Newtonsoft.Json;
using SpotifyManager.Classes.Models.RootObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyManager.Classes.Global
{
    public class DataStore
    {
        public Profile MyProfile { get; set; }
        public PlaylistList MyPlaylistList { get; set; }
        public Playlist SelectedPlaylist { get; set; }

        public async Task<bool> RefreshDataStore()
        {
            // List<Task> webCalls = new List<Task>();

            DataGridView a = new DataGridView();

            //MyProfile
            string myProfileJson = await Globals.Requester.MakeRequestAsync("https://api.spotify.com/v1/me");
            MyProfile = JsonConvert.DeserializeObject<Profile>(myProfileJson);

            //MyPlaylists
            string myPlaylistsJson = await Globals.Requester.MakeRequestAsync("https://api.spotify.com/v1/me/playlists");
            MyPlaylistList = JsonConvert.DeserializeObject<PlaylistList>(myPlaylistsJson);

            //returns success
            return true;
        }

        public async Task SetPlaylist(string playlistId)
        {
            string playlistJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/playlists/{playlistId}?limit=999");
            Playlist playlist = JsonConvert.DeserializeObject<Playlist>(playlistJson);
            
            SelectedPlaylist = playlist;

        }
    }
}
