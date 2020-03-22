namespace XareuWFClient.Controls.Util
{
    partial class SearchControl
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
            this.pSearch = new System.Windows.Forms.Panel();
            this.bSearch = new System.Windows.Forms.PictureBox();
            this.pTagsLocations = new System.Windows.Forms.Panel();
            this.tBTags = new System.Windows.Forms.TextBox();
            this.tBLocation = new System.Windows.Forms.TextBox();
            this.tBSearchText = new System.Windows.Forms.TextBox();
            this.lSearchTitle = new System.Windows.Forms.Label();
            this.pSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSearch)).BeginInit();
            this.pTagsLocations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.Color.Transparent;
            this.pSearch.Controls.Add(this.bSearch);
            this.pSearch.Controls.Add(this.pTagsLocations);
            this.pSearch.Controls.Add(this.tBSearchText);
            this.pSearch.Controls.Add(this.lSearchTitle);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(536, 91);
            this.pSearch.TabIndex = 4;
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.Image = global::XareuWFClient.Properties.Resources.search;
            this.bSearch.Location = new System.Drawing.Point(507, 60);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(22, 22);
            this.bSearch.TabIndex = 13;
            this.bSearch.TabStop = false;
            // 
            // pTagsLocations
            // 
            this.pTagsLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pTagsLocations.Controls.Add(this.tBTags);
            this.pTagsLocations.Controls.Add(this.tBLocation);
            this.pTagsLocations.Location = new System.Drawing.Point(3, 54);
            this.pTagsLocations.Name = "pTagsLocations";
            this.pTagsLocations.Size = new System.Drawing.Size(498, 31);
            this.pTagsLocations.TabIndex = 5;
            // 
            // tBTags
            // 
            this.tBTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBTags.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTags.Location = new System.Drawing.Point(0, 5);
            this.tBTags.Name = "tBTags";
            this.tBTags.Size = new System.Drawing.Size(363, 26);
            this.tBTags.TabIndex = 13;
            this.tBTags.Text = "Tags";
            // 
            // tBLocation
            // 
            this.tBLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBLocation.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLocation.Location = new System.Drawing.Point(369, 5);
            this.tBLocation.Name = "tBLocation";
            this.tBLocation.Size = new System.Drawing.Size(126, 26);
            this.tBLocation.TabIndex = 14;
            this.tBLocation.Text = "Location";
            // 
            // tBSearchText
            // 
            this.tBSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSearchText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearchText.Location = new System.Drawing.Point(3, 26);
            this.tBSearchText.Name = "tBSearchText";
            this.tBSearchText.Size = new System.Drawing.Size(530, 26);
            this.tBSearchText.TabIndex = 12;
            this.tBSearchText.Text = "Text";
            // 
            // lSearchTitle
            // 
            this.lSearchTitle.AutoSize = true;
            this.lSearchTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearchTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.lSearchTitle.Location = new System.Drawing.Point(-3, 0);
            this.lSearchTitle.Name = "lSearchTitle";
            this.lSearchTitle.Size = new System.Drawing.Size(85, 29);
            this.lSearchTitle.TabIndex = 2;
            this.lSearchTitle.Text = "Search";
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pSearch);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(536, 91);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSearch)).EndInit();
            this.pTagsLocations.ResumeLayout(false);
            this.pTagsLocations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.TextBox tBLocation;
        private System.Windows.Forms.TextBox tBTags;
        private System.Windows.Forms.TextBox tBSearchText;
        private System.Windows.Forms.Label lSearchTitle;
        private System.Windows.Forms.Panel pTagsLocations;
        private System.Windows.Forms.PictureBox bSearch;
    }
}
