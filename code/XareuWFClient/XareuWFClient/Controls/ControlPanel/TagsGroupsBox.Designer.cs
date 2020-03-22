namespace XareuWFClient.Controls.ControlPanel
{
    partial class TagsGroupsBox
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
            this.tLPTagsGroups = new System.Windows.Forms.TableLayoutPanel();
            this.pGroups = new System.Windows.Forms.Panel();
            this.bCreateGroup = new System.Windows.Forms.Button();
            this.fLPGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.lGroups = new System.Windows.Forms.Label();
            this.pTags = new System.Windows.Forms.Panel();
            this.bAddTag = new System.Windows.Forms.Button();
            this.fLPTags = new System.Windows.Forms.FlowLayoutPanel();
            this.lTags = new System.Windows.Forms.Label();
            this.tLPTagsGroups.SuspendLayout();
            this.pGroups.SuspendLayout();
            this.pTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPTagsGroups
            // 
            this.tLPTagsGroups.ColumnCount = 1;
            this.tLPTagsGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPTagsGroups.Controls.Add(this.pGroups, 0, 1);
            this.tLPTagsGroups.Controls.Add(this.pTags, 0, 0);
            this.tLPTagsGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPTagsGroups.Location = new System.Drawing.Point(0, 0);
            this.tLPTagsGroups.Name = "tLPTagsGroups";
            this.tLPTagsGroups.RowCount = 2;
            this.tLPTagsGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPTagsGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPTagsGroups.Size = new System.Drawing.Size(243, 263);
            this.tLPTagsGroups.TabIndex = 0;
            // 
            // pGroups
            // 
            this.pGroups.Controls.Add(this.bCreateGroup);
            this.pGroups.Controls.Add(this.fLPGroups);
            this.pGroups.Controls.Add(this.lGroups);
            this.pGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGroups.Location = new System.Drawing.Point(3, 134);
            this.pGroups.Name = "pGroups";
            this.pGroups.Size = new System.Drawing.Size(237, 126);
            this.pGroups.TabIndex = 1;
            // 
            // bCreateGroup
            // 
            this.bCreateGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCreateGroup.FlatAppearance.BorderSize = 0;
            this.bCreateGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bCreateGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bCreateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateGroup.Image = global::XareuWFClient.Properties.Resources.add;
            this.bCreateGroup.Location = new System.Drawing.Point(115, 7);
            this.bCreateGroup.Name = "bCreateGroup";
            this.bCreateGroup.Size = new System.Drawing.Size(28, 23);
            this.bCreateGroup.TabIndex = 15;
            this.bCreateGroup.UseVisualStyleBackColor = true;
            this.bCreateGroup.Click += new System.EventHandler(this.bCreateGroup_Click);
            // 
            // fLPGroups
            // 
            this.fLPGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPGroups.Location = new System.Drawing.Point(0, 36);
            this.fLPGroups.Name = "fLPGroups";
            this.fLPGroups.Size = new System.Drawing.Size(237, 90);
            this.fLPGroups.TabIndex = 14;
            // 
            // lGroups
            // 
            this.lGroups.AutoSize = true;
            this.lGroups.BackColor = System.Drawing.Color.Transparent;
            this.lGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.lGroups.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lGroups.Location = new System.Drawing.Point(0, 0);
            this.lGroups.Name = "lGroups";
            this.lGroups.Size = new System.Drawing.Size(109, 36);
            this.lGroups.TabIndex = 12;
            this.lGroups.Text = "Groups";
            // 
            // pTags
            // 
            this.pTags.Controls.Add(this.bAddTag);
            this.pTags.Controls.Add(this.fLPTags);
            this.pTags.Controls.Add(this.lTags);
            this.pTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTags.Location = new System.Drawing.Point(3, 3);
            this.pTags.Name = "pTags";
            this.pTags.Size = new System.Drawing.Size(237, 125);
            this.pTags.TabIndex = 0;
            // 
            // bAddTag
            // 
            this.bAddTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddTag.FlatAppearance.BorderSize = 0;
            this.bAddTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bAddTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddTag.Image = global::XareuWFClient.Properties.Resources.add;
            this.bAddTag.Location = new System.Drawing.Point(85, 7);
            this.bAddTag.Name = "bAddTag";
            this.bAddTag.Size = new System.Drawing.Size(28, 23);
            this.bAddTag.TabIndex = 16;
            this.bAddTag.UseVisualStyleBackColor = true;
            this.bAddTag.Click += new System.EventHandler(this.bAddTag_Click);
            // 
            // fLPTags
            // 
            this.fLPTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPTags.Location = new System.Drawing.Point(0, 36);
            this.fLPTags.Name = "fLPTags";
            this.fLPTags.Size = new System.Drawing.Size(237, 89);
            this.fLPTags.TabIndex = 13;
            // 
            // lTags
            // 
            this.lTags.AutoSize = true;
            this.lTags.BackColor = System.Drawing.Color.Transparent;
            this.lTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTags.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lTags.Location = new System.Drawing.Point(0, 0);
            this.lTags.Name = "lTags";
            this.lTags.Size = new System.Drawing.Size(79, 36);
            this.lTags.TabIndex = 12;
            this.lTags.Text = "Tags";
            // 
            // TagsGroupsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tLPTagsGroups);
            this.Name = "TagsGroupsBox";
            this.Size = new System.Drawing.Size(243, 263);
            this.tLPTagsGroups.ResumeLayout(false);
            this.pGroups.ResumeLayout(false);
            this.pGroups.PerformLayout();
            this.pTags.ResumeLayout(false);
            this.pTags.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPTagsGroups;
        private System.Windows.Forms.Panel pGroups;
        private System.Windows.Forms.Panel pTags;
        private System.Windows.Forms.FlowLayoutPanel fLPGroups;
        private System.Windows.Forms.Label lGroups;
        private System.Windows.Forms.FlowLayoutPanel fLPTags;
        private System.Windows.Forms.Label lTags;
        private System.Windows.Forms.Button bCreateGroup;
        private System.Windows.Forms.Button bAddTag;
    }
}
