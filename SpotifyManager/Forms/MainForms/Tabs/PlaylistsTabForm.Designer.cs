
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
            this.colPlaylistDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaylistCollab = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPlaylistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaylistNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPlaylist = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlaylistSelect = new System.Windows.Forms.ComboBox();
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
            this.colPlaylistDate,
            this.colPlaylistCollab,
            this.colPlaylistName,
            this.colPlaylistNum});
            this.dgvPlaylist.Location = new System.Drawing.Point(12, 85);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.ReadOnly = true;
            this.dgvPlaylist.Size = new System.Drawing.Size(716, 378);
            this.dgvPlaylist.TabIndex = 0;
            // 
            // colPlaylistDate
            // 
            this.colPlaylistDate.HeaderText = "Created";
            this.colPlaylistDate.Name = "colPlaylistDate";
            this.colPlaylistDate.ReadOnly = true;
            // 
            // colPlaylistCollab
            // 
            this.colPlaylistCollab.HeaderText = "Collab";
            this.colPlaylistCollab.Name = "colPlaylistCollab";
            this.colPlaylistCollab.ReadOnly = true;
            this.colPlaylistCollab.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPlaylistCollab.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colPlaylistName
            // 
            this.colPlaylistName.HeaderText = "Name";
            this.colPlaylistName.Name = "colPlaylistName";
            this.colPlaylistName.ReadOnly = true;
            // 
            // colPlaylistNum
            // 
            this.colPlaylistNum.HeaderText = "Songs";
            this.colPlaylistNum.Name = "colPlaylistNum";
            this.colPlaylistNum.ReadOnly = true;
            // 
            // pnlPlaylist
            // 
            this.pnlPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlaylist.Controls.Add(this.label1);
            this.pnlPlaylist.Controls.Add(this.cmbPlaylistSelect);
            this.pnlPlaylist.Location = new System.Drawing.Point(12, 13);
            this.pnlPlaylist.Name = "pnlPlaylist";
            this.pnlPlaylist.Size = new System.Drawing.Size(705, 53);
            this.pnlPlaylist.TabIndex = 1;
            this.pnlPlaylist.Tag = "shade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select:";
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
            // PlaylistsTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 475);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaylistDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPlaylistCollab;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaylistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaylistNum;
        private System.Windows.Forms.ComboBox cmbPlaylistSelect;
        private System.Windows.Forms.Label label1;
    }
}