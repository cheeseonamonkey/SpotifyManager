using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace SpotifyManager
{
    public partial class MainForm : Form
    {

        SpotifyRequester requester = new SpotifyRequester();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Globals.LoadAppData();

            Styling.SetScheme(this);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if already have access token just try to connect 
            Forms.ConnectSplashForm splashForm = new Forms.ConnectSplashForm();
            splashForm.ShowDialog();
        }

        private void boopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Globals.AccessToken.access_token);
        }

        async Task Load()
        {
            //
            //

            //

            //you are here
        }
    }
}
