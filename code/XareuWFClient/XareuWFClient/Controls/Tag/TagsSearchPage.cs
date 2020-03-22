using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Args;

namespace XareuWFClient.Controls.Tag
{
    public partial class TagsSearchPage : UserControl
    {
        public TagsArgs TagArgs { get; set; }

        #region Events
        [Category("User Defined")]
        [Description("Search especified text")]
        public event SearchTextHandler SearchText;

        public delegate void SearchTextHandler(object sender, TagsArgs args);

        [Category("User Defined")]
        [Description("Loads Next Following Page")]
        public event CallNextPageHandler CallNextPage;

        [Category("User Defined")]
        [Description("Loads Previous Following Page")]
        public event CallPreviousPageHandler CallPreviousPage;

        public delegate void CallNextPageHandler(object sender, TagsArgs args);
        public delegate void CallPreviousPageHandler(object sender, TagsArgs args);

        [Category("User Defined")]
        [Description("Subscribe to Tag")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToTagHandler SubscribeToTag;

        [Category("User Defined")]
        [Description("Open Tag Results")]
        public event XareuWFClient.Delegates.Delegates.OpenTagResultsHandler OpenTagResults;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsSearchPage"/> class.
        /// </summary>
        public TagsSearchPage()
        {
            InitializeComponent();
            this.TagArgs = new TagsArgs("", 0, new Model.Tag.Tag());
        }

        /// <summary>
        /// Searches the text control_ search text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void searchTextControl_SearchText(object sender, TagsArgs args)
        {
            this.SearchText(sender, args);
        }

        /// <summary>
        /// Pagination_s the call next page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void pagination_CallNextPage(object sender, PageArgs args)
        {
            TagsArgs newArgs = new TagsArgs(this.TagArgs.Text, args.Page, this.TagArgs.Tag);
            this.CallNextPage(sender, newArgs);
        }

        /// <summary>
        /// Pagination_s the call previous page.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void pagination_CallPreviousPage(object sender, PageArgs args)
        {
            TagsArgs newArgs = new TagsArgs(this.TagArgs.Text, args.Page, this.TagArgs.Tag);
            this.CallPreviousPage(sender, newArgs);
        }

        /// <summary>
        /// Loads the tags.
        /// </summary>
        /// <param name="tags">The tags.</param>
        /// <param name="args">The args.</param>
        public void LoadTags(List<Model.Tag.Tag> tags, TagsArgs args)
        {
            this.TagArgs = args;
            if (this.TagArgs.Page == 0)
            {
                this.pagination.DisablePreviousLink();
            }
            else
            {
                this.pagination.EnablePreviousLink();
            }
            this.pTagsList.Controls.Clear();
            foreach (Model.Tag.Tag tag in tags)
            {
                TagResult newTag = new TagResult();
                newTag.LoadData(tag);
                newTag.SubscribeToTag += new Delegates.Delegates.SubscribeToTagHandler(newTag_SubscribeToTag);
                newTag.OpenTagResults += new Delegates.Delegates.OpenTagResultsHandler(newTag_OpenTagResults);
                newTag.Dock = DockStyle.Top;
                this.pTagsList.Controls.Add(newTag);
            }
            if (this.pTagsList.Controls.Count == 10)
            {
                this.pagination.EnableNextLink();
            }
            else
            {
                this.pagination.DisableNextLink();
            }
        }

        /// <summary>
        /// News the tag_ open tag results.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void newTag_OpenTagResults(object sender, TagsArgs args)
        {
            this.OpenTagResults(sender, args);
        }

        /// <summary>
        /// Loads the tags.
        /// </summary>
        /// <param name="tags">The tags.</param>
        /// <param name="args">The args.</param>
        public void LoadTags(List<Model.Tag.Tag> tags, PageArgs args)
        {
            this.TagArgs.Page = args.Page;
            this.LoadTags(tags, this.TagArgs);
        }

        /// <summary>
        /// News the tag_ subscribe to tag.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        void newTag_SubscribeToTag(object sender, TagsArgs args)
        {
            this.SubscribeToTag(sender, args);
        }

        /// <summary>
        /// Searches the text control_ search text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        private void searchTextControl_SearchText(object sender, TextArgs args)
        {
            this.TagArgs.Text=args.Text;
            this.TagArgs.Page = 0;
            this.SearchText(sender, this.TagArgs);
        }

    }
}
