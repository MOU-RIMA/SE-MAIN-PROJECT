namespace ShopBillingSystem
{
    partial class ManagerList
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
            this.pnlManagerList = new System.Windows.Forms.Panel();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnManagerProductHistory = new System.Windows.Forms.Button();
            this.btnBackManagerList = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.lblSearchById = new System.Windows.Forms.Label();
            this.lblManagerList = new System.Windows.Forms.Label();
            this.dgvManagerList = new System.Windows.Forms.DataGridView();
            this.pnlManagerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManagerList
            // 
            this.pnlManagerList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlManagerList.Controls.Add(this.txtSearchId);
            this.pnlManagerList.Controls.Add(this.txtAutoSearch);
            this.pnlManagerList.Controls.Add(this.btnDeleteProfile);
            this.pnlManagerList.Controls.Add(this.btnManagerProductHistory);
            this.pnlManagerList.Controls.Add(this.btnBackManagerList);
            this.pnlManagerList.Controls.Add(this.btnEditProfile);
            this.pnlManagerList.Controls.Add(this.lblSearchByName);
            this.pnlManagerList.Controls.Add(this.lblSearchById);
            this.pnlManagerList.Controls.Add(this.lblManagerList);
            this.pnlManagerList.Controls.Add(this.dgvManagerList);
            this.pnlManagerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManagerList.Location = new System.Drawing.Point(0, 0);
            this.pnlManagerList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlManagerList.Name = "pnlManagerList";
            this.pnlManagerList.Size = new System.Drawing.Size(1400, 939);
            this.pnlManagerList.TabIndex = 0;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(17, 211);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(212, 26);
            this.txtSearchId.TabIndex = 68;
            this.txtSearchId.TextChanged += new System.EventHandler(this.txtSearchId_TextChanged);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(310, 210);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(212, 26);
            this.txtAutoSearch.TabIndex = 67;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.BackColor = System.Drawing.Color.Lavender;
            this.btnDeleteProfile.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProfile.Location = new System.Drawing.Point(981, 176);
            this.btnDeleteProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(197, 61);
            this.btnDeleteProfile.TabIndex = 53;
            this.btnDeleteProfile.Text = "Delete Profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = false;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnManagerProductHistory
            // 
            this.btnManagerProductHistory.BackColor = System.Drawing.Color.Lavender;
            this.btnManagerProductHistory.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerProductHistory.Location = new System.Drawing.Point(1185, 178);
            this.btnManagerProductHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnManagerProductHistory.Name = "btnManagerProductHistory";
            this.btnManagerProductHistory.Size = new System.Drawing.Size(209, 61);
            this.btnManagerProductHistory.TabIndex = 53;
            this.btnManagerProductHistory.Text = "Product History";
            this.btnManagerProductHistory.UseVisualStyleBackColor = false;
            this.btnManagerProductHistory.Click += new System.EventHandler(this.btnManagerProductHistory_Click);
            // 
            // btnBackManagerList
            // 
            this.btnBackManagerList.BackColor = System.Drawing.Color.LightCoral;
            this.btnBackManagerList.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackManagerList.Location = new System.Drawing.Point(1281, 20);
            this.btnBackManagerList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackManagerList.Name = "btnBackManagerList";
            this.btnBackManagerList.Size = new System.Drawing.Size(115, 52);
            this.btnBackManagerList.TabIndex = 66;
            this.btnBackManagerList.Text = "Back";
            this.btnBackManagerList.UseVisualStyleBackColor = false;
            this.btnBackManagerList.Click += new System.EventHandler(this.btnBackManagerList_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Lavender;
            this.btnEditProfile.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(777, 176);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(197, 61);
            this.btnEditProfile.TabIndex = 52;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByName.Location = new System.Drawing.Point(316, 176);
            this.lblSearchByName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(164, 27);
            this.lblSearchByName.TabIndex = 39;
            this.lblSearchByName.Text = "Search by Name:";
            // 
            // lblSearchById
            // 
            this.lblSearchById.AutoSize = true;
            this.lblSearchById.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchById.Location = new System.Drawing.Point(12, 176);
            this.lblSearchById.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchById.Name = "lblSearchById";
            this.lblSearchById.Size = new System.Drawing.Size(129, 27);
            this.lblSearchById.TabIndex = 39;
            this.lblSearchById.Text = "Search by Id:";
            // 
            // lblManagerList
            // 
            this.lblManagerList.AutoSize = true;
            this.lblManagerList.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerList.Location = new System.Drawing.Point(594, 21);
            this.lblManagerList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManagerList.Name = "lblManagerList";
            this.lblManagerList.Size = new System.Drawing.Size(243, 49);
            this.lblManagerList.TabIndex = 39;
            this.lblManagerList.Text = "Manager  List";
            // 
            // dgvManagerList
            // 
            this.dgvManagerList.AllowUserToAddRows = false;
            this.dgvManagerList.AllowUserToDeleteRows = false;
            this.dgvManagerList.AllowUserToResizeColumns = false;
            this.dgvManagerList.AllowUserToResizeRows = false;
            this.dgvManagerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManagerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvManagerList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvManagerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagerList.Location = new System.Drawing.Point(0, 244);
            this.dgvManagerList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvManagerList.Name = "dgvManagerList";
            this.dgvManagerList.ReadOnly = true;
            this.dgvManagerList.RowHeadersWidth = 82;
            this.dgvManagerList.RowTemplate.Height = 33;
            this.dgvManagerList.Size = new System.Drawing.Size(1400, 695);
            this.dgvManagerList.TabIndex = 3;
            // 
            // ManagerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 939);
            this.Controls.Add(this.pnlManagerList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerList";
            this.Text = "ManagerList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerList_FormClosing);
            this.Load += new System.EventHandler(this.ManagerList_Load);
            this.pnlManagerList.ResumeLayout(false);
            this.pnlManagerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManagerList;
        private System.Windows.Forms.DataGridView dgvManagerList;
        private System.Windows.Forms.Label lblManagerList;
        private System.Windows.Forms.Button btnBackManagerList;
        private System.Windows.Forms.Button btnManagerProductHistory;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.TextBox txtSearchId;
    }
}