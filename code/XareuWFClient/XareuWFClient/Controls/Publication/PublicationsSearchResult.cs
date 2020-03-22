using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Controls.Tag;
using XareuWFClient.Args;
using XareuWFClient.Controls.User;
using XareuWFClient.Controls.Group;

namespace XareuWFClient.Controls.Publication
{
    public partial class PublicationsSearchResult : UserControl
    {

        public int Page { get; set; }
        public Model.Tag.Tag TagData { get; set; }
        public Model.User.User UserData { get; set; }
        public Model.Group.Group GroupData { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationsSearchResult"/> class.
        /// </summary>
        public PublicationsSearchResult()
        {
            InitializeComponent();
            this.TagData = null;
            this.UserData = null;
            this.Page = 0;
        }


        #region Events

        [Category("User Defined")]
        [Description("Changes Tags Page")]
        public event ChangeTagsPageHandler ChangeTagsPage;
        public delegate void ChangeTagsPageHandler(object sender, TagsArgs args);

        [Category("User Defined")]
        [Description("Changes Groups Page")]
        public event ChangeGroupsPageHandler ChangeGroupsPage;
        public delegate void ChangeGroupsPageHandler(object sender, GroupsArgs args);

        [Category("User Defined")]
        [Description("Changes Users Page")]
        public event ChangeUsersPageHandler ChangeUsersPage;
        public delegate void ChangeUsersPageHandler(object sender, UsersArgs args);

        [Category("User Defined")]
        [Description("Subscribe to Tag")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToTagHandler SubscribeToTag;

        [Category("User Defined")]
        [Description("Subscribe to Group")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToGroupHandler SubscribeToGroup;

        [Category("User Defined")]
        [Description("Follow User")]
        public event XareuWFClient.Delegates.Delegates.FollowUserHandler FollowUser;

        [Category("User Defined")]
        [Description("Open Publication Page")]
        public event XareuWFClient.Delegates.Delegates.OpenPublicationPageHandler OpenPublicationPage;

        #endregion

        #region Tags
        /// <summary>
        /// Loads the title.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void LoadTitle(Model.Tag.Tag tag)
        {
            this.TagData = tag;
            TagTitle title = new TagTitle();
            title.LoadData(tag);
            title.SubscribeToTag += new Delegates.Delegates.SubscribeToTagHandler(title_SubscribeToTag);
            title.Dock = DockStyle.Fill;
            this.pTitle.Controls.Clear();
            this.pTitle.Controls.Add(title);
            title.Show();
            title.BringToFront();
        }

        /// <summary>
        /// Subscribe to title tag.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void title_SubscribeToTag(object sender, Args.TagsArgs args)
        {
            this.SubscribeToTag(sender, args);
        }
        #endregion

        #region User
        /// <summary>
        /// Loads the title.
        /// </summary>
        /// <param name="user">The user.</param>
        public void LoadTitle(Model.User.User user)
        {
            this.UserData = user;

            UserTitle title = new UserTitle();
            title.LoadData(user);
            title.FollowUser += new Delegates.Delegates.FollowUserHandler(title_FollowUser);
            title.Dock = DockStyle.Fill;
            this.pTitle.Controls.Clear();
            this.pTitle.Controls.Add(title);
            title.Show();
            title.BringToFront();
        }

        /// <summary>
        /// Title_s the follow user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void title_FollowUser(object sender, UsersArgs args)
        {
            this.FollowUser(sender, args);
        }
        #endregion

        #region Groups
        /// <summary>
        /// Loads the title.
        /// </summary>
        /// <param name="group">The group.</param>
        public void LoadTitle(Model.Group.Group group)
        {
            this.GroupData = group;
            GroupTitle title = new GroupTitle();
            title.LoadData(group);
            title.SubscribeToGroup += new Delegates.Delegates.SubscribeToGroupHandler(title_SubscribeToGroup);
            title.Dock = DockStyle.Fill;
            this.pTitle.Controls.Clear();
            this.pTitle.Controls.Add(title);
            title.Show();
            title.BringToFront();
        }

        /// <summary>
        /// Title_s the subscribe to group.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void title_SubscribeToGroup(object sender, GroupsArgs args)
        {
            this.SubscribeToGroup(sender, args);
        }

        #endregion


        /// <summary>
        /// Loads the publications.
        /// </summary>
        /// <param name="publicationsList">The publications list.</param>
        public void LoadPublications(List<Model.Publication.Publication> publicationsList)
        {
            this.pPublicationsList.Controls.Clear();
            foreach (Model.Publication.Publication publication in publicationsList)
            {
                XareuWFClient.Controls.Publication.Publication publicationControl = new Publication(publication);
                publicationControl.Dock = DockStyle.Top;
                this.pPublicationsList.Controls.Add(publicationControl);
            }
            this.setPaginationLinks();
        }

        /// <summary>
        /// Sets the pagination links.
        /// </summary>
        private void setPaginationLinks()
        {
            if (this.Page == 0)
            {
                this.paginationSearch.DisablePreviousLink();
            }
            else
            {
                this.paginationSearch.EnablePreviousLink();
            }
            if (this.pPublicationsList.Controls.Count == 10)
            {
                this.paginationSearch.EnableNextLink();
            }
            else
            {
                this.paginationSearch.DisableNextLink();
            }
        }


        #region Pagination

        /// <summary>
        /// Paginations the search_ call next page_1.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void paginationSearch_CallNextPage_1(object sender, PageArgs args)
        {
            if (this.TagData != null)
            {
                this.changePageTags(sender, args);
            }
        }

        /// <summary>
        /// Paginations the search_ call previous page_1.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void paginationSearch_CallPreviousPage_1(object sender, PageArgs args)
        {
            this.paginationSearch_CallNextPage_1(sender, args);
        }


        /// <summary>
        /// Changes the page tags.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void changePageTags(object sender, PageArgs args)
        {
            TagsArgs newArgs = new TagsArgs("", this.Page, this.TagData);
            this.Page = paginationSearch.Page;
            this.ChangeTagsPage(sender, newArgs);
        }



        #endregion
    }
}
