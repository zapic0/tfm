using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Args
{
    public class GroupsArgs : EventArgs
    {
        public Model.Group.Group Group { get; set; }
        public string Text { get; set; }
        public int Page { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsArgs"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="page">The page.</param>
        /// <param name="group">The group.</param>
        public GroupsArgs(string text, int page, Model.Group.Group group)
        {
            this.Text = text;
            this.Page = page;
            this.Group = group;
        }
    }
}
