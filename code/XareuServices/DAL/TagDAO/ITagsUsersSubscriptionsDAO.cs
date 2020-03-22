using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface ITagsUsersSubscriptionsDAO
    {
        /// <summary>
        /// Gets all user subscriptions.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags</returns>
        List<Model.Tag.Tag> GetAllUserSubscriptions(long userId, int number, int page);

        /// <summary>
        /// Gets all users subscribed to tag.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        List<Model.User.User> GetAllUsersSubscribedToTag(long tagId, int number, int page);

        /// <summary>
        /// Adds the user subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="tagId">The tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool AddUserSubscription(long userId, long tagId);

        /// <summary>
        /// Deletes the user subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="tagId">The tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool DeleteUserSubscription(long userId, long tagId);
    }
}
