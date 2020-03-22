using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.GroupDAO
{
    /// <summary>
    /// Class for Group User Subscription data access
    /// </summary>
    public class GroupUserSubscriptionDAO : IGroupUserSubscriptionDAO
    {

        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUserSubscriptionDAO"/> class.
        /// </summary>
        public GroupUserSubscriptionDAO ()
	    {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IGroupUserSubscriptionDAO Members

        /// <summary>
        /// Devuelve la lista de usuarios suscritos a un grupo determinado
        /// </summary>
        /// <param name="groupId">Id del grupo</param>
        /// <param name="number">Número de resultados por página</param>
        /// <param name="page">Página a obtener</param>
        /// <returns>Lista de usuarios suscritos al grupo</returns>
        public List<XareuServices.Model.Group.GroupUsers> GetSubscribedUsers(long groupId, int number, int page)
        {
            List<Model.Group.GroupUsers> subscribedUsersList = new List<XareuServices.Model.Group.GroupUsers>();

            var query = (from subscribedUsers in data.groups_users_subscriptions
                         where subscribedUsers.group_id == groupId
                         select subscribedUsers).Skip<groups_users_subscription>(number * page).Take<groups_users_subscription>(number);
            try
            {
                foreach (groups_users_subscription userSubscribed in query)
                {
                    subscribedUsersList.Add(this.getUserSubscription(userSubscribed));
                }
            }
            catch { }

            return subscribedUsersList;
        }

        /// <summary>
        /// Devuelve la lista de suscripciones de un usuario determinado
        /// </summary>
        /// <param name="userId">Id del usuario que queremos obtener</param>
        /// <param name="number">Número de resultados por página</param>
        /// <param name="page">Págna a obtener</param>
        /// <returns>Lista de suscripciones de un usuario</returns>
        public List<XareuServices.Model.Group.GroupUsers> GetUserSubscriptions(long userId, int number, int page)
        {
            List<Model.Group.GroupUsers> userSubscriptionsList = new List<XareuServices.Model.Group.GroupUsers>();

            var query = (from userSubscriptions in data.groups_users_subscriptions
                         where userSubscriptions.user_id == userId
                         select userSubscriptions).Skip<groups_users_subscription>(number * page).Take<groups_users_subscription>(number);
            try
            {
                foreach (groups_users_subscription userSubscribed in query)
                {
                    userSubscriptionsList.Add(this.getUserSubscription(userSubscribed));
                }
            }
            catch { }

            return userSubscriptionsList;
        }

        /// <summary>
        /// Añade una subscripción de un usuario a un grupo
        /// </summary>
        /// <param name="groupId">Grupo de la subscripción</param>
        /// <param name="userId">Usuario</param>
        /// <returns>
        /// True si se pudo suscribir, false en caso contrario
        /// </returns>
        public bool AddSubscription(long groupId, long userId)
        {
            try
            {
                groups_users_subscription userSubscription = new groups_users_subscription();
                userSubscription.user_id = userId;
                userSubscription.group_id = groupId;
                data.groups_users_subscriptions.InsertOnSubmit(userSubscription);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Borra una subscripción para un grupo y usuario determinados
        /// </summary>
        /// <param name="groupId">Id del grupo</param>
        /// <param name="userId">Id del usuario</param>
        /// <returns>
        /// True si se pudo borrar, false en caso contrario
        /// </returns>
        public bool DeleteSubscription(long groupId, long userId)
        {
            var query = from subscriptions in data.groups_users_subscriptions
                        where subscriptions.group_id == groupId
                        where subscriptions.user_id == userId
                        select subscriptions;

            try
            {
                groups_users_subscription subscription = query.First<groups_users_subscription>();
                data.groups_users_subscriptions.DeleteOnSubmit(subscription);
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
        /// Gets the user subscription.
        /// </summary>
        /// <param name="groupUserSubscription">The group user subscription.</param>
        /// <returns></returns>
        private Model.Group.GroupUsers getUserSubscription(groups_users_subscription groupUserSubscription)
        {
            Model.Group.GroupUsers newGroupUserSubscription = new XareuServices.Model.Group.GroupUsers();

            newGroupUserSubscription.Group.Id = groupUserSubscription.group_id;
            newGroupUserSubscription.Group.Name = groupUserSubscription.group.group_name;
            try
            {
                newGroupUserSubscription.Group.IsPrivate = (bool)groupUserSubscription.group.group_is_private;
            }
            catch { newGroupUserSubscription.Group.IsPrivate = false; }
            newGroupUserSubscription.Group.Owner.Id = groupUserSubscription.group.user.user_id;
            newGroupUserSubscription.Group.Owner.Nick = groupUserSubscription.group.user.user_nick;
            newGroupUserSubscription.Group.Creation = groupUserSubscription.group.group_creation;

            newGroupUserSubscription.User.Email = groupUserSubscription.user.user_email;
            newGroupUserSubscription.User.Id = groupUserSubscription.user.user_id;
            newGroupUserSubscription.User.Nick = groupUserSubscription.user.user_nick;

            return newGroupUserSubscription;
        }
    }
}
