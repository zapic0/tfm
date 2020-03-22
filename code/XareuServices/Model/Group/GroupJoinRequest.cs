using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Model.Group
{
    public class GroupJoinRequest
    {
        public Group Group { get; set; }
        public User.User User { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupJoinRequest"/> class.
        /// </summary>
        public GroupJoinRequest()
        {
            this.Group = new Group();
            this.User = new User.User();
        }
    }
}
