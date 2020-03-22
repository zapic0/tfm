using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Args;

namespace XareuWFClient.Controls.ControlPanel
{
    public partial class ControlPanel : UserControl
    {

        #region Events
        [Category("User Defined")]
        [Description("Create new Group")]
        public event CreateNewGroupHandler CreateNewGroup;

        [Category("User Defined")]
        [Description("Subscribe to a new Tag")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToTagHandler SubscribeToTag;

        [Category("User Defined")]
        [Description("Loads user following list")]
        public event LoadFollowingListHandler LoadFollowingListEvent;

        [Category("User Defined")]
        [Description("Loads user followers list")]
        public event LoadFollowersListHandler LoadFollowersListEvent;

        [Category("User Defined")]
        [Description("Loads user followers requests list")]
        public event LoadFollowersRequestListHandler LoadFollowersRequestListEvent;


        /// <summary>
        /// Occurs when [open user results event].
        /// </summary>
        [Category("User Defined")]
        [Description("Loads user page")]
        public event XareuWFClient.Delegates.Delegates.OpenUserResultsHandler OpenUserResultsEvent;

        #endregion

        #region Delegates
        public delegate void CreateNewGroupHandler(object sender, EventArgs args);
        public delegate void LoadFollowingListHandler(object sender, PageArgs args);
        public delegate void LoadFollowersListHandler(object sender, PageArgs args);
        public delegate void LoadFollowersRequestListHandler(object sender, PageArgs args);
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlPanel"/> class.
        /// </summary>
        public ControlPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the subscribed tags.
        /// </summary>
        /// <param name="subscribedTags">The subscribed tags.</param>
        public void LoadSubscribedTags(List<Model.Tag.Tag> subscribedTags)
        {
            tagsGroupsBox.LoadSubscribedTags(subscribedTags);
        }

        /// <summary>
        /// Loads the own groups.
        /// </summary>
        /// <param name="ownGroups">The own groups.</param>
        public void LoadOwnGroups(List<Model.Group.Group> ownGroups)
        {
            tagsGroupsBox.LoadOwnGroups(ownGroups);
        }

        /// <summary>
        /// Handles the CreateNewGroup event of the tagsGroupsBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tagsGroupsBox_CreateNewGroup(object sender, EventArgs args)
        {
            this.CreateNewGroup(sender, args);
        }

        /// <summary>
        /// Tagses the groups box_ subscribe to tag.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void tagsGroupsBox_SubscribeToTag(object sender, TagsArgs args)
        {
            this.SubscribeToTag(sender, args);
        }

        /// <summary>
        /// Loads the followers list.
        /// </summary>
        /// <param name="userFollowersList">The user followers list.</param>
        public void LoadFollowersList(List<Model.User.UserFollow> userFollowersList)
        {
            this.usersColumns1.LoadFollowersList(userFollowersList);
        }

        /// <summary>
        /// Loads the following list.
        /// </summary>
        /// <param name="userFollowingList">The user following list.</param>
        public void LoadFollowingList(List<Model.User.UserFollow> userFollowingList)
        {
            this.usersColumns1.LoadFollowingList(userFollowingList);
        }

        /// <summary>
        /// Loads the followers request list.
        /// </summary>
        /// <param name="userFollowRequestList">The user follow request list.</param>
        public void LoadFollowersRequestList(List<Model.User.UserFollowRequest> userFollowRequestList)
        {
            this.usersColumns1.LoadFollowersRequestList(userFollowRequestList);
        }

        /// <summary>
        /// Userses the columns1_ load next follower page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void usersColumns1_LoadNextFollowerPage(object sender, PageArgs args)
        {
            this.LoadFollowersListEvent(sender, args);
        }

        /// <summary>
        /// Userses the columns1_ load next following page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void usersColumns1_LoadNextFollowingPage(object sender, PageArgs args)
        {
            this.LoadFollowingListEvent(sender, args);
        }

        /// <summary>
        /// Userses the columns1_ load next request page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void usersColumns1_LoadNextRequestPage(object sender, PageArgs args)
        {
            this.LoadFollowersRequestListEvent(sender, args);
        }

        /// <summary>
        /// Userses the columns1_ load previous follower page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void usersColumns1_LoadPreviousFollowerPage(object sender, PageArgs args)
        {
            this.LoadFollowersListEvent(sender, args);
        }

        /// <summary>
        /// Userses the columns1_ load previous following page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void usersColumns1_LoadPreviousFollowingPage(object sender, PageArgs args)
        {
            this.LoadFollowingListEvent(sender, args);
        }

        /// <summary>
        /// Userses the columns1_ load previous request page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void usersColumns1_LoadPreviousRequestPage(object sender, PageArgs args)
        {
            this.LoadFollowersRequestListEvent(sender, args);
        }
    }
}
