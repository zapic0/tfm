using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.UserDAO
{
    public class UserInPublicationDAO : IUserInPublicationDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInPublicationDAO"/> class.
        /// </summary>
        public UserInPublicationDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IUserInPublicationDAO Members

        /// <summary>
        /// Userses the in publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of users</returns>
        public List<Model.User.User> UsersInPublication(long publicationId, int number, int page)
        {
            List<Model.User.User> usersList = new List<XareuServices.Model.User.User>();

            var query = (from usersInPublication in data.user_in_publications
                         where usersInPublication.publication_id == publicationId
                         select usersInPublication).Skip<user_in_publication>(number * page).Take<user_in_publication>(number);

            foreach (user_in_publication user in query)
            {
                try
                {
                    usersList.Add(this.getUser(user.user));
                }
                catch { }
            }

            return usersList;
        }

        /// <summary>
        /// Users the mentions.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications</returns>
        public List<Model.Publication.Publication> UserMentions(long userId, int number, int page)
        {
            List<Model.Publication.Publication> publicationsList = new List<XareuServices.Model.Publication.Publication>();

            var query = (from usersInPublication in data.user_in_publications
                         where usersInPublication.user_id == userId
                         select usersInPublication).Skip<user_in_publication>(number * page).Take<user_in_publication>(number);

            foreach (user_in_publication publication in query)
            {
                try
                {
                    publicationsList.Add(this.getPublication(publication.publication));
                }
                catch { }
            }

            return publicationsList;
        }

        /// <summary>
        /// Adds the user in publication.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddUserInPublication(long userId, int publicationId)
        {
            user_in_publication newUserInPublication = new user_in_publication();

            newUserInPublication.user_id = userId;
            newUserInPublication.publication_id = publicationId;

            try
            {
                data.user_in_publications.InsertOnSubmit(newUserInPublication);
                data.SubmitChanges();

                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Deletes the user from publication.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteUserFromPublication(long userId, int publicationId)
        {
            var query = from usersInPublication in data.user_in_publications
                        where usersInPublication.user_id == userId
                        where usersInPublication.publication_id == publicationId
                        select usersInPublication;

            try
            {
                data.user_in_publications.DeleteOnSubmit(query.First<user_in_publication>());
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        #endregion

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        private Model.User.User getUser(user user)
        {
            Model.User.User newUser = new XareuServices.Model.User.User();

            newUser.DefaultPlace.Id = user.user_default_place;
            newUser.Email = user.user_email;
            newUser.Id = user.user_id;
            newUser.Karma = user.user_karma;
            newUser.Nick = user.user_nick;
            newUser.IsPrivate = user.user_is_private;
            newUser.IsAdmin = user.user_is_admin;
            newUser.SignUp = user.user_signup;

            return newUser;
        }

        /// <summary>
        /// Gets the publication.
        /// </summary>
        /// <param name="publication">The publication.</param>
        /// <returns></returns>
        private Model.Publication.Publication getPublication(publication publication)
        {
            Model.Publication.Publication newPublication = new XareuServices.Model.Publication.Publication();

            newPublication.Author.Email = publication.user.user_email;
            newPublication.Author.Id = publication.user.user_id;
            newPublication.Author.Nick = publication.user.user_nick;
            newPublication.Author.Karma = publication.user.user_karma;

            newPublication.CreationDateTime = publication.publication_datetime;

            newPublication.Id = publication.publication_id;

            newPublication.Place.Id = publication.place_tag_id;

            newPublication.Text = publication.publication_text;

            newPublication.Karma = (float)publication.publication_karma;

            newPublication.IsPrivate = publication.publlication_is_private;

            try
            {
                newPublication.IsQuestion = (bool)publication.publication_is_question;
            }
            catch { newPublication.IsQuestion = false; }

            try
            {
                newPublication.AnswersTo = (long)publication.publication_answer_to;
            }
            catch { newPublication.AnswersTo = 0; }

            return newPublication;
        }
    }
}
