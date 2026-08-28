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
    public partial class AddUpdateProduct : Form
    {

        private DataAccess Da { get; set; }
        private Methods methods { get; set; }
        string userId = Session.SessionUserId;
        public AddUpdateProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.methods = new Methods();

        }

        private void btnBackAddUpdateProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerView managerView = new ManagerView();
            managerView.Show();

        }
        private void AddUpdateProduct_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
            this.PopulateGridView();
            PopulateCategoryComboBox();
        }

        private void AddUpdateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }
        private void PopulateGridView(string sql = "select * from ProductInfo")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvAddUpdateProduct.AutoGenerateColumns = true;
            this.dgvAddUpdateProduct.Columns.Clear();// to remove duplicated columns
            this.dgvAddUpdateProduct.DataSource = ds.Tables[0];

            this.dgvAddUpdateProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddUpdateProduct.MultiSelect = false;
            this.dgvAddUpdateProduct.RowHeadersVisible = false;
            this.dgvAddUpdateProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void PopulateCategoryComboBox()
        {
            try
            {
                string sql = "select distinct Category from ProductInfo";
                var ds = this.Da.ExecuteQuery(sql);

                cmbCategory.Items.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmbCategory.Items.Add(row["Category"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }


        

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperation.Text == "Add Product")
            {
                ClearFields();
                AutoGenerateId("P-");
            }
            else if (cmbOperation.Text == "Update Product")
            {
                ClearFields();
            }
        }

        private void dgvAddUpdateProduct_DoubleClick(object sender, EventArgs e)
        {
            cmbOperation.Text = "Update Product";
            txtProductId.Text = this.dgvAddUpdateProduct.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = this.dgvAddUpdateProduct.CurrentRow.Cells[1].Value.ToString();
            cmbCategory.Text = this.dgvAddUpdateProduct.CurrentRow.Cells[2].Value.ToString();
            txtQuantity.Text = this.dgvAddUpdateProduct.CurrentRow.Cells[3].Value.ToString();
            txtPricePerUnit.Text = this.dgvAddUpdateProduct.CurrentRow.Cells[4].Value.ToString();
            

            decimal quantity = 0;
            decimal pricePerUnit = 0;
            decimal.TryParse(txtQuantity.Text, out quantity);
            decimal.TryParse(txtPricePerUnit.Text, out pricePerUnit);

            
            txtTotalPrice.Text = (quantity * pricePerUnit).ToString("F2");

            


        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from ProductInfo where ProductId like '" + this.txtSearchById.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void txtSearchProductName_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from ProductInfo where  ProductName like '" + this.txtSearchProductName.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AutoGenerateId("B-");

            UpdateProductInfo();
            UpdatePurchaseInfo();
            this.PopulateGridView();
        }


        private bool IsValidToSave()
        {
            if (
                string.IsNullOrEmpty(this.txtProductName.Text) ||
                string.IsNullOrEmpty(this.cmbCategory.Text) || string.IsNullOrEmpty(this.txtQuantity.Text) ||
                string.IsNullOrEmpty(this.txtPricePerUnit.Text) || string.IsNullOrEmpty(this.txtTotalPrice.Text)
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void UpdateTotalPrice()
        {
            decimal quantity = 0;
            decimal pricePerUnit = 0;

            decimal.TryParse(txtQuantity.Text, out quantity);
            decimal.TryParse(txtPricePerUnit.Text, out pricePerUnit);

            txtTotalPrice.Text = (quantity * pricePerUnit).ToString("F2");
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void txtPricePerUnit_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateProductInfo()
        {
            if (cmbOperation.Text == "Update Product")
            {
                try
                {
                    var dt = this.Da.ExecuteQueryTable($"SELECT TotalQuantity, AvgPricePerUnit FROM ProductInfo WHERE ProductId = '{this.txtProductId.Text}'");

                    int oldQuantity = 0;
                    decimal oldAvgPricePerUnit = 0m;

                    if (dt.Rows.Count > 0)
                    {
                        int.TryParse(dt.Rows[0]["TotalQuantity"].ToString(), out oldQuantity);
                        decimal.TryParse(dt.Rows[0]["AvgPricePerUnit"].ToString(), out oldAvgPricePerUnit);
                    }


                    var productId = this.txtProductId.Text;
                    var productName = this.txtProductName.Text;
                    var category = this.cmbCategory.Text;

                    int addedQuantity = 0;
                    decimal newPricePerUnit = 0m;

                    int.TryParse(this.txtQuantity.Text, out addedQuantity);
                    decimal.TryParse(this.txtPricePerUnit.Text, out newPricePerUnit);


                    int newQuantity = oldQuantity + addedQuantity;

                    decimal updatedPricePerUnit = 0m;
                    if (newQuantity > 0)
                    {
                        updatedPricePerUnit = ((oldQuantity * oldAvgPricePerUnit) + (addedQuantity * newPricePerUnit)) / newQuantity;
                    }

                    decimal sellPricePerUnit = updatedPricePerUnit + (updatedPricePerUnit * 0.2m);


                    if (!this.IsValidToSave())
                    {
                        MessageBox.Show("Please fill all the empty fields");
                        return;
                    }
                    if (!cmbCategory.Items.Contains(cmbCategory.Text))
                    {
                        cmbCategory.Items.Add(cmbCategory.Text);
                    }

                    string updateSql = $@"
                                        UPDATE ProductInfo
                                        SET ProductName = '{productName}',
                                            Category = '{category}',
                                            TotalQuantity = {newQuantity},
                                            AvgPricePerUnit = {updatedPricePerUnit},
                                            SellPricePerUnit = {sellPricePerUnit}
                                        WHERE ProductId = '{productId}'";

                    int count = this.Da.ExecuteDMLQuery(updateSql);

                    if (count == 1)
                        MessageBox.Show("Product updated successfully.");
                    else
                        MessageBox.Show("Failed to update product.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbOperation.Text == "Add Product")
            {
                try
                {
                    if (!this.IsValidToSave())
                    {
                        MessageBox.Show("Please fill all the empty fields");
                        return;
                    }
                    if (!cmbCategory.Items.Contains(cmbCategory.Text))
                    {
                        cmbCategory.Items.Add(cmbCategory.Text);
                    }
                    var productId = this.txtProductId.Text;
                    var productName = this.txtProductName.Text;
                    var category = this.cmbCategory.Text;
                    int quantity = 0;
                    decimal pricePerUnit = 0m;
                    int.TryParse(this.txtQuantity.Text, out quantity);
                    decimal.TryParse(this.txtPricePerUnit.Text, out pricePerUnit);
                    decimal sellPricePerUnit = pricePerUnit + (pricePerUnit * 0.2m);
                    string insertSql = $@"
                                        INSERT INTO ProductInfo (ProductId, ProductName, Category, TotalQuantity, AvgPricePerUnit, SellPricePerUnit)
                                        VALUES ('{productId}', '{productName}', '{category}', {quantity}, {pricePerUnit}, {sellPricePerUnit})";
                    int count = this.Da.ExecuteDMLQuery(insertSql);
                    if (count == 1)
                        MessageBox.Show("Product added successfully.");
                    else
                        MessageBox.Show("Failed to add product.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ClearFields()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();
        }
        public void UpdatePurchaseInfo()
        {
            try
            {
                var purchaseId = this.txtPurchaseId.Text;
                var productId = this.txtProductId.Text;
                var productName = this.txtProductName.Text;
                var category = this.cmbCategory.Text;
                int quantity = 0;
                decimal pricePerUnit = 0m;
                int.TryParse(this.txtQuantity.Text, out quantity);
                decimal.TryParse(this.txtPricePerUnit.Text, out pricePerUnit);
                string insertSql = $@"
                                        INSERT INTO PurchaseInfo (PurchaseId, ProductId, ManagerId, ProductName, Category, BuyQuantity, BuyPricePerUnit)
                                        VALUES ('{purchaseId}', '{productId}', '{userId}', '{productName}', '{category}','{quantity}', '{pricePerUnit}')";
                int count = this.Da.ExecuteDMLQuery(insertSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoGenerateId(string uniqueId)
        {
            if (uniqueId == "P-")
            {
                var query = $"select max(ProductId) from ProductInfo;";
                var dt = this.Da.ExecuteQueryTable(query);
                var oldId = dt.Rows[0][0].ToString();
                string newId;

                if (string.IsNullOrEmpty(oldId))
                {
                    newId = uniqueId[0] + "-001"; 
                }
                else
                {
                    var s = oldId.Split('-');
                    var temp = Convert.ToInt32(s[1]);
                    newId = uniqueId[0] + "-" + (++temp).ToString("d3");

                }
                this.txtProductId.Text = newId;
            }
            else if (uniqueId == "B-")
            {
                var query = $"select max(PurchaseId) from PurchaseInfo;";
                var dt = this.Da.ExecuteQueryTable(query);
                var oldId = dt.Rows[0][0].ToString();
                string newId;
                if (string.IsNullOrEmpty(oldId)) 
                {
                    newId = uniqueId[0] + "-0001";
                }
                else
                {
                    var s = oldId.Split('-');
                    var temp = Convert.ToInt32(s[1]);
                    newId = uniqueId[0] + "-" + (++temp).ToString("d4");
                }
                this.txtPurchaseId.Text = newId; 
            }
            
        }

    }
}
