
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
            this.lblNumPlaylists = new System.Windows.Forms.Label();
            this.lblNumFollowers = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProfile
            // 
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProfile.Controls.Add(this.lblNumPlaylists);
            this.pnlProfile.Controls.Add(this.lblNumFollowers);
            this.pnlProfile.Controls.Add(this.picProfile);
            this.pnlProfile.Controls.Add(this.lblDisplayName);
            this.pnlProfile.Location = new System.Drawing.Point(12, 12);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(716, 162);
            this.pnlProfile.TabIndex = 0;
            this.pnlProfile.Tag = "shade";
            this.pnlProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // ProfileTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 475);
            this.Controls.Add(this.pnlProfile);
            this.Name = "ProfileTabForm";
            this.Text = "ProfileTabForm";
            this.Load += new System.EventHandler(this.ProfileTabForm_Load);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblNumFollowers;
        private System.Windows.Forms.Label lblNumPlaylists;
    }
}