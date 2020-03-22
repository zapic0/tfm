using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IVoteDAO
    {
        /// <summary>
        /// Gets the vote.
        /// </summary>
        /// <param name="voteId">The vote id.</param>
        /// <returns>Vote</returns>
        Model.Vote.Vote GetVote(long voteId);

        /// <summary>
        /// Gets the votes for publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of votes</returns>
        List<Model.Vote.Vote> GetVotesForPublication(long publicationId, int number, int page);

        /// <summary>
        /// Gets the user votes.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of votes</returns>
        List<Model.Vote.Vote> GetUserVotes(long userId, int number, int page);

        /// <summary>
        /// Gets the votes number.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>Number of votes</returns>
        int GetVotesNumber(long publicationId);

        /// <summary>
        /// Gets the positive votes number.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>Number of positive votes</returns>
        int GetPositiveVotesNumber(long publicationId);

        /// <summary>
        /// Adds the vote.
        /// </summary>
        /// <param name="vote">The vote.</param>
        /// <param name="voteID">The vote ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool AddVote(Model.Vote.Vote vote, out long voteID);

        /// <summary>
        /// Deletes the vote.
        /// </summary>
        /// <param name="voteId">The vote id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        bool DeleteVote(long voteId);
    }
}
