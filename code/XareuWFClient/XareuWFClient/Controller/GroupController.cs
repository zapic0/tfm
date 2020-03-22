using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Controller
{
    class GroupController
    {
        GroupServices.GroupServiceClient groupService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupController"/> class.
        /// </summary>
        public GroupController()
        {
            groupService = new GroupServices.GroupServiceClient();
        }

        /// <summary>
        /// Creates the new group.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="name">The name.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns></returns>
        public bool CreateNewGroup(out Guid newToken, long userID, Guid token, string name, long userAuthorID)
        {
            try
            {
                return groupService.CreateGroup(out newToken, userID, token, name, userAuthorID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating new group " + ex.Message);
            }
        }

        /// <summary>
        /// Adds the join request.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <returns></returns>
        public bool AddJoinRequest(out Guid newToken, long userID, Guid token, long groupID, long userAuthorID)
        {
            try
            {
                return groupService.AddJoinRequest(out newToken, userID, token, groupID, userAuthorID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating new group " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the group by ID.
        /// </summary>
        /// <param name="groupID">The group ID.</param>
        /// <returns></returns>
        public Model.Group.Group GetGroupByID(long groupID)
        {
            try
            {
                return this.convertToModelGroup(groupService.GetGroupById(groupID));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting group " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the name of the group by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Model.Group.Group GetGroupByName(string name)
        {
            try
            {
                return this.convertToModelGroup(groupService.GetGroupByName(name));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting group " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the group join requests.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.Group.GroupJoinRequest> GetGroupJoinRequests(out Guid newToken, long userID, Guid token, long groupID, int number, int page)
        {
            try
            {
                return this.convertToModelGroupJoinRequests(groupService.GetGroupJoinRequests(out newToken, userID, token, groupID, number, page));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting group join requests " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the user own groups.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.Group.Group> GetUserOwnGroups(out Guid newToken, long userID, Guid token, long userAuthorID, int number, int page)
        {
            try
            {
                return this.convertToModelGroupList(groupService.GetUserOwnGroups(out newToken, userID, token, userAuthorID, number, page));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting groups " + ex.Message);
            }
        }

        /// <summary>
        /// Searches the name of the groups by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.Group.Group> SearchGroupsByName(string name, int number, int page)
        {
            try
            {
                return this.convertToModelGroupList(groupService.SearchGroupsByName(name, number, page));
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching groups " + ex.Message);
            }
        }

        #region Converters 

        /// <summary>
        /// Converts to model group list.
        /// </summary>
        /// <param name="serviceGroupList">The service group list.</param>
        /// <returns></returns>
        private List<Model.Group.Group> convertToModelGroupList(GroupServices.Group[] serviceGroupList)
        {
            List<Model.Group.Group> modelGroupList = new List<Model.Group.Group>();

            foreach (GroupServices.Group group in serviceGroupList)
            {
                modelGroupList.Add(this.convertToModelGroup(group));
            }

            return modelGroupList;
        }

        /// <summary>
        /// Converts to model group.
        /// </summary>
        /// <param name="serviceGroup">The service group.</param>
        /// <returns></returns>
        private Model.Group.Group convertToModelGroup(GroupServices.Group serviceGroup)
        {
            Model.Group.Group modelGroup = new Model.Group.Group();

            modelGroup.Creation = serviceGroup.Creation;
            modelGroup.Id = serviceGroup.Id;
            modelGroup.IsPrivate = serviceGroup.IsPrivate;
            modelGroup.Name = serviceGroup.Name;
            modelGroup.Owner = this.convertToModelUser(serviceGroup.Owner);

            return modelGroup;
        }

        /// <summary>
        /// Converts to model user.
        /// </summary>
        /// <param name="serviceUser">The service user.</param>
        /// <returns></returns>
        private Model.User.User convertToModelUser(GroupServices.User serviceUser)
        {
            Model.User.User modelUser = new Model.User.User();

            modelUser.DefaultPlace = convertToModelTagPlace(serviceUser.DefaultPlace);
            modelUser.Email = serviceUser.Email;
            modelUser.Id = serviceUser.Id;
            modelUser.IsAdmin = serviceUser.IsAdmin;
            modelUser.IsPrivate = serviceUser.IsPrivate;
            modelUser.Karma = serviceUser.Karma;
            modelUser.Nick = serviceUser.Nick;
            modelUser.Password = serviceUser.Password;
            modelUser.SignUp = serviceUser.SignUp;
            modelUser.UserPictureURL = serviceUser.UserPictureURL;

            return modelUser;
        }

        /// <summary>
        /// Converts to model tag place.
        /// </summary>
        /// <param name="serviceTagPlace">The service tag place.</param>
        /// <returns></returns>
        private Model.TagPlace.TagPlace convertToModelTagPlace(GroupServices.TagPlace serviceTagPlace)
        {
            Model.TagPlace.TagPlace modelTagPlace = new Model.TagPlace.TagPlace(serviceTagPlace.Id);

            modelTagPlace.Name = serviceTagPlace.Name;
            modelTagPlace.ParentId = serviceTagPlace.ParentId;

            return modelTagPlace;
        }

        /// <summary>
        /// Converts to model group join request.
        /// </summary>
        /// <param name="serviceGroupJoinRequest">The service group join request.</param>
        /// <returns></returns>
        private Model.Group.GroupJoinRequest convertToModelGroupJoinRequest(GroupServices.GroupJoinRequest serviceGroupJoinRequest)
        {
            Model.Group.GroupJoinRequest modelGroupJoinRequest = new Model.Group.GroupJoinRequest();

            modelGroupJoinRequest.Group = this.convertToModelGroup(serviceGroupJoinRequest.Group);
            modelGroupJoinRequest.User = this.convertToModelUser(serviceGroupJoinRequest.User);

            return modelGroupJoinRequest;
        }

        /// <summary>
        /// Converts to model group join requests.
        /// </summary>
        /// <param name="serviceGroupJoinRequests">The service group join requests.</param>
        /// <returns></returns>
        private List<Model.Group.GroupJoinRequest> convertToModelGroupJoinRequests(GroupServices.GroupJoinRequest[] serviceGroupJoinRequests)
        {
            List<Model.Group.GroupJoinRequest> modelGroupJoinRequests = new List<Model.Group.GroupJoinRequest>();

            foreach (GroupServices.GroupJoinRequest serviceGroupJoinRequest in serviceGroupJoinRequests)
            {
                modelGroupJoinRequests.Add(this.convertToModelGroupJoinRequest(serviceGroupJoinRequest));
            }

            return modelGroupJoinRequests;
        }

        #endregion
    }
}
