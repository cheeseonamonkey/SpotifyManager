using Newtonsoft.Json;
using SpotifyManager.Classes.Models.RootObjects;
using SpotifyManager.Classes.Models.Objects;
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
using SpotifyManager.Forms.MiscForms;

namespace SpotifyManager.Forms.MainForms.Tabs
{
    public partial class ProfileTabForm : Form, iTabForm
    {
        public ProfileTabForm()
        {
            InitializeComponent();
        }

        //load me
        public async Task LoadTabForm()
        {
            Profile myProfile = Globals.DataStore.SelectedProfile;
            lblDisplayName.Text = myProfile.display_name;

            picProfile.LoadAsync(myProfile.images.FirstOrDefault().url.ToString());

            PlaylistList myPlaylists = Globals.DataStore.MyPlaylistList;
            lblNumFollowers.Text = $"{myProfile.followers.total.ToString(), 3} followers";
            lblNumPlaylists.Text = $"{myPlaylists.total, 3} playlists";

            foreach(Item item in Globals.DataStore.SelectedRecentlyPlayed.items)
            {
                dgvRecentlyPlayed.Rows.Add($"{item.track.name}", $"{item.track.artists.FirstOrDefault().name}", "Go to track");
            }

        }


        private void ProfileTabForm_Load(object sender, EventArgs e)
        {
            Styling.SetFormScheme(this);
        }

        

        private void txtSearchProfiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)(Keys.Enter))
            {
                //todo: profile search

                /*
                ProfileSearchForm profileSearchForm = new ProfileSearchForm("asdfasdfasdf");
                profileSearchForm.ShowDialog();
                */

                // ^ query fed through the constructor
            }
        }

        private void lblGoToPlaylists_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //todo: go to playlists
        }
    }
}
