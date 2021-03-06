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
            Globals.AccessToken = JsonConvert.DeserializeObject<AccessToken>(Properties.Settings.Default.AccessToken.ToString());

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ConnectSplashForm splashForm = new Forms.ConnectSplashForm();
            splashForm.ShowDialog();
        }

        private void boopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Globals.AccessToken.access_token);
        }
    }
}
