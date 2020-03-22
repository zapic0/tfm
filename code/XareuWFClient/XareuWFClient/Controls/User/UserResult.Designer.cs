namespace XareuWFClient.Controls.User
{
    partial class UserResult
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
            this.bFollow = new System.Windows.Forms.Button();
            this.lUser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // bFollow
            // 
            this.bFollow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bFollow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFollow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFollow.ForeColor = System.Drawing.Color.White;
            this.bFollow.Location = new System.Drawing.Point(273, 6);
            this.bFollow.Name = "bFollow";
            this.bFollow.Size = new System.Drawing.Size(111, 28);
            this.bFollow.TabIndex = 10;
            this.bFollow.Text = "Follow";
            this.bFollow.UseVisualStyleBackColor = false;
            this.bFollow.Click += new System.EventHandler(this.bFollow_Click);
            // 
            // lUser
            // 
            this.lUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lUser.AutoSize = true;
            this.lUser.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lUser.Location = new System.Drawing.Point(15, 11);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(47, 23);
            this.lUser.TabIndex = 9;
            this.lUser.TabStop = true;
            this.lUser.Text = "User";
            this.lUser.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lUser_LinkClicked);
            // 
            // UserResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bFollow);
            this.Controls.Add(this.lUser);
            this.Name = "UserResult";
            this.Size = new System.Drawing.Size(399, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFollow;
        private System.Windows.Forms.LinkLabel lUser;

    }
}
