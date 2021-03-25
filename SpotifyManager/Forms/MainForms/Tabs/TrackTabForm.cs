using Newtonsoft.Json;
using SpotifyManager.Classes.Models.RootObjects;
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

namespace SpotifyManager.Forms.MainForms.Tabs
{
    public partial class TrackTabForm : Form, iTabForm
    {
        public TrackTabForm()
        {
            InitializeComponent();
        }

        public async Task LoadTabForm()
        {
            //what a mess 
            //you are here
            //we implemented shit in the wrong place, needs to go through DataStore global variables

            lblTrackName.Text = track.name;

            lblEnergy.Text = (trackFeatures.energy * 100).ToString() + "%";
            lblLiveness.Text = (trackFeatures.liveness * 100).ToString() + "%";
            lblSpeechiness.Text = (trackFeatures.speechiness * 100).ToString() + "%";
            lblDanceability.Text = (trackFeatures.danceability * 100).ToString() + "%";
            lblInstrumentalness.Text = (trackFeatures.instrumentalness * 100).ToString() + "%";
            lblValence.Text = (trackFeatures.valence * 100).ToString() + "%";
            lblAcousticness.Text = (trackFeatures.acousticness * 100).ToString() + "%";

            lblTempo.Text = (trackFeatures.tempo).ToString();
            lblTimeSignature.Text = (trackFeatures.time_signature).ToString();
            lblLoudness.Text = (trackFeatures.loudness).ToString();
        }

        public async Task LoadTrack(string trackId)
        {

            string trackJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/tracks/{trackId}");
            Track track = JsonConvert.DeserializeObject<Track>(trackJson);

            LoadTrack(track);

        }



        public async Task LoadTrack(Track track)
        {
            string trackFeaturesJson = await Globals.Requester.MakeRequestAsync($"https://api.spotify.com/v1/audio-features/{track.id}");
            TrackFeatures trackFeatures = JsonConvert.DeserializeObject<TrackFeatures>(trackFeaturesJson);

            lblTrackName.Text = track.name;

            lblEnergy.Text = (trackFeatures.energy * 100).ToString() + "%";
            lblLiveness.Text = (trackFeatures.liveness * 100).ToString() + "%";
            lblSpeechiness.Text = (trackFeatures.speechiness * 100).ToString() + "%";
            lblDanceability.Text = (trackFeatures.danceability * 100).ToString() + "%";
            lblInstrumentalness.Text = (trackFeatures.instrumentalness * 100).ToString() + "%";
            lblValence.Text = (trackFeatures.valence * 100).ToString() + "%";
            lblAcousticness.Text = (trackFeatures.acousticness * 100).ToString() + "%";

            lblTempo.Text = (trackFeatures.tempo).ToString();
            lblTimeSignature.Text = (trackFeatures.time_signature).ToString();
            lblLoudness.Text = (trackFeatures.loudness).ToString();



        }


        private void TrackTabForm_Load(object sender, EventArgs e)
        {
            Styling.SetFormScheme(this);


        }
    }
}
