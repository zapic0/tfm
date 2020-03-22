namespace XareuWFClient.Controls.Main
{
    partial class PublicationColumns
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
            this.pPublicationColumns = new System.Windows.Forms.Panel();
            this.tLPContent = new System.Windows.Forms.TableLayoutPanel();
            this.pSeparator = new System.Windows.Forms.Panel();
            this.pPublications = new System.Windows.Forms.Panel();
            this.pPublicationsList = new System.Windows.Forms.Panel();
            this.pPublicationsLinks = new System.Windows.Forms.Panel();
            this.lLNextPublications = new System.Windows.Forms.LinkLabel();
            this.lLPreviousPublications = new System.Windows.Forms.LinkLabel();
            this.pPublicationsTitle = new System.Windows.Forms.Panel();
            this.lPublications = new System.Windows.Forms.Label();
            this.pQuestions = new System.Windows.Forms.Panel();
            this.pQuestionsList = new System.Windows.Forms.Panel();
            this.pQuestionsLinks = new System.Windows.Forms.Panel();
            this.lLNextQuestions = new System.Windows.Forms.LinkLabel();
            this.lLPreviousQuestions = new System.Windows.Forms.LinkLabel();
            this.pQuestionsTitle = new System.Windows.Forms.Panel();
            this.lQuestions = new System.Windows.Forms.Label();
            this.pPublicationColumns.SuspendLayout();
            this.tLPContent.SuspendLayout();
            this.pPublications.SuspendLayout();
            this.pPublicationsLinks.SuspendLayout();
            this.pPublicationsTitle.SuspendLayout();
            this.pQuestions.SuspendLayout();
            this.pQuestionsLinks.SuspendLayout();
            this.pQuestionsTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPublicationColumns
            // 
            this.pPublicationColumns.BackColor = System.Drawing.Color.Transparent;
            this.pPublicationColumns.Controls.Add(this.tLPContent);
            this.pPublicationColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPublicationColumns.Location = new System.Drawing.Point(0, 0);
            this.pPublicationColumns.Name = "pPublicationColumns";
            this.pPublicationColumns.Size = new System.Drawing.Size(597, 322);
            this.pPublicationColumns.TabIndex = 0;
            // 
            // tLPContent
            // 
            this.tLPContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tLPContent.ColumnCount = 3;
            this.tLPContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tLPContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPContent.Controls.Add(this.pSeparator, 1, 0);
            this.tLPContent.Controls.Add(this.pPublications, 0, 0);
            this.tLPContent.Controls.Add(this.pQuestions, 2, 0);
            this.tLPContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPContent.Location = new System.Drawing.Point(0, 0);
            this.tLPContent.Name = "tLPContent";
            this.tLPContent.RowCount = 1;
            this.tLPContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPContent.Size = new System.Drawing.Size(597, 322);
            this.tLPContent.TabIndex = 9;
            // 
            // pSeparator
            // 
            this.pSeparator.BackColor = System.Drawing.Color.Transparent;
            this.pSeparator.BackgroundImage = global::XareuWFClient.Properties.Resources.separatorComplete;
            this.pSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSeparator.Location = new System.Drawing.Point(296, 3);
            this.pSeparator.Name = "pSeparator";
            this.pSeparator.Size = new System.Drawing.Size(4, 316);
            this.pSeparator.TabIndex = 0;
            // 
            // pPublications
            // 
            this.pPublications.Controls.Add(this.pPublicationsList);
            this.pPublications.Controls.Add(this.pPublicationsLinks);
            this.pPublications.Controls.Add(this.pPublicationsTitle);
            this.pPublications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPublications.Location = new System.Drawing.Point(3, 3);
            this.pPublications.Name = "pPublications";
            this.pPublications.Size = new System.Drawing.Size(287, 316);
            this.pPublications.TabIndex = 9;
            // 
            // pPublicationsList
            // 
            this.pPublicationsList.AutoScroll = true;
            this.pPublicationsList.AutoSize = true;
            this.pPublicationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPublicationsList.Location = new System.Drawing.Point(0, 59);
            this.pPublicationsList.Name = "pPublicationsList";
            this.pPublicationsList.Size = new System.Drawing.Size(287, 239);
            this.pPublicationsList.TabIndex = 3;
            // 
            // pPublicationsLinks
            // 
            this.pPublicationsLinks.Controls.Add(this.lLNextPublications);
            this.pPublicationsLinks.Controls.Add(this.lLPreviousPublications);
            this.pPublicationsLinks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPublicationsLinks.Location = new System.Drawing.Point(0, 298);
            this.pPublicationsLinks.Name = "pPublicationsLinks";
            this.pPublicationsLinks.Size = new System.Drawing.Size(287, 18);
            this.pPublicationsLinks.TabIndex = 14;
            // 
            // lLNextPublications
            // 
            this.lLNextPublications.AutoSize = true;
            this.lLNextPublications.Dock = System.Windows.Forms.DockStyle.Right;
            this.lLNextPublications.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextPublications.Location = new System.Drawing.Point(228, 0);
            this.lLNextPublications.Name = "lLNextPublications";
            this.lLNextPublications.Size = new System.Drawing.Size(59, 13);
            this.lLNextPublications.TabIndex = 1;
            this.lLNextPublications.TabStop = true;
            this.lLNextPublications.Text = "Next 10 >>";
            this.lLNextPublications.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextPublications.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLNextPublications_LinkClicked);
            // 
            // lLPreviousPublications
            // 
            this.lLPreviousPublications.AutoSize = true;
            this.lLPreviousPublications.Dock = System.Windows.Forms.DockStyle.Left;
            this.lLPreviousPublications.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousPublications.Location = new System.Drawing.Point(0, 0);
            this.lLPreviousPublications.Name = "lLPreviousPublications";
            this.lLPreviousPublications.Size = new System.Drawing.Size(78, 13);
            this.lLPreviousPublications.TabIndex = 0;
            this.lLPreviousPublications.TabStop = true;
            this.lLPreviousPublications.Text = "<< Previous 10";
            this.lLPreviousPublications.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousPublications.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLPreviousPublications_LinkClicked);
            // 
            // pPublicationsTitle
            // 
            this.pPublicationsTitle.Controls.Add(this.lPublications);
            this.pPublicationsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPublicationsTitle.Location = new System.Drawing.Point(0, 0);
            this.pPublicationsTitle.Name = "pPublicationsTitle";
            this.pPublicationsTitle.Size = new System.Drawing.Size(287, 59);
            this.pPublicationsTitle.TabIndex = 2;
            // 
            // lPublications
            // 
            this.lPublications.AutoSize = true;
            this.lPublications.BackColor = System.Drawing.Color.Transparent;
            this.lPublications.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPublications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lPublications.Location = new System.Drawing.Point(3, 0);
            this.lPublications.Name = "lPublications";
            this.lPublications.Size = new System.Drawing.Size(248, 52);
            this.lPublications.TabIndex = 9;
            this.lPublications.Text = "Publications";
            // 
            // pQuestions
            // 
            this.pQuestions.Controls.Add(this.pQuestionsList);
            this.pQuestions.Controls.Add(this.pQuestionsLinks);
            this.pQuestions.Controls.Add(this.pQuestionsTitle);
            this.pQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pQuestions.Location = new System.Drawing.Point(306, 3);
            this.pQuestions.Name = "pQuestions";
            this.pQuestions.Size = new System.Drawing.Size(288, 316);
            this.pQuestions.TabIndex = 1;
            // 
            // pQuestionsList
            // 
            this.pQuestionsList.AutoScroll = true;
            this.pQuestionsList.AutoSize = true;
            this.pQuestionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pQuestionsList.Location = new System.Drawing.Point(0, 59);
            this.pQuestionsList.Name = "pQuestionsList";
            this.pQuestionsList.Size = new System.Drawing.Size(288, 239);
            this.pQuestionsList.TabIndex = 1;
            // 
            // pQuestionsLinks
            // 
            this.pQuestionsLinks.Controls.Add(this.lLNextQuestions);
            this.pQuestionsLinks.Controls.Add(this.lLPreviousQuestions);
            this.pQuestionsLinks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pQuestionsLinks.Location = new System.Drawing.Point(0, 298);
            this.pQuestionsLinks.Name = "pQuestionsLinks";
            this.pQuestionsLinks.Size = new System.Drawing.Size(288, 18);
            this.pQuestionsLinks.TabIndex = 15;
            // 
            // lLNextQuestions
            // 
            this.lLNextQuestions.AutoSize = true;
            this.lLNextQuestions.Dock = System.Windows.Forms.DockStyle.Right;
            this.lLNextQuestions.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextQuestions.Location = new System.Drawing.Point(229, 0);
            this.lLNextQuestions.Name = "lLNextQuestions";
            this.lLNextQuestions.Size = new System.Drawing.Size(59, 13);
            this.lLNextQuestions.TabIndex = 1;
            this.lLNextQuestions.TabStop = true;
            this.lLNextQuestions.Text = "Next 10 >>";
            this.lLNextQuestions.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLNextQuestions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLNextQuestions_LinkClicked);
            // 
            // lLPreviousQuestions
            // 
            this.lLPreviousQuestions.AutoSize = true;
            this.lLPreviousQuestions.Dock = System.Windows.Forms.DockStyle.Left;
            this.lLPreviousQuestions.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousQuestions.Location = new System.Drawing.Point(0, 0);
            this.lLPreviousQuestions.Name = "lLPreviousQuestions";
            this.lLPreviousQuestions.Size = new System.Drawing.Size(78, 13);
            this.lLPreviousQuestions.TabIndex = 0;
            this.lLPreviousQuestions.TabStop = true;
            this.lLPreviousQuestions.Text = "<< Previous 10";
            this.lLPreviousQuestions.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lLPreviousQuestions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLPreviousQuestions_LinkClicked);
            // 
            // pQuestionsTitle
            // 
            this.pQuestionsTitle.Controls.Add(this.lQuestions);
            this.pQuestionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pQuestionsTitle.Location = new System.Drawing.Point(0, 0);
            this.pQuestionsTitle.Name = "pQuestionsTitle";
            this.pQuestionsTitle.Size = new System.Drawing.Size(288, 59);
            this.pQuestionsTitle.TabIndex = 0;
            // 
            // lQuestions
            // 
            this.lQuestions.AutoSize = true;
            this.lQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lQuestions.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lQuestions.Location = new System.Drawing.Point(3, 0);
            this.lQuestions.Name = "lQuestions";
            this.lQuestions.Size = new System.Drawing.Size(209, 52);
            this.lQuestions.TabIndex = 9;
            this.lQuestions.Text = "Questions";
            // 
            // PublicationColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pPublicationColumns);
            this.DoubleBuffered = true;
            this.Name = "PublicationColumns";
            this.Size = new System.Drawing.Size(597, 322);
            this.pPublicationColumns.ResumeLayout(false);
            this.tLPContent.ResumeLayout(false);
            this.pPublications.ResumeLayout(false);
            this.pPublications.PerformLayout();
            this.pPublicationsLinks.ResumeLayout(false);
            this.pPublicationsLinks.PerformLayout();
            this.pPublicationsTitle.ResumeLayout(false);
            this.pPublicationsTitle.PerformLayout();
            this.pQuestions.ResumeLayout(false);
            this.pQuestions.PerformLayout();
            this.pQuestionsLinks.ResumeLayout(false);
            this.pQuestionsLinks.PerformLayout();
            this.pQuestionsTitle.ResumeLayout(false);
            this.pQuestionsTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPublicationColumns;
        private System.Windows.Forms.TableLayoutPanel tLPContent;
        private System.Windows.Forms.Panel pSeparator;
        private System.Windows.Forms.Panel pPublications;
        private System.Windows.Forms.Panel pPublicationsList;
        private System.Windows.Forms.Panel pPublicationsTitle;
        private System.Windows.Forms.Label lPublications;
        private System.Windows.Forms.Panel pQuestions;
        private System.Windows.Forms.Panel pQuestionsList;
        private System.Windows.Forms.Panel pQuestionsTitle;
        private System.Windows.Forms.Label lQuestions;
        private System.Windows.Forms.Panel pPublicationsLinks;
        private System.Windows.Forms.LinkLabel lLNextPublications;
        private System.Windows.Forms.LinkLabel lLPreviousPublications;
        private System.Windows.Forms.Panel pQuestionsLinks;
        private System.Windows.Forms.LinkLabel lLNextQuestions;
        private System.Windows.Forms.LinkLabel lLPreviousQuestions;
    }
}
