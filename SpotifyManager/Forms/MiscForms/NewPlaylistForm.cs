using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyManager.Forms.MiscForms
{
    public partial class NewPlaylistForm : Form
    {
        public bool Okay { get; set; }
        public string Name_ { get; set; }
        public string Description { get; set; }
        public bool IsVarLength { get; set; }
        public int NumTracks { get; set; }
        

        public NewPlaylistForm(int numTracks, bool isVarLength = false)
        {
            InitializeComponent();
            IsVarLength = isVarLength;
            NumTracks = numTracks;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Name_ = txtName.Text;
            this.Description = txtDescription.Text;
            this.NumTracks = Convert.ToInt32( nmbNumTracks.Value );
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void NewPlaylistForm_Load(object sender, EventArgs e)
        {
            if(IsVarLength)
            {
                nmbNumTracks.Enabled = true;
            }
            nmbNumTracks.Value = NumTracks;
        }
    }
}
