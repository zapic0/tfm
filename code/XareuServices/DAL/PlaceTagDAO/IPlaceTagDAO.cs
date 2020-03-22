using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IPlaceTagDAO
    {
        /// <summary>
        /// Devuelve una etiqueta de lugar determinada
        /// </summary>
        /// <param name="placeTagId">Id de la etiqueta de lugar</param>
        /// <returns>Etiqueta de lugar</returns>
        Model.TagPlace.TagPlace GetTagPlace(long placeTagId);

        /// <summary>
        /// Edita los datos de una etiqueta de lugar determinada por los que indicamos
        /// </summary>
        /// <param name="tagPlace">Nuevos datos de la etiqueta que queremos editar (conservando el Id)</param>
        bool EditTagPlace(Model.TagPlace.TagPlace tagPlace);

        /// <summary>
        /// Borra una etiqueta de lugar
        /// </summary>
        /// <param name="placeTagId">Id de la etiqueta que queremos borrar</param>
        /// <returns>True si la pudo borrar, false en caso contrario</returns>
        bool DeleteTagPlace(long placeTagId);

        /// <summary>
        /// Añade una etiqueta de lugar
        /// </summary>
        /// <param name="tagPlace">Etiqueta de lugar que queremos añadir</param>
        /// <returns>True si la pudo añadir, false en caso contrario</returns>
        bool AddTagPlace(Model.TagPlace.TagPlace tagPlace, out long tagPlaceID);

        /// <summary>
        /// Gets the sons.
        /// </summary>
        /// <param name="tagPlaceID">The tag place ID.</param>
        /// <returns>List of tag places</returns>
        List<Model.TagPlace.TagPlace> GetSons(long tagPlaceID);
    }
}
