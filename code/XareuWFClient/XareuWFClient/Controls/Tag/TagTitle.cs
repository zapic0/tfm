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
    public partial class TagTitle : UserControl
    {
        Model.Tag.Tag tagData;

        #region Events
        [Category("User Defined")]
        [Description("Subscribe to Tag")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToTagHandler SubscribeToTag;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="TagTitle"/> class.
        /// </summary>
        public TagTitle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void LoadData(Model.Tag.Tag tag)
        {
            this.tagData = tag;
            this.lTag.Text = this.tagData.Name;
            this.bSubscribe.Click += new EventHandler(bSubscribe_Click);
            this.Show();
        }

        #region Tags

        /// <summary>
        /// Handles the Click event of the bSubscribe control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void bSubscribe_Click(object sender, EventArgs e)
        {
            TagsArgs args = new TagsArgs("", 0, this.tagData);
            this.SubscribeToTag(sender, args);
        }
        #endregion
    }
}
