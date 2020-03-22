using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Services.Group
{
    public class Group : API.IGroupService
    {
        Login.Login loginService = new XareuServices.Services.Login.Login();
        DAL.Linq.GroupDAO.GroupDAO groupDAO = new XareuServices.DAL.Linq.GroupDAO.GroupDAO();
        DAL.Linq.GroupDAO.GroupInPublicationDAO groupInPublicationDAO = new XareuServices.DAL.Linq.GroupDAO.GroupInPublicationDAO();
        DAL.Linq.GroupDAO.GroupJoinRequestDAO groupJoinRequestDAO = new XareuServices.DAL.Linq.GroupDAO.GroupJoinRequestDAO();
        DAL.Linq.GroupDAO.GroupUserSubscriptionDAO groupUserSubscriptionDAO = new XareuServices.DAL.Linq.GroupDAO.GroupUserSubscriptionDAO();
        DAL.Linq.UserDAO.UserDAO userDAO = new XareuServices.DAL.Linq.UserDAO.UserDAO();
        DAL.Linq.PublicationDAO.PublicationDAO publicationDAO = new XareuServices.DAL.Linq.PublicationDAO.PublicationDAO();

        #region IGroupService Members

        /// <summary>
        /// Gets the group by id.
        /// </summary>
        /// <param name="groupID">The group ID.</param>
        /// <returns>Group</returns>
        public XareuServices.Model.Group.Group GetGroupById(long groupID)
        {
            return groupDAO.GetGroupById(groupID);
        }

        /// <summary>
        /// Gets the group by name.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        /// <returns>Group</returns>
        public XareuServices.Model.Group.Group GetGroupByName(string groupName)
        {
            return groupDAO.GetGroupByName(groupName);
        }

        /// <summary>
        /// Gets all groups.
        /// </summary>
        /// <param name="number">Number of groups to take.</param>
        /// <param name="page">The page (number of pages to skip).</param>
        /// <returns>All groups</returns>
        public List<XareuServices.Model.Group.Group> GetAllGroups(int number, int page)
        {
            return groupDAO.GetGroups(number, page);
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID)
                    {
                        return groupDAO.CreateGroup(name, userAuthorID);
                    }
                    throw new Exception("User is not able to create that group");
                }
                catch
                {
                    throw new Exception("Creating group error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (groupDAO.GetGroupById(groupID).Owner.Id == userID || userDAO.IsAdmin(userID))
                    {
                        groupDAO.DeleteGroup(groupID);
                        return true;
                    }
                    throw new Exception("User is not able to delete that group");
                }
                catch
                {
                    throw new Exception("Deleting group error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (groupDAO.GetGroupById(groupID).Owner.Id == userID || userDAO.IsAdmin(userID))
                    {
                        groupDAO.SetGroupPrivacy(groupID, isPrivate);
                        return true;
                    }
                    throw new Exception("User is not able to set that group privacy");
                }
                catch
                {
                    throw new Exception("Setting up privacy group error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return groupDAO.GetUserOwnGroups(userAuthorID, number, page);
                    }
                    throw new Exception("User is not able to set that group privacy");
                }
                catch
                {
                    throw new Exception("Setting up privacy group error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the groups in a publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>List of groups in that publication</returns>
        public List<XareuServices.Model.Group.Group> GetGroupsInPublication(long publicationID)
        {
            try
            {
                return groupInPublicationDAO.GetGroupsInPublication(publicationID);
            }
            catch
            {
                throw new Exception("Get groups in publication error");
            }
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if ((publicationDAO.GetPublication(publicationID).Author.Id == userID) || (userDAO.IsAdmin(userID)))
                    {
                        return groupInPublicationDAO.AddGroupToPublication(publicationID, groupID);
                    }
                    throw new Exception("User is not able to add a group to that publication");
                }
                catch
                {
                    throw new Exception("Add group to publication error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if ((publicationDAO.GetPublication(publicationID).Author.Id == userID) || (userDAO.IsAdmin(userID)))
                    {
                        groupInPublicationDAO.DeleteGroupFromPublication(publicationID, groupID);
                        return true;
                    }
                    throw new Exception("User is not able to delete a group from that publication");
                }
                catch
                {
                    throw new Exception("Deleting group from publication error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if ((userAuthorID == userID) ||(groupDAO.GetGroupById(groupID).Owner.Id == userID) || (userDAO.IsAdmin(userID)))
                    {
                        return groupJoinRequestDAO.GetGroupJoinRequest(groupID, userAuthorID);
                    }
                    throw new Exception("User is not able to get that group join request");
                }
                catch
                {
                    throw new Exception("Get group join request error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if ((groupDAO.GetGroupById(groupID).Owner.Id == userID) || (userDAO.IsAdmin(userID)))
                    {
                        return groupJoinRequestDAO.GetGroupJoinRequests(groupID, number, page);
                    }
                    throw new Exception("User is not able to get that group join requests");
                }
                catch
                {
                    throw new Exception("Get group join requests error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return groupJoinRequestDAO.GetUserJoinRequests(userAuthorID, number, page);
                    }
                    throw new Exception("User is not able to get that user join requests");
                }
                catch
                {
                    throw new Exception("Get user join requests error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID)
                    {
                        return groupJoinRequestDAO.AddJoinRequest(groupID, userAuthorID);
                    }
                    throw new Exception("User is not able to add that join request");
                }
                catch
                {
                    throw new Exception("Add group join request error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || groupDAO.GetGroupById(groupID).Owner.Id==userID)
                    {
                        return groupJoinRequestDAO.DeleteJoinRequest(groupID, userAuthorID);
                    }
                    throw new Exception("User is not able to delete that join request");
                }
                catch
                {
                    throw new Exception("Delete group join request error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (groupDAO.GetGroupById(groupID).Owner.Id == userID || userDAO.IsAdmin(userID))
                    {
                        return groupUserSubscriptionDAO.GetSubscribedUsers(groupID, number, page);
                    }
                    throw new Exception("User is not able to get that group users");
                }
                catch
                {
                    throw new Exception("Get subscribed users error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return groupUserSubscriptionDAO.GetUserSubscriptions(userID, number, page);
                    }
                    throw new Exception("User is not able to get that user subscriptions");
                }
                catch
                {
                    throw new Exception("Get user subscriptions error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    return groupUserSubscriptionDAO.AddSubscription(groupID, userAuthorID);
                }
                catch
                {
                    throw new Exception("Add subscription error");
                }
            }
            throw new Exception("Login error");
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
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || groupDAO.GetGroupById(groupID).Owner.Id == userID || userDAO.IsAdmin(userID))
                    {
                        return groupUserSubscriptionDAO.DeleteSubscription(groupID, userID);
                    }
                    throw new Exception("User isn't able to delete that subscription");
                }
                catch
                {
                    throw new Exception("Delete subscription error");
                }
            }
            throw new Exception("Login error");
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
            try
            {
                return groupDAO.SearchGroupByName(name, number, page);
            }
            catch
            {
                throw new Exception("Search groups by name error");
            }
        }

        #endregion
    }
}
