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
    public partial class GroupTitle : UserControl
    {
        Model.Group.Group groupData;

        #region Events
        [Category("User Defined")]
        [Description("Subscribe to Tag")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToGroupHandler SubscribeToGroup;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupTitle"/> class.
        /// </summary>
        public GroupTitle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <param name="group">The group.</param>
        public void LoadData(Model.Group.Group group)
        {
            this.groupData = group;
            this.lGroup.Text = this.groupData.Name;
            this.bSubscribe.Click += new EventHandler(bSubscribe_Click);
            this.Show();
        }

        #region Groups
        /// <summary>
        /// Handles the Click event of the bSubscribe control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void bSubscribe_Click(object sender, EventArgs e)
        {
            GroupsArgs args = new GroupsArgs("", 0, this.groupData);
            this.SubscribeToGroup(sender, args);
        }
        #endregion
    }
}
