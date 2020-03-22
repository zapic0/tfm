using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.VoteDAO
{
    public class VoteDAO : IVoteDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoteDAO"/> class.
        /// </summary>
        public VoteDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }
        
        #region IVoteDAO Members

        /// <summary>
        /// Gets the vote.
        /// </summary>
        /// <param name="voteId">The vote id.</param>
        /// <returns>Vote</returns>
        public XareuServices.Model.Vote.Vote GetVote(long voteId)
        {
            var query = from votes in data.votes
                        where votes.vote_id == voteId
                        select votes;

            try
            {
                return this.getVote(query.First<vote>());
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the votes for publication.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of votes</returns>
        public List<XareuServices.Model.Vote.Vote> GetVotesForPublication(long publicationId, int number, int page)
        {
            List<Model.Vote.Vote> votesList = new List<XareuServices.Model.Vote.Vote>();

            var query = (from votes in data.votes
                        where votes.vote_publication == publicationId
                        select votes).Skip<vote>(number*page).Take<vote>(number);

            foreach (vote vote in query)
            {
                try
                {
                    votesList.Add(this.getVote(vote));
                }
                catch { }
            }

            return votesList;
        }

        /// <summary>
        /// Gets the user votes.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="number">The number.</param>
        /// <param name="page">The page.</param>
        /// <returns>List of votes</returns>
        public List<XareuServices.Model.Vote.Vote> GetUserVotes(long userId, int number, int page)
        {
            List<Model.Vote.Vote> userVotesList = new List<XareuServices.Model.Vote.Vote>();

            var query = (from votes in data.votes
                         where votes.vote_author == userId
                         select votes).Skip<vote>(number * page).Take<vote>(number);

            foreach (vote vote in query)
            {
                try
                {
                    userVotesList.Add(this.getVote(vote));
                }
                catch { }
            }

            return userVotesList;
        }

        /// <summary>
        /// Gets the votes number.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>Number of votes</returns>
        public int GetVotesNumber(long publicationId)
        {
            var query =  from votes in data.votes
                         where votes.vote_publication == publicationId
                         select votes;
            
            return query.Count<vote>();
        }

        /// <summary>
        /// Gets the positive votes number.
        /// </summary>
        /// <param name="publicationId">The publication id.</param>
        /// <returns>Number of positive votes</returns>
        public int GetPositiveVotesNumber(long publicationId)
        {
            var query =  from votes in data.votes
                         where votes.vote_publication == publicationId
                         where votes.vote_positive == true
                         select votes;

            return query.Count<vote>();
        }

        /// <summary>
        /// Adds the vote.
        /// </summary>
        /// <param name="vote">The vote.</param>
        /// <param name="voteID">The vote ID.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool AddVote(XareuServices.Model.Vote.Vote vote, out long voteID)
        {
            voteID = 0;
            Linq.vote newVote = new vote();

            try
            {
                newVote.vote_publication = vote.Publication.Id;
                newVote.vote_karma = vote.Karma;
                newVote.vote_author = vote.Author.Id;
                newVote.vote_positive = vote.Positive;
                data.votes.InsertOnSubmit(newVote);
                data.SubmitChanges();
                voteID = this.getLastVoteID();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes the vote.
        /// </summary>
        /// <param name="voteId">The vote id.</param>
        /// <returns>True if it was OK, false otherwise</returns>
        public bool DeleteVote(long voteId)
        {
            var query = from votes in data.votes
                        where votes.vote_id == voteId
                        select votes;

            try
            {
                data.votes.DeleteOnSubmit(query.First<vote>());
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Gets the last vote ID.
        /// </summary>
        /// <returns></returns>
        private long getLastVoteID()
        {
            try
            {
                IEnumerable<vote> vote = from votes in data.votes
                                         select votes;

                return vote.Last<vote>().vote_id;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the vote.
        /// </summary>
        /// <param name="vote">The vote.</param>
        /// <returns></returns>
        private Model.Vote.Vote getVote(vote vote)
        {
            Model.Vote.Vote newVote = new XareuServices.Model.Vote.Vote();

            newVote.Author.Id = vote.vote_author;
            newVote.Author.Nick = vote.user.user_nick;
            newVote.Id = vote.vote_id;
            newVote.Karma = vote.vote_karma;
            newVote.Publication.Id = vote.publication.publication_id;
            newVote.Publication.Author.Id = vote.publication.user.user_id;
            newVote.Publication.Text = vote.publication.publication_text;
            newVote.Publication.Karma = vote.publication.publication_karma;
            try { newVote.Publication.IsQuestion = (bool)vote.publication.publication_is_question; }
            catch { newVote.Publication.IsQuestion = false; }
            newVote.Publication.IsPrivate = vote.publication.publlication_is_private;

            return newVote;
        }
    }
}
