namespace IMS
{
    partial class customer_registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_registration));
            this.lblDetails = new System.Windows.Forms.Label();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.bttnRegister = new System.Windows.Forms.Button();
            this.bttnGoBack = new System.Windows.Forms.Button();
            this.CustomerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Baskerville Old Face", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDetails.Location = new System.Drawing.Point(271, 37);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(368, 25);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "Please enter the details asked below.";
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Controls.Add(this.cmbLocation);
            this.CustomerPanel.Controls.Add(this.lblLocation);
            this.CustomerPanel.Controls.Add(this.lblPassword);
            this.CustomerPanel.Controls.Add(this.txtPassword);
            this.CustomerPanel.Controls.Add(this.txtContact);
            this.CustomerPanel.Controls.Add(this.txtCustName);
            this.CustomerPanel.Controls.Add(this.lblContact);
            this.CustomerPanel.Controls.Add(this.lblName);
            this.CustomerPanel.Location = new System.Drawing.Point(186, 84);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(554, 338);
            this.CustomerPanel.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(200, 157);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(330, 23);
            this.txtContact.TabIndex = 8;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(200, 79);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(330, 23);
            this.txtCustName.TabIndex = 7;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblContact.Location = new System.Drawing.Point(35, 162);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(69, 18);
            this.lblContact.TabIndex = 6;
            this.lblContact.Text = "Contact:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblName.Location = new System.Drawing.Point(52, 79);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 18);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(200, 224);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(330, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPassword.Location = new System.Drawing.Point(39, 224);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 18);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblLocation.Location = new System.Drawing.Point(35, 295);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(77, 18);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location:";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Gulshan",
            "Nazimabad"});
            this.cmbLocation.Location = new System.Drawing.Point(200, 291);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(330, 22);
            this.cmbLocation.TabIndex = 14;
            // 
            // bttnRegister
            // 
            this.bttnRegister.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnRegister.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnRegister.Location = new System.Drawing.Point(124, 439);
            this.bttnRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnRegister.Name = "bttnRegister";
            this.bttnRegister.Size = new System.Drawing.Size(204, 67);
            this.bttnRegister.TabIndex = 7;
            this.bttnRegister.Text = "Register";
            this.bttnRegister.UseVisualStyleBackColor = false;
            this.bttnRegister.Click += new System.EventHandler(this.bttnRegister_Click);
            // 
            // bttnGoBack
            // 
            this.bttnGoBack.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnGoBack.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnGoBack.Location = new System.Drawing.Point(623, 439);
            this.bttnGoBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnGoBack.Name = "bttnGoBack";
            this.bttnGoBack.Size = new System.Drawing.Size(204, 67);
            this.bttnGoBack.TabIndex = 8;
            this.bttnGoBack.Text = "Go Back";
            this.bttnGoBack.UseVisualStyleBackColor = false;
            this.bttnGoBack.Click += new System.EventHandler(this.bttnGoBack_Click);
            // 
            // customer_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(978, 518);
            this.Controls.Add(this.bttnGoBack);
            this.Controls.Add(this.bttnRegister);
            this.Controls.Add(this.CustomerPanel);
            this.Controls.Add(this.lblDetails);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "customer_registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Button bttnRegister;
        private System.Windows.Forms.Button bttnGoBack;
    }
}