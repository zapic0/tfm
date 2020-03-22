namespace XareuWFClient.Controls.Util
{
    partial class SearchTextControl
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
            this.tBSearchText = new System.Windows.Forms.TextBox();
            this.lSearchTitle = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tBSearchText
            // 
            this.tBSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSearchText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearchText.Location = new System.Drawing.Point(3, 26);
            this.tBSearchText.Name = "tBSearchText";
            this.tBSearchText.Size = new System.Drawing.Size(438, 26);
            this.tBSearchText.TabIndex = 15;
            this.tBSearchText.Text = "Text";
            // 
            // lSearchTitle
            // 
            this.lSearchTitle.AutoSize = true;
            this.lSearchTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearchTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.lSearchTitle.Location = new System.Drawing.Point(-2, 0);
            this.lSearchTitle.Name = "lSearchTitle";
            this.lSearchTitle.Size = new System.Drawing.Size(85, 29);
            this.lSearchTitle.TabIndex = 14;
            this.lSearchTitle.Text = "Search";
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.Image = global::XareuWFClient.Properties.Resources.search;
            this.bSearch.Location = new System.Drawing.Point(447, 26);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(22, 22);
            this.bSearch.TabIndex = 16;
            this.bSearch.TabStop = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // SearchTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tBSearchText);
            this.Controls.Add(this.lSearchTitle);
            this.Name = "SearchTextControl";
            this.Size = new System.Drawing.Size(472, 60);
            ((System.ComponentModel.ISupportInitialize)(this.bSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bSearch;
        private System.Windows.Forms.TextBox tBSearchText;
        private System.Windows.Forms.Label lSearchTitle;
    }
}
