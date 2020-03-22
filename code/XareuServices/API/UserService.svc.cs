using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    // NOTE: If you change the class name "UserService" here, you must also update the reference to "UserService" in Web.config.
    /// <summary>
    /// Services that operate over Users options
    /// </summary>
    public class UserService : IUserService
    {
        Services.User.User userService = new XareuServices.Services.User.User();

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
            return userService.RegisterNewUser(nick, email, password, defaultPlaceID);
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
            return userService.DeleteUser(userID, token, out newToken, email, password);
        }

        /// <summary>
        /// Gets the user by ID.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <returns>User</returns>
        public XareuServices.Model.User.User GetUserByID(long userID)
        {
            return userService.GetUserByID(userID);
        }

        /// <summary>
        /// Gets the user by nick.
        /// </summary>
        /// <param name="nick">The nick.</param>
        /// <returns>User</returns>
        public XareuServices.Model.User.User GetUserByNick(string nick)
        {
            return userService.GetUserByNick(nick);
        }

        /// <summary>
        /// Gets the user by email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>User</returns>
        public XareuServices.Model.User.User GetUserByEmail(string email)
        {
            return userService.GetUserByEmail(email);
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
            return userService.EditUser(userID, token, out newToken, user);
        }

        /// <summary>
        /// Gets the registered users.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of registered users</returns>
        public List<XareuServices.Model.User.User> GetRegisteredUsers(int number, int page)
        {
            return userService.GetRegisteredUsers(number, page);
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
            return userService.SearchUsersByName(name, number, page);
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
            return userService.SearchUsersByKarma(karma, number, page);
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
            return userService.SearchUsersByEmail(email, number, page);
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
            return userService.SearchUsersByTagPlace(tagPlaceID, number, page);
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
            return userService.GetUserFollow(userID, token, out newToken, userAuthorID, userFollowedID);
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
            return userService.GetUserFollowers(userID, token, out newToken, userAuthorID, number, page);
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
            return userService.GetUserOwnFollows(userID, token, out newToken, userAuthorID, number, page);
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
            return userService.AddUserFollow(userID, token, out newToken, userAuthorID, userFollowedID);
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
            return userService.DeleteUserFollow(userID, token, out newToken, userAuthorID, userFollowedID);
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
            return userService.GetUserFollowRequest(userID, token, out newToken, userAuthorID, userRequestedID);
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
            return userService.GetUserFollowRequests(userID, token, out newToken, userAuthorID, number, page);
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
            return userService.GetUserOwnFollowRequests(userID, token, out newToken, userAuthorID, number, page);
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
            return userService.AddUserFollowRequest(userID, token, out newToken, userAuthorID, userRequestedID);
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
            return userService.DeleteUserFollowRequest(userID, token, out newToken, userAuthorID, userRequestedID);
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
            return userService.UsersInPublication(publicationID, number, page);
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
            return userService.UserMentions(userID, token, out newToken, userAuthorID, number, page);
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
            return userService.AddUserInPublication(userID, token, out newToken, userAuthorID, publicationID);
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
            return userService.DeleteUserFromPublication(userID, token, out newToken, userAuthorID, publicationID);
        }

        #endregion
    }
}
