using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    /// <summary>
    /// Services that operate over Tags options
    /// </summary>
    [ServiceContract]
    public interface ITagService
    {
        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>Tag</returns>
        [OperationContract]
        Model.Tag.Tag GetTag(long tagID);

        /// <summary>
        /// Gets the name of the tag by.
        /// </summary>
        /// <param name="tagName">Name of the tag.</param>
        /// <returns>Tag by name</returns>
        [OperationContract]
        Model.Tag.Tag GetTagByName(string tagName);

        /// <summary>
        /// Gets all tags.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of all tags</returns>
        [OperationContract]
        List<Model.Tag.Tag> GetAllTags(int number, int page);

        /// <summary>
        /// Adds the tag.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tag">The tag.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddTag(long userID, Guid token, out Guid newToken, Model.Tag.Tag tag, out long tagID);

        /// <summary>
        /// Deletes the tag.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteTag(long userID, Guid token, out Guid newToken, long tagID);

        /// <summary>
        /// Edits the tag.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tag">The tag.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool EditTag(long userID, Guid token, out Guid newToken, Model.Tag.Tag tag);





        /// <summary>
        /// Gets the tags for publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags for a publication</returns>
        [OperationContract]
        List<Model.Tag.Tag> GetTagsForPublication(long publicationID, int number, int page);

        /// <summary>
        /// Gets the publications with tag.
        /// </summary>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications with tag</returns>
        [OperationContract]
        List<Model.Publication.Publication> GetPublicationsWithTag(long tagID, int number, int page);

        /// <summary>
        /// Adds the tag to publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddTagToPublication(long userID, Guid token, out Guid newToken, long tagID, long publicationID);

        /// <summary>
        /// Deletes the tag from publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteTagFromPublication(long userID, Guid token, out Guid newToken, long tagID, long publicationID);







        /// <summary>
        /// Gets all user subscriptions.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags user subscriptions</returns>
        [OperationContract]
        List<Model.Tag.Tag> GetAllUserSubscriptions(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

        /// <summary>
        /// Gets all users subscribed to tag.
        /// </summary>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users subscribed to a tag</returns>
        [OperationContract]
        List<Model.User.User> GetAllUsersSubscribedToTag(long tagID, int number, int page);

        /// <summary>
        /// Adds the user subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddUserSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, long tagID);

        /// <summary>
        /// Deletes the user subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteUserSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, long tagID);



        /// <summary>
        /// Searches the tags by text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags with text</returns>
        [OperationContract]
        List<Model.Tag.Tag> SearchTagsByText(string text, int number, int page);
    }
}
