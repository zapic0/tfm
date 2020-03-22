using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.TokenDAO
{
    public class TokenDAO : ITokenDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenDAO"/> class.
        /// </summary>
        public TokenDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region ITokenDAO Members

        /// <summary>
        /// Gets the security token.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>Security Token</returns>
        public XareuServices.Model.SecurityToken.SecurityToken GetSecurityToken(long userId)
        {
            try
            {
                data.Connection.Open();
                var query = from tokens in data.tokens
                            where tokens.user_id == userId
                            select tokens;
                return this.getSecurityToken(query.First<token>());
            }
            catch
            {
                data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
                return null;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        /// <summary>
        /// Gets the new security token.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>Guid</returns>
        public Guid GetNewSecurityToken(long userId)
        {
            try
            {
                data.Connection.Open();
                var query = from tokens in data.tokens
                            where tokens.user_id == userId
                            select tokens;
                Guid newGuid = Guid.NewGuid();
                token newToken = query.First<token>();
                newToken.token1 = newGuid;
                newToken.token_was_used = false;
                data.SubmitChanges();
                return newGuid;
            }
            catch
            {
                try
                {
                    token newToken = new token();
                    newToken.user_id = userId;
                    newToken.token_was_used = false;
                    newToken.token1 = Guid.NewGuid();
                    data.tokens.InsertOnSubmit(newToken);
                    data.SubmitChanges();
                    return newToken.token1;
                }
                catch
                {
                    data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
                    return Guid.Empty;
                }
            }
            finally
            {
                data.Connection.Close();
            }
        }

        /// <summary>
        /// Tries the security token.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="token">The token.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool TrySecurityToken(long userId, Guid token)
        {
            try
            {
                data.Connection.Open();
                IEnumerable<token> query = from tokens in data.tokens
                                           where tokens.user_id == userId
                                           where tokens.token1 == token
                                           select tokens;

                Linq.token oldToken = query.First<token>();
                if (!oldToken.token_was_used)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        /// <summary>
        /// Invalidates the security token.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool InvalidateSecurityToken(long userId)
        {
            try
            {
                data.Connection.Open();
                var query = from tokens in data.tokens
                            where tokens.user_id == userId
                            select tokens;
                query.First<token>().token_was_used = true;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
                return false;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        #endregion

        /// <summary>
        /// Gets the security token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        private Model.SecurityToken.SecurityToken getSecurityToken(token token)
        {
            Model.SecurityToken.SecurityToken newSecurityToken = new XareuServices.Model.SecurityToken.SecurityToken();

            newSecurityToken.Value = token.token1;
            newSecurityToken.Id = token.token_id;
            newSecurityToken.Used = token.token_was_used;
            newSecurityToken.User.Id = token.user_id;
            newSecurityToken.User.Nick = token.user.user_nick;

            return newSecurityToken;
        }
    }
}
