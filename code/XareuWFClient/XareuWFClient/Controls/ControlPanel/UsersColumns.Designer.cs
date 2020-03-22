namespace XareuWFClient.Controls.ControlPanel
{
    partial class UsersColumns
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
            this.tLPUserColumns = new System.Windows.Forms.TableLayoutPanel();
            this.pRequests = new System.Windows.Forms.Panel();
            this.pRequestsList = new System.Windows.Forms.Panel();
            this.pRequestsLinks = new System.Windows.Forms.Panel();
            this.lLNextRequests = new System.Windows.Forms.LinkLabel();
            this.lLPreviousRequests = new System.Windows.Forms.LinkLabel();
            this.lRequest = new System.Windows.Forms.Label();
            this.pFollowers = new System.Windows.Forms.Panel();
            this.pFollowersList = new System.Windows.Forms.Panel();
            this.pFollowersLinks = new System.Windows.Forms.Panel();
            this.lLNextFollowers = new System.Windows.Forms.LinkLabel();
            this.lLPreviousFollowers = new System.Windows.Forms.LinkLabel();
            this.lFollowers = new System.Windows.Forms.Label();
            this.pFollowing = new System.Windows.Forms.Panel();
            this.pFollowingList = new System.Windows.Forms.Panel();
            this.pFollowingLinks = new System.Windows.Forms.Panel();
            this.lLNextFollowing = new System.Windows.Forms.LinkLabel();
            this.lLPreviousFollowing = new System.Windows.Forms.LinkLabel();
            this.lFollowing = new System.Windows.Forms.Label();
            this.tLPUserColumns.SuspendLayout();
            this.pRequests.SuspendLayout();
            this.pRequestsLinks.SuspendLayout();
            this.pFollowers.SuspendLayout();
            this.pFollowersLinks.SuspendLayout();
            this.pFollowing.SuspendLayout();
            this.pFollowingLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPUserColumns
            // 
            this.tLPUserColumns.ColumnCount = 3;
            this.tLPUserColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPUserColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPUserColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPUserColumns.Controls.Add(this.pRequests, 2, 0);
            this.tLPUserColumns.Controls.Add(this.pFollowers, 1, 0);
            this.tLPUserColumns.Controls.Add(this.pFollowing, 0, 0);
            this.tLPUserColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPUserColumns.Location = new System.Drawing.Point(0, 0);
            this.tLPUserColumns.Name = "tLPUserColumns";
            this.tLPUserColumns.RowCount = 1;
            this.tLPUserColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPUserColumns.Size = new System.Drawing.Size(627, 351);
            this.tLPUserColumns.TabIndex = 0;
            // 
            // pRequests
            // 
            this.pRequests.Controls.Add(this.pRequestsList);
            this.pRequests.Controls.Add(this.pRequestsLinks);
            this.pRequests.Controls.Add(this.lRequest);
            this.pRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRequests.Location = new System.Drawing.Point(421, 3);
            this.pRequests.Name = "pRequests";
            this.pRequests.Size = new System.Drawing.Size(203, 345);
            this.pRequests.TabIndex = 2;
            // 
            // pRequestsList
            // 
            this.pRequestsList.AutoScroll = true;
            this.pRequestsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRequestsList.Location = new System.Drawing.Point(0, 36);
            this.pRequestsList.Name = "pRequestsList";
            this.pRequestsList.Size = new System.Drawing.Size(203, 291);
            this.pRequestsList.TabIndex = 12;
            // 
            // pRequestsLinks
            // 
            this.pRequestsLinks.Controls.Add(this.lLNextRequests);
            this.pRequestsLinks.Controls.Add(this.lLPreviousRequests);
            this.pRequestsLinks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pRequestsLinks.Location = new System.Drawing.Point(0, 327);
            this.pRequestsLinks.Name = "pRequestsLinks";
            this.pRequestsLinks.Size = new System.Drawing.Size(203, 18);
            this.pRequestsLinks.TabIndex = 13;
            // 
            // lLNextRequests
            // 
            this.lLNextRequests.AutoSize = true;
            this.lLNextRequests.Dock = System.Windows.Forms.DockStyle.Right;
            this.lLNextRequests.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextRequests.Location = new System.Drawing.Point(144, 0);
            this.lLNextRequests.Name = "lLNextRequests";
            this.lLNextRequests.Size = new System.Drawing.Size(59, 13);
            this.lLNextRequests.TabIndex = 1;
            this.lLNextRequests.TabStop = true;
            this.lLNextRequests.Text = "Next 10 >>";
            this.lLNextRequests.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextRequests.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLNextRequests_LinkClicked);
            // 
            // lLPreviousRequests
            // 
            this.lLPreviousRequests.AutoSize = true;
            this.lLPreviousRequests.Dock = System.Windows.Forms.DockStyle.Left;
            this.lLPreviousRequests.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousRequests.Location = new System.Drawing.Point(0, 0);
            this.lLPreviousRequests.Name = "lLPreviousRequests";
            this.lLPreviousRequests.Size = new System.Drawing.Size(78, 13);
            this.lLPreviousRequests.TabIndex = 0;
            this.lLPreviousRequests.TabStop = true;
            this.lLPreviousRequests.Text = "<< Previous 10";
            this.lLPreviousRequests.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousRequests.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLPreviousRequests_LinkClicked);
            // 
            // lRequest
            // 
            this.lRequest.AutoSize = true;
            this.lRequest.BackColor = System.Drawing.Color.Transparent;
            this.lRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lRequest.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lRequest.Location = new System.Drawing.Point(0, 0);
            this.lRequest.Name = "lRequest";
            this.lRequest.Size = new System.Drawing.Size(136, 36);
            this.lRequest.TabIndex = 11;
            this.lRequest.Text = "Requests";
            // 
            // pFollowers
            // 
            this.pFollowers.Controls.Add(this.pFollowersList);
            this.pFollowers.Controls.Add(this.pFollowersLinks);
            this.pFollowers.Controls.Add(this.lFollowers);
            this.pFollowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFollowers.Location = new System.Drawing.Point(212, 3);
            this.pFollowers.Name = "pFollowers";
            this.pFollowers.Size = new System.Drawing.Size(203, 345);
            this.pFollowers.TabIndex = 1;
            // 
            // pFollowersList
            // 
            this.pFollowersList.AutoScroll = true;
            this.pFollowersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFollowersList.Location = new System.Drawing.Point(0, 36);
            this.pFollowersList.Name = "pFollowersList";
            this.pFollowersList.Size = new System.Drawing.Size(203, 291);
            this.pFollowersList.TabIndex = 12;
            // 
            // pFollowersLinks
            // 
            this.pFollowersLinks.Controls.Add(this.lLNextFollowers);
            this.pFollowersLinks.Controls.Add(this.lLPreviousFollowers);
            this.pFollowersLinks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFollowersLinks.Location = new System.Drawing.Point(0, 327);
            this.pFollowersLinks.Name = "pFollowersLinks";
            this.pFollowersLinks.Size = new System.Drawing.Size(203, 18);
            this.pFollowersLinks.TabIndex = 0;
            // 
            // lLNextFollowers
            // 
            this.lLNextFollowers.AutoSize = true;
            this.lLNextFollowers.Dock = System.Windows.Forms.DockStyle.Right;
            this.lLNextFollowers.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextFollowers.Location = new System.Drawing.Point(144, 0);
            this.lLNextFollowers.Name = "lLNextFollowers";
            this.lLNextFollowers.Size = new System.Drawing.Size(59, 13);
            this.lLNextFollowers.TabIndex = 1;
            this.lLNextFollowers.TabStop = true;
            this.lLNextFollowers.Text = "Next 10 >>";
            this.lLNextFollowers.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextFollowers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLNextFollowers_LinkClicked);
            // 
            // lLPreviousFollowers
            // 
            this.lLPreviousFollowers.AutoSize = true;
            this.lLPreviousFollowers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lLPreviousFollowers.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousFollowers.Location = new System.Drawing.Point(0, 0);
            this.lLPreviousFollowers.Name = "lLPreviousFollowers";
            this.lLPreviousFollowers.Size = new System.Drawing.Size(78, 13);
            this.lLPreviousFollowers.TabIndex = 0;
            this.lLPreviousFollowers.TabStop = true;
            this.lLPreviousFollowers.Text = "<< Previous 10";
            this.lLPreviousFollowers.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousFollowers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLPreviousFollowers_LinkClicked);
            // 
            // lFollowers
            // 
            this.lFollowers.AutoSize = true;
            this.lFollowers.BackColor = System.Drawing.Color.Transparent;
            this.lFollowers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lFollowers.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lFollowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lFollowers.Location = new System.Drawing.Point(0, 0);
            this.lFollowers.Name = "lFollowers";
            this.lFollowers.Size = new System.Drawing.Size(139, 36);
            this.lFollowers.TabIndex = 11;
            this.lFollowers.Text = "Followers";
            // 
            // pFollowing
            // 
            this.pFollowing.Controls.Add(this.pFollowingList);
            this.pFollowing.Controls.Add(this.pFollowingLinks);
            this.pFollowing.Controls.Add(this.lFollowing);
            this.pFollowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFollowing.Location = new System.Drawing.Point(3, 3);
            this.pFollowing.Name = "pFollowing";
            this.pFollowing.Size = new System.Drawing.Size(203, 345);
            this.pFollowing.TabIndex = 0;
            // 
            // pFollowingList
            // 
            this.pFollowingList.AutoScroll = true;
            this.pFollowingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFollowingList.Location = new System.Drawing.Point(0, 36);
            this.pFollowingList.Name = "pFollowingList";
            this.pFollowingList.Size = new System.Drawing.Size(203, 291);
            this.pFollowingList.TabIndex = 12;
            // 
            // pFollowingLinks
            // 
            this.pFollowingLinks.Controls.Add(this.lLNextFollowing);
            this.pFollowingLinks.Controls.Add(this.lLPreviousFollowing);
            this.pFollowingLinks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFollowingLinks.Location = new System.Drawing.Point(0, 327);
            this.pFollowingLinks.Name = "pFollowingLinks";
            this.pFollowingLinks.Size = new System.Drawing.Size(203, 18);
            this.pFollowingLinks.TabIndex = 13;
            // 
            // lLNextFollowing
            // 
            this.lLNextFollowing.AutoSize = true;
            this.lLNextFollowing.Dock = System.Windows.Forms.DockStyle.Right;
            this.lLNextFollowing.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextFollowing.Location = new System.Drawing.Point(144, 0);
            this.lLNextFollowing.Name = "lLNextFollowing";
            this.lLNextFollowing.Size = new System.Drawing.Size(59, 13);
            this.lLNextFollowing.TabIndex = 1;
            this.lLNextFollowing.TabStop = true;
            this.lLNextFollowing.Text = "Next 10 >>";
            this.lLNextFollowing.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextFollowing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLNextFollowing_LinkClicked);
            // 
            // lLPreviousFollowing
            // 
            this.lLPreviousFollowing.AutoSize = true;
            this.lLPreviousFollowing.Dock = System.Windows.Forms.DockStyle.Left;
            this.lLPreviousFollowing.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousFollowing.Location = new System.Drawing.Point(0, 0);
            this.lLPreviousFollowing.Name = "lLPreviousFollowing";
            this.lLPreviousFollowing.Size = new System.Drawing.Size(78, 13);
            this.lLPreviousFollowing.TabIndex = 0;
            this.lLPreviousFollowing.TabStop = true;
            this.lLPreviousFollowing.Text = "<< Previous 10";
            this.lLPreviousFollowing.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousFollowing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLPreviousFollowing_LinkClicked);
            // 
            // lFollowing
            // 
            this.lFollowing.AutoSize = true;
            this.lFollowing.BackColor = System.Drawing.Color.Transparent;
            this.lFollowing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lFollowing.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lFollowing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lFollowing.Location = new System.Drawing.Point(0, 0);
            this.lFollowing.Name = "lFollowing";
            this.lFollowing.Size = new System.Drawing.Size(140, 36);
            this.lFollowing.TabIndex = 11;
            this.lFollowing.Text = "Following";
            // 
            // UsersColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tLPUserColumns);
            this.Name = "UsersColumns";
            this.Size = new System.Drawing.Size(627, 351);
            this.tLPUserColumns.ResumeLayout(false);
            this.pRequests.ResumeLayout(false);
            this.pRequests.PerformLayout();
            this.pRequestsLinks.ResumeLayout(false);
            this.pRequestsLinks.PerformLayout();
            this.pFollowers.ResumeLayout(false);
            this.pFollowers.PerformLayout();
            this.pFollowersLinks.ResumeLayout(false);
            this.pFollowersLinks.PerformLayout();
            this.pFollowing.ResumeLayout(false);
            this.pFollowing.PerformLayout();
            this.pFollowingLinks.ResumeLayout(false);
            this.pFollowingLinks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPUserColumns;
        private System.Windows.Forms.Panel pRequests;
        private System.Windows.Forms.Panel pRequestsList;
        private System.Windows.Forms.Label lRequest;
        private System.Windows.Forms.Panel pFollowers;
        private System.Windows.Forms.Panel pFollowersList;
        private System.Windows.Forms.Label lFollowers;
        private System.Windows.Forms.Panel pFollowing;
        private System.Windows.Forms.Panel pFollowingList;
        private System.Windows.Forms.Label lFollowing;
        private System.Windows.Forms.Panel pFollowersLinks;
        private System.Windows.Forms.LinkLabel lLNextFollowers;
        private System.Windows.Forms.LinkLabel lLPreviousFollowers;
        private System.Windows.Forms.Panel pFollowingLinks;
        private System.Windows.Forms.LinkLabel lLNextFollowing;
        private System.Windows.Forms.LinkLabel lLPreviousFollowing;
        private System.Windows.Forms.Panel pRequestsLinks;
        private System.Windows.Forms.LinkLabel lLNextRequests;
        private System.Windows.Forms.LinkLabel lLPreviousRequests;
    }
}
