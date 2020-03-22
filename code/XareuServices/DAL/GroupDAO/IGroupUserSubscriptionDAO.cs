using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IGroupUserSubscriptionDAO
    {
        /// <summary>
        /// Devuelve la lista de usuarios suscritos a un grupo determinado
        /// </summary>
        /// <param name="groupId">Id del grupo</param>
        /// <param name="number">Número de resultados por página</param>
        /// <param name="page">Página a obtener</param>
        /// <returns>Lista de usuarios suscritos al grupo</returns>
        List<Model.Group.GroupUsers> GetSubscribedUsers(long groupId, int number, int page);

        /// <summary>
        /// Devuelve la lista de suscripciones de un usuario determinado
        /// </summary>
        /// <param name="userId">Id del usuario que queremos obtener</param>
        /// <param name="number">Número de resultados por página</param>
        /// <param name="page">Págna a obtener</param>
        /// <returns>Lista de suscripciones de un usuario</returns>
        List<Model.Group.GroupUsers> GetUserSubscriptions(long userId, int number, int page);

        /// <summary>
        /// Añade una subscripción de un usuario a un grupo
        /// </summary>
        /// <param name="groupId">Grupo de la subscripción</param>
        /// <param name="userId">Usuario</param>
        /// <returns>True si se pudo suscribir, false en caso contrario</returns>
        bool AddSubscription(long groupId, long userId);

        /// <summary>
        /// Borra una subscripción para un grupo y usuario determinados
        /// </summary>
        /// <param name="groupId">Id del grupo</param>
        /// <param name="userId">Id del usuario</param>
        /// <returns>True si se pudo borrar, false en caso contrario</returns>
        bool DeleteSubscription(long groupId, long userId);
    }
}
