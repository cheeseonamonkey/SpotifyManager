﻿using System;
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
    public partial class StatsTabForm : Form, iTabForm
    {
        public StatsTabForm()
        {
            InitializeComponent();
        }

        public async Task LoadTabForm()
        {
            
        }

        private void StatsTabForm_Load(object sender, EventArgs e)
        {
            Styling.SetFormScheme(this);
        }
    }
}
