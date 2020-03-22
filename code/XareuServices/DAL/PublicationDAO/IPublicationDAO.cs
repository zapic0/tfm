using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IPublicationDAO
    {
        /// <summary>
        /// Devuelve los datos de una publicación determinada
        /// </summary>
        /// <param name="publicationId">Id de la publicación que queremos obtener</param>
        /// <returns>Datos de la publicación</returns>
        Model.Publication.Publication GetPublication(long publicationId);


        /// <summary>
        /// Añade una nueva publicación a la base de datos
        /// </summary>
        /// <param name="publication">Publicación que queremos añadir</param>
        /// <param name="publicationID">ID de la publicación que ha añadido</param>
        /// <returns>True si la pudo añadir, false en caso contrario</returns>
        bool AddPublication(Model.Publication.Publication publication, out long publicationID);

        /// <summary>
        /// Elimina una publicación de la base de datos
        /// </summary>
        /// <param name="publicationID">ID de la publicación que queremos eliminar</param>
        /// <returns>True si la pudo eliminar, false en caso contrario</returns>
        bool DeletePublication(long publicationID);

        /// <summary>
        /// Edita los valores de una publicación determinada substituyéndolos por los indicados en el parámetro
        /// </summary>
        /// <param name="publication">Datos para editar la publicación</param>
        /// <returns>True si se pudo editar, false en caso contrario</returns>
        bool EditPublication(Model.Publication.Publication publication);

        /// <summary>
        /// Devuelve las publicaciones de un usuario en particular
        /// </summary>
        /// <param name="userId">Id del usuario del que queremos buscar las publicaciones€</param>
        /// <returns>Lista de publicaciones del usuario</returns>
        List<Model.Publication.Publication> GetUserPublications(long userId, int number, int page, bool questions, bool publications);

        /// <summary>
        /// Devuelve las publicaciones que debe leer un usuario en particular
        /// </summary>
        /// <param name="userId">Id del usuario</param>
        /// <param name="number">Número de resultados por página</param>
        /// <param name="page">Página que queremos obtener</param>
        /// <returns>Lista con las publicaciones que debe leer el usuario</returns>
        List<Model.Publication.Publication> GetPublicationsForUser(long userId, int number, int page, bool questions, bool publications);

        /// <summary>
        /// Devuelve todas las publicaciones existentes
        /// </summary>
        /// <param name="number">Número de resultados por página</param>
        /// <param name="page">Página de resultado</param>
        /// <param name="page">True si queremos las preguntas</param>
        /// <param name="page">True si queremos las publicaciones</param>
        /// <returns>Lista de publicaciones</returns>
        List<Model.Publication.Publication> GetAllPublications(int number, int page, bool questions, bool publications);

        /// <summary>
        /// Busca las publicaciones que tienen un texto determinado
        /// </summary>
        /// <param name="text">Texto a buscar</param>
        /// <param name="number">Número de resultados por página</param>
        /// <param name="page">Página de resultado</param>
        /// <returns>Lista de publicaciones que cumplen con los criterios de búsqueda</returns>
        List<Model.Publication.Publication> SearchPublicationWithText(string text, int number, int page);


        /// <summary>
        /// Searches the publications in group.
        /// </summary>
        /// <param name="groupId">The group id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List with publications in specified group</returns>
        List<Model.Publication.Publication> SearchPublicationsInGroup(long groupId, int number, int page);

    }
}
