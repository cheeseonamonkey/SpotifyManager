using Newtonsoft.Json;
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

        public async void RefreshTabForm()
        {
            dynamic ProfileObj = JsonConvert.DeserializeObject( await Globals.Requester.MakeRequestAsync("https://api.spotify.com/v1/me"));
        }

        private void ProfileTabForm_Load(object sender, EventArgs e)
        {
            Styling.SetScheme(this);
        }
    }
}
