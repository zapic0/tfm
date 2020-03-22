using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XareuWFClient.Controls.Tabs
{
    public partial class ButtonTabs : UserControl
    {
        public string Selected { get; set; }

        #region Events
        [Category("User Defined")]
        [Description("Opens the new publication form")]
        public event AddNewPublicationHandler AddNewPublication;

        [Category("User Defined")]
        [Description("Selects the New Publications Tab")]
        public event SelectNewPublicationsTabHandler SelectNewPublicationsTab;

        [Category("User Defined")]
        [Description("Selects the My Interests Tab")]
        public event SelectMyInterestsTabHandler SelectMyInterestsTab;

        [Category("User Defined")]
        [Description("Selects the My Publications Tab")]
        public event SelectMyPublicationsTabHandler SelectMyPublicationsTab;

        [Category("User Defined")]
        [Description("Selects the Control Panel Tab")]
        public event SelectControlPanelTabHandler SelectControlPanelTab;

        [Category("User Defined")]
        [Description("Selects the Publications Tab")]
        public event SelectPublicationsTabHandler SelectPublicationsTab;

        [Category("User Defined")]
        [Description("Selects the Groups Tab")]
        public event SelectGroupsTabHandler SelectGroupsTab;

        [Category("User Defined")]
        [Description("Selects the Tags Tab")]
        public event SelectTagsTabHandler SelectTagsTab;

        [Category("User Defined")]
        [Description("Selects Users Tab")]
        public event SelectUsersTabHandler SelectUsersTab;
        #endregion

        #region Delegates
        public delegate void AddNewPublicationHandler(object sender, EventArgs args);
        
        public delegate void SelectNewPublicationsTabHandler(object sender, EventArgs args);
        public delegate void SelectMyInterestsTabHandler(object sender, EventArgs args);
        public delegate void SelectMyPublicationsTabHandler(object sender, EventArgs args);
        public delegate void SelectControlPanelTabHandler(object sender, EventArgs args);
        public delegate void SelectPublicationsTabHandler(object sender, EventArgs args);
        public delegate void SelectGroupsTabHandler(object sender, EventArgs args);
        public delegate void SelectTagsTabHandler(object sender, EventArgs args);
        public delegate void SelectUsersTabHandler(object sender, EventArgs args);

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonTabs"/> class.
        /// </summary>
        public ButtonTabs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets all as default.
        /// </summary>
        private void setAllAsDefault()
        {
            Color defaultColor = Color.FromArgb(149, 149, 149);

            this.bNewPublications.ForeColor = defaultColor;
            this.bNewPublications.SendToBack();
            this.bMyInterests.ForeColor = defaultColor;
            this.bMyInterests.SendToBack();
            this.bMyPublications.ForeColor = defaultColor;
            this.bMyPublications.SendToBack();
            this.bControlPanel.ForeColor = defaultColor;
            this.bControlPanel.SendToBack();
            this.bPublications.ForeColor = defaultColor;
            this.bPublications.SendToBack();
            this.bGroups.ForeColor = defaultColor;
            this.bGroups.SendToBack();
            this.bTags.ForeColor = defaultColor;
            this.bTags.SendToBack();
            this.bUsers.ForeColor = defaultColor;
            this.bUsers.SendToBack();
            this.underLine.BringToFront();

            this.Selected = "newpublications";
        }

        #region Public
        /// <summary>
        /// Selects my interests.
        /// </summary>
        public void SelectMyInterests()
        {
            this.bMyInterests_Click(this, new EventArgs());
        }

        /// <summary>
        /// Selects the new publications.
        /// </summary>
        public void SelectNewPublications()
        {
            this.bNewPublications_Click(this, new EventArgs());
        }

        /// <summary>
        /// Selects my publications.
        /// </summary>
        public void SelectMyPublications()
        {
            this.bMyPublications_Click(this, new EventArgs());
        }

        /// <summary>
        /// Selects the control panel.
        /// </summary>
        public void SelectControlPanel()
        {
            this.bControlPanel_Click(this, new EventArgs());
        }

        /// <summary>
        /// Selects the publications.
        /// </summary>
        public void SelectPublications()
        {
            this.bPublications_Click(this, new EventArgs());
        }

        /// <summary>
        /// Selects the tags.
        /// </summary>
        public void SelectTags()
        {
            this.bTags_Click(this, new EventArgs());
        }

        /// <summary>
        /// Selects the groups.
        /// </summary>
        public void SelectGroups()
        {
            this.bGroups_Click(this, new EventArgs());
        }

        /// <summary>
        /// Selects the users.
        /// </summary>
        public void SelectUsers()
        {
            this.bUsers_Click(this, new EventArgs());
        }
        #endregion

        #region Buttons
        /// <summary>
        /// Handles the Click event of the bMyInterests control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bMyInterests_Click(object sender, EventArgs e)
        {
            this.setAllAsDefault();
            this.bMyInterests.ForeColor=Color.FromArgb(247, 144, 32);
            this.bMyInterests.BringToFront();
            this.SelectMyInterestsTab(sender, e);
            this.Selected = "myinterests";
        }

        /// <summary>
        /// Handles the Click event of the bNewPublications control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bNewPublications_Click(object sender, EventArgs e)
        {
            this.setAllAsDefault();
            this.bNewPublications.ForeColor = Color.FromArgb(247, 144, 32);
            this.bNewPublications.BringToFront();
            this.SelectNewPublicationsTab(sender, e);
            this.Selected = "newpublications";
        }

        /// <summary>
        /// Handles the Click event of the bMyPublications control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bMyPublications_Click(object sender, EventArgs e)
        {
            this.setAllAsDefault();
            this.bMyPublications.ForeColor = Color.FromArgb(247, 144, 32);
            this.bMyPublications.BringToFront();
            this.SelectMyPublicationsTab(sender, e);
            this.Selected = "mypublications";
        }

        /// <summary>
        /// Handles the Click event of the bControlPanel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bControlPanel_Click(object sender, EventArgs e)
        {
            this.setAllAsDefault();
            this.bControlPanel.ForeColor = Color.FromArgb(247, 144, 32);
            this.bControlPanel.BringToFront();
            this.SelectControlPanelTab(sender, e);
            this.Selected = "controlpanel";
        }

        /// <summary>
        /// Handles the Click event of the bPublications control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bPublications_Click(object sender, EventArgs e)
        {
            this.setAllAsDefault();
            this.bPublications.ForeColor = Color.FromArgb(247, 144, 32);
            this.bPublications.BringToFront();
            this.SelectPublicationsTab(sender, e);
            this.Selected = "publications";
        }

        /// <summary>
        /// Handles the Click event of the bGroups control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bGroups_Click(object sender, EventArgs e)
        {
            this.setAllAsDefault();
            this.bGroups.ForeColor = Color.FromArgb(247, 144, 32);
            this.bGroups.BringToFront();
            this.SelectGroupsTab(sender, e);
            this.Selected = "groups";
        }

        /// <summary>
        /// Handles the Click event of the bTags control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bTags_Click(object sender, EventArgs e)
        {
            this.setAllAsDefault();
            this.bTags.ForeColor = Color.FromArgb(247, 144, 32);
            this.bTags.BringToFront();
            this.SelectTagsTab(sender, e);
            this.Selected = "tags";
        }

        /// <summary>
        /// Handles the Click event of the bUsers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bUsers_Click(object sender, EventArgs e)
        {
            this.setAllAsDefault();
            this.bUsers.ForeColor = Color.FromArgb(247, 144, 32);
            this.bUsers.BringToFront();
            this.SelectUsersTab(sender, e);
            this.Selected = "users";
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the bAddPublication control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bAddPublication_Click(object sender, EventArgs e)
        {
            this.AddNewPublication(sender, e);
        }
    }
}
