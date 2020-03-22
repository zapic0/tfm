using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    // NOTE: If you change the class name "GroupService" here, you must also update the reference to "GroupService" in Web.config.
    public class GroupService : IGroupService
    {
        Services.Group.Group groupService = new XareuServices.Services.Group.Group();

        #region IGroupService Members

        /// <summary>
        /// Gets the group by id.
        /// </summary>
        /// <param name="groupID">The group ID.</param>
        /// <returns>Group</returns>
        public XareuServices.Model.Group.Group GetGroupById(long groupID)
        {
            return groupService.GetGroupById(groupID);
        }

        /// <summary>
        /// Gets the group by name.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        /// <returns>Group</returns>
        public XareuServices.Model.Group.Group GetGroupByName(string groupName)
        {
            return groupService.GetGroupByName(groupName);
        }

        /// <summary>
        /// Gets all groups.
        /// </summary>
        /// <param name="number">Number of groups to take.</param>
        /// <param name="page">The page (number of pages to skip).</param>
        /// <returns>All groups</returns>
        public List<XareuServices.Model.Group.Group> GetAllGroups(int number, int page)
        {
            return groupService.GetAllGroups(number, page);
        }

        /// <summary>
        /// Creates the group.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="name">The name.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool CreateGroup(long userID, Guid token, out Guid newToken, string name, long userAuthorID)
        {
            return groupService.CreateGroup(userID, token, out newToken, name, userAuthorID);
        }

        /// <summary>
        /// Deletes the group.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteGroup(long userID, Guid token, out Guid newToken, long groupID)
        {
            return groupService.DeleteGroup(userID, token, out newToken, groupID);
        }

        /// <summary>
        /// Sets the group privacy.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="isPrivate">if set to <c>true</c> [is private].</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool SetGroupPrivacy(long userID, Guid token, out Guid newToken, long groupID, bool isPrivate)
        {
            return groupService.SetGroupPrivacy(userID, token, out newToken, groupID, isPrivate);
        }

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
        public List<XareuServices.Model.Group.Group> GetUserOwnGroups(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            return groupService.GetUserOwnGroups(userID, token, out newToken, userAuthorID, number, page);
        }

        /// <summary>
        /// Gets the groups in a publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>List of groups in that publication</returns>
        public List<XareuServices.Model.Group.Group> GetGroupsInPublication(long publicationID)
        {
            return groupService.GetGroupsInPublication(publicationID);
        }

        /// <summary>
        /// Adds the group to publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="groupID">The group ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddGroupToPublication(long userID, Guid token, out Guid newToken, long publicationID, long groupID)
        {
            return groupService.AddGroupToPublication(userID, token, out newToken, publicationID, groupID);
        }

        /// <summary>
        /// Deletes the group from publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="groupID">The group ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteGroupFromPublication(long userID, Guid token, out Guid newToken, long publicationID, long groupID)
        {
            return groupService.DeleteGroupFromPublication(userID, token, out newToken, publicationID, groupID);
        }

        /// <summary>
        /// Gets the group join request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>Group Join Request</returns>
        public XareuServices.Model.Group.GroupJoinRequest GetGroupJoinRequest(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID)
        {
            return groupService.GetGroupJoinRequest(userID, token, out newToken, groupID, userAuthorID);
        }

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
        public List<XareuServices.Model.Group.GroupJoinRequest> GetGroupJoinRequests(long userID, Guid token, out Guid newToken, long groupID, int number, int page)
        {
            return groupService.GetGroupJoinRequests(userID, token, out newToken, groupID, number, page);
        }

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
        public List<XareuServices.Model.Group.GroupJoinRequest> GetUserJoinRequests(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            return groupService.GetUserJoinRequests(userID, token, out newToken, userAuthorID, number, page);
        }

        /// <summary>
        /// Adds the join request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddJoinRequest(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID)
        {
            return groupService.AddJoinRequest(userID, token, out newToken, groupID, userAuthorID);
        }

        /// <summary>
        /// Deletes the join request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteJoinRequest(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID)
        {
            return groupService.DeleteJoinRequest(userID, token, out newToken, groupID, userAuthorID);
        }

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
        public List<XareuServices.Model.Group.GroupUsers> GetSubscribedUsers(long userID, Guid token, out Guid newToken, long groupID, int number, int page)
        {
            return groupService.GetSubscribedUsers(userID, token, out newToken, groupID, number, page);
        }

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
        public List<XareuServices.Model.Group.GroupUsers> GetUserSubscriptions(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            return groupService.GetUserSubscriptions(userID, token, out newToken, userAuthorID, number, page);
        }

        /// <summary>
        /// Adds the subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddSubscription(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID)
        {
            return groupService.AddSubscription(userID, token, out newToken, groupID, userAuthorID);
        }

        /// <summary>
        /// Deletes the subscription.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteSubscription(long userID, Guid token, out Guid newToken, long groupID, long userAuthorID)
        {
            return groupService.DeleteSubscription(userID, token, out newToken, groupID, userAuthorID);
        }

        /// <summary>
        /// Searches the groups by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of groups with a similar name</returns>
        public List<Model.Group.Group> SearchGroupsByName(string name, int number, int page)
        {
            return groupService.SearchGroupsByName(name, number, page);
        }

        #endregion
    }
}
