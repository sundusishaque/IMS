namespace IMS
{
    partial class Form1
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
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblDbName = new System.Windows.Forms.Label();
            this.lblDbUserId = new System.Windows.Forms.Label();
            this.lblDbPwd = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.txtDbUserId = new System.Windows.Forms.TextBox();
            this.txtDbPwd = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(12, 40);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(91, 16);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name:";
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbName.Location = new System.Drawing.Point(12, 90);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(111, 16);
            this.lblDbName.TabIndex = 1;
            this.lblDbName.Text = "Database Name:";
            // 
            // lblDbUserId
            // 
            this.lblDbUserId.AutoSize = true;
            this.lblDbUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbUserId.Location = new System.Drawing.Point(12, 142);
            this.lblDbUserId.Name = "lblDbUserId";
            this.lblDbUserId.Size = new System.Drawing.Size(119, 16);
            this.lblDbUserId.TabIndex = 2;
            this.lblDbUserId.Text = "Database User ID:";
            // 
            // lblDbPwd
            // 
            this.lblDbPwd.AutoSize = true;
            this.lblDbPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbPwd.Location = new System.Drawing.Point(12, 203);
            this.lblDbPwd.Name = "lblDbPwd";
            this.lblDbPwd.Size = new System.Drawing.Size(134, 16);
            this.lblDbPwd.TabIndex = 3;
            this.lblDbPwd.Text = "Database Password:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(150, 40);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(194, 20);
            this.txtServerName.TabIndex = 4;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(150, 90);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(194, 20);
            this.txtDbName.TabIndex = 5;
            // 
            // txtDbUserId
            // 
            this.txtDbUserId.Location = new System.Drawing.Point(150, 142);
            this.txtDbUserId.Name = "txtDbUserId";
            this.txtDbUserId.Size = new System.Drawing.Size(194, 20);
            this.txtDbUserId.TabIndex = 6;
            // 
            // txtDbPwd
            // 
            this.txtDbPwd.Location = new System.Drawing.Point(150, 203);
            this.txtDbPwd.Name = "txtDbPwd";
            this.txtDbPwd.Size = new System.Drawing.Size(194, 20);
            this.txtDbPwd.TabIndex = 7;
            this.txtDbPwd.UseSystemPasswordChar = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(150, 261);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 306);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtDbPwd);
            this.Controls.Add(this.txtDbUserId);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblDbPwd);
            this.Controls.Add(this.lblDbUserId);
            this.Controls.Add(this.lblDbName);
            this.Controls.Add(this.lblServerName);
            this.Name = "Form1";
            this.Text = "Connect to Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.Label lblDbUserId;
        private System.Windows.Forms.Label lblDbPwd;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.TextBox txtDbUserId;
        private System.Windows.Forms.TextBox txtDbPwd;
        private System.Windows.Forms.Button btnConnect;
    }
}

