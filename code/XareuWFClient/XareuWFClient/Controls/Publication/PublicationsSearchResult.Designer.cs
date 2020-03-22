namespace XareuWFClient.Controls.Publication
{
    partial class PublicationsSearchResult
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
            this.pPublicationsList = new System.Windows.Forms.Panel();
            this.pTitle = new System.Windows.Forms.Panel();
            this.paginationSearch = new XareuWFClient.Controls.Util.Pagination();
            this.SuspendLayout();
            // 
            // pPublicationsList
            // 
            this.pPublicationsList.BackColor = System.Drawing.Color.Transparent;
            this.pPublicationsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPublicationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPublicationsList.Location = new System.Drawing.Point(0, 59);
            this.pPublicationsList.Name = "pPublicationsList";
            this.pPublicationsList.Size = new System.Drawing.Size(691, 425);
            this.pPublicationsList.TabIndex = 1;
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.Transparent;
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(691, 59);
            this.pTitle.TabIndex = 2;
            // 
            // paginationSearch
            // 
            this.paginationSearch.BackColor = System.Drawing.Color.Transparent;
            this.paginationSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginationSearch.Location = new System.Drawing.Point(0, 484);
            this.paginationSearch.Name = "paginationSearch";
            this.paginationSearch.Page = 0;
            this.paginationSearch.Size = new System.Drawing.Size(691, 16);
            this.paginationSearch.TabIndex = 3;
            this.paginationSearch.CallNextPage += new XareuWFClient.Controls.Util.Pagination.CallNextPageHandler(this.paginationSearch_CallNextPage_1);
            this.paginationSearch.CallPreviousPage += new XareuWFClient.Controls.Util.Pagination.CallPreviousPageHandler(this.paginationSearch_CallPreviousPage_1);
            // 
            // PublicationsSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pPublicationsList);
            this.Controls.Add(this.paginationSearch);
            this.Controls.Add(this.pTitle);
            this.Name = "PublicationsSearchResult";
            this.Size = new System.Drawing.Size(691, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPublicationsList;
        private System.Windows.Forms.Panel pTitle;
        private Util.Pagination paginationSearch;
    }
}
