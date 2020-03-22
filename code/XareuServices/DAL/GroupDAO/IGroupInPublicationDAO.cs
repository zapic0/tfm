using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IGroupInPublicationDAO
    {
        /// <summary>
        /// Devuelve la lista de grupos a la que va dirigido un mensaje en particular
        /// Si no va dirigido a ningún grupo, la lista estará vacía
        /// </summary>
        /// <param name="messageId">Id del mensaje que queremos buscar</param>
        /// <returns>Lista de grupos a los que va dirigido el mensaje</returns>
        List<Model.Group.Group> GetGroupsInPublication(long publicationId);

        /// <summary>
        /// Añade un grupo a la lista de receptores de un mensaje en particular
        /// </summary>
        /// <param name="messageId">Id del mensaje que queremos enviar al grupo</param>
        /// <param name="groupId">Id del grupo al que queremos enviar el mensaje</param>
        /// <returns>True si se pudo añadir, false en caso contrario</returns>
        bool AddGroupToPublication(long publicationId, long groupId);

        /// <summary>
        /// Borra un grupo de un mensaje
        /// </summary>
        /// <param name="messageId">Id del mensaje que contenía el grupo</param>
        /// <param name="groupId">Grupo que queremos borrar</param>
        /// <returns>True si se pudo borrar, false en caso contrario</returns>
        bool DeleteGroupFromPublication(long publicationId, long groupId);
    }
}
