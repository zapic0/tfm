using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Model.Group
{
    public class GroupUsers
    {
        public User.User User { get; set; }
        public Group Group { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUsers"/> class.
        /// </summary>
        public GroupUsers()
        {
            this.User = new User.User();
            this.Group = new Group();
        }
    }
}
