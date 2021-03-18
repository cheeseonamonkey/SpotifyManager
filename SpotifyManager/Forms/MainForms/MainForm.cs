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

        public async Task LoadTabs()
        {
            await Globals.DataStore.RefreshDataStore();

            foreach (iTabForm tabform in TabForms)
            {
                tabform.LoadTabForm();
            }
        }

        //loads in tabs initially then calls Refresh()
        public async void InitTabs()
        {
            //place child tabforms in each tab:
            ProfileTabForm profileTabForm = new ProfileTabForm();
            InitTab(tabProfile, profileTabForm);
            TabForms.Add(profileTabForm);

            PlaylistsTabForm playlistTabForm = new PlaylistsTabForm();
            InitTab(tabPlaylists, playlistTabForm);
            TabForms.Add(playlistTabForm);

            StatsTabForm statsTabForm = new StatsTabForm();
            InitTab(tabStats, statsTabForm);
            TabForms.Add(statsTabForm);

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
            foreach(iTabForm tabForm in TabForms)
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
    }


}
