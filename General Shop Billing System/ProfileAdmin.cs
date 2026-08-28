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
    public partial class ProfileAdmin : Form
    {
        private Form PreviousForm { set; get; }
        private string UserIdReference { get; set; }
        private Methods methods { get; set; }
        private DataAccess Da { get; set; }
        public ProfileAdmin(Form previousForm, string userId)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PreviousForm = previousForm;
            UserIdReference = userId;
            this.methods = new Methods();
        }
        private void btnBackProfileAdmin_Click(object sender, EventArgs e)
        {
            if (PreviousForm is ManagerList managerList)
            {
                managerList.RefreshManagerList();
            }
            PreviousForm.Show();
            this.Hide();
        }

        private void ProfileAdmin_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
            LoadUserProfile();
        }
        private void btnUpdateProfileAdmin_Click(object sender, EventArgs e)
        {
            UpdateUserProfile();
        }
        private void ProfileAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || !methods.VerifyName(this.txtName.Text) ||
               !methods.IsValidEmail(this.txtEmail.Text) || !methods.VerifyPhoneNumber(this.txtPhoneNo.Text) ||
                string.IsNullOrEmpty(this.txtNIDNo.Text) ||  string.IsNullOrEmpty(this.txtSalary.Text) ||
                string.IsNullOrEmpty(this.cmbGender.Text) || string.IsNullOrEmpty(this.txtPassword.Text)||
                !methods.IsAgeAtLeast18(this.dtpDOB.Value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LoadUserProfile()
        {
            try
            {
                string userId = UserIdReference;

                string query = "SELECT * FROM UserInfo WHERE UserId = '" + userId + "';";
                DataTable dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];

                    txtUserId.Text = userId;
                    txtName.Text = row["Name"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtPhoneNo.Text = row["PhoneNo"].ToString();
                    dtpDOB.Value = Convert.ToDateTime(row["DateOfBirth"]);
                    txtNIDNo.Text = row["NID"].ToString();
                    txtSalary.Text = row["Salary"].ToString();
                    cmbGender.SelectedItem = row["Gender"].ToString();
                    txtPassword.Text = row["Password"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateUserProfile()
        {
            try
            {
                string userId = UserIdReference;
                var name = this.txtName.Text;
                var email = this.txtEmail.Text;
                var phoneNo = this.txtPhoneNo.Text;
                DateTime dob = this.dtpDOB.Value;
                var nid = this.txtNIDNo.Text;
                decimal salary = Convert.ToDecimal(this.txtSalary.Text);
                var gender = this.cmbGender.SelectedItem;
                var password = this.txtPassword.Text;

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from UserInfo where UserId ='" + userId + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    string sql = $@"
                                    UPDATE UserInfo
                                    SET Name = '{name}',
                                        Email = '{email}',
                                        PhoneNo = '{phoneNo}',
                                        DateOfBirth = '{dob}',
                                        NID = '{nid}',
                                        Salary = {salary},
                                        Gender = '{gender}',
                                        Password = '{password}'
                                    WHERE UserId = '{userId}'";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
