using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace XareuServices.Model.User
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Nick { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public TagPlace.TagPlace DefaultPlace { get; set; }
        [DataMember]
        public float Karma { get; set; }
        [DataMember]
        public bool IsAdmin { get; set; }
        [DataMember]
        public bool IsPrivate { get; set; }
        [DataMember]
        public DateTime SignUp { get; set; }
        [DataMember]
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
            this.DefaultPlace = new XareuServices.Model.TagPlace.TagPlace();
            this.Karma = 0;
            this.IsAdmin = false;
            this.SignUp = DateTime.Today;
            this.UserPictureURL = "http://test.com/test.png";
        }
    }
}
