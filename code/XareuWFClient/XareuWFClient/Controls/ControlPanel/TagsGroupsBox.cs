using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XareuWFClient.Args;

namespace XareuWFClient.Controls.ControlPanel
{
    public partial class TagsGroupsBox : UserControl
    {
        Font font;

        #region Events
        [Category("User Defined")]
        [Description("Create new Group")]
        public event CreateNewGroupHandler CreateNewGroup;

        [Category("User Defined")]
        [Description("Subscribe to a new Tag")]
        public event XareuWFClient.Delegates.Delegates.SubscribeToTagHandler SubscribeToTag;
        #endregion



        #region Delegates
        public delegate void CreateNewGroupHandler(object sender, EventArgs args);

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsGroupsBox"/> class.
        /// </summary>
        public TagsGroupsBox()
        {
            InitializeComponent();
            this.font = new Font("Tahoma", 11);
        }

        /// <summary>
        /// Adds the group to list.
        /// </summary>
        public void AddGroupToList()
        {
            LinkLabel newGroup = new LinkLabel();
            newGroup.Font = this.font;
            newGroup.ForeColor = Color.FromArgb(247, 144, 32);
            this.fLPGroups.Controls.Add(newGroup);
        }

        /// <summary>
        /// Adds the tag to list.
        /// </summary>
        public void AddTagToList()
        {
            LinkLabel newTag = new LinkLabel();
            newTag.Font = this.font;
            newTag.ForeColor = Color.FromArgb(247, 144, 32);
            this.fLPTags.Controls.Add(newTag);
        }

        /// <summary>
        /// Loads the subscribed tags.
        /// </summary>
        /// <param name="subscribedTags">The subscribed tags.</param>
        public void LoadSubscribedTags(List<Model.Tag.Tag> subscribedTags)
        {
            fLPTags.Controls.Clear();
            foreach (Model.Tag.Tag tag in subscribedTags)
            {
                LinkLabel newLinkLabelTag = new LinkLabel();
                newLinkLabelTag.ForeColor = Color.Black;
                newLinkLabelTag.Font = new System.Drawing.Font("Tahoma", 11);
                newLinkLabelTag.Text = tag.Name;
                fLPTags.Controls.Add(newLinkLabelTag);
            }
        }

        /// <summary>
        /// Loads the own groups.
        /// </summary>
        /// <param name="ownGroups">The own groups.</param>
        public void LoadOwnGroups(List<Model.Group.Group> ownGroups)
        {
            fLPGroups.Controls.Clear();
            foreach (Model.Group.Group group in ownGroups)
            {
                LinkLabel newLinkLabelGroup = new LinkLabel();
                newLinkLabelGroup.ForeColor = Color.Black;
                newLinkLabelGroup.Font = new System.Drawing.Font("Tahoma", 11);
                newLinkLabelGroup.Text = group.Name;
                fLPGroups.Controls.Add(newLinkLabelGroup);
            }
        }

        /// <summary>
        /// Handles the Click event of the bCreateGroup control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bCreateGroup_Click(object sender, EventArgs e)
        {
            this.CreateNewGroup(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the bAddTag control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bAddTag_Click(object sender, EventArgs e)
        {
            TagsArgs newArgs = new TagsArgs("", 0, new Model.Tag.Tag());
            this.SubscribeToTag(sender, newArgs);
        }
    }
}
