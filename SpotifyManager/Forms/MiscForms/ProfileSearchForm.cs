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
    public partial class ProfileSearchForm : Form
    {
        public string SearchString { get; set; }

        public ProfileSearchForm(string searchString)
        {
            InitializeComponent();

            SearchString = searchString;
        }

        private void ProfileSearchForm_Load(object sender, EventArgs e)
        {
            Styling.SetFormScheme(this);

            //todo: user search
            //

            lblSearchResultsFor.Text = $"Search results: {SearchString}";
        }
    }
}
