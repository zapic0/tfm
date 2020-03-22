using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Services.TagPlace
{
    public class TagPlace : API.IPlaceService
    {
        Services.Login.Login loginService = new XareuServices.Services.Login.Login();

        DAL.Linq.UserDAO.UserDAO userDAO = new XareuServices.DAL.Linq.UserDAO.UserDAO();
        DAL.Linq.PublicationDAO.PublicationDAO publicationDAO = new XareuServices.DAL.Linq.PublicationDAO.PublicationDAO();
        DAL.Linq.PlaceTagDAO.PlaceTagDAO placeTagDAO = new XareuServices.DAL.Linq.PlaceTagDAO.PlaceTagDAO();
        DAL.Linq.PlaceTagDAO.PlaceTagInPublicationDAO placeTagInPublicationDAO = new XareuServices.DAL.Linq.PlaceTagDAO.PlaceTagInPublicationDAO();
        DAL.Linq.PlaceTagDAO.PlaceTagUsersSubscriptionsDAO placeTagUsersSubscriptionsDAO = new XareuServices.DAL.Linq.PlaceTagDAO.PlaceTagUsersSubscriptionsDAO();

        #region IPlaceService Members

        /// <summary>
        /// Gets the tag place.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <returns>Tag Place</returns>
        public XareuServices.Model.TagPlace.TagPlace GetTagPlace(long tagPlaceID)
        {
            try
            {
                return placeTagDAO.GetTagPlace(tagPlaceID);
            }
            catch
            {
                throw new Exception("Getting Tag Place error");
            }
        }

        /// <summary>
        /// Adds the tag place.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tagPlace">The tag place.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddTagPlace(long userID, Guid token, out Guid newToken, XareuServices.Model.TagPlace.TagPlace tagPlace)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    long tagPlaceID;
                    return placeTagDAO.AddTagPlace(tagPlace, out tagPlaceID);
                }
                catch
                {
                    throw new Exception("Adding tag place error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the sons.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <returns>List of sons place tags</returns>
        public List<XareuServices.Model.TagPlace.TagPlace> GetSons(long tagPlaceID)
        {
            try
            {
                return placeTagDAO.GetSons(tagPlaceID);
            }
            catch
            {
                throw new Exception("Getting sons error");
            }
        }

        /// <summary>
        /// Gets the place tags in publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of place tags in publication</returns>
        public List<XareuServices.Model.TagPlace.TagPlace> GetPlaceTagsInPublication(long publicationID, int number, int page)
        {
            try
            {
                return placeTagInPublicationDAO.GetPlaceTagsInPublication(publicationID, number, page);
            }
            catch
            {
                throw new Exception("Getting place tags in publication error");
            }
        }

        /// <summary>
        /// Gets the publications for place tag.
        /// </summary>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of Publications for a place tag</returns>
        public List<XareuServices.Model.Publication.Publication> GetPublicationForPlaceTag(long placeTagID, int number, int page)
        {
            try
            {
                return placeTagInPublicationDAO.GetPublicationForPlaceTag(placeTagID, number, page);
            }
            catch
            {
                throw new Exception("Getting publications for place tag error");
            }
        }

        /// <summary>
        /// Adds the place tag in publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddPlaceTagInPublication(long userID, Guid token, out Guid newToken, long publicationID, long placeTagID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    Model.Publication.Publication publication = publicationDAO.GetPublication(publicationID);
                    if ((publication.Author.Id == userID) || (userDAO.IsAdmin(userID)))
                    {
                        return placeTagInPublicationDAO.AddPlaceTagInPublication(publicationID, placeTagID);
                    }
                    else
                    {
                        throw new Exception("User is not able to add that tag");
                    }
                }
                catch
                {
                    throw new Exception("Adding tag place error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Deletes the place tag in publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeletePlaceTagInPublication(long userID, Guid token, out Guid newToken, long publicationID, long placeTagID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    Model.Publication.Publication publication = publicationDAO.GetPublication(publicationID);
                    if ((publication.Author.Id == userID) || (userDAO.IsAdmin(userID)))
                    {
                        return placeTagInPublicationDAO.DeletePlaceTagInPublication(publicationID, placeTagID);
                    }
                    else
                    {
                        throw new Exception("User is not able to add that tag");
                    }
                }
                catch
                {
                    throw new Exception("Deleting tag place in publication error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the user place tag subscriptions.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of user place tag subscriptions</returns>
        public List<XareuServices.Model.TagPlace.TagPlace> GetUserPlaceTagSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if ((userID==userAuthorID) || (userDAO.IsAdmin(userID)))
                    {
                        return placeTagUsersSubscriptionsDAO.GetUserPlaceTagSubscription(userAuthorID, number, page);
                    }
                    else
                    {
                        throw new Exception("User is not able to get that data");
                    }
                }
                catch
                {
                    throw new Exception("Getting user place tag subscription error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the users subscribed to place tag.
        /// </summary>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<XareuServices.Model.User.User> GetUsersSubscribedToPlaceTag(long placeTagID, int number, int page)
        {
            try
            {
                return placeTagUsersSubscriptionsDAO.GetUsersSubscribedToPlaceTag(placeTagID, number, page);
            }
            catch
            {
                throw new Exception("Getting users subscribed to place tag error");
            }
        }

        /// <summary>
        /// Adds the user subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, long placeTagID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if ((userID == userAuthorID) || (userDAO.IsAdmin(userID)))
                    {
                        return placeTagUsersSubscriptionsDAO.AddUserSubscription(userAuthorID, placeTagID);
                    }
                    else
                    {
                        throw new Exception("User is not able to add that subscription");
                    }
                }
                catch
                {
                    throw new Exception("Adding subscription error");
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
        /// <param name="placeTagID">The place tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, long placeTagID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if ((userID == userAuthorID) || (userDAO.IsAdmin(userID)))
                    {
                        return placeTagUsersSubscriptionsDAO.DeleteUserSubscription(userAuthorID, placeTagID);
                    }
                    else
                    {
                        throw new Exception("User is not able to delete that subscription");
                    }
                }
                catch
                {
                    throw new Exception("Deleting subscription error");
                }
            }
            throw new Exception("Login error");
        }

        #endregion
    }
}
