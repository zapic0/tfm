using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Controller
{
    class TagsController
    {
        TagServices.TagServiceClient tagService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsController"/> class.
        /// </summary>
        public TagsController()
        {
            tagService = new TagServices.TagServiceClient();
        }

        /// <summary>
        /// Adds the tag.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="tag">The tag.</param>
        /// <returns></returns>
        public bool AddTag(out Guid newToken, out long tagID, long userID, Guid token, Model.Tag.Tag tag)
        {
            try
            {
                return tagService.AddTag(out newToken, out tagID, userID, token, this.convertToServiceTag(tag));
            }
            catch(Exception ex)
            {
                throw new Exception("Error adding new tag " + ex.Message);
            }
        }

        /// <summary>
        /// Adds the user subscription.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns></returns>
        public bool AddUserSubscription(out Guid newToken, long userID, Guid token, long userAuthorID, long tagID)
        {
            try
            {
                return tagService.AddUserSubscription(out newToken, userID, token, userAuthorID, tagID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new tag " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the name of the tag by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Model.Tag.Tag GetTagByName(string name)
        {
            try
            {
                return this.convertToModelTag(tagService.GetTagByName(name));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting tag " + ex.Message);
            }
        }

        /// <summary>
        /// Gets all user subscriptions.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.Tag.Tag> GetAllUserSubscriptions(out Guid newToken, long userID, Guid token, long userAuthorID, int number, int page)
        {
            try
            {
                return this.convertToModelTagList(tagService.GetAllUserSubscriptions(out newToken, userID, token, userAuthorID, number, page));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting subscribed tags " + ex.Message);
            }

        }

        /// <summary>
        /// Gets the publications with tag.
        /// </summary>
        /// <param name="tagID">The tag ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.Publication.Publication> GetPublicationsWithTag(long tagID, int number, int page)
        {
            try
            {
                return this.convertToModelPublicationList(tagService.GetPublicationsWithTag(tagID, number, page));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting publications with tag " + ex.Message);
            }
        }

        /// <summary>
        /// Searches the tag.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.Tag.Tag> SearchTag(string text, int number, int page)
        {
            try
            {
                return this.convertToModelTagList(tagService.SearchTagsByText(text, number, page));
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching tags " + ex.Message);
            }
        }

        #region Converters

        #region Tag Converters
        /// <summary>
        /// Converts to model tag.
        /// </summary>
        /// <param name="serviceTag">The service tag.</param>
        /// <returns></returns>
        private Model.Tag.Tag convertToModelTag(TagServices.Tag serviceTag)
        {
            if (serviceTag == null)
            {
                return null;
            }

            Model.Tag.Tag modelTag = new Model.Tag.Tag();

            modelTag.Id = serviceTag.Id;
            modelTag.Name = serviceTag.Name;

            return modelTag;
        }

        /// <summary>
        /// Converts to model tag list.
        /// </summary>
        /// <param name="serviceTagList">The service tag list.</param>
        /// <returns></returns>
        private List<Model.Tag.Tag> convertToModelTagList(TagServices.Tag[] serviceTagList)
        {
            List<Model.Tag.Tag> modelTagList = new List<Model.Tag.Tag>();
            foreach (TagServices.Tag serviceTag in serviceTagList)
            {
                modelTagList.Add(this.convertToModelTag(serviceTag));
            }
            return modelTagList;
        }

        /// <summary>
        /// Converts to service tag.
        /// </summary>
        /// <param name="modelTag">The model tag.</param>
        /// <returns></returns>
        private TagServices.Tag convertToServiceTag(Model.Tag.Tag modelTag)
        {
            TagServices.Tag serviceTag = new TagServices.Tag();

            serviceTag.Id = modelTag.Id;
            serviceTag.Name = modelTag.Name;

            return serviceTag;
        }
        #endregion

        #region Publication Converters

        /// <summary>
        /// Converts to model publication list.
        /// </summary>
        /// <param name="servicePublicationList">The service publication list.</param>
        /// <returns></returns>
        private List<Model.Publication.Publication> convertToModelPublicationList(TagServices.Publication[] servicePublicationList)
        {
            List<Model.Publication.Publication> modelPublications = new List<XareuWFClient.Model.Publication.Publication>();

            foreach (TagServices.Publication publication in servicePublicationList)
            {
                modelPublications.Add(this.convertToModelPublication(publication));
            }

            return modelPublications;
        }

        /// <summary>
        /// Converts to model publication.
        /// </summary>
        /// <param name="servicePublication">The service publication.</param>
        /// <returns></returns>
        private Model.Publication.Publication convertToModelPublication(TagServices.Publication servicePublication)
        {
            Model.Publication.Publication modelPublication = new XareuWFClient.Model.Publication.Publication();

            modelPublication.AnswersTo = servicePublication.AnswersTo;
            modelPublication.Author = this.convertToModelUser(servicePublication.Author);
            modelPublication.CreationDateTime = servicePublication.CreationDateTime;
            modelPublication.Id = servicePublication.Id;
            modelPublication.IsPrivate = servicePublication.IsPrivate;
            modelPublication.IsQuestion = servicePublication.IsQuestion;
            modelPublication.Karma = servicePublication.Karma;
            modelPublication.NegativeVotes = servicePublication.NegativeVotes;
            modelPublication.Place = this.convertToModelTagPlace(servicePublication.Place);
            modelPublication.PositiveVotes = servicePublication.PositiveVotes;
            modelPublication.Text = servicePublication.Text;

            return modelPublication;
        }

        /// <summary>
        /// Converts to model user.
        /// </summary>
        /// <param name="serviceUser">The service user.</param>
        /// <returns></returns>
        private Model.User.User convertToModelUser(TagServices.User serviceUser)
        {
            Model.User.User modelUser = new XareuWFClient.Model.User.User();

            modelUser.DefaultPlace = this.convertToModelTagPlace(serviceUser.DefaultPlace);
            modelUser.Email = serviceUser.Email;
            modelUser.Id = serviceUser.Id;
            modelUser.IsAdmin = serviceUser.IsAdmin;
            modelUser.IsPrivate = serviceUser.IsPrivate;
            modelUser.Karma = serviceUser.Karma;
            modelUser.Nick = serviceUser.Nick;
            modelUser.SignUp = serviceUser.SignUp;
            modelUser.UserPictureURL = serviceUser.UserPictureURL;

            return modelUser;
        }

        /// <summary>
        /// Converts to model tag place.
        /// </summary>
        /// <param name="serviceTagPlace">The service tag place.</param>
        /// <returns></returns>
        private Model.TagPlace.TagPlace convertToModelTagPlace(TagServices.TagPlace serviceTagPlace)
        {
            Model.TagPlace.TagPlace modelTagPlace = new XareuWFClient.Model.TagPlace.TagPlace(serviceTagPlace.Id);

            modelTagPlace.Name = serviceTagPlace.Name;
            modelTagPlace.ParentId = serviceTagPlace.ParentId;

            return modelTagPlace;
        }
        #endregion

        #endregion
    }
}
