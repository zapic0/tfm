using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.Group
{
    public class Group
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public User.User Owner { get; set; }
        public DateTime Creation { get; set; }
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public Group()
        {
            this.Id = 0;
            this.Name = "";
            this.Owner = new User.User();
            this.Creation = DateTime.Now;
            this.IsPrivate = false;
        }
    }
}
