using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.PlaceTagDAO
{
    public class PlaceTagInPublicationDAO : IPlaceTagInPublicationDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceTagInPublicationDAO"/> class.
        /// </summary>
        public PlaceTagInPublicationDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IPlaceTagInPublicationDAO Members

        /// <summary>
        /// Gets the place tags in publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tag places</returns>
        public List<Model.TagPlace.TagPlace> GetPlaceTagsInPublication(long publicationId, int number, int page)
        {
            List<Model.TagPlace.TagPlace> placeTagsInPublicationList = new List<Model.TagPlace.TagPlace>();

            var query = (from placeTagsInPublication in data.place_tag_in_publications
                        where placeTagsInPublication.publication_id == publicationId
                        select placeTagsInPublication).Skip<place_tag_in_publication>(number * page).Take<place_tag_in_publication>(number);

            foreach (place_tag_in_publication placeTag in query)
            {
                placeTagsInPublicationList.Add(getPlaceTag(placeTag));
            }

            return placeTagsInPublicationList;
        }



        /// <summary>
        /// Gets the publication for place tag.
        /// </summary>
        /// <param name="placeTagId">The place tag id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications</returns>
        public List<Model.Publication.Publication> GetPublicationForPlaceTag(long placeTagId, int number, int page)
        {
            List<Model.Publication.Publication> publicationsInPlaceTag = new List<Model.Publication.Publication>();

            var query = (from publicationsForPlaceTag in data.place_tag_in_publications
                        where publicationsForPlaceTag.place_tag_id == placeTagId
                         select publicationsForPlaceTag).Skip<place_tag_in_publication>(number * page).Take<place_tag_in_publication>(number);

            foreach (place_tag_in_publication publication in query)
            {
                publicationsInPlaceTag.Add(this.getPublication(this.getPublicationData(publication.publication_id)));
            }

            return publicationsInPlaceTag;
        }

        /// <summary>
        /// Adds the place tag in publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="placeTagId">The place tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddPlaceTagInPublication(long publicationId, long placeTagId)
        {
            try
            {
                place_tag_in_publication newPlaceTagInPublication = new place_tag_in_publication();
                newPlaceTagInPublication.publication_id = publicationId;
                newPlaceTagInPublication.place_tag_id = placeTagId;
                data.place_tag_in_publications.InsertOnSubmit(newPlaceTagInPublication);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes the place tag in publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="placeTagId">The place tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeletePlaceTagInPublication(long publicationId, long placeTagId)
        {
            var query = from placeTagInPublication in data.place_tag_in_publications
                        where placeTagInPublication.place_tag_id == placeTagId
                        where placeTagInPublication.publication_id == publicationId
                        select placeTagInPublication;

            try
            {
                data.place_tag_in_publications.DeleteOnSubmit(query.First<place_tag_in_publication>());
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Gets the place tag.
        /// </summary>
        /// <param name="placeTag">The place tag.</param>
        /// <returns></returns>
        private Model.TagPlace.TagPlace getPlaceTag(place_tag_in_publication placeTag)
        {
            Model.TagPlace.TagPlace newTagPlace = new XareuServices.Model.TagPlace.TagPlace();

            newTagPlace.Id = placeTag.place_tag_id;
            newTagPlace.Name = placeTag.place_tag.place_tag_name;
            try
            {
                newTagPlace.ParentId = (long)placeTag.place_tag.place_tag_parent;
            }
            catch { newTagPlace.ParentId = 0; }

            return newTagPlace;
        }

        /// <summary>
        /// Gets the publication data.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns></returns>
        private publication getPublicationData(long publicationID)
        {
            try
            {
                publication query = (from publications in data.publications
                                     where publications.publication_id == publicationID
                                     select publications).First<publication>();
                return query;
            }
            catch { return null; }
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
