
namespace IMS
{
    partial class customer_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_menu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.bttnAccount = new System.Windows.Forms.Button();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.bttnPlaceOrder = new System.Windows.Forms.Button();
            this.bttnInventory = new System.Windows.Forms.Button();
            this.bttnOrderHistory = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.picFilter = new System.Windows.Forms.PictureBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlDataView = new System.Windows.Forms.Panel();
            this.PnlDetails = new System.Windows.Forms.Panel();
            this.bttnDetails = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.picSortName = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.bttnViewCart = new System.Windows.Forms.Button();
            this.bttnAddtoCart = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.OrderQtyNum = new System.Windows.Forms.NumericUpDown();
            this.OrderIdNum = new System.Windows.Forms.NumericUpDown();
            this.pnlMenu.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            this.pnlDataView.SuspendLayout();
            this.PnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSortName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderQtyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderIdNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.bttnAccount);
            this.pnlMenu.Controls.Add(this.bttnLogOut);
            this.pnlMenu.Controls.Add(this.bttnPlaceOrder);
            this.pnlMenu.Controls.Add(this.bttnInventory);
            this.pnlMenu.Controls.Add(this.bttnOrderHistory);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(168, 661);
            this.pnlMenu.TabIndex = 1;
            // 
            // bttnAccount
            // 
            this.bttnAccount.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnAccount.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnAccount.Location = new System.Drawing.Point(-1, 507);
            this.bttnAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnAccount.Name = "bttnAccount";
            this.bttnAccount.Size = new System.Drawing.Size(167, 29);
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
            this.bttnLogOut.Location = new System.Drawing.Point(0, 630);
            this.bttnLogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(166, 29);
            this.bttnLogOut.TabIndex = 12;
            this.bttnLogOut.Text = "Log Out";
            this.bttnLogOut.UseVisualStyleBackColor = false;
            this.bttnLogOut.Click += new System.EventHandler(this.bttnLogOut_Click);
            // 
            // bttnPlaceOrder
            // 
            this.bttnPlaceOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnPlaceOrder.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPlaceOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnPlaceOrder.Location = new System.Drawing.Point(-2, 251);
            this.bttnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnPlaceOrder.Name = "bttnPlaceOrder";
            this.bttnPlaceOrder.Size = new System.Drawing.Size(169, 29);
            this.bttnPlaceOrder.TabIndex = 12;
            this.bttnPlaceOrder.Text = "Place Order";
            this.bttnPlaceOrder.UseVisualStyleBackColor = false;
            this.bttnPlaceOrder.Click += new System.EventHandler(this.bttnPlaceOrder_Click);
            // 
            // bttnInventory
            // 
            this.bttnInventory.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnInventory.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnInventory.Location = new System.Drawing.Point(-2, 155);
            this.bttnInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnInventory.Name = "bttnInventory";
            this.bttnInventory.Size = new System.Drawing.Size(169, 29);
            this.bttnInventory.TabIndex = 14;
            this.bttnInventory.Text = "Inventory";
            this.bttnInventory.UseVisualStyleBackColor = false;
            this.bttnInventory.Click += new System.EventHandler(this.bttnInventory_Click);
            // 
            // bttnOrderHistory
            // 
            this.bttnOrderHistory.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnOrderHistory.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnOrderHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnOrderHistory.Location = new System.Drawing.Point(-2, 75);
            this.bttnOrderHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnOrderHistory.Name = "bttnOrderHistory";
            this.bttnOrderHistory.Size = new System.Drawing.Size(169, 29);
            this.bttnOrderHistory.TabIndex = 7;
            this.bttnOrderHistory.Text = "Order History";
            this.bttnOrderHistory.UseVisualStyleBackColor = false;
            this.bttnOrderHistory.Click += new System.EventHandler(this.bttnOrderHistory_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFilter.Controls.Add(this.picFilter);
            this.pnlFilter.Controls.Add(this.cmbFilter);
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Location = new System.Drawing.Point(398, 12);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(360, 50);
            this.pnlFilter.TabIndex = 2;
            // 
            // picFilter
            // 
            this.picFilter.Image = ((System.Drawing.Image)(resources.GetObject("picFilter.Image")));
            this.picFilter.Location = new System.Drawing.Point(300, 9);
            this.picFilter.Name = "picFilter";
            this.picFilter.Size = new System.Drawing.Size(33, 33);
            this.picFilter.TabIndex = 13;
            this.picFilter.TabStop = false;
            this.picFilter.Click += new System.EventHandler(this.picFilter_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Home Appliances",
            "Kitchen Appliances",
            "Mobile Accessories"});
            this.cmbFilter.Location = new System.Drawing.Point(84, 11);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(197, 21);
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
            // pnlDataView
            // 
            this.pnlDataView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDataView.Controls.Add(this.PnlDetails);
            this.pnlDataView.Controls.Add(this.dataGridView);
            this.pnlDataView.Controls.Add(this.pnlSearch);
            this.pnlDataView.Location = new System.Drawing.Point(236, 66);
            this.pnlDataView.Name = "pnlDataView";
            this.pnlDataView.Size = new System.Drawing.Size(612, 342);
            this.pnlDataView.TabIndex = 3;
            // 
            // PnlDetails
            // 
            this.PnlDetails.Controls.Add(this.bttnDetails);
            this.PnlDetails.Location = new System.Drawing.Point(453, 284);
            this.PnlDetails.Margin = new System.Windows.Forms.Padding(2);
            this.PnlDetails.Name = "PnlDetails";
            this.PnlDetails.Size = new System.Drawing.Size(157, 56);
            this.PnlDetails.TabIndex = 50;
            // 
            // bttnDetails
            // 
            this.bttnDetails.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnDetails.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnDetails.Location = new System.Drawing.Point(3, 15);
            this.bttnDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnDetails.Name = "bttnDetails";
            this.bttnDetails.Size = new System.Drawing.Size(146, 33);
            this.bttnDetails.TabIndex = 12;
            this.bttnDetails.Text = "View Details";
            this.bttnDetails.UseVisualStyleBackColor = false;
            this.bttnDetails.Click += new System.EventHandler(this.bttnDetails_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(612, 217);
            this.dataGridView.TabIndex = 1;
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
            this.pnlSearch.Size = new System.Drawing.Size(416, 66);
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
            this.txtSearch.Size = new System.Drawing.Size(206, 20);
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
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlOrder.Controls.Add(this.bttnViewCart);
            this.pnlOrder.Controls.Add(this.bttnAddtoCart);
            this.pnlOrder.Controls.Add(this.lblQuantity);
            this.pnlOrder.Controls.Add(this.lblId);
            this.pnlOrder.Controls.Add(this.OrderQtyNum);
            this.pnlOrder.Controls.Add(this.OrderIdNum);
            this.pnlOrder.Location = new System.Drawing.Point(359, 406);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(372, 104);
            this.pnlOrder.TabIndex = 55;
            // 
            // bttnViewCart
            // 
            this.bttnViewCart.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnViewCart.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnViewCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnViewCart.Location = new System.Drawing.Point(238, 72);
            this.bttnViewCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnViewCart.Name = "bttnViewCart";
            this.bttnViewCart.Size = new System.Drawing.Size(130, 25);
            this.bttnViewCart.TabIndex = 56;
            this.bttnViewCart.Text = "View Cart";
            this.bttnViewCart.UseVisualStyleBackColor = false;
            this.bttnViewCart.Click += new System.EventHandler(this.bttnViewCart_Click);
            // 
            // bttnAddtoCart
            // 
            this.bttnAddtoCart.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnAddtoCart.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddtoCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnAddtoCart.Location = new System.Drawing.Point(12, 72);
            this.bttnAddtoCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnAddtoCart.Name = "bttnAddtoCart";
            this.bttnAddtoCart.Size = new System.Drawing.Size(130, 25);
            this.bttnAddtoCart.TabIndex = 56;
            this.bttnAddtoCart.Text = "Add To Cart";
            this.bttnAddtoCart.UseVisualStyleBackColor = false;
            this.bttnAddtoCart.Click += new System.EventHandler(this.bttnAddtoCart_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuantity.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblQuantity.Location = new System.Drawing.Point(92, 35);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 18);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblId.Location = new System.Drawing.Point(89, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(74, 18);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Enter Id:";
            // 
            // OrderQtyNum
            // 
            this.OrderQtyNum.Location = new System.Drawing.Point(192, 33);
            this.OrderQtyNum.Name = "OrderQtyNum";
            this.OrderQtyNum.Size = new System.Drawing.Size(78, 20);
            this.OrderQtyNum.TabIndex = 6;
            // 
            // OrderIdNum
            // 
            this.OrderIdNum.Location = new System.Drawing.Point(192, 8);
            this.OrderIdNum.Name = "OrderIdNum";
            this.OrderIdNum.Size = new System.Drawing.Size(78, 20);
            this.OrderIdNum.TabIndex = 5;
            // 
            // customer_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(909, 661);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlDataView);
            this.Name = "customer_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer\'s Menu of General Store";
            this.Load += new System.EventHandler(this.customer_menu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            this.pnlDataView.ResumeLayout(false);
            this.PnlDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSortName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderQtyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderIdNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button bttnAccount;
        private System.Windows.Forms.Button bttnLogOut;
        private System.Windows.Forms.Button bttnPlaceOrder;
        private System.Windows.Forms.Button bttnInventory;
        private System.Windows.Forms.Button bttnOrderHistory;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.PictureBox picFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel pnlDataView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox picSortName;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel PnlDetails;
        private System.Windows.Forms.NumericUpDown OrderIdNum;
        private System.Windows.Forms.NumericUpDown OrderQtyNum;
        private System.Windows.Forms.Button bttnDetails;
        private System.Windows.Forms.Button bttnViewCart;
        private System.Windows.Forms.Button bttnAddtoCart;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblId;
    }
}