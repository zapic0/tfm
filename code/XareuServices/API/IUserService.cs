using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.UI.MobileControls;

namespace XareuServices.API
{
    /// <summary>
    /// Services that operate over Users options
    /// </summary>
    [ServiceContract]
    public interface IUserService
    {
        /// <summary>
        /// Registers the new user.
        /// </summary>
        /// <param name="nick">The nick.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <param name="defaultPlaceID">The default place ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool RegisterNewUser(string nick, string email, string password, long defaultPlaceID);

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteUser(long userID, Guid token, out Guid newToken, string email, string password);

        /// <summary>
        /// Gets the user by ID.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <returns>User</returns>
        [OperationContract]
        Model.User.User GetUserByID(long userID);

        /// <summary>
        /// Gets the user by nick.
        /// </summary>
        /// <param name="nick">The nick.</param>
        /// <returns>User</returns>
        [OperationContract]
        Model.User.User GetUserByNick(string nick);

        /// <summary>
        /// Gets the user by email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>User</returns>
        [OperationContract]
        Model.User.User GetUserByEmail(string email);

        /// <summary>
        /// Edits the user.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="user">The user.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool EditUser(long userID, Guid token, out Guid newToken, Model.User.User user);

        /// <summary>
        /// Gets the registered users.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of registered users</returns>
        [OperationContract]
        List<Model.User.User> GetRegisteredUsers(int number, int page);

        /// <summary>
        /// Searches the name of the users by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        [OperationContract]
        List<Model.User.User> SearchUsersByName(string name, int number, int page);

        /// <summary>
        /// Searches the users by karma.
        /// </summary>
        /// <param name="karma">The karma.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        [OperationContract]
        List<Model.User.User> SearchUsersByKarma(float karma, int number, int page);

        /// <summary>
        /// Searches the users by email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        [OperationContract]
        List<Model.User.User> SearchUsersByEmail(string email, int number, int page);

        /// <summary>
        /// Searches the users by tag place.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        [OperationContract]
        List<Model.User.User> SearchUsersByTagPlace(long tagPlaceID, int number, int page);






        /// <summary>
        /// Gets the user follow.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userFollowedID">The user followed ID.</param>
        /// <returns>User Follow</returns>
        [OperationContract]
        Model.UserFollow.UserFollow GetUserFollow(long userID, Guid token, out Guid newToken, long userAuthorID, long userFollowedID);

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
        [OperationContract]
        List<Model.UserFollow.UserFollow> GetUserFollowers(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

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
        [OperationContract]
        List<Model.UserFollow.UserFollow> GetUserOwnFollows(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

        /// <summary>
        /// Adds the user follow.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userFollowedID">The user followed ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddUserFollow(long userID, Guid token, out Guid newToken, long userAuthorID, long userFollowedID);

        /// <summary>
        /// Deletes the user follow.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userFollowedID">The user followed ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteUserFollow(long userID, Guid token, out Guid newToken, long userAuthorID, long userFollowedID);







        /// <summary>
        /// Gets the user follow request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userRequestedID">The user requested ID.</param>
        /// <returns>Follow Request</returns>
        [OperationContract]
        Model.UserFollow.UserFollowRequest GetUserFollowRequest(long userID, Guid token, out Guid newToken, long userAuthorID, long userRequestedID);

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
        [OperationContract]
        List<Model.UserFollow.UserFollowRequest> GetUserFollowRequests(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

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
        [OperationContract]
        List<Model.UserFollow.UserFollowRequest> GetUserOwnFollowRequests(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

        /// <summary>
        /// Adds the user follow request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userRequestedID">The user requested ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddUserFollowRequest(long userID, Guid token, out Guid newToken, long userAuthorID, long userRequestedID);

        /// <summary>
        /// Deletes the user follow request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userRequestedID">The user requested ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteUserFollowRequest(long userID, Guid token, out Guid newToken, long userAuthorID, long userRequestedID);





        /// <summary>
        /// Users in a publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of Users</returns>
        [OperationContract]
        List<Model.User.User> UsersInPublication(long publicationID, int number, int page);

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
        [OperationContract]
        List<Model.Publication.Publication> UserMentions(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

        /// <summary>
        /// Adds the user in publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddUserInPublication(long userID, Guid token, out Guid newToken, long userAuthorID, int publicationID);

        /// <summary>
        /// Deletes the user from publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteUserFromPublication(long userID, Guid token, out Guid newToken, long userAuthorID, int publicationID);
    }
}
