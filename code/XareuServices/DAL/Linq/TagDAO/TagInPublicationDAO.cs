using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.TagDAO
{
    public class TagInPublicationDAO : ITagInPublicationDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="TagInPublicationDAO"/> class.
        /// </summary>
        public TagInPublicationDAO ()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region ITagInPublicationDAO Members

        /// <summary>
        /// Gets the tags for publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags</returns>
        public List<Model.Tag.Tag> GetTagsForPublication(long publicationId, int number, int page)
        {
            List<Model.Tag.Tag> tagsList = new List<XareuServices.Model.Tag.Tag>();

            try
            {
                var query = (from tags in data.tag_in_publications
                            where tags.publication_id == publicationId
                            select tags).Skip<tag_in_publication>(number * page).Take<tag_in_publication>(number);

                foreach (tag_in_publication tag in query)
                {
                    tagsList.Add(this.getTag(tag));
                }
            }
            catch { }

            return tagsList;
        }

        /// <summary>
        /// Gets the publications with tag.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications</returns>
        public List<Model.Publication.Publication> GetPublicationsWithTag(long tagId, int number, int page)
        {
            List<Model.Publication.Publication> publicationsList = new List<XareuServices.Model.Publication.Publication>();

            var query = (from publications in data.tag_in_publications
                        where publications.tag_id == tagId
                         select publications).Skip<tag_in_publication>(number * page).Take<tag_in_publication>(number);

            foreach (tag_in_publication publication in query)
            {
                publicationsList.Add(this.getPublication(publication));
            }

            return publicationsList;
        }

        /// <summary>
        /// Adds the tag to publication.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddTagToPublication(long tagId, long publicationId)
        {
            try
            {
                tag_in_publication newTagInPublication = new tag_in_publication();
                newTagInPublication.publication_id = publicationId;
                newTagInPublication.tag_id = tagId;
                data.tag_in_publications.InsertOnSubmit(newTagInPublication);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Deletes the tag from publication.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteTagFromPublication(long tagId, long publicationId)
        {
            var query = from tagInPublication in data.tag_in_publications
                        where tagInPublication.tag_id == tagId
                        where tagInPublication.publication_id == publicationId
                        select tagInPublication;
            try
            {
                data.tag_in_publications.DeleteOnSubmit(query.First<tag_in_publication>());
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
        /// Gets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns></returns>
        private Model.Tag.Tag getTag(tag_in_publication tag)
        {
            Model.Tag.Tag newTag = new XareuServices.Model.Tag.Tag();

            newTag.Id = tag.tag_id;
            newTag.Name = tag.tag.tag_name;

            return newTag;
        }

        /// <summary>
        /// Gets the publication.
        /// </summary>
        /// <param name="publication">The publication.</param>
        /// <returns></returns>
        private Model.Publication.Publication getPublication(tag_in_publication publication)
        {
            Model.Publication.Publication newPublication = new XareuServices.Model.Publication.Publication();

            newPublication.Author.Email = publication.publication.user.user_email;
            newPublication.Author.Id = publication.publication.user.user_id;
            newPublication.Author.Nick = publication.publication.user.user_nick;
            newPublication.Author.Karma = publication.publication.user.user_karma;

            newPublication.CreationDateTime = publication.publication.publication_datetime;

            newPublication.Id = publication.publication_id;

            newPublication.Place.Id = publication.publication.place_tag_id;

            newPublication.Text = publication.publication.publication_text;

            newPublication.Karma = (float)publication.publication.publication_karma;

            newPublication.IsPrivate = publication.publication.publlication_is_private;

            try
            {
                newPublication.IsQuestion = (bool)publication.publication.publication_is_question;
            }
            catch { newPublication.IsQuestion = false; }

            try
            {
                newPublication.AnswersTo = (long)publication.publication.publication_answer_to;
            }
            catch { newPublication.AnswersTo = 0; }

            return newPublication;
        }
    }
}
