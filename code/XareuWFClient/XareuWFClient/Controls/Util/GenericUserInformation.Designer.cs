namespace XareuWFClient.Controls.Util
{
    partial class GenericUserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenericUserInformation));
            this.pUserCard = new System.Windows.Forms.Panel();
            this.pActions = new System.Windows.Forms.Panel();
            this.lLReject = new System.Windows.Forms.LinkLabel();
            this.lLAccept = new System.Windows.Forms.LinkLabel();
            this.lKarma = new System.Windows.Forms.Label();
            this.pBUserIcon = new System.Windows.Forms.PictureBox();
            this.lUserName = new System.Windows.Forms.Label();
            this.lUserLocation = new System.Windows.Forms.Label();
            this.pBUserImage = new System.Windows.Forms.PictureBox();
            this.pUserCard.SuspendLayout();
            this.pActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pUserCard
            // 
            this.pUserCard.BackColor = System.Drawing.Color.Transparent;
            this.pUserCard.Controls.Add(this.pActions);
            this.pUserCard.Controls.Add(this.lKarma);
            this.pUserCard.Controls.Add(this.pBUserIcon);
            this.pUserCard.Controls.Add(this.lUserName);
            this.pUserCard.Controls.Add(this.lUserLocation);
            this.pUserCard.Controls.Add(this.pBUserImage);
            this.pUserCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUserCard.Location = new System.Drawing.Point(0, 0);
            this.pUserCard.Name = "pUserCard";
            this.pUserCard.Size = new System.Drawing.Size(329, 95);
            this.pUserCard.TabIndex = 6;
            // 
            // pActions
            // 
            this.pActions.Controls.Add(this.lLReject);
            this.pActions.Controls.Add(this.lLAccept);
            this.pActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pActions.Location = new System.Drawing.Point(268, 0);
            this.pActions.Name = "pActions";
            this.pActions.Size = new System.Drawing.Size(61, 95);
            this.pActions.TabIndex = 5;
            // 
            // lLReject
            // 
            this.lLReject.Dock = System.Windows.Forms.DockStyle.Top;
            this.lLReject.Image = global::XareuWFClient.Properties.Resources.negativo;
            this.lLReject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lLReject.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lLReject.Location = new System.Drawing.Point(0, 23);
            this.lLReject.Name = "lLReject";
            this.lLReject.Size = new System.Drawing.Size(61, 23);
            this.lLReject.TabIndex = 3;
            this.lLReject.TabStop = true;
            this.lLReject.Text = "Reject";
            this.lLReject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lLAccept
            // 
            this.lLAccept.Dock = System.Windows.Forms.DockStyle.Top;
            this.lLAccept.Image = global::XareuWFClient.Properties.Resources.positivo;
            this.lLAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lLAccept.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lLAccept.Location = new System.Drawing.Point(0, 0);
            this.lLAccept.Name = "lLAccept";
            this.lLAccept.Size = new System.Drawing.Size(61, 23);
            this.lLAccept.TabIndex = 2;
            this.lLAccept.TabStop = true;
            this.lLAccept.Text = "Accept";
            this.lLAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lKarma
            // 
            this.lKarma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lKarma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lKarma.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKarma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lKarma.Location = new System.Drawing.Point(101, 44);
            this.lKarma.Name = "lKarma";
            this.lKarma.Size = new System.Drawing.Size(225, 17);
            this.lKarma.TabIndex = 4;
            this.lKarma.Text = "Karma: Unknown";
            // 
            // pBUserIcon
            // 
            this.pBUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pBUserIcon.Image")));
            this.pBUserIcon.Location = new System.Drawing.Point(101, 2);
            this.pBUserIcon.Name = "pBUserIcon";
            this.pBUserIcon.Size = new System.Drawing.Size(20, 22);
            this.pBUserIcon.TabIndex = 1;
            this.pBUserIcon.TabStop = false;
            // 
            // lUserName
            // 
            this.lUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lUserName.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(127, 5);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(199, 19);
            this.lUserName.TabIndex = 2;
            this.lUserName.Text = "Unknown User";
            // 
            // lUserLocation
            // 
            this.lUserLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lUserLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lUserLocation.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lUserLocation.Location = new System.Drawing.Point(101, 26);
            this.lUserLocation.Name = "lUserLocation";
            this.lUserLocation.Size = new System.Drawing.Size(225, 17);
            this.lUserLocation.TabIndex = 3;
            this.lUserLocation.Text = "Unknown Location";
            // 
            // pBUserImage
            // 
            this.pBUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBUserImage.Location = new System.Drawing.Point(3, 3);
            this.pBUserImage.Name = "pBUserImage";
            this.pBUserImage.Padding = new System.Windows.Forms.Padding(3);
            this.pBUserImage.Size = new System.Drawing.Size(91, 91);
            this.pBUserImage.TabIndex = 0;
            this.pBUserImage.TabStop = false;
            // 
            // GenericUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pUserCard);
            this.Name = "GenericUserInformation";
            this.Size = new System.Drawing.Size(329, 95);
            this.pUserCard.ResumeLayout(false);
            this.pActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pUserCard;
        private System.Windows.Forms.Label lKarma;
        private System.Windows.Forms.PictureBox pBUserIcon;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Label lUserLocation;
        private System.Windows.Forms.PictureBox pBUserImage;
        private System.Windows.Forms.Panel pActions;
        private System.Windows.Forms.LinkLabel lLAccept;
        private System.Windows.Forms.LinkLabel lLReject;

    }
}
