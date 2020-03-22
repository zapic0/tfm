using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Services.Login
{
    public class Login
    {
        DAL.Linq.TokenDAO.TokenDAO tokenDAO = new XareuServices.DAL.Linq.TokenDAO.TokenDAO();
        DAL.Linq.UserDAO.UserDAO userDAO = new XareuServices.DAL.Linq.UserDAO.UserDAO();

        /// <summary>
        /// Gets the new token.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="userPassword">The user password.</param>
        /// <returns></returns>
        public Guid GetNewToken(string userEmail, string userPassword)
        {
            long userID = userDAO.GetUserID(userEmail, userPassword);
            return tokenDAO.GetNewSecurityToken(userID);
        }

        /// <summary>
        /// Logins the email.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="securityToken">The security token.</param>
        /// <param name="newSecurityToken">The new security token.</param>
        /// <returns></returns>
        public Model.User.User LoginEmail(string userEmail, Guid securityToken, out Guid newSecurityToken)
        {
            Model.User.User user = userDAO.GetUserByEmail(userEmail);
            try
            {
                if (tokenDAO.TrySecurityToken(user.Id, securityToken))
                {
                    tokenDAO.InvalidateSecurityToken(user.Id);
                    newSecurityToken = tokenDAO.GetNewSecurityToken(user.Id);
                    return user;
                }
                else
                {
                    newSecurityToken = Guid.Empty;
                    return null;
                }
            }
            catch
            {
                newSecurityToken = Guid.Empty;
                return null;
            }
        }

        /// <summary>
        /// Uses the token.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="securityToken">The security token.</param>
        /// <param name="newSecurityToken">The new security token.</param>
        /// <returns></returns>
        public bool UseToken(long userID, Guid securityToken, out Guid newSecurityToken)
        {
            if (tokenDAO.TrySecurityToken(userID, securityToken))
            {
                newSecurityToken = tokenDAO.GetSecurityToken(userID).Value;
                return true;
            }
            else
            {
                newSecurityToken = Guid.Empty;
                return false;
            }
        }
    }
}
