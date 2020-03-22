using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.User
{
    public class User
    {
        public string Nick { get; set; }
        public string Email { get; set; }
        public long Id { get; set; }
        public string Password { get; set; }
        public TagPlace.TagPlace DefaultPlace { get; set; }
        public float Karma { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime SignUp { get; set; }
        public string UserPictureURL { get; set; }

        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public User()
        {
            this.Nick = "";
            this.Email = "";
            this.Id = 0;
            this.Password = "";
            this.DefaultPlace = new Model.TagPlace.TagPlace();
            this.Karma = 0;
            this.IsAdmin = false;
            this.SignUp = DateTime.Today;
            this.UserPictureURL = "http://test.com/test.png";
        }
    }
}
