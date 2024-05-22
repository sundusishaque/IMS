namespace IMS
{
    partial class admin_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_menu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.bttnAccount = new System.Windows.Forms.Button();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.bttnOrders = new System.Windows.Forms.Button();
            this.bttnInventory = new System.Windows.Forms.Button();
            this.bttnCustomer = new System.Windows.Forms.Button();
            this.bttnEmployees = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.picFilter = new System.Windows.Forms.PictureBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.picSortName = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlDataView = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSortName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.bttnAccount);
            this.pnlMenu.Controls.Add(this.bttnLogOut);
            this.pnlMenu.Controls.Add(this.bttnOrders);
            this.pnlMenu.Controls.Add(this.bttnInventory);
            this.pnlMenu.Controls.Add(this.bttnCustomer);
            this.pnlMenu.Controls.Add(this.bttnEmployees);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 650);
            this.pnlMenu.TabIndex = 0;
            // 
            // bttnAccount
            // 
            this.bttnAccount.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnAccount.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnAccount.Location = new System.Drawing.Point(-2, 516);
            this.bttnAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnAccount.Name = "bttnAccount";
            this.bttnAccount.Size = new System.Drawing.Size(200, 52);
            this.bttnAccount.TabIndex = 11;
            this.bttnAccount.Text = "Account";
            this.bttnAccount.UseVisualStyleBackColor = false;
            this.bttnAccount.Click += new System.EventHandler(this.bttnAccount_Click);
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnLogOut.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnLogOut.Location = new System.Drawing.Point(0, 596);
            this.bttnLogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(198, 52);
            this.bttnLogOut.TabIndex = 12;
            this.bttnLogOut.Text = "Log Out";
            this.bttnLogOut.UseVisualStyleBackColor = false;
            this.bttnLogOut.Click += new System.EventHandler(this.bttnLogOut_Click);
            // 
            // bttnOrders
            // 
            this.bttnOrders.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnOrders.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnOrders.Location = new System.Drawing.Point(-2, 319);
            this.bttnOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnOrders.Name = "bttnOrders";
            this.bttnOrders.Size = new System.Drawing.Size(200, 52);
            this.bttnOrders.TabIndex = 12;
            this.bttnOrders.Text = "Orders";
            this.bttnOrders.UseVisualStyleBackColor = false;
            this.bttnOrders.Click += new System.EventHandler(this.bttnOrders_Click);
            // 
            // bttnInventory
            // 
            this.bttnInventory.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnInventory.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnInventory.Location = new System.Drawing.Point(0, 236);
            this.bttnInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnInventory.Name = "bttnInventory";
            this.bttnInventory.Size = new System.Drawing.Size(200, 52);
            this.bttnInventory.TabIndex = 13;
            this.bttnInventory.Text = "Inventory";
            this.bttnInventory.UseVisualStyleBackColor = false;
            this.bttnInventory.Click += new System.EventHandler(this.bttnInventory_Click);
            // 
            // bttnCustomer
            // 
            this.bttnCustomer.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnCustomer.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnCustomer.Location = new System.Drawing.Point(-2, 155);
            this.bttnCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnCustomer.Name = "bttnCustomer";
            this.bttnCustomer.Size = new System.Drawing.Size(200, 52);
            this.bttnCustomer.TabIndex = 14;
            this.bttnCustomer.Text = "Customer";
            this.bttnCustomer.UseVisualStyleBackColor = false;
            this.bttnCustomer.Click += new System.EventHandler(this.bttnCustomer_Click);
            // 
            // bttnEmployees
            // 
            this.bttnEmployees.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnEmployees.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnEmployees.Location = new System.Drawing.Point(-2, 75);
            this.bttnEmployees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnEmployees.Name = "bttnEmployees";
            this.bttnEmployees.Size = new System.Drawing.Size(200, 52);
            this.bttnEmployees.TabIndex = 7;
            this.bttnEmployees.Text = "Employees";
            this.bttnEmployees.UseVisualStyleBackColor = false;
            this.bttnEmployees.Click += new System.EventHandler(this.bttnEmployees_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFilter.Controls.Add(this.picFilter);
            this.pnlFilter.Controls.Add(this.cmbFilter);
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Location = new System.Drawing.Point(409, 40);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(368, 54);
            this.pnlFilter.TabIndex = 0;
            // 
            // picFilter
            // 
            this.picFilter.Image = ((System.Drawing.Image)(resources.GetObject("picFilter.Image")));
            this.picFilter.Location = new System.Drawing.Point(300, 9);
            this.picFilter.Name = "picFilter";
            this.picFilter.Size = new System.Drawing.Size(43, 33);
            this.picFilter.TabIndex = 13;
            this.picFilter.TabStop = false;
            this.picFilter.Click += new System.EventHandler(this.picFilter_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(84, 11);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(197, 22);
            this.cmbFilter.TabIndex = 13;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFilter.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblFilter.Location = new System.Drawing.Point(3, 11);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(53, 18);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "Filter:";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlSearch.Controls.Add(this.picSortName);
            this.pnlSearch.Controls.Add(this.picSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Location = new System.Drawing.Point(139, 12);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(416, 54);
            this.pnlSearch.TabIndex = 0;
            // 
            // picSortName
            // 
            this.picSortName.Image = ((System.Drawing.Image)(resources.GetObject("picSortName.Image")));
            this.picSortName.Location = new System.Drawing.Point(362, 9);
            this.picSortName.Name = "picSortName";
            this.picSortName.Size = new System.Drawing.Size(37, 37);
            this.picSortName.TabIndex = 1;
            this.picSortName.TabStop = false;
            this.picSortName.Click += new System.EventHandler(this.picSortName_Click);
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(310, 9);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(46, 36);
            this.picSearch.TabIndex = 2;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(98, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(206, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSearch.Location = new System.Drawing.Point(3, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(62, 18);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search:";
            // 
            // pnlDataView
            // 
            this.pnlDataView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDataView.Controls.Add(this.dataGridView);
            this.pnlDataView.Controls.Add(this.pnlSearch);
            this.pnlDataView.Location = new System.Drawing.Point(239, 111);
            this.pnlDataView.Name = "pnlDataView";
            this.pnlDataView.Size = new System.Drawing.Size(707, 449);
            this.pnlDataView.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(47, 116);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(612, 217);
            this.dataGridView.TabIndex = 2;
            // 
            // bttnEdit
            // 
            this.bttnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnEdit.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnEdit.Location = new System.Drawing.Point(784, 590);
            this.bttnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(159, 42);
            this.bttnEdit.TabIndex = 12;
            this.bttnEdit.Text = "Edit";
            this.bttnEdit.UseVisualStyleBackColor = false;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(978, 650);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlDataView);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "admin_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin\'s Menu of General Store";
            this.pnlMenu.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSortName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlDataView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlDataView;
        private System.Windows.Forms.Button bttnEmployees;
        private System.Windows.Forms.Button bttnAccount;
        private System.Windows.Forms.Button bttnLogOut;
        private System.Windows.Forms.Button bttnOrders;
        private System.Windows.Forms.Button bttnInventory;
        private System.Windows.Forms.Button bttnCustomer;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox picFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.PictureBox picSortName;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}