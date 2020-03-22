using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XareuWFClient.Forms
{
    public partial class Login : XareuWFClient.FBasicForm
    {
        Controller.LoginController loginController = new Controller.LoginController();
        Model.Session.Session session;


        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        public Login()
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
            session = ((Forms.Main)this.Owner).Session;
            bool login = loginController.LoginWithPassword(tBEmail.Text, tBPassword.Text, session);

            if (login)
            {
                MessageBox.Show("Login succesful");
                ((Main)(this.Owner)).LoadUser(session.User);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error trying to login");
            }
        }

        /// <summary>
        /// Handles the Click event of the bRegister control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bRegister_Click(object sender, EventArgs e)
        {
            session = ((Forms.Main)this.Owner).Session;
            Controller.UsersController userController = new Controller.UsersController();

            bool registered = userController.RegisterNewUser(this.tBNick.Text, this.tBNewMail.Text, this.tBNewPassword.Text, 1);

            if (registered)
            {
                MessageBox.Show("User succesfully registered, now you can login");
            }
            else
            {
                MessageBox.Show("Error registering new user");
            }
        }
    }
}
