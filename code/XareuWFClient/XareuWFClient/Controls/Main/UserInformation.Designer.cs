namespace XareuWFClient.Controls.Main
{
    partial class UserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformation));
            this.lUserName = new System.Windows.Forms.Label();
            this.lUserLocation = new System.Windows.Forms.Label();
            this.lKarma = new System.Windows.Forms.Label();
            this.pUserCard = new System.Windows.Forms.Panel();
            this.bLogin = new System.Windows.Forms.Button();
            this.pBUserIcon = new System.Windows.Forms.PictureBox();
            this.pBUserImage = new System.Windows.Forms.PictureBox();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.pUserCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lUserName
            // 
            this.lUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lUserName.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(127, 5);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(154, 19);
            this.lUserName.TabIndex = 2;
            this.lUserName.Text = "Unknown User";
            this.lUserName.Click += new System.EventHandler(this.lUserName_Click);
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
            this.lUserLocation.Size = new System.Drawing.Size(180, 17);
            this.lUserLocation.TabIndex = 3;
            this.lUserLocation.Text = "Unknown Location";
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
            this.lKarma.Size = new System.Drawing.Size(180, 17);
            this.lKarma.TabIndex = 4;
            this.lKarma.Text = "Karma: Unknown";
            // 
            // pUserCard
            // 
            this.pUserCard.Controls.Add(this.bDisconnect);
            this.pUserCard.Controls.Add(this.bLogin);
            this.pUserCard.Controls.Add(this.lKarma);
            this.pUserCard.Controls.Add(this.pBUserIcon);
            this.pUserCard.Controls.Add(this.lUserName);
            this.pUserCard.Controls.Add(this.lUserLocation);
            this.pUserCard.Controls.Add(this.pBUserImage);
            this.pUserCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUserCard.Location = new System.Drawing.Point(0, 0);
            this.pUserCard.Name = "pUserCard";
            this.pUserCard.Size = new System.Drawing.Size(284, 102);
            this.pUserCard.TabIndex = 5;
            // 
            // bLogin
            // 
            this.bLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.Color.White;
            this.bLogin.Location = new System.Drawing.Point(101, 64);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(177, 30);
            this.bLogin.TabIndex = 6;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
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
            // pBUserImage
            // 
            this.pBUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBUserImage.Location = new System.Drawing.Point(3, 2);
            this.pBUserImage.Name = "pBUserImage";
            this.pBUserImage.Padding = new System.Windows.Forms.Padding(3);
            this.pBUserImage.Size = new System.Drawing.Size(91, 91);
            this.pBUserImage.TabIndex = 0;
            this.pBUserImage.TabStop = false;
            // 
            // bDisconnect
            // 
            this.bDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDisconnect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDisconnect.ForeColor = System.Drawing.Color.White;
            this.bDisconnect.Location = new System.Drawing.Point(101, 63);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(177, 30);
            this.bDisconnect.TabIndex = 7;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = false;
            this.bDisconnect.Visible = false;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pUserCard);
            this.Name = "UserInformation";
            this.Size = new System.Drawing.Size(284, 102);
            this.pUserCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBUserImage;
        private System.Windows.Forms.PictureBox pBUserIcon;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Label lUserLocation;
        private System.Windows.Forms.Label lKarma;
        private System.Windows.Forms.Panel pUserCard;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bDisconnect;
    }
}
