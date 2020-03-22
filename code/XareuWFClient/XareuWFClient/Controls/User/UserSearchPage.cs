using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Args;

namespace XareuWFClient.Controls.User
{
    public partial class UserSearchPage : UserControl
    {
        public string TextSearched { get; set; }
        public int Page { get; set; }

        #region Events
        [Category("User Defined")]
        [Description("Search especified text")]
        public event XareuWFClient.Delegates.Delegates.SearchTextHandler SearchText;

        

        [Category("User Defined")]
        [Description("Loads Next Page")]
        public event CallNextPageHandler CallNextPage;

        [Category("User Defined")]
        [Description("Loads Previous Page")]
        public event CallPreviousPageHandler CallPreviousPage;

        public delegate void CallNextPageHandler(object sender, UsersArgs args);
        public delegate void CallPreviousPageHandler(object sender, UsersArgs args);

        [Category("User Defined")]
        [Description("Follow a user")]
        public event XareuWFClient.Delegates.Delegates.FollowUserHandler FollowUser;

        [Category("User Defined")]
        [Description("Open User Results")]
        public event XareuWFClient.Delegates.Delegates.OpenUserResultsHandler OpenUserResults;

        #endregion


        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchPage"/> class.
        /// </summary>
        public UserSearchPage()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Pagination_s the call next page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void pagination_CallNextPage(object sender, PageArgs args)
        {
            this.Page = args.Page;
            Args.UsersArgs userArgs = new UsersArgs(this.TextSearched, args.Page, null);
            this.CallNextPage(sender, userArgs);
        }

        /// <summary>
        /// Pagination_s the call previous page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void pagination_CallPreviousPage(object sender, PageArgs args)
        {
            this.Page = args.Page;
            Args.UsersArgs userArgs = new UsersArgs(this.TextSearched, args.Page, null);
            this.CallPreviousPage(sender, userArgs);
        }

        /// <summary>
        /// Searches the text control_ search text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void searchTextControl_SearchText(object sender, TextArgs args)
        {
            this.Page = 0;
            this.TextSearched = args.Text;
            Args.UsersArgs userArgs = new UsersArgs(args.Text, this.Page, null);
            this.SearchText(sender, userArgs);
        }

        /// <summary>
        /// Loads the users.
        /// </summary>
        /// <param name="usersList">The users list.</param>
        /// <param name="userArgs">The user args.</param>
        public void LoadUsers(List<Model.User.User> usersList, UsersArgs userArgs)
        {
            this.Page = userArgs.Page;
            this.TextSearched = userArgs.Text;
            this.pUsersList.Controls.Clear();
            if (this.Page == 0)
            {
                this.pagination.DisablePreviousLink();
            }
            else
            {
                this.pagination.EnablePreviousLink();
            }
            if (usersList.Count == 10)
            {
                this.pagination.EnableNextLink();
            }
            else
            {
                this.pagination.DisableNextLink();
            }
            foreach (Model.User.User user in usersList)
            {
                UserResult userResult = new UserResult();
                userResult.LoadData(user);
                userResult.Dock = DockStyle.Top;
                userResult.FollowUser += new Delegates.Delegates.FollowUserHandler(userResult_FollowUser);
                userResult.OpenUserResults += new Delegates.Delegates.OpenUserResultsHandler(userResult_OpenUserResults);
                this.pUsersList.Controls.Add(userResult);
            }
        }

        /// <summary>
        /// Users the result_ open user results.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void userResult_OpenUserResults(object sender, UsersArgs args)
        {
            this.OpenUserResults(sender, args);
        }

        /// <summary>
        /// Users the result_ follow user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void userResult_FollowUser(object sender, UsersArgs args)
        {
            this.FollowUser(sender, args);
        }

    }
}
