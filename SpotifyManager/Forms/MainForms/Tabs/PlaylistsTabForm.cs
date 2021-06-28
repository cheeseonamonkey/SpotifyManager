using Newtonsoft.Json;
using SpotifyManager.Classes.Models.RootObjects;
using SpotifyManager.Classes.Models.SubObjects;
using SpotifyManager.Forms.MiscForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyManager.Forms.MainForms.Tabs
{
    public partial class PlaylistsTabForm : Form, iTabForm
    {
        public PlaylistsTabForm()
        {
            InitializeComponent();
        }

        public async Task LoadTabForm()
        {
            PlaylistList myPlayListList = Globals.DataStore.PlaylistList;

            cmbPlaylistSelect.Items.Clear();

            foreach (Item i in Globals.DataStore.PlaylistList.items)
            {
                cmbPlaylistSelect.Items.Add(i.name);
            }

        }

        private void PlaylistsTabForm_Load(object sender, EventArgs e)
        {
            Styling.SetFormScheme(this);


        }

        public void LoadPlaylist()
        {
            //playlist:

            Playlist playlist = Globals.DataStore.SelectedPlaylist;

            lblPlaylistName.Text = playlist.name;
            //lblCreatedOn.Text = $"Created on: ";
            lblPlaylistFollowers.Text = $"{playlist.followers.total.ToString()} followers";

            lblAuthor.Text = $"By: {playlist.owner.display_name.ToString()}";

            if (playlist.collaborative)
                ckbCollab.Checked = true;
            else
                ckbCollab.Checked = false;

            if (playlist.@public)
                ckbPublic.Checked = true;
            else
                ckbPublic.Checked = false;


            //playlist tracks:

            PlaylistTracks playlistTracks = Globals.DataStore.SelectedPlaylistTracks;

            foreach (Item item in playlistTracks.items)
            {
                dgvPlaylist.Rows.Add(item.track.name, item.added_at, item.added_by.id, item.track.id, item.added_by.id);
            }

        }

        private async void cmbPlaylistSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPlaylist.Rows.Clear();

            int index = cmbPlaylistSelect.SelectedIndex;

            string playlistid = Globals.DataStore.PlaylistList.items[index].id;

            await Globals.DataStore.GetPlaylist($"{playlistid}");

            LoadPlaylist();
        }

        private async void dgvPlaylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //go to user link
            if (dgvPlaylist.CurrentCell.ColumnIndex == 2)
            {
                string userId = dgvPlaylist.Rows[e.RowIndex].Cells[4].Value.ToString();
                await Globals.DataStore.GetProfile(userId);
                await Globals.DataStore.GetPlaylistList(userId);


                await Globals.TabForms[0].LoadTabForm();
                await Globals.TabForms[1].LoadTabForm();

            }
            //go to track link
            else if (dgvPlaylist.CurrentCell.ColumnIndex == 0)
            {

                string trackId = dgvPlaylist.Rows[e.RowIndex].Cells[3].Value.ToString();

                await Globals.DataStore.GetTrack(trackId);

                Globals.TabForms[2].LoadTabForm();


            }






        }



        public string GetUriListJson(object paramObject = null)
        {
            if (paramObject == null)
            {
                string saveData = "{\"uris\":[\n";

                foreach (Item item in Globals.DataStore.SelectedPlaylistTracks.items)
                {
                    saveData += $"\t\"{item.track.uri}\",\n";
                }

                saveData += "\n]}";

                saveData = saveData.Remove(saveData.LastIndexOf(','), 1);

                return saveData;

            }
            else if (paramObject is List<string>)
            {
                List<string> uris = paramObject as List<string>;

                string saveData = "{\"uris\":[\n";

                foreach (string s in uris)
                {
                    saveData += $"\t\"{s}\",\n";
                }

                saveData += "\n]}";

                saveData = saveData.Remove(saveData.LastIndexOf(','), 1);

                return saveData;
            }

            return null;

        }

        private async void lnkExportPlaylist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbPlaylistSelect.SelectedIndex != -1)
            {
                fileDialogExportPlaylist.ShowDialog();

                string savePath = fileDialogExportPlaylist.FileName;

                string saveData = GetUriListJson();

                File.WriteAllText(savePath, saveData);
            }
        }

        public async Task<Playlist> CreateNewPlaylist(string name, string description)
        {
            string playlistPostContent = "{\r\n  \"name\": \"" + name + "\",\r\n  \"description\": \"" + description + "\",\r\n  \"public\": true\r\n}";

            string responseJson = await Globals.Requester.PostAsync("https://api.spotify.com/v1/users/1226203341/playlists", playlistPostContent);

            Playlist playlistCreated = JsonConvert.DeserializeObject<Playlist>(responseJson);

            return playlistCreated;
        }

        public async Task PopulatePlaylistTracks(string playlistId, string contentUris)
        {
            //response data is unnecessary spotify server stuff, we don't need it 
            await Globals.Requester.PostAsync($"https://api.spotify.com/v1/playlists/{playlistId}/tracks", contentUris);
        }



        private async void lnkImportPlaylist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialogImportPlaylist.ShowDialog();


            string filePath = fileDialogImportPlaylist.FileName;
            string fileDataJson = File.ReadAllText(filePath);

            //needed to count tracks:
            dynamic fileData = JsonConvert.DeserializeObject(fileDataJson);

            NewPlaylistForm newPlaylistForm = new NewPlaylistForm(fileData.uris.Count);

            newPlaylistForm.ShowDialog();

            if (newPlaylistForm.DialogResult == DialogResult.OK)
            {
                string playlistName = newPlaylistForm.Name_;
                string playlistDescription = newPlaylistForm.Description;

                Playlist playlistCreated = await CreateNewPlaylist(playlistName, playlistDescription);

                string targetId = playlistCreated.id;


                PopulatePlaylistTracks(targetId, fileDataJson);

                MessageBox.Show("Playlist imported!");

                newPlaylistForm.Dispose();
            }


        }

        public List<string> GetPlaylistTrackIDs()
        {
            List<string> trackIDs = new List<string>();
            foreach (DataGridViewRow row in dgvPlaylist.Rows)
            {
                trackIDs.Add(row.Cells[3].Value.ToString());
            }

            return trackIDs;
        }

        /*
        public async Task<Recommendation> GetRecommendations()
        {

        }
        */

        private async void lnkGenerateSimilar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int firstPlaylistCount = Globals.DataStore.SelectedPlaylist.tracks.total;

            NewPlaylistForm newPlaylistForm = new NewPlaylistForm(firstPlaylistCount);
            newPlaylistForm.ShowDialog();

            string playlistName = newPlaylistForm.Name_;
            string playlistDescription = newPlaylistForm.Description;
            //int numTracks = newPlaylistForm.NumTracks;

            PlaylistTracks playlistTracks = Globals.DataStore.SelectedPlaylistTracks;

            List<string> seedTrackIDs = GetPlaylistTrackIDs();
            List<string> newTrackUris = new List<string>();
            
            
            for (int i = 0; i < firstPlaylistCount; i+=5)
            {
                
                //TODO: only seeding w/ first 5 tracks for now

                string recomUrl = $"https://api.spotify.com/v1/recommendations?limit=5&seed_tracks=";

                for (int ii = 0; ii < 5; ii += 1)
                {
                    if(seedTrackIDs.Count > i+ii)
                        recomUrl += $"{seedTrackIDs[i + ii]},";
                }

                if(recomUrl.Contains(','))
                    recomUrl = recomUrl.Remove(recomUrl.LastIndexOf(','));

                string recommendationJson = await Globals.Requester.GetAsync(recomUrl);
                Recommendation recommendation = JsonConvert.DeserializeObject<Recommendation>(recommendationJson);

                foreach(Track t in recommendation.tracks)
                {
                    newTrackUris.Add(t.uri);
                }

            }

            string uriPostContent = GetUriListJson(newTrackUris);
            
            Playlist newPlaylist = await CreateNewPlaylist(playlistName, playlistDescription);

            await PopulatePlaylistTracks(newPlaylist.id, uriPostContent);

            /*
            //this is working
            //maybe lets put this in a method with parameters so it can be used for the other generation methods
            //if that won't work or is too time-consuming it can be easily done in each event also 
            */

            newPlaylistForm.Dispose();
        }

        private async void lnkGenerateObscure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int firstPlaylistCount = Globals.DataStore.SelectedPlaylist.tracks.total;

            NewPlaylistForm newPlaylistForm = new NewPlaylistForm(firstPlaylistCount);
            newPlaylistForm.ShowDialog();

            string playlistName = newPlaylistForm.Name_;
            string playlistDescription = newPlaylistForm.Description;
            //int numTracks = newPlaylistForm.NumTracks;

            PlaylistTracks playlistTracks = Globals.DataStore.SelectedPlaylistTracks;

            List<string> seedTrackIDs = GetPlaylistTrackIDs();
            List<string> newTrackUris = new List<string>();


            for (int i = 0; i < firstPlaylistCount; i += 5)
            {

                

                string recomUrl = $"https://api.spotify.com/v1/recommendations?limit=5&seed_tracks=";

                for (int ii = 0; ii < 5; ii += 1)
                {
                    if (seedTrackIDs.Count > i + ii)
                        recomUrl += $"{seedTrackIDs[i + ii]},";
                }

                if (recomUrl.Contains(','))
                    recomUrl = recomUrl.Remove(recomUrl.LastIndexOf(','));

                recomUrl += "&target_popularity=0";

                string recommendationJson = await Globals.Requester.GetAsync(recomUrl);
                Recommendation recommendation = JsonConvert.DeserializeObject<Recommendation>(recommendationJson);

                foreach (Track t in recommendation.tracks)
                {
                    newTrackUris.Add(t.uri);
                }

            }

            string uriPostContent = GetUriListJson(newTrackUris);

            Playlist newPlaylist = await CreateNewPlaylist(playlistName, playlistDescription);

            await PopulatePlaylistTracks(newPlaylist.id, uriPostContent);



            newPlaylistForm.Dispose();
        }

        private async void lnkLikeEveryTrack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //you are here
            //maxing out at 50 tracks

            List<string> ids = GetPlaylistTrackIDs();

            string url = "https://api.spotify.com/v1/me/tracks?ids=";
            
            foreach(string s in ids)
            {
                url += $"{s},";
            }

            url = url.Remove(url.LastIndexOf(','));

            string returnedResult = await Globals.Requester.PutAsync(url, "");
        }
    }
}