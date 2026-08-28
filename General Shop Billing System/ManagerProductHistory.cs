using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopBillingSystem;

namespace General_Shop_Billing_System
{
    public partial class ManagerProductHistory : Form
    {
        private Methods methods { get; set; }
        DataAccess Da { get; set; }
        private Form PreviousForm { get; set; }
        private string UserId { get; set; }
        public ManagerProductHistory(Form previousForm, string userId)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            UserId = userId;
            this.Da = new DataAccess();
            this.methods = new Methods();
        }
        private void ManagerProductHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }
        private void btnBackManagerProductHistory_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Hide();
        }
        private void ManagerProductHistory_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
            rbSell.Checked = true; 
            PopulateGridView("Sell");
        }
        private void PopulateGridView(string mode)
        {
                string sql = "";

                if (mode == "Sell")
                {
                    sql = $@" select * from SalesInfo where ManagerId = '{UserId}' order by SaleSerialNumber asc";
                }
                else if (mode == "Purchase")
                {
                    sql = $@" select * from PurchaseInfo where ManagerId = '{UserId}' order by PurchaseId asc";
                }

                var ds = this.Da.ExecuteQuery(sql);

                dgvManagerPurchaseHistory.AutoGenerateColumns = true;
                dgvManagerPurchaseHistory.Columns.Clear();
                dgvManagerPurchaseHistory.DataSource = ds.Tables[0];

                dgvManagerPurchaseHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvManagerPurchaseHistory.MultiSelect = false;
                dgvManagerPurchaseHistory.RowHeadersVisible = false;
                dgvManagerPurchaseHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void rbSell_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSell.Checked)
            {
                PopulateGridView("Sell");
            }
        }
        private void rbPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPurchase.Checked)
            {
                PopulateGridView("Purchase");
            }
        }
        private void txtOrderIdHistory_TextChanged(object sender, EventArgs e)
        {
            
                string searchText = txtOrderIdHistory.Text.Trim();
                string sql = "";
                if (rbSell.Checked)
                {
                    sql = $@"
                            SELECT *
                            FROM SalesInfo
                            WHERE ManagerId = '{UserId}'
                              AND SaleIdFK LIKE '{searchText}%'
                            ORDER BY SaleSerialNumber ASC";
                }
                else if (rbPurchase.Checked)
                {
                    sql = $@"
                            SELECT *
                            FROM PurchaseInfo
                            WHERE ManagerId = '{UserId}'
                              AND PurchaseId LIKE '{searchText}%'
                            ORDER BY PurchaseId ASC";
                }
                var ds = Da.ExecuteQuery(sql);
                dgvManagerPurchaseHistory.DataSource = ds.Tables[0];
                dgvManagerPurchaseHistory.Refresh();
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderIdHistory.Clear();
        }
    }
}
