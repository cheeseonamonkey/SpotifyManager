
namespace SpotifyManager
{
    partial class MainForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSecretIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAcessTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAccessTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuallySetAccessTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAccessTokenMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabPlaylists = new System.Windows.Forms.TabPage();
            this.tabTrack = new System.Windows.Forms.TabPage();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.menuStripMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.miscToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(889, 25);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(123, 21);
            this.connectToolStripMenuItem.Text = "Connect to Spotify";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSecretIDToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setSecretIDToolStripMenuItem
            // 
            this.setSecretIDToolStripMenuItem.Name = "setSecretIDToolStripMenuItem";
            this.setSecretIDToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.setSecretIDToolStripMenuItem.Text = "Set secret ID";
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boopToolStripMenuItem,
            this.copyAcessTokenToolStripMenuItem,
            this.resetAccessTokenToolStripMenuItem,
            this.manuallySetAccessTokenToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // boopToolStripMenuItem
            // 
            this.boopToolStripMenuItem.Name = "boopToolStripMenuItem";
            this.boopToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.boopToolStripMenuItem.Text = "Beep Boop";
            // 
            // copyAcessTokenToolStripMenuItem
            // 
            this.copyAcessTokenToolStripMenuItem.Name = "copyAcessTokenToolStripMenuItem";
            this.copyAcessTokenToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.copyAcessTokenToolStripMenuItem.Text = "Copy acess token";
            this.copyAcessTokenToolStripMenuItem.Click += new System.EventHandler(this.copyAcessTokenToolStripMenuItem_Click);
            // 
            // resetAccessTokenToolStripMenuItem
            // 
            this.resetAccessTokenToolStripMenuItem.Name = "resetAccessTokenToolStripMenuItem";
            this.resetAccessTokenToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.resetAccessTokenToolStripMenuItem.Text = "Reset access token";
            this.resetAccessTokenToolStripMenuItem.Click += new System.EventHandler(this.resetAccessTokenToolStripMenuItem_Click);
            // 
            // manuallySetAccessTokenToolStripMenuItem
            // 
            this.manuallySetAccessTokenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAccessTokenMenuItem});
            this.manuallySetAccessTokenToolStripMenuItem.Name = "manuallySetAccessTokenToolStripMenuItem";
            this.manuallySetAccessTokenToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.manuallySetAccessTokenToolStripMenuItem.Text = "Manually set access token";
            // 
            // setAccessTokenMenuItem
            // 
            this.setAccessTokenMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.setAccessTokenMenuItem.Name = "setAccessTokenMenuItem";
            this.setAccessTokenMenuItem.Size = new System.Drawing.Size(100, 23);
            this.setAccessTokenMenuItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.setAccessTokenMenuItem_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Controls.Add(this.tabPlaylists);
            this.tabControl.Controls.Add(this.tabTrack);
            this.tabControl.Controls.Add(this.tabStats);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(10, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(870, 542);
            this.tabControl.TabIndex = 2;
            // 
            // tabProfile
            // 
            this.tabProfile.Location = new System.Drawing.Point(4, 25);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(862, 513);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // tabPlaylists
            // 
            this.tabPlaylists.Location = new System.Drawing.Point(4, 25);
            this.tabPlaylists.Name = "tabPlaylists";
            this.tabPlaylists.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaylists.Size = new System.Drawing.Size(862, 513);
            this.tabPlaylists.TabIndex = 1;
            this.tabPlaylists.Text = "Playlists";
            this.tabPlaylists.UseVisualStyleBackColor = true;
            // 
            // tabTrack
            // 
            this.tabTrack.Location = new System.Drawing.Point(4, 25);
            this.tabTrack.Name = "tabTrack";
            this.tabTrack.Size = new System.Drawing.Size(862, 513);
            this.tabTrack.TabIndex = 3;
            this.tabTrack.Text = "Track";
            this.tabTrack.UseVisualStyleBackColor = true;
            // 
            // tabStats
            // 
            this.tabStats.Location = new System.Drawing.Point(4, 25);
            this.tabStats.Name = "tabStats";
            this.tabStats.Size = new System.Drawing.Size(862, 513);
            this.tabStats.TabIndex = 2;
            this.tabStats.Text = "Stats";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 579);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStripMain);
            this.Name = "MainForm";
            this.Tag = "main";
            this.Text = "SpotifyManager";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSecretIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boopToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabPlaylists;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.ToolStripMenuItem copyAcessTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAccessTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuallySetAccessTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox setAccessTokenMenuItem;
        private System.Windows.Forms.TabPage tabTrack;
    }
}

