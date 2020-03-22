using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Model.SecurityToken
{
    public class SecurityToken
    {
        public Guid Value { get; set; }
        public long Id { get; set; }
        public User.User User { get; set; }
        public bool Used { get; set; }

        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public SecurityToken()
        {
            this.Value = Guid.Empty;
            this.User = new User.User();
            this.Used = true;
        }
    }
}
