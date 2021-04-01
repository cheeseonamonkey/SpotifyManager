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
        

        public MainForm()
        {
            InitializeComponent();

            Styling.SetFormScheme(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        public async Task ConnectToSpotify()
        {
            

            if (Globals.Connected == false)
            {
                if(Globals.AccessToken.IsSet)
                {           //  using saved access token

                    //tests access code
                    bool testGet = await Globals.Requester.TestGet();

                            //  TESTING:
                    if(testGet)
                    {//test succeed, continue!

                        Globals.Connected = true;
                        InitTabs();

                    }
                    else
                    {//test failed, reset token and start authorization over

                        Globals.AccessToken.ResetAccessToken();
                        await ConnectToSpotify();
                    }

                }//end saved token IF
                else
                {           //  generating new access token

                    //opens splash form to login
                    ConnectSplashForm connectSplashForm = new ConnectSplashForm();

                    connectSplashForm.ShowDialog();
                    connectSplashForm.Close();

                    //test access token
                    bool testGet = await Globals.Requester.TestGet();

                            //  TESTING:
                    if (testGet)
                    {//test succeed, continue!

                        Globals.Connected = true;
                        InitTabs();

                    }
                    else
                    {//splash login failed, alert user and do not continute

                        MessageBox.Show("Error logging into Spotify.");
                    }


                }//end generate new access token IF

                if (Globals.Connected)
                    connectToolStripMenuItem.Text = "Log Out";
                else
                    connectToolStripMenuItem.Text = "Connect to Spotify";



            }//end main log in IF
            else//connected is true
            {           //  logging out:

                connectToolStripMenuItem.Text = "Connect to Spotify";

                Globals.AccessToken.ResetAccessToken();


                DeInitTabs();

                
            }

            

        }//end ConnectToSpotify() method


        private async void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ConnectToSpotify();
            
        }

        private void boopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //debug button
        }

        public static async Task LoadTabs()
        {
            await Globals.DataStore.RefreshInitialDataStore();

            foreach (iTabForm tabform in Globals.TabForms)
            {
                tabform.LoadTabForm();
            }

            Globals.DataStore.MyId = Globals.DataStore.SelectedProfile.id;
        }

        //loads in tabs initially then calls Refresh()
        public async void InitTabs()
        {
            

            Globals.TabForms = new List<iTabForm>();

            //place child tabforms in each tab:
            ProfileTabForm profileTabForm = new ProfileTabForm();
            InitTab(tabProfile, profileTabForm);
            Globals.TabForms.Add(profileTabForm);
            
            PlaylistsTabForm playlistTabForm = new PlaylistsTabForm();
            InitTab(tabPlaylists, playlistTabForm);
            Globals.TabForms.Add(playlistTabForm);

            TrackTabForm trackTabForm = new TrackTabForm();
            InitTab(tabTrack, trackTabForm);
            Globals.TabForms.Add(trackTabForm);

            StatsTabForm statsTabForm = new StatsTabForm();
            InitTab(tabStats, statsTabForm);
            Globals.TabForms.Add(statsTabForm);

            //refresh all the tabs:
            await LoadTabs();
            


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

        //unloads tab init
        public void DeInitTabs()
        {
            foreach(iTabForm tabForm in Globals.TabForms)
            {
                DeInitTab(tabForm);
            }

            void DeInitTab(iTabForm itabForm)
            {
                Form tabForm = itabForm as Form;

                tabForm.Close();
                tabForm.Dispose();

            }
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            Styling.SetFormScheme(this);
        }

        private void copyAcessTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Globals.AccessToken.access_token);
        }

        private void resetAccessTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.AccessToken.ResetAccessToken();
            
        }

        public void ChangeTab(int num)
        {
            //todo:
            //make sure is loading our playlists if necessary, not leaving whatever is possibly already loaded there
            tabControl.SelectedTab = tabControl.TabPages[num];
        }

        private void setAccessTokenMenuItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Globals.AccessToken.SetAccessToken(setAccessTokenMenuItem.Text);
            }
        }

        private async void boopToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*
            string content = "{\"uris\":[\r\n\t\"spotify:track:3Dy8QNZ77cre9ThUPRguy0\",\r\n\t\"spotify:track:1TSAV7rDKNEqH4ApQbJlzq\",\r\n\t\"spotify:track:0BqlU7mN83X4jQlfzM3Z3i\",\r\n\t\"spotify:track:2APaWLyP3drx0CIodMhKHd\",\r\n\t\"spotify:track:2Dv7PTwSoB17f3VFDIKw8m\",\r\n\t\"spotify:track:1Qdnvn4XlmZANCVy3XjrQo\",\r\n\t\"spotify:track:6mFkJmJqdDVQ1REhVfGgd1\",\r\n\t\"spotify:track:4sIPWACRol7zzc5RbRSt60\",\r\n\t\"spotify:track:3ZjiEk0ndl063kalc2stx9\",\r\n\t\"spotify:track:56Z7hbyMrndw1naxb6I5Oi\",\r\n\t\"spotify:track:6gSKswfcoWvaadqvuMF3Y7\",\r\n\t\"spotify:track:3clX2NMmjaAHmBjeTSa9vV\",\r\n\t\"spotify:track:3M8FzayQWtkvOhqMn2V4T2\",\r\n\t\"spotify:track:7vRdcsmD92oErIQDnmp60e\",\r\n\t\"spotify:track:61hJaUtcgY2buPeBZz4jq7\",\r\n\t\"spotify:track:6M0Ef3mfbK34lw9QxV1LFK\",\r\n\t\"spotify:track:3DYZKxjG8SZrWpVcoUilqQ\",\r\n\t\"spotify:track:3xTk4fMLcpoLkItpiI30vD\",\r\n\t\"spotify:track:4RXpgGM7A4Hg7cFBoH5KyF\",\r\n\t\"spotify:track:0a4agFmqHXxcZl1nho1BxM\",\r\n\t\"spotify:track:2AlhagDeOuRTZMRg89YQJl\",\r\n\t\"spotify:track:6Kn5yzAyOw3jf4Y5a6d1Oq\",\r\n\t\"spotify:track:0iYXDjcE2fOpJiy0ob1Kk3\",\r\n\t\"spotify:track:5mfA2CBzQeGiTk9wFItCsS\",\r\n\t\"spotify:track:01ga3tkz9Z5l2tE2DsvUO8\",\r\n\t\"spotify:track:05qauoa1cfrL4MNesfgilA\",\r\n\t\"spotify:track:0OrpW2p1jJj1qpsmevRIB2\",\r\n\t\"spotify:track:0lUlrI1sF4vFU9DpxTB1bV\",\r\n\t\"spotify:track:35ycG8vBnHjAfw1Q5WDl76\"\r\n\r\n]}";
            Globals.Requester.PostAsync("https://api.spotify.com/v1/playlists/1XMrKphRQroVfO3t0vfXE9/tracks", content);
            */
        }
    }


}
