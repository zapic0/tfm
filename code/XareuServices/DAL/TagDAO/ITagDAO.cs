using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface ITagDAO
    {
        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <returns>Tag</returns>
        Model.Tag.Tag GetTag(long tagId);

        /// <summary>
        /// Gets all tags.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags</returns>
        List<Model.Tag.Tag> GetAllTags(int number, int page);

        /// <summary>
        /// Adds the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool AddTag(Model.Tag.Tag tag, out long tagID);

        /// <summary>
        /// Deletes the tag.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool DeleteTag(long tagId);

        /// <summary>
        /// Edits the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool EditTag(Model.Tag.Tag tag);
    }
}
