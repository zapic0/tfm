using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Args
{
    public class TagsArgs : EventArgs
    {
        public Model.Tag.Tag Tag { get; set; }
        public string Text { get; set; }
        public int Page { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsArgs"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="page">The page.</param>
        /// <param name="tag">The tag.</param>
        public TagsArgs(string text, int page, Model.Tag.Tag tag)
        {
            this.Text = text;
            this.Page = page;
            this.Tag = tag;
        }
    }
}
