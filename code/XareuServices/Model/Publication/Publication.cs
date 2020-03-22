using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Model.Publication
{
    public class Publication
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public User.User Author { get; set; }
        public DateTime CreationDateTime { get; set; }
        public TagPlace.TagPlace Place { get; set; }
        public float Karma { get; set; }
        public bool IsQuestion { get; set; }
        public long AnswersTo { get; set; }
        public bool IsPrivate { get; set; }
        public int PositiveVotes { get; set; }
        public int NegativeVotes { get; set; }

        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public Publication()
        {
            this.Id = 0;
            this.Text = "";
            this.Author = new User.User();
            this.CreationDateTime = DateTime.Now;
            this.Place = new XareuServices.Model.TagPlace.TagPlace();
            this.Karma = 0;
            this.IsQuestion = false;
            this.AnswersTo = 0;
            this.IsPrivate = false;
            this.PositiveVotes = 0;
            this.NegativeVotes = 0;
        }
    }
}
