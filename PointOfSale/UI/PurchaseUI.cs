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
using PointOfSale.Manager;

namespace PointOfSale.UI
{
    public partial class PurchaseUI : Form
    {
        public PurchaseUI()
        {
            InitializeComponent();
        }

        private void PurchaseUI_Load(object sender, EventArgs e)
        {
            purchaseDataGridView.AutoGenerateColumns = false;

            SuperShopDatabaseContext db = new SuperShopDatabaseContext();


            var supplier = db.PartySetup.Where(c => c.Supplier != c.Customer);


            itemComboBox.DataSource = db.ItemSetups.ToList();
            itemComboBox.DisplayMember = "Name";
            itemComboBox.ValueMember = "Id";
            //itemComboBox.SelectedIndex = -1;



            



            outletcomboBox.DataSource = db.Outlates.ToList();
            outletcomboBox.DisplayMember = "Name";
            outletcomboBox.ValueMember = "Id";
            //outletcomboBox.SelectedIndex = -1;


            employeecomboBox.DataSource = db.Employee.ToList();
            employeecomboBox.DisplayMember = "Name";
            employeecomboBox.ValueMember = "Id";
            //employeecomboBox.SelectedIndex = -1;


            partyTypeComboBox.DataSource = db.PartySetup.ToList();
            partyTypeComboBox.DisplayMember = "Name";
            partyTypeComboBox.ValueMember = "Id";
            //partyTypeComboBox.SelectedIndex = -1;



            
        }


        List<PurchaseItem> PurchaseItems = new List<PurchaseItem>();
        private void addButton_Click(object sender, EventArgs e)
        {
            PurchaseItem purchaseItem = new PurchaseItem();
            purchaseItem.ItemName = itemComboBox.Text;
            purchaseItem.Quantity = Convert.ToDecimal(qtyTextBox.Text);
            purchaseItem.Price = Convert.ToDecimal(priceTextBox.Text);
            purchaseItem.LineTotal = (Convert.ToDecimal(qtyTextBox.Text) * Convert.ToDecimal(priceTextBox.Text));

            PurchaseItems.Add(purchaseItem);
            purchaseDataGridView.DataSource = null;

            purchaseDataGridView.DataSource = PurchaseItems;

            totalTextBox.Text = TotalAmount().ToString();
            totalAmmountTextBox.Text = TotalAmount().ToString();

            //itemAddedLabel.Text = PurchaseItems.Count.ToString();
        }

        private decimal TotalAmount()
        {
            decimal sum = 0;
            for (int i = 0; i < purchaseDataGridView.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(purchaseDataGridView.Rows[i].Cells[3].Value);
            }
            return sum;
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            PurchaseItems.RemoveAt(purchaseDataGridView.SelectedRows[0].Index);
        }

        List<Purchase> PurchaseList = new List<Purchase>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            Purchase purchase = new Purchase();
            purchase.TotalAmmount = Convert.ToDecimal(totalAmmountTextBox.Text);
            purchase.Due = Convert.ToDecimal(dueTextBox.Text);
            purchase.Remarks = remarksTextBox.Text;
            purchase.PurchaseDate = dateTimePicker.Value;
            purchase.SalesNumber = r.Next().ToString();
            purchase.OutletId = (int)outletcomboBox.SelectedValue;
            purchase.EmployeeId = (int)employeecomboBox.SelectedValue;
            purchase.ItemId = (int)itemComboBox.SelectedValue;
            purchase.PartyTypeId = (int)partyTypeComboBox.SelectedValue;
            purchase.PurchaseItemList = PurchaseItems;

            PurchaseList.Add(purchase);

            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Purchases.AddRange(PurchaseList);
            var row = db.SaveChanges();
            if(row> 0)
            {
                MessageBox.Show("Purchase Item Inserted");
                clearField();
            }
            else
            {
                MessageBox.Show("Purchase Item Inserted Faild");
            }
        }

        public void clearField()
        {
            qtyTextBox.Clear();
            priceTextBox.Clear();
            totalTextBox.Clear();
            totalAmmountTextBox.Clear();
        }

        private void purchaseDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.purchaseDataGridView.Rows[e.RowIndex].Cells["sl"].Value = (e.RowIndex + 1).ToString();
        }

        private int id;
        private void outletcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool result = int.TryParse(outletcomboBox.SelectedIndex.ToString(), out id);
        }
    }
}
