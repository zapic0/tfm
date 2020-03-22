using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    /// <summary>
    /// Services that operate over Place options
    /// </summary>
    [ServiceContract]
    public interface IPlaceService
    {
        /// <summary>
        /// Gets the tag place.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <returns>Tag Place</returns>
        [OperationContract]
        Model.TagPlace.TagPlace GetTagPlace(long tagPlaceID);

        /// <summary>
        /// Adds the tag place.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="tagPlace">The tag place.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddTagPlace(long userID, Guid token, out Guid newToken, Model.TagPlace.TagPlace tagPlace);

        /// <summary>
        /// Gets the sons.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <returns>List of sons place tags</returns>
        [OperationContract]
        List<Model.TagPlace.TagPlace> GetSons(long tagPlaceID);




        /// <summary>
        /// Gets the place tags in publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of place tags in publication</returns>
        [OperationContract]
        List<Model.TagPlace.TagPlace> GetPlaceTagsInPublication(long publicationID, int number, int page);

        /// <summary>
        /// Gets the publications for place tag.
        /// </summary>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of Publications for a place tag</returns>
        [OperationContract]
        List<Model.Publication.Publication> GetPublicationForPlaceTag(long placeTagID, int number, int page);

        /// <summary>
        /// Adds the place tag in publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddPlaceTagInPublication(long userID, Guid token, out Guid newToken, long publicationID, long placeTagID);

        /// <summary>
        /// Deletes the place tag in publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeletePlaceTagInPublication(long userID, Guid token, out Guid newToken, long publicationID, long placeTagID);




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
        [OperationContract]
        List<Model.TagPlace.TagPlace> GetUserPlaceTagSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

        /// <summary>
        /// Gets the users subscribed to place tag.
        /// </summary>
        /// <param name="placeTag">The place tag.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users subscribed to a place tag</returns>
        [OperationContract]
        List<Model.User.User> GetUsersSubscribedToPlaceTag(long placeTag, int number, int page);

        /// <summary>
        /// Adds the user subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddUserSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, long placeTagID);

        /// <summary>
        /// Deletes the user subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="placeTagID">The place tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteUserSubscription(long userID, Guid token, out Guid newToken, long userAuthorID, long placeTagID);
    }
}
