namespace XareuWFClient.Controls.Group
{
    partial class GroupResult
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
            this.lTagText = new System.Windows.Forms.LinkLabel();
            this.bSubscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTagText
            // 
            this.lTagText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lTagText.AutoSize = true;
            this.lTagText.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTagText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lTagText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lTagText.Location = new System.Drawing.Point(13, 11);
            this.lTagText.Name = "lTagText";
            this.lTagText.Size = new System.Drawing.Size(42, 23);
            this.lTagText.TabIndex = 0;
            this.lTagText.TabStop = true;
            this.lTagText.Text = "Tag";
            this.lTagText.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lTagText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lTagText_LinkClicked);
            // 
            // bSubscribe
            // 
            this.bSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bSubscribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSubscribe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubscribe.ForeColor = System.Drawing.Color.White;
            this.bSubscribe.Location = new System.Drawing.Point(271, 6);
            this.bSubscribe.Name = "bSubscribe";
            this.bSubscribe.Size = new System.Drawing.Size(111, 28);
            this.bSubscribe.TabIndex = 8;
            this.bSubscribe.Text = "Subscribe";
            this.bSubscribe.UseVisualStyleBackColor = false;
            this.bSubscribe.Click += new System.EventHandler(this.bSubscribe_Click);
            // 
            // TagResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bSubscribe);
            this.Controls.Add(this.lTagText);
            this.Name = "TagResult";
            this.Size = new System.Drawing.Size(399, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lTagText;
        private System.Windows.Forms.Button bSubscribe;
    }
}
