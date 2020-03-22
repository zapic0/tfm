using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XareuWFClient.Controls.Main
{
    public partial class BigTabs : UserControl
    {
        #region Events
        [Category("User Defined")]
        [Description("Selects the Work Tab")]
        public event SelectWorkTabHandler SelectWorkTab;

        [Category("User Defined")]
        [Description("Selects the My Interests Tab")]
        public event SelectMyInterestsTabHandler SelectMyInterestsTab;

        [Category("User Defined")]
        [Description("Selects the My Publications Tab")]
        public event SelectMyPublicationsTabHandler SelectMyPublicationsTab;

        [Category("User Defined")]
        [Description("Opens the new publication form")]
        public event AddNewPublicationHandler AddNewPublication;

        #endregion



        #region Delegates
        public delegate void SelectWorkTabHandler(object sender, EventArgs args);
        public delegate void SelectMyInterestsTabHandler(object sender, EventArgs args);
        public delegate void SelectMyPublicationsTabHandler(object sender, EventArgs args);
        public delegate void AddNewPublicationHandler(object sender, EventArgs args);

        #endregion


        /// <summary>
        /// Initializes a new instance of the <see cref="BigTabs"/> class.
        /// </summary>
        public BigTabs()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Handles the Click event of the bAddTab control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void bAddTab_Click(object sender, EventArgs e)
        {
            this.AddNewPublication(this, null);
        }

        /// <summary>
        /// Handles the Click event of the lMyPublications control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void lMyPublications_Click(object sender, EventArgs e)
        {
            this.SelectMyPublicationsTabAppearance();
        }

        /// <summary>
        /// Handles the Click event of the lWorkTitle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void lWorkTitle_Click(object sender, EventArgs e)
        {
            this.SelectWorkTabAppearance();
        }

        /// <summary>
        /// Handles the Click event of the lMyInterests control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void lMyInterests_Click(object sender, EventArgs e)
        {
            this.SelectMyInterestsTabAppearance();
        }


        /// <summary>
        /// Selects my publications tab appearance.
        /// </summary>
        public void SelectMyPublicationsTabAppearance()
        {
            //this.lMyPublications.ForeColor = Color.FromArgb(247, 144, 32);
            //this.lWorkTitle.ForeColor = Color.FromArgb(149, 149, 149);
            //this.lMyInterests.ForeColor = Color.FromArgb(149, 149, 149);

            //this.pBMyPublications.Image = XareuWFClient.Properties.Resources.selectedTabLeft;
            //this.pBMyInterests.Image = XareuWFClient.Properties.Resources.tabCorner;
            //this.pBWork.Image = XareuWFClient.Properties.Resources.tabCorner;

            //this.pMyPublications.BackgroundImage = XareuWFClient.Properties.Resources.backgroundSelectedTabTop;
            //this.pMyInterests.BackgroundImage = XareuWFClient.Properties.Resources.backgroundUnselectedTab;
            //this.pWork.BackgroundImage = XareuWFClient.Properties.Resources.backgroundUnselectedTab;

            //this.SelectMyPublicationsTab(this, null);
        }

        /// <summary>
        /// Selects my interests tab appearance.
        /// </summary>
        public void SelectMyInterestsTabAppearance()
        {
            //this.lMyPublications.ForeColor = Color.FromArgb(149, 149, 149);
            //this.lWorkTitle.ForeColor = Color.FromArgb(149, 149, 149);
            //this.lMyInterests.ForeColor = Color.FromArgb(247, 144, 32);

            //this.pBMyPublications.Image = XareuWFClient.Properties.Resources.tabCornerUnselectedLeft;
            //this.pBMyInterests.Image = XareuWFClient.Properties.Resources.selectedTab;
            //this.pBWork.Image = XareuWFClient.Properties.Resources.tabCorner;

            //this.pMyPublications.BackgroundImage = XareuWFClient.Properties.Resources.backgroundUnselectedTab;
            //this.pMyInterests.BackgroundImage = XareuWFClient.Properties.Resources.backgroundSelectedTabTop;
            //this.pWork.BackgroundImage = XareuWFClient.Properties.Resources.backgroundUnselectedTab;

            //this.SelectMyInterestsTab(this, null);
        }

        /// <summary>
        /// Selects the work tab appearance.
        /// </summary>
        public void SelectWorkTabAppearance()
        {
            //this.lMyPublications.ForeColor = Color.FromArgb(149, 149, 149);
            //this.lWorkTitle.ForeColor = Color.FromArgb(247, 144, 32);
            //this.lMyInterests.ForeColor = Color.FromArgb(149, 149, 149);

            //this.pBMyPublications.Image = XareuWFClient.Properties.Resources.tabCornerUnselectedLeft;
            //this.pBMyInterests.Image = XareuWFClient.Properties.Resources.tabCorner;
            //this.pBWork.Image = XareuWFClient.Properties.Resources.selectedTab;

            //this.pMyPublications.BackgroundImage = XareuWFClient.Properties.Resources.backgroundUnselectedTab;
            //this.pMyInterests.BackgroundImage = XareuWFClient.Properties.Resources.backgroundUnselectedTab;
            //this.pWork.BackgroundImage = XareuWFClient.Properties.Resources.backgroundSelectedTabTop;

            //this.SelectWorkTab(this, null);
        }


    }
}
