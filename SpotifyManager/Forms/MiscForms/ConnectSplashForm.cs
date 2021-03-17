using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            lblSplash.Text = "All credentials are handled only by Spotify's servers and are never visible to this application. Spotify will let you specify which information is released on the next page. All code is open source and available for review.";

            string authorizationUrl = $"https://accounts.spotify.com/authorize?client_id={Globals.spotifyClient}&redirect_uri=http://localhost/&response_type=code&scope=user-read-recently-played";

            authBrowser.Navigate(authorizationUrl);

        }

        private async void authBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //todo: access token bug
            //to reprdouce, log out and back in
            //console output shows access token not present

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

        private void lnkClearCookies_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(authBrowser.Document != null)
                authBrowser.Document.Cookie.Remove(0, authBrowser.Document.Cookie.Length);

            string[] theCookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            foreach (string currentFile in theCookies)
            {
                try
                {
                    System.IO.File.Delete(currentFile);
                }
                catch (Exception ex)
                {
                }
            }

            ClearFolder(new DirectoryInfo(Environment.GetFolderPath
      (Environment.SpecialFolder.InternetCache)));

            void ClearFolder(DirectoryInfo folder)
            {

                foreach (FileInfo file in folder.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch (Exception ex) // files used by another process exception
                    {

                    }
                }
                foreach (DirectoryInfo subfolder in folder.GetDirectories())
                {
                    ClearFolder(subfolder);
                }

            }

        }
    }
}
