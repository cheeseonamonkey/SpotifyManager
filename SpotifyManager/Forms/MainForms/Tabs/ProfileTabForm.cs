using Newtonsoft.Json;
using SpotifyManager.Classes.Models.RootObjects;
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
    public partial class ProfileTabForm : Form, iTabForm
    {
        public ProfileTabForm()
        {
            InitializeComponent();
        }

        public async Task LoadTabForm()
        {
            Profile myProfile = Globals.DataStore.MyProfile;
            lblDisplayName.Text = myProfile.display_name;

            picProfile.LoadAsync(myProfile.images.FirstOrDefault().url.ToString());

            PlaylistList myPlaylists = Globals.DataStore.MyPlaylistList;
            lblNumFollowers.Text = $"{myProfile.followers.total.ToString(), 3} followers";
            lblNumPlaylists.Text = $"{myPlaylists.total, 3} playlists";

        }

        private void ProfileTabForm_Load(object sender, EventArgs e)
        {
            Styling.SetFormScheme(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
