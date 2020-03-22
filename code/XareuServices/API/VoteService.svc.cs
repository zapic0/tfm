using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{
    // NOTE: If you change the class name "VoteService" here, you must also update the reference to "VoteService" in Web.config.
    /// <summary>
    /// Services that operate over Votes options
    /// </summary>
    public class VoteService : IVoteService
    {
        Services.Vote.Vote voteService = new XareuServices.Services.Vote.Vote();

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
            return voteService.GetVote(userID, token, out newToken, voteID);
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
            return voteService.GetVotesForPublication(publicationID, number, page);
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
            return voteService.GetUserVotes(userID, token, out newToken, userAuthorID, number, page);
        }

        /// <summary>
        /// Gets the votes number.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>Votes number</returns>
        public int GetVotesNumber(long publicationID)
        {
            return voteService.GetVotesNumber(publicationID);
        }

        /// <summary>
        /// Gets the positive votes number.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>Positive votes number</returns>
        public int GetPositiveVotesNumber(long publicationID)
        {
            return voteService.GetPositiveVotesNumber(publicationID);
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
            return voteService.AddVote(userID, token, out newToken, vote, out voteID);
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
            return voteService.DeleteVote(userID, token, out newToken, voteID);
        }

        #endregion
    }
}
