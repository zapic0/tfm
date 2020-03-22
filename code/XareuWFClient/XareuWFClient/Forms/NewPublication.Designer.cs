namespace XareuWFClient.Forms
{
    partial class NewPublication
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rTBPublicationText = new System.Windows.Forms.RichTextBox();
            this.pText = new System.Windows.Forms.Panel();
            this.cBQuestion = new System.Windows.Forms.CheckBox();
            this.lQuestions = new System.Windows.Forms.Label();
            this.pTags = new System.Windows.Forms.Panel();
            this.lTags = new System.Windows.Forms.Label();
            this.rTBTags = new System.Windows.Forms.RichTextBox();
            this.tLPOther = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rTBMentions = new System.Windows.Forms.RichTextBox();
            this.lMentions = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rTBGroups = new System.Windows.Forms.RichTextBox();
            this.lGroups = new System.Windows.Forms.Label();
            this.tLPButtons = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bAccept = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.pText.SuspendLayout();
            this.pTags.SuspendLayout();
            this.tLPOther.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tLPButtons.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTBPublicationText
            // 
            this.rTBPublicationText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBPublicationText.BackColor = System.Drawing.Color.White;
            this.rTBPublicationText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBPublicationText.Location = new System.Drawing.Point(3, 39);
            this.rTBPublicationText.Name = "rTBPublicationText";
            this.rTBPublicationText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTBPublicationText.Size = new System.Drawing.Size(583, 162);
            this.rTBPublicationText.TabIndex = 0;
            this.rTBPublicationText.Text = "";
            // 
            // pText
            // 
            this.pText.Controls.Add(this.cBQuestion);
            this.pText.Controls.Add(this.lQuestions);
            this.pText.Controls.Add(this.rTBPublicationText);
            this.pText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pText.Location = new System.Drawing.Point(0, 0);
            this.pText.Name = "pText";
            this.pText.Size = new System.Drawing.Size(589, 205);
            this.pText.TabIndex = 1;
            // 
            // cBQuestion
            // 
            this.cBQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cBQuestion.AutoSize = true;
            this.cBQuestion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.cBQuestion.Location = new System.Drawing.Point(440, 12);
            this.cBQuestion.Name = "cBQuestion";
            this.cBQuestion.Size = new System.Drawing.Size(137, 27);
            this.cBQuestion.TabIndex = 11;
            this.cBQuestion.Text = "Is a question";
            this.cBQuestion.UseVisualStyleBackColor = true;
            // 
            // lQuestions
            // 
            this.lQuestions.AutoSize = true;
            this.lQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lQuestions.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lQuestions.Location = new System.Drawing.Point(0, 0);
            this.lQuestions.Name = "lQuestions";
            this.lQuestions.Size = new System.Drawing.Size(74, 36);
            this.lQuestions.TabIndex = 10;
            this.lQuestions.Text = "Text";
            // 
            // pTags
            // 
            this.pTags.Controls.Add(this.lTags);
            this.pTags.Controls.Add(this.rTBTags);
            this.pTags.Location = new System.Drawing.Point(3, 3);
            this.pTags.Name = "pTags";
            this.pTags.Size = new System.Drawing.Size(190, 102);
            this.pTags.TabIndex = 2;
            // 
            // lTags
            // 
            this.lTags.AutoSize = true;
            this.lTags.BackColor = System.Drawing.Color.Transparent;
            this.lTags.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lTags.Location = new System.Drawing.Point(0, 0);
            this.lTags.Name = "lTags";
            this.lTags.Size = new System.Drawing.Size(79, 36);
            this.lTags.TabIndex = 10;
            this.lTags.Text = "Tags";
            // 
            // rTBTags
            // 
            this.rTBTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBTags.BackColor = System.Drawing.Color.White;
            this.rTBTags.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBTags.Location = new System.Drawing.Point(3, 39);
            this.rTBTags.Name = "rTBTags";
            this.rTBTags.Size = new System.Drawing.Size(184, 59);
            this.rTBTags.TabIndex = 0;
            this.rTBTags.Text = "";
            // 
            // tLPOther
            // 
            this.tLPOther.ColumnCount = 3;
            this.tLPOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPOther.Controls.Add(this.panel2, 2, 0);
            this.tLPOther.Controls.Add(this.panel1, 1, 0);
            this.tLPOther.Controls.Add(this.pTags, 0, 0);
            this.tLPOther.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tLPOther.Location = new System.Drawing.Point(0, 205);
            this.tLPOther.Name = "tLPOther";
            this.tLPOther.RowCount = 1;
            this.tLPOther.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPOther.Size = new System.Drawing.Size(589, 113);
            this.tLPOther.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rTBMentions);
            this.panel2.Controls.Add(this.lMentions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(395, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 107);
            this.panel2.TabIndex = 4;
            // 
            // rTBMentions
            // 
            this.rTBMentions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBMentions.BackColor = System.Drawing.Color.White;
            this.rTBMentions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBMentions.Location = new System.Drawing.Point(4, 39);
            this.rTBMentions.Name = "rTBMentions";
            this.rTBMentions.Size = new System.Drawing.Size(184, 59);
            this.rTBMentions.TabIndex = 11;
            this.rTBMentions.Text = "";
            // 
            // lMentions
            // 
            this.lMentions.AutoSize = true;
            this.lMentions.BackColor = System.Drawing.Color.Transparent;
            this.lMentions.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lMentions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lMentions.Location = new System.Drawing.Point(0, 0);
            this.lMentions.Name = "lMentions";
            this.lMentions.Size = new System.Drawing.Size(134, 36);
            this.lMentions.TabIndex = 10;
            this.lMentions.Text = "Mentions";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rTBGroups);
            this.panel1.Controls.Add(this.lGroups);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(199, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 107);
            this.panel1.TabIndex = 3;
            // 
            // rTBGroups
            // 
            this.rTBGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBGroups.BackColor = System.Drawing.Color.White;
            this.rTBGroups.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBGroups.Location = new System.Drawing.Point(3, 39);
            this.rTBGroups.Name = "rTBGroups";
            this.rTBGroups.Size = new System.Drawing.Size(184, 59);
            this.rTBGroups.TabIndex = 11;
            this.rTBGroups.Text = "";
            // 
            // lGroups
            // 
            this.lGroups.AutoSize = true;
            this.lGroups.BackColor = System.Drawing.Color.Transparent;
            this.lGroups.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lGroups.Location = new System.Drawing.Point(0, 0);
            this.lGroups.Name = "lGroups";
            this.lGroups.Size = new System.Drawing.Size(109, 36);
            this.lGroups.TabIndex = 10;
            this.lGroups.Text = "Groups";
            // 
            // tLPButtons
            // 
            this.tLPButtons.ColumnCount = 2;
            this.tLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPButtons.Controls.Add(this.panel5, 0, 0);
            this.tLPButtons.Controls.Add(this.panel3, 1, 0);
            this.tLPButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tLPButtons.Location = new System.Drawing.Point(0, 318);
            this.tLPButtons.Name = "tLPButtons";
            this.tLPButtons.RowCount = 1;
            this.tLPButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPButtons.Size = new System.Drawing.Size(589, 45);
            this.tLPButtons.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bAccept);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 39);
            this.panel5.TabIndex = 13;
            // 
            // bAccept
            // 
            this.bAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAccept.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccept.ForeColor = System.Drawing.Color.White;
            this.bAccept.Location = new System.Drawing.Point(84, 3);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(121, 33);
            this.bAccept.TabIndex = 0;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = false;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(297, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 39);
            this.panel3.TabIndex = 12;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(84, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 33);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // NewPublication
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(589, 363);
            this.ControlBox = false;
            this.Controls.Add(this.pText);
            this.Controls.Add(this.tLPOther);
            this.Controls.Add(this.tLPButtons);
            this.Name = "NewPublication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Publication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPublication_FormClosing);
            this.pText.ResumeLayout(false);
            this.pText.PerformLayout();
            this.pTags.ResumeLayout(false);
            this.pTags.PerformLayout();
            this.tLPOther.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tLPButtons.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBPublicationText;
        private System.Windows.Forms.Panel pText;
        private System.Windows.Forms.Label lQuestions;
        private System.Windows.Forms.Panel pTags;
        private System.Windows.Forms.Label lTags;
        private System.Windows.Forms.RichTextBox rTBTags;
        private System.Windows.Forms.TableLayoutPanel tLPOther;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rTBMentions;
        private System.Windows.Forms.Label lMentions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rTBGroups;
        private System.Windows.Forms.Label lGroups;
        private System.Windows.Forms.TableLayoutPanel tLPButtons;
        private System.Windows.Forms.CheckBox cBQuestion;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bAccept;
    }
}