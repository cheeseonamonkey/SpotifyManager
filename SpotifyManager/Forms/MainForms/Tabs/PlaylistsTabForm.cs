using SpotifyManager.Classes.Models.RootObjects;
using SpotifyManager.Classes.Models.SubObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            foreach(Item item in playlistTracks.items)
            {
                dgvPlaylist.Rows.Add(item.track.name, item.added_at , item.added_by.id, "Go to",  item.track.id, item.added_by.id);
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
            //go to song button
            if(dgvPlaylist.CurrentCell.ColumnIndex == 2)
            {
                string userId = dgvPlaylist.Rows[e.RowIndex].Cells[5].Value.ToString();
                await Globals.DataStore.GetProfile(userId);
                await Globals.DataStore.GetPlaylistList(userId);


                await Globals.TabForms[0].LoadTabForm();
                await Globals.TabForms[1].LoadTabForm();

            }

            

            

            
        }
    }
}
