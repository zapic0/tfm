using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.PlaceTagDAO
{
    public class PlaceTagUsersSubscriptionsDAO : IPlaceTagUsersSubscriptionsDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceTagUsersSubscriptionsDAO"/> class.
        /// </summary>
        public PlaceTagUsersSubscriptionsDAO ()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IPlaceTagUsersSubscriptionsDAO Members

        /// <summary>
        /// Gets the user place tag subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of Tag Places</returns>
        public List<Model.TagPlace.TagPlace> GetUserPlaceTagSubscription(long userId, int number, int page)
        {
            List<Model.TagPlace.TagPlace> tagPlacesList = new List<XareuServices.Model.TagPlace.TagPlace>();

            var query = (from tagPlaces in data.place_tag_users_subscriptions
                         where tagPlaces.user_id == userId
                         select tagPlaces).Skip<place_tag_users_subscription>(number * page).Take<place_tag_users_subscription>(number);

            foreach (place_tag_users_subscription placeTag in query)
            {
                Model.TagPlace.TagPlace newTagPlace = new XareuServices.Model.TagPlace.TagPlace();

                newTagPlace.Id = placeTag.place_tag_id;
                newTagPlace.Name = placeTag.place_tag.place_tag_name;
                try
                {
                    newTagPlace.ParentId = (long)placeTag.place_tag.place_tag_parent;
                }
                catch { newTagPlace.ParentId = 0; }

                tagPlacesList.Add(newTagPlace);
            }

            return tagPlacesList;
        }

        /// <summary>
        /// Gets the users subscribed to place tag.
        /// </summary>
        /// <param name="placeTagId">The place tag id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        public List<Model.User.User> GetUsersSubscribedToPlaceTag(long placeTagId, int number, int page)
        {
            List<Model.User.User> usersSubscribedList = new List<XareuServices.Model.User.User>();

            var query = (from subscriptions in data.place_tag_users_subscriptions
                         where subscriptions.place_tag_id == placeTagId
                         select subscriptions).Skip<place_tag_users_subscription>(number * page).Take<place_tag_users_subscription>(number);

            foreach (place_tag_users_subscription subscription in query)
            {
                usersSubscribedList.Add(this.getUser(subscription.user));
            }

            return usersSubscribedList;
        }

        /// <summary>
        /// Adds the user subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="placeTagId">The place tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserSubscription(long userId, long placeTagId)
        {
            place_tag_users_subscription subscription = new place_tag_users_subscription();

            try
            {
                subscription.user_id = userId;
                subscription.place_tag_id = placeTagId;
                data.place_tag_users_subscriptions.InsertOnSubmit(subscription);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes the user subscription.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="placeTagId">The place tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserSubscription(long userId, long placeTagId)
        {
            var query = from subscriptions in data.place_tag_users_subscriptions
                        where subscriptions.user_id == userId
                        where subscriptions.place_tag_id == placeTagId
                        select subscriptions;

            try
            {
                place_tag_users_subscription subscriptionToDelete = query.First<place_tag_users_subscription>();
                data.place_tag_users_subscriptions.DeleteOnSubmit(subscriptionToDelete);
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
