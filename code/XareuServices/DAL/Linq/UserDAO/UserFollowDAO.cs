using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.UserDAO
{
    public class UserFollowDAO : IUserFollowDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFollowDAO"/> class.
        /// </summary>
        public UserFollowDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }


        #region IUserFollowDAO Members

        /// <summary>
        /// Gets the user follow.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userFollowedId">The user followed id.</param>
        /// <returns>User Follow</returns>
        public XareuServices.Model.UserFollow.UserFollow GetUserFollow(long userId, long userFollowedId)
        {
            var query = from userFollows in data.user_follows
                        where userFollows.user_id_follower == userId
                        where userFollows.user_id_followed == userFollowedId
                        select userFollows;

            try
            {
                return this.getUserFollow(query.First<user_follow>());
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the user followers.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of user follows</returns>
        public List<XareuServices.Model.UserFollow.UserFollow> GetUserFollowers(long userId, int number, int page)
        {
            List<Model.UserFollow.UserFollow> userFollowsList = new List<XareuServices.Model.UserFollow.UserFollow>();

            var query = (from userFollows in data.user_follows
                        where userFollows.user_id_followed == userId
                         select userFollows).Skip<user_follow>(number * page).Take<user_follow>(number);

            foreach (user_follow newUserFollow in query)
            {
                try
                {
                    userFollowsList.Add(this.getUserFollow(newUserFollow));
                }
                catch { }
            }

            return userFollowsList;
        }

        /// <summary>
        /// Gets the user own follows.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of user follows</returns>
        public List<XareuServices.Model.UserFollow.UserFollow> GetUserOwnFollows(long userId, int number, int page)
        {
            List<Model.UserFollow.UserFollow> userFollowsList = new List<XareuServices.Model.UserFollow.UserFollow>();

            var query = (from userFollows in data.user_follows
                        where userFollows.user_id_follower == userId
                        select userFollows).Skip<user_follow>(number*page).Take<user_follow>(number);

            foreach (user_follow newUserFollow in query)
            {
                try
                {
                    userFollowsList.Add(this.getUserFollow(newUserFollow));
                }
                catch { }
            }

            return userFollowsList;
        }

        /// <summary>
        /// Adds the user follow.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userFollowedId">The user followed id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserFollow(long userId, long userFollowedId)
        {
            user_follow newUserFollow = new user_follow();

            try
            {
                newUserFollow.user_id_follower = userId;
                newUserFollow.user_id_followed = userFollowedId;

                data.user_follows.InsertOnSubmit(newUserFollow);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes the user follow.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="userFollowedId">The user followed id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserFollow(long userId, long userFollowedId)
        {
            var query = from userFollows in data.user_follows
                        where userFollows.user_id_follower == userId
                        where userFollows.user_id_followed == userFollowedId
                        select userFollows;

            try
            {
                data.user_follows.DeleteOnSubmit(query.First<user_follow>());
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
        /// Gets the user follow.
        /// </summary>
        /// <param name="userFollow">The user follow.</param>
        /// <returns></returns>
        private Model.UserFollow.UserFollow getUserFollow(user_follow userFollow)
        {
            Model.UserFollow.UserFollow newUserFollow = new XareuServices.Model.UserFollow.UserFollow();

            newUserFollow.UserFollowed.Id = userFollow.user_id_followed;
            newUserFollow.UserFollowed.Nick = userFollow.user1.user_nick;
            newUserFollow.UserFollowed.Email = userFollow.user1.user_email;

            newUserFollow.UserFollowing.Id = userFollow.user_id_follower;
            newUserFollow.UserFollowing.Nick = userFollow.user.user_nick;
            newUserFollow.UserFollowing.Email = userFollow.user.user_email;

            return newUserFollow;
        }
    }
}
