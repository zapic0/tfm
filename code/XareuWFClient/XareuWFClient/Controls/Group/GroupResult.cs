using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Args;

namespace XareuWFClient.Controls.Group
{
    public partial class GroupResult : UserControl
    {
        #region Events
        [Category("User Defined")]
        [Description("Subscribe to tag")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToGroupHandler SubscribeToGroup;

        [Category("User Defined")]
        [Description("Open tag results")]
        public event XareuWFClient.Delegates.Delegates.OpenGroupResultsHandler OpenGroupResults;
        #endregion

        public Model.Group.Group GroupData { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResult"/> class.
        /// </summary>
        public GroupResult()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <param name="group">The group.</param>
        public void LoadData(Model.Group.Group group)
        {
            this.GroupData = group;
            this.lTagText.Text = group.Name;
        }

        /// <summary>
        /// Handles the Click event of the bSubscribe control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bSubscribe_Click(object sender, EventArgs e)
        {
            GroupsArgs args = new GroupsArgs("", 0, this.GroupData);
            this.SubscribeToGroup(sender, args);
        }

        /// <summary>
        /// Handles the LinkClicked event of the lTagText control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lTagText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GroupsArgs args = new GroupsArgs("", 0, this.GroupData);
            this.OpenGroupResults(sender, args);
        }
    }
}
