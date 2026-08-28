using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General_Shop_Billing_System;

namespace ShopBillingSystem
{
    public partial class DetailedOrder : Form
    {
        private Methods methods{ get; set; }

        DataAccess Da { get; set; }
        public DetailedOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.methods = new Methods();
        }
        private void DetailedOrder_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
            PopulateGridView("Sale");
            rbSale.Checked = true;
        }
        private void btnBackDetailedOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account account = new Account();
            account.Show();
        }

        private void DetailedOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }
        private void PopulateGridView(string mode)
        {
            string sql = "";

            if (mode == "Sale")
            {
                sql = $@"
                        SELECT *
                        FROM Sales";
            }
            else if (mode == "Purchase")
            {
                sql = $@"
                        SELECT *
                        FROM PurchaseInfo";
            }

            var ds = this.Da.ExecuteQuery(sql);

            dgvDetailedOrder.AutoGenerateColumns = true;
            dgvDetailedOrder.Columns.Clear();
            dgvDetailedOrder.DataSource = ds.Tables[0];

            dgvDetailedOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetailedOrder.MultiSelect = false;
            dgvDetailedOrder.RowHeadersVisible = false;
            dgvDetailedOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void rbSale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSale.Checked)
            {
                PopulateGridView("Sale");
            }
        }
        private void rbPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPurchase.Checked)
            {
                PopulateGridView("Purchase");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtManagerId.Clear();
            txtTransactionId.Clear();
        }

        private void txtManagerId_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtManagerId.Text.Trim();
            string sql = "";

            if (rbSale.Checked)
            {
                sql = $@"
                        SELECT *
                        FROM Sales
                        WHERE ManagerId LIKE '{searchText}%'
                        ORDER BY SaleId ASC";
            }
            else if (rbPurchase.Checked)
            {
                sql = $@"
                        SELECT *
                        FROM PurchaseInfo
                        WHERE ManagerId LIKE '{searchText}%'
                        ORDER BY PurchaseId ASC";
            }

            SearchLikeText(sql);
        }

        private void txtTransactionId_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTransactionId.Text.Trim();
            string sql = "";

            if (rbSale.Checked)
            {
                sql = $@"
                        SELECT *
                        FROM Sales
                        WHERE SaleId LIKE '{searchText}%'
                        ORDER BY SaleId ASC";
            }
            else if (rbPurchase.Checked)
            {
                sql = $@"
                        SELECT *
                        FROM PurchaseInfo
                        WHERE PurchaseId LIKE '{searchText}%'
                        ORDER BY PurchaseId ASC";
            }

            SearchLikeText(sql);
        }

        private void SearchLikeText(string sql)
        { 
            var ds = Da.ExecuteQuery(sql);
            dgvDetailedOrder.DataSource = ds.Tables[0];
            dgvDetailedOrder.Refresh();
        }
    }
}
