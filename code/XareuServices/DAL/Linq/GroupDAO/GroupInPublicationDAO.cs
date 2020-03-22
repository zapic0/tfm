using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.GroupDAO
{
    /// <summary>
    /// Class for group in publication data access
    /// </summary>
    public class GroupInPublicationDAO : IGroupInPublicationDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupInPublicationDAO"/> class.
        /// </summary>
        public GroupInPublicationDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IGroupInPublicationDAO Members

        /// <summary>
        /// Devuelve la lista de grupos a la que va dirigido un mensaje en particular
        /// Si no va dirigido a ningún grupo, la lista estará vacía
        /// </summary>
        /// <param name="publicationId"></param>
        /// <returns>
        /// Lista de grupos a los que va dirigido el mensaje
        /// </returns>
        public List<XareuServices.Model.Group.Group> GetGroupsInPublication(long publicationId)
        {
            List<Model.Group.Group> groups = new List<XareuServices.Model.Group.Group>();

            IEnumerable<group_in_publication> query = from groupsInPublication in data.group_in_publications
                                                      where groupsInPublication.group_id == publicationId
                                                      select groupsInPublication;

            foreach (group_in_publication group in query)
            {
                Model.Group.Group newGroup = this.getGroup(group.group_id);

                groups.Add(newGroup);
            }

            return groups;
        }

        /// <summary>
        /// Añade un grupo a la lista de receptores de un mensaje en particular
        /// </summary>
        /// <param name="publicationId"></param>
        /// <param name="groupId">Id del grupo al que queremos enviar el mensaje</param>
        /// <returns>
        /// True si se pudo añadir, false en caso contrario
        /// </returns>
        public bool AddGroupToPublication(long publicationId, long groupId)
        {
            group_in_publication groupInPublication = new group_in_publication();

            groupInPublication.group_id = groupId;
            groupInPublication.publication_id = publicationId;

            try
            {
                data.group_in_publications.InsertOnSubmit(groupInPublication);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Borra un grupo de un mensaje
        /// </summary>
        /// <param name="publicationId"></param>
        /// <param name="groupId">Grupo que queremos borrar</param>
        /// <returns>
        /// True si se pudo borrar, false en caso contrario
        /// </returns>
        public bool DeleteGroupFromPublication(long publicationId, long groupId)
        {
            var query = from groups in data.group_in_publications
                        where groups.publication_id == publicationId
                        where groups.group_id == groupId
                        select groups;

            try
            {
                group_in_publication group = query.First<group_in_publication>();

                data.group_in_publications.DeleteOnSubmit(group);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        #endregion


        /// <summary>
        /// Gets the group.
        /// </summary>
        /// <param name="groupId">The group id.</param>
        /// <returns>Group</returns>
        private Model.Group.Group getGroup(long groupId)
        {
            Model.Group.Group newGroup = new XareuServices.Model.Group.Group();

            var query = from groups in data.groups
                        where groups.group_id == groupId
                        select groups;

            try
            {
                group group = query.First<group>();
                newGroup.Creation = group.group_creation;
                newGroup.Id = group.group_id;
                try
                {
                    newGroup.IsPrivate = (bool)group.group_is_private;
                }
                catch { newGroup.IsPrivate = false; }
                newGroup.Name = group.group_name;
                newGroup.Owner.Nick = group.user.user_nick;
                newGroup.Owner.Id = group.user.user_id;
            }
            catch { newGroup = null; }

            return newGroup;
        }
    }
}
