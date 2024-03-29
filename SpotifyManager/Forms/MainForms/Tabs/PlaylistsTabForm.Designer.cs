﻿
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
            this.colSong = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colAddedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddedBy = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTrackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddedById = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPlaylist = new System.Windows.Forms.Panel();
            this.lnkLikeEveryTrack = new System.Windows.Forms.LinkLabel();
            this.lnkImportPlaylist = new System.Windows.Forms.LinkLabel();
            this.lnkGenerateObscure = new System.Windows.Forms.LinkLabel();
            this.lnkGenerateSimilar = new System.Windows.Forms.LinkLabel();
            this.lnkExportPlaylist = new System.Windows.Forms.LinkLabel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPlaylistFollowers = new System.Windows.Forms.Label();
            this.ckbPublic = new System.Windows.Forms.CheckBox();
            this.ckbCollab = new System.Windows.Forms.CheckBox();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlaylistSelect = new System.Windows.Forms.ComboBox();
            this.fileDialogExportPlaylist = new System.Windows.Forms.SaveFileDialog();
            this.fileDialogImportPlaylist = new System.Windows.Forms.OpenFileDialog();
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
            this.colTrackId,
            this.colAddedById});
            this.dgvPlaylist.Location = new System.Drawing.Point(18, 163);
            this.dgvPlaylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.ReadOnly = true;
            this.dgvPlaylist.Size = new System.Drawing.Size(1058, 549);
            this.dgvPlaylist.TabIndex = 0;
            this.dgvPlaylist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylist_CellContentClick);
            // 
            // colSong
            // 
            this.colSong.HeaderText = "Song name";
            this.colSong.Name = "colSong";
            this.colSong.ReadOnly = true;
            this.colSong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.colAddedBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAddedBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTrackId
            // 
            this.colTrackId.HeaderText = "trackId";
            this.colTrackId.Name = "colTrackId";
            this.colTrackId.ReadOnly = true;
            this.colTrackId.Visible = false;
            // 
            // colAddedById
            // 
            this.colAddedById.HeaderText = "addedById";
            this.colAddedById.Name = "colAddedById";
            this.colAddedById.ReadOnly = true;
            this.colAddedById.Visible = false;
            // 
            // pnlPlaylist
            // 
            this.pnlPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlaylist.Controls.Add(this.lnkLikeEveryTrack);
            this.pnlPlaylist.Controls.Add(this.lnkImportPlaylist);
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
            this.pnlPlaylist.Location = new System.Drawing.Point(18, 20);
            this.pnlPlaylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPlaylist.Name = "pnlPlaylist";
            this.pnlPlaylist.Size = new System.Drawing.Size(1056, 132);
            this.pnlPlaylist.TabIndex = 1;
            this.pnlPlaylist.Tag = "shade";
            // 
            // lnkLikeEveryTrack
            // 
            this.lnkLikeEveryTrack.AutoSize = true;
            this.lnkLikeEveryTrack.Location = new System.Drawing.Point(234, 94);
            this.lnkLikeEveryTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLikeEveryTrack.Name = "lnkLikeEveryTrack";
            this.lnkLikeEveryTrack.Size = new System.Drawing.Size(125, 20);
            this.lnkLikeEveryTrack.TabIndex = 13;
            this.lnkLikeEveryTrack.TabStop = true;
            this.lnkLikeEveryTrack.Text = "Save every track";
            this.lnkLikeEveryTrack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLikeEveryTrack_LinkClicked);
            // 
            // lnkImportPlaylist
            // 
            this.lnkImportPlaylist.AutoSize = true;
            this.lnkImportPlaylist.Location = new System.Drawing.Point(120, 94);
            this.lnkImportPlaylist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkImportPlaylist.Name = "lnkImportPlaylist";
            this.lnkImportPlaylist.Size = new System.Drawing.Size(106, 20);
            this.lnkImportPlaylist.TabIndex = 12;
            this.lnkImportPlaylist.TabStop = true;
            this.lnkImportPlaylist.Text = "Import playlist";
            this.lnkImportPlaylist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImportPlaylist_LinkClicked);
            // 
            // lnkGenerateObscure
            // 
            this.lnkGenerateObscure.AutoSize = true;
            this.lnkGenerateObscure.Location = new System.Drawing.Point(507, 94);
            this.lnkGenerateObscure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkGenerateObscure.Name = "lnkGenerateObscure";
            this.lnkGenerateObscure.Size = new System.Drawing.Size(138, 20);
            this.lnkGenerateObscure.TabIndex = 10;
            this.lnkGenerateObscure.TabStop = true;
            this.lnkGenerateObscure.Text = "Generate obscure";
            this.lnkGenerateObscure.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGenerateObscure_LinkClicked);
            // 
            // lnkGenerateSimilar
            // 
            this.lnkGenerateSimilar.AutoSize = true;
            this.lnkGenerateSimilar.Location = new System.Drawing.Point(375, 94);
            this.lnkGenerateSimilar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkGenerateSimilar.Name = "lnkGenerateSimilar";
            this.lnkGenerateSimilar.Size = new System.Drawing.Size(125, 20);
            this.lnkGenerateSimilar.TabIndex = 9;
            this.lnkGenerateSimilar.TabStop = true;
            this.lnkGenerateSimilar.Text = "Generate similar";
            this.lnkGenerateSimilar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGenerateSimilar_LinkClicked);
            // 
            // lnkExportPlaylist
            // 
            this.lnkExportPlaylist.AutoSize = true;
            this.lnkExportPlaylist.Location = new System.Drawing.Point(4, 94);
            this.lnkExportPlaylist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkExportPlaylist.Name = "lnkExportPlaylist";
            this.lnkExportPlaylist.Size = new System.Drawing.Size(106, 20);
            this.lnkExportPlaylist.TabIndex = 8;
            this.lnkExportPlaylist.TabStop = true;
            this.lnkExportPlaylist.Text = "Export playlist";
            this.lnkExportPlaylist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExportPlaylist_LinkClicked);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(360, 40);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(25, 13);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "By: ";
            // 
            // lblPlaylistFollowers
            // 
            this.lblPlaylistFollowers.AutoSize = true;
            this.lblPlaylistFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistFollowers.Location = new System.Drawing.Point(628, 34);
            this.lblPlaylistFollowers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.ckbPublic.Location = new System.Drawing.Point(747, 5);
            this.ckbPublic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.ckbCollab.Location = new System.Drawing.Point(747, 37);
            this.ckbCollab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.lblCreatedOn.Location = new System.Drawing.Point(628, 8);
            this.lblCreatedOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(73, 15);
            this.lblCreatedOn.TabIndex = 3;
            this.lblCreatedOn.Text = "Created on: ";
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(402, 5);
            this.lblPlaylistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(100, 17);
            this.lblPlaylistName.TabIndex = 2;
            this.lblPlaylistName.Text = "playlistName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.cmbPlaylistSelect.Location = new System.Drawing.Point(4, 34);
            this.cmbPlaylistSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPlaylistSelect.Name = "cmbPlaylistSelect";
            this.cmbPlaylistSelect.Size = new System.Drawing.Size(326, 23);
            this.cmbPlaylistSelect.TabIndex = 0;
            this.cmbPlaylistSelect.SelectedIndexChanged += new System.EventHandler(this.cmbPlaylistSelect_SelectedIndexChanged);
            // 
            // fileDialogExportPlaylist
            // 
            this.fileDialogExportPlaylist.DefaultExt = "playlist";
            // 
            // fileDialogImportPlaylist
            // 
            this.fileDialogImportPlaylist.DefaultExt = "playlist";
            // 
            // PlaylistsTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 732);
            this.Controls.Add(this.pnlPlaylist);
            this.Controls.Add(this.dgvPlaylist);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.LinkLabel lnkGenerateObscure;
        private System.Windows.Forms.LinkLabel lnkGenerateSimilar;
        private System.Windows.Forms.LinkLabel lnkExportPlaylist;
        private System.Windows.Forms.DataGridViewLinkColumn colSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddedOn;
        private System.Windows.Forms.DataGridViewLinkColumn colAddedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddedById;
        private System.Windows.Forms.SaveFileDialog fileDialogExportPlaylist;
        private System.Windows.Forms.LinkLabel lnkImportPlaylist;
        private System.Windows.Forms.OpenFileDialog fileDialogImportPlaylist;
        private System.Windows.Forms.LinkLabel lnkLikeEveryTrack;
    }
}