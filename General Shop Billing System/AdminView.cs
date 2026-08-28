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
    public partial class AdminView : Form
    {
        private Methods methods { get; set; }
        public AdminView()
        {
            InitializeComponent();
            this.methods = new Methods();
        }
        private void AdminView_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }
        private void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            string userId = Session.SessionUserId;
            this.Hide();
            ProfileAdmin profileAdmin = new ProfileAdmin(this,userId);
            profileAdmin.Show();    
        }

        private void btnViewManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerList managerList = new ManagerList();
            managerList.Show();
        }

        private void AdminView_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }
        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account account = new Account();
            account.Show();
        }
    }
}
