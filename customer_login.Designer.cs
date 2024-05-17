namespace IMS
{
    partial class customer_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_login));
            this.pnlCredentials = new System.Windows.Forms.Panel();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.bttnGoBack = new System.Windows.Forms.Button();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.linkLblRegister = new System.Windows.Forms.LinkLabel();
            this.pnlCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCredentials
            // 
            this.pnlCredentials.Controls.Add(this.linkLblRegister);
            this.pnlCredentials.Controls.Add(this.checkPassword);
            this.pnlCredentials.Controls.Add(this.txtUserPassword);
            this.pnlCredentials.Controls.Add(this.txtUserId);
            this.pnlCredentials.Controls.Add(this.lblUserPassword);
            this.pnlCredentials.Controls.Add(this.lblUserId);
            this.pnlCredentials.Location = new System.Drawing.Point(83, 128);
            this.pnlCredentials.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCredentials.Name = "pnlCredentials";
            this.pnlCredentials.Size = new System.Drawing.Size(625, 245);
            this.pnlCredentials.TabIndex = 9;
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPassword.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkPassword.Location = new System.Drawing.Point(406, 170);
            this.checkPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(170, 27);
            this.checkPassword.TabIndex = 5;
            this.checkPassword.Text = "Show Password";
            this.checkPassword.UseVisualStyleBackColor = true;
            this.checkPassword.CheckedChanged += new System.EventHandler(this.checkPassword_CheckedChanged);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(252, 112);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(330, 30);
            this.txtUserPassword.TabIndex = 4;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(252, 37);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(330, 30);
            this.txtUserId.TabIndex = 3;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblUserPassword.Location = new System.Drawing.Point(18, 112);
            this.lblUserPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(179, 27);
            this.lblUserPassword.TabIndex = 1;
            this.lblUserPassword.Text = "Enter Password:";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblUserId.Location = new System.Drawing.Point(84, 34);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(113, 27);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "Enter ID:";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.Color.Gold;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeader.Font = new System.Drawing.Font("Baskerville Old Face", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(-3, -5);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(840, 107);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "CUSTOMER";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnGoBack
            // 
            this.bttnGoBack.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnGoBack.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnGoBack.Location = new System.Drawing.Point(569, 428);
            this.bttnGoBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnGoBack.Name = "bttnGoBack";
            this.bttnGoBack.Size = new System.Drawing.Size(204, 67);
            this.bttnGoBack.TabIndex = 11;
            this.bttnGoBack.Text = "Go Back";
            this.bttnGoBack.UseVisualStyleBackColor = false;
            this.bttnGoBack.Click += new System.EventHandler(this.bttnGoBack_Click);
            // 
            // bttnLogin
            // 
            this.bttnLogin.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnLogin.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnLogin.Location = new System.Drawing.Point(38, 428);
            this.bttnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(204, 67);
            this.bttnLogin.TabIndex = 10;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = false;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // linkLblRegister
            // 
            this.linkLblRegister.AutoSize = true;
            this.linkLblRegister.Location = new System.Drawing.Point(19, 212);
            this.linkLblRegister.Name = "linkLblRegister";
            this.linkLblRegister.Size = new System.Drawing.Size(207, 23);
            this.linkLblRegister.TabIndex = 12;
            this.linkLblRegister.TabStop = true;
            this.linkLblRegister.Text = "Register an account here.";
            this.linkLblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegister_LinkClicked);
            // 
            // customer_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(838, 513);
            this.Controls.Add(this.pnlCredentials);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.bttnGoBack);
            this.Controls.Add(this.bttnLogin);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "customer_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.pnlCredentials.ResumeLayout(false);
            this.pnlCredentials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCredentials;
        private System.Windows.Forms.CheckBox checkPassword;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button bttnGoBack;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.LinkLabel linkLblRegister;
    }
}