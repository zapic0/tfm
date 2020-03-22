using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Controls;
using XareuWFClient.Args;
using XareuWFClient.Controls.Tag;
using XareuWFClient.Controls.Publication;
using XareuWFClient.Controls.User;
using XareuWFClient.Controls.Main;
using XareuWFClient.Controls.ControlPanel;
using XareuWFClient.Controls.Group;
using XareuWFClient.Model.Commands;

namespace XareuWFClient.Forms
{
    public partial class Main : XareuWFClient.FBasicForm
    {
        #region Properties
        /// <summary>
        /// Gets or sets the session.
        /// </summary>
        /// <value>The session.</value>
        public Model.Session.Session Session { get; set; }
        Controller.PublicationController publicationController;
        Controller.TagsController tagController;
        Controller.GroupController groupController;
        Controller.UsersController userController;
        Controller.TagsController tagsController;

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        private Model.User.User User { get; set; }
        /// <summary>
        /// Gets or sets the tags number.
        /// </summary>
        /// <value>The tags number.</value>
        public int TagsNumber { get; set; }
        /// <summary>
        /// Gets or sets the groups number.
        /// </summary>
        /// <value>The groups number.</value>
        public int GroupsNumber { get; set; }
        /// <summary>
        /// Gets or sets the control panel number.
        /// </summary>
        /// <value>The control panel number.</value>
        public int ControlPanelNumber { get; set; }

        TagsSearchPage tagsPage;
        UserSearchPage usersPage;
        GroupSearchPage groupsPage;
        PublicationsSearchResult searchPublicationPage;

        #endregion


        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            TagsNumber = 20;
            GroupsNumber = 20;
            ControlPanelNumber = 5;
            publicationController = new XareuWFClient.Controller.PublicationController();
            tagController = new Controller.TagsController();
            groupController = new Controller.GroupController();
            userController = new Controller.UsersController();
            tagsController = new Controller.TagsController();
            this.Session = new Model.Session.Session(this, this.bTabsMain);
            this.Session.Logged = false;
        }
        #endregion

        #region Load
        /// <summary>
        /// Handles the Load event of the Main control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Main_Load(object sender, EventArgs e)
        {
            this.bTabsMain_SelectNewPublicationsTab(sender, e);
        }
        #endregion

        #region User Information

        /// <summary>
        /// Loads the user.
        /// </summary>
        /// <param name="userData">The user data.</param>
        public void LoadUser(Model.User.User userData)
        {
            this.User = userData;
            this.userInformationPanel.LoadUserInfo(this.User);
        }

        /// <summary>
        /// Handles the ViewUser event of the userInformationPanel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void userInformationPanel_ViewUser(object sender, EventArgs args)
        {
            if (Session.Logged)
            {
                this.bTabsMain_SelectControlPanelTab(sender, args);
            }
        }

        #endregion


        #region Tags Page

        #region Public
        /// <summary>
        /// Creates the tags page.
        /// </summary>
        public void CreateTagsPage()
        {
            this.tagsPage = new TagsSearchPage();
            tagsPage.Dock = DockStyle.Fill;
            tagsPage.SearchText += new TagsSearchPage.SearchTextHandler(tags_SearchText);
            tagsPage.SubscribeToTag += new Delegates.Delegates.SubscribeToTagHandler(tags_SubscribeToTag);
            tagsPage.CallNextPage += new TagsSearchPage.CallNextPageHandler(tags_CallNextPage);
            tagsPage.CallPreviousPage += new TagsSearchPage.CallPreviousPageHandler(tags_CallPreviousPage);
            tagsPage.OpenTagResults += new Delegates.Delegates.OpenTagResultsHandler(tagsPage_OpenTagResults);
            this.pContent.Controls.Add(tagsPage);
            tagsPage.BringToFront();
            tagsPage.Show();
        }

        /// <summary>
        /// Creates the tags publications page.
        /// </summary>
        /// <param name="args">The args.</param>
        public void CreateTagsPublicationsPage(TagsArgs args)
        {
            try
            {
                this.searchPublicationPage = new PublicationsSearchResult();
                this.searchPublicationPage.LoadTitle(args.Tag);
                this.searchPublicationPage.LoadPublications(tagsController.GetPublicationsWithTag(args.Tag.Id, 10, 0));
                this.searchPublicationPage.Dock = DockStyle.Fill;
                this.searchPublicationPage.SubscribeToTag += new Delegates.Delegates.SubscribeToTagHandler(searchPage_SubscribeToTag);
                this.searchPublicationPage.ChangeTagsPage += new PublicationsSearchResult.ChangeTagsPageHandler(searchPage_ChangeTagsPage);
                this.pContent.Controls.Add(searchPublicationPage);
                searchPublicationPage.BringToFront();
                searchPublicationPage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Opens the tags search.
        /// </summary>
        /// <param name="args">The args.</param>
        public void OpenTagsSearch(TagsArgs args)
        {
            if (this.tagsPage == null)
            {
                this.CreateTagsPage();
            }
            this.tagsPage.LoadTags(tagsController.SearchTag(args.Text, 10, args.Page), args);
            tagsPage.BringToFront();
            tagsPage.Show();
        }

        /// <summary>
        /// Opens the tags publications page.
        /// </summary>
        /// <param name="args">The args.</param>
        public void OpenTagsPublicationsPage(TagsArgs args)
        {
            if (this.searchPublicationPage == null)
            {
                this.CreateTagsPublicationsPage(args);
            }
            this.searchPublicationPage.LoadPublications(tagsController.GetPublicationsWithTag(args.Tag.Id, 10, 0));
            searchPublicationPage.BringToFront();
            searchPublicationPage.Show();
        }
        #endregion

        #region Tags Page
        /// <summary>
        /// Handles the SelectTagsTab event of the bTabsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTabsMain_SelectTagsTab(object sender, EventArgs args)
        {
            this.callTagsTab(new TagsArgs("", 0, null));
        }

        /// <summary>
        /// Tags_s the call previous page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void tags_CallPreviousPage(object sender, TagsArgs args)
        {
            this.callTagsTab(args);
        }

        /// <summary>
        /// Tags_s the call next page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void tags_CallNextPage(object sender, TagsArgs args)
        {
            this.callTagsTab(args);
        }

        /// <summary>
        /// Tags_s the search text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void tags_SearchText(object sender, TagsArgs args)
        {
            this.callTagsTab(args);
        }
        #endregion

        #region Tag Publications Page
        /// <summary>
        /// Tagses the page_ open tag results.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void tagsPage_OpenTagResults(object sender, TagsArgs args)
        {
            this.callTagsTab(args);
        }

        /// <summary>
        /// Searches the page_ change tags page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void searchPage_ChangeTagsPage(object sender, TagsArgs args)
        {
            this.callTagsTab(args);
        }
        #endregion

        #region Call to Form Controller
        /// <summary>
        /// Calls the tags tab.
        /// </summary>
        /// <param name="args">The args.</param>
        private void callTagsTab(TagsArgs args)
        {
            Command command = new Command();
            command.Tab = "tags";
            command.Args = args;
            this.Session.FormController.AddCommand(command);
        }
        #endregion

        #region Tag suscription
        /// <summary>
        /// Subscribes to tag.
        /// </summary>
        /// <param name="args">The args.</param>
        private void subscribeToTag(TagsArgs args)
        {
            try
            {
                Guid newToken = Guid.Empty;
                this.tagsController.AddUserSubscription(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, args.Tag.Id);
                this.Session.CurrentToken = newToken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Searches the page_ subscribe to tag.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void searchPage_SubscribeToTag(object sender, TagsArgs args)
        {
            this.subscribeToTag(args);
        }

        /// <summary>
        /// Tags_s the subscribe to tag.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void tags_SubscribeToTag(object sender, TagsArgs args)
        {
            this.subscribeToTag(args);
        }
        #endregion

        #endregion

        #region Users Page
        #region Public
        /// <summary>
        /// Creates the users page.
        /// </summary>
        public void CreateUsersPage()
        {
            this.usersPage = new UserSearchPage();
            usersPage.Dock = DockStyle.Fill;
            usersPage.SearchText += new Delegates.Delegates.SearchTextHandler(usersPage_SearchText);
            usersPage.FollowUser += new Delegates.Delegates.FollowUserHandler(usersPage_FollowUser);
            usersPage.CallNextPage += new UserSearchPage.CallNextPageHandler(usersPage_CallNextPage);
            usersPage.CallPreviousPage += new UserSearchPage.CallPreviousPageHandler(usersPage_CallPreviousPage);
            usersPage.OpenUserResults += new Delegates.Delegates.OpenUserResultsHandler(usersPage_OpenUserResults);
            this.pContent.Controls.Add(usersPage);
            usersPage.BringToFront();
            usersPage.Show();
        }

        /// <summary>
        /// Creates the users publications page.
        /// </summary>
        /// <param name="args">The args.</param>
        public void CreateUsersPublicationsPage(UsersArgs args)
        {
            try
            {
                this.searchPublicationPage = new PublicationsSearchResult();
                this.searchPublicationPage.LoadTitle(args.User);
                Guid newToken = Session.CurrentToken;
                this.searchPublicationPage.LoadPublications(publicationController.GetUserPublications(out newToken, Session.User.Id, Session.CurrentToken, args.User.Id, 10, args.Page, true, true));
                Session.CurrentToken = newToken;
                this.searchPublicationPage.Dock = DockStyle.Fill;
                this.searchPublicationPage.FollowUser += new Delegates.Delegates.FollowUserHandler(searchPublicationPage_FollowUser);
                this.searchPublicationPage.ChangeUsersPage += new PublicationsSearchResult.ChangeUsersPageHandler(searchPublicationPage_ChangeUsersPage);
                this.pContent.Controls.Add(searchPublicationPage);
                searchPublicationPage.BringToFront();
                searchPublicationPage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Loads the user publications.
        /// </summary>
        /// <param name="args">The args.</param>
        public void LoadUserPublications(UsersArgs args)
        {
            if (this.searchPublicationPage == null)
            {
                this.CreateUsersPublicationsPage(args);
            }
            Guid newToken = Session.CurrentToken;
            this.searchPublicationPage.LoadPublications(publicationController.GetUserPublications(out newToken, Session.User.Id, Session.CurrentToken, args.User.Id, 10, args.Page, true, true));
            Session.CurrentToken = newToken;
            searchPublicationPage.BringToFront();
            searchPublicationPage.Show();
        }

        /// <summary>
        /// Loads the users search.
        /// </summary>
        /// <param name="args">The args.</param>
        public void LoadUsersSearch(UsersArgs args)
        {
            if (this.tagsPage == null)
            {
                this.CreateUsersPage();
            }
            this.usersPage.LoadUsers(userController.SearchUsersByNick(args.Text, 10, args.Page), args);

        }
        
        #endregion

        #region Call to Form Controller
        /// <summary>
        /// Calls the users tab.
        /// </summary>
        /// <param name="args">The args.</param>
        private void callUsersTab(UsersArgs args)
        {
            Command command = new Command();
            command.Tab = "users";
            command.Args = args;
            this.Session.FormController.AddCommand(command);
        }
        #endregion

        #region Users Page
        /// <summary>
        /// Userses the page_ search text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void usersPage_SearchText(object sender, UsersArgs args)
        {
            this.callUsersTab(args);
        }

        /// <summary>
        /// Userses the page_ open user results.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void usersPage_OpenUserResults(object sender, UsersArgs args)
        {
            this.callUsersTab(args);
        }

        /// <summary>
        /// Handles the SelectUsersTab event of the bTabsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTabsMain_SelectUsersTab(object sender, EventArgs args)
        {
            this.callUsersTab(new UsersArgs("", 0, null));
        }

        /// <summary>
        /// Userses the page_ call previous page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void usersPage_CallPreviousPage(object sender, UsersArgs args)
        {
            this.callUsersTab(args);
        }

        /// <summary>
        /// Userses the page_ call next page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void usersPage_CallNextPage(object sender, UsersArgs args)
        {
            this.callUsersTab(args);
        }
        #endregion

        #region User Publications

        /// <summary>
        /// Searches the publication page_ change users page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void searchPublicationPage_ChangeUsersPage(object sender, UsersArgs args)
        {
            this.callUsersTab(args);
        }
        #endregion

        #region User Follow

        /// <summary>
        /// Follows the user.
        /// </summary>
        /// <param name="args">The args.</param>
        private void FollowUser(UsersArgs args)
        {
            try
            {
                Guid newToken = Guid.Empty;
                this.userController.AddFollowRequest(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, args.User.Id);
                this.Session.CurrentToken = newToken;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to add follow request - " + ex.Message);
            }
        }

        /// <summary>
        /// Userses the page_ follow user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void usersPage_FollowUser(object sender, UsersArgs args)
        {
            this.FollowUser(args);
        }

        /// <summary>
        /// Searches the publication page_ follow user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void searchPublicationPage_FollowUser(object sender, UsersArgs args)
        {
            this.FollowUser(args);
        }
        #endregion
        #endregion

        #region Groups Page
        #region Public
        /// <summary>
        /// Creates the groups page.
        /// </summary>
        public void CreateGroupsPage()
        {
            this.groupsPage = new GroupSearchPage();
            groupsPage.Dock = DockStyle.Fill;
            groupsPage.SearchText += new GroupSearchPage.SearchTextHandler(groupsPage_SearchText);
            groupsPage.SubscribeToGroup += new Delegates.Delegates.SubscribeToGroupHandler(groupsPage_SubscribeToGroup);
            groupsPage.CallNextPage += new GroupSearchPage.CallNextPageHandler(groupsPage_CallNextPage);
            groupsPage.CallPreviousPage += new GroupSearchPage.CallPreviousPageHandler(groupsPage_CallPreviousPage);
            groupsPage.OpenGroupResults += new Delegates.Delegates.OpenGroupResultsHandler(groupsPage_OpenGroupResults);

            this.pContent.Controls.Add(groupsPage);
            groupsPage.BringToFront();
            groupsPage.Show();
        }

        /// <summary>
        /// Creates the group publications page.
        /// </summary>
        /// <param name="args">The args.</param>
        public void CreateGroupPublicationsPage(GroupsArgs args)
        {
            try
            {
                this.searchPublicationPage = new PublicationsSearchResult();
                this.searchPublicationPage.LoadTitle(args.Group);
                Guid newToken = Session.CurrentToken;
                this.searchPublicationPage.LoadPublications(publicationController.GetPublicationsForGroup(out newToken, args.Group.Id, Session.CurrentToken, Session.User.Id, 10, 0));
                Session.CurrentToken = newToken;
                this.searchPublicationPage.Dock = DockStyle.Fill;
                this.searchPublicationPage.SubscribeToGroup += new Delegates.Delegates.SubscribeToGroupHandler(searchPublicationPage_SubscribeToGroup);
                this.searchPublicationPage.ChangeGroupsPage += new PublicationsSearchResult.ChangeGroupsPageHandler(searchPublicationPage_ChangeGroupsPage);
                this.pContent.Controls.Add(searchPublicationPage);
                searchPublicationPage.BringToFront();
                searchPublicationPage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Loads the group publications.
        /// </summary>
        /// <param name="args">The args.</param>
        public void LoadGroupPublications(GroupsArgs args)
        {
            if (this.searchPublicationPage == null)
            {
                this.CreateGroupPublicationsPage(args);
            }
            try
            {
                Guid newToken = Session.CurrentToken;

                this.searchPublicationPage.LoadPublications(publicationController.GetPublicationsForGroup(out newToken, args.Group.Id, Session.CurrentToken, Session.User.Id, 10, args.Page));

                Session.CurrentToken = newToken;
                this.searchPublicationPage.BringToFront();
                this.searchPublicationPage.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while trying to load group publications " + ex.Message);
            }
        }

        /// <summary>
        /// Loads the groups page.
        /// </summary>
        /// <param name="args">The args.</param>
        public void LoadGroupsPage(GroupsArgs args)
        {
            if (this.groupsPage == null)
            {
                this.CreateGroupPublicationsPage(args);
            }
            this.groupsPage.LoadGroups(groupController.SearchGroupsByName(args.Text, 10, args.Page), args);
            this.groupsPage.BringToFront();
            this.groupsPage.Show();
        }

        #endregion

        #region Call to Form Controller
        /// <summary>
        /// Calls the groups page.
        /// </summary>
        /// <param name="args">The args.</param>
        private void callGroupsPage(GroupsArgs args)
        {
            Command command = new Command();
            command.Tab = "groups";
            command.Args = args;
            this.Session.FormController.AddCommand(command);
        }
        #endregion

        #region Groups Page
        /// <summary>
        /// Handles the SelectGroupsTab event of the bTabsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTabsMain_SelectGroupsTab(object sender, EventArgs args)
        {
            this.callGroupsPage(new GroupsArgs("", 0, null));
        }

        /// <summary>
        /// Groupses the page_ open group results.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void groupsPage_OpenGroupResults(object sender, GroupsArgs args)
        {
            this.callGroupsPage(args);
        }

        /// <summary>
        /// Groupses the page_ call previous page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void groupsPage_CallPreviousPage(object sender, GroupsArgs args)
        {
            this.callGroupsPage(args);
        }

        /// <summary>
        /// Groupses the page_ call next page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void groupsPage_CallNextPage(object sender, GroupsArgs args)
        {
            this.callGroupsPage(args);
        }

        /// <summary>
        /// Groupses the page_ search text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void groupsPage_SearchText(object sender, GroupsArgs args)
        {
            this.callGroupsPage(args);
        }

        #endregion

        #region Group Publications

        /// <summary>
        /// Searches the publication page_ change groups page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void searchPublicationPage_ChangeGroupsPage(object sender, GroupsArgs args)
        {
            this.callGroupsPage(args);
        }

        #endregion

        #region Group Subscription

        /// <summary>
        /// Groups the subscription.
        /// </summary>
        /// <param name="args">The args.</param>
        private void groupSubscription(GroupsArgs args)
        {
            try
            {
                Guid newGuid = Guid.Empty;
                groupController.AddJoinRequest(out newGuid, this.Session.User.Id, this.Session.CurrentToken, args.Group.Id, this.Session.User.Id);
                this.Session.CurrentToken = newGuid;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while trying to add subscription to group  - " + ex.Message);
            }
        }

        /// <summary>
        /// Searches the publication page_ subscribe to group.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void searchPublicationPage_SubscribeToGroup(object sender, GroupsArgs args)
        {
            this.groupSubscription(args);
        }

        /// <summary>
        /// Groupses the page_ subscribe to group.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void groupsPage_SubscribeToGroup(object sender, GroupsArgs args)
        {
            this.groupSubscription(args);
        }
        #endregion
        #endregion

        #region Last Publications
        #region Public
        /// <summary>
        /// Creates the new publications page.
        /// </summary>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        public void CreateNewPublicationsPage(EventArgs args)
        {
            this.pContent.Controls.Clear();
            publicationColumns = new PublicationColumns();
            publicationColumns.PublicationPage = 0;
            publicationColumns.QuestionsPage = 0;
            publicationColumns.ResultsPerPage = 10;
            publicationColumns.LoadNextPublicationPage += new PublicationColumns.LoadNextPublicationPageHandler(publicationColumns_LoadNextPublicationPage);
            publicationColumns.LoadNextQuestionPage += new PublicationColumns.LoadNextQuestionPageHandler(publicationColumns_LoadNextQuestionPage);
            publicationColumns.LoadPreviousPublicationPage += new PublicationColumns.LoadPreviousPublicationPageHandler(publicationColumns_LoadPreviousPublicationPage);
            publicationColumns.LoadPreviousQuestionPage += new PublicationColumns.LoadPreviousQuestionPageHandler(publicationColumns_LoadPreviousQuestionPage);
            this.LoadPublicationsColumn();
            this.LoadQuestionsColumn();
            this.publicationColumns.Dock = DockStyle.Fill;
            this.pContent.Controls.Add(publicationColumns);
            this.publicationColumns.BringToFront();
            this.publicationColumns.Show();
        }

        /// <summary>
        /// Loads the publications column.
        /// </summary>
        public void LoadPublicationsColumn()
        {
            try
            {
                this.publicationColumns.LoadPublicationsList(this.publicationController.GetAllPublications(this.publicationColumns.PublicationPage, this.publicationColumns.ResultsPerPage));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Loads the questions column.
        /// </summary>
        public void LoadQuestionsColumn()
        {
            try
            {
                this.publicationColumns.LoadQuestionsList(this.publicationController.GetAllQuestions(this.publicationColumns.QuestionsPage, this.publicationColumns.ResultsPerPage));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Call to Form Controller
        /// <summary>
        /// Calls the new publications page.
        /// </summary>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void callNewPublicationsPage(EventArgs args)
        {
            Command command = new Command();
            command.Tab = "newPublications";
            command.Args = args;
            this.Session.FormController.AddCommand(command);
        }
        #endregion

        #region New Publications Page
        /// <summary>
        /// Handles the SelectNewPublicationsTab event of the bTabsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTabsMain_SelectNewPublicationsTab(object sender, EventArgs args)
        {
            this.callNewPublicationsPage(args);
        }

        /// <summary>
        /// Handles the LoadNextPublicationPage event of the publicationColumns control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void publicationColumns_LoadNextPublicationPage(object sender, EventArgs args)
        {
            this.callNewPublicationsPage(args);
        }

        /// <summary>
        /// Handles the LoadNextQuestionPage event of the publicationColumns control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void publicationColumns_LoadNextQuestionPage(object sender, EventArgs args)
        {
            this.callNewPublicationsPage(args);
        }

        /// <summary>
        /// Handles the LoadPreviousPublicationPage event of the publicationColumns control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void publicationColumns_LoadPreviousPublicationPage(object sender, EventArgs args)
        {
            this.callNewPublicationsPage(args);
        }

        /// <summary>
        /// Handles the LoadPreviousQuestionPage event of the publicationColumns control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void publicationColumns_LoadPreviousQuestionPage(object sender, EventArgs args)
        {
            this.callNewPublicationsPage(args);
        }
        #endregion
        #endregion

        #region Control Panel
        #region Public
        /// <summary>
        /// Creates the control panel page.
        /// </summary>
        public void CreateControlPanelPage()
        {
            this.controlPanel = new ControlPanel();

            try
            {
                Guid newToken;
                this.controlPanel.LoadSubscribedTags(tagController.GetAllUserSubscriptions(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, TagsNumber, 0));
                this.Session.CurrentToken = newToken;
                this.controlPanel.LoadOwnGroups(groupController.GetUserOwnGroups(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, GroupsNumber, 0));
                this.Session.CurrentToken = newToken;
                this.controlPanel.LoadFollowingList(userController.GetUserOwnFollows(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, this.ControlPanelNumber, 0));
                this.Session.CurrentToken = newToken;
                this.controlPanel.LoadFollowersRequestList(userController.GetUserFollowRequests(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, this.ControlPanelNumber, 0));
                this.Session.CurrentToken = newToken;
                this.controlPanel.LoadFollowersList(userController.GetUserFollowers(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, this.ControlPanelNumber, 0));
                this.Session.CurrentToken = newToken;

                this.controlPanel.SubscribeToTag += new Delegates.Delegates.SubscribeToTagHandler(controlPanel_SubscribeToTag);
                this.controlPanel.CreateNewGroup += new ControlPanel.CreateNewGroupHandler(controlPanel_CreateNewGroup);

                this.controlPanel.LoadFollowersListEvent += new ControlPanel.LoadFollowersListHandler(controlPanel_LoadFollowersListEvent);
                this.controlPanel.LoadFollowersRequestListEvent += new ControlPanel.LoadFollowersRequestListHandler(controlPanel_LoadFollowersRequestListEvent);
                this.controlPanel.LoadFollowingListEvent += new ControlPanel.LoadFollowingListHandler(controlPanel_LoadFollowingListEvent);

                this.pContent.Controls.Clear();
                this.pContent.Controls.Add(this.controlPanel);
                this.controlPanel.Dock = DockStyle.Fill;
                this.controlPanel.BringToFront();
                this.controlPanel.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Call to Form Controller
        /// <summary>
        /// Calls the control panel page.
        /// </summary>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void callControlPanelPage(EventArgs args)
        {
            Command command = new Command();
            command.Tab = "controlPanel";
            command.Args = args;
            this.Session.FormController.AddCommand(command);
        }
        #endregion

        #region Control Panel Page
        /// <summary>
        /// Handles the SelectControlPanelTab event of the bTabsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTabsMain_SelectControlPanelTab(object sender, EventArgs args)
        {
            this.callControlPanelPage(args);
        }

        /// <summary>
        /// Controls the panel_ subscribe to tag.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void controlPanel_SubscribeToTag(object sender, TagsArgs args)
        {
            try
            {
                Forms.SubscribeToTag subscribeToTag = new SubscribeToTag();
                subscribeToTag.ShowDialog(this);
                //this.showControlPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the CreateNewGroup event of the controlPanel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void controlPanel_CreateNewGroup(object sender, EventArgs args)
        {
            try
            {
                Forms.CreateGroup createGroup = new CreateGroup();
                createGroup.ShowDialog(this);
                //this.showControlPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Controls the panel_ load following list event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void controlPanel_LoadFollowingListEvent(object sender, PageArgs args)
        {
            try
            {
                List<Model.User.UserFollow> userFollowingList;
                Guid newToken = Guid.Empty;
                userFollowingList = userController.GetUserOwnFollows(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, this.ControlPanelNumber, args.Page);
                this.Session.CurrentToken = newToken;
                this.controlPanel.LoadFollowingList(userFollowingList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Controls the panel_ load followers request list event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void controlPanel_LoadFollowersRequestListEvent(object sender, PageArgs args)
        {
            try
            {
                List<Model.User.UserFollowRequest> userFollowerRequestList;
                Guid newToken = Guid.Empty;
                userFollowerRequestList = userController.GetUserFollowRequests(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, this.ControlPanelNumber, args.Page);
                this.Session.CurrentToken = newToken;
                this.controlPanel.LoadFollowersRequestList(userFollowerRequestList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Controls the panel_ load followers list event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void controlPanel_LoadFollowersListEvent(object sender, PageArgs args)
        {
            try
            {
                List<Model.User.UserFollow> userFollowersList;
                Guid newToken = Guid.Empty;
                userFollowersList = userController.GetUserFollowers(out newToken, Session.User.Id, Session.CurrentToken, Session.User.Id, this.ControlPanelNumber, args.Page);
                this.Session.CurrentToken = newToken;
                this.controlPanel.LoadFollowersList(userFollowersList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #endregion



        /// <summary>
        /// Handles the AddNewPublication event of the bTabsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTabsMain_AddNewPublication(object sender, EventArgs args)
        {
            NewPublication newPublication = new NewPublication();
            newPublication.ShowDialog();
        }

        /// <summary>
        /// Handles the SelectMyInterestsTab event of the bTabsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTabsMain_SelectMyInterestsTab(object sender, EventArgs args)
        {

        }

        /// <summary>
        /// Handles the SelectMyPublicationsTab event of the bTabsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTabsMain_SelectMyPublicationsTab(object sender, EventArgs args)
        {

        }

        /// <summary>
        /// Handles the SelectPublicationsTab event of the bTabsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTabsMain_SelectPublicationsTab(object sender, EventArgs args)
        {

        }

        

        
    }
}
