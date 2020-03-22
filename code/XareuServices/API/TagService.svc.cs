using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    // NOTE: If you change the class name "TagService" here, you must also update the reference to "TagService" in Web.config.
    /// <summary>
    /// Services that operate over Tags options
    /// </summary>
    public class TagService : ITagService
    {
        Services.Tag.Tag tagService = new XareuServices.Services.Tag.Tag();

        #region ITagService Members

        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>Tag</returns>
        public XareuServices.Model.Tag.Tag GetTag(long tagID)
        {
            return tagService.GetTag(tagID);
        }

        /// <summary>
        /// Gets the name of the tag by.
        /// </summary>
        /// <param name="tagName">Name of the tag.</param>
        /// <returns>Tag by name</returns>
        public XareuServices.Model.Tag.Tag GetTagByName(string tagName)
        {
            return tagService.GetTagByName(tagName);
        }

        /// <summary>
        /// Gets all tags.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of all tags</returns>
        public List<XareuServices.Model.Tag.Tag> GetAllTags(int number, int page)
        {
            return tagService.GetAllTags(number, page);
        }

        /// <summary>
        /// Adds the tag.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tag">The tag.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddTag(long userID, Guid token, out Guid newToken, XareuServices.Model.Tag.Tag tag, out long tagID)
        {
            return tagService.AddTag(userID, token, out newToken, tag, out tagID);
        }

        /// <summary>
        /// Deletes the tag.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteTag(long userID, Guid token, out Guid newToken, long tagID)
        {
            return tagService.DeleteTag(userID, token, out newToken, tagID);
        }

        /// <summary>
        /// Edits the tag.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tag">The tag.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool EditTag(long userID, Guid token, out Guid newToken, XareuServices.Model.Tag.Tag tag)
        {
            return tagService.EditTag(userID, token, out newToken, tag);
        }

        /// <summary>
        /// Gets the tags for publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags for a publication</returns>
        public List<XareuServices.Model.Tag.Tag> GetTagsForPublication(long publicationID, int number, int page)
        {
            return tagService.GetTagsForPublication(publicationID, number, page);
        }

        /// <summary>
        /// Gets the publications with tag.
        /// </summary>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications with tag</returns>
        public List<XareuServices.Model.Publication.Publication> GetPublicationsWithTag(long tagID, int number, int page)
        {
            return tagService.GetPublicationsWithTag(tagID, number, page);
        }

        /// <summary>
        /// Adds the tag to publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddTagToPublication(long userID, Guid token, out Guid newToken, long tagID, long publicationID)
        {
            return tagService.AddTagToPublication(userID, token, out newToken, tagID, publicationID);
        }

        /// <summary>
        /// Deletes the tag from publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteTagFromPublication(long userID, Guid token, out Guid newToken, long tagID, long publicationID)
        {
            return tagService.DeleteTagFromPublication(userID, token, out newToken, tagID, publicationID);
        }

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
        public List<XareuServices.Model.Tag.Tag> GetAllUserSubscriptions(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            return tagService.GetAllUserSubscriptions(userID, token, out newToken, userAuthorID, number, page);
        }

        /// <summary>
        /// Gets all users subscribed to tag.
        /// </summary>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users subscribed to a tag</returns>
        public List<XareuServices.Model.User.User> GetAllUsersSubscribedToTag(long tagID, int number, int page)
        {
            return tagService.GetAllUsersSubscribedToTag(tagID, number, page);
        }

        /// <summary>
        /// Adds the user subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, long tagID)
        {
            return tagService.AddUserSubscription(userID, token, out newToken, userAuthorID, tagID);
        }

        /// <summary>
        /// Deletes the user subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, long tagID)
        {
            return tagService.DeleteUserSubscription(userID, token, out newToken, userAuthorID, tagID);
        }

        /// <summary>
        /// Searches the tags by text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags with text</returns>
        public List<XareuServices.Model.Tag.Tag> SearchTagsByText(string text, int number, int page)
        {
            return tagService.SearchTagsByText(text, number, page);
        }

        #endregion
    }
}
