using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface ITagInPublicationDAO
    {
        /// <summary>
        /// Gets the tags for publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags</returns>
        List<Model.Tag.Tag> GetTagsForPublication(long publicationId, int number, int page);

        /// <summary>
        /// Gets the publications with tag.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications</returns>
        List<Model.Publication.Publication> GetPublicationsWithTag(long tagId, int number, int page);

        /// <summary>
        /// Adds the tag to publication.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool AddTagToPublication(long tagId, long publicationId);

        /// <summary>
        /// Deletes the tag from publication.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool DeleteTagFromPublication(long tagId, long publicationId);
    }
}
