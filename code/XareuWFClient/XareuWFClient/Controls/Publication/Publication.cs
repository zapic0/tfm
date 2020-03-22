using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XareuWFClient.Controls.Publication
{
    public partial class Publication : UserControl
    {
        public Model.Publication.Publication PublicationData { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Publication"/> class.
        /// </summary>
        public Publication()
        {
            InitializeComponent();
            this.PublicationData = new XareuWFClient.Model.Publication.Publication();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Publication"/> class.
        /// </summary>
        /// <param name="publicationData">The publication data.</param>
        public Publication(Model.Publication.Publication publicationData)
        {
            InitializeComponent();
            this.PublicationData = publicationData;
            this.LoadPublicationData();
        }

        /// <summary>
        /// Loads the publication data.
        /// </summary>
        public void LoadPublicationData()
        {
            this.SetText(PublicationData.Text);
            this.SetKarma(PublicationData.Karma);
            this.SetVotes(PublicationData.PositiveVotes, PublicationData.NegativeVotes);
            this.SetUserName(PublicationData.Author.Nick);
            this.SetUserLocation(PublicationData.Author.DefaultPlace.Name);
        }

        /// <summary>
        /// Sets the colors.
        /// </summary>
        public void SetColors()
        {
            if (this.PublicationData.IsQuestion)
            {
                this.BackColor = Color.FromArgb(244, 226, 207);
                this.tBPublicationText.BackColor = Color.FromArgb(244, 226, 207);
                //this.BackgroundImageLayout = ImageLayout.Stretch;
                //this.BackgroundImage = Resources.backgroundQuestions;
            }
            else
            {
                this.BackColor = Color.FromArgb(238, 237, 237);
                this.tBPublicationText.BackColor = Color.FromArgb(238, 237, 237);
                //this.BackgroundImageLayout = ImageLayout.Stretch;
                //this.BackgroundImage = Resources.backgroundPublications;
            }
        }

        /// <summary>
        /// Gets or sets the background.
        /// </summary>
        /// <value>The background.</value>
        public Image Background { get; set; }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText(string text)
        {
            this.tBPublicationText.Text = text;
            string title = "";
            if (text.Length >= 20)
            {
                title = text.Substring(0, 20);
            }
            else
            {
                title = text;
            }
            this.lTitle.Text = title + "...";
        }

        /// <summary>
        /// Sets the karma.
        /// </summary>
        /// <param name="karma">The karma.</param>
        public void SetKarma(float karma)
        {
            this.vBVotes.Karma = karma;
        }

        /// <summary>
        /// Sets the votes.
        /// </summary>
        /// <param name="positives">The positives.</param>
        /// <param name="negatives">The negatives.</param>
        public void SetVotes(int positives, int negatives)
        {
            this.vBVotes.PositiveVotes = positives;
            this.vBVotes.NegativeVotes = negatives;
        }

        /// <summary>
        /// Sets the name of the user.
        /// </summary>
        /// <param name="name">The name.</param>
        public void SetUserName(string name)
        {
            this.lUserName.Text = name;
        }

        /// <summary>
        /// Sets the user location.
        /// </summary>
        /// <param name="location">The location.</param>
        public void SetUserLocation(string location)
        {
            this.lUserLocation.Text = location;
        }

    }
}
