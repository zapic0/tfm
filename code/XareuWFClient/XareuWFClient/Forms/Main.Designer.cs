using XareuWFClient.Controls.Main;
using XareuWFClient.Controls.Util;
using XareuWFClient.Controls.ControlPanel;
namespace XareuWFClient.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.userInformationPanel = new XareuWFClient.Controls.Main.UserInformation();
            this.searchControl = new XareuWFClient.Controls.Util.SearchControl();
            this.pHead = new System.Windows.Forms.Panel();
            this.pNavigation = new System.Windows.Forms.Panel();
            this.bNavitationRight = new System.Windows.Forms.Button();
            this.bNavigationLeft = new System.Windows.Forms.Button();
            this.pContent = new System.Windows.Forms.Panel();
            this.pSectionsContainer = new System.Windows.Forms.Panel();
            this.bTabsMain = new XareuWFClient.Controls.Tabs.ButtonTabs();
            this.pHead.SuspendLayout();
            this.pNavigation.SuspendLayout();
            this.pSectionsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInformationPanel
            // 
            this.userInformationPanel.BackColor = System.Drawing.Color.Transparent;
            this.userInformationPanel.Location = new System.Drawing.Point(3, 2);
            this.userInformationPanel.Name = "userInformationPanel";
            this.userInformationPanel.Size = new System.Drawing.Size(253, 98);
            this.userInformationPanel.TabIndex = 4;
            this.userInformationPanel.ViewUser += new XareuWFClient.Controls.Main.UserInformation.ViewUserHandler(this.userInformationPanel_ViewUser);
            // 
            // searchControl
            // 
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl.BackColor = System.Drawing.Color.Transparent;
            this.searchControl.Location = new System.Drawing.Point(259, 3);
            this.searchControl.Name = "searchControl";
            this.searchControl.Size = new System.Drawing.Size(262, 87);
            this.searchControl.TabIndex = 5;
            // 
            // pHead
            // 
            this.pHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pHead.BackColor = System.Drawing.Color.Transparent;
            this.pHead.Controls.Add(this.pNavigation);
            this.pHead.Controls.Add(this.userInformationPanel);
            this.pHead.Controls.Add(this.searchControl);
            this.pHead.Location = new System.Drawing.Point(226, 31);
            this.pHead.Name = "pHead";
            this.pHead.Size = new System.Drawing.Size(632, 102);
            this.pHead.TabIndex = 6;
            // 
            // pNavigation
            // 
            this.pNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pNavigation.Controls.Add(this.bNavitationRight);
            this.pNavigation.Controls.Add(this.bNavigationLeft);
            this.pNavigation.Location = new System.Drawing.Point(555, 58);
            this.pNavigation.Name = "pNavigation";
            this.pNavigation.Padding = new System.Windows.Forms.Padding(5);
            this.pNavigation.Size = new System.Drawing.Size(74, 41);
            this.pNavigation.TabIndex = 8;
            // 
            // bNavitationRight
            // 
            this.bNavitationRight.BackgroundImage = global::XareuWFClient.Properties.Resources.navegacionDerecha;
            this.bNavitationRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNavitationRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNavitationRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNavitationRight.FlatAppearance.BorderSize = 0;
            this.bNavitationRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavitationRight.Location = new System.Drawing.Point(36, 5);
            this.bNavitationRight.Name = "bNavitationRight";
            this.bNavitationRight.Size = new System.Drawing.Size(33, 31);
            this.bNavitationRight.TabIndex = 7;
            this.bNavitationRight.UseVisualStyleBackColor = true;
            // 
            // bNavigationLeft
            // 
            this.bNavigationLeft.BackgroundImage = global::XareuWFClient.Properties.Resources.navegacionIzquierda;
            this.bNavigationLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNavigationLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNavigationLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.bNavigationLeft.FlatAppearance.BorderSize = 0;
            this.bNavigationLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavigationLeft.Location = new System.Drawing.Point(5, 5);
            this.bNavigationLeft.Name = "bNavigationLeft";
            this.bNavigationLeft.Size = new System.Drawing.Size(31, 31);
            this.bNavigationLeft.TabIndex = 6;
            this.bNavigationLeft.UseVisualStyleBackColor = true;
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.Color.Transparent;
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 166);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(860, 396);
            this.pContent.TabIndex = 9;
            // 
            // pSectionsContainer
            // 
            this.pSectionsContainer.Controls.Add(this.bTabsMain);
            this.pSectionsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSectionsContainer.Location = new System.Drawing.Point(0, 105);
            this.pSectionsContainer.Name = "pSectionsContainer";
            this.pSectionsContainer.Size = new System.Drawing.Size(860, 61);
            this.pSectionsContainer.TabIndex = 13;
            // 
            // bTabsMain
            // 
            this.bTabsMain.BackColor = System.Drawing.Color.Transparent;
            this.bTabsMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bTabsMain.BackgroundImage")));
            this.bTabsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTabsMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bTabsMain.Location = new System.Drawing.Point(0, 31);
            this.bTabsMain.Name = "bTabsMain";
            this.bTabsMain.Selected = null;
            this.bTabsMain.Size = new System.Drawing.Size(860, 30);
            this.bTabsMain.TabIndex = 13;
            this.bTabsMain.AddNewPublication += new XareuWFClient.Controls.Tabs.ButtonTabs.AddNewPublicationHandler(this.bTabsMain_AddNewPublication);
            this.bTabsMain.SelectNewPublicationsTab += new XareuWFClient.Controls.Tabs.ButtonTabs.SelectNewPublicationsTabHandler(this.bTabsMain_SelectNewPublicationsTab);
            this.bTabsMain.SelectMyInterestsTab += new XareuWFClient.Controls.Tabs.ButtonTabs.SelectMyInterestsTabHandler(this.bTabsMain_SelectMyInterestsTab);
            this.bTabsMain.SelectMyPublicationsTab += new XareuWFClient.Controls.Tabs.ButtonTabs.SelectMyPublicationsTabHandler(this.bTabsMain_SelectMyPublicationsTab);
            this.bTabsMain.SelectControlPanelTab += new XareuWFClient.Controls.Tabs.ButtonTabs.SelectControlPanelTabHandler(this.bTabsMain_SelectControlPanelTab);
            this.bTabsMain.SelectPublicationsTab += new XareuWFClient.Controls.Tabs.ButtonTabs.SelectPublicationsTabHandler(this.bTabsMain_SelectPublicationsTab);
            this.bTabsMain.SelectGroupsTab += new XareuWFClient.Controls.Tabs.ButtonTabs.SelectGroupsTabHandler(this.bTabsMain_SelectGroupsTab);
            this.bTabsMain.SelectTagsTab += new XareuWFClient.Controls.Tabs.ButtonTabs.SelectTagsTabHandler(this.bTabsMain_SelectTagsTab);
            this.bTabsMain.SelectUsersTab += new XareuWFClient.Controls.Tabs.ButtonTabs.SelectUsersTabHandler(this.bTabsMain_SelectUsersTab);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 562);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pHead);
            this.Controls.Add(this.pSectionsContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Controls.SetChildIndex(this.pSectionsContainer, 0);
            this.Controls.SetChildIndex(this.pHead, 0);
            this.Controls.SetChildIndex(this.pContent, 0);
            this.pHead.ResumeLayout(false);
            this.pNavigation.ResumeLayout(false);
            this.pSectionsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XareuWFClient.Controls.Main.UserInformation userInformationPanel;
        private XareuWFClient.Controls.Util.SearchControl searchControl;
        private System.Windows.Forms.Panel pHead;
        private XareuWFClient.Controls.Main.PublicationColumns publicationColumns;
        private System.Windows.Forms.Panel pContent;
        private Controls.ControlPanel.ControlPanel controlPanel;
        private System.Windows.Forms.Panel pSectionsContainer;
        private Controls.Tabs.ButtonTabs bTabsMain;
        private System.Windows.Forms.Button bNavigationLeft;
        private System.Windows.Forms.Panel pNavigation;
        private System.Windows.Forms.Button bNavitationRight;

    }
}
