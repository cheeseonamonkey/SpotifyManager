
namespace SpotifyManager.Forms.MainForms.Tabs
{
    partial class ProfileTabForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblGoToFollowers = new System.Windows.Forms.LinkLabel();
            this.lblGoToPlaylists = new System.Windows.Forms.LinkLabel();
            this.txtSearchProfiles = new System.Windows.Forms.TextBox();
            this.lblNumPlaylists = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumFollowers = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.dgvRecentlyPlayed = new System.Windows.Forms.DataGridView();
            this.colTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoToTrack = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblRecentlyPLayed = new System.Windows.Forms.Label();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentlyPlayed)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProfile
            // 
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProfile.Controls.Add(this.lblGoToFollowers);
            this.pnlProfile.Controls.Add(this.lblGoToPlaylists);
            this.pnlProfile.Controls.Add(this.txtSearchProfiles);
            this.pnlProfile.Controls.Add(this.lblNumPlaylists);
            this.pnlProfile.Controls.Add(this.label2);
            this.pnlProfile.Controls.Add(this.lblNumFollowers);
            this.pnlProfile.Controls.Add(this.picProfile);
            this.pnlProfile.Controls.Add(this.lblDisplayName);
            this.pnlProfile.Location = new System.Drawing.Point(12, 12);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(716, 162);
            this.pnlProfile.TabIndex = 0;
            this.pnlProfile.Tag = "shade";
            // 
            // lblGoToFollowers
            // 
            this.lblGoToFollowers.AutoSize = true;
            this.lblGoToFollowers.Location = new System.Drawing.Point(229, 33);
            this.lblGoToFollowers.Name = "lblGoToFollowers";
            this.lblGoToFollowers.Size = new System.Drawing.Size(33, 13);
            this.lblGoToFollowers.TabIndex = 13;
            this.lblGoToFollowers.TabStop = true;
            this.lblGoToFollowers.Text = "Go to";
            // 
            // lblGoToPlaylists
            // 
            this.lblGoToPlaylists.AutoSize = true;
            this.lblGoToPlaylists.Location = new System.Drawing.Point(229, 50);
            this.lblGoToPlaylists.Name = "lblGoToPlaylists";
            this.lblGoToPlaylists.Size = new System.Drawing.Size(33, 13);
            this.lblGoToPlaylists.TabIndex = 12;
            this.lblGoToPlaylists.TabStop = true;
            this.lblGoToPlaylists.Text = "Go to";
            this.lblGoToPlaylists.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoToPlaylists_LinkClicked);
            // 
            // txtSearchProfiles
            // 
            this.txtSearchProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProfiles.Location = new System.Drawing.Point(490, 25);
            this.txtSearchProfiles.Name = "txtSearchProfiles";
            this.txtSearchProfiles.Size = new System.Drawing.Size(219, 21);
            this.txtSearchProfiles.TabIndex = 10;
            this.txtSearchProfiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchProfiles_KeyPress);
            // 
            // lblNumPlaylists
            // 
            this.lblNumPlaylists.AutoSize = true;
            this.lblNumPlaylists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPlaylists.Location = new System.Drawing.Point(144, 46);
            this.lblNumPlaylists.Name = "lblNumPlaylists";
            this.lblNumPlaylists.Size = new System.Drawing.Size(71, 17);
            this.lblNumPlaylists.TabIndex = 4;
            this.lblNumPlaylists.Text = "0 Playlists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search profiles:";
            // 
            // lblNumFollowers
            // 
            this.lblNumFollowers.AutoSize = true;
            this.lblNumFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFollowers.Location = new System.Drawing.Point(144, 29);
            this.lblNumFollowers.Name = "lblNumFollowers";
            this.lblNumFollowers.Size = new System.Drawing.Size(79, 17);
            this.lblNumFollowers.TabIndex = 3;
            this.lblNumFollowers.Text = "0 Followers";
            // 
            // picProfile
            // 
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile.Location = new System.Drawing.Point(14, 29);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(110, 110);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 1;
            this.picProfile.TabStop = false;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(11, 9);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(87, 17);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "displayname";
            // 
            // dgvRecentlyPlayed
            // 
            this.dgvRecentlyPlayed.AllowUserToAddRows = false;
            this.dgvRecentlyPlayed.AllowUserToDeleteRows = false;
            this.dgvRecentlyPlayed.AllowUserToResizeRows = false;
            this.dgvRecentlyPlayed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentlyPlayed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentlyPlayed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrack,
            this.colArtist,
            this.colGoToTrack});
            this.dgvRecentlyPlayed.Location = new System.Drawing.Point(28, 208);
            this.dgvRecentlyPlayed.Name = "dgvRecentlyPlayed";
            this.dgvRecentlyPlayed.ReadOnly = true;
            this.dgvRecentlyPlayed.Size = new System.Drawing.Size(376, 109);
            this.dgvRecentlyPlayed.TabIndex = 5;
            // 
            // colTrack
            // 
            this.colTrack.HeaderText = "Track";
            this.colTrack.Name = "colTrack";
            this.colTrack.ReadOnly = true;
            // 
            // colArtist
            // 
            this.colArtist.HeaderText = "Artist";
            this.colArtist.Name = "colArtist";
            this.colArtist.ReadOnly = true;
            // 
            // colGoToTrack
            // 
            this.colGoToTrack.HeaderText = "Go to track";
            this.colGoToTrack.Name = "colGoToTrack";
            this.colGoToTrack.ReadOnly = true;
            this.colGoToTrack.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGoToTrack.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblRecentlyPLayed
            // 
            this.lblRecentlyPLayed.AutoSize = true;
            this.lblRecentlyPLayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentlyPLayed.Location = new System.Drawing.Point(25, 188);
            this.lblRecentlyPLayed.Name = "lblRecentlyPLayed";
            this.lblRecentlyPLayed.Size = new System.Drawing.Size(126, 17);
            this.lblRecentlyPLayed.TabIndex = 6;
            this.lblRecentlyPLayed.Text = "My recently played";
            // 
            // ProfileTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 475);
            this.Controls.Add(this.lblRecentlyPLayed);
            this.Controls.Add(this.dgvRecentlyPlayed);
            this.Controls.Add(this.pnlProfile);
            this.Name = "ProfileTabForm";
            this.Text = "ProfileTabForm";
            this.Load += new System.EventHandler(this.ProfileTabForm_Load);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentlyPlayed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblNumFollowers;
        private System.Windows.Forms.Label lblNumPlaylists;
        private System.Windows.Forms.DataGridView dgvRecentlyPlayed;
        private System.Windows.Forms.Label lblRecentlyPLayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtist;
        private System.Windows.Forms.DataGridViewLinkColumn colGoToTrack;
        private System.Windows.Forms.TextBox txtSearchProfiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblGoToFollowers;
        private System.Windows.Forms.LinkLabel lblGoToPlaylists;
    }
}