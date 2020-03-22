using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.TagDAO
{
    /// <summary>
    /// 
    /// </summary>
    public class TagDAO : ITagDAO
    {

        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="TagDAO"/> class.
        /// </summary>
        public TagDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }


        #region ITagDAO Members

        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <returns>Tag</returns>
        public XareuServices.Model.Tag.Tag GetTag(long tagId)
        {
            var query = from tags in data.tags
                        where tags.tag_id == tagId
                        select tags;

            try
            {
                return this.getTag(query.First<tag>());
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the name of the tag by.
        /// </summary>
        /// <param name="tagName">Name of the tag.</param>
        /// <returns></returns>
        public XareuServices.Model.Tag.Tag GetTagByName(string tagName)
        {
            var query = from tags in data.tags
                        where tags.tag_name == tagName
                        select tags;

            try
            {
                return this.getTag(query.First<tag>());
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all tags.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of tags</returns>
        public List<XareuServices.Model.Tag.Tag> GetAllTags(int number, int page)
        {
            List<Model.Tag.Tag> tagList = new List<XareuServices.Model.Tag.Tag>();
            var query = (from tags in data.tags
                         select tags).Skip<tag>(number * page).Take<tag>(number);

            foreach (tag tag in query)
            {
                tagList.Add(this.getTag(tag));
            }

            return tagList;
        }

        /// <summary>
        /// Adds the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <param name="tagID">The tag ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddTag(XareuServices.Model.Tag.Tag tag, out long tagID)
        {
            tagID = 0;
            try
            {
                Linq.tag tagToAdd = new tag();
                tagToAdd.tag_name = tag.Name;
                data.tags.InsertOnSubmit(tagToAdd);
                data.SubmitChanges();
                tagID = this.getLastInsertedTagID();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes the tag.
        /// </summary>
        /// <param name="tagId">The tag id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteTag(long tagId)
        {
            var query = from tags in data.tags
                        where tags.tag_id == tagId
                        select tags;

            try
            {
                data.tags.DeleteOnSubmit(query.First<tag>());
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Edits the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool EditTag(XareuServices.Model.Tag.Tag tag)
        {
            try
            {
                Linq.tag actualTagData = (from tags in data.tags
                                          where tags.tag_id == tag.Id
                                          select tags).First<tag>();
                actualTagData.tag_name = tag.Name;
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        #endregion

        /// <summary>
        /// Gets the last inserted tag ID.
        /// </summary>
        /// <returns></returns>
        private long getLastInsertedTagID()
        {
            try
            {
                IEnumerable<tag> query = from tags in data.tags
                                         orderby tags.tag_id
                                         select tags;
                return query.Last<tag>().tag_id;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns></returns>
        private Model.Tag.Tag getTag(tag tag)
        {
            Model.Tag.Tag newTag = new XareuServices.Model.Tag.Tag();

            newTag.Id = tag.tag_id;
            newTag.Name = tag.tag_name;

            return newTag;
        }

        /// <summary>
        /// Searches the tag by text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public List<Model.Tag.Tag> SearchTagByText(string text, int number, int page)
        {
            List<Model.Tag.Tag> tagList = new List<XareuServices.Model.Tag.Tag>();
            var query = (from tags in data.tags
                         where tags.tag_name.Contains(text)
                         select tags).Skip<tag>(number * page).Take<tag>(number);

            foreach (tag tag in query)
            {
                tagList.Add(this.getTag(tag));
            }

            return tagList;
        }
    }
}
