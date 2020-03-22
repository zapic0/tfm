using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    /// <summary>
    /// Services that operate over Places options
    /// </summary>
    public class PlaceService : IPlaceService
    {

        Services.TagPlace.TagPlace tagPlaceService = new XareuServices.Services.TagPlace.TagPlace();

        #region IPlaceService Members

        /// <summary>
        /// Gets the tag place.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <returns>Tag Place</returns>
        public XareuServices.Model.TagPlace.TagPlace GetTagPlace(long tagPlaceID)
        {
            return tagPlaceService.GetTagPlace(tagPlaceID);
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
            return tagPlaceService.AddTagPlace(userID, token, out newToken, tagPlace);
        }

        /// <summary>
        /// Gets the sons.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <returns>List of sons place tags</returns>
        public List<XareuServices.Model.TagPlace.TagPlace> GetSons(long tagPlaceID)
        {
            return tagPlaceService.GetSons(tagPlaceID);
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
            return tagPlaceService.GetPlaceTagsInPublication(publicationID, number, page);
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
            return tagPlaceService.GetPublicationForPlaceTag(placeTagID, number, page);
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
            return tagPlaceService.DeletePlaceTagInPublication(userID, token, out newToken, publicationID, placeTagID);
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
            return tagPlaceService.DeletePlaceTagInPublication(userID, token, out newToken, publicationID, placeTagID);
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
            return tagPlaceService.GetUserPlaceTagSubscription(userID, token, out newToken, userAuthorID, number, page);
        }

        /// <summary>
        /// Gets the users subscribed to place tag.
        /// </summary>
        /// <param name="placeTag">The place tag.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users subscribed to a place tag</returns>
        public List<XareuServices.Model.User.User> GetUsersSubscribedToPlaceTag(long placeTag, int number, int page)
        {
            return tagPlaceService.GetUsersSubscribedToPlaceTag(placeTag, number, page);
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
            return tagPlaceService.AddUserSubscription(userID, token, out newToken, userAuthorID, placeTagID);
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
            return tagPlaceService.DeleteUserSubscription(userID, token, out newToken, userAuthorID, placeTagID);
        }

        #endregion
    }
}
