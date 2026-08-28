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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopBillingSystem
{
    public partial class ManagerList : Form
    {
        private Methods methods { get; set; }
        private DataAccess Da { get; set; }
        public ManagerList()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.methods = new Methods();   
            this.PopulateGridView();
        }
        private void btnBackManagerList_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView adminView = new AdminView();
            adminView.Show();
        }
        private void ManagerList_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
            this.PopulateGridView();
        }
        private void ManagerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }
        private void PopulateGridView(string sql = "select UserId, Name, Email, PhoneNo,DateOfBirth,Salary, Gender from UserInfo where UserType = 'Manager';")
        {
            var dt = this.Da.ExecuteQueryTable(sql);
            this.dgvManagerList.AutoGenerateColumns = true;
            dgvManagerList.Columns.Clear();
            this.dgvManagerList.DataSource = dt;
            dgvManagerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManagerList.MultiSelect = false;
            dgvManagerList.RowHeadersVisible = false;
            dgvManagerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //private void PopulateGridView(string mode)
        //{
        //    string sql = "";

        //    if (mode == "Sell")
        //    {
        //        sql = $@" select * from SalesInfo where ManagerId = '{UserId}' order by SaleSerialNumber asc";
        //    }
        //    else if (mode == "Purchase")
        //    {
        //        sql = $@" select * from PurchaseInfo where ManagerId = '{UserId}' order by PurchaseId asc";
        //    }

        //    var ds = this.Da.ExecuteQuery(sql);

        //    dgvManagerPurchaseHistory.AutoGenerateColumns = true;
        //    dgvManagerPurchaseHistory.Columns.Clear();
        //    dgvManagerPurchaseHistory.DataSource = ds.Tables[0];

        //    dgvManagerPurchaseHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgvManagerPurchaseHistory.MultiSelect = false;
        //    dgvManagerPurchaseHistory.RowHeadersVisible = false;
        //    dgvManagerPurchaseHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //}
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (dgvManagerList.SelectedRows.Count > 0)
            {
                this.Hide();
                string userId = dgvManagerList.SelectedRows[0].Cells["UserId"].Value.ToString();
                ProfileAdmin profileAdmin = new ProfileAdmin(this, userId);
                profileAdmin.Show();
            }
            else
            {
                MessageBox.Show("Please select a manager to edit.");
            }
        }
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from UserInfo where UserType = 'Manager' and Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from UserInfo where UserType = 'Manager' and UserId like '" + this.txtSearchId.Text + "%';";
            this.PopulateGridView(sql);
        }
        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            DeleteUserProfile();
        }
        private void DeleteUserProfile() 
        {
            try
            {
                if (this.dgvManagerList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var userId = this.dgvManagerList.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvManagerList.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure want to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from UserInfo where UserId = '" + userId + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void btnManagerProductHistory_Click(object sender, EventArgs e)
        {
            if (dgvManagerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a manager first.");
                return;
            }

            string selectedManagerId = dgvManagerList.SelectedRows[0].Cells["UserId"].Value.ToString();

            this.Hide();
            ManagerProductHistory managerProductHistory = new ManagerProductHistory(this, selectedManagerId);
            managerProductHistory.Show();
        }
        public void RefreshManagerList()
        {
            this.PopulateGridView();
        }
    }
}