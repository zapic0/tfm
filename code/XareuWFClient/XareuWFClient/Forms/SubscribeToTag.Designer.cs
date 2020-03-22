namespace XareuWFClient.Forms
{
    partial class SubscribeToTag
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
            this.lTag = new System.Windows.Forms.Label();
            this.tBTag = new System.Windows.Forms.TextBox();
            this.tLPButtons = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bAccept = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.tLPButtons.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTag
            // 
            this.lTag.AutoSize = true;
            this.lTag.BackColor = System.Drawing.Color.Transparent;
            this.lTag.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.lTag.Location = new System.Drawing.Point(12, 9);
            this.lTag.Name = "lTag";
            this.lTag.Size = new System.Drawing.Size(235, 36);
            this.lTag.TabIndex = 11;
            this.lTag.Text = "Tag to subscribe";
            // 
            // tBTag
            // 
            this.tBTag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTag.Location = new System.Drawing.Point(18, 48);
            this.tBTag.MaxLength = 30;
            this.tBTag.Name = "tBTag";
            this.tBTag.Size = new System.Drawing.Size(229, 27);
            this.tBTag.TabIndex = 12;
            // 
            // tLPButtons
            // 
            this.tLPButtons.ColumnCount = 2;
            this.tLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPButtons.Controls.Add(this.panel5, 0, 0);
            this.tLPButtons.Controls.Add(this.panel3, 1, 0);
            this.tLPButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tLPButtons.Location = new System.Drawing.Point(0, 93);
            this.tLPButtons.Name = "tLPButtons";
            this.tLPButtons.RowCount = 1;
            this.tLPButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPButtons.Size = new System.Drawing.Size(284, 45);
            this.tLPButtons.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bAccept);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 39);
            this.panel5.TabIndex = 13;
            // 
            // bAccept
            // 
            this.bAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAccept.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccept.ForeColor = System.Drawing.Color.White;
            this.bAccept.Location = new System.Drawing.Point(8, 3);
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
            this.panel3.Location = new System.Drawing.Point(145, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 39);
            this.panel3.TabIndex = 12;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(8, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 33);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // SubscribeToTag
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(284, 138);
            this.Controls.Add(this.tLPButtons);
            this.Controls.Add(this.tBTag);
            this.Controls.Add(this.lTag);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 176);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 176);
            this.Name = "SubscribeToTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Subscribe To Tag";
            this.tLPButtons.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTag;
        private System.Windows.Forms.TextBox tBTag;
        private System.Windows.Forms.TableLayoutPanel tLPButtons;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bCancel;
    }
}