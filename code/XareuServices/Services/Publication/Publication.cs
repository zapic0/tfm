using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Services.Publication
{
    public class Publication : API.IPublicationService
    {
        Services.Login.Login loginService = new XareuServices.Services.Login.Login();
        DAL.Linq.PublicationDAO.PublicationDAO publicationDAO = new XareuServices.DAL.Linq.PublicationDAO.PublicationDAO();
        DAL.Linq.UserDAO.UserDAO userDAO = new XareuServices.DAL.Linq.UserDAO.UserDAO();

        /// <summary>
        /// Gets all publications.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="questions">if set to <c>true</c> [questions].</param>
        /// <param name="publications">if set to <c>true</c> [publications].</param>
        /// <returns>List with publications</returns>
        public List<XareuServices.Model.Publication.Publication> GetAllPublications(int number, int page, bool questions, bool publications)
        {
            return publicationDAO.GetAllPublications(number, page, questions, publications);
        }

        /// <summary>
        /// Gets the publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>Publication</returns>
        public XareuServices.Model.Publication.Publication GetPublication(long publicationID)
        {
            return publicationDAO.GetPublication(publicationID);
        }

        /// <summary>
        /// Gets the publication answers.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publication's answers</returns>
        public List<Model.Publication.Publication> GetPublicationAnswers(long publicationID, int number, int page)
        {
            return publicationDAO.GetPublicationAnswers(publicationID, number, page);
        }


        #region IPublicationService Members


        /// <summary>
        /// Searches the publication with text.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="text">The text.</param>
        /// <returns>List of publications with text</returns>
        public List<XareuServices.Model.Publication.Publication> SearchPublicationWithText(long userID, Guid token, out Guid newToken, int number, int page, string text)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    return publicationDAO.SearchPublicationWithText(text, number, page);
                }
                catch
                {
                    throw new Exception("Searching publication error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Adds the publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publication">The publication.</param>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns></returns>
        public bool AddPublication(long userID, Guid token, out Guid newToken, XareuServices.Model.Publication.Publication publication, out long publicationID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (publication.Author.Id == userID)
                    {
                        publicationDAO.AddPublication(publication, out publicationID);
                        return true;
                    }
                    throw new Exception("User is not able to add that publication");
                }
                catch
                {
                    throw new Exception("Adding publication error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Edits the publication.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="publication">The publication.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool EditPublication(long userID, Guid token, out Guid newToken, XareuServices.Model.Publication.Publication publication)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if ((publicationDAO.GetPublication(publication.Id).Author.Id == userID)||(userDAO.IsAdmin(userID)))
                    {
                        publicationDAO.EditPublication(publication);
                        return true;
                    }
                    throw new Exception("User is not able to edit that publication");
                }
                catch
                {
                    throw new Exception("Edit publication error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the user publications.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="questions">if set to <c>true</c> [questions].</param>
        /// <param name="publications">if set to <c>true</c> [publications].</param>
        /// <returns>List of user's publications</returns>
        public List<XareuServices.Model.Publication.Publication> GetUserPublications(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page, bool questions, bool publications)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    return publicationDAO.GetUserPublications(userAuthorID, number, page, questions, publications);
                }
                catch
                {
                    throw new Exception("Getting user publications error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the publications for user.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <param name="questions">if set to <c>true</c> [questions].</param>
        /// <param name="publications">if set to <c>true</c> [publications].</param>
        /// <returns>List of publications for a user</returns>
        public List<XareuServices.Model.Publication.Publication> GetPublicationsForUser(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page, bool questions, bool publications)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID)
                    {
                        return publicationDAO.GetPublicationsForUser(userAuthorID, number, page, questions, publications);
                    }
                    throw new Exception("User is not able to get another user publications");
                }
                catch
                {
                    throw new Exception("Getting publications for user error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the publications for group.
        /// </summary>
        /// <param name="groupID">The group ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of publications for a group</returns>
        public List<Model.Publication.Publication> GetPublicationsForGroup(long groupID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            if (loginService.UseToken(userAuthorID, token, out newToken))
            {
                try
                {
                    //***** AQUÍ SE DEBERÍA COMPROBAR SI EL USUARIO ESTÁ SUCRITO AL GRUPO
                    //***** DE MOMENTO SE DEJA LISTAR LAS PUBLICACIONES PORQUE TODOS LOS GRUPOS SERÁN ABIERTOS
                    return publicationDAO.SearchPublicationsInGroup(groupID, number, page);
                }
                catch
                {
                    throw new Exception("Getting publications for group error");
                }
            }
            throw new Exception("Login error");
        }

        #endregion
    }
}
