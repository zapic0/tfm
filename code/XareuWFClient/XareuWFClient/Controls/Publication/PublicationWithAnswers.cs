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
    public partial class PublicationWithAnswers : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationWithAnswers"/> class.
        /// </summary>
        public PublicationWithAnswers()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the publication.
        /// </summary>
        /// <param name="publication">The publication.</param>
        public void LoadPublication(Model.Publication.Publication publication)
        {
            this.publication.PublicationData = publication;
            this.publication.SetColors();
            this.publication.LoadPublicationData();
        }

        /// <summary>
        /// Loads the answers.
        /// </summary>
        /// <param name="answers">The answers.</param>
        public void LoadAnswers(List<Model.Publication.Publication> answers)
        {
            foreach (Model.Publication.Publication answer in answers)
            {
                XareuWFClient.Controls.Publication.Publication newAnswer = new XareuWFClient.Controls.Publication.Publication(answer);
                newAnswer.Dock = DockStyle.Top;
                newAnswer.SetColors();
                this.pAnswers.Controls.Add(newAnswer);
            }
        }

    }
}
