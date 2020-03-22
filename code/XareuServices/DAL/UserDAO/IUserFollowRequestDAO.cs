using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IUserFollowRequestDAO
    {

        /// <summary>
        /// Gets the user follow request.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userRequestedId">The user requested id.</param>
        /// <returns>User Follow Request</returns>
        Model.UserFollow.UserFollowRequest GetUserFollowRequest(long userId, long userRequestedId);

        /// <summary>
        /// Gets the user follow requests.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of User Follow Request</returns>
        List<Model.UserFollow.UserFollowRequest> GetUserFollowRequests(long userId, int number, int page);

        /// <summary>
        /// Gets the user own follow requests.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of User Follow Request</returns>
        List<Model.UserFollow.UserFollowRequest> GetUserOwnFollowRequests(long userId, int number, int page);

        /// <summary>
        /// Adds the user follow request.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userRequestedId">The user requested id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool AddUserFollowRequest(long userId, long userRequestedId);

        /// <summary>
        /// Deletes the user follow request.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userRequestedId">The user requested id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool DeleteUserFollowRequest(long userId, long userRequestedId);
    }
}
