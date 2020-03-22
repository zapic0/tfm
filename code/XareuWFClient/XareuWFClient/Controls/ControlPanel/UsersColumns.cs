using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Args;
using XareuWFClient.Controls.Util;

namespace XareuWFClient.Controls.ControlPanel
{

    public partial class UsersColumns : UserControl
    {
        public int FollowingsPage { get; set; }
        public int FollowersPage { get; set; }
        public int RequestsPage { get; set; }
        public int ResultsPerPage { get; set; }

        #region Events
        [Category("User Defined")]
        [Description("Loads Next Following Page")]
        public event LoadNextFollowingPageHandler LoadNextFollowingPage;

        [Category("User Defined")]
        [Description("Loads Previous Following Page")]
        public event LoadPreviousFollowingPageHandler LoadPreviousFollowingPage;

        [Category("User Defined")]
        [Description("Loads Next Followers Page")]
        public event LoadNextFollowerPageHandler LoadNextFollowerPage;

        [Category("User Defined")]
        [Description("Loads Previous Followers Page")]
        public event LoadPreviousFollowerPageHandler LoadPreviousFollowerPage;

        [Category("User Defined")]
        [Description("Loads Next Requests Page")]
        public event LoadNextRequestPageHandler LoadNextRequestPage;

        [Category("User Defined")]
        [Description("Loads Previous Requests Page")]
        public event LoadPreviousRequestPageHandler LoadPreviousRequestPage;

        public delegate void LoadNextFollowingPageHandler(object sender, PageArgs args);
        public delegate void LoadPreviousFollowingPageHandler(object sender, PageArgs args);
        public delegate void LoadNextFollowerPageHandler(object sender, PageArgs args);
        public delegate void LoadPreviousFollowerPageHandler(object sender, PageArgs args);
        public delegate void LoadNextRequestPageHandler(object sender, PageArgs args);
        public delegate void LoadPreviousRequestPageHandler(object sender, PageArgs args);
        #endregion



        /// <summary>
        /// Initializes a new instance of the <see cref="UsersColumns"/> class.
        /// </summary>
        public UsersColumns()
        {
            InitializeComponent();
            this.FollowingsPage = 0;
            this.FollowersPage = 0;
            this.RequestsPage = 0;
            this.ResultsPerPage= 5;
            this.setLinksStatus();
        }

        /// <summary>
        /// Clears the followers list.
        /// </summary>
        public void ClearFollowersList()
        {
            this.FollowersPage = 0;
            this.pFollowersList.Controls.Clear();
            this.setLinksStatus();
        }

        /// <summary>
        /// Clears the following list.
        /// </summary>
        public void ClearFollowingList()
        {
            this.FollowingsPage = 0;
            this.pFollowingList.Controls.Clear();
            this.setLinksStatus();
        }

        /// <summary>
        /// Clears the request list.
        /// </summary>
        public void ClearRequestList()
        {
            this.RequestsPage = 0;
            this.pRequestsList.Controls.Clear();
            this.setLinksStatus();
        }

        /// <summary>
        /// Clears the lists.
        /// </summary>
        public void ClearLists()
        {
            this.ClearFollowersList();
            this.ClearFollowingList();
            this.ClearRequestList();
        }

        /// <summary>
        /// Loads the followers list.
        /// </summary>
        /// <param name="userFollowersList">The user followers list.</param>
        public void LoadFollowersList(List<Model.User.UserFollow> userFollowersList)
        {
            this.pFollowersList.Controls.Clear();
            foreach (Model.User.UserFollow userFollow in userFollowersList)
            {
                GenericUserInformation userInfo = new GenericUserInformation();
                userInfo.User = userFollow.UserFollowing;
                userInfo.LoadData();
                userInfo.Dock = DockStyle.Top;
                this.pFollowersList.Controls.Add(userInfo);
            }
            this.setLinksStatus();
        }

        /// <summary>
        /// Loads the following list.
        /// </summary>
        /// <param name="userFollowingList">The user following list.</param>
        public void LoadFollowingList(List<Model.User.UserFollow> userFollowingList)
        {
            this.pFollowingList.Controls.Clear();
            foreach (Model.User.UserFollow userFollow in userFollowingList)
            {
                GenericUserInformation userInfo = new GenericUserInformation();
                userInfo.User = userFollow.UserFollowed;
                userInfo.LoadData();
                userInfo.Dock = DockStyle.Top;
                this.pFollowingList.Controls.Add(userInfo);
            }
            this.setLinksStatus();
        }

        /// <summary>
        /// Loads the followers request list.
        /// </summary>
        /// <param name="userFollowersRequestList">The user followers request list.</param>
        public void LoadFollowersRequestList(List<Model.User.UserFollowRequest> userFollowersRequestList)
        {
            this.pRequestsList.Controls.Clear();
            foreach (Model.User.UserFollowRequest userFollowRequest in userFollowersRequestList)
            {
                GenericUserInformation userInfo = new GenericUserInformation();
                userInfo.User = userFollowRequest.UserFollowed;
                userInfo.LoadData();
                userInfo.Dock = DockStyle.Top;
                this.pRequestsList.Controls.Add(userInfo);
            }
            this.setLinksStatus();
        }

        /// <summary>
        /// Sets the links status.
        /// </summary>
        private void setLinksStatus()
        {
            if (this.pFollowersList.Controls.Count < this.ResultsPerPage)
            {
                this.lLNextFollowers.Hide();
            }
            else
            {
                this.lLNextFollowers.Show();
            }
            if (this.FollowersPage == 0)
            {
                this.lLPreviousFollowers.Hide();
            }
            else
            {
                this.lLPreviousFollowers.Show();
            }

            if (this.pFollowingList.Controls.Count < this.ResultsPerPage)
            {
                this.lLNextFollowing.Hide();
            }
            else
            {
                this.lLNextFollowing.Show();
            }
            if (this.FollowingsPage == 0)
            {
                this.lLPreviousFollowing.Hide();
            }
            else
            {
                this.lLPreviousFollowing.Show();
            }

            if (this.pRequestsList.Controls.Count < this.ResultsPerPage)
            {
                this.lLNextRequests.Hide();
            }
            else
            {
                this.lLNextRequests.Show();
            }
            if (this.RequestsPage == 0)
            {
                this.lLPreviousRequests.Hide();
            }
            else
            {
                this.lLPreviousRequests.Show();
            }
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLNextRequests control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLNextRequests_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.RequestsPage++;
            PageArgs args = new PageArgs(this.RequestsPage);
            this.LoadNextRequestPage(sender, args);
            this.setLinksStatus();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLPreviousRequests control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLPreviousRequests_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.RequestsPage--;
            PageArgs args = new PageArgs(this.RequestsPage);
            this.LoadPreviousRequestPage(sender, args);
            this.setLinksStatus();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLNextFollowers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLNextFollowers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.FollowersPage++;
            PageArgs args = new PageArgs(this.FollowersPage);
            this.LoadNextFollowerPage(sender, args);
            this.setLinksStatus();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLPreviousFollowers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLPreviousFollowers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.FollowersPage--;
            PageArgs args = new PageArgs(this.FollowersPage);
            this.LoadPreviousFollowerPage(sender, args);
            this.setLinksStatus();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLNextFollowing control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLNextFollowing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.FollowingsPage++;
            PageArgs args = new PageArgs(this.FollowingsPage);
            this.LoadNextFollowingPage(sender, args);
            this.setLinksStatus();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLPreviousFollowing control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLPreviousFollowing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.FollowingsPage--;
            PageArgs args = new PageArgs(this.FollowingsPage);
            this.LoadPreviousFollowingPage(sender, args);
            this.setLinksStatus();
        }

    }
}
