namespace XareuWFClient.Controls.Publication
{
    partial class PublicationPage
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
            XareuWFClient.Model.Publication.Publication publication1 = new XareuWFClient.Model.Publication.Publication();
            XareuWFClient.Model.User.User user1 = new XareuWFClient.Model.User.User();
            XareuWFClient.Model.TagPlace.TagPlace tagPlace1 = new XareuWFClient.Model.TagPlace.TagPlace();
            XareuWFClient.Model.TagPlace.TagPlace tagPlace2 = new XareuWFClient.Model.TagPlace.TagPlace();
            this.publicationData = new XareuWFClient.Controls.Publication.Publication();
            this.pAnswers = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // publicationData
            // 
            this.publicationData.BackColor = System.Drawing.Color.White;
            this.publicationData.Background = null;
            this.publicationData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.publicationData.Dock = System.Windows.Forms.DockStyle.Top;
            this.publicationData.Location = new System.Drawing.Point(0, 0);
            this.publicationData.Name = "publicationData";
            publication1.AnswersTo = ((long)(0));
            tagPlace1.Id = ((long)(1));
            tagPlace1.Name = "";
            tagPlace1.ParentId = ((long)(1));
            user1.DefaultPlace = tagPlace1;
            user1.Email = "";
            user1.Id = ((long)(0));
            user1.IsAdmin = false;
            user1.IsPrivate = false;
            user1.Karma = 0F;
            user1.Nick = "";
            user1.Password = "";
            user1.SignUp = new System.DateTime(2010, 6, 20, 0, 0, 0, 0);
            user1.UserPictureURL = "http://test.com/test.png";
            publication1.Author = user1;
            publication1.CreationDateTime = new System.DateTime(2010, 6, 20, 21, 11, 17, 496);
            publication1.Id = ((long)(0));
            publication1.IsPrivate = false;
            publication1.IsQuestion = false;
            publication1.Karma = 0F;
            publication1.NegativeVotes = 0;
            tagPlace2.Id = ((long)(1));
            tagPlace2.Name = "";
            tagPlace2.ParentId = ((long)(1));
            publication1.Place = tagPlace2;
            publication1.PositiveVotes = 0;
            publication1.Text = "";
            this.publicationData.PublicationData = publication1;
            this.publicationData.Size = new System.Drawing.Size(572, 362);
            this.publicationData.TabIndex = 0;
            // 
            // pAnswers
            // 
            this.pAnswers.AutoScroll = true;
            this.pAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAnswers.Location = new System.Drawing.Point(0, 362);
            this.pAnswers.Name = "pAnswers";
            this.pAnswers.Size = new System.Drawing.Size(572, 143);
            this.pAnswers.TabIndex = 1;
            // 
            // PublicationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pAnswers);
            this.Controls.Add(this.publicationData);
            this.Name = "PublicationPage";
            this.Size = new System.Drawing.Size(572, 505);
            this.ResumeLayout(false);

        }

        #endregion

        private Publication publicationData;
        private System.Windows.Forms.Panel pAnswers;
    }
}
