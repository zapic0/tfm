using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Model.UserFollow
{
    public class UserFollowRequest
    {
        public User.User UserFollower { get; set; }
        public User.User UserFollowed { get; set; }
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFollowRequest"/> class.
        /// </summary>
        public UserFollowRequest()
        {
            this.UserFollowed = new User.User();
            this.UserFollower = new User.User();
            this.DateTime = DateTime.Today;
        }
    }
}
