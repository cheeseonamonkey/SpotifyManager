
namespace SpotifyManager.Forms
{
    partial class ConnectSplashForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.authBrowser = new System.Windows.Forms.WebBrowser();
            this.lblSplash = new System.Windows.Forms.Label();
            this.lnkClearCookies = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(23, 497);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 38);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to Spotify";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // authBrowser
            // 
            this.authBrowser.Location = new System.Drawing.Point(12, 12);
            this.authBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.authBrowser.Name = "authBrowser";
            this.authBrowser.Size = new System.Drawing.Size(518, 467);
            this.authBrowser.TabIndex = 1;
            this.authBrowser.WebBrowserShortcutsEnabled = false;
            this.authBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.authBrowser_Navigated);
            // 
            // lblSplash
            // 
            this.lblSplash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSplash.Location = new System.Drawing.Point(170, 497);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(359, 54);
            this.lblSplash.TabIndex = 2;
            this.lblSplash.Text = "Log into your spotify account here.\r\n";
            // 
            // lnkClearCookies
            // 
            this.lnkClearCookies.AutoSize = true;
            this.lnkClearCookies.Location = new System.Drawing.Point(434, 556);
            this.lnkClearCookies.Name = "lnkClearCookies";
            this.lnkClearCookies.Size = new System.Drawing.Size(95, 13);
            this.lnkClearCookies.TabIndex = 3;
            this.lnkClearCookies.TabStop = true;
            this.lnkClearCookies.Text = "Clear browser data";
            this.lnkClearCookies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearCookies_LinkClicked);
            // 
            // ConnectSplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 575);
            this.Controls.Add(this.lnkClearCookies);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.authBrowser);
            this.Controls.Add(this.btnConnect);
            this.Name = "ConnectSplashForm";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.WebBrowser authBrowser;
        private System.Windows.Forms.Label lblSplash;
        private System.Windows.Forms.LinkLabel lnkClearCookies;
    }
}