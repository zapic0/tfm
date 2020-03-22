namespace XareuWFClient
{
    partial class FBasicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBasicForm));
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.pLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.pLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBLogo
            // 
            this.pBLogo.BackColor = System.Drawing.Color.White;
            this.pBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBLogo.Image")));
            this.pBLogo.InitialImage = null;
            this.pBLogo.Location = new System.Drawing.Point(0, 0);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(247, 104);
            this.pBLogo.TabIndex = 0;
            this.pBLogo.TabStop = false;
            // 
            // pLogo
            // 
            this.pLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLogo.BackgroundImage")));
            this.pLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pLogo.Controls.Add(this.pBLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(784, 105);
            this.pLogo.TabIndex = 2;
            // 
            // FBasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pLogo);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FBasicForm";
            this.Text = "FBasicForm";
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.pLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBLogo;
        private System.Windows.Forms.Panel pLogo;
    }
}