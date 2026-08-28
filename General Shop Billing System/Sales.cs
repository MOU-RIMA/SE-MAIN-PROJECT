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
    public partial class Sales : Form
    {
        private Methods methods { get; set; }
        private DataAccess Da { get; set; }
        string userId = Session.SessionUserId;
        private DataTable cartTable = new DataTable();
        public Sales()
        {
            InitializeComponent();
            this.methods = new Methods();
            this.Da = new DataAccess();

        }
        private void btnBackSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerView managerView = new ManagerView();
            managerView.Show();
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            methods.ResetAnchors(this);
            PopulateGridView();
            CreateCart();
        }
        private void dgvProductListSales_DoubleClick(object sender, EventArgs e)
        {
            txtProductIdSales.Text = this.dgvProductListSales.CurrentRow.Cells[0].Value.ToString();
            txtNameSales.Text = this.dgvProductListSales.CurrentRow.Cells[1].Value.ToString();
            txtCategorySales.Text = this.dgvProductListSales.CurrentRow.Cells[2].Value.ToString();
            txtAddQuantitySales.Text = "";
            txtPriceSales.Text = this.dgvProductListSales.CurrentRow.Cells[4].Value.ToString();
            txtAddQuantitySales.Text = "1";
            txtDiscountSales.Text = "0";
            string availableQuantityString = this.dgvProductListSales.CurrentRow.Cells[3].Value.ToString();

            int availableQuantity = int.Parse(availableQuantityString);
            if (availableQuantity > 0)
            {
                txtAvailableSales.Text = "Available";
            }
            else
            {
                txtAvailableSales.Text = "Not Available";
            }
        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            methods.Exit(e);
        }
        private void txtDiscountSales_TextChanged(object sender, EventArgs e)
        {
            UpdateFinalAmount();
        }
        private void btnAddToCartSales_Click(object sender, EventArgs e)
        {
            UpdateCart();
        }

        private void btnRemoveSales_Click(object sender, EventArgs e)
        {
            if (dgvCartListSales.CurrentRow != null)
            {
                cartTable.Rows.RemoveAt(dgvCartListSales.CurrentRow.Index);

                UpdateTotalAmount();
                UpdateFinalAmount();
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }

        private void btnClearCartSales_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                                    "Are you sure you want to clear the entire cart?",
                                                    "Clear Cart Confirmation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question
                                                );

            if (result == DialogResult.Yes)
            {
                cartTable.Clear();

                txtTotalAmountSales.Text = "";
                txtFinalAmountSales.Text = "";
                txtDiscountSales.Text = "";

                clearCart();

                MessageBox.Show("Cart cleared successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnPurchaseSales_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty. Add some products first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateDiscount(out decimal discount))
                return;

            if (!CheckProductAvailability())
                return;

            string saleId = GenerateSaleId();

            InsertIntoSales(saleId, discount);
            InsertIntoSalesInfoAndUpdateProduct(saleId, discount);

            ClearCartAndUI();
            this.PopulateGridView();

            MessageBox.Show("Purchase completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerateSaleId()
        {
            var query = "SELECT MAX(SaleId) FROM Sales";
            var dt = this.Da.ExecuteQuery(query).Tables[0];
            string oldId = dt.Rows[0][0]?.ToString();
            string newId;
            string prefix = "S";

            if (string.IsNullOrEmpty(oldId))
            { 
                newId = prefix + "-0001";
            }
            else
            {
                var parts = oldId.Split('-');
                int num = int.Parse(parts[1]);
                num++;

                newId = prefix + "-" + num.ToString("D4");
            }
            return newId;
        }

        private int GenerateSaleSerialNumber()
        {
            var query = "SELECT ISNULL(MAX(SaleSerialNumber), 0) FROM SalesInfo";
            var dt = this.Da.ExecuteQuery(query).Tables[0];
            int lastNumber = Convert.ToInt32(dt.Rows[0][0]);
            return lastNumber + 1;
        }
        private bool ValidateDiscount(out decimal discount)
        {
            discount = 0;
            if (!decimal.TryParse(txtDiscountSales.Text, out discount) || discount < 0 || discount > 100)
            {
                MessageBox.Show("Discount must be between 0 and 100.", "Invalid Discount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CheckProductAvailability()
        {
            foreach (DataRow row in cartTable.Rows)
            {
                string productId = row["ProductId"].ToString();
                int requestedQuantity = Convert.ToInt32(row["Quantity"]);

                string sqlCheckQty = $"SELECT TotalQuantity FROM ProductInfo WHERE ProductId='{productId}'";
                var dt = Da.ExecuteQuery(sqlCheckQty).Tables[0];

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"Product {productId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                int availableQuantity = Convert.ToInt32(dt.Rows[0]["TotalQuantity"]);
                if (requestedQuantity > availableQuantity)
                {
                    MessageBox.Show($"Not enough quantity for product {productId}. Available: {availableQuantity}", "Insufficient Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void InsertIntoSales(string saleId, decimal discount)
        {
            decimal totalAmount = GetCartTotal();
            decimal finalAmount = totalAmount - (totalAmount * discount / 100);

            string sqlInsertSales = $@"
        INSERT INTO Sales (SaleId, ManagerId, TotalAmount, Discount, FinalAmount)
        VALUES ('{saleId}', '{userId}', {totalAmount}, {discount}, {finalAmount})";

            Da.ExecuteDMLQuery(sqlInsertSales);
        }

        private void InsertIntoSalesInfoAndUpdateProduct(string saleId, decimal discount)
        {
            foreach (DataRow row in cartTable.Rows)
            {
                string productId = row["ProductId"].ToString();
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal price = Convert.ToDecimal(row["PricePerUnit"]);
                decimal rowFinalPrice = (price*quantity)-(price * quantity * (1 - discount / 100));///////////////////////////////////////////////////////////
                int saleSerialNumber = GenerateSaleSerialNumber();

                string sqlInsertSalesInfo = $@"
                                            INSERT INTO SalesInfo (SaleSerialNumber, SaleIdFK, ManagerId, ProductId, Quantity, PricePerUnit, Discount, FinalPrice)
                                            VALUES ({saleSerialNumber}, '{saleId}', '{userId}', '{productId}', {quantity}, {price}, {discount}, {rowFinalPrice})";

                Da.ExecuteDMLQuery(sqlInsertSalesInfo);

                string sqlUpdateProduct = $@"
                                            UPDATE ProductInfo
                                            SET TotalQuantity = TotalQuantity - {quantity}
                                            WHERE ProductId='{productId}'";

                Da.ExecuteDMLQuery(sqlUpdateProduct);
            }
        }

        private void ClearCartAndUI()
        {
            cartTable.Clear();
            txtTotalAmountSales.Text = "";
            txtFinalAmountSales.Text = "";
            txtDiscountSales.Text = "";
            clearCart();
        }
        private void txtSearchByNameSales_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from ProductInfo where ProductName like '" + this.txtSearchByNameSales.Text + "%';";
            this.PopulateGridView(sql);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchByNameSales.Clear();
        }

        private void PopulateGridView(string sql = "select ProductId, ProductName, Category, TotalQuantity, SellPricePerUnit from ProductInfo")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProductListSales.AutoGenerateColumns = true;
            dgvProductListSales.Columns.Clear();
            this.dgvProductListSales.DataSource = ds.Tables[0];

            dgvProductListSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductListSales.MultiSelect = false;
            dgvProductListSales.RowHeadersVisible = false;
        }

        private decimal GetCartTotal()
        {
            decimal total = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                total += Convert.ToDecimal(row["TotalPrice"]);
            }

            return total;
        }

        private void UpdateTotalAmount()
        {
            decimal cartTotal = GetCartTotal();
            txtTotalAmountSales.Text = cartTotal.ToString("F2");
        }

        private void UpdateFinalAmount()
        {
            decimal cartTotal = GetCartTotal();
            decimal discount = 0;

            decimal.TryParse(txtDiscountSales.Text, out discount);

            decimal finalAmount = cartTotal - (cartTotal * discount / 100);
            if (finalAmount < 0) finalAmount = 0;

            txtFinalAmountSales.Text = finalAmount.ToString("F2");
        }


        private void UpdateCart()
        {
            if (string.IsNullOrEmpty(txtProductIdSales.Text) || string.IsNullOrEmpty(txtAddQuantitySales.Text))
            {
                MessageBox.Show("Please select a product and enter quantity.");
                return;
            }

            int quantity;
            if (!int.TryParse(txtAddQuantitySales.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            if (!CheckSingleProductAvailability(txtProductIdSales.Text, quantity))
                return;

            decimal price = 0m;
            decimal.TryParse(txtPriceSales.Text, out price);

            DataRow existingRow = null;

            foreach (DataRow row in cartTable.Rows)
            {
                if (row["ProductId"].ToString() == txtProductIdSales.Text)
                {
                    existingRow = row;
                    break;
                }
            }

            if (existingRow != null)
            {
                existingRow["Quantity"] = quantity;
                existingRow["TotalPrice"] = quantity * price;
            }
            else
            {
                cartTable.Rows.Add(
                    txtProductIdSales.Text,
                    txtNameSales.Text,
                    txtCategorySales.Text,
                    quantity,
                    price,
                    quantity * price
                );
            }

            clearCart();
            UpdateTotalAmount();
            UpdateFinalAmount();
        }

        private void clearCart()
        {
            txtProductIdSales.Clear();
            txtNameSales.Clear();
            txtCategorySales.Clear();
            txtAddQuantitySales.Clear();
            txtPriceSales.Clear();
            txtAvailableSales.Clear();
        }

        private void CreateCart()
        {
            cartTable.Columns.Add("ProductId", typeof(string));
            cartTable.Columns.Add("ProductName", typeof(string));
            cartTable.Columns.Add("Category", typeof(string));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("PricePerUnit", typeof(decimal));
            cartTable.Columns.Add("TotalPrice", typeof(decimal));

            dgvCartListSales.DataSource = cartTable;
            dgvCartListSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCartListSales.RowHeadersVisible = false;
        }

        private bool CheckSingleProductAvailability(string productId, int requestedQuantity)
        {
            string sql = $"SELECT TotalQuantity FROM ProductInfo WHERE ProductId='{productId}'";
            var dt = Da.ExecuteQuery(sql).Tables[0];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Product not found.", "Error");
                return false;
            }

            int availableQuantity = Convert.ToInt32(dt.Rows[0]["TotalQuantity"]);

            if (requestedQuantity > availableQuantity)
            {
                MessageBox.Show(
                    $"Requested quantity exceeds available stock.\nAvailable: {availableQuantity}",
                    "Insufficient Quantity",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }


    }
}
