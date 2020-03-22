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
    public partial class NewPublication : Form
    {
        Controller.PublicationController publicationController = new Controller.PublicationController();
        public Model.User.User User { get; set; }



        /// <summary>
        /// Initializes a new instance of the <see cref="NewPublication"/> class.
        /// </summary>
        public NewPublication()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the bCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bCancel_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the FormClosing event of the NewPublication control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        private void NewPublication_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel?", "Window will close", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                this.OnClosing(new CancelEventArgs(true));
            }
        }

        /// <summary>
        /// Handles the Click event of the bAccept control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bAccept_Click(object sender, EventArgs e)
        {
            //PublicationServices.Publication publication = new XareuWFClient.PublicationServices.Publication();
            //publication.IsQuestion = this.cBQuestion.Checked;
            //publication.Karma = 0;
            //publication.Text = rTBPublicationText.Text;
            //publication.CreationDateTime = DateTime.Now;
            //publication.Author = new XareuWFClient.PublicationServices.User();
            //publication.Author.DefaultPlace = new XareuWFClient.PublicationServices.TagPlace();
            //publication.Author.DefaultPlace.Id = this.User.DefaultPlace.Id;
            //publication.Author.DefaultPlace.Name = this.User.DefaultPlace.Name;
            //publication.Author.Email = this.User.Email;
            //publication.Author.Id = this.User.Id;
            //publication.Author.IsAdmin = this.User.IsAdmin;
            //publication.Author.IsPrivate = this.User.IsPrivate;
            //publication.Author.Karma = this.User.Karma;
            //publication.Author.Nick = this.User.Nick;
            //publication.Author.SignUp = this.User.SignUp;
            //publication.Place = publication.Author.DefaultPlace;

            

            //if (publicationServices.AddPublication(publication))
            //{
            //    MessageBox.Show("Publication added");
            //}
            //else
            //{
            //    MessageBox.Show("There was an error");
            //}
        }
    }
}
