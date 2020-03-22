using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IPlaceTagUsersSubscriptionsDAO
    {
        /// <summary>
        /// Gets the user place tag subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of Tag Places</returns>
        List<Model.TagPlace.TagPlace> GetUserPlaceTagSubscription(long userId, int number, int page);

        /// <summary>
        /// Gets the users subscribed to place tag.
        /// </summary>
        /// <param name="placeTagId">The place tag id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        List<Model.User.User> GetUsersSubscribedToPlaceTag(long placeTagId, int number, int page);

        /// <summary>
        /// Adds the user subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="placeTagId">The place tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool AddUserSubscription(long userId, long placeTagId);

        /// <summary>
        /// Deletes the user subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="placeTagId">The place tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool DeleteUserSubscription(long userId, long placeTagId);
    }
}
