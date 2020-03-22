namespace XareuWFClient.Controls.Util
{
    partial class VoteBox
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
            this.lKarma = new System.Windows.Forms.Label();
            this.pKarma = new System.Windows.Forms.Panel();
            this.pVotePositive = new System.Windows.Forms.Panel();
            this.lPositives = new System.Windows.Forms.Label();
            this.pBVotePositive = new System.Windows.Forms.PictureBox();
            this.pVoteNegative = new System.Windows.Forms.Panel();
            this.lNegatives = new System.Windows.Forms.Label();
            this.pBVoteNegative = new System.Windows.Forms.PictureBox();
            this.tLPVotesKarma = new System.Windows.Forms.TableLayoutPanel();
            this.tLPVotes = new System.Windows.Forms.TableLayoutPanel();
            this.pKarma.SuspendLayout();
            this.pVotePositive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBVotePositive)).BeginInit();
            this.pVoteNegative.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBVoteNegative)).BeginInit();
            this.tLPVotesKarma.SuspendLayout();
            this.tLPVotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lKarma
            // 
            this.lKarma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lKarma.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKarma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lKarma.Location = new System.Drawing.Point(0, 0);
            this.lKarma.Name = "lKarma";
            this.lKarma.Size = new System.Drawing.Size(98, 40);
            this.lKarma.TabIndex = 0;
            this.lKarma.Text = "99.9";
            this.lKarma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pKarma
            // 
            this.pKarma.Controls.Add(this.lKarma);
            this.pKarma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pKarma.Location = new System.Drawing.Point(3, 3);
            this.pKarma.Name = "pKarma";
            this.pKarma.Size = new System.Drawing.Size(98, 40);
            this.pKarma.TabIndex = 1;
            // 
            // pVotePositive
            // 
            this.pVotePositive.Controls.Add(this.lPositives);
            this.pVotePositive.Controls.Add(this.pBVotePositive);
            this.pVotePositive.Location = new System.Drawing.Point(3, 3);
            this.pVotePositive.Name = "pVotePositive";
            this.pVotePositive.Size = new System.Drawing.Size(43, 17);
            this.pVotePositive.TabIndex = 1;
            // 
            // lPositives
            // 
            this.lPositives.AutoSize = true;
            this.lPositives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lPositives.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPositives.Location = new System.Drawing.Point(16, 0);
            this.lPositives.Name = "lPositives";
            this.lPositives.Size = new System.Drawing.Size(24, 18);
            this.lPositives.TabIndex = 2;
            this.lPositives.Text = "99";
            // 
            // pBVotePositive
            // 
            this.pBVotePositive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBVotePositive.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBVotePositive.Image = global::XareuWFClient.Properties.Resources.VotePositiveTransparent1;
            this.pBVotePositive.Location = new System.Drawing.Point(0, 0);
            this.pBVotePositive.Name = "pBVotePositive";
            this.pBVotePositive.Size = new System.Drawing.Size(16, 17);
            this.pBVotePositive.TabIndex = 1;
            this.pBVotePositive.TabStop = false;
            this.pBVotePositive.Click += new System.EventHandler(this.pBVotePositive_Click);
            // 
            // pVoteNegative
            // 
            this.pVoteNegative.Controls.Add(this.lNegatives);
            this.pVoteNegative.Controls.Add(this.pBVoteNegative);
            this.pVoteNegative.Location = new System.Drawing.Point(52, 3);
            this.pVoteNegative.Name = "pVoteNegative";
            this.pVoteNegative.Size = new System.Drawing.Size(43, 17);
            this.pVoteNegative.TabIndex = 0;
            // 
            // lNegatives
            // 
            this.lNegatives.AutoSize = true;
            this.lNegatives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lNegatives.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNegatives.Location = new System.Drawing.Point(16, 0);
            this.lNegatives.Name = "lNegatives";
            this.lNegatives.Size = new System.Drawing.Size(24, 18);
            this.lNegatives.TabIndex = 1;
            this.lNegatives.Text = "99";
            // 
            // pBVoteNegative
            // 
            this.pBVoteNegative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBVoteNegative.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBVoteNegative.Image = global::XareuWFClient.Properties.Resources.voteNegative;
            this.pBVoteNegative.Location = new System.Drawing.Point(0, 0);
            this.pBVoteNegative.Name = "pBVoteNegative";
            this.pBVoteNegative.Size = new System.Drawing.Size(16, 17);
            this.pBVoteNegative.TabIndex = 0;
            this.pBVoteNegative.TabStop = false;
            // 
            // tLPVotesKarma
            // 
            this.tLPVotesKarma.ColumnCount = 1;
            this.tLPVotesKarma.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPVotesKarma.Controls.Add(this.tLPVotes, 0, 1);
            this.tLPVotesKarma.Controls.Add(this.pKarma, 0, 0);
            this.tLPVotesKarma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPVotesKarma.Location = new System.Drawing.Point(0, 0);
            this.tLPVotesKarma.Name = "tLPVotesKarma";
            this.tLPVotesKarma.RowCount = 2;
            this.tLPVotesKarma.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tLPVotesKarma.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tLPVotesKarma.Size = new System.Drawing.Size(104, 77);
            this.tLPVotesKarma.TabIndex = 3;
            // 
            // tLPVotes
            // 
            this.tLPVotes.ColumnCount = 2;
            this.tLPVotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPVotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPVotes.Controls.Add(this.pVotePositive, 0, 0);
            this.tLPVotes.Controls.Add(this.pVoteNegative, 1, 0);
            this.tLPVotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPVotes.Location = new System.Drawing.Point(3, 49);
            this.tLPVotes.Name = "tLPVotes";
            this.tLPVotes.RowCount = 1;
            this.tLPVotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPVotes.Size = new System.Drawing.Size(98, 25);
            this.tLPVotes.TabIndex = 4;
            // 
            // VoteBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tLPVotesKarma);
            this.MaximumSize = new System.Drawing.Size(106, 79);
            this.MinimumSize = new System.Drawing.Size(104, 77);
            this.Name = "VoteBox";
            this.Size = new System.Drawing.Size(104, 77);
            this.pKarma.ResumeLayout(false);
            this.pVotePositive.ResumeLayout(false);
            this.pVotePositive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBVotePositive)).EndInit();
            this.pVoteNegative.ResumeLayout(false);
            this.pVoteNegative.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBVoteNegative)).EndInit();
            this.tLPVotesKarma.ResumeLayout(false);
            this.tLPVotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lKarma;
        private System.Windows.Forms.Panel pKarma;
        private System.Windows.Forms.Panel pVotePositive;
        private System.Windows.Forms.Panel pVoteNegative;
        private System.Windows.Forms.PictureBox pBVoteNegative;
        private System.Windows.Forms.PictureBox pBVotePositive;
        private System.Windows.Forms.Label lPositives;
        private System.Windows.Forms.Label lNegatives;
        private System.Windows.Forms.TableLayoutPanel tLPVotesKarma;
        private System.Windows.Forms.TableLayoutPanel tLPVotes;
    }
}
