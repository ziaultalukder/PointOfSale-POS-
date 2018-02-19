using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.DatabaseContext;
using PointOfSale.Models;

namespace PointOfSale.UI
{
    public partial class SalesUI : Form
    {
        public SalesUI()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            SuperShopDatabaseContext db = new SuperShopDatabaseContext();

            itemComboBox.DataSource = db.ItemSetups.ToList();
            itemComboBox.DisplayMember = "Name";
            itemComboBox.ValueMember = "Id";
            //itemComboBox.SelectedIndex = -1;

            outletComboBox.DataSource = db.Outlates.ToList();
            outletComboBox.DisplayMember = "Name";
            outletComboBox.ValueMember = "Id";
            //outletComboBox.SelectedIndex = -1;

            employeeComboBox.DataSource = db.Employee.ToList();
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
            //employeeComboBox.SelectedIndex = -1;
        }

        private decimal discount = 0;
        private decimal vat = 0;
        private decimal totalPrice = 0;

        private void GetTotalAmmount()
        {
            decimal subTotalWithoutDiscount = TotalAmount() - discount;
            decimal vatAmount = (subTotalWithoutDiscount * vat) / 100;
            totalPrice = subTotalWithoutDiscount + vatAmount;
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = discountTextBox.Text;
            if (text != null)
            {
                decimal n;
                decimal.TryParse(text, out n);
                discount = n;
            }
            
            GetTotalAmmount();
            totalTakaTextBox.Text = totalPrice.ToString();
        }

        private void vatTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = vatTextBox.Text;
            if (text != null)
            {
                decimal n;
                decimal.TryParse(text, out n);
                vat = n;
            }

            GetTotalAmmount();
            totalTakaTextBox.Text = totalPrice.ToString();
        }

        private decimal TotalAmount()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            return sum;
        }


        private void customerNumberTextBox_Leave(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            string number = customerNumberTextBox.Text;
            var findName = db.PartySetup.FirstOrDefault(c => c.Contact == number).Name;
            customerNameTextBox.Text = findName;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["sl"].Value = (e.RowIndex + 1).ToString();
        }

        List<SalesItem> SalesItemList = new List<SalesItem>();
        private void addButton_Click(object sender, EventArgs e)
        {
            SalesItem salesItm = new SalesItem();
            salesItm.ItemName = itemComboBox.Text;
            salesItm.Quantity = Convert.ToDecimal(qtyTextBox.Text);
            salesItm.Price = Convert.ToDecimal(priceTextBox.Text);
            salesItm.LineTotal = (Convert.ToDecimal(qtyTextBox.Text)* Convert.ToDecimal(priceTextBox.Text));

            SalesItemList.Add(salesItm);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SalesItemList;


            totalAmontTextBox.Text = TotalAmount().ToString();
            subTotaltextBox.Text = TotalAmount().ToString();
        }

        List<Sales> SalesList = new List<Sales>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            Sales sales = new Sales();

            sales.TotalAmount = Convert.ToDecimal(totalTakaTextBox.Text);
            sales.Due = Convert.ToDecimal(dueTextBox.Text);
            sales.Discount = Convert.ToDecimal(discountTextBox.Text);
            sales.Vat = Convert.ToDecimal(vatTextBox.Text);
            sales.Date = dateTimePicker1.Value;
            sales.SalesNumber = r.Next().ToString();
            sales.SalesItmLst = SalesItemList;

            sales.OutletId = outletComboBox.SelectedIndex;
            sales.EmployeeId = employeeComboBox.SelectedIndex;
            //sales.CustomerId = customerNameTextBox.tex

            SalesList.Add(sales);

            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Sales.AddRange(SalesList);
            db.SaveChanges();

        }
    }
}
