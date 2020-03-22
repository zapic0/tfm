using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.PlaceTagDAO
{
    public class PlaceTagDAO : IPlaceTagDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceTagDAO"/> class.
        /// </summary>
        public PlaceTagDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IPlaceTagDAO Members

        /// <summary>
        /// Devuelve una etiqueta de lugar determinada
        /// </summary>
        /// <param name="placeTagId">Id de la etiqueta de lugar</param>
        /// <returns>Etiqueta de lugar</returns>
        public XareuServices.Model.TagPlace.TagPlace GetTagPlace(long placeTagId)
        {
            IEnumerable<place_tag> query = from tagPlaces in data.place_tags
                                           where tagPlaces.place_tag_id == placeTagId
                                           select tagPlaces;

            try
            {
                return this.getTagPlace(query.First<place_tag>());
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Edita los datos de una etiqueta de lugar determinada por los que indicamos
        /// </summary>
        /// <param name="tagPlace">Nuevos datos de la etiqueta que queremos editar (conservando el Id)</param>
        /// <returns></returns>
        public bool EditTagPlace(XareuServices.Model.TagPlace.TagPlace tagPlace)
        {
            place_tag actualTagPlaceValues;

            IEnumerable<place_tag> query = from tagPlaces in data.place_tags
                                           where tagPlaces.place_tag_id == tagPlace.Id
                                           select tagPlaces;

            actualTagPlaceValues = query.First<place_tag>();

            try
            {
                actualTagPlaceValues.place_tag_name = tagPlace.Name;
                actualTagPlaceValues.place_tag_parent = tagPlace.ParentId;

                this.data.SubmitChanges();
                return true;
            }

            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Borra una etiqueta de lugar
        /// </summary>
        /// <param name="placeTagId">Id de la etiqueta que queremos borrar</param>
        /// <returns>
        /// True si la pudo borrar, false en caso contrario
        /// </returns>
        public bool DeleteTagPlace(long placeTagId)
        {
            IEnumerable<place_tag> query = from tagPlaces in data.place_tags
                                           where tagPlaces.place_tag_id == placeTagId
                                           select tagPlaces;

            try
            {
                place_tag placeTagToDelete = query.First<place_tag>();
                data.place_tags.DeleteOnSubmit(placeTagToDelete);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the sons.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <returns>List of tag places</returns>
        public List<Model.TagPlace.TagPlace> GetSons(long tagPlaceID)
        {
            List<Model.TagPlace.TagPlace> sons = new List<XareuServices.Model.TagPlace.TagPlace>();

            IEnumerable<place_tag> tagPlaces = from places in data.place_tags
                                               where places.place_tag_parent == tagPlaceID
                                               select places;

            foreach (place_tag place in tagPlaces)
            {
                Model.TagPlace.TagPlace newPlace = new XareuServices.Model.TagPlace.TagPlace();
                newPlace.Id = place.place_tag_id;
                newPlace.Name = place.place_tag_name;
                newPlace.ParentId = (long)place.place_tag_parent;
                sons.Add(newPlace);
            }
            return sons;
        }

        /// <summary>
        /// Añade una etiqueta de lugar
        /// </summary>
        /// <param name="tagPlace">Etiqueta de lugar que queremos añadir</param>
        /// <param name="tagPlaceID"></param>
        /// <returns>
        /// True si la pudo añadir, false en caso contrario
        /// </returns>
        public bool AddTagPlace(XareuServices.Model.TagPlace.TagPlace tagPlace, out long tagPlaceID)
        {
            tagPlaceID = 0;
            try
            {
                place_tag newPlaceTag = this.convertToLinqPlaceTag(tagPlace);

                data.place_tags.InsertOnSubmit(newPlaceTag);
                data.SubmitChanges();

                tagPlaceID = this.getLastInsertedTagPlaceID();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Gets the last inserted tag place ID.
        /// </summary>
        /// <returns></returns>
        private long getLastInsertedTagPlaceID()
        {
            long tagPlaceID = 0;

            IEnumerable<place_tag> query = from tagPlaces in data.place_tags
                                            select tagPlaces;
            
            tagPlaceID = query.Last<place_tag>().place_tag_id;

            return tagPlaceID;
        }

        /// <summary>
        /// Gets the tag place.
        /// </summary>
        /// <param name="tagPlace">The tag place.</param>
        /// <returns></returns>
        private Model.TagPlace.TagPlace getTagPlace(place_tag tagPlace)
        {
            Model.TagPlace.TagPlace newTagPlace = new XareuServices.Model.TagPlace.TagPlace();

            newTagPlace.Id = tagPlace.place_tag_id;
            newTagPlace.Name = tagPlace.place_tag_name;
            try
            {
                newTagPlace.ParentId = (long)tagPlace.place_tag_parent;
            }
            catch { newTagPlace.ParentId = 1; }

            return newTagPlace;
        }

        /// <summary>
        /// Converts to linq place tag.
        /// </summary>
        /// <param name="tagPlace">The tag place.</param>
        /// <returns></returns>
        private place_tag convertToLinqPlaceTag(Model.TagPlace.TagPlace tagPlace)
        {
            place_tag newPlaceTag = new place_tag();

            newPlaceTag.place_tag_name = tagPlace.Name;
            newPlaceTag.place_tag_parent = tagPlace.ParentId;

            return newPlaceTag;
        }
    }
}
