using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Args
{
    public class UsersArgs : EventArgs
    {
        public Model.User.User User { get; set; }
        public string Text { get; set; }
        public int Page { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersArgs"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="page">The page.</param>
        /// <param name="user">The user.</param>
        public UsersArgs(string text, int page, Model.User.User user)
        {
            this.User = user;
            this.Text = text;
            this.Page = page;
        }
    }
}
