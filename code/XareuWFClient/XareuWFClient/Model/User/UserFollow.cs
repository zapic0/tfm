using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.User
{
    public class UserFollow
    {
        public User UserFollowing { get; set; }
        public User UserFollowed { get; set; }

        public UserFollow()
        {
            this.UserFollowed = new User();
            this.UserFollowing = new User();
        }
    }
}
