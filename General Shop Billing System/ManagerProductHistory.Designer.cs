namespace General_Shop_Billing_System
{
    partial class ManagerProductHistory
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
            this.pnlManagerPurchaseHistory = new System.Windows.Forms.Panel();
            this.btnBackManagerProductHistory = new System.Windows.Forms.Button();
            this.lblProductHistory = new System.Windows.Forms.Label();
            this.gpbProductHistory = new System.Windows.Forms.GroupBox();
            this.rbPurchase = new System.Windows.Forms.RadioButton();
            this.rbSell = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOrderIdHistory = new System.Windows.Forms.TextBox();
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.dgvManagerPurchaseHistory = new System.Windows.Forms.DataGridView();
            this.pnlManagerPurchaseHistory.SuspendLayout();
            this.gpbProductHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerPurchaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManagerPurchaseHistory
            // 
            this.pnlManagerPurchaseHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlManagerPurchaseHistory.Controls.Add(this.btnBackManagerProductHistory);
            this.pnlManagerPurchaseHistory.Controls.Add(this.lblProductHistory);
            this.pnlManagerPurchaseHistory.Controls.Add(this.gpbProductHistory);
            this.pnlManagerPurchaseHistory.Controls.Add(this.panel1);
            this.pnlManagerPurchaseHistory.Controls.Add(this.dgvManagerPurchaseHistory);
            this.pnlManagerPurchaseHistory.Location = new System.Drawing.Point(-9, 0);
            this.pnlManagerPurchaseHistory.Name = "pnlManagerPurchaseHistory";
            this.pnlManagerPurchaseHistory.Size = new System.Drawing.Size(1469, 756);
            this.pnlManagerPurchaseHistory.TabIndex = 1;
            // 
            // btnBackManagerProductHistory
            // 
            this.btnBackManagerProductHistory.BackColor = System.Drawing.Color.LightCoral;
            this.btnBackManagerProductHistory.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackManagerProductHistory.Location = new System.Drawing.Point(1354, 12);
            this.btnBackManagerProductHistory.Name = "btnBackManagerProductHistory";
            this.btnBackManagerProductHistory.Size = new System.Drawing.Size(102, 42);
            this.btnBackManagerProductHistory.TabIndex = 66;
            this.btnBackManagerProductHistory.Text = "Back";
            this.btnBackManagerProductHistory.UseVisualStyleBackColor = false;
            this.btnBackManagerProductHistory.Click += new System.EventHandler(this.btnBackManagerProductHistory_Click);
            // 
            // lblProductHistory
            // 
            this.lblProductHistory.AutoSize = true;
            this.lblProductHistory.Font = new System.Drawing.Font("Mongolian Baiti", 19.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductHistory.Location = new System.Drawing.Point(640, 9);
            this.lblProductHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductHistory.Name = "lblProductHistory";
            this.lblProductHistory.Size = new System.Drawing.Size(230, 36);
            this.lblProductHistory.TabIndex = 44;
            this.lblProductHistory.Text = "Product History";
            // 
            // gpbProductHistory
            // 
            this.gpbProductHistory.Controls.Add(this.rbPurchase);
            this.gpbProductHistory.Controls.Add(this.rbSell);
            this.gpbProductHistory.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductHistory.Location = new System.Drawing.Point(20, 60);
            this.gpbProductHistory.Margin = new System.Windows.Forms.Padding(2);
            this.gpbProductHistory.Name = "gpbProductHistory";
            this.gpbProductHistory.Padding = new System.Windows.Forms.Padding(2);
            this.gpbProductHistory.Size = new System.Drawing.Size(402, 77);
            this.gpbProductHistory.TabIndex = 40;
            this.gpbProductHistory.TabStop = false;
            this.gpbProductHistory.Text = "History Type:";
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
            // rbSell
            // 
            this.rbSell.AutoSize = true;
            this.rbSell.Location = new System.Drawing.Point(126, 31);
            this.rbSell.Margin = new System.Windows.Forms.Padding(2);
            this.rbSell.Name = "rbSell";
            this.rbSell.Size = new System.Drawing.Size(69, 29);
            this.rbSell.TabIndex = 0;
            this.rbSell.TabStop = true;
            this.rbSell.Text = "Sell";
            this.rbSell.UseVisualStyleBackColor = true;
            this.rbSell.CheckedChanged += new System.EventHandler(this.rbSell_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtOrderIdHistory);
            this.panel1.Controls.Add(this.lblTransactionId);
            this.panel1.Location = new System.Drawing.Point(987, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 87);
            this.panel1.TabIndex = 38;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Lavender;
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(324, 40);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 37);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOrderIdHistory
            // 
            this.txtOrderIdHistory.Location = new System.Drawing.Point(169, 9);
            this.txtOrderIdHistory.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderIdHistory.Name = "txtOrderIdHistory";
            this.txtOrderIdHistory.Size = new System.Drawing.Size(233, 22);
            this.txtOrderIdHistory.TabIndex = 13;
            this.txtOrderIdHistory.TextChanged += new System.EventHandler(this.txtOrderIdHistory_TextChanged);
            // 
            // lblTransactionId
            // 
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTransactionId.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionId.Location = new System.Drawing.Point(8, 9);
            this.lblTransactionId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(165, 25);
            this.lblTransactionId.TabIndex = 10;
            this.lblTransactionId.Text = "Transaction Id: ";
            // 
            // dgvManagerPurchaseHistory
            // 
            this.dgvManagerPurchaseHistory.AllowUserToAddRows = false;
            this.dgvManagerPurchaseHistory.AllowUserToDeleteRows = false;
            this.dgvManagerPurchaseHistory.AllowUserToResizeColumns = false;
            this.dgvManagerPurchaseHistory.AllowUserToResizeRows = false;
            this.dgvManagerPurchaseHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvManagerPurchaseHistory.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvManagerPurchaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagerPurchaseHistory.Location = new System.Drawing.Point(14, 152);
            this.dgvManagerPurchaseHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvManagerPurchaseHistory.Name = "dgvManagerPurchaseHistory";
            this.dgvManagerPurchaseHistory.ReadOnly = true;
            this.dgvManagerPurchaseHistory.RowHeadersWidth = 82;
            this.dgvManagerPurchaseHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvManagerPurchaseHistory.RowTemplate.Height = 33;
            this.dgvManagerPurchaseHistory.Size = new System.Drawing.Size(1442, 588);
            this.dgvManagerPurchaseHistory.TabIndex = 18;
            // 
            // ManagerProductHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1449, 746);
            this.Controls.Add(this.pnlManagerPurchaseHistory);
            this.Name = "ManagerProductHistory";
            this.Text = "ManagerProductHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerProductHistory_FormClosing);
            this.Load += new System.EventHandler(this.ManagerProductHistory_Load);
            this.pnlManagerPurchaseHistory.ResumeLayout(false);
            this.pnlManagerPurchaseHistory.PerformLayout();
            this.gpbProductHistory.ResumeLayout(false);
            this.gpbProductHistory.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerPurchaseHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManagerPurchaseHistory;
        private System.Windows.Forms.DataGridView dgvManagerPurchaseHistory;
        private System.Windows.Forms.Label lblProductHistory;
        private System.Windows.Forms.Button btnBackManagerProductHistory;
        private System.Windows.Forms.GroupBox gpbProductHistory;
        private System.Windows.Forms.RadioButton rbPurchase;
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOrderIdHistory;
        private System.Windows.Forms.Label lblTransactionId;
    }
}