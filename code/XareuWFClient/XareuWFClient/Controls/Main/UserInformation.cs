using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace XareuWFClient.Controls.Main
{
    public partial class UserInformation : UserControl
    {
        [Category("User Defined")]
        [Description("Opens the User Control Panel")]
        public event ViewUserHandler ViewUser;

        public delegate void ViewUserHandler(object sender, EventArgs args);

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInformation"/> class.
        /// </summary>
        public UserInformation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the bLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bLogin_Click(object sender, EventArgs e)
        {
            Forms.Login loginForm = new XareuWFClient.Forms.Login();
            Model.Session.Session session = ((Forms.Main)this.ParentForm).Session;
            loginForm.ShowDialog(this.ParentForm);
        }

        /// <summary>
        /// Loads the user info.
        /// </summary>
        /// <param name="userInfo">The user info.</param>
        public void LoadUserInfo(Model.User.User userInfo)
        {
            this.lKarma.Text = "Karma: " + userInfo.Karma.ToString();
            this.lUserName.Text = userInfo.Nick;
            this.lUserLocation.Text = userInfo.DefaultPlace.Name.ToString();
            //System.IO.Stream stream = (Stream)(new System.IO.StreamReader(userInfo.UserPictureURL));
            //this.pBUserImage.Image = Image.FromStream(stream);

            this.bLogin.Visible = false;
            this.bDisconnect.Visible = true;
        }

        /// <summary>
        /// Handles the Click event of the lUserName control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void lUserName_Click(object sender, EventArgs e)
        {
            this.ViewUser(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the bDisconnect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bDisconnect_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to disconnect?", "Atention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.bDisconnect.Visible = false;
                this.lUserName.Text = "Unknowkn user";
                this.lUserLocation.Text = "Unknown place";
                this.lKarma.Text = "Karma: Unknown";
                this.bLogin.Visible = true;
            }
        }
    }
}
