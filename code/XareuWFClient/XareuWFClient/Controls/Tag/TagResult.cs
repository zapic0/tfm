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
    public partial class TagResult : UserControl
    {
        #region Events
        [Category("User Defined")]
        [Description("Subscribe to tag")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToTagHandler SubscribeToTag;

        [Category("User Defined")]
        [Description("Open tag results")]
        public event XareuWFClient.Delegates.Delegates.OpenTagResultsHandler OpenTagResults;

        
        #endregion

        public Model.Tag.Tag TagData { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagResult"/> class.
        /// </summary>
        public TagResult()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void LoadData(Model.Tag.Tag tag)
        {
            this.TagData = tag;
            this.lTagText.Text = tag.Name;
        }

        /// <summary>
        /// Handles the Click event of the bSubscribe control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bSubscribe_Click(object sender, EventArgs e)
        {
            TagsArgs args = new TagsArgs("", 0, this.TagData);
            this.SubscribeToTag(sender, args);
        }

        /// <summary>
        /// Handles the LinkClicked event of the lTagText control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lTagText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TagsArgs args = new TagsArgs("", 0, this.TagData);
            this.OpenTagResults(sender, args);
        }
    }
}
