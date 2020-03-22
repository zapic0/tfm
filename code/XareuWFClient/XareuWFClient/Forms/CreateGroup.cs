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
    public partial class CreateGroup : Form
    {
        Controller.GroupController groupController;
        Model.Session.Session session;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroup"/> class.
        /// </summary>
        public CreateGroup()
        {
            InitializeComponent();
            groupController = new Controller.GroupController();
        }

        /// <summary>
        /// Handles the Click event of the bAccept control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bAccept_Click(object sender, EventArgs e)
        {
            if (!Util.StringSanitizer.TestStringSanitizationWithoutBlank(this.tBGroupName.Text))
            {
                MessageBox.Show("Name must be formed of chars and numbers");
            }
            else
            {
                session = ((Forms.Main)this.Owner).Session;
                Guid newToken = Guid.Empty;

                try
                {
                    if (!groupController.CreateNewGroup(out newToken, session.User.Id, session.CurrentToken, this.tBGroupName.Text, session.User.Id))
                    {
                        MessageBox.Show("Group couldn't be created");
                    }
                    else
                    {
                        session.CurrentToken = newToken;
                        MessageBox.Show("Group created");
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Error creating group");
                }
            }
        }

    }
}
