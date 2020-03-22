namespace XareuWFClient.Controls.Main
{
    partial class BigTabs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTabs = new System.Windows.Forms.Panel();
            this.bAddTab = new System.Windows.Forms.Button();
            this.pMyPublications = new System.Windows.Forms.Panel();
            this.lMyPublications = new System.Windows.Forms.Label();
            this.pBMyPublications = new System.Windows.Forms.PictureBox();
            this.pMyInterests = new System.Windows.Forms.Panel();
            this.lMyInterests = new System.Windows.Forms.Label();
            this.pBMyInterests = new System.Windows.Forms.PictureBox();
            this.pWork = new System.Windows.Forms.Panel();
            this.lWorkTitle = new System.Windows.Forms.Label();
            this.pBWork = new System.Windows.Forms.PictureBox();
            this.pTabs.SuspendLayout();
            this.pMyPublications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMyPublications)).BeginInit();
            this.pMyInterests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMyInterests)).BeginInit();
            this.pWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBWork)).BeginInit();
            this.SuspendLayout();
            // 
            // pTabs
            // 
            this.pTabs.BackColor = System.Drawing.Color.Transparent;
            this.pTabs.BackgroundImage = global::XareuWFClient.Properties.Resources.backgroundTabs;
            this.pTabs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTabs.Controls.Add(this.bAddTab);
            this.pTabs.Controls.Add(this.pMyPublications);
            this.pTabs.Controls.Add(this.pMyInterests);
            this.pTabs.Controls.Add(this.pWork);
            this.pTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTabs.Location = new System.Drawing.Point(0, 0);
            this.pTabs.Name = "pTabs";
            this.pTabs.Size = new System.Drawing.Size(814, 42);
            this.pTabs.TabIndex = 8;
            // 
            // bAddTab
            // 
            this.bAddTab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bAddTab.BackgroundImage = global::XareuWFClient.Properties.Resources.addTab;
            this.bAddTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddTab.ForeColor = System.Drawing.Color.Transparent;
            this.bAddTab.Location = new System.Drawing.Point(24, 1);
            this.bAddTab.Name = "bAddTab";
            this.bAddTab.Size = new System.Drawing.Size(97, 38);
            this.bAddTab.TabIndex = 12;
            this.bAddTab.UseVisualStyleBackColor = true;
            this.bAddTab.Click += new System.EventHandler(this.bAddTab_Click);
            // 
            // pMyPublications
            // 
            this.pMyPublications.BackgroundImage = global::XareuWFClient.Properties.Resources.backgroundUnselectedTab;
            this.pMyPublications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMyPublications.Controls.Add(this.lMyPublications);
            this.pMyPublications.Controls.Add(this.pBMyPublications);
            this.pMyPublications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pMyPublications.Dock = System.Windows.Forms.DockStyle.Right;
            this.pMyPublications.Location = new System.Drawing.Point(127, 0);
            this.pMyPublications.Name = "pMyPublications";
            this.pMyPublications.Size = new System.Drawing.Size(265, 42);
            this.pMyPublications.TabIndex = 10;
            // 
            // lMyPublications
            // 
            this.lMyPublications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lMyPublications.AutoSize = true;
            this.lMyPublications.BackColor = System.Drawing.Color.Transparent;
            this.lMyPublications.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMyPublications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.lMyPublications.Location = new System.Drawing.Point(51, 4);
            this.lMyPublications.Name = "lMyPublications";
            this.lMyPublications.Size = new System.Drawing.Size(212, 35);
            this.lMyPublications.TabIndex = 10;
            this.lMyPublications.Text = "My Publications";
            this.lMyPublications.Click += new System.EventHandler(this.lMyPublications_Click);
            // 
            // pBMyPublications
            // 
            this.pBMyPublications.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBMyPublications.Image = global::XareuWFClient.Properties.Resources.tabCornerUnselectedLeft;
            this.pBMyPublications.Location = new System.Drawing.Point(0, 0);
            this.pBMyPublications.Name = "pBMyPublications";
            this.pBMyPublications.Size = new System.Drawing.Size(49, 42);
            this.pBMyPublications.TabIndex = 0;
            this.pBMyPublications.TabStop = false;
            // 
            // pMyInterests
            // 
            this.pMyInterests.BackgroundImage = global::XareuWFClient.Properties.Resources.backgroundUnselectedTab;
            this.pMyInterests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMyInterests.Controls.Add(this.lMyInterests);
            this.pMyInterests.Controls.Add(this.pBMyInterests);
            this.pMyInterests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pMyInterests.Dock = System.Windows.Forms.DockStyle.Right;
            this.pMyInterests.Location = new System.Drawing.Point(392, 0);
            this.pMyInterests.Name = "pMyInterests";
            this.pMyInterests.Size = new System.Drawing.Size(231, 42);
            this.pMyInterests.TabIndex = 9;
            // 
            // lMyInterests
            // 
            this.lMyInterests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lMyInterests.AutoSize = true;
            this.lMyInterests.BackColor = System.Drawing.Color.Transparent;
            this.lMyInterests.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMyInterests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.lMyInterests.Location = new System.Drawing.Point(51, 4);
            this.lMyInterests.Name = "lMyInterests";
            this.lMyInterests.Size = new System.Drawing.Size(173, 35);
            this.lMyInterests.TabIndex = 9;
            this.lMyInterests.Text = "My Interests";
            this.lMyInterests.Click += new System.EventHandler(this.lMyInterests_Click);
            // 
            // pBMyInterests
            // 
            this.pBMyInterests.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBMyInterests.Image = global::XareuWFClient.Properties.Resources.tabCorner;
            this.pBMyInterests.Location = new System.Drawing.Point(0, 0);
            this.pBMyInterests.Name = "pBMyInterests";
            this.pBMyInterests.Size = new System.Drawing.Size(49, 42);
            this.pBMyInterests.TabIndex = 0;
            this.pBMyInterests.TabStop = false;
            // 
            // pWork
            // 
            this.pWork.BackgroundImage = global::XareuWFClient.Properties.Resources.backgroundSelectedTabTop;
            this.pWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pWork.Controls.Add(this.lWorkTitle);
            this.pWork.Controls.Add(this.pBWork);
            this.pWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pWork.Dock = System.Windows.Forms.DockStyle.Right;
            this.pWork.Location = new System.Drawing.Point(623, 0);
            this.pWork.Name = "pWork";
            this.pWork.Size = new System.Drawing.Size(191, 42);
            this.pWork.TabIndex = 8;
            // 
            // lWorkTitle
            // 
            this.lWorkTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lWorkTitle.AutoSize = true;
            this.lWorkTitle.BackColor = System.Drawing.Color.Transparent;
            this.lWorkTitle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWorkTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lWorkTitle.Location = new System.Drawing.Point(52, 4);
            this.lWorkTitle.Name = "lWorkTitle";
            this.lWorkTitle.Size = new System.Drawing.Size(81, 35);
            this.lWorkTitle.TabIndex = 8;
            this.lWorkTitle.Text = "Work";
            this.lWorkTitle.Click += new System.EventHandler(this.lWorkTitle_Click);
            // 
            // pBWork
            // 
            this.pBWork.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBWork.Image = global::XareuWFClient.Properties.Resources.selectedTab;
            this.pBWork.Location = new System.Drawing.Point(0, 0);
            this.pBWork.Name = "pBWork";
            this.pBWork.Size = new System.Drawing.Size(49, 42);
            this.pBWork.TabIndex = 0;
            this.pBWork.TabStop = false;
            // 
            // BigTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pTabs);
            this.MaximumSize = new System.Drawing.Size(2000, 42);
            this.Name = "BigTabs";
            this.Size = new System.Drawing.Size(814, 42);
            this.pTabs.ResumeLayout(false);
            this.pMyPublications.ResumeLayout(false);
            this.pMyPublications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMyPublications)).EndInit();
            this.pMyInterests.ResumeLayout(false);
            this.pMyInterests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMyInterests)).EndInit();
            this.pWork.ResumeLayout(false);
            this.pWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTabs;
        private System.Windows.Forms.Panel pMyPublications;
        private System.Windows.Forms.Label lMyPublications;
        private System.Windows.Forms.PictureBox pBMyPublications;
        private System.Windows.Forms.Panel pMyInterests;
        private System.Windows.Forms.Label lMyInterests;
        private System.Windows.Forms.PictureBox pBMyInterests;
        private System.Windows.Forms.Panel pWork;
        private System.Windows.Forms.Label lWorkTitle;
        private System.Windows.Forms.PictureBox pBWork;
        private System.Windows.Forms.Button bAddTab;
    }
}
