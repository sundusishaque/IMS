namespace IMS
{
    partial class admin_employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_employees));
            this.bttnInsert = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.bttnGoBack = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnInsert
            // 
            this.bttnInsert.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnInsert.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnInsert.Location = new System.Drawing.Point(8, 161);
            this.bttnInsert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnInsert.Name = "bttnInsert";
            this.bttnInsert.Size = new System.Drawing.Size(159, 42);
            this.bttnInsert.TabIndex = 13;
            this.bttnInsert.Text = "Insert";
            this.bttnInsert.UseVisualStyleBackColor = false;
            this.bttnInsert.Click += new System.EventHandler(this.bttnInsert_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblName.Location = new System.Drawing.Point(86, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 27);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalary.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSalary.Location = new System.Drawing.Point(552, 79);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(81, 27);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Salary:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPosition.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblPosition.Location = new System.Drawing.Point(530, 10);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(103, 27);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "Position:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContact.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblContact.Location = new System.Drawing.Point(69, 82);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(98, 27);
            this.lblContact.TabIndex = 17;
            this.lblContact.Text = "Contact:";
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnUpdate.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnUpdate.Location = new System.Drawing.Point(251, 161);
            this.bttnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(159, 42);
            this.bttnUpdate.TabIndex = 18;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = false;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnDelete.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnDelete.Location = new System.Drawing.Point(502, 161);
            this.bttnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(159, 42);
            this.bttnDelete.TabIndex = 19;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.bttnGoBack);
            this.pnlContainer.Controls.Add(this.txtSalary);
            this.pnlContainer.Controls.Add(this.bttnDelete);
            this.pnlContainer.Controls.Add(this.cmbPosition);
            this.pnlContainer.Controls.Add(this.bttnUpdate);
            this.pnlContainer.Controls.Add(this.txtContact);
            this.pnlContainer.Controls.Add(this.bttnInsert);
            this.pnlContainer.Controls.Add(this.txtName);
            this.pnlContainer.Controls.Add(this.lblName);
            this.pnlContainer.Controls.Add(this.lblSalary);
            this.pnlContainer.Controls.Add(this.lblContact);
            this.pnlContainer.Controls.Add(this.lblPosition);
            this.pnlContainer.Location = new System.Drawing.Point(30, 1);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(909, 230);
            this.pnlContainer.TabIndex = 20;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(639, 79);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(175, 30);
            this.txtSalary.TabIndex = 21;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(639, 10);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(175, 31);
            this.cmbPosition.TabIndex = 25;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(173, 79);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(176, 30);
            this.txtContact.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 30);
            this.txtName.TabIndex = 24;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeDataGridView.Location = new System.Drawing.Point(0, 237);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 62;
            this.employeeDataGridView.RowTemplate.Height = 28;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(978, 449);
            this.employeeDataGridView.TabIndex = 26;
            this.employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellClick);
            // 
            // bttnGoBack
            // 
            this.bttnGoBack.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnGoBack.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnGoBack.Location = new System.Drawing.Point(737, 161);
            this.bttnGoBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnGoBack.Name = "bttnGoBack";
            this.bttnGoBack.Size = new System.Drawing.Size(159, 42);
            this.bttnGoBack.TabIndex = 26;
            this.bttnGoBack.Text = "Go Back";
            this.bttnGoBack.UseVisualStyleBackColor = false;
            this.bttnGoBack.Click += new System.EventHandler(this.bttnGoBack_Click);
            // 
            // admin_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(978, 686);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "admin_employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            this.Load += new System.EventHandler(this.admin_employees_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnInsert;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button bttnGoBack;
    }
}