using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IGroupDAO
    {
        /// <summary>
        /// Devuelve el grupo del id especificado
        /// </summary>
        /// <param name="id">Id del grupo que queremos recuperar</param>
        /// <returns>Grupo con el id correspondiente, null si no existe</returns>
        Model.Group.Group GetGroupById(long id);

        /// <summary>
        /// Devuelve el grupo del nombre especificado
        /// </summary>
        /// <param name="name">Nombre del grupo que queremos recuperar</param>
        /// <returns>Grupo con el nombre correspondiente, null si no existe</returns>
        Model.Group.Group GetGroupByName(string name);

        /// <summary>
        /// Devuelve todos los grupos registrados en el sistema.
        /// Tiene en cuenta el número de elementos que se desean recibir y la página de resultados.
        /// </summary>
        /// <param name="number">Número de elementos por página</param>
        /// <param name="page">Número de página</param>
        /// <returns>Lista de grupos</returns>
        List<Model.Group.Group> GetGroups(int number, int page);

        /// <summary>
        /// Crea un grupo con el nombre especificado por el usuario especificado
        /// </summary>
        /// <param name="name">Nombre del grupo</param>
        /// <param name="userId">Usuario que crea el grupo</param>
        /// <returns>True si pudo crear el grupo, false en caso contrario</returns>
        bool CreateGroup(string name, long userId);

        /// <summary>
        /// Borra un grupo especificado por su Id
        /// </summary>
        /// <param name="groupId">Id del grupo a borrar</param>
        /// <returns>True si se pudo borrar, false en caso contrario</returns>
        bool DeleteGroup(long groupId);

        /// <summary>
        /// Cambia la privacidad del grupo
        /// </summary>
        /// <param name="isPrivate">Lo ponemos a true si queremos que el grupo sea privado y viceversa</param>
        /// <returns>True si se pudo cambiar, false en caso contrario</returns>
        bool SetGroupPrivacy(long groupId, bool isPrivate);


        /// <summary>
        /// Searches by the name of the group.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of groups that contains the specified name</returns>
        List<Model.Group.Group> SearchGroupByName(string name, int number, int page);
    }
}
