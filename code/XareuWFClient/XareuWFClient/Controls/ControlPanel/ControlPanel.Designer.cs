namespace XareuWFClient.Controls.ControlPanel
{
    partial class ControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tLPControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tagsGroupsBox = new TagsGroupsBox();
            this.pSeparator = new System.Windows.Forms.Panel();
            this.usersColumns1 = new UsersColumns();
            this.tLPControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPControlPanel
            // 
            this.tLPControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.tLPControlPanel.ColumnCount = 3;
            this.tLPControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tLPControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tLPControlPanel.Controls.Add(this.tagsGroupsBox, 0, 0);
            this.tLPControlPanel.Controls.Add(this.pSeparator, 1, 0);
            this.tLPControlPanel.Controls.Add(this.usersColumns1, 2, 0);
            this.tLPControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPControlPanel.Location = new System.Drawing.Point(0, 0);
            this.tLPControlPanel.Name = "tLPControlPanel";
            this.tLPControlPanel.RowCount = 1;
            this.tLPControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPControlPanel.Size = new System.Drawing.Size(771, 419);
            this.tLPControlPanel.TabIndex = 1;
            // 
            // tagsGroupsBox
            // 
            this.tagsGroupsBox.BackColor = System.Drawing.Color.Transparent;
            this.tagsGroupsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsGroupsBox.Location = new System.Drawing.Point(3, 3);
            this.tagsGroupsBox.Name = "tagsGroupsBox";
            this.tagsGroupsBox.Size = new System.Drawing.Size(146, 413);
            this.tagsGroupsBox.TabIndex = 0;
            this.tagsGroupsBox.CreateNewGroup += new TagsGroupsBox.CreateNewGroupHandler(this.tagsGroupsBox_CreateNewGroup);
            this.tagsGroupsBox.SubscribeToTag += new Delegates.Delegates.SubscribeToTagHandler(this.tagsGroupsBox_SubscribeToTag);
            // 
            // pSeparator
            // 
            this.pSeparator.BackColor = System.Drawing.Color.Transparent;
            this.pSeparator.BackgroundImage = global::XareuWFClient.Properties.Resources.separatorComplete;
            this.pSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSeparator.Location = new System.Drawing.Point(155, 3);
            this.pSeparator.Name = "pSeparator";
            this.pSeparator.Size = new System.Drawing.Size(4, 413);
            this.pSeparator.TabIndex = 1;
            // 
            // usersColumns1
            // 
            this.usersColumns1.BackColor = System.Drawing.Color.Transparent;
            this.usersColumns1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersColumns1.FollowersPage = 0;
            this.usersColumns1.FollowingsPage = 0;
            this.usersColumns1.Location = new System.Drawing.Point(165, 3);
            this.usersColumns1.Name = "usersColumns1";
            this.usersColumns1.RequestsPage = 0;
            this.usersColumns1.ResultsPerPage = 5;
            this.usersColumns1.Size = new System.Drawing.Size(603, 413);
            this.usersColumns1.TabIndex = 2;
            this.usersColumns1.LoadNextFollowingPage += new UsersColumns.LoadNextFollowingPageHandler(this.usersColumns1_LoadNextFollowingPage);
            this.usersColumns1.LoadPreviousFollowingPage += new UsersColumns.LoadPreviousFollowingPageHandler(this.usersColumns1_LoadPreviousFollowingPage);
            this.usersColumns1.LoadNextFollowerPage += new UsersColumns.LoadNextFollowerPageHandler(this.usersColumns1_LoadNextFollowerPage);
            this.usersColumns1.LoadPreviousFollowerPage += new UsersColumns.LoadPreviousFollowerPageHandler(this.usersColumns1_LoadPreviousFollowerPage);
            this.usersColumns1.LoadNextRequestPage += new UsersColumns.LoadNextRequestPageHandler(this.usersColumns1_LoadNextRequestPage);
            this.usersColumns1.LoadPreviousRequestPage += new UsersColumns.LoadPreviousRequestPageHandler(this.usersColumns1_LoadPreviousRequestPage);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tLPControlPanel);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(771, 419);
            this.tLPControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TagsGroupsBox tagsGroupsBox;
        private System.Windows.Forms.TableLayoutPanel tLPControlPanel;
        private System.Windows.Forms.Panel pSeparator;
        private UsersColumns usersColumns1;
    }
}
