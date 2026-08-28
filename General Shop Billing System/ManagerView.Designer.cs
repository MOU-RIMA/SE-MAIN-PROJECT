namespace ShopBillingSystem
{
    partial class ManagerView
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
            this.pnlManagerView = new System.Windows.Forms.Panel();
            this.lblManagerDashboard = new System.Windows.Forms.Label();
            this.btnLogOutManager = new System.Windows.Forms.Button();
            this.lblView = new System.Windows.Forms.Label();
            this.btnProductHistory = new System.Windows.Forms.Button();
            this.btnAddAndUpdate = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.lblProductOperation = new System.Windows.Forms.Label();
            this.pnlManagerView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManagerView
            // 
            this.pnlManagerView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlManagerView.Controls.Add(this.lblManagerDashboard);
            this.pnlManagerView.Controls.Add(this.btnLogOutManager);
            this.pnlManagerView.Controls.Add(this.lblView);
            this.pnlManagerView.Controls.Add(this.btnProductHistory);
            this.pnlManagerView.Controls.Add(this.btnAddAndUpdate);
            this.pnlManagerView.Controls.Add(this.btnSales);
            this.pnlManagerView.Controls.Add(this.lblProductOperation);
            this.pnlManagerView.Location = new System.Drawing.Point(-7, 0);
            this.pnlManagerView.Name = "pnlManagerView";
            this.pnlManagerView.Size = new System.Drawing.Size(1075, 680);
            this.pnlManagerView.TabIndex = 0;
            // 
            // lblManagerDashboard
            // 
            this.lblManagerDashboard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblManagerDashboard.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerDashboard.Location = new System.Drawing.Point(379, 73);
            this.lblManagerDashboard.Name = "lblManagerDashboard";
            this.lblManagerDashboard.Size = new System.Drawing.Size(412, 36);
            this.lblManagerDashboard.TabIndex = 18;
            this.lblManagerDashboard.Text = "Manager Dashboard";
            // 
            // btnLogOutManager
            // 
            this.btnLogOutManager.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogOutManager.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutManager.Location = new System.Drawing.Point(905, 604);
            this.btnLogOutManager.Name = "btnLogOutManager";
            this.btnLogOutManager.Size = new System.Drawing.Size(152, 57);
            this.btnLogOutManager.TabIndex = 17;
            this.btnLogOutManager.Text = "Log Out";
            this.btnLogOutManager.UseVisualStyleBackColor = false;
            this.btnLogOutManager.Click += new System.EventHandler(this.btnLogOutManager_Click);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(601, 170);
            this.lblView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(95, 31);
            this.lblView.TabIndex = 14;
            this.lblView.Text = "View :";
            // 
            // btnProductHistory
            // 
            this.btnProductHistory.BackColor = System.Drawing.Color.Lavender;
            this.btnProductHistory.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductHistory.Location = new System.Drawing.Point(607, 257);
            this.btnProductHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductHistory.Name = "btnProductHistory";
            this.btnProductHistory.Size = new System.Drawing.Size(199, 47);
            this.btnProductHistory.TabIndex = 12;
            this.btnProductHistory.Text = "Product History";
            this.btnProductHistory.UseVisualStyleBackColor = false;
            this.btnProductHistory.Click += new System.EventHandler(this.btnProductHistory_Click);
            // 
            // btnAddAndUpdate
            // 
            this.btnAddAndUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnAddAndUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAndUpdate.Location = new System.Drawing.Point(183, 360);
            this.btnAddAndUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAndUpdate.Name = "btnAddAndUpdate";
            this.btnAddAndUpdate.Size = new System.Drawing.Size(221, 47);
            this.btnAddAndUpdate.TabIndex = 11;
            this.btnAddAndUpdate.Text = "Add and Update";
            this.btnAddAndUpdate.UseVisualStyleBackColor = false;
            this.btnAddAndUpdate.Click += new System.EventHandler(this.btnAddAndUpdate_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Lavender;
            this.btnSales.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(183, 257);
            this.btnSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(221, 47);
            this.btnSales.TabIndex = 10;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // lblProductOperation
            // 
            this.lblProductOperation.AutoSize = true;
            this.lblProductOperation.Font = new System.Drawing.Font("Mongolian Baiti", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductOperation.Location = new System.Drawing.Point(187, 172);
            this.lblProductOperation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductOperation.Name = "lblProductOperation";
            this.lblProductOperation.Size = new System.Drawing.Size(232, 29);
            this.lblProductOperation.TabIndex = 9;
            this.lblProductOperation.Text = "Product Operation :";
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.pnlManagerView);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerView_FormClosing);
            this.Load += new System.EventHandler(this.ManagerView_Load);
            this.pnlManagerView.ResumeLayout(false);
            this.pnlManagerView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManagerView;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnProductHistory;
        private System.Windows.Forms.Button btnAddAndUpdate;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Label lblProductOperation;
        private System.Windows.Forms.Button btnLogOutManager;
        private System.Windows.Forms.Label lblManagerDashboard;
    }
}