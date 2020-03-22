using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    /// <summary>
    /// Services that operate over Publications options
    /// </summary>
    [ServiceContract]
    public interface IPublicationService
    {
        /// <summary>
        /// Gets all publications.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="questions">if set to <c>true</c> [questions].</param>
        /// <param name="publications">if set to <c>true</c> [publications].</param>
        /// <returns>List with publications</returns>
        [OperationContract]
        List<Model.Publication.Publication> GetAllPublications(int number, int page, bool questions, bool publications);

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
        [OperationContract]
        List<Model.Publication.Publication> SearchPublicationWithText(long userID, Guid token, out Guid newToken, int number, int page, string text);

        /// <summary>
        /// Gets the publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>Publication</returns>
        [OperationContract]
        Model.Publication.Publication GetPublication(long publicationID);

        /// <summary>
        /// Gets the publication answers.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publication's answers</returns>
        [OperationContract]
        List<Model.Publication.Publication> GetPublicationAnswers(long publicationID, int number, int page);

        /// <summary>
        /// Adds the publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="tokeFn">The toke fn.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publication">The publication.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddPublication(long userID, Guid tokeFn, out Guid newToken, Model.Publication.Publication publication, out long publicationID);

        /// <summary>
        /// Edits the publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publication">The publication.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool EditPublication(long userID, Guid token, out Guid newToken, Model.Publication.Publication publication);

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
        [OperationContract]
        List<Model.Publication.Publication> GetUserPublications(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page, bool questions, bool publications);

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
        [OperationContract]
        List<Model.Publication.Publication> GetPublicationsForUser(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page, bool questions, bool publications);

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
        [OperationContract]
        List<Model.Publication.Publication> GetPublicationsForGroup(long groupID, Guid token, out Guid newToken, long userAuthorID, int number, int page);
    }
}
