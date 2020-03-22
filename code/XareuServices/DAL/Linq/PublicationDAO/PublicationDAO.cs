using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.PublicationDAO
{
    public class PublicationDAO : IPublicationDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationDAO"/> class.
        /// </summary>
        public PublicationDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IPublicationDAO Members

        /// <summary>
        /// Devuelve los datos de una publicación determinada
        /// </summary>
        /// <param name="publicationId">Id de la publicación que queremos obtener</param>
        /// <returns>Datos de la publicación</returns>
        public XareuServices.Model.Publication.Publication GetPublication(long publicationId)
        {
            var query = from publications in data.publications
                        where publications.publication_id == publicationId
                        select publications;

            try
            {
                publication publication = query.First<publication>();

                return this.getPublication(publication);
            }
            catch { return null; }
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
            List<Model.Publication.Publication> publicationAnswers = new List<XareuServices.Model.Publication.Publication>();

            var query = (from publications in data.publications
                        where publications.publication_answer_to == publicationID
                         select publications).Skip<publication>(number * page).Take<publication>(number);

            try
            {
                foreach (publication publication in query)
                {
                    publicationAnswers.Add(this.getPublication(publication));
                }
                return publicationAnswers;
            }
            catch { return null; }
        }

        /// <summary>
        /// Añade una nueva publicación a la base de datos
        /// </summary>
        /// <param name="publication">Publicación que queremos añadir</param>
        /// <param name="publicationID">ID de la publicación que ha añadido</param>
        /// <returns>
        /// True si la pudo añadir, false en caso contrario
        /// </returns>
        public bool AddPublication(XareuServices.Model.Publication.Publication publication, out long publicationID)
        {
            Linq.publication newPublication = this.convertToLinqPublication(publication);
            publicationID = 0;
            try
            {
                data.publications.InsertOnSubmit(newPublication);
                data.SubmitChanges();
                publicationID = this.getLastestPublicationID();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Elimina una publicación de la base de datos
        /// </summary>
        /// <param name="publicationID">ID de la publicación que queremos eliminar</param>
        /// <returns>
        /// True si la pudo eliminar, false en caso contrario
        /// </returns>
        public bool DeletePublication(long publicationID)
        {
            try
            {
                publication query = (from publications in data.publications
                                     where publications.publication_id == publicationID
                                     select publications).First<publication>();
                data.publications.DeleteOnSubmit(query);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Edita los valores de una publicación determinada substituyéndolos por los indicados en el parámetro
        /// </summary>
        /// <param name="publication">Datos para editar la publicación</param>
        /// <returns>
        /// True si se pudo editar, false en caso contrario
        /// </returns>
        public bool EditPublication(XareuServices.Model.Publication.Publication publication)
        {
            DAL.Linq.publication actualPublicationData;
            actualPublicationData = (from publications in data.publications
                                    where publications.publication_id == publication.Id
                                    select publications).First<publication>();

            try
            {
                actualPublicationData.place_tag_id = publication.Place.Id;
                actualPublicationData.publication_datetime = publication.CreationDateTime;
                actualPublicationData.publication_is_question = publication.IsQuestion;
                actualPublicationData.publlication_is_private = publication.IsPrivate;
                actualPublicationData.publication_karma = publication.Karma;
                actualPublicationData.publication_text = publication.Text;
                actualPublicationData.user_id_author = publication.Author.Id;

                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the user publications.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="wantQuestions">if set to <c>true</c> [want questions].</param>
        /// <param name="wantPublications">if set to <c>true</c> [want publications].</param>
        /// <returns></returns>
        public List<XareuServices.Model.Publication.Publication> GetUserPublications(long userId, int number, int page, bool wantQuestions, bool wantPublications)
        {
            List<Model.Publication.Publication> userPublications = new List<XareuServices.Model.Publication.Publication>();

            var query = (from publications in data.publications
                         where publications.user_id_author == userId
                         where ((publications.publication_is_question == wantQuestions == true) || (publications.publication_is_question != (wantPublications == true)))
                         select publications).Skip<publication>(number * page).Take<publication>(number);

            foreach (publication publication in query)
            {
                userPublications.Add(this.getPublication(publication));
            }

            return userPublications;
        }

        /// <summary>
        /// Gets the publications for user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="wantQuestions">if set to <c>true</c> [want questions].</param>
        /// <param name="wantPublications">if set to <c>true</c> [want publications].</param>
        /// <returns></returns>
        public List<XareuServices.Model.Publication.Publication> GetPublicationsForUser(long userId, int number, int page, bool wantQuestions, bool wantPublications)
        {
            List<Model.Publication.Publication> userPublications = new List<XareuServices.Model.Publication.Publication>();

            var query = (from publications in data.publications
                         select publications).Skip<publication>(number * page).Take<publication>(number);

            foreach (publication publication in query)
            {
                userPublications.Add(this.getPublication(publication));
            }

            return userPublications;
        }

        /// <summary>
        /// Gets all publications.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="wantQuestions">if set to <c>true</c> [want questions].</param>
        /// <param name="wantPublications">if set to <c>true</c> [want publications].</param>
        /// <returns></returns>
        public List<XareuServices.Model.Publication.Publication> GetAllPublications(int number, int page, bool wantQuestions, bool wantPublications)
        {
            List<Model.Publication.Publication> userPublications = new List<XareuServices.Model.Publication.Publication>();

            var query = (from publications in data.publications
                         where ((publications.publication_is_question == wantQuestions == true) || (publications.publication_is_question != (wantPublications == true)))
                         select publications).Skip<publication>(number * page).Take<publication>(number);

            foreach (publication publication in query)
            {
                userPublications.Add(this.getPublication(publication));
            }

            return userPublications;
        }

        /// <summary>
        /// Busca las publicaciones que tienen un texto determinado
        /// </summary>
        /// <param name="text">Texto a buscar</param>
        /// <param name="number">Número de resultados por página</param>
        /// <param name="page">Página de resultado</param>
        /// <returns>
        /// Lista de publicaciones que cumplen con los criterios de búsqueda
        /// </returns>
        public List<XareuServices.Model.Publication.Publication> SearchPublicationWithText(string text, int number, int page)
        {
            List<Model.Publication.Publication> userPublications = new List<XareuServices.Model.Publication.Publication>();

            var query = (from publications in data.publications
                         where publications.publication_text.Contains(text)
                         select publications).Skip<publication>(number * page).Take<publication>(number);

            foreach (publication publication in query)
            {
                userPublications.Add(this.getPublication(publication));
            }

            return userPublications;
        }

        /// <summary>
        /// Searches the publications in group.
        /// </summary>
        /// <param name="groupId">The group id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>
        /// List with publications in specified group
        /// </returns>
        public List<Model.Publication.Publication> SearchPublicationsInGroup(long groupId, int number, int page)
        {
            List<Model.Publication.Publication> publicationsInGroup = new List<Model.Publication.Publication>();

            IEnumerable<long> publicationsId = ((from publications_in_group in data.group_in_publications
                                                  where publications_in_group.group_id == groupId
                                                  select publications_in_group.publication_id).Skip<long>(number * page).Take<long>(number));

            IEnumerable<publication> publicationsToReturn = from allPublications in data.publications
                                                   where publicationsId.Contains<long>(allPublications.publication_id)
                                                   select allPublications;

            foreach (publication publicationToReturn in publicationsToReturn)
            {
                publicationsInGroup.Add(this.getPublication(publicationToReturn));
            }

            return publicationsInGroup;
        }


        #endregion

        /// <summary>
        /// Gets the lastest publication ID.
        /// </summary>
        /// <returns></returns>
        private long getLastestPublicationID()
        {
            IEnumerable<publication> query = (from publications in data.publications
                        select publications);
            try
            {
                return query.Last<publication>().publication_id;
            }
            catch
            {
                return 0;
            }
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
            newPublication.IsQuestion = publication.publication_is_question.GetValueOrDefault(false);
            newPublication.AnswersTo = publication.publication_answer_to.GetValueOrDefault(0);
            newPublication.PositiveVotes = publication.positive_votes.GetValueOrDefault(0);
            newPublication.NegativeVotes = publication.negative_votes.GetValueOrDefault(0);

            return newPublication;
        }

        /// <summary>
        /// Converts to linq publication.
        /// </summary>
        /// <param name="publication">The publication.</param>
        /// <returns></returns>
        private publication convertToLinqPublication(Model.Publication.Publication publication)
        {
            publication newPublication = new publication();

            newPublication.place_tag_id = publication.Place.Id;
            newPublication.publication_answer_to = publication.AnswersTo;
            newPublication.publication_datetime = publication.CreationDateTime;
            newPublication.publication_is_question = publication.IsQuestion;
            newPublication.publication_karma = publication.Karma;
            newPublication.publication_text = publication.Text;
            newPublication.publlication_is_private = publication.IsPrivate;
            newPublication.user_id_author = publication.Author.Id;
            newPublication.positive_votes = publication.PositiveVotes;
            newPublication.negative_votes = publication.NegativeVotes;

            return newPublication;
        }

        
    }
}
