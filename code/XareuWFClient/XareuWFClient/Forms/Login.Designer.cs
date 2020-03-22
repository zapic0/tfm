namespace XareuWFClient.Forms
{
    partial class Login
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
            this.pExisting = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bLogin = new System.Windows.Forms.Button();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pRegister = new System.Windows.Forms.Panel();
            this.lRegisterTitle = new System.Windows.Forms.Label();
            this.pRegisterControls = new System.Windows.Forms.Panel();
            this.bRegister = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBNewMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tLPLogin = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pExisting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pRegister.SuspendLayout();
            this.pRegisterControls.SuspendLayout();
            this.tLPLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pExisting
            // 
            this.pExisting.Controls.Add(this.label1);
            this.pExisting.Controls.Add(this.panel1);
            this.pExisting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pExisting.Location = new System.Drawing.Point(400, 3);
            this.pExisting.Name = "pExisting";
            this.pExisting.Size = new System.Drawing.Size(381, 451);
            this.pExisting.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Existing User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bLogin);
            this.panel1.Controls.Add(this.tBPassword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tBEmail);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 352);
            this.panel1.TabIndex = 2;
            // 
            // bLogin
            // 
            this.bLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.Color.White;
            this.bLogin.Location = new System.Drawing.Point(207, 103);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(93, 29);
            this.bLogin.TabIndex = 15;
            this.bLogin.Text = "Send";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tBPassword
            // 
            this.tBPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.Location = new System.Drawing.Point(3, 71);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.Size = new System.Drawing.Size(297, 26);
            this.tBPassword.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            // 
            // tBEmail
            // 
            this.tBEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.Location = new System.Drawing.Point(3, 21);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(297, 26);
            this.tBEmail.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "E-mail";
            // 
            // pRegister
            // 
            this.pRegister.Controls.Add(this.lRegisterTitle);
            this.pRegister.Controls.Add(this.pRegisterControls);
            this.pRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRegister.Location = new System.Drawing.Point(3, 3);
            this.pRegister.Name = "pRegister";
            this.pRegister.Size = new System.Drawing.Size(381, 451);
            this.pRegister.TabIndex = 0;
            // 
            // lRegisterTitle
            // 
            this.lRegisterTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lRegisterTitle.AutoSize = true;
            this.lRegisterTitle.BackColor = System.Drawing.Color.Transparent;
            this.lRegisterTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRegisterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.lRegisterTitle.Location = new System.Drawing.Point(62, 0);
            this.lRegisterTitle.Name = "lRegisterTitle";
            this.lRegisterTitle.Size = new System.Drawing.Size(145, 35);
            this.lRegisterTitle.TabIndex = 1;
            this.lRegisterTitle.Text = "New User";
            // 
            // pRegisterControls
            // 
            this.pRegisterControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pRegisterControls.BackColor = System.Drawing.Color.Transparent;
            this.pRegisterControls.Controls.Add(this.bRegister);
            this.pRegisterControls.Controls.Add(this.label10);
            this.pRegisterControls.Controls.Add(this.label6);
            this.pRegisterControls.Controls.Add(this.tBConfirmNewPassword);
            this.pRegisterControls.Controls.Add(this.label5);
            this.pRegisterControls.Controls.Add(this.tBNewPassword);
            this.pRegisterControls.Controls.Add(this.label4);
            this.pRegisterControls.Controls.Add(this.tBNewMail);
            this.pRegisterControls.Controls.Add(this.label3);
            this.pRegisterControls.Controls.Add(this.tBNick);
            this.pRegisterControls.Controls.Add(this.label2);
            this.pRegisterControls.Location = new System.Drawing.Point(68, 42);
            this.pRegisterControls.Name = "pRegisterControls";
            this.pRegisterControls.Size = new System.Drawing.Size(305, 352);
            this.pRegisterControls.TabIndex = 0;
            // 
            // bRegister
            // 
            this.bRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(144)))), ((int)(((byte)(32)))));
            this.bRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegister.ForeColor = System.Drawing.Color.White;
            this.bRegister.Location = new System.Drawing.Point(207, 252);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(93, 29);
            this.bRegister.TabIndex = 16;
            this.bRegister.Text = "Send";
            this.bRegister.UseVisualStyleBackColor = false;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Universe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Location";
            // 
            // tBConfirmNewPassword
            // 
            this.tBConfirmNewPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBConfirmNewPassword.Location = new System.Drawing.Point(3, 171);
            this.tBConfirmNewPassword.Name = "tBConfirmNewPassword";
            this.tBConfirmNewPassword.PasswordChar = '*';
            this.tBConfirmNewPassword.Size = new System.Drawing.Size(297, 26);
            this.tBConfirmNewPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password";
            // 
            // tBNewPassword
            // 
            this.tBNewPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNewPassword.Location = new System.Drawing.Point(3, 121);
            this.tBNewPassword.Name = "tBNewPassword";
            this.tBNewPassword.PasswordChar = '*';
            this.tBNewPassword.Size = new System.Drawing.Size(297, 26);
            this.tBNewPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // tBNewMail
            // 
            this.tBNewMail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNewMail.Location = new System.Drawing.Point(3, 71);
            this.tBNewMail.Name = "tBNewMail";
            this.tBNewMail.Size = new System.Drawing.Size(297, 26);
            this.tBNewMail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // tBNick
            // 
            this.tBNick.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNick.Location = new System.Drawing.Point(3, 21);
            this.tBNick.Name = "tBNick";
            this.tBNick.Size = new System.Drawing.Size(297, 26);
            this.tBNick.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nick";
            // 
            // tLPLogin
            // 
            this.tLPLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tLPLogin.ColumnCount = 3;
            this.tLPLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tLPLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPLogin.Controls.Add(this.pRegister, 0, 0);
            this.tLPLogin.Controls.Add(this.pExisting, 2, 0);
            this.tLPLogin.Controls.Add(this.panel2, 1, 0);
            this.tLPLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPLogin.Location = new System.Drawing.Point(0, 105);
            this.tLPLogin.Name = "tLPLogin";
            this.tLPLogin.RowCount = 1;
            this.tLPLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPLogin.Size = new System.Drawing.Size(784, 457);
            this.tLPLogin.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::XareuWFClient.Properties.Resources.separatorComplete;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(390, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 451);
            this.panel2.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tLPLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Controls.SetChildIndex(this.tLPLogin, 0);
            this.pExisting.ResumeLayout(false);
            this.pExisting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pRegister.ResumeLayout(false);
            this.pRegister.PerformLayout();
            this.pRegisterControls.ResumeLayout(false);
            this.pRegisterControls.PerformLayout();
            this.tLPLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pExisting;
        private System.Windows.Forms.Panel pRegister;
        private System.Windows.Forms.Label lRegisterTitle;
        private System.Windows.Forms.Panel pRegisterControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBNewMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBNick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBConfirmNewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tLPLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bRegister;
    }
}
