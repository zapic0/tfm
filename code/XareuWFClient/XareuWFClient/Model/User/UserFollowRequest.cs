using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.User
{
    public class UserFollowRequest
    {
        public User UserFollower { get; set; }
        public User UserFollowed { get; set; }
        public DateTime DateTime { get; set; }

        public UserFollowRequest()
        {
            this.UserFollowed = new User();
            this.UserFollower = new User();
            this.DateTime = DateTime.Today;
        }
    }
}
