using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.UserDAO
{
    public class UserFollowRequestDAO : IUserFollowRequestDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFollowRequestDAO"/> class.
        /// </summary>
        public UserFollowRequestDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IUserFollowRequestDAO Members

        /// <summary>
        /// Gets the user follow request.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userRequestedId">The user requested id.</param>
        /// <returns>User Follow Request</returns>
        public XareuServices.Model.UserFollow.UserFollowRequest GetUserFollowRequest(long userId, long userRequestedId)
        {
            var query = from userFollowRequests in data.user_follow_requests
                        where userFollowRequests.user_id_request == userId
                        where userFollowRequests.user_id_requested == userRequestedId
                        select userFollowRequests;

            try
            {
                return this.getUserFollowRequest(query.First<user_follow_request>());
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the user follow requests.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of User Follow Request</returns>
        public List<XareuServices.Model.UserFollow.UserFollowRequest> GetUserFollowRequests(long userId, int number, int page)
        {
            List<Model.UserFollow.UserFollowRequest> userFollowRequestsList = new List<XareuServices.Model.UserFollow.UserFollowRequest>();

            var query = (from userFollowRequests in data.user_follow_requests
                        where userFollowRequests.user_id_requested == userId
                        select userFollowRequests).Skip<user_follow_request>(number*page).Take<user_follow_request>(number);

            foreach (user_follow_request userFollowRequest in query)
            {
                try
                {
                    userFollowRequestsList.Add(this.getUserFollowRequest(userFollowRequest));
                }
                catch { }
            }

            return userFollowRequestsList;
        }

        /// <summary>
        /// Gets the user own follow requests.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of User Follow Request</returns>
        public List<XareuServices.Model.UserFollow.UserFollowRequest> GetUserOwnFollowRequests(long userId, int number, int page)
        {
            List<Model.UserFollow.UserFollowRequest> userFollowRequestsList = new List<XareuServices.Model.UserFollow.UserFollowRequest>();

            var query = (from userFollowRequests in data.user_follow_requests
                         where userFollowRequests.user_id_request == userId
                         select userFollowRequests).Skip<user_follow_request>(number * page).Take<user_follow_request>(number);

            foreach (user_follow_request userFollowRequest in query)
            {
                try
                {
                    userFollowRequestsList.Add(this.getUserFollowRequest(userFollowRequest));
                }
                catch { }
            }

            return userFollowRequestsList;
        }

        /// <summary>
        /// Adds the user follow request.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userRequestedId">The user requested id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserFollowRequest(long userId, long userRequestedId)
        {
            user_follow_request newUserFollowRequest = new user_follow_request();

            newUserFollowRequest.user_id_request = userId;
            newUserFollowRequest.user_id_requested = userRequestedId;
            newUserFollowRequest.datetime = DateTime.Today;

            try
            {
                data.user_follow_requests.InsertOnSubmit(newUserFollowRequest);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Deletes the user follow request.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userRequestedId">The user requested id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserFollowRequest(long userId, long userRequestedId)
        {
            var query = from userFollowRequests in data.user_follow_requests
                        where userFollowRequests.user_id_request == userId
                        where userFollowRequests.user_id_requested == userRequestedId
                        select userFollowRequests;

            try
            {
                data.user_follow_requests.DeleteOnSubmit(query.First<user_follow_request>());
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        #endregion

        /// <summary>
        /// Gets the user follow request.
        /// </summary>
        /// <param name="userFollowRequest">The user follow request.</param>
        /// <returns></returns>
        private Model.UserFollow.UserFollowRequest getUserFollowRequest(user_follow_request userFollowRequest)
        {
            Model.UserFollow.UserFollowRequest newUserFollowRequest = new XareuServices.Model.UserFollow.UserFollowRequest();

            newUserFollowRequest.UserFollowed.Id = userFollowRequest.user_id_request;
            newUserFollowRequest.UserFollowed.Nick = userFollowRequest.user.user_nick;

            newUserFollowRequest.UserFollower.Id = userFollowRequest.user_id_requested;
            newUserFollowRequest.UserFollower.Nick = userFollowRequest.user1.user_nick;

            newUserFollowRequest.DateTime = userFollowRequest.datetime;

            return newUserFollowRequest;
        }
    }
}
