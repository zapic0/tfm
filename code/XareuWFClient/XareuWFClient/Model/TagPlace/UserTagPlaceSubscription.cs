using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.TagPlace
{
    class UserTagPlaceSubscription
    {
        public TagPlace TagPlace { get; set; }
        public User.User User { get; set; }

        public UserTagPlaceSubscription()
        {
            this.User = new User.User();
            this.TagPlace = new TagPlace();
        }
    }
}
