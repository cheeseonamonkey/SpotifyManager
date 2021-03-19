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
        public Profile SelectedProfile { get; set; }
        public PlaylistList MyPlaylistList { get; set; }
        public Playlist SelectedPlaylist { get; set; }
        public PlaylistTracks SelectedPlaylistTracks { get; set; }
        public RecentlyPlayed SelectedRecentlyPlayed { get; set; }


        public async Task<bool> RefreshDataStore()
        {
                //todo: async webcalls
            // List<Task> webCalls = new List<Task>();

            //MyProfile:
            string myProfileJson = await Globals.Requester.MakeRequestAsync("https://api.spotify.com/v1/me");
            SelectedProfile = JsonConvert.DeserializeObject<Profile>(myProfileJson);


            //MyPlaylists:
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


            //ProfileRecentlyPlayed:
            string myRecentlyPlayedJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/me/player/recently-played?limit=10");
            SelectedRecentlyPlayed = JsonConvert.DeserializeObject<RecentlyPlayed>(myRecentlyPlayedJson);


            //returns success
            return true;
        }

        public async Task GetPlaylist(string playlistId)
        {
            //sets selected playlist
            string playlistJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/playlists/{playlistId}?limit=999");
            Playlist playlist = JsonConvert.DeserializeObject<Playlist>(playlistJson);

            SelectedPlaylist = playlist;


            //gets playlist items
            string playlistTracksJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/playlists/{playlistId}/tracks?limit=99");
            PlaylistTracks playlistTracks = JsonConvert.DeserializeObject<PlaylistTracks>(playlistTracksJson);

            if (playlistTracks.total > 99)
            {
                int numLoops = (int)Math.Ceiling(Convert.ToDouble(playlistTracks.total) / 99.0);

                for (int i = 1; i < numLoops; i++)
                {
                    playlistTracksJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/playlists/{playlistId}/tracks?limit=99&offset={99*i}");
                    PlaylistList playlistTracksOffset = JsonConvert.DeserializeObject<PlaylistList>(playlistTracksJson);


                    playlistTracks.items.AddRange(playlistTracksOffset.items.ToArray());
                }
            }

            SelectedPlaylistTracks = playlistTracks;

            

        }

        public async Task GetProfile(string userId)
        {
            string myProfileJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/users/{userId}");
            SelectedProfile = JsonConvert.DeserializeObject<Profile>(myProfileJson);
        }

        
        
    }
}
