namespace XareuWFClient.Controls.Group
{
    partial class GroupTitle
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
            this.lGroup = new System.Windows.Forms.Label();
            this.bSubscribe = new System.Windows.Forms.Button();
            this.pTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.Transparent;
            this.pTitle.Controls.Add(this.lGroup);
            this.pTitle.Controls.Add(this.bSubscribe);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(423, 58);
            this.pTitle.TabIndex = 0;
            // 
            // lGroup
            // 
            this.lGroup.AutoSize = true;
            this.lGroup.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
            this.lGroup.Location = new System.Drawing.Point(14, 10);
            this.lGroup.Name = "lGroup";
            this.lGroup.Size = new System.Drawing.Size(88, 33);
            this.lGroup.TabIndex = 11;
            this.lGroup.Text = "Group";
            // 
            // bSubscribe
            // 
            this.bSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bSubscribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSubscribe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubscribe.ForeColor = System.Drawing.Color.White;
            this.bSubscribe.Location = new System.Drawing.Point(296, 15);
            this.bSubscribe.Name = "bSubscribe";
            this.bSubscribe.Size = new System.Drawing.Size(111, 28);
            this.bSubscribe.TabIndex = 10;
            this.bSubscribe.Text = "Subscribe";
            this.bSubscribe.UseVisualStyleBackColor = false;
            // 
            // GroupTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pTitle);
            this.Name = "GroupTitle";
            this.Size = new System.Drawing.Size(423, 58);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Label lGroup;
        private System.Windows.Forms.Button bSubscribe;
    }
}
