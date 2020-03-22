using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IUserFollowDAO
    {
        /// <summary>
        /// Gets the user follow.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userFollowedId">The user followed id.</param>
        /// <returns>User Follow</returns>
        Model.UserFollow.UserFollow GetUserFollow(long userId, long userFollowedId);

        /// <summary>
        /// Gets the user followers.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of user follows</returns>
        List<Model.UserFollow.UserFollow> GetUserFollowers(long userId, int number, int page);

        /// <summary>
        /// Gets the user own follows.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of user follows</returns>
        List<Model.UserFollow.UserFollow> GetUserOwnFollows(long userId, int number, int page);

        /// <summary>
        /// Adds the user follow.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userFollowedId">The user followed id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool AddUserFollow(long userId, long userFollowedId);

        /// <summary>
        /// Deletes the user follow.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userFollowedId">The user followed id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool DeleteUserFollow(long userId, long userFollowedId);
    }
}
