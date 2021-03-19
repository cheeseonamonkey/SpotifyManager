using Newtonsoft.Json;
using SpotifyManager.Classes.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyManager
{
    public class Globals
    {
        public static string spotifyClient = "66e1cc6f62154340966581033cbe84e8";
        public static string spotifySecret = "1142189b8c504c07a1ddfc088eeb361b";
        //obfuscate secret key?

        public static AccessToken AccessToken { get; set; }

        public static SpotifyRequester Requester { get; set; } = new SpotifyRequester();
        public static DataStore DataStore { get; set; } = new DataStore();

        public static List<iTabForm> TabForms { get; set; }

        public static bool Connected { get; set; } = false;

        

        public static void SaveAppData()
        {
            Properties.Settings.Default.AccessToken = JsonConvert.SerializeObject(AccessToken);

            Properties.Settings.Default.Save();

            
        }

        public static void LoadAppData()
        {
            Globals.AccessToken = JsonConvert.DeserializeObject<AccessToken>( Properties.Settings.Default.AccessToken.ToString() );
        }
    }
}

