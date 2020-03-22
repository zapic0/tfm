using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Properties;
using XareuWFClient.Controls.Publication;

namespace XareuWFClient.Controls.Main
{
    public partial class PublicationColumns : UserControl
    {
        public int QuestionsPage { get; set; }
        public int PublicationPage { get; set; }
        public int ResultsPerPage { get; set; }


        #region Events
        [Category("User Defined")]
        [Description("Loads Next Questions Page")]
        public event LoadNextQuestionPageHandler LoadNextQuestionPage;

        [Category("User Defined")]
        [Description("Loads Previous Questions Page")]
        public event LoadPreviousQuestionPageHandler LoadPreviousQuestionPage;

        [Category("User Defined")]
        [Description("Loads Next Publications Page")]
        public event LoadNextPublicationPageHandler LoadNextPublicationPage;

        [Category("User Defined")]
        [Description("Loads Previous Publications Page")]
        public event LoadPreviousPublicationPageHandler LoadPreviousPublicationPage;

        public delegate void LoadNextQuestionPageHandler(object sender, EventArgs args);
        public delegate void LoadPreviousQuestionPageHandler(object sender, EventArgs args);
        public delegate void LoadNextPublicationPageHandler(object sender, EventArgs args);
        public delegate void LoadPreviousPublicationPageHandler(object sender, EventArgs args);
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationColumns"/> class.
        /// </summary>
        public PublicationColumns()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            PublicationPage = 0;
            QuestionsPage = 0;
            this.setLinksStatus();
        }

        /// <summary>
        /// Clears the columns.
        /// </summary>
        public void Clear()
        {
            this.PublicationPage = 0;
            this.QuestionsPage = 0;
            this.pQuestionsList.Controls.Clear();
            this.pPublicationsList.Controls.Clear();
            this.setLinksStatus();
        }

        /// <summary>
        /// Clears the publications list.
        /// </summary>
        public void ClearPublicationsList()
        {
            this.PublicationPage = 0;
            this.pPublicationsList.Controls.Clear();
            this.setLinksStatus();
        }

        /// <summary>
        /// Clears the questions list.
        /// </summary>
        public void ClearQuestionsList()
        {
            this.QuestionsPage = 0;
            this.pQuestionsList.Controls.Clear();
            this.setLinksStatus();
        }

        /// <summary>
        /// Loads the questions list.
        /// </summary>
        /// <param name="publicationList">The publication list.</param>
        public void LoadQuestionsList(List<Model.Publication.Publication> publicationList)
        {
            foreach (Model.Publication.Publication publication in publicationList)
            {
                XareuWFClient.Controls.Publication.Publication publicationControl = new XareuWFClient.Controls.Publication.Publication(publication);
                this.AddQuestion(publicationControl);
            }
            this.setLinksStatus();
        }

        /// <summary>
        /// Loads the publications list.
        /// </summary>
        /// <param name="publicationList">The publication list.</param>
        public void LoadPublicationsList(List<Model.Publication.Publication> publicationList)
        {
            foreach (Model.Publication.Publication publication in publicationList)
            {
                XareuWFClient.Controls.Publication.Publication publicationControl = new XareuWFClient.Controls.Publication.Publication(publication);
                this.AddPublication(publicationControl);
            }
            this.setLinksStatus();
        }

        /// <summary>
        /// Adds the publication.
        /// </summary>
        /// <param name="publication">The publication.</param>
        public void AddPublication(XareuWFClient.Controls.Publication.Publication publication)
        {
            publication.Dock = DockStyle.Top;
            publication.SetColors();
            this.pPublicationsList.Controls.Add(publication);
        }

        /// <summary>
        /// Adds the question.
        /// </summary>
        /// <param name="question">The question.</param>
        public void AddQuestion(XareuWFClient.Controls.Publication.Publication question)
        {
            question.Dock = DockStyle.Top;
            question.SetColors();
            this.pQuestionsList.Controls.Add(question);
        }

        /// <summary>
        /// Sets the links status.
        /// </summary>
        private void setLinksStatus()
        {
            if (this.pQuestionsList.Controls.Count < this.ResultsPerPage)
            {
                this.lLNextQuestions.Enabled = false;
            }
            else
            {
                this.lLNextQuestions.Enabled = true;
            }
            if (this.QuestionsPage == 0)
            {
                this.lLPreviousQuestions.Enabled=false;
            }
            else
            {
                this.lLPreviousQuestions.Enabled = true;
            }


            if (this.pPublicationsList.Controls.Count < this.ResultsPerPage)
            {
                this.lLNextPublications.Enabled = false;
            }
            else
            {
                this.lLNextPublications.Enabled = true;
            }
            if (this.PublicationPage == 0)
            {
                this.lLPreviousPublications.Enabled = false;
            }
            else
            {
                this.lLPreviousPublications.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLPreviousQuestions control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLPreviousQuestions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.QuestionsPage--;
            this.pQuestionsList.Controls.Clear();
            this.LoadPreviousQuestionPage(sender, e);
            this.setLinksStatus();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLNextQuestions control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLNextQuestions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.QuestionsPage++;
            this.pQuestionsList.Controls.Clear();
            this.LoadNextQuestionPage(sender, e);
            this.setLinksStatus();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLNextPublications control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLNextPublications_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.PublicationPage++;
            this.pPublicationsList.Controls.Clear();
            this.LoadNextPublicationPage(sender, e);
            this.setLinksStatus();
        }

        /// <summary>
        /// Handles the LinkClicked event of the lLPreviousPublications control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lLPreviousPublications_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.PublicationPage--;
            this.pPublicationsList.Controls.Clear();
            this.LoadPreviousPublicationPage(sender, e);
            this.setLinksStatus();
        }
    }
}
