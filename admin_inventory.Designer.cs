namespace IMS
{
    partial class admin_inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_inventory));
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnInsert = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.bttnGoBack = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblPrice.Location = new System.Drawing.Point(567, 17);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 27);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuantity.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblQuantity.Location = new System.Drawing.Point(59, 82);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(108, 27);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategory.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCategory.Location = new System.Drawing.Point(530, 82);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(110, 27);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Category:";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.bttnGoBack);
            this.pnlContainer.Controls.Add(this.txtPrice);
            this.pnlContainer.Controls.Add(this.bttnDelete);
            this.pnlContainer.Controls.Add(this.cmbCategory);
            this.pnlContainer.Controls.Add(this.bttnUpdate);
            this.pnlContainer.Controls.Add(this.txtQuantity);
            this.pnlContainer.Controls.Add(this.bttnInsert);
            this.pnlContainer.Controls.Add(this.txtName);
            this.pnlContainer.Controls.Add(this.lblName);
            this.pnlContainer.Controls.Add(this.lblPrice);
            this.pnlContainer.Controls.Add(this.lblQuantity);
            this.pnlContainer.Controls.Add(this.lblCategory);
            this.pnlContainer.Location = new System.Drawing.Point(29, 1);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(909, 230);
            this.pnlContainer.TabIndex = 27;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(652, 17);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(175, 30);
            this.txtPrice.TabIndex = 21;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(652, 82);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(175, 31);
            this.cmbCategory.TabIndex = 25;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(173, 79);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(176, 30);
            this.txtQuantity.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 30);
            this.txtName.TabIndex = 24;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inventoryDataGridView.Location = new System.Drawing.Point(0, 237);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.RowHeadersWidth = 62;
            this.inventoryDataGridView.RowTemplate.Height = 28;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.Size = new System.Drawing.Size(978, 449);
            this.inventoryDataGridView.TabIndex = 28;
            this.inventoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGridView_CellClick);
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
            this.bttnGoBack.TabIndex = 27;
            this.bttnGoBack.Text = "Go Back";
            this.bttnGoBack.UseVisualStyleBackColor = false;
            this.bttnGoBack.Click += new System.EventHandler(this.bttnGoBack_Click);
            // 
            // admin_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(978, 686);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.inventoryDataGridView);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "admin_inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.admin_inventory_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnInsert;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.Button bttnGoBack;
    }
}