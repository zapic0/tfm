using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Model.UserFollow
{
    public class UserFollow
    {
        public User.User UserFollowing{ get; set; }
        public User.User UserFollowed { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFollow"/> class.
        /// </summary>
        public UserFollow()
        {
            this.UserFollowed = new User.User();
            this.UserFollowing = new User.User();
        }
    }
}
