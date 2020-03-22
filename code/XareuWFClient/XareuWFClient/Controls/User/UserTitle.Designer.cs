namespace XareuWFClient.Controls.User
{
    partial class UserTitle
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
            this.pTitle = new System.Windows.Forms.Panel();
            this.lUser = new System.Windows.Forms.Label();
            this.bFollow = new System.Windows.Forms.Button();
            this.pTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.Transparent;
            this.pTitle.Controls.Add(this.lUser);
            this.pTitle.Controls.Add(this.bFollow);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(423, 58);
            this.pTitle.TabIndex = 1;
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lUser.Location = new System.Drawing.Point(14, 10);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(69, 33);
            this.lUser.TabIndex = 11;
            this.lUser.Text = "User";
            // 
            // bFollow
            // 
            this.bFollow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bFollow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFollow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFollow.ForeColor = System.Drawing.Color.White;
            this.bFollow.Location = new System.Drawing.Point(296, 15);
            this.bFollow.Name = "bFollow";
            this.bFollow.Size = new System.Drawing.Size(111, 28);
            this.bFollow.TabIndex = 10;
            this.bFollow.Text = "Follow";
            this.bFollow.UseVisualStyleBackColor = false;
            // 
            // UserTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pTitle);
            this.Name = "UserTitle";
            this.Size = new System.Drawing.Size(423, 58);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Button bFollow;
    }
}
