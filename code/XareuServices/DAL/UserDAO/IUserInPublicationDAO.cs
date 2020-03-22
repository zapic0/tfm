using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IUserInPublicationDAO
    {
        /// <summary>
        /// Userses the in publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        List<Model.User.User> UsersInPublication(long publicationId, int number, int page);

        /// <summary>
        /// Users the mentions.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications</returns>
        List<Model.Publication.Publication> UserMentions(long userId, int number, int page);

        /// <summary>
        /// Adds the user in publication.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool AddUserInPublication(long userId, int publicationId);

        /// <summary>
        /// Deletes the user from publication.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool DeleteUserFromPublication(long userId, int publicationId);
    }
}
