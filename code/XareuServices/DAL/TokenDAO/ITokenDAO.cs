using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface ITokenDAO
    {
        /// <summary>
        /// Gets the security token.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>Security Token</returns>
        Model.SecurityToken.SecurityToken GetSecurityToken(long userId);

        /// <summary>
        /// Gets the new security token.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>Guid</returns>
        Guid GetNewSecurityToken(long userId);

        /// <summary>
        /// Tries the security token.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="token">The token.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool TrySecurityToken(long userId, Guid token);

        /// <summary>
        /// Invalidates the security token.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool InvalidateSecurityToken(long userId);
    }
}
