using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using ShopBillingSystem;

namespace General_Shop_Billing_System
{
    public partial class AddUser : Form
    {
        private DataAccess Da { get; set; }
        private Methods methods { get; set; }

        public AddUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.methods = new Methods();
        }
        private void btnBackAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView adminView = new AdminView();
            adminView.Show();  
        }
        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserType.SelectedItem != null)
            {
                this.AutoGenerateId(cmbUserType.SelectedItem.ToString());
            }            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                var userType = cmbUserType.SelectedItem;
                var userId = txtUserId.Text;
                var name = methods.FormatName(txtName.Text);
                var email = txtEmail.Text;
                var phoneNo = txtPhoneNo.Text;
                DateTime dob = dtpDOB.Value;
                var nid = txtNIDNo.Text;
                decimal salary = Convert.ToDecimal(txtSalary.Text);
                var gender = cmbGender.SelectedItem;
                var password = txtPassword.Text;
                var query = (@"Insert into UserInfo (UserType, UserId, Name, Email, PhoneNo, DateOfBirth, NID, Salary, Gender, Password)" +
                            "Values ('" + userType + "' ,'" + userId + "','" + name + "','" + email + "','" + phoneNo + "','" + dob + "','" + nid + "','" + salary + "', '" + gender + "','" + password + "') ");
                var dt = Da.ExecuteDMLQuery(query);
                MessageBox.Show("Data added Successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || !methods.VerifyName(this.txtName.Text) ||
               !methods.IsValidEmail(this.txtEmail.Text) || !methods.VerifyPhoneNumber(this.txtPhoneNo.Text) ||
                string.IsNullOrEmpty(this.cmbUserType.Text) || string.IsNullOrEmpty(this.txtNIDNo.Text) ||
                string.IsNullOrEmpty(this.txtSalary.Text) || string.IsNullOrEmpty(this.cmbGender.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text) || !methods.IsAgeAtLeast18(this.dtpDOB.Value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearAll()
        {
            cmbUserType.SelectedIndex = -1;
            txtUserId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();
            dtpDOB.Value = DateTime.Now;
            txtNIDNo.Clear();
            txtSalary.Clear();
            cmbGender.SelectedIndex = -1;
            txtPassword.Clear();
        }
        private void AutoGenerateId(string userType)
        {
            var query = $"select max(UserId) from UserInfo where UserType = '{userType}';";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();

            string newId;

            if (string.IsNullOrEmpty(oldId))
            {
                newId = userType[0] + "-001";
            }
            else
            {
                var s = oldId.Split('-');
                int temp = Convert.ToInt32(s[1]);
                newId = userType[0] + "-" + (++temp).ToString("D3");
            }

            this.txtUserId.Text = newId;
        }
    }
}
