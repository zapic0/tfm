namespace XareuWFClient.Controls.Publication
{
    partial class PublicationWithAnswers
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
            this.pAnswers = new System.Windows.Forms.Panel();
            this.tLPPublicationWithAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.pPublication = new System.Windows.Forms.Panel();
            this.publication = new Publication();
            this.tLPPublicationWithAnswers.SuspendLayout();
            this.pPublication.SuspendLayout();
            this.SuspendLayout();
            // 
            // pAnswers
            // 
            this.pAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAnswers.Location = new System.Drawing.Point(3, 144);
            this.pAnswers.Name = "pAnswers";
            this.pAnswers.Size = new System.Drawing.Size(482, 206);
            this.pAnswers.TabIndex = 0;
            // 
            // tLPPublicationWithAnswers
            // 
            this.tLPPublicationWithAnswers.ColumnCount = 1;
            this.tLPPublicationWithAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPPublicationWithAnswers.Controls.Add(this.pAnswers, 0, 1);
            this.tLPPublicationWithAnswers.Controls.Add(this.pPublication, 0, 0);
            this.tLPPublicationWithAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPPublicationWithAnswers.Location = new System.Drawing.Point(0, 0);
            this.tLPPublicationWithAnswers.Name = "tLPPublicationWithAnswers";
            this.tLPPublicationWithAnswers.RowCount = 2;
            this.tLPPublicationWithAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tLPPublicationWithAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tLPPublicationWithAnswers.Size = new System.Drawing.Size(488, 353);
            this.tLPPublicationWithAnswers.TabIndex = 1;
            // 
            // pPublication
            // 
            this.pPublication.Controls.Add(this.publication);
            this.pPublication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPublication.Location = new System.Drawing.Point(3, 3);
            this.pPublication.Name = "pPublication";
            this.pPublication.Size = new System.Drawing.Size(482, 135);
            this.pPublication.TabIndex = 1;
            // 
            // publication
            // 
            this.publication.BackColor = System.Drawing.Color.White;
            this.publication.Background = null;
            this.publication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publication.Location = new System.Drawing.Point(0, 0);
            this.publication.Name = "publication";
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
            user1.SignUp = new System.DateTime(2010, 3, 25, 0, 0, 0, 0);
            user1.UserPictureURL = "http://a1.twimg.com/profile_images/55668578/poison.png";
            publication1.Author = user1;
            publication1.CreationDateTime = new System.DateTime(2010, 3, 25, 10, 27, 11, 154);
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
            this.publication.PublicationData = publication1;
            this.publication.Size = new System.Drawing.Size(482, 135);
            this.publication.TabIndex = 0;
            // 
            // PublicationWithAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tLPPublicationWithAnswers);
            this.Name = "PublicationWithAnswers";
            this.Size = new System.Drawing.Size(488, 353);
            this.tLPPublicationWithAnswers.ResumeLayout(false);
            this.pPublication.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAnswers;
        private System.Windows.Forms.TableLayoutPanel tLPPublicationWithAnswers;
        private System.Windows.Forms.Panel pPublication;
        private XareuWFClient.Controls.Publication.Publication publication;
    }
}
