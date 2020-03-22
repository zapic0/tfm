using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{    
    /// <summary>
    /// Services that operate over Login options 
    /// </summary>
    [ServiceContract]
    public interface ILoginService
    {
        /// <summary>
        /// Gets the new token.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="userPassword">The user password.</param>
        /// <returns>A new Token</returns>
        [OperationContract]
        Guid GetNewToken(string userEmail, string userPassword);

        /// <summary>
        /// Logins the specified user email.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="securityToken">The security token.</param>
        /// <param name="newSecurityToken">The new security token.</param>
        /// <returns>User logged data</returns>
        [OperationContract]
        Model.User.User Login(string userEmail, Guid securityToken, out Guid newSecurityToken);
    }
}
