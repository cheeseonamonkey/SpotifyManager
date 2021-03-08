
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
            this.profilePanel = new System.Windows.Forms.Panel();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblNumFollowers = new System.Windows.Forms.Label();
            this.lblNumPlaylists = new System.Windows.Forms.Label();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePanel
            // 
            this.profilePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profilePanel.Controls.Add(this.lblNumPlaylists);
            this.profilePanel.Controls.Add(this.lblNumFollowers);
            this.profilePanel.Controls.Add(this.picProfile);
            this.profilePanel.Controls.Add(this.lblDisplayName);
            this.profilePanel.Location = new System.Drawing.Point(12, 12);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(716, 162);
            this.profilePanel.TabIndex = 0;
            this.profilePanel.Tag = "shade";
            this.profilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // ProfileTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 475);
            this.Controls.Add(this.profilePanel);
            this.Name = "ProfileTabForm";
            this.Text = "ProfileTabForm";
            this.Load += new System.EventHandler(this.ProfileTabForm_Load);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblNumFollowers;
        private System.Windows.Forms.Label lblNumPlaylists;
    }
}