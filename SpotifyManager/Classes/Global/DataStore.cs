﻿using Newtonsoft.Json;
using SpotifyManager.Classes.Models.RootObjects;
using SpotifyManager.Classes.Models.SubObjects;
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
        public PlaylistList PlaylistList { get; set; }
        public Playlist SelectedPlaylist { get; set; }
        public PlaylistTracks SelectedPlaylistTracks { get; set; }
        public RecentlyPlayed SelectedRecentlyPlayed { get; set; }

        public Track SelectedTrack { get; set; }
        public TrackFeatures SelectedTrackFeatures { get; set; }


        public string MyId { get; set; }
        public bool IsMe { get; set; }


        public async Task<bool> RefreshInitialDataStore()
        {
                //todo: async webcalls
            // List<Task> webCalls = new List<Task>();

            //MyProfile:
            string myProfileJson = await Globals.Requester.GetAsync("https://api.spotify.com/v1/me");
            SelectedProfile = JsonConvert.DeserializeObject<Profile>(myProfileJson);
            
            MyId = SelectedProfile.id;

            //MyPlaylists:
            string myPlaylistsJson = await Globals.Requester.GetAsync("https://api.spotify.com/v1/me/playlists/?limit=49");
            PlaylistList = JsonConvert.DeserializeObject<PlaylistList>(myPlaylistsJson);

            //because max limit is 50, must loop
            if(PlaylistList.total > 49)
            {
                int numLoops = (int) Math.Ceiling(Convert.ToDouble( PlaylistList.total ) / 49.0);

                for (int i = 1; i < numLoops; i++)
                {
                    myPlaylistsJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/me/playlists/?limit=49&offset={49*i}");
                    PlaylistList playlistOffset = JsonConvert.DeserializeObject<PlaylistList>(myPlaylistsJson);


                    PlaylistList.items.AddRange(playlistOffset.items.ToArray());
                }
            }


            //ProfileRecentlyPlayed:
            string myRecentlyPlayedJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/me/player/recently-played?limit=10");
            SelectedRecentlyPlayed = JsonConvert.DeserializeObject<RecentlyPlayed>(myRecentlyPlayedJson);

            //Track
            await GetTrack(SelectedRecentlyPlayed.items.FirstOrDefault().track.id);

            //returns success
            return true;
        }


        public async Task GetPlaylistList(string userId)
        {
            //MyPlaylists:
            string myPlaylistsJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/users/{userId}/playlists/");
            PlaylistList = JsonConvert.DeserializeObject<PlaylistList>(myPlaylistsJson);

            //because max limit is 50, must loop
            if (PlaylistList.total > 49)
            {
                int numLoops = (int)Math.Ceiling(Convert.ToDouble(PlaylistList.total) / 49.0);

                for (int i = 1; i < numLoops; i++)
                {
                    myPlaylistsJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/me/playlists/?limit=49&offset={49 * i}");
                    PlaylistList playlistOffset = JsonConvert.DeserializeObject<PlaylistList>(myPlaylistsJson);


                    PlaylistList.items.AddRange(playlistOffset.items.ToArray());
                }
            }
        }

        public async Task GetPlaylist(string playlistId)
        {
            //sets selected playlist
            string playlistJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/playlists/{playlistId}?limit=999");
            Playlist playlist = JsonConvert.DeserializeObject<Playlist>(playlistJson);

            SelectedPlaylist = playlist;


            //gets playlist items
            string playlistTracksJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/playlists/{playlistId}/tracks?limit=99");
            PlaylistTracks playlistTracks = JsonConvert.DeserializeObject<PlaylistTracks>(playlistTracksJson);

            if (playlistTracks.total > 99)
            {
                int numLoops = (int)Math.Ceiling(Convert.ToDouble(playlistTracks.total) / 99.0);

                for (int i = 1; i < numLoops; i++)
                {
                    playlistTracksJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/playlists/{playlistId}/tracks?limit=99&offset={99*i}");
                    PlaylistList playlistTracksOffset = JsonConvert.DeserializeObject<PlaylistList>(playlistTracksJson);


                    playlistTracks.items.AddRange(playlistTracksOffset.items.ToArray());
                }
            }

            SelectedPlaylistTracks = playlistTracks;

            

        }

        public async Task GetProfile(string userId)
        {
            string myProfileJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/users/{userId}");
            SelectedProfile = JsonConvert.DeserializeObject<Profile>(myProfileJson);

        }

        public async Task GetTrack(string trackId)
        {
            string trackJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/tracks/{trackId}");
            SelectedTrack = JsonConvert.DeserializeObject<Track>(trackJson);

            await GetTrackDetails(SelectedTrack.id.ToString());

        }


        public async Task GetTrackDetails(string trackId)
        {
            string trackFeaturesJson = await Globals.Requester.GetAsync($"https://api.spotify.com/v1/audio-features/{trackId}");
            SelectedTrackFeatures = JsonConvert.DeserializeObject<TrackFeatures>(trackFeaturesJson);

            


        }

    }
}
