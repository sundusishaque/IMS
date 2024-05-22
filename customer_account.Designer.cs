
namespace IMS
{
    partial class customer_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_account));
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.bttnAccount = new System.Windows.Forms.Button();
            this.bttnGoBack = new System.Windows.Forms.Button();
            this.bttnCustDelete = new System.Windows.Forms.Button();
            this.bttnCustUpdate = new System.Windows.Forms.Button();
            this.PnlUpdateCustomer = new System.Windows.Forms.Panel();
            this.PnlDeleteCustomer = new System.Windows.Forms.Panel();
            this.bttDeleteCustomer = new System.Windows.Forms.Button();
            this.lblCustPassword = new System.Windows.Forms.Label();
            this.txtCustPassword = new System.Windows.Forms.TextBox();
            this.pnlMenu.SuspendLayout();
            this.PnlUpdateCustomer.SuspendLayout();
            this.PnlDeleteCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnUpdate.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnUpdate.Location = new System.Drawing.Point(230, 147);
            this.bttnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(94, 31);
            this.bttnUpdate.TabIndex = 22;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = false;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(172, 80);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(144, 20);
            this.txtNewPassword.TabIndex = 21;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(155, 33);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(161, 20);
            this.txtOldPassword.TabIndex = 20;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNewPassword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNewPassword.Location = new System.Drawing.Point(3, 80);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(163, 18);
            this.lblNewPassword.TabIndex = 19;
            this.lblNewPassword.Text = "Enter New Password:";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOldPassword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblOldPassword.Location = new System.Drawing.Point(3, 33);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(126, 18);
            this.lblOldPassword.TabIndex = 18;
            this.lblOldPassword.Text = "Enter Password:";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.bttnAccount);
            this.pnlMenu.Controls.Add(this.bttnGoBack);
            this.pnlMenu.Controls.Add(this.bttnCustDelete);
            this.pnlMenu.Controls.Add(this.bttnCustUpdate);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(168, 319);
            this.pnlMenu.TabIndex = 24;
            // 
            // bttnAccount
            // 
            this.bttnAccount.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnAccount.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnAccount.Location = new System.Drawing.Point(-1, 507);
            this.bttnAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnAccount.Name = "bttnAccount";
            this.bttnAccount.Size = new System.Drawing.Size(200, 52);
            this.bttnAccount.TabIndex = 11;
            this.bttnAccount.Text = "Account";
            this.bttnAccount.UseVisualStyleBackColor = false;
            // 
            // bttnGoBack
            // 
            this.bttnGoBack.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnGoBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnGoBack.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnGoBack.Location = new System.Drawing.Point(0, 288);
            this.bttnGoBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnGoBack.Name = "bttnGoBack";
            this.bttnGoBack.Size = new System.Drawing.Size(166, 29);
            this.bttnGoBack.TabIndex = 12;
            this.bttnGoBack.Text = "Go Back";
            this.bttnGoBack.UseVisualStyleBackColor = false;
            this.bttnGoBack.Click += new System.EventHandler(this.bttnGoBack_Click);
            // 
            // bttnCustDelete
            // 
            this.bttnCustDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnCustDelete.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCustDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnCustDelete.Location = new System.Drawing.Point(-2, 155);
            this.bttnCustDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnCustDelete.Name = "bttnCustDelete";
            this.bttnCustDelete.Size = new System.Drawing.Size(167, 29);
            this.bttnCustDelete.TabIndex = 14;
            this.bttnCustDelete.Text = "Delete";
            this.bttnCustDelete.UseVisualStyleBackColor = false;
            this.bttnCustDelete.Click += new System.EventHandler(this.bttnCustDelete_Click);
            // 
            // bttnCustUpdate
            // 
            this.bttnCustUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnCustUpdate.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCustUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnCustUpdate.Location = new System.Drawing.Point(-2, 75);
            this.bttnCustUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnCustUpdate.Name = "bttnCustUpdate";
            this.bttnCustUpdate.Size = new System.Drawing.Size(167, 29);
            this.bttnCustUpdate.TabIndex = 7;
            this.bttnCustUpdate.Text = "Update";
            this.bttnCustUpdate.UseVisualStyleBackColor = false;
            this.bttnCustUpdate.Click += new System.EventHandler(this.bttnCustUpdate_Click);
            // 
            // PnlUpdateCustomer
            // 
            this.PnlUpdateCustomer.Controls.Add(this.bttnUpdate);
            this.PnlUpdateCustomer.Controls.Add(this.txtNewPassword);
            this.PnlUpdateCustomer.Controls.Add(this.lblNewPassword);
            this.PnlUpdateCustomer.Controls.Add(this.txtOldPassword);
            this.PnlUpdateCustomer.Controls.Add(this.lblOldPassword);
            this.PnlUpdateCustomer.Location = new System.Drawing.Point(227, 85);
            this.PnlUpdateCustomer.Name = "PnlUpdateCustomer";
            this.PnlUpdateCustomer.Size = new System.Drawing.Size(324, 181);
            this.PnlUpdateCustomer.TabIndex = 54;
            // 
            // PnlDeleteCustomer
            // 
            this.PnlDeleteCustomer.Controls.Add(this.bttDeleteCustomer);
            this.PnlDeleteCustomer.Controls.Add(this.lblCustPassword);
            this.PnlDeleteCustomer.Controls.Add(this.txtCustPassword);
            this.PnlDeleteCustomer.Location = new System.Drawing.Point(233, 58);
            this.PnlDeleteCustomer.Name = "PnlDeleteCustomer";
            this.PnlDeleteCustomer.Size = new System.Drawing.Size(351, 205);
            this.PnlDeleteCustomer.TabIndex = 55;
            // 
            // bttDeleteCustomer
            // 
            this.bttDeleteCustomer.BackColor = System.Drawing.Color.Goldenrod;
            this.bttDeleteCustomer.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttDeleteCustomer.Location = new System.Drawing.Point(235, 160);
            this.bttDeleteCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttDeleteCustomer.Name = "bttDeleteCustomer";
            this.bttDeleteCustomer.Size = new System.Drawing.Size(89, 33);
            this.bttDeleteCustomer.TabIndex = 18;
            this.bttDeleteCustomer.Text = "Delete";
            this.bttDeleteCustomer.UseVisualStyleBackColor = false;
            this.bttDeleteCustomer.Click += new System.EventHandler(this.bttDeleteCustomer_Click);
            // 
            // lblCustPassword
            // 
            this.lblCustPassword.AutoSize = true;
            this.lblCustPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustPassword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPassword.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCustPassword.Location = new System.Drawing.Point(3, 77);
            this.lblCustPassword.Name = "lblCustPassword";
            this.lblCustPassword.Size = new System.Drawing.Size(126, 18);
            this.lblCustPassword.TabIndex = 17;
            this.lblCustPassword.Text = "Enter Password:";
            // 
            // txtCustPassword
            // 
            this.txtCustPassword.Location = new System.Drawing.Point(145, 74);
            this.txtCustPassword.Name = "txtCustPassword";
            this.txtCustPassword.Size = new System.Drawing.Size(179, 20);
            this.txtCustPassword.TabIndex = 16;
            // 
            // customer_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(622, 319);
            this.Controls.Add(this.PnlDeleteCustomer);
            this.Controls.Add(this.PnlUpdateCustomer);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customer_account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Settings";
            this.Load += new System.EventHandler(this.customer_account_Load);
            this.pnlMenu.ResumeLayout(false);
            this.PnlUpdateCustomer.ResumeLayout(false);
            this.PnlUpdateCustomer.PerformLayout();
            this.PnlDeleteCustomer.ResumeLayout(false);
            this.PnlDeleteCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button bttnAccount;
        private System.Windows.Forms.Button bttnGoBack;
        private System.Windows.Forms.Button bttnCustDelete;
        private System.Windows.Forms.Button bttnCustUpdate;
        private System.Windows.Forms.Panel PnlUpdateCustomer;
        private System.Windows.Forms.Panel PnlDeleteCustomer;
        private System.Windows.Forms.TextBox txtCustPassword;
        private System.Windows.Forms.Label lblCustPassword;
        private System.Windows.Forms.Button bttDeleteCustomer;
    }
}