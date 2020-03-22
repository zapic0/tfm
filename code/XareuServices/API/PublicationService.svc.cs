using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    // NOTE: If you change the class name "PublicationService" here, you must also update the reference to "PublicationService" in Web.config.
    /// <summary>
    /// Services that operate over Publications options
    /// </summary>
    public class PublicationService : IPublicationService
    {
        Services.Publication.Publication publicationService = new XareuServices.Services.Publication.Publication();

        #region IPublicationService Members

        /// <summary>
        /// Gets all publications.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="questions">if set to <c>true</c> [questions].</param>
        /// <param name="publications">if set to <c>true</c> [publications].</param>
        /// <returns>List with publications</returns>
        public List<XareuServices.Model.Publication.Publication> GetAllPublications(int number, int page, bool questions, bool publications)
        {
            return publicationService.GetAllPublications(number, page, questions, publications);
        }

        /// <summary>
        /// Gets the publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>Publication</returns>
        public XareuServices.Model.Publication.Publication GetPublication(long publicationID)
        {
            return publicationService.GetPublication(publicationID);
        }

        /// <summary>
        /// Gets the publication answers.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publication's answers</returns>
        public List<XareuServices.Model.Publication.Publication> GetPublicationAnswers(long publicationID, int number, int page)
        {
            return publicationService.GetPublicationAnswers(publicationID, number, page);
        }

        /// <summary>
        /// Searches the publication with text.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="text">The text.</param>
        /// <returns>List of publications with text</returns>
        public List<XareuServices.Model.Publication.Publication> SearchPublicationWithText(long userID, Guid token, out Guid newToken, int number, int page, string text)
        {
            return publicationService.SearchPublicationWithText(userID, token, out newToken, number, page, text);
        }

        /// <summary>
        /// Adds the publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publication">The publication.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns></returns>
        public bool AddPublication(long userID, Guid token, out Guid newToken, XareuServices.Model.Publication.Publication publication, out long publicationID)
        {
            return publicationService.AddPublication(userID, token, out newToken, publication, out publicationID);
        }

        /// <summary>
        /// Edits the publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publication">The publication.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool EditPublication(long userID, Guid token, out Guid newToken, XareuServices.Model.Publication.Publication publication)
        {
            return publicationService.EditPublication(userID, token, out newToken, publication);
        }

        /// <summary>
        /// Gets the user publications.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="questions">if set to <c>true</c> [questions].</param>
        /// <param name="publications">if set to <c>true</c> [publications].</param>
        /// <returns>List of user's publications</returns>
        public List<XareuServices.Model.Publication.Publication> GetUserPublications(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page, bool questions, bool publications)
        {
            return publicationService.GetUserPublications(userID, token, out newToken, userAuthorID, number, page, questions, publications);
        }

        /// <summary>
        /// Gets the publications for user.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="questions">if set to <c>true</c> [questions].</param>
        /// <param name="publications">if set to <c>true</c> [publications].</param>
        /// <returns>List of publications for a user</returns>
        public List<XareuServices.Model.Publication.Publication> GetPublicationsForUser(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page, bool questions, bool publications)
        {
            return publicationService.GetPublicationsForUser(userID, token, out newToken, userAuthorID, number, page, questions, publications);
        }

        /// <summary>
        /// Gets the publications for group.
        /// </summary>
        /// <param name="groupID">The group ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications for a group</returns>
        public List<Model.Publication.Publication> GetPublicationsForGroup(long groupID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            return publicationService.GetPublicationsForGroup(groupID, token, out newToken, userAuthorID, number, page);
        }

        #endregion
    }
}
