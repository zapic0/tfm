using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XareuServices.API
{

    /// <summary>
    /// Services that operate over Votes options
    /// </summary>
    [ServiceContract]
    public interface IVoteService
    {
        /// <summary>
        /// Gets the vote.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="voteID">The vote ID.</param>
        /// <returns>Vote</returns>
        [OperationContract]
        Model.Vote.Vote GetVote(long userID, Guid token, out Guid newToken, long voteID);

        /// <summary>
        /// Gets the votes for publication.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of votes</returns>
        [OperationContract]
        List<Model.Vote.Vote> GetVotesForPublication(long publicationID, int number, int page);

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
        [OperationContract]
        List<Model.Vote.Vote> GetUserVotes(long userID, Guid token, out Guid newToken, long userAuthorID, int number, int page);

        /// <summary>
        /// Gets the votes number.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>Votes number</returns>
        [OperationContract]
        int GetVotesNumber(long publicationID);

        /// <summary>
        /// Gets the positive votes number.
        /// </summary>
        /// <param name="publicationID">The publication ID.</param>
        /// <returns>Positive votes number</returns>
        [OperationContract]
        int GetPositiveVotesNumber(long publicationID);

        /// <summary>
        /// Adds the vote.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="vote">The vote.</param>
        /// <param name="voteID">The vote ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool AddVote(long userID, Guid token, out Guid newToken, Model.Vote.Vote vote, out long voteID);

        /// <summary>
        /// Deletes the vote.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="token">The token.</param>
        /// <param name="newToken">The new token.</param>
        /// <param name="voteID">The vote ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        [OperationContract]
        bool DeleteVote(long userID, Guid token, out Guid newToken, long voteID);
    }
}
