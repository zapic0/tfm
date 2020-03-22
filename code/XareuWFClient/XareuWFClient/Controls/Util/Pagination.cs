using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Args;

namespace XareuWFClient.Controls.Util
{
    public partial class Pagination : UserControl
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        /// <value>The page.</value>
        public int Page { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination"/> class.
        /// </summary>
        public Pagination()
        {
            InitializeComponent();
            Page = 0;
        }

        #region Events
        /// <summary>
        /// Occurs when [call next page].
        /// </summary>
        [Category("User Defined")]
        [Description("Loads Next Following Page")]
        public event CallNextPageHandler CallNextPage;

        /// <summary>
        /// Occurs when [call previous page].
        /// </summary>
        [Category("User Defined")]
        [Description("Loads Previous Following Page")]
        public event CallPreviousPageHandler CallPreviousPage;

        public delegate void CallNextPageHandler(object sender, PageArgs args);
        public delegate void CallPreviousPageHandler(object sender, PageArgs args);
        #endregion


        /// <summary>
        /// Enables the next link.
        /// </summary>
        public void EnableNextLink()
        {
            this.lLNextPage.Enabled = true;
        }

        /// <summary>
        /// Enables the previous link.
        /// </summary>
        public void EnablePreviousLink()
        {
            this.lLPreviousPage.Enabled = true;
        }

        /// <summary>
        /// Disables the next link.
        /// </summary>
        public void DisableNextLink()
        {
            this.lLNextPage.Enabled = false;
        }

        /// <summary>
        /// Disables the previous link.
        /// </summary>
        public void DisablePreviousLink()
        {
            this.lLPreviousPage.Enabled = false;
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLNextPage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLNextPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page++;
            PageArgs args = new PageArgs(Page);
            this.CallNextPage(sender, args);
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLPreviousPage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLPreviousPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page--;
            PageArgs args = new PageArgs(Page);
            this.CallPreviousPage(sender, args);
        }

    }
}
