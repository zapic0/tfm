using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.Group
{
    class GroupJoinRequest
    {
        public Group Group { get; set; }
        public User.User User { get; set; }

        public GroupJoinRequest()
        {
            this.Group = new Group();
            this.User = new User.User();
        }
    }
}
