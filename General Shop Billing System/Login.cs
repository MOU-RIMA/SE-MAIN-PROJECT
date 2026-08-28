using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShopBillingSystem;

namespace General_Shop_Billing_System
{
    public partial class Login : Form
    {
        private Methods methods { get; set; }   
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess(); 
            this.methods = new Methods();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {                             
            string userId = txtUserId.Text;
            string password = txtPassword.Text;

            // Storing UserId in Session Class
            Session.SessionUserId = userId;

            //var query = $"select UserId,UserType,Password from UserInfo where UserId = '{userId}' and Password = '{password}'";
            var query = $@"
                            SELECT UserId, UserType, Password 
                            FROM UserInfo 
                            WHERE UserId COLLATE Latin1_General_CS_AS = '{userId}'
                              AND Password COLLATE Latin1_General_CS_AS = '{password}'";
            var dt = Da.ExecuteQueryTable(query); 
            if (dt.Rows.Count==1)
            {
                if (dt.Rows[0]["UserType"].ToString()=="Admin")
                {
                    
                    MessageBox.Show("Logged in as admin.", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    this.Hide();
                    AdminView admin = new AdminView();
                    admin.Show();
                    
                    
                }

                else if (dt.Rows[0]["UserType"].ToString() == "Manager")
                {
                    MessageBox.Show("Logged in as Manager.", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ManagerView manager = new ManagerView();
                    manager.Show();  
                }
            }
            else
            {
                MessageBox.Show("Login failed.", "Invalid info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }
    }
}
