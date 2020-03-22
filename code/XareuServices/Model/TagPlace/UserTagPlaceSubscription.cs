using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Model.TagPlace
{
    public class UserTagPlaceSubscription
    {
        public TagPlace TagPlace { get; set; }
        public User.User User { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTagPlaceSubscription"/> class.
        /// </summary>
        public UserTagPlaceSubscription()
        {
            this.User = new User.User();
            this.TagPlace = new TagPlace();
        }
    }
}
