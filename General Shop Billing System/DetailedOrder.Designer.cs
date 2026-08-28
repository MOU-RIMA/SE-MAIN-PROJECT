namespace ShopBillingSystem
{
    partial class DetailedOrder
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
            this.pnlDetailedOrder = new System.Windows.Forms.Panel();
            this.btnBackDetailedOrder = new System.Windows.Forms.Button();
            this.gpbProductHistoryType = new System.Windows.Forms.GroupBox();
            this.rbPurchase = new System.Windows.Forms.RadioButton();
            this.rbSale = new System.Windows.Forms.RadioButton();
            this.lblProductHistory = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.lblSearchOrderId = new System.Windows.Forms.Label();
            this.dgvDetailedOrder = new System.Windows.Forms.DataGridView();
            this.txtManagerId = new System.Windows.Forms.TextBox();
            this.lblManagerId = new System.Windows.Forms.Label();
            this.lblDetailedOrder = new System.Windows.Forms.Label();
            this.pnlDetailedOrder.SuspendLayout();
            this.gpbProductHistoryType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailedOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetailedOrder
            // 
            this.pnlDetailedOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlDetailedOrder.Controls.Add(this.lblDetailedOrder);
            this.pnlDetailedOrder.Controls.Add(this.dgvDetailedOrder);
            this.pnlDetailedOrder.Controls.Add(this.btnBackDetailedOrder);
            this.pnlDetailedOrder.Controls.Add(this.btnClear);
            this.pnlDetailedOrder.Controls.Add(this.gpbProductHistoryType);
            this.pnlDetailedOrder.Controls.Add(this.lblManagerId);
            this.pnlDetailedOrder.Controls.Add(this.lblSearchOrderId);
            this.pnlDetailedOrder.Controls.Add(this.txtManagerId);
            this.pnlDetailedOrder.Controls.Add(this.txtTransactionId);
            this.pnlDetailedOrder.Controls.Add(this.lblProductHistory);
            this.pnlDetailedOrder.Location = new System.Drawing.Point(-3, -2);
            this.pnlDetailedOrder.Name = "pnlDetailedOrder";
            this.pnlDetailedOrder.Size = new System.Drawing.Size(1384, 780);
            this.pnlDetailedOrder.TabIndex = 0;
            // 
            // btnBackDetailedOrder
            // 
            this.btnBackDetailedOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnBackDetailedOrder.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDetailedOrder.Location = new System.Drawing.Point(1260, 14);
            this.btnBackDetailedOrder.Name = "btnBackDetailedOrder";
            this.btnBackDetailedOrder.Size = new System.Drawing.Size(102, 42);
            this.btnBackDetailedOrder.TabIndex = 66;
            this.btnBackDetailedOrder.Text = "Back";
            this.btnBackDetailedOrder.UseVisualStyleBackColor = false;
            this.btnBackDetailedOrder.Click += new System.EventHandler(this.btnBackDetailedOrder_Click);
            // 
            // gpbProductHistoryType
            // 
            this.gpbProductHistoryType.Controls.Add(this.rbPurchase);
            this.gpbProductHistoryType.Controls.Add(this.rbSale);
            this.gpbProductHistoryType.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductHistoryType.Location = new System.Drawing.Point(14, 51);
            this.gpbProductHistoryType.Margin = new System.Windows.Forms.Padding(2);
            this.gpbProductHistoryType.Name = "gpbProductHistoryType";
            this.gpbProductHistoryType.Padding = new System.Windows.Forms.Padding(2);
            this.gpbProductHistoryType.Size = new System.Drawing.Size(365, 72);
            this.gpbProductHistoryType.TabIndex = 39;
            this.gpbProductHistoryType.TabStop = false;
            this.gpbProductHistoryType.Text = "Product History Type:";
            // 
            // rbPurchase
            // 
            this.rbPurchase.AutoSize = true;
            this.rbPurchase.Location = new System.Drawing.Point(231, 31);
            this.rbPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.rbPurchase.Name = "rbPurchase";
            this.rbPurchase.Size = new System.Drawing.Size(120, 29);
            this.rbPurchase.TabIndex = 1;
            this.rbPurchase.TabStop = true;
            this.rbPurchase.Text = "Purchase";
            this.rbPurchase.UseVisualStyleBackColor = true;
            this.rbPurchase.CheckedChanged += new System.EventHandler(this.rbPurchase_CheckedChanged);
            // 
            // rbSale
            // 
            this.rbSale.AutoSize = true;
            this.rbSale.Location = new System.Drawing.Point(126, 31);
            this.rbSale.Margin = new System.Windows.Forms.Padding(2);
            this.rbSale.Name = "rbSale";
            this.rbSale.Size = new System.Drawing.Size(74, 29);
            this.rbSale.TabIndex = 0;
            this.rbSale.TabStop = true;
            this.rbSale.Text = "Sale";
            this.rbSale.UseVisualStyleBackColor = true;
            this.rbSale.CheckedChanged += new System.EventHandler(this.rbSale_CheckedChanged);
            // 
            // lblProductHistory
            // 
            this.lblProductHistory.AutoSize = true;
            this.lblProductHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblProductHistory.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductHistory.Location = new System.Drawing.Point(2, 183);
            this.lblProductHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductHistory.Name = "lblProductHistory";
            this.lblProductHistory.Size = new System.Drawing.Size(171, 25);
            this.lblProductHistory.TabIndex = 17;
            this.lblProductHistory.Text = "Product History:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Lavender;
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1161, 127);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 28);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Location = new System.Drawing.Point(1046, 89);
            this.txtTransactionId.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(206, 22);
            this.txtTransactionId.TabIndex = 13;
            this.txtTransactionId.TextChanged += new System.EventHandler(this.txtTransactionId_TextChanged);
            // 
            // lblSearchOrderId
            // 
            this.lblSearchOrderId.AutoSize = true;
            this.lblSearchOrderId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSearchOrderId.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOrderId.Location = new System.Drawing.Point(882, 89);
            this.lblSearchOrderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchOrderId.Name = "lblSearchOrderId";
            this.lblSearchOrderId.Size = new System.Drawing.Size(159, 25);
            this.lblSearchOrderId.TabIndex = 10;
            this.lblSearchOrderId.Text = "Transaction Id:";
            // 
            // dgvDetailedOrder
            // 
            this.dgvDetailedOrder.AllowUserToAddRows = false;
            this.dgvDetailedOrder.AllowUserToDeleteRows = false;
            this.dgvDetailedOrder.AllowUserToResizeColumns = false;
            this.dgvDetailedOrder.AllowUserToResizeRows = false;
            this.dgvDetailedOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDetailedOrder.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDetailedOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailedOrder.Location = new System.Drawing.Point(7, 210);
            this.dgvDetailedOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetailedOrder.Name = "dgvDetailedOrder";
            this.dgvDetailedOrder.ReadOnly = true;
            this.dgvDetailedOrder.RowHeadersWidth = 82;
            this.dgvDetailedOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetailedOrder.RowTemplate.Height = 33;
            this.dgvDetailedOrder.Size = new System.Drawing.Size(1363, 559);
            this.dgvDetailedOrder.TabIndex = 67;
            // 
            // txtManagerId
            // 
            this.txtManagerId.Location = new System.Drawing.Point(1046, 52);
            this.txtManagerId.Margin = new System.Windows.Forms.Padding(2);
            this.txtManagerId.Name = "txtManagerId";
            this.txtManagerId.Size = new System.Drawing.Size(206, 22);
            this.txtManagerId.TabIndex = 13;
            this.txtManagerId.TextChanged += new System.EventHandler(this.txtManagerId_TextChanged);
            // 
            // lblManagerId
            // 
            this.lblManagerId.AutoSize = true;
            this.lblManagerId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblManagerId.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerId.Location = new System.Drawing.Point(882, 52);
            this.lblManagerId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManagerId.Name = "lblManagerId";
            this.lblManagerId.Size = new System.Drawing.Size(131, 25);
            this.lblManagerId.TabIndex = 10;
            this.lblManagerId.Text = "Manager Id:";
            // 
            // lblDetailedOrder
            // 
            this.lblDetailedOrder.AutoSize = true;
            this.lblDetailedOrder.Font = new System.Drawing.Font("Mongolian Baiti", 19.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailedOrder.Location = new System.Drawing.Point(549, 11);
            this.lblDetailedOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailedOrder.Name = "lblDetailedOrder";
            this.lblDetailedOrder.Size = new System.Drawing.Size(217, 36);
            this.lblDetailedOrder.TabIndex = 68;
            this.lblDetailedOrder.Text = "Detailed Order";
            // 
            // DetailedOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1371, 771);
            this.Controls.Add(this.pnlDetailedOrder);
            this.Name = "DetailedOrder";
            this.Text = "DetailedOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailedOrder_FormClosing);
            this.Load += new System.EventHandler(this.DetailedOrder_Load);
            this.pnlDetailedOrder.ResumeLayout(false);
            this.pnlDetailedOrder.PerformLayout();
            this.gpbProductHistoryType.ResumeLayout(false);
            this.gpbProductHistoryType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailedOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetailedOrder;
        private System.Windows.Forms.Label lblProductHistory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.Label lblSearchOrderId;
        private System.Windows.Forms.Button btnBackDetailedOrder;
        private System.Windows.Forms.GroupBox gpbProductHistoryType;
        private System.Windows.Forms.RadioButton rbPurchase;
        private System.Windows.Forms.RadioButton rbSale;
        private System.Windows.Forms.DataGridView dgvDetailedOrder;
        private System.Windows.Forms.Label lblManagerId;
        private System.Windows.Forms.TextBox txtManagerId;
        private System.Windows.Forms.Label lblDetailedOrder;
    }
}