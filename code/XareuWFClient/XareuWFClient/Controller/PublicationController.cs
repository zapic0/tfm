using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Controller
{
    class PublicationController
    {
        PublicationServices.PublicationServiceClient publicationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationController"/> class.
        /// </summary>
        public PublicationController()
        {
            publicationService = new XareuWFClient.PublicationServices.PublicationServiceClient();
        }

        /// <summary>
        /// Gets all publications.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public List<Model.Publication.Publication> GetAllPublications(int page, int number)
        {
            List<Model.Publication.Publication> publications;

            try
            {
                PublicationServices.Publication[] servicePublications = this.publicationService.GetAllPublications(number, page, false, true);
                publications = this.convertToModelPublicationList(servicePublications);
            }
            catch(Exception ex)
            {
                throw new Exception("Error while trying to get new publications " + ex.Message);
            }
            return publications;
        }

        /// <summary>
        /// Gets all questions.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public List<Model.Publication.Publication> GetAllQuestions(int page, int number)
        {
            List<Model.Publication.Publication> publications;

            try
            {
                PublicationServices.Publication[] servicePublications = this.publicationService.GetAllPublications(number, page, true, false);
                publications = this.convertToModelPublicationList(servicePublications);
            }
            catch(Exception ex)
            {
                throw new Exception("Error while trying to get new questions " + ex.Message);
            }
            return publications;
        }

        /// <summary>
        /// Gets the publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns></returns>
        public Model.Publication.Publication GetPublication(long publicationID)
        {
            try
            {
                return this.convertToModelPublication(publicationService.GetPublication(publicationID));
            }
            catch(Exception ex)
            {
                throw new Exception("Error getting publication " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the publication answers.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.Publication.Publication> GetPublicationAnswers(long publicationID, int number, int page)
        {
            try
            {
                return this.convertToModelPublicationList(publicationService.GetPublicationAnswers(publicationID, number, page));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting publication answers " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the user publications.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="questions">if set to <c>true</c> [questions].</param>
        /// <param name="publications">if set to <c>true</c> [publications].</param>
        /// <returns></returns>
        public List<Model.Publication.Publication> GetUserPublications(out Guid newToken, long userID, Guid token, long userAuthorID, int number, int page, bool questions, bool publications)
        {
            try
            {
                return this.convertToModelPublicationList(publicationService.GetUserPublications(out newToken, userID, token, userAuthorID, number, page, questions, publications));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting publication answers " + ex.Message);
            }
        }

        /// <summary>
        /// Gets the publications for group.
        /// </summary>
        /// <param name="newToken">The new token.</param>
        /// <param name="groupID">The group ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.Publication.Publication> GetPublicationsForGroup(out Guid newToken, long groupID, Guid token, long userAuthorID, int number, int page)
        {
            try
            {
                return this.convertToModelPublicationList(publicationService.GetPublicationsForGroup(out newToken, groupID, token, userAuthorID, number, page));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting group publications " + ex.Message);
            }
        }


        #region Converters
        /// <summary>
        /// Converts to model publication list.
        /// </summary>
        /// <param name="servicePublicationList">The service publication list.</param>
        /// <returns></returns>
        private List<Model.Publication.Publication> convertToModelPublicationList(PublicationServices.Publication[] servicePublicationList)
        {
            List<Model.Publication.Publication> modelPublications = new List<XareuWFClient.Model.Publication.Publication>();

            foreach (PublicationServices.Publication publication in servicePublicationList)
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
        private Model.Publication.Publication convertToModelPublication(PublicationServices.Publication servicePublication)
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
        private Model.User.User convertToModelUser(PublicationServices.User serviceUser)
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
        private Model.TagPlace.TagPlace convertToModelTagPlace(PublicationServices.TagPlace serviceTagPlace)
        {
            Model.TagPlace.TagPlace modelTagPlace = new XareuWFClient.Model.TagPlace.TagPlace(serviceTagPlace.Id);

            modelTagPlace.Name = serviceTagPlace.Name;
            modelTagPlace.ParentId = serviceTagPlace.ParentId;

            return modelTagPlace;
        }
        #endregion
    }
}
