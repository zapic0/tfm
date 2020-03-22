using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.TagDAO
{
    public class TagsUsersSubscriptionsDAO : ITagsUsersSubscriptionsDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsUsersSubscriptionsDAO"/> class.
        /// </summary>
        public TagsUsersSubscriptionsDAO ()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region ITagsUsersSubscriptionsDAO Members

        /// <summary>
        /// Gets all user subscriptions.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags</returns>
        public List<Model.Tag.Tag> GetAllUserSubscriptions(long userId, int number, int page)
        {
            List<Model.Tag.Tag> tagsList = new List<XareuServices.Model.Tag.Tag>();

            var query = from tags in data.tags_users_subscriptions
                        where tags.user_id == userId
                        select tags;

            foreach (tags_users_subscription tag in query)
            {
                tagsList.Add(this.getTag(tag));
            }

            return tagsList;
        }

        /// <summary>
        /// Gets all users subscribed to tag.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        public List<Model.User.User> GetAllUsersSubscribedToTag(long tagId, int number, int page)
        {
            List<Model.User.User> usersList = new List<XareuServices.Model.User.User>();

            var query = from users in data.tags_users_subscriptions
                        where users.tag_id == tagId
                        select users;

            foreach (tags_users_subscription user in query)
            {
                usersList.Add(this.getUser(user.user));
            }

            return usersList;
        }

        /// <summary>
        /// Adds the user subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="tagId">The tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserSubscription(long userId, long tagId)
        {
            try
            {
                tags_users_subscription newUserSubscription = new tags_users_subscription();
                newUserSubscription.user_id = userId;
                newUserSubscription.tag_id = tagId;
                data.tags_users_subscriptions.InsertOnSubmit(newUserSubscription);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Deletes the user subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="tagId">The tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserSubscription(long userId, long tagId)
        {
            var query = from userSubscriptions in data.tags_users_subscriptions
                        where userSubscriptions.tag_id == tagId
                        where userSubscriptions.user_id == userId
                        select userSubscriptions;

            try
            {
                tags_users_subscription userSubscription = query.First<tags_users_subscription>();
                data.tags_users_subscriptions.DeleteOnSubmit(userSubscription);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns></returns>
        private Model.Tag.Tag getTag(tags_users_subscription tag)
        {
            Model.Tag.Tag newTag = new XareuServices.Model.Tag.Tag();

            newTag.Id = tag.tag_id;
            newTag.Name = tag.tag.tag_name;

            return newTag;
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        private Model.User.User getUser(user user)
        {
            Model.User.User newUser = new XareuServices.Model.User.User();

            newUser.DefaultPlace.Id = user.user_default_place;
            newUser.Email = user.user_email;
            newUser.Id = user.user_id;
            newUser.Karma = user.user_karma;
            newUser.Nick = user.user_nick;

            return newUser;
        }
    }
}
