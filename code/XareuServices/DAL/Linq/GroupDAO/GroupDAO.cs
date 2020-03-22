using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.GroupDAO
{
    /// <summary>
    /// Class for group data access
    /// </summary>
    public class GroupDAO : IGroupDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDAO"/> class.
        /// </summary>
        public GroupDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IGroupDAO Members

        /// <summary>
        /// Devuelve el grupo del id especificado
        /// </summary>
        /// <param name="id">Id del grupo que queremos recuperar</param>
        /// <returns>
        /// Grupo con el id correspondiente, null si no existe
        /// </returns>
        public XareuServices.Model.Group.Group GetGroupById(long id)
        {
            IEnumerable<group> query = from groups in data.groups
                                       where groups.group_id == id
                                       select groups;

            group group;
            Model.Group.Group groupReturn = new XareuServices.Model.Group.Group();

            try
            {
                group = query.First<group>();
                groupReturn = this.GetGroup(group);
            }

            catch
            {
                groupReturn = null;
            }

            return groupReturn;
        }

        /// <summary>
        /// Devuelve el grupo del nombre especificado
        /// </summary>
        /// <param name="name">Nombre del grupo que queremos recuperar</param>
        /// <returns>
        /// Grupo con el nombre correspondiente, null si no existe
        /// </returns>
        public XareuServices.Model.Group.Group GetGroupByName(string name)
        {
            IEnumerable<group> query = from groups in data.groups
                                       where groups.group_name == name
                                       select groups;

            try
            {
                group groupData = query.First<group>();
                Model.Group.Group groupReturn = this.GetGroup(groupData);                
                return groupReturn;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Devuelve todos los grupos registrados en el sistema.
        /// Tiene en cuenta el número de elementos que se desean recibir y la página de resultados.
        /// </summary>
        /// <param name="number">Número de elementos por página</param>
        /// <param name="page">Número de página</param>
        /// <returns>Lista de grupos</returns>
        public List<XareuServices.Model.Group.Group> GetGroups(int number, int page)
        {
            List<Model.Group.Group> groupsList = new List<XareuServices.Model.Group.Group>();

            var query = (from groups in data.groups
                         select groups).Skip<group>(page * number).Take<group>(number);

            foreach (group group in query)
            {
                groupsList.Add(this.GetGroup(group));
            }

            return groupsList;
        }

        /// <summary>
        /// Gets the user own groups.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<XareuServices.Model.Group.Group> GetUserOwnGroups(long userID, int number, int page)
        {
            List<Model.Group.Group> groupsList = new List<XareuServices.Model.Group.Group>();

            var query = (from groups in data.groups
                         where groups.user_id_owner == userID
                         select groups).Skip<group>(page * number).Take<group>(number);

            foreach (group group in query)
            {
                groupsList.Add(this.GetGroup(group));
            }

            return groupsList;
        }

        /// <summary>
        /// Crea un grupo con el nombre especificado por el usuario especificado
        /// </summary>
        /// <param name="name">Nombre del grupo</param>
        /// <param name="userId">Usuario que crea el grupo</param>
        /// <returns>
        /// True si pudo crear el grupo, false en caso contrario
        /// </returns>
        public bool CreateGroup(string name, long userId)
        {
            try
            {
                group group = new group();
                group.group_creation = DateTime.Now;
                group.group_name = name;
                group.user_id_owner = userId;

                data.groups.InsertOnSubmit(group);
                data.SubmitChanges();
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Borra un grupo especificado por su Id
        /// </summary>
        /// <param name="groupId">Id del grupo a borrar</param>
        /// <returns>
        /// True si se pudo borrar, false en caso contrario
        /// </returns>
        public bool DeleteGroup(long groupId)
        {
            try
            {
                IEnumerable<group> query = from groups in data.groups
                                           where groups.group_id == groupId
                                           select groups;

                group group = query.First<group>();

                this.data.groups.DeleteOnSubmit(query.First<group>());
                this.data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Cambia la privacidad del grupo
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="isPrivate">Lo ponemos a true si queremos que el grupo sea privado y viceversa</param>
        /// <returns>
        /// True si se pudo cambiar, false en caso contrario
        /// </returns>
        public bool SetGroupPrivacy(long groupId, bool isPrivate)
        {
            var query = from groups in data.groups
                        where groups.group_id == groupId
                        select groups;

            try
            {
                group group = query.First<group>();
                group.group_is_private = isPrivate;

                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Searches by the name of the group.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>
        /// List of groups that contains the specified name
        /// </returns>
        public List<Model.Group.Group> SearchGroupByName(string name, int number, int page)
        {
            List<Model.Group.Group> groupsList = new List<XareuServices.Model.Group.Group>();

            var query = (from groups in data.groups
                         where groups.group_name.Contains(name)
                         select groups).Skip<group>(page * number).Take<group>(number);

            foreach (group group in query)
            {
                groupsList.Add(this.GetGroup(group));
            }

            return groupsList;
        }

        #endregion

        /// <summary>
        /// Gets the group.
        /// </summary>
        /// <param name="group">The group.</param>
        /// <returns>Group</returns>
        private Model.Group.Group GetGroup(group group)
        {
            Model.Group.Group modelGroup = new Model.Group.Group();

            modelGroup.Creation = group.group_creation;
            modelGroup.Id = group.group_id;
            modelGroup.Name = group.group_name;
            modelGroup.Owner.Nick = group.user.user_nick;
            modelGroup.Owner.Id = group.user.user_id;
            modelGroup.Owner.Karma = group.user.user_karma;
            modelGroup.Owner.UserPictureURL = group.user.user_picture;

            return modelGroup;
        }
    }
}
