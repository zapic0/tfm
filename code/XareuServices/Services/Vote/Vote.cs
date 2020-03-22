using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.Services.Vote
{
    public class Vote : API.IVoteService
    {

        Services.Login.Login loginService = new XareuServices.Services.Login.Login();
        DAL.Linq.VoteDAO.VoteDAO voteDAO = new XareuServices.DAL.Linq.VoteDAO.VoteDAO();
        DAL.Linq.UserDAO.UserDAO userDAO = new XareuServices.DAL.Linq.UserDAO.UserDAO();

        #region IVoteService Members

        /// <summary>
        /// Gets the vote.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="voteID">The vote ID.</param>
        /// <returns>Vote</returns>
        public XareuServices.Model.Vote.Vote GetVote(long userID, Guid token, out Guid newToken, long voteID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    return voteDAO.GetVote(voteID);
                }
                catch
                {
                    throw new Exception("Getting vote error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the votes for publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of votes</returns>
        public List<XareuServices.Model.Vote.Vote> GetVotesForPublication(long publicationID, int number, int page)
        {
            try
            {
                return voteDAO.GetVotesForPublication(publicationID, number, page);
            }
            catch
            {
                throw new Exception("Getting votes for publication error");
            }
        }

        /// <summary>
        /// Gets the user votes.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="userAuthorID">The user author ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of votes</returns>
        public List<XareuServices.Model.Vote.Vote> GetUserVotes(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    if (userID == userAuthorID || userDAO.IsAdmin(userID))
                    {
                        return voteDAO.GetUserVotes(userAuthorID, number, page);
                    }
                }
                catch
                {
                    throw new Exception("Getting user votes error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Gets the votes number.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>Votes number</returns>
        public int GetVotesNumber(long publicationID)
        {
            try
            {
                return voteDAO.GetVotesNumber(publicationID);
            }
            catch
            {
                throw new Exception("Getting votes number for publication error");
            }
        }

        /// <summary>
        /// Gets the positive votes number.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>Positive votes number</returns>
        public int GetPositiveVotesNumber(long publicationID)
        {
            try
            {
                return voteDAO.GetPositiveVotesNumber(publicationID);
            }
            catch
            {
                throw new Exception("Getting positive votes for publication error");
            }
        }

        /// <summary>
        /// Adds the vote.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="vote">The vote.</param>
        /// <param name="voteID">The vote ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddVote(long userID, Guid token, out Guid newToken, XareuServices.Model.Vote.Vote vote, out long voteID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    return voteDAO.AddVote(vote, out voteID);
                }
                catch
                {
                    throw new Exception("Vote error");
                }
            }
            throw new Exception("Login error");
        }

        /// <summary>
        /// Deletes the vote.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="voteID">The vote ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteVote(long userID, Guid token, out Guid newToken, long voteID)
        {
            if (loginService.UseToken(userID, token, out newToken))
            {
                try
                {
                    return voteDAO.DeleteVote(voteID);
                }
                catch
                {
                    throw new Exception("Deleting vote error");
                }
            }
            throw new Exception("Login error");
        }

        #endregion
    }
}
