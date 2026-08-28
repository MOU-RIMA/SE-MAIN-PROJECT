namespace ShopBillingSystem
{
    partial class Account
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
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.btnBackAccount = new System.Windows.Forms.Button();
            this.btnProductHistory = new System.Windows.Forms.Button();
            this.txtTotalSell = new System.Windows.Forms.TextBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtTotalPurchase = new System.Windows.Forms.TextBox();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblTotalPurchase = new System.Windows.Forms.Label();
            this.lblTotalSell = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.pnlAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccount
            // 
            this.pnlAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlAccount.Controls.Add(this.btnBackAccount);
            this.pnlAccount.Controls.Add(this.btnProductHistory);
            this.pnlAccount.Controls.Add(this.txtTotalSell);
            this.pnlAccount.Controls.Add(this.txtProfit);
            this.pnlAccount.Controls.Add(this.txtTotalPurchase);
            this.pnlAccount.Controls.Add(this.lblProfit);
            this.pnlAccount.Controls.Add(this.lblTotalPurchase);
            this.pnlAccount.Controls.Add(this.lblTotalSell);
            this.pnlAccount.Controls.Add(this.lblAccount);
            this.pnlAccount.Location = new System.Drawing.Point(0, -4);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(1068, 684);
            this.pnlAccount.TabIndex = 0;
            // 
            // btnBackAccount
            // 
            this.btnBackAccount.BackColor = System.Drawing.Color.LightCoral;
            this.btnBackAccount.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAccount.Location = new System.Drawing.Point(948, 16);
            this.btnBackAccount.Name = "btnBackAccount";
            this.btnBackAccount.Size = new System.Drawing.Size(102, 42);
            this.btnBackAccount.TabIndex = 66;
            this.btnBackAccount.Text = "Back";
            this.btnBackAccount.UseVisualStyleBackColor = false;
            this.btnBackAccount.Click += new System.EventHandler(this.btnBackAccount_Click);
            // 
            // btnProductHistory
            // 
            this.btnProductHistory.BackColor = System.Drawing.Color.Lavender;
            this.btnProductHistory.Font = new System.Drawing.Font("Mongolian Baiti", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductHistory.Location = new System.Drawing.Point(375, 456);
            this.btnProductHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductHistory.Name = "btnProductHistory";
            this.btnProductHistory.Size = new System.Drawing.Size(330, 58);
            this.btnProductHistory.TabIndex = 41;
            this.btnProductHistory.Text = "View All Product History";
            this.btnProductHistory.UseVisualStyleBackColor = false;
            this.btnProductHistory.Click += new System.EventHandler(this.btnProductHistory_Click);
            // 
            // txtTotalSell
            // 
            this.txtTotalSell.Enabled = false;
            this.txtTotalSell.Location = new System.Drawing.Point(498, 148);
            this.txtTotalSell.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalSell.Name = "txtTotalSell";
            this.txtTotalSell.Size = new System.Drawing.Size(222, 22);
            this.txtTotalSell.TabIndex = 14;
            // 
            // txtProfit
            // 
            this.txtProfit.Enabled = false;
            this.txtProfit.Location = new System.Drawing.Point(498, 353);
            this.txtProfit.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(222, 22);
            this.txtProfit.TabIndex = 13;
            // 
            // txtTotalPurchase
            // 
            this.txtTotalPurchase.Enabled = false;
            this.txtTotalPurchase.Location = new System.Drawing.Point(498, 252);
            this.txtTotalPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPurchase.Name = "txtTotalPurchase";
            this.txtTotalPurchase.Size = new System.Drawing.Size(222, 22);
            this.txtTotalPurchase.TabIndex = 12;
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Mongolian Baiti", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(269, 344);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(91, 29);
            this.lblProfit.TabIndex = 11;
            this.lblProfit.Text = "Profit :";
            // 
            // lblTotalPurchase
            // 
            this.lblTotalPurchase.AutoSize = true;
            this.lblTotalPurchase.Font = new System.Drawing.Font("Mongolian Baiti", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPurchase.Location = new System.Drawing.Point(269, 243);
            this.lblTotalPurchase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPurchase.Name = "lblTotalPurchase";
            this.lblTotalPurchase.Size = new System.Drawing.Size(193, 29);
            this.lblTotalPurchase.TabIndex = 10;
            this.lblTotalPurchase.Text = "Total Purchase :";
            // 
            // lblTotalSell
            // 
            this.lblTotalSell.AutoSize = true;
            this.lblTotalSell.Font = new System.Drawing.Font("Mongolian Baiti", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSell.Location = new System.Drawing.Point(269, 148);
            this.lblTotalSell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSell.Name = "lblTotalSell";
            this.lblTotalSell.Size = new System.Drawing.Size(137, 29);
            this.lblTotalSell.TabIndex = 9;
            this.lblTotalSell.Text = "Total Sell :";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(442, 52);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(137, 36);
            this.lblAccount.TabIndex = 8;
            this.lblAccount.Text = "Account";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.pnlAccount);
            this.Name = "Account";
            this.Text = "Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Account_FormClosing);
            this.Load += new System.EventHandler(this.Account_Load);
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.TextBox txtTotalSell;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtTotalPurchase;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblTotalPurchase;
        private System.Windows.Forms.Label lblTotalSell;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnProductHistory;
        private System.Windows.Forms.Button btnBackAccount;
    }
}