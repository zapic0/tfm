using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XareuWFClient.Args;

namespace XareuWFClient.Delegates
{
    public class Delegates
    {

        #region User
        /// <summary>
        /// Open user publications results Handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="args">Args with user data</param>
        public delegate void OpenUserResultsHandler(object sender, UsersArgs args);


        /// <summary>
        /// Follow a user handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="args">Args with user data</param>
        public delegate void FollowUserHandler(object sender, UsersArgs args);

        /// <summary>
        /// Searchs users for an especified text handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="args">Args with user data</param>
        public delegate void SearchTextHandler(object sender, UsersArgs args);
        #endregion

        #region Tags
        /// <summary>
        /// Open tag publications results Handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="args">Args with tag data</param>
        public delegate void OpenTagResultsHandler(object sender, TagsArgs args);

        /// <summary>
        /// Subscribe to a tag handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="args">Args with tag data</param>
        public delegate void SubscribeToTagHandler(object sender, TagsArgs args);
        #endregion


        #region Groups
        /// <summary>
        /// Open group publications results handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="args">Args with group data</param>
        public delegate void OpenGroupResultsHandler(object sender, GroupsArgs args);

        /// <summary>
        /// Subscribe to a group handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="args">Args with group data</param>
        public delegate void SubscribeToGroupHandler(object sender, GroupsArgs args);

        #endregion

        #region Publications

        /// <summary>
        /// Open publication page handler
        /// </summary>
        public delegate void OpenPublicationPageHandler(object sender, PublicationArgs args);

        #endregion
    }
}
