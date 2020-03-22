using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Model.Tag
{
    public class UserTagSubscription
    {
        public User.User User { get; set; }
        public Tag Tag { get; set; }

        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public UserTagSubscription()
        {
            this.User = new User.User();
            this.Tag = new Tag();
        }
    }
}
