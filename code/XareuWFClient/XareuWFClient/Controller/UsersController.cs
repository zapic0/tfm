using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Controller
{
    class UsersController
    {
        UserServices.UserServiceClient userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        public UsersController()
        {
            userService = new UserServices.UserServiceClient();
        }

        /// <summary>
        /// Gets the user by ID.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <returns></returns>
        public Model.User.User GetUserByID(long userID)
        {
            Model.User.User user;
            try
            {
                user = this.convertToModelUser(userService.GetUserByID(userID));
            }
            catch(Exception ex)
            {
                throw new Exception("Error getting user" + ex.Message);
            }
            return user;
        }

        /// <summary>
        /// Searches the users by nick.
        /// </summary>
        /// <param name="nick">The nick.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.User.User> SearchUsersByNick(string nick, int number, int page)
        {
            List<Model.User.User> usersList;
            try
            {
                usersList = this.convertToModelUsersList(userService.SearchUsersByName(nick, number, page));
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching users - " + ex.Message);
            }
            return usersList;
        }

        /// <summary>
        /// Gets the user by nick.
        /// </summary>
        /// <param name="userNick">The user nick.</param>
        /// <returns></returns>
        public Model.User.User GetUserByNick(string userNick)
        {
            Model.User.User user;
            try
            {
                user = this.convertToModelUser(userService.GetUserByNick(userNick));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting user" + ex.Message);
            }
            return user;
        }

        /// <summary>
        /// Gets the user by email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Model.User.User GetUserByEmail(string email)
        {
            Model.User.User user;
            try
            {
                user = this.convertToModelUser(userService.GetUserByEmail(email));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting user " + ex.Message);
            }
            return user;
        }

        /// <summary>
        /// Registers the new user.
        /// </summary>
        /// <param name="nick">The nick.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <param name="placeID">The place ID.</param>
        /// <returns></returns>
        public bool RegisterNewUser(string nick, string email, string password, long placeID)
        {
            try
            {
                return userService.RegisterNewUser(nick, email, password, placeID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error registering new user " + ex.Message);
            }
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool DeleteUser(out Guid newToken, long userID, Guid token, string email, string password)
        {
            try
            {
                return userService.DeleteUser(out newToken, userID, token, email, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting user " + ex.Message);
            }
        }

        /// <summary>
        /// Adds the follow request.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userRequestedID">The user requested ID.</param>
        /// <returns></returns>
        public bool AddFollowRequest(out Guid newToken, long userID, Guid token, long userAuthorID, long userRequestedID)
        {
            try
            {
                return userService.AddUserFollowRequest(out newToken, userID, token, userAuthorID, userRequestedID);
            }
            catch(Exception ex)
            {
                throw new Exception("Error adding follow request " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the user follow.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="userFollowedID">The user followed ID.</param>
        /// <returns></returns>
        public Model.User.UserFollow GetUserFollow(out Guid newToken, long userID, Guid token, long userAuthorID, long userFollowedID)
        {
            try
            {
                return this.convertToModelUserFollow(userService.GetUserFollow(out newToken, userID, token, userAuthorID, userFollowedID));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting user follow " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the user own follows.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.User.UserFollow> GetUserOwnFollows(out Guid newToken, long userID, Guid token, long userAuthorID, int number, int page)
        {
            List<Model.User.UserFollow> userFollows = new List<Model.User.UserFollow>();
            try
            {
                UserServices.UserFollow[] serviceUserFollows = userService.GetUserOwnFollows(out newToken, userID, token, userAuthorID, number, page);
                foreach (UserServices.UserFollow userFollow in serviceUserFollows)
                {
                    userFollows.Add(convertToModelUserFollow(userFollow));
                }
                return userFollows;
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting user follows " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the user followers.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.User.UserFollow> GetUserFollowers(out Guid newToken, long userID, Guid token, long userAuthorID, int number, int page)
        {
            List<Model.User.UserFollow> userFollowers = new List<Model.User.UserFollow>();
            try
            {
                UserServices.UserFollow[] serviceUserFollowers = userService.GetUserFollowers(out newToken, userID, token, userAuthorID, number, page);
                foreach (UserServices.UserFollow userFollow in serviceUserFollowers)
                {
                    userFollowers.Add(convertToModelUserFollow(userFollow));
                }
                return userFollowers;
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting user followers " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the user follow requests.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.User.UserFollowRequest> GetUserFollowRequests(out Guid newToken, long userID, Guid token, long userAuthorID, int number, int page)
        {
            List<Model.User.UserFollowRequest> userFollowRequests = new List<Model.User.UserFollowRequest>();
            try
            {
                UserServices.UserFollowRequest[] serviceUserFollowRequests = userService.GetUserFollowRequests(out newToken, userID, token, userAuthorID, number, page);
                foreach (UserServices.UserFollowRequest userFollowRequest in serviceUserFollowRequests)
                {
                    userFollowRequests.Add(this.convertToModelUserFollowRequest(userFollowRequest));
                }
                return userFollowRequests;
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting user follow requests " + ex.Message);
            }
        }


        #region Converters

        /// <summary>
        /// Converts to model user.
        /// </summary>
        /// <param name="serviceUser">The service user.</param>
        /// <returns></returns>
        private Model.User.User convertToModelUser(UserServices.User serviceUser)
        {
            Model.User.User modelUser = new Model.User.User();

            modelUser.DefaultPlace = convertToModelTagPlace(serviceUser.DefaultPlace);
            modelUser.Email = serviceUser.Email;
            modelUser.Id = serviceUser.Id;
            modelUser.IsAdmin = serviceUser.IsAdmin;
            modelUser.IsPrivate = serviceUser.IsPrivate;
            modelUser.Karma = serviceUser.Karma;
            modelUser.Nick = serviceUser.Nick;
            modelUser.Password = serviceUser.Password;
            modelUser.SignUp = serviceUser.SignUp;
            modelUser.UserPictureURL = serviceUser.UserPictureURL;

            return modelUser;
        }

        /// <summary>
        /// Converts to model users list.
        /// </summary>
        /// <param name="serviceUsersList">The service users list.</param>
        /// <returns></returns>
        private List<Model.User.User> convertToModelUsersList(UserServices.User[] serviceUsersList)
        {
            List<Model.User.User> modelUsersList = new List<Model.User.User>();

            foreach (UserServices.User serviceUser in serviceUsersList)
            {
                modelUsersList.Add(this.convertToModelUser(serviceUser));
            }

            return modelUsersList;
        }

        /// <summary>
        /// Converts to model tag place.
        /// </summary>
        /// <param name="serviceTagPlace">The service tag place.</param>
        /// <returns></returns>
        private Model.TagPlace.TagPlace convertToModelTagPlace(UserServices.TagPlace serviceTagPlace)
        {
            Model.TagPlace.TagPlace modelTagPlace = new Model.TagPlace.TagPlace(serviceTagPlace.Id);

            modelTagPlace.Name = serviceTagPlace.Name;
            modelTagPlace.ParentId = serviceTagPlace.ParentId;

            return modelTagPlace;
        }

        /// <summary>
        /// Converts to model user follow.
        /// </summary>
        /// <param name="serviceUserFollow">The service user follow.</param>
        /// <returns></returns>
        private Model.User.UserFollow convertToModelUserFollow(UserServices.UserFollow serviceUserFollow)
        {
            Model.User.UserFollow modelUserFollow = new Model.User.UserFollow();

            modelUserFollow.UserFollowing = this.convertToModelUser(serviceUserFollow.UserFollowing);
            modelUserFollow.UserFollowed = this.convertToModelUser(serviceUserFollow.UserFollowed);

            return modelUserFollow;
        }

        /// <summary>
        /// Converts to model user follow request.
        /// </summary>
        /// <param name="serviceUserFollowRequest">The service user follow request.</param>
        /// <returns></returns>
        private Model.User.UserFollowRequest convertToModelUserFollowRequest(UserServices.UserFollowRequest serviceUserFollowRequest)
        {
            Model.User.UserFollowRequest modelUserFollowRequest = new Model.User.UserFollowRequest();

            modelUserFollowRequest.UserFollower = this.convertToModelUser(serviceUserFollowRequest.UserFollower);
            modelUserFollowRequest.UserFollowed = this.convertToModelUser(serviceUserFollowRequest.UserFollowed);

            return modelUserFollowRequest;
        }

        #endregion
    }
}
