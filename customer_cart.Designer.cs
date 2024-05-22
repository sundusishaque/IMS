
namespace IMS
{
    partial class customer_cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_cart));
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.pnlOrderId = new System.Windows.Forms.Panel();
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.bttnGoBack = new System.Windows.Forms.Button();
            this.bttnPlaceOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.pnlOrderId.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(63, 61);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.RowTemplate.Height = 28;
            this.dataGridViewOrders.Size = new System.Drawing.Size(875, 382);
            this.dataGridViewOrders.TabIndex = 49;
            // 
            // pnlOrderId
            // 
            this.pnlOrderId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlOrderId.Controls.Add(this.OrderIdLabel);
            this.pnlOrderId.Controls.Add(this.lblOrderId);
            this.pnlOrderId.Location = new System.Drawing.Point(47, 12);
            this.pnlOrderId.Name = "pnlOrderId";
            this.pnlOrderId.Size = new System.Drawing.Size(252, 43);
            this.pnlOrderId.TabIndex = 50;
            this.pnlOrderId.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrderId_Paint);
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderIdLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.OrderIdLabel.Location = new System.Drawing.Point(115, 16);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(40, 18);
            this.OrderIdLabel.TabIndex = 13;
            this.OrderIdLabel.Text = "here";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderId.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblOrderId.Location = new System.Drawing.Point(9, 16);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(74, 18);
            this.lblOrderId.TabIndex = 12;
            this.lblOrderId.Text = "Order Id";
            // 
            // bttnGoBack
            // 
            this.bttnGoBack.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnGoBack.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnGoBack.Location = new System.Drawing.Point(165, 520);
            this.bttnGoBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnGoBack.Name = "bttnGoBack";
            this.bttnGoBack.Size = new System.Drawing.Size(147, 44);
            this.bttnGoBack.TabIndex = 51;
            this.bttnGoBack.Text = "Go Back";
            this.bttnGoBack.UseVisualStyleBackColor = false;
            this.bttnGoBack.Click += new System.EventHandler(this.bttnGoBack_Click);
            // 
            // bttnPlaceOrder
            // 
            this.bttnPlaceOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.bttnPlaceOrder.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPlaceOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnPlaceOrder.Location = new System.Drawing.Point(717, 520);
            this.bttnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnPlaceOrder.Name = "bttnPlaceOrder";
            this.bttnPlaceOrder.Size = new System.Drawing.Size(146, 44);
            this.bttnPlaceOrder.TabIndex = 52;
            this.bttnPlaceOrder.Text = "Place Order";
            this.bttnPlaceOrder.UseVisualStyleBackColor = false;
            this.bttnPlaceOrder.Click += new System.EventHandler(this.bttnPlaceOrder_Click);
            // 
            // customer_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1064, 653);
            this.Controls.Add(this.bttnPlaceOrder);
            this.Controls.Add(this.bttnGoBack);
            this.Controls.Add(this.pnlOrderId);
            this.Controls.Add(this.dataGridViewOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customer_cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.pnlOrderId.ResumeLayout(false);
            this.pnlOrderId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Panel pnlOrderId;
        private System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Button bttnGoBack;
        private System.Windows.Forms.Button bttnPlaceOrder;
    }
}