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
    public partial class Account : Form
    {
        private Methods methods { get; set; }
        public Account()
        {
            InitializeComponent();
            this.methods = new Methods();
        }
        private void btnBackAccount_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView();
            adminView.Show();
            this.Hide();
        }
        private void btnProductHistory_Click(object sender, EventArgs e)
        {
            DetailedOrder detailedOrder = new DetailedOrder();
            detailedOrder.Show();
            this.Hide();
        }
        private void Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }

        private void Account_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
            CalculateTotals();
        }

        private void CalculateTotals()
        {
            DataAccess Da = new DataAccess();

            string sqlTotalSale = "SELECT SUM(FinalAmount) FROM Sales";
            var dtSale = Da.ExecuteQuery(sqlTotalSale).Tables[0];
            decimal totalSale = Convert.ToDecimal(dtSale.Rows[0][0]);
            txtTotalSell.Text = totalSale.ToString("F2");

            string sqlTotalPurchase = "SELECT SUM(BuyQuantity * BuyPricePerUnit) FROM PurchaseInfo";
            var dtPurchase = Da.ExecuteQuery(sqlTotalPurchase).Tables[0];
            decimal totalPurchase = Convert.ToDecimal(dtPurchase.Rows[0][0]);
            txtTotalPurchase.Text = totalPurchase.ToString("F2");

            decimal profit = totalSale - totalPurchase;
            txtProfit.Text = profit.ToString("F2");
        }
    }
}
