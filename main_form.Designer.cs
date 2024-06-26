﻿namespace IMS
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
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
            this.lblServerName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblServerName.Location = new System.Drawing.Point(74, 55);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(154, 27);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name:";
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDbName.Location = new System.Drawing.Point(46, 114);
            this.lblDbName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(182, 27);
            this.lblDbName.TabIndex = 1;
            this.lblDbName.Text = "Database Name:";
            // 
            // lblDbUserId
            // 
            this.lblDbUserId.AutoSize = true;
            this.lblDbUserId.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbUserId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDbUserId.Location = new System.Drawing.Point(22, 175);
            this.lblDbUserId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDbUserId.Name = "lblDbUserId";
            this.lblDbUserId.Size = new System.Drawing.Size(206, 27);
            this.lblDbUserId.TabIndex = 2;
            this.lblDbUserId.Text = "Database User ID:";
            // 
            // lblDbPwd
            // 
            this.lblDbPwd.AutoSize = true;
            this.lblDbPwd.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbPwd.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDbPwd.Location = new System.Drawing.Point(12, 239);
            this.lblDbPwd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDbPwd.Name = "lblDbPwd";
            this.lblDbPwd.Size = new System.Drawing.Size(216, 27);
            this.lblDbPwd.TabIndex = 3;
            this.lblDbPwd.Text = "Database Password:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(275, 52);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(352, 30);
            this.txtServerName.TabIndex = 4;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(275, 114);
            this.txtDbName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(352, 30);
            this.txtDbName.TabIndex = 5;
            // 
            // txtDbUserId
            // 
            this.txtDbUserId.Location = new System.Drawing.Point(275, 175);
            this.txtDbUserId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDbUserId.Name = "txtDbUserId";
            this.txtDbUserId.Size = new System.Drawing.Size(352, 30);
            this.txtDbUserId.TabIndex = 6;
            // 
            // txtDbPwd
            // 
            this.txtDbPwd.Location = new System.Drawing.Point(275, 239);
            this.txtDbPwd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDbPwd.Name = "txtDbPwd";
            this.txtDbPwd.Size = new System.Drawing.Size(352, 30);
            this.txtDbPwd.TabIndex = 7;
            this.txtDbPwd.UseSystemPasswordChar = true;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConnect.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnect.Location = new System.Drawing.Point(237, 330);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(204, 67);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(726, 432);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtDbPwd);
            this.Controls.Add(this.txtDbUserId);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblDbPwd);
            this.Controls.Add(this.lblDbUserId);
            this.Controls.Add(this.lblDbName);
            this.Controls.Add(this.lblServerName);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

