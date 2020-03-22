using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.GroupDAO
{
    /// <summary>
    /// Class of Group Join Request data access
    /// </summary>
    public class GroupJoinRequestDAO : IGroupJoinRequestDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupJoinRequestDAO"/> class.
        /// </summary>
        public GroupJoinRequestDAO ()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IGroupJoinRequestDAO Members

        /// <summary>
        /// Devuelve la solicitud de unión de un usuario a un grupo en particular
        /// </summary>
        /// <param name="groupId">Id del grupo de la solicitud</param>
        /// <param name="userId">Id del usuario de la solicitud</param>
        /// <returns>Solicitud de unión al grupo</returns>
        public XareuServices.Model.Group.GroupJoinRequest GetGroupJoinRequest(long groupId, long userId)
        {
            var query = from joinRequests in data.group_join_requests
                        where joinRequests.group_id == groupId
                        where joinRequests.user_id_request == userId
                        select joinRequests;

            
            Model.Group.GroupJoinRequest joinRequest = null;

            try
            {
                joinRequest = this.getGroupJoinRequest(query.First<group_join_request>());
            }
            catch { }

            return joinRequest;
        }

        /// <summary>
        /// Devuelve la lista de peticiones de unión a un grupo determinado
        /// </summary>
        /// <param name="groupId">Id del grupo del que queremos obtener las peticiones de unión</param>
        /// <param name="number">Número de peticiones por página</param>
        /// <param name="page">Página que queremos obtener</param>
        /// <returns>Peticiones de unión al grupo</returns>
        public List<XareuServices.Model.Group.GroupJoinRequest> GetGroupJoinRequests(long groupId, int number, int page)
        {
            List<Model.Group.GroupJoinRequest> listGroupJoinRequest = new List<XareuServices.Model.Group.GroupJoinRequest>();

            IEnumerable<group_join_request> query = (from groupJoinRequests in data.group_join_requests
                                                     where groupJoinRequests.group_id == groupId
                                                     select groupJoinRequests).Skip<group_join_request>(page * number).Take<group_join_request>(number);

            foreach (group_join_request groupJoinRequest in query)
            {
                Model.Group.GroupJoinRequest newGroupJoinRequest = this.getGroupJoinRequest(groupJoinRequest);
                listGroupJoinRequest.Add(newGroupJoinRequest);
            }

            return listGroupJoinRequest;
        }

        /// <summary>
        /// Devuelve la lista de peticiones que ha hecho un usuario
        /// </summary>
        /// <param name="userId">Id del usuario</param>
        /// <param name="number">Número de peticiones por página</param>
        /// <param name="page">Página que queremos obtener</param>
        /// <returns>Peticiones de unión del usuario</returns>
        public List<XareuServices.Model.Group.GroupJoinRequest> GetUserJoinRequests(long userId, int number, int page)
        {
            List<Model.Group.GroupJoinRequest> listGroupJoinRequest = new List<XareuServices.Model.Group.GroupJoinRequest>();

            IEnumerable<group_join_request> query = (from groupJoinRequests in data.group_join_requests
                                                     where groupJoinRequests.user_id_request == userId
                                                     select groupJoinRequests).Skip<group_join_request>(page * number).Take<group_join_request>(number);

            foreach (group_join_request groupJoinRequest in query)
            {
                Model.Group.GroupJoinRequest newGroupJoinRequest = this.getGroupJoinRequest(groupJoinRequest);
                listGroupJoinRequest.Add(newGroupJoinRequest);
            }

            return listGroupJoinRequest;
        }

        /// <summary>
        /// Añade una solicitud de unión de un usuario a un grupo determinado
        /// </summary>
        /// <param name="groupId">Id del rupo al que se desea unir</param>
        /// <param name="userId">Id del usuario</param>
        /// <returns>
        /// True si se pudo realizar la solicitud, false en caso contrario
        /// </returns>
        public bool AddJoinRequest(long groupId, long userId)
        {
            group_join_request groupJoinRequest = new group_join_request();

            groupJoinRequest.user_id_request = userId;
            groupJoinRequest.group_id = groupId;
            groupJoinRequest.datetime = DateTime.Now;

            try
            {
                data.group_join_requests.InsertOnSubmit(groupJoinRequest);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Borra una solicitud de unión de un usuario a un grupo determinado
        /// </summary>
        /// <param name="groupId">Id del grupo</param>
        /// <param name="userId">Id del usuario</param>
        /// <returns>
        /// True si se pudo borrar, false en caso contrario
        /// </returns>
        public bool DeleteJoinRequest(long groupId, long userId)
        {
            var query = from groupJoinRequests in data.group_join_requests
                        where groupJoinRequests.group_id == groupId
                        where groupJoinRequests.user_id_request == userId
                        select groupJoinRequests;

            try
            {
                group_join_request groupJoinRequest = query.First<group_join_request>();
                data.group_join_requests.DeleteOnSubmit(groupJoinRequest);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        #endregion

        /// <summary>
        /// Gets the group join request.
        /// </summary>
        /// <param name="groupJoinRequest">The group join request.</param>
        /// <returns></returns>
        private Model.Group.GroupJoinRequest getGroupJoinRequest(group_join_request groupJoinRequest)
        {
            Model.Group.GroupJoinRequest groupJoinRequestReturn = new XareuServices.Model.Group.GroupJoinRequest();

            groupJoinRequestReturn.Group.Id = groupJoinRequest.group_id;
            groupJoinRequestReturn.Group.Name = groupJoinRequest.group.group_name;
            groupJoinRequestReturn.Group.IsPrivate = (bool)groupJoinRequest.group.group_is_private;
            groupJoinRequestReturn.Group.Owner.Id = groupJoinRequest.group.user_id_owner;
            groupJoinRequestReturn.Group.Owner.Nick = groupJoinRequest.group.user.user_nick;
            groupJoinRequestReturn.Group.Creation = groupJoinRequest.group.group_creation;

            groupJoinRequestReturn.User.Email = groupJoinRequest.user.user_email;
            groupJoinRequestReturn.User.Id = groupJoinRequest.user.user_id;
            groupJoinRequestReturn.User.Nick = groupJoinRequest.user.user_nick;

            return groupJoinRequestReturn;
        }
    }
}
