using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.Group
{
    class GroupUsers
    {
        public User.User User { get; set; }
        public Group Group { get; set; }

        public GroupUsers()
        {
            this.User = new User.User();
            this.Group = new Group();
        }
    }
}
