using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpotifyManager.Forms
{
    public partial class ConnectSplashForm : Form
    {
        public ConnectSplashForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblSplash.Text = "All credentials are only handled by Spotify's servers, and Spotify will let you specify which information is released on the next page. All code is open source and available for review.";

            string authorizationUrl = $"https://accounts.spotify.com/authorize?client_id={Globals.spotifyClient}&redirect_uri=http://localhost/&response_type=code";

            authBrowser.Navigate(authorizationUrl);

        }

        private async void authBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //String rootDirectory = Path.Substring(0, LastIndexOf("/"));
            string url = authBrowser.Url.AbsoluteUri.ToString() ;
            
            string rootUrl = url.Substring(0, url.LastIndexOf('/')+1);

            if (rootUrl.Contains("localhost"))
            {
                //extracts access code from url parameters
                string code = url.Replace(rootUrl, "").Replace("?code=", "").Replace("#_=_", "");

                authBrowser.Visible = false;

                lblSplash.Text = "Received authorization code.\nRequesting access token...";

                Globals.AccessToken = await SpotifyRequester.GetAccessTokenAsync(code);

                lblSplash.Text += "\nAccess token received!";

                Globals.SaveAppData();
                Globals.Connected = true;

                this.Close();


            }


        }
    }
}
