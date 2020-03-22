using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Services.User
{
    public class User : API.IUserService
    {
        Services.Login.Login loginService = new XareuServices.Services.Login.Login();
        XareuServices.DAL.Linq.UserDAO.UserDAO userDAO = new XareuServices.DAL.Linq.UserDAO.UserDAO();
        XareuServices.DAL.Linq.UserDAO.UserFollowDAO userFollowDAO = new XareuServices.DAL.Linq.UserDAO.UserFollowDAO();
        XareuServices.DAL.Linq.UserDAO.UserFollowRequestDAO userFollowRequestDAO = new XareuServices.DAL.Linq.UserDAO.UserFollowRequestDAO();
        XareuServices.DAL.Linq.UserDAO.UserInPublicationDAO userInPublicationDAO = new XareuServices.DAL.Linq.UserDAO.UserInPublicationDAO();
        XareuServices.DAL.Linq.PublicationDAO.PublicationDAO publicationDAO = new XareuServices.DAL.Linq.PublicationDAO.PublicationDAO();

        /// <summary>
        /// Registers the new user.
        /// </summary>
        /// <param name="nick">The nick.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <param name="defaultPlaceID">The default place ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool RegisterNewUser(string nick, string email, string password, long defaultPlaceID)
        {
            try
            {
                Model.User.User newUser = new XareuServices.Model.User.User();

                newUser.Nick = nick;
                newUser.Email = email;
                newUser.Password = password;
                newUser.SignUp = DateTime.Now;
                newUser.DefaultPlace = new XareuServices.Model.TagPlace.TagPlace(defaultPlaceID);

                long userID;
                return userDAO.AddNewUser(newUser, out userID);
            }
            catch
            {
                throw new Exception("Error registering new user");
            }
        }


        #region IUserService Members


        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUser(long userID, Guid token, out Guid newToken, string email, string password)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                if (userDAO.IsAdmin(userID))
                {
                    Model.User.User user = userDAO.GetUserByEmail(email);
                    newToken = Guid.Empty;
                    return userDAO.DeleteUser(user);
                }
                else
                {
                    newToken = loginService.GetNewToken(email, password);
                    if (loginService.UseToken(userID, newToken, out newToken))
                    {
                        Model.User.User user = userDAO.GetUserById(userID);
                        return userDAO.DeleteUser(user);
                    }
                    throw new Exception("User can't delete user");
                }
            }
            throw new Exception("Login error");
        }



        /// <summary>
        /// Gets the user by ID.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <returns>User</returns>
        public XareuServices.Model.User.User GetUserByID(long userID)
        {
            try
            {
                return userDAO.GetUserById(userID);
            }
            catch
            {
                throw new Exception("Getting user by ID error");
            }
        }

        /// <summary>
        /// Gets the user by nick.
        /// </summary>
        /// <param name="nick">The nick.</param>
        /// <returns>User</returns>
        public XareuServices.Model.User.User GetUserByNick(string nick)
        {
            try
            {
                return userDAO.GetUserByName(nick);
            }
            catch
            {
                throw new Exception("Getting user by name error");
            }
        }

        /// <summary>
        /// Gets the user by email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>User</returns>
        public XareuServices.Model.User.User GetUserByEmail(string email)
        {
            try
            {
                return userDAO.GetUserByEmail(email);
            }
            catch
            {
                throw new Exception("Getting user by email error");
            }
        }

        /// <summary>
        /// Edits the user.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="user">The user.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool EditUser(long userID, Guid token, out Guid newToken, XareuServices.Model.User.User user)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == user.Id || userDAO.IsAdmin(userID))
                    {
                        return userDAO.EditUser(user);
                    }
                    throw new Exception("User isn't able to edit that user");
                }
                catch
                {
                    throw new Exception("Editting user error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the registered users.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of registered users</returns>
        public List<XareuServices.Model.User.User> GetRegisteredUsers(int number, int page)
        {
            try
            {
                return userDAO.GetRegisteredUsers(number, page);
            }
            catch
            {
                throw new Exception("Getting registered users error");
            }
        }

        /// <summary>
        /// Searches the name of the users by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        public List<XareuServices.Model.User.User> SearchUsersByName(string name, int number, int page)
        {
            try
            {
                return userDAO.SearchUsersByName(number, page, name);
            }
            catch
            {
                throw new Exception("Searching users by name error");
            }
        }

        /// <summary>
        /// Searches the users by karma.
        /// </summary>
        /// <param name="karma">The karma.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        public List<XareuServices.Model.User.User> SearchUsersByKarma(float karma, int number, int page)
        {
            try
            {
                return userDAO.SearchUsersByKarma(number, page, karma);
            }
            catch
            {
                throw new Exception("Searching users by karma error");
            }
        }

        /// <summary>
        /// Searches the users by email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        public List<XareuServices.Model.User.User> SearchUsersByEmail(string email, int number, int page)
        {
            try
            {
                return userDAO.SearchUsersByEmail(number, page, email);
            }
            catch
            {
                throw new Exception("Searching users by email error");
            }
        }

        /// <summary>
        /// Searches the users by tag place.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        public List<XareuServices.Model.User.User> SearchUsersByTagPlace(long tagPlaceID, int number, int page)
        {
            try
            {
                return userDAO.SearchUsersByTagPlace(number, page, tagPlaceID);
            }
            catch
            {
                throw new Exception("Searching users by tag place error");
            }
        }

        /// <summary>
        /// Gets the user follow.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userFollowedID">The user followed ID.</param>
        /// <returns>User Follow</returns>
        public XareuServices.Model.UserFollow.UserFollow GetUserFollow(long userID, Guid token, out Guid newToken, long userAuthorID, long userFollowedID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userID == userFollowedID || userDAO.IsAdmin(userID))
                    {
                        return userFollowDAO.GetUserFollow(userAuthorID, userFollowedID);
                    }
                    throw new Exception("User isn't able to get that user information");
                }
                catch
                {
                    throw new Exception("Getting user follow error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the user followers.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of user followers</returns>
        public List<XareuServices.Model.UserFollow.UserFollow> GetUserFollowers(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return userFollowDAO.GetUserFollowers(userAuthorID, number, page);
                    }
                    throw new Exception("User isn't able to get that user information");
                }
                catch
                {
                    throw new Exception("Getting user follows error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the user own follows.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users that the user follows</returns>
        public List<XareuServices.Model.UserFollow.UserFollow> GetUserOwnFollows(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return userFollowDAO.GetUserOwnFollows(userAuthorID, number, page);
                    }
                    throw new Exception("User isn't able to get that info");
                }
                catch
                {
                    throw new Exception("Getting user own follows error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Adds the user follow.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userFollowedID">The user followed ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserFollow(long userID, Guid token, out Guid newToken, long userAuthorID, long userFollowedID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userID == userFollowedID || userDAO.IsAdmin(userID))
                    {
                        return userFollowDAO.AddUserFollow(userAuthorID, userFollowedID);
                    }
                    throw new Exception("User isn't able to add that follow");
                }
                catch
                {
                    throw new Exception("Adding user follow error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Deletes the user follow.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userFollowedID">The user followed ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserFollow(long userID, Guid token, out Guid newToken, long userAuthorID, long userFollowedID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userID == userFollowedID || userDAO.IsAdmin(userID))
                    {
                        return userFollowDAO.DeleteUserFollow(userAuthorID, userFollowedID);
                    }
                    throw new Exception("User isn't able to delete that follow");
                }
                catch
                {
                    throw new Exception("Delleting user follow error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the user follow request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userRequestedID">The user requested ID.</param>
        /// <returns>Follow Request</returns>
        public XareuServices.Model.UserFollow.UserFollowRequest GetUserFollowRequest(long userID, Guid token, out Guid newToken, long userAuthorID, long userRequestedID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userID==userRequestedID || userDAO.IsAdmin(userID))
                    {
                        return userFollowRequestDAO.GetUserFollowRequest(userAuthorID, userRequestedID);
                    }
                    throw new Exception("User isn't able to get that info");
                }
                catch
                {
                    throw new Exception("Getting user follow error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the user follow requests.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>Follow Request</returns>
        public List<XareuServices.Model.UserFollow.UserFollowRequest> GetUserFollowRequests(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return userFollowRequestDAO.GetUserFollowRequests(userAuthorID, number, page);
                    }
                    throw new Exception("User isn't able to get that info");
                }
                catch
                {
                    throw new Exception("Getting user follow requests error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the user own follow requests.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of follow requests</returns>
        public List<XareuServices.Model.UserFollow.UserFollowRequest> GetUserOwnFollowRequests(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return userFollowRequestDAO.GetUserOwnFollowRequests(userAuthorID, number, page);
                    }
                    throw new Exception("User isn't able to get that info");
                }
                catch
                {
                    throw new Exception("Getting user own follow requests error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Adds the user follow request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userRequestedID">The user requested ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserFollowRequest(long userID, Guid token, out Guid newToken, long userAuthorID, long userRequestedID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return userFollowRequestDAO.AddUserFollowRequest(userAuthorID, userRequestedID);
                    }
                    throw new Exception("User isn't able to add that follow request");
                }
                catch
                {
                    throw new Exception("Adding user follow requests error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Deletes the user follow request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userRequestedID">The user requested ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserFollowRequest(long userID, Guid token, out Guid newToken, long userAuthorID, long userRequestedID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userID==userRequestedID || userDAO.IsAdmin(userID))
                    {
                        return userFollowRequestDAO.DeleteUserFollowRequest(userAuthorID, userRequestedID);
                    }
                    throw new Exception("User isn't able to delete that follow request");
                }
                catch
                {
                    throw new Exception("Deleting user follow requests error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Users in a publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of Users</returns>
        public List<XareuServices.Model.User.User> UsersInPublication(long publicationID, int number, int page)
        {
            try
            {
                return userInPublicationDAO.UsersInPublication(publicationID, number, page);
            }
            catch
            {
                throw new Exception("Getting users in publication error");
            }
        }

        /// <summary>
        /// User mentions in publications.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications</returns>
        public List<XareuServices.Model.Publication.Publication> UserMentions(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return userInPublicationDAO.UserMentions(userAuthorID, number, page);
                    }
                    throw new Exception("User isn't able to get that info");
                }
                catch
                {
                    throw new Exception("Getting user mentions error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Adds the user in publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserInPublication(long userID, Guid token, out Guid newToken, long userAuthorID, int publicationID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (publicationDAO.GetPublication(publicationID).Author.Id==userID || userDAO.IsAdmin(userID))
                    {
                        return userInPublicationDAO.AddUserInPublication(userAuthorID, publicationID);
                    }
                    throw new Exception("User isn't able to add that mention");
                }
                catch
                {
                    throw new Exception("Adding user mention error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Deletes the user from publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserFromPublication(long userID, Guid token, out Guid newToken, long userAuthorID, int publicationID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (publicationDAO.GetPublication(publicationID).Author.Id == userID || userDAO.IsAdmin(userID))
                    {
                        return userInPublicationDAO.DeleteUserFromPublication(userAuthorID, publicationID);
                    }
                    throw new Exception("User isn't able to delete that mention");
                }
                catch
                {
                    throw new Exception("Deleting user mention error");
                }
            }
            throw new Exception("Login error");
        }

        #endregion
    }
}
