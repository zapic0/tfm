using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.Vote
{
    class Vote
    {
        public long Id { get; set; }
        public float Karma { get; set; }
        public User.User Author { get; set; }
        public Publication.Publication Publication { get; set; }
        public bool Positive { get; set; }

        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public Vote()
        {
            this.Id = 0;
            this.Karma = 0;
            this.Author = new User.User();
            this.Publication = new Model.Publication.Publication();
            this.Positive = true;
        }
    }
}
