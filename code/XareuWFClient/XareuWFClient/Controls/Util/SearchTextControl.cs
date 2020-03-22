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
    public partial class SearchTextControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTextControl"/> class.
        /// </summary>
        public SearchTextControl()
        {
            InitializeComponent();
        }

        #region Events
        /// <summary>
        /// Occurs when [search text].
        /// </summary>
        [Category("User Defined")]
        [Description("Search especified text")]
        public event SearchTextHandler SearchText;

        public delegate void SearchTextHandler(object sender, TextArgs args);
        #endregion

        /// <summary>
        /// Handles the Click event of the bSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bSearch_Click(object sender, EventArgs e)
        {
            TextArgs args = new TextArgs(this.tBSearchText.Text);
            this.SearchText(sender, args);
        }

    }
}
