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
            //go to user button
            if (dgvPlaylist.CurrentCell.ColumnIndex == 2)
            {
                string userId = dgvPlaylist.Rows[e.RowIndex].Cells[4].Value.ToString();
                await Globals.DataStore.GetProfile(userId);
                await Globals.DataStore.GetPlaylistList(userId);


                await Globals.TabForms[0].LoadTabForm();
                await Globals.TabForms[1].LoadTabForm();

            }
            else if (dgvPlaylist.CurrentCell.ColumnIndex == 0)
            {

                string trackId = dgvPlaylist.Rows[e.RowIndex].Cells[3].Value.ToString();

                await Globals.DataStore.GetTrack(trackId);

                Globals.TabForms[2].LoadTabForm();


            }






        }

        private async void lnkExportPlaylist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbPlaylistSelect.SelectedIndex != -1)
            {
                fileDialogExportPlaylist.ShowDialog();

                string savePath = fileDialogExportPlaylist.FileName;

                string saveData = "{\"uris\":[\n";

                foreach (Item item in Globals.DataStore.SelectedPlaylistTracks.items)
                {
                    saveData += $"\t\"{item.track.uri}\",\n";
                }

                saveData += "\n]}";

                saveData = saveData.Remove(saveData.LastIndexOf(','), 1);

                File.WriteAllText(savePath, saveData);
            }
        }

        public async Task<Playlist> CreateNewPlaylist(string name, string description)
        {
            string playlistPostContent = "{\r\n  \"name\": \"" + name    + "\",\r\n  \"description\": \"" + description + "\",\r\n  \"public\": true\r\n}";

            string responseJson = await Globals.Requester.PostAsync("https://api.spotify.com/v1/users/1226203341/playlists", playlistPostContent);

            Playlist playlistCreated = JsonConvert.DeserializeObject<Playlist>(responseJson);

            return playlistCreated;
        }

        public async void PopulatePlaylistTracks(string playlistId, string contentUris)
        {
            //response data is unnecessary spotify server stuff, we don't need it 
            await Globals.Requester.PostAsync($"https://api.spotify.com/v1/playlists/{playlistId}", contentUris);
        }

        

        private async void lnkImportPlaylist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialogImportPlaylist.ShowDialog();


            string filePath = fileDialogImportPlaylist.FileName;
            string fileDataJson = File.ReadAllText(filePath);
            //dynamic fileData = JsonConvert.DeserializeObject(fileDataJson);

            NewPlaylistForm newPlaylistForm = new NewPlaylistForm();

            newPlaylistForm.ShowDialog();

            string playlistName = newPlaylistForm.Name_;
            string playlistDescription = newPlaylistForm.Description;

            Playlist playlistCreated = await CreateNewPlaylist(playlistName, playlistDescription);

            string targetId = playlistCreated.id;

            //error 405 method not allowed?
            PopulatePlaylistTracks(targetId, fileDataJson);

            MessageBox.Show("Playlist imported!");



        }
    }
}