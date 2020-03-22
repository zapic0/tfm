using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XareuWFClient.Controls.Util
{
    public partial class GenericUserInformation : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericUserInformation"/> class.
        /// </summary>
        public GenericUserInformation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hides the buttons.
        /// </summary>
        public void HideButtons()
        {
            this.pActions.Hide();
        }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        public Model.User.User User { get; set; }

        /// <summary>
        /// Loads the data.
        /// </summary>
        public void LoadData()
        {
            if (this.User != null)
            {
                this.lKarma.Text = this.User.Karma.ToString();
                this.lUserName.Text = this.User.Nick;
                this.lUserLocation.Text = this.User.DefaultPlace.Name;
                //this.pBUserIcon.Image = Image.FromStream(this.User.UserPictureURL);
            }
        }
    }
}
