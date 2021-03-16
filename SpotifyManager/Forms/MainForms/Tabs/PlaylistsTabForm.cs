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
            PlaylistList myPlayListList = Globals.DataStore.MyPlaylistList;


        } 

        private void PlaylistsTabForm_Load(object sender, EventArgs e)
        {
            Styling.SetFormScheme(this);

            cmbPlaylistSelect.Items.Clear();

            foreach (Item i in Globals.DataStore.MyPlaylistList.items)
            {
                cmbPlaylistSelect.Items.Add(i.name);
            }
        }

        public async void LoadPlaylist()
        {

        }

        private async void cmbPlaylistSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbPlaylistSelect.SelectedIndex;

            //you are here!
            //selecting playlist to fill out datagrid
            //

            string playlistid = Globals.DataStore.MyPlaylistList.items[index].id;

            await Globals.DataStore.GetPlaylist($"{playlistid}");

            LoadPlaylist();
        }
    }
}
