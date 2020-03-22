using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Services.Tag
{
    public class Tag : API.ITagService
    {
        Services.Login.Login loginService = new XareuServices.Services.Login.Login();
        DAL.Linq.TagDAO.TagDAO tagDAO = new XareuServices.DAL.Linq.TagDAO.TagDAO();
        DAL.Linq.TagDAO.TagInPublicationDAO tagInPublicationDAO = new XareuServices.DAL.Linq.TagDAO.TagInPublicationDAO();
        DAL.Linq.TagDAO.TagsUsersSubscriptionsDAO tagsUsersSubscriptionsDAO = new XareuServices.DAL.Linq.TagDAO.TagsUsersSubscriptionsDAO();
        DAL.Linq.UserDAO.UserDAO userDAO = new XareuServices.DAL.Linq.UserDAO.UserDAO();
        DAL.Linq.PublicationDAO.PublicationDAO publicationDAO = new XareuServices.DAL.Linq.PublicationDAO.PublicationDAO();

        #region ITagService Members

        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>Tag</returns>
        public XareuServices.Model.Tag.Tag GetTag(long tagID)
        {
            try
            {
                return tagDAO.GetTag(tagID);
            }
            catch
            {
                throw new Exception("Getting Tag error");
            }
        }

        /// <summary>
        /// Gets the name of the tag by.
        /// </summary>
        /// <param name="tagName">Name of the tag.</param>
        /// <returns>Tag by name</returns>
        public XareuServices.Model.Tag.Tag GetTagByName(string tagName)
        {
            try
            {
                return tagDAO.GetTagByName(tagName);
            }
            catch
            {
                throw new Exception("Getting Tag error");
            }
        }


        /// <summary>
        /// Gets all tags.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of all tags</returns>
        public List<XareuServices.Model.Tag.Tag> GetAllTags(int number, int page)
        {
            try
            {
                return tagDAO.GetAllTags(number, page);
            }
            catch
            {
                throw new Exception("Getting All Tags error");
            }
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    return tagDAO.AddTag(tag, out tagID);
                }
                catch
                {
                    throw new Exception("Adding tag error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userDAO.IsAdmin(userID))
                    {
                        return tagDAO.DeleteTag(tagID);
                    }
                    throw new Exception("User can't delete a tag");
                }
                catch
                {
                    throw new Exception("Deleting tag error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userDAO.IsAdmin(userID))
                    {
                        return tagDAO.EditTag(tag);
                    }
                    throw new Exception("User can't edit a tag");
                }
                catch
                {
                    throw new Exception("Editting tag error");
                }
            }
            throw new Exception("Login error");
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
            try
            {
                return tagInPublicationDAO.GetTagsForPublication(publicationID, number, page);
            }
            catch
            {
                throw new Exception("Getting tags for publication error");
            }
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
            try
            {
                return tagInPublicationDAO.GetPublicationsWithTag(tagID, number, page);
            }
            catch
            {
                throw new Exception("Getting publications with tag error");
            }
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (publicationDAO.GetPublication(publicationID).Author.Id == userID || userDAO.IsAdmin(userID))
                    {
                        return tagInPublicationDAO.AddTagToPublication(tagID, publicationID);
                    }
                    throw new Exception("User can't add that tag");
                }
                catch
                {
                    throw new Exception("Adding tag to publication error");
                }
            }
            else
            {
                throw new Exception("Login error");
            }
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (publicationDAO.GetPublication(publicationID).Author.Id == userID || userDAO.IsAdmin(userID))
                    {
                        return tagInPublicationDAO.DeleteTagFromPublication(tagID, publicationID);
                    }
                    throw new Exception("User can't delete that tag");
                }
                catch
                {
                    throw new Exception("Deleting tag from publication error");
                }
            }
            else
            {
                throw new Exception("Login error");
            }
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return tagsUsersSubscriptionsDAO.GetAllUserSubscriptions(userAuthorID, number, page);
                    }
                    throw new Exception("User can't get that info");
                }
                catch
                {
                    throw new Exception("Getting all user subscriptions error");
                }
            }
            throw new Exception("Login error");
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
            try
            {
                return tagsUsersSubscriptionsDAO.GetAllUsersSubscribedToTag(tagID, number, page);
            }
            catch
            {
                throw new Exception("Getting all users subscribed to a tag error");
            }
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return tagsUsersSubscriptionsDAO.AddUserSubscription(userAuthorID, tagID);
                    }
                    throw new Exception("User can't add subscription");
                }
                catch
                {
                    throw new Exception("Adding user subscription error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return tagsUsersSubscriptionsDAO.DeleteUserSubscription(userAuthorID, tagID);
                    }
                    throw new Exception("User can't delete subscription");
                }
                catch
                {
                    throw new Exception("Deleting user subscriptions error");
                }
            }
            throw new Exception("Login error");
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
            try
            {
                return tagDAO.SearchTagByText(text, number, page);
            }
            catch
            {
                throw new Exception("Searching Tags error");
            }
        }

        #endregion
    }
}
