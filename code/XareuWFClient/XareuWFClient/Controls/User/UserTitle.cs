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
    public partial class UserTitle : UserControl
    {
        Model.User.User userData;

        #region Events
        [Category("User Defined")]
        [Description("Follo a User")]
        public event XareuWFClient.Delegates.Delegates.FollowUserHandler FollowUser;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTitle"/> class.
        /// </summary>
        public UserTitle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <param name="user">The user.</param>
        public void LoadData(Model.User.User user)
        {
            this.userData = user;
            this.lUser.Text = this.userData.Nick;
            this.bFollow.Click += new EventHandler(bFollow_Click);
            this.Show();
        }

        /// <summary>
        /// Handles the Click event of the bFollow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void bFollow_Click(object sender, EventArgs e)
        {
            UsersArgs args = new UsersArgs("", 0, this.userData);
            this.FollowUser(sender, args);
        }
    }
}
