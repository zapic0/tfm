using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Args
{
    public class PublicationArgs : EventArgs
    {
        public Model.Publication.Publication Publication { get; set; }
        public string Text { get; set; }
        public string TagsText { get; set; }
        public string LocationText { get; set; }
        public int Page { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationArgs"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="tagsText">The tags text.</param>
        /// <param name="locationText">The location text.</param>
        /// <param name="page">The page.</param>
        /// <param name="publication">The publication.</param>
        public PublicationArgs(string text, string tagsText, string locationText, int page, Model.Publication.Publication publication)
        {
            this.Text = text;
            this.TagsText = tagsText;
            this.LocationText = locationText;
            this.Page = page;
            this.Publication = publication;
        }
    }

}
