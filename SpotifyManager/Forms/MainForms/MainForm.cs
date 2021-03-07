using Newtonsoft.Json;
using SpotifyManager.Forms;
using SpotifyManager.Forms.MainForms.Tabs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyManager
{
    public partial class MainForm : Form
    {

        
        
        public List<iTabForm> TabForms { get; set; } = new List<iTabForm>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Styling.SetScheme(this);
        }

        public async Task ConnectToSpotify()
        {
            Globals.LoadAppData(); 

            if (Globals.Connected == false)
            {
                //use saved token:
                if (Globals.AccessToken.access_token != null && Globals.AccessToken.access_token != "")
                {
                    //test token
                    Globals.Connected = await SpotifyRequester.TestGet();

                    //if saved token is invalid, start over
                    if (Globals.Connected == false)
                    {
                        Globals.ResetAccessToken();
                        await ConnectToSpotify();
                    }
                }

                //generate new token:
                else
                {
                    Forms.ConnectSplashForm splashForm = new Forms.ConnectSplashForm();
                    splashForm.ShowDialog();
                    splashForm.Close();

                    //test token
                    Globals.Connected = await SpotifyRequester.TestGet();

                    if (Globals.Connected == false)
                    {
                        MessageBox.Show("er 1");
                    }

                //
                //connect success
                if (Globals.Connected)
                {
                    connectToolStripMenuItem.Text = "Log out";

                    InitTabs();

                    await RefreshTabs();

                }
                else if (Globals.Connected == false)
                {
                    //connect failure
                }

            }
            else if (Globals.Connected == true)
            {
                //logout button
            }
        }




        private async void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ConnectToSpotify();
        }

        private void boopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Globals.AccessToken.access_token);
        }

        public async Task RefreshTabs()
        {
            foreach(iTabForm tabform in TabForms)
            {
                tabform.RefreshTabForm();
            }
        }

        //loads in tabs initially then calls Refresh()
        public void InitTabs()
        {

            ProfileTabForm profileTabForm = new ProfileTabForm();
            InitTab(tabProfile, profileTabForm);
            TabForms.Add(profileTabForm);

            PlaylistsTabForm playlistTabForm = new PlaylistsTabForm();
            InitTab(tabPlaylists, playlistTabForm);
            TabForms.Add(playlistTabForm);

            StatsTabForm statsTabForm = new StatsTabForm();
            InitTab(tabStats, statsTabForm);
            TabForms.Add(statsTabForm);


            //puts child form into tab
            void InitTab(TabPage tabPage, Form childForm)
            {
                //tab setup
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                tabPage.Controls.Add(childForm);
                childForm.Visible = true;
            }

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            Styling.SetScheme(this);
        }
    }
}
