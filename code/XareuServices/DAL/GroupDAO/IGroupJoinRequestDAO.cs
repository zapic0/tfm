using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IGroupJoinRequestDAO
    {
        /// <summary>
        /// Devuelve la solicitud de unión de un usuario a un grupo en particular
        /// </summary>
        /// <param name="groupId">Id del grupo de la solicitud</param>
        /// <param name="userId">Id del usuario de la solicitud</param>
        /// <returns>Solicitud de unión al grupo</returns>
        Model.Group.GroupJoinRequest GetGroupJoinRequest(long groupId, long userId);

        /// <summary>
        /// Devuelve la lista de peticiones de unión a un grupo determinado
        /// </summary>
        /// <param name="groupId">Id del grupo del que queremos obtener las peticiones de unión</param>
        /// <param name="number">Número de peticiones por página</param>
        /// <param name="page">Página que queremos obtener</param>
        /// <returns>Peticiones de unión al grupo</returns>
        List<Model.Group.GroupJoinRequest> GetGroupJoinRequests(long groupId, int number, int page);

        /// <summary>
        /// Devuelve la lista de peticiones que ha hecho un usuario
        /// </summary>
        /// <param name="userId">Id del usuario</param>
        /// <param name="number">Número de peticiones por página</param>
        /// <param name="page">Página que queremos obtener</param>
        /// <returns>Peticiones de unión del usuario</returns>
        List<Model.Group.GroupJoinRequest> GetUserJoinRequests(long userId, int number, int page);

        /// <summary>
        /// Añade una solicitud de unión de un usuario a un grupo determinado
        /// </summary>
        /// <param name="groupId">Id del rupo al que se desea unir</param>
        /// <param name="userId">Id del usuario</param>
        /// <returns>True si se pudo realizar la solicitud, false en caso contrario</returns>
        bool AddJoinRequest(long groupId, long userId);

        /// <summary>
        /// Borra una solicitud de unión de un usuario a un grupo determinado
        /// </summary>
        /// <param name="groupId">Id del grupo</param>
        /// <param name="userId">Id del usuario</param>
        /// <returns>True si se pudo borrar, false en caso contrario</returns>
        bool DeleteJoinRequest(long groupId, long userId);
    }
}
