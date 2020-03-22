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
    public partial class PublicationPage : UserControl
    {
        public Model.Publication.Publication PublicationData { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationPage"/> class.
        /// </summary>
        public PublicationPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the publication data.
        /// </summary>
        /// <param name="publicationData">The publication data.</param>
        public void LoadPublicationData(Model.Publication.Publication publicationData)
        {
            this.PublicationData = publicationData;
            this.publicationData.PublicationData = publicationData;
            this.publicationData.LoadPublicationData();
        }

        /// <summary>
        /// Loads the answers.
        /// </summary>
        /// <param name="publicationAnswers">The publication answers.</param>
        public void LoadAnswers(List<Model.Publication.Publication> publicationAnswers)
        {
            foreach (Model.Publication.Publication publication in publicationAnswers)
            {
                XareuWFClient.Controls.Publication.Publication newPublication = new Publication(publication);
                newPublication.Dock = DockStyle.Top;
                this.pAnswers.Controls.Add(newPublication);
            }
        }
    }
}
