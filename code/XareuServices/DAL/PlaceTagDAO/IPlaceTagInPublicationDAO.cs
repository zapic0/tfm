using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IPlaceTagInPublicationDAO
    {
        /// <summary>
        /// Gets the place tags in publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tag places</returns>
        List<Model.TagPlace.TagPlace> GetPlaceTagsInPublication(long publicationId, int number, int page);

        /// <summary>
        /// Gets the publication for place tag.
        /// </summary>
        /// <param name="placeTagId">The place tag id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications</returns>
        List<Model.Publication.Publication> GetPublicationForPlaceTag(long placeTagId, int number, int page);

        /// <summary>
        /// Adds the place tag in publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="placeTagId">The place tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool AddPlaceTagInPublication(long publicationId, long placeTagId);

        /// <summary>
        /// Deletes the place tag in publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="placeTagId">The place tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool DeletePlaceTagInPublication(long publicationId, long placeTagId);
    }
}
