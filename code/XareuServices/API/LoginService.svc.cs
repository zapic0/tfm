using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    // NOTE: If you change the class name "LoginService" here, you must also update the reference to "LoginService" in Web.config.
    /// <summary>
    /// Login services
    /// </summary>
    public class LoginService : ILoginService
    {
        Services.Login.Login loginService = new XareuServices.Services.Login.Login();

        #region ILoginService Members

        /// <summary>
        /// Gets the new token.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="userPassword">The user password.</param>
        /// <returns>A new Token</returns>
        public Guid GetNewToken(string userEmail, string userPassword)
        {
            return loginService.GetNewToken(userEmail, userPassword);
        }

        /// <summary>
        /// Logins the specified user email.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="securityToken">The security token.</param>
        /// <param name="newSecurityToken">The new security token.</param>
        /// <returns>User logged data</returns>
        public Model.User.User Login(string userEmail, Guid securityToken, out Guid newSecurityToken)
        {
            return loginService.LoginEmail(userEmail, securityToken, out newSecurityToken);
        }

        #endregion
    }
}
