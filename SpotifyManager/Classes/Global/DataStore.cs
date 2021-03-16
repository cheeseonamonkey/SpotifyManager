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
                //todo: async webcalls
            // List<Task> webCalls = new List<Task>();

            //MyProfile
            string myProfileJson = await Globals.Requester.MakeRequestAsync("https://api.spotify.com/v1/me");
            MyProfile = JsonConvert.DeserializeObject<Profile>(myProfileJson);

            //MyPlaylists
            string myPlaylistsJson = await Globals.Requester.MakeRequestAsync("https://api.spotify.com/v1/me/playlists/?limit=49");
            MyPlaylistList = JsonConvert.DeserializeObject<PlaylistList>(myPlaylistsJson);

            //because max limit is 50, must loop
            if(MyPlaylistList.total > 49)
            {
                int numLoops = (int) Math.Ceiling(Convert.ToDouble( MyPlaylistList.total ) / 49.0);

                for (int i = 1; i < numLoops; i++)
                {
                    myPlaylistsJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/me/playlists/?limit=49&offset={49*i}");
                    PlaylistList playlistOffset = JsonConvert.DeserializeObject<PlaylistList>(myPlaylistsJson);


                    MyPlaylistList.items.AddRange(playlistOffset.items.ToArray());
                }
            }

            //returns success
            return true;
        }

        public async Task GetPlaylist(string playlistId)
        {
            string playlistJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/playlists/{playlistId}?limit=999");
            Playlist playlist = JsonConvert.DeserializeObject<Playlist>(playlistJson);
            
            SelectedPlaylist = playlist;

        }
    }
}
