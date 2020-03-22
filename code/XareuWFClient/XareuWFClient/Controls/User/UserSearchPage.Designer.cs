namespace XareuWFClient.Controls.User
{
    partial class UserSearchPage
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
            this.pContent = new System.Windows.Forms.Panel();
            this.pUsersList = new System.Windows.Forms.Panel();
            this.pagination = new XareuWFClient.Controls.Util.Pagination();
            this.searchTextControl = new XareuWFClient.Controls.Util.SearchTextControl();
            this.pContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.Controls.Add(this.pUsersList);
            this.pContent.Controls.Add(this.pagination);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(30, 90);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(563, 299);
            this.pContent.TabIndex = 3;
            // 
            // pUsersList
            // 
            this.pUsersList.AutoScroll = true;
            this.pUsersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUsersList.Location = new System.Drawing.Point(0, 0);
            this.pUsersList.Name = "pUsersList";
            this.pUsersList.Size = new System.Drawing.Size(563, 283);
            this.pUsersList.TabIndex = 2;
            // 
            // pagination
            // 
            this.pagination.BackColor = System.Drawing.Color.Transparent;
            this.pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagination.Location = new System.Drawing.Point(0, 283);
            this.pagination.Name = "pagination";
            this.pagination.Page = 0;
            this.pagination.Size = new System.Drawing.Size(563, 16);
            this.pagination.TabIndex = 0;
            this.pagination.CallNextPage += new XareuWFClient.Controls.Util.Pagination.CallNextPageHandler(this.pagination_CallNextPage);
            this.pagination.CallPreviousPage += new XareuWFClient.Controls.Util.Pagination.CallPreviousPageHandler(this.pagination_CallPreviousPage);
            // 
            // searchTextControl
            // 
            this.searchTextControl.BackColor = System.Drawing.Color.Transparent;
            this.searchTextControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTextControl.Location = new System.Drawing.Point(30, 30);
            this.searchTextControl.Name = "searchTextControl";
            this.searchTextControl.Size = new System.Drawing.Size(563, 60);
            this.searchTextControl.TabIndex = 3;
            this.searchTextControl.SearchText += new XareuWFClient.Controls.Util.SearchTextControl.SearchTextHandler(this.searchTextControl_SearchText);
            // 
            // UserSearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.searchTextControl);
            this.Name = "UserSearchPage";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(623, 419);
            this.pContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Panel pUsersList;
        private Util.Pagination pagination;
        private Util.SearchTextControl searchTextControl;
    }
}
