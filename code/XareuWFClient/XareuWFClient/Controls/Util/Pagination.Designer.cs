namespace XareuWFClient.Controls.Util
{
    partial class Pagination
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
            this.pPagination = new System.Windows.Forms.Panel();
            this.lLNextPage = new System.Windows.Forms.LinkLabel();
            this.lLPreviousPage = new System.Windows.Forms.LinkLabel();
            this.pPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPagination
            // 
            this.pPagination.Controls.Add(this.lLNextPage);
            this.pPagination.Controls.Add(this.lLPreviousPage);
            this.pPagination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPagination.Location = new System.Drawing.Point(0, 0);
            this.pPagination.Name = "pPagination";
            this.pPagination.Size = new System.Drawing.Size(228, 16);
            this.pPagination.TabIndex = 14;
            // 
            // lLNextPage
            // 
            this.lLNextPage.AutoSize = true;
            this.lLNextPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lLNextPage.Enabled = false;
            this.lLNextPage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextPage.Location = new System.Drawing.Point(169, 0);
            this.lLNextPage.Name = "lLNextPage";
            this.lLNextPage.Size = new System.Drawing.Size(59, 13);
            this.lLNextPage.TabIndex = 1;
            this.lLNextPage.TabStop = true;
            this.lLNextPage.Text = "Next 10 >>";
            this.lLNextPage.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLNextPage_LinkClicked);
            // 
            // lLPreviousPage
            // 
            this.lLPreviousPage.AutoSize = true;
            this.lLPreviousPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lLPreviousPage.Enabled = false;
            this.lLPreviousPage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousPage.Location = new System.Drawing.Point(0, 0);
            this.lLPreviousPage.Name = "lLPreviousPage";
            this.lLPreviousPage.Size = new System.Drawing.Size(78, 13);
            this.lLPreviousPage.TabIndex = 0;
            this.lLPreviousPage.TabStop = true;
            this.lLPreviousPage.Text = "<< Previous 10";
            this.lLPreviousPage.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLPreviousPage_LinkClicked);
            // 
            // Pagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pPagination);
            this.Name = "Pagination";
            this.Size = new System.Drawing.Size(228, 16);
            this.pPagination.ResumeLayout(false);
            this.pPagination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPagination;
        private System.Windows.Forms.LinkLabel lLNextPage;
        private System.Windows.Forms.LinkLabel lLPreviousPage;
    }
}
