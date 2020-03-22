using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Controller
{
    class LoginController
    {
        LoginServices.LoginServiceClient loginService;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController()
        {
            loginService = new XareuWFClient.LoginServices.LoginServiceClient();
        }

        /// <summary>
        /// Logins the with key.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="session">The session.</param>
        /// <returns></returns>
        public bool LoginWithKey(string userEmail, Model.Session.Session session)
        {
            try
            {
                Guid newSecurityToken = Guid.Empty;
                LoginServices.User serviceUser = loginService.Login(out newSecurityToken, userEmail, session.CurrentToken);
                session.User = this.convertToModelUser(serviceUser);
                session.Logged = true;
                session.CurrentToken = newSecurityToken;

                return true;
            }
            catch
            {
                session.User = null;
                session.Logged = false;
                session.CurrentToken = Guid.Empty;

                return false;
            }
        }

        /// <summary>
        /// Gets the new token.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="password">The password.</param>
        /// <param name="session">The session.</param>
        /// <returns></returns>
        public bool GetNewToken(string userEmail, string password, Model.Session.Session session)
        {
            try
            {
                session.CurrentToken = loginService.GetNewToken(userEmail, password);
                return true;
            }

            catch
            {
                session.CurrentToken = Guid.Empty;
                return false;
            }
        }

        /// <summary>
        /// Logins the with password.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="password">The password.</param>
        /// <param name="session">The session.</param>
        /// <returns></returns>
        public bool LoginWithPassword(string userEmail, string password, Model.Session.Session session)
        {
            try
            {
                bool isOK = true;

                isOK = this.GetNewToken(userEmail, password, session);
                if (isOK)
                {
                    isOK = this.LoginWithKey(userEmail, session);
                }
                if (isOK)
                {
                    session.Logged = true;
                    return true;
                }
                return isOK;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Disconnects the specified session.
        /// </summary>
        /// <param name="session">The session.</param>
        public void Disconnect(Model.Session.Session session)
        {
            session.Logged = false;
            session.User = new Model.User.User();
            session.CurrentToken = Guid.Empty;
        }


        /// <summary>
        /// Converts to model user.
        /// </summary>
        /// <param name="serviceUser">The service user.</param>
        /// <returns></returns>
        private Model.User.User convertToModelUser(LoginServices.User serviceUser)
        {
            Model.User.User modelUser = new Model.User.User();

            modelUser.DefaultPlace = new XareuWFClient.Model.TagPlace.TagPlace(serviceUser.DefaultPlace.Id);
            modelUser.DefaultPlace.Name = serviceUser.DefaultPlace.Name;
            modelUser.DefaultPlace.ParentId = serviceUser.DefaultPlace.ParentId;

            modelUser.Email = serviceUser.Email;
            modelUser.Id = serviceUser.Id;
            modelUser.IsAdmin = serviceUser.IsAdmin;
            modelUser.IsPrivate = serviceUser.IsPrivate;
            modelUser.Karma = serviceUser.Karma;
            modelUser.Nick = serviceUser.Nick;
            modelUser.SignUp = serviceUser.SignUp;
            modelUser.UserPictureURL = serviceUser.UserPictureURL;

            return modelUser;
        }
    }
}
