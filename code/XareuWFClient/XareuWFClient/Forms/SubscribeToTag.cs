using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XareuWFClient.Forms
{
    public partial class SubscribeToTag : Form
    {
        Controller.TagsController tagController;
        Model.Session.Session session;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeToTag"/> class.
        /// </summary>
        public SubscribeToTag()
        {
            InitializeComponent();
            tagController = new Controller.TagsController();
        }

        /// <summary>
        /// Handles the Click event of the bAccept control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bAccept_Click(object sender, EventArgs e)
        {
            session = ((Forms.Main)this.Owner).Session;
            Guid newToken = Guid.Empty;

            string tagName = this.tBTag.Text;

            Model.Tag.Tag tag = tagController.GetTagByName(tagName);
            long tagID = 1;
            if (tag == null)
            {
                tag = new Model.Tag.Tag();
                tag.Id = tagID;
                tag.Name = tagName;
                tagController.AddTag(out newToken, out tagID, session.User.Id, session.CurrentToken, tag);
                session.CurrentToken = newToken;
            }
            
            tagController.AddUserSubscription(out newToken, session.User.Id, session.CurrentToken, session.User.Id, tagID);

            session.CurrentToken = newToken;

            this.Close();
        }
    }
}
