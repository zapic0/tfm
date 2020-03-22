using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Args;
using XareuWFClient.Controls.User;

namespace XareuWFClient.Controls.Group
{
    public partial class GroupSearchPage : UserControl
    {
        public string TextSearched { get; set; }
        public int Page { get; set; }

        #region Events
        [Category("User Defined")]
        [Description("Search especified text")]
        public event SearchTextHandler SearchText;

        public delegate void SearchTextHandler(object sender, GroupsArgs args);

        [Category("User Defined")]
        [Description("Loads Next Page")]
        public event CallNextPageHandler CallNextPage;

        [Category("User Defined")]
        [Description("Loads Previous Page")]
        public event CallPreviousPageHandler CallPreviousPage;

        public delegate void CallNextPageHandler(object sender, GroupsArgs args);
        public delegate void CallPreviousPageHandler(object sender, GroupsArgs args);

        [Category("User Defined")]
        [Description("Subscribe to a Group")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToGroupHandler SubscribeToGroup;

        [Category("User Defined")]
        [Description("Open Groups Results")]
        public event XareuWFClient.Delegates.Delegates.OpenGroupResultsHandler OpenGroupResults;

        #endregion


        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSearchPage"/> class.
        /// </summary>
        public GroupSearchPage()
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
            Args.GroupsArgs groupArgs = new GroupsArgs(this.TextSearched, args.Page, null);
            this.CallNextPage(sender, groupArgs);
        }

        /// <summary>
        /// Pagination_s the call previous page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void pagination_CallPreviousPage(object sender, PageArgs args)
        {
            this.Page = args.Page;
            Args.GroupsArgs groupArgs = new GroupsArgs(this.TextSearched, args.Page, null);
            this.CallPreviousPage(sender, groupArgs);
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
            Args.GroupsArgs groupArgs = new GroupsArgs(args.Text, this.Page, null);
            this.SearchText(sender, groupArgs);
        }

        /// <summary>
        /// Loads the groups.
        /// </summary>
        /// <param name="groupsList">The groups list.</param>
        /// <param name="groupArgs">The group args.</param>
        public void LoadGroups(List<Model.Group.Group> groupsList, GroupsArgs groupArgs)
        {
            this.Page = groupArgs.Page;
            this.TextSearched = groupArgs.Text;
            this.pGroupsList.Controls.Clear();
            if (this.Page == 0)
            {
                this.pagination.DisablePreviousLink();
            }
            else
            {
                this.pagination.EnablePreviousLink();
            }
            if (groupsList.Count == 10)
            {
                this.pagination.EnableNextLink();
            }
            else
            {
                this.pagination.DisableNextLink();
            }
            foreach (Model.Group.Group group in groupsList)
            {
                GroupResult groupResult = new GroupResult();
                groupResult.LoadData(group);
                groupResult.Dock = DockStyle.Top;
                groupResult.SubscribeToGroup += new Delegates.Delegates.SubscribeToGroupHandler(groupResult_SubscribeToGroup);
                groupResult.OpenGroupResults += new Delegates.Delegates.OpenGroupResultsHandler(groupResult_OpenGroupResults);
                this.pGroupsList.Controls.Add(groupResult);
            }
        }

        /// <summary>
        /// Groups the result_ open group results.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void groupResult_OpenGroupResults(object sender, GroupsArgs args)
        {
            this.OpenGroupResults(sender, args);
        }

        /// <summary>
        /// Groups the result_ subscribe to group.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void groupResult_SubscribeToGroup(object sender, GroupsArgs args)
        {
            this.SubscribeToGroup(sender, args);
        }

    }
}
