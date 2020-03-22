using XareuWFClient.Controls.Util;
namespace XareuWFClient.Controls.Publication
{
    partial class Publication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publication));
            this.pPublication = new System.Windows.Forms.Panel();
            this.pContent = new System.Windows.Forms.Panel();
            this.tLPContent = new System.Windows.Forms.TableLayoutPanel();
            this.pPublicationText = new System.Windows.Forms.Panel();
            this.tBPublicationText = new System.Windows.Forms.TextBox();
            this.fLPTags = new System.Windows.Forms.FlowLayoutPanel();
            this.pSeparator = new System.Windows.Forms.Panel();
            this.pInfo = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.pLeftColumn = new System.Windows.Forms.Panel();
            this.pUserInfo = new System.Windows.Forms.Panel();
            this.lUserLocation = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.pUserImage = new System.Windows.Forms.Panel();
            this.pBUserImage = new System.Windows.Forms.PictureBox();
            this.vBVotes = new XareuWFClient.Controls.Util.VoteBox();
            this.pPublication.SuspendLayout();
            this.pContent.SuspendLayout();
            this.tLPContent.SuspendLayout();
            this.pPublicationText.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.pLeftColumn.SuspendLayout();
            this.pUserInfo.SuspendLayout();
            this.pUserImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pPublication
            // 
            this.pPublication.BackColor = System.Drawing.Color.Transparent;
            this.pPublication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublication.Controls.Add(this.pContent);
            this.pPublication.Controls.Add(this.pLeftColumn);
            this.pPublication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPublication.Location = new System.Drawing.Point(0, 0);
            this.pPublication.Name = "pPublication";
            this.pPublication.Size = new System.Drawing.Size(345, 213);
            this.pPublication.TabIndex = 0;
            // 
            // pContent
            // 
            this.pContent.Controls.Add(this.tLPContent);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(109, 0);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(236, 213);
            this.pContent.TabIndex = 4;
            // 
            // tLPContent
            // 
            this.tLPContent.ColumnCount = 1;
            this.tLPContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPContent.Controls.Add(this.pPublicationText, 0, 3);
            this.tLPContent.Controls.Add(this.fLPTags, 0, 4);
            this.tLPContent.Controls.Add(this.pSeparator, 0, 2);
            this.tLPContent.Controls.Add(this.pInfo, 0, 1);
            this.tLPContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPContent.Location = new System.Drawing.Point(0, 0);
            this.tLPContent.Name = "tLPContent";
            this.tLPContent.RowCount = 5;
            this.tLPContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tLPContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLPContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tLPContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLPContent.Size = new System.Drawing.Size(236, 213);
            this.tLPContent.TabIndex = 1;
            // 
            // pPublicationText
            // 
            this.pPublicationText.AutoScroll = true;
            this.pPublicationText.Controls.Add(this.tBPublicationText);
            this.pPublicationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPublicationText.Location = new System.Drawing.Point(3, 51);
            this.pPublicationText.Name = "pPublicationText";
            this.pPublicationText.Size = new System.Drawing.Size(230, 129);
            this.pPublicationText.TabIndex = 2;
            // 
            // tBPublicationText
            // 
            this.tBPublicationText.BackColor = System.Drawing.Color.White;
            this.tBPublicationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBPublicationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBPublicationText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPublicationText.Location = new System.Drawing.Point(0, 0);
            this.tBPublicationText.Multiline = true;
            this.tBPublicationText.Name = "tBPublicationText";
            this.tBPublicationText.ReadOnly = true;
            this.tBPublicationText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBPublicationText.Size = new System.Drawing.Size(230, 129);
            this.tBPublicationText.TabIndex = 1;
            this.tBPublicationText.Text = resources.GetString("tBPublicationText.Text");
            // 
            // fLPTags
            // 
            this.fLPTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPTags.Location = new System.Drawing.Point(3, 186);
            this.fLPTags.Name = "fLPTags";
            this.fLPTags.Size = new System.Drawing.Size(230, 24);
            this.fLPTags.TabIndex = 3;
            // 
            // pSeparator
            // 
            this.pSeparator.BackColor = System.Drawing.Color.White;
            this.pSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSeparator.Location = new System.Drawing.Point(3, 41);
            this.pSeparator.Name = "pSeparator";
            this.pSeparator.Size = new System.Drawing.Size(230, 4);
            this.pSeparator.TabIndex = 4;
            // 
            // pInfo
            // 
            this.pInfo.AutoSize = true;
            this.pInfo.Controls.Add(this.lTitle);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfo.Location = new System.Drawing.Point(3, 11);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(230, 24);
            this.pInfo.TabIndex = 1;
            // 
            // lTitle
            // 
            this.lTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(230, 24);
            this.lTitle.TabIndex = 5;
            this.lTitle.Text = "Unknown Title..........................4..........5";
            // 
            // pLeftColumn
            // 
            this.pLeftColumn.Controls.Add(this.pUserInfo);
            this.pLeftColumn.Controls.Add(this.vBVotes);
            this.pLeftColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftColumn.Location = new System.Drawing.Point(0, 0);
            this.pLeftColumn.Name = "pLeftColumn";
            this.pLeftColumn.Padding = new System.Windows.Forms.Padding(3);
            this.pLeftColumn.Size = new System.Drawing.Size(109, 213);
            this.pLeftColumn.TabIndex = 5;
            // 
            // pUserInfo
            // 
            this.pUserInfo.Controls.Add(this.lUserLocation);
            this.pUserInfo.Controls.Add(this.lUserName);
            this.pUserInfo.Controls.Add(this.pUserImage);
            this.pUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUserInfo.Location = new System.Drawing.Point(3, 82);
            this.pUserInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pUserInfo.Name = "pUserInfo";
            this.pUserInfo.Size = new System.Drawing.Size(103, 128);
            this.pUserInfo.TabIndex = 2;
            // 
            // lUserLocation
            // 
            this.lUserLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lUserLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lUserLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lUserLocation.Location = new System.Drawing.Point(0, 86);
            this.lUserLocation.Margin = new System.Windows.Forms.Padding(3);
            this.lUserLocation.Name = "lUserLocation";
            this.lUserLocation.Size = new System.Drawing.Size(103, 31);
            this.lUserLocation.TabIndex = 4;
            this.lUserLocation.Text = "Unknown Location";
            // 
            // lUserName
            // 
            this.lUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lUserName.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(0, 56);
            this.lUserName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(103, 30);
            this.lUserName.TabIndex = 3;
            this.lUserName.Text = "Unknown User";
            // 
            // pUserImage
            // 
            this.pUserImage.Controls.Add(this.pBUserImage);
            this.pUserImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pUserImage.Location = new System.Drawing.Point(0, 0);
            this.pUserImage.Margin = new System.Windows.Forms.Padding(0);
            this.pUserImage.Name = "pUserImage";
            this.pUserImage.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pUserImage.Size = new System.Drawing.Size(103, 56);
            this.pUserImage.TabIndex = 5;
            // 
            // pBUserImage
            // 
            this.pBUserImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pBUserImage.BackColor = System.Drawing.Color.White;
            this.pBUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBUserImage.Location = new System.Drawing.Point(26, 3);
            this.pBUserImage.MaximumSize = new System.Drawing.Size(50, 50);
            this.pBUserImage.MinimumSize = new System.Drawing.Size(50, 50);
            this.pBUserImage.Name = "pBUserImage";
            this.pBUserImage.Padding = new System.Windows.Forms.Padding(3);
            this.pBUserImage.Size = new System.Drawing.Size(50, 50);
            this.pBUserImage.TabIndex = 0;
            this.pBUserImage.TabStop = false;
            // 
            // vBVotes
            // 
            this.vBVotes.BackColor = System.Drawing.Color.Transparent;
            this.vBVotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vBVotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.vBVotes.Location = new System.Drawing.Point(3, 3);
            this.vBVotes.MaximumSize = new System.Drawing.Size(106, 79);
            this.vBVotes.MinimumSize = new System.Drawing.Size(104, 77);
            this.vBVotes.Name = "vBVotes";
            this.vBVotes.Padding = new System.Windows.Forms.Padding(2);
            this.vBVotes.Size = new System.Drawing.Size(104, 79);
            this.vBVotes.TabIndex = 3;
            // 
            // Publication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pPublication);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(347, 215);
            this.Name = "Publication";
            this.Size = new System.Drawing.Size(345, 213);
            this.pPublication.ResumeLayout(false);
            this.pContent.ResumeLayout(false);
            this.tLPContent.ResumeLayout(false);
            this.tLPContent.PerformLayout();
            this.pPublicationText.ResumeLayout(false);
            this.pPublicationText.PerformLayout();
            this.pInfo.ResumeLayout(false);
            this.pLeftColumn.ResumeLayout(false);
            this.pUserInfo.ResumeLayout(false);
            this.pUserImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPublication;
        private System.Windows.Forms.PictureBox pBUserImage;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Panel pUserInfo;
        private System.Windows.Forms.Label lUserLocation;
        private System.Windows.Forms.Label lUserName;
        private VoteBox vBVotes;
        private System.Windows.Forms.Panel pPublicationText;
        private System.Windows.Forms.FlowLayoutPanel fLPTags;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.TableLayoutPanel tLPContent;
        private System.Windows.Forms.Panel pSeparator;
        private System.Windows.Forms.Panel pLeftColumn;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tBPublicationText;
        private System.Windows.Forms.Panel pUserImage;
    }
}
