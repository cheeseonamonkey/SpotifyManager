
namespace SpotifyManager.Forms.MainForms.Tabs
{
    partial class PlaylistsTabForm
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
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.colSong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnGoToSong = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colTrackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPlaylist = new System.Windows.Forms.Panel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPlaylistFollowers = new System.Windows.Forms.Label();
            this.ckbPublic = new System.Windows.Forms.CheckBox();
            this.ckbCollab = new System.Windows.Forms.CheckBox();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlaylistSelect = new System.Windows.Forms.ComboBox();
            this.lnkExportPlaylist = new System.Windows.Forms.LinkLabel();
            this.lnkGenerateSimilar = new System.Windows.Forms.LinkLabel();
            this.lnkGenerateObscure = new System.Windows.Forms.LinkLabel();
            this.lnkGenerateArtists = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.pnlPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.AllowUserToAddRows = false;
            this.dgvPlaylist.AllowUserToDeleteRows = false;
            this.dgvPlaylist.AllowUserToResizeRows = false;
            this.dgvPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSong,
            this.colAddedOn,
            this.colAddedBy,
            this.colBtnGoToSong,
            this.colTrackId});
            this.dgvPlaylist.Location = new System.Drawing.Point(12, 106);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.ReadOnly = true;
            this.dgvPlaylist.Size = new System.Drawing.Size(705, 357);
            this.dgvPlaylist.TabIndex = 0;
            this.dgvPlaylist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylist_CellContentClick);
            // 
            // colSong
            // 
            this.colSong.HeaderText = "Song name";
            this.colSong.Name = "colSong";
            this.colSong.ReadOnly = true;
            // 
            // colAddedOn
            // 
            this.colAddedOn.HeaderText = "Added on";
            this.colAddedOn.Name = "colAddedOn";
            this.colAddedOn.ReadOnly = true;
            // 
            // colAddedBy
            // 
            this.colAddedBy.HeaderText = "Added by";
            this.colAddedBy.Name = "colAddedBy";
            this.colAddedBy.ReadOnly = true;
            // 
            // colBtnGoToSong
            // 
            this.colBtnGoToSong.HeaderText = "Go to song";
            this.colBtnGoToSong.Name = "colBtnGoToSong";
            this.colBtnGoToSong.ReadOnly = true;
            // 
            // colTrackId
            // 
            this.colTrackId.HeaderText = "trackId";
            this.colTrackId.Name = "colTrackId";
            this.colTrackId.ReadOnly = true;
            this.colTrackId.Visible = false;
            // 
            // pnlPlaylist
            // 
            this.pnlPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlaylist.Controls.Add(this.lnkGenerateArtists);
            this.pnlPlaylist.Controls.Add(this.lnkGenerateObscure);
            this.pnlPlaylist.Controls.Add(this.lnkGenerateSimilar);
            this.pnlPlaylist.Controls.Add(this.lnkExportPlaylist);
            this.pnlPlaylist.Controls.Add(this.lblAuthor);
            this.pnlPlaylist.Controls.Add(this.lblPlaylistFollowers);
            this.pnlPlaylist.Controls.Add(this.ckbPublic);
            this.pnlPlaylist.Controls.Add(this.ckbCollab);
            this.pnlPlaylist.Controls.Add(this.lblCreatedOn);
            this.pnlPlaylist.Controls.Add(this.lblPlaylistName);
            this.pnlPlaylist.Controls.Add(this.label1);
            this.pnlPlaylist.Controls.Add(this.cmbPlaylistSelect);
            this.pnlPlaylist.Location = new System.Drawing.Point(12, 13);
            this.pnlPlaylist.Name = "pnlPlaylist";
            this.pnlPlaylist.Size = new System.Drawing.Size(705, 87);
            this.pnlPlaylist.TabIndex = 1;
            this.pnlPlaylist.Tag = "shade";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(240, 26);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(25, 13);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "By: ";
            // 
            // lblPlaylistFollowers
            // 
            this.lblPlaylistFollowers.AutoSize = true;
            this.lblPlaylistFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistFollowers.Location = new System.Drawing.Point(419, 22);
            this.lblPlaylistFollowers.Name = "lblPlaylistFollowers";
            this.lblPlaylistFollowers.Size = new System.Drawing.Size(66, 15);
            this.lblPlaylistFollowers.TabIndex = 6;
            this.lblPlaylistFollowers.Text = "0 followers";
            // 
            // ckbPublic
            // 
            this.ckbPublic.AutoSize = true;
            this.ckbPublic.Enabled = false;
            this.ckbPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPublic.Location = new System.Drawing.Point(498, 3);
            this.ckbPublic.Name = "ckbPublic";
            this.ckbPublic.Size = new System.Drawing.Size(60, 19);
            this.ckbPublic.TabIndex = 5;
            this.ckbPublic.Text = "Public";
            this.ckbPublic.UseVisualStyleBackColor = true;
            // 
            // ckbCollab
            // 
            this.ckbCollab.AutoSize = true;
            this.ckbCollab.Enabled = false;
            this.ckbCollab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCollab.Location = new System.Drawing.Point(498, 24);
            this.ckbCollab.Name = "ckbCollab";
            this.ckbCollab.Size = new System.Drawing.Size(97, 19);
            this.ckbCollab.TabIndex = 4;
            this.ckbCollab.Text = "Collaborative";
            this.ckbCollab.UseVisualStyleBackColor = true;
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.AutoSize = true;
            this.lblCreatedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedOn.Location = new System.Drawing.Point(419, 5);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(73, 15);
            this.lblCreatedOn.TabIndex = 3;
            this.lblCreatedOn.Text = "Created on: ";
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(268, 3);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(100, 17);
            this.lblPlaylistName.TabIndex = 2;
            this.lblPlaylistName.Text = "playlistName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "My playlists:";
            // 
            // cmbPlaylistSelect
            // 
            this.cmbPlaylistSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPlaylistSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPlaylistSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlaylistSelect.FormattingEnabled = true;
            this.cmbPlaylistSelect.Location = new System.Drawing.Point(3, 22);
            this.cmbPlaylistSelect.Name = "cmbPlaylistSelect";
            this.cmbPlaylistSelect.Size = new System.Drawing.Size(219, 23);
            this.cmbPlaylistSelect.TabIndex = 0;
            this.cmbPlaylistSelect.SelectedIndexChanged += new System.EventHandler(this.cmbPlaylistSelect_SelectedIndexChanged);
            // 
            // lnkExportPlaylist
            // 
            this.lnkExportPlaylist.AutoSize = true;
            this.lnkExportPlaylist.Location = new System.Drawing.Point(3, 61);
            this.lnkExportPlaylist.Name = "lnkExportPlaylist";
            this.lnkExportPlaylist.Size = new System.Drawing.Size(71, 13);
            this.lnkExportPlaylist.TabIndex = 8;
            this.lnkExportPlaylist.TabStop = true;
            this.lnkExportPlaylist.Text = "Export playlist";
            // 
            // lnkGenerateSimilar
            // 
            this.lnkGenerateSimilar.AutoSize = true;
            this.lnkGenerateSimilar.Location = new System.Drawing.Point(80, 61);
            this.lnkGenerateSimilar.Name = "lnkGenerateSimilar";
            this.lnkGenerateSimilar.Size = new System.Drawing.Size(82, 13);
            this.lnkGenerateSimilar.TabIndex = 9;
            this.lnkGenerateSimilar.TabStop = true;
            this.lnkGenerateSimilar.Text = "Generate similar";
            // 
            // lnkGenerateObscure
            // 
            this.lnkGenerateObscure.AutoSize = true;
            this.lnkGenerateObscure.Location = new System.Drawing.Point(168, 61);
            this.lnkGenerateObscure.Name = "lnkGenerateObscure";
            this.lnkGenerateObscure.Size = new System.Drawing.Size(92, 13);
            this.lnkGenerateObscure.TabIndex = 10;
            this.lnkGenerateObscure.TabStop = true;
            this.lnkGenerateObscure.Text = "Generate obscure";
            // 
            // lnkGenerateArtists
            // 
            this.lnkGenerateArtists.AutoSize = true;
            this.lnkGenerateArtists.Location = new System.Drawing.Point(266, 61);
            this.lnkGenerateArtists.Name = "lnkGenerateArtists";
            this.lnkGenerateArtists.Size = new System.Drawing.Size(120, 13);
            this.lnkGenerateArtists.TabIndex = 11;
            this.lnkGenerateArtists.TabStop = true;
            this.lnkGenerateArtists.Text = "Generate w/ artist swap";
            // 
            // PlaylistsTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 476);
            this.Controls.Add(this.pnlPlaylist);
            this.Controls.Add(this.dgvPlaylist);
            this.Name = "PlaylistsTabForm";
            this.Text = "PlaylistsTabForm";
            this.Load += new System.EventHandler(this.PlaylistsTabForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.pnlPlaylist.ResumeLayout(false);
            this.pnlPlaylist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.Panel pnlPlaylist;
        private System.Windows.Forms.ComboBox cmbPlaylistSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbCollab;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.CheckBox ckbPublic;
        private System.Windows.Forms.Label lblPlaylistFollowers;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddedBy;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnGoToSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrackId;
        private System.Windows.Forms.LinkLabel lnkGenerateObscure;
        private System.Windows.Forms.LinkLabel lnkGenerateSimilar;
        private System.Windows.Forms.LinkLabel lnkExportPlaylist;
        private System.Windows.Forms.LinkLabel lnkGenerateArtists;
    }
}