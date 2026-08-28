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
    public partial class ManagerView : Form
    {
        private Methods methods { get; set; }

        public ManagerView()
        {
            InitializeComponent();
            this.methods = new Methods();

        }
        private void btnLogOutManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void ManagerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }

        private void btnProductHistory_Click(object sender, EventArgs e)
        {
            ManagerProductHistory managerProductHistory = new ManagerProductHistory(this, Session.SessionUserId);
            this.Hide();
            managerProductHistory.Show();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
        }

        private void btnAddAndUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUpdateProduct addUpdateProduct = new AddUpdateProduct();
            addUpdateProduct.Show();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales sales = new Sales();
            sales.Show();
        }
    }
}
