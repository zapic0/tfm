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
    public partial class UserResult : UserControl
    {
        #region Events
        [Category("User Defined")]
        [Description("Follow a User")]
        public event XareuWFClient.Delegates.Delegates.FollowUserHandler FollowUser;

        [Category("User Defined")]
        [Description("Open user results")]
        public event XareuWFClient.Delegates.Delegates.OpenUserResultsHandler OpenUserResults;

        #endregion

        public Model.User.User UserData { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResult"/> class.
        /// </summary>
        public UserResult()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <param name="user">The user.</param>
        public void LoadData(Model.User.User user)
        {
            this.UserData = user;
            this.lUser.Text = user.Nick;
        }

        /// <summary>
        /// Handles the Click event of the bFollow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bFollow_Click(object sender, EventArgs e)
        {
            UsersArgs args = new UsersArgs("", 0, this.UserData);
            this.FollowUser(sender, args);
        }

        /// <summary>
        /// Handles the LinkClicked event of the lUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsersArgs args = new UsersArgs("", 0, this.UserData);
            this.OpenUserResults(sender, args);
        }
    }
}
