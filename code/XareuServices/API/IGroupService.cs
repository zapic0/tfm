using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    /// <summary>
    /// Services that operate over Groups options
    /// </summary>
    [ServiceContract]
    public interface IGroupService
    {
        /// <summary>
        /// Gets the group by id.
        /// </summary>
        /// <param name="groupID">The group ID.</param>
        /// <returns>Group</returns>
        [OperationContract]
        XareuServices.Model.Group.Group GetGroupById(long groupID);

        /// <summary>
        /// Gets the group by name.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        /// <returns>Group</returns>
        [OperationContract]
        XareuServices.Model.Group.Group GetGroupByName(string groupName);

        /// <summary>
        /// Gets all groups.
        /// </summary>
        /// <param name="number">Number of groups to take.</param>
        /// <param name="page">The page (number of pages to skip).</param>
        /// <returns>All groups</returns>
        [OperationContract]
        List<XareuServices.Model.Group.Group> GetAllGroups(int number, int page);


        /// <summary>
        /// Gets the user own groups.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of user groups</returns>
        [OperationContract]
        List<XareuServices.Model.Group.Group> GetUserOwnGroups(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

        /// <summary>
        /// Creates the group.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="name">The name.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool CreateGroup(long userID, Guid token, out Guid newToken, string name, long userAuthorID);

        /// <summary>
        /// Deletes the group.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteGroup(long userID, Guid token, out Guid newToken, long groupID);

        /// <summary>
        /// Sets the group privacy.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="isPrivate">if set to <c>true</c> [is private].</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool SetGroupPrivacy(long userID, Guid token, out Guid newToken, long groupID, bool isPrivate);



        /// <summary>
        /// Gets the groups in a publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>List of groups in that publication</returns>
        [OperationContract]
        List<XareuServices.Model.Group.Group> GetGroupsInPublication(long publicationID);

        /// <summary>
        /// Adds the group to publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="groupID">The group ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddGroupToPublication(long userID, Guid token, out Guid newToken, long publicationID, long groupID);

        /// <summary>
        /// Deletes the group from publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="groupID">The group ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteGroupFromPublication(long userID, Guid token, out Guid newToken, long publicationID, long groupID);



        /// <summary>
        /// Gets the group join request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>Group Join Request</returns>
        [OperationContract]
        XareuServices.Model.Group.GroupJoinRequest GetGroupJoinRequest(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID);

        /// <summary>
        /// Gets the group join requests.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of group join requests</returns>
        [OperationContract]
        List<XareuServices.Model.Group.GroupJoinRequest> GetGroupJoinRequests(long userID, Guid token, out Guid newToken, long groupID, int number, int page);

        /// <summary>
        /// Gets the user join requests.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of User Join Requests</returns>
        [OperationContract]
        List<XareuServices.Model.Group.GroupJoinRequest> GetUserJoinRequests(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

        /// <summary>
        /// Adds the join request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddJoinRequest(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID);

        /// <summary>
        /// Deletes the join request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteJoinRequest(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID);



        /// <summary>
        /// Gets the subscribed users.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of subscribed users</returns>
        [OperationContract]
        List<XareuServices.Model.Group.GroupUsers> GetSubscribedUsers(long userID, Guid token, out Guid newToken, long groupID, int number, int page);

        /// <summary>
        /// Gets the user subscriptions.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of user subscriptions</returns>
        [OperationContract]
        List<XareuServices.Model.Group.GroupUsers> GetUserSubscriptions(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

        /// <summary>
        /// Adds the subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddSubscription(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID);

        /// <summary>
        /// Deletes the subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteSubscription(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID);


        /// <summary>
        /// Searches the groups by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of groups with a similar name</returns>
        [OperationContract]
        List<Model.Group.Group> SearchGroupsByName(string name, int number, int page);
    }
}
