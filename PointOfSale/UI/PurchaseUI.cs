using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        Purchase purchase = new Purchase();
        public PurchaseUI()
        {
            InitializeComponent();
        }

        private void PurchaseUI_Load(object sender, EventArgs e)
        {
            purchaseDataGridView.AutoGenerateColumns = false;

           // SuperShopDatabaseContext db = new SuperShopDatabaseContext();

            var supplier = db.PartySetup.Where(c => c.Supplier != c.Customer);

            itemComboBox.DataSource = db.ItemSetups.ToList();
            itemComboBox.DisplayMember = "Name";
            itemComboBox.ValueMember = "Id";
            //itemComboBox.SelectedIndex = -1;

            //ClearAllForm();
            ClearSaveButtonField();

            ClearItemAddButton();

            outletcomboBox.DataSource = db.Outlates.ToList();
            outletcomboBox.DisplayMember = "Name";
            outletcomboBox.ValueMember = "Id";
            //outletcomboBox.SelectedIndex = -1;

            employeecomboBox.DataSource = db.Employee.ToList();
            employeecomboBox.DisplayMember = "Name";
            employeecomboBox.ValueMember = "Id";
            //employeecomboBox.SelectedIndex = -1;

            partyTypeComboBox.DataSource = db.PartySetup.Where(c=>c.Supplier != null).ToList();
            partyTypeComboBox.DisplayMember = "Name";
            partyTypeComboBox.ValueMember = "Id";
            //partyTypeComboBox.SelectedIndex = -1;
        }


        List<PurchaseItem> PurchaseItems = new List<PurchaseItem>();

        private void addButton_Click(object sender, EventArgs e)
        {
            PurchaseItem purchaseItem = new PurchaseItem();


            //bool found = false;
            //if (purchaseDataGridView.RowCount >0)
            //{
            //    foreach (DataGridViewRow row in purchaseDataGridView.Rows)
            //    {
            //        if (Convert .ToString(row .Cells [1].Value) == itemComboBox.Text && Convert .ToString(row .Cells [4].Value)==priceTextBox .Text )

            //        {
            //            row.Cells[3].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[3].Value));
            //            found = true;
            //        }
            //    }
            //    if (!found)
            //    {
            //        purchaseDataGridView.Rows.Add(itemComboBox.Text, priceTextBox.Text, 1);
            //    }
            //}
            if (IsAddButtonValidated())
            {
                purchaseItem.Id = AutoIDGenerate();
                purchaseItem.ItemName = itemComboBox.Text;
                purchaseItem.Quantity = Convert.ToDecimal(qtyTextBox.Text);
                if (manualPriceTextBox.Text.Trim() == string.Empty)
                {
                    purchaseItem.Price = Convert.ToDecimal(txtBoxCostPrice.Text);
                }
                else
                {
                    purchaseItem.Price = Convert.ToDecimal(manualPriceTextBox.Text);
                }

                purchaseItem.LineTotal = purchaseItem.Quantity*purchaseItem.Price;

                PurchaseItems.Add(purchaseItem);
                purchaseDataGridView.DataSource = null;

                purchaseDataGridView.DataSource = PurchaseItems;

                totalTextBox.Text = TotalAmount().ToString();
                totalAmmountTextBox.Text = TotalAmount().ToString();
                ClearItemAddButton();

                //itemAddedLabel.Text = PurchaseItems.Count.ToString();
            }
        }

        private int AutoIDGenerate()
        {
            int counts = 1;
            counts = db.PurchaseItems.Include(c => c.Id).Count() + counts;
            int result = 0 + counts;
            return result;
        }

        private bool IsAddButtonValidated()
        {
            if (itemComboBox.SelectedIndex == -1)
            {
                WinMessageBox.ShowErrorMessage("Please Item Select.");
                return false;
            }
            if (qtyTextBox.Text .Trim()==string .Empty)
            {
                WinMessageBox.ShowErrorMessage("Please Input Quantity.");
                return false;
            }
            return true;
        }

        private decimal TotalAmount()
        {
            decimal sum = 0;
            for (int i = 0; i < purchaseDataGridView.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(purchaseDataGridView.Rows[i].Cells[4].Value);
            }
            return sum;
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            ClearItemAddButton();

            //PurchaseItems.RemoveAt(purchaseDataGridView.SelectedRows[0].Index);
        }

        private void ClearItemAddButton()
        {
            itemComboBox.SelectedValue = -1;
            qtyTextBox.Clear();
            txtBoxCostPrice.Clear();
            manualPriceTextBox.Clear();
            pictureBoxBarcode.Image = null;
        }

        //List<Purchase> PurchaseList = new List<Purchase>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsSaveButtonValidated())
            {
                if (purchase != null)
                {
                    purchase.TotalAmmount = Convert.ToDecimal(totalAmmountTextBox.Text);
                    purchase.Due = Convert.ToDecimal(dueTextBox.Text);
                    purchase.Remarks = remarksTextBox.Text;
                    purchase.PurchaseDate = dateTimePicker.Value;
                    purchase.SalesNumber = AutoCodeGenerate().ToString();
                    purchase.OutletId = (int) outletcomboBox.SelectedValue;
                    purchase.EmployeeId = (int) employeecomboBox.SelectedValue;
                    //purchase.ItemId = (int)itemComboBox.SelectedValue;
                    purchase.PartyTypeId = (int) partyTypeComboBox.SelectedValue;
                    purchase.PurchaseItemList = PurchaseItems;

                    //PurchaseList.Add(purchase);


                    db.Purchases.Add(purchase);
                    var row = db.SaveChanges();
                    if (row > 0)
                    {
                        WinMessageBox.ShowSuccessMessage("Record save Successfully.");
                        ClearSaveButtonField();
                        purchaseDataGridView.DataSource = null;
                    }
                    else
                    {
                        WinMessageBox.ShowErrorMessage("Record save Failed.");
                    }
                }
                else
                {
                    WinMessageBox.ShowErrorMessage("Please All Field Added and Save button prese.");
                }
            }
        }

        private bool IsSaveButtonValidated()
        {
            if (outletcomboBox.SelectedValue ==null )
            {
                WinMessageBox.ShowErrorMessage("Please select oulet.");
                return false;
            }
            if (employeecomboBox.SelectedValue==null)
            {
                WinMessageBox.ShowErrorMessage("Please select employee.");
                return false;
            }
            if (partyTypeComboBox.SelectedValue ==null)
            {
                WinMessageBox.ShowErrorMessage("Please select supplier");
                return false;
            }
            if (dateTimePicker.Text ==null)
            {
                WinMessageBox.ShowErrorMessage("Please select date.");
                return false;
            }
            if (PurchaseItems==null)
            {
                WinMessageBox.ShowErrorMessage("Please first added item.");
                return false;
            }
            return true;
        }

        public void ClearSaveButtonField()
        {
            //qtyTextBox.Clear();
            //manualPriceTextBox.Clear();
            totalTextBox.Clear();
            totalAmmountTextBox.Clear();
            outletcomboBox.SelectedText = null;
            employeecomboBox.SelectedText = null;
            partyTypeComboBox.SelectedText = null;
            remarksTextBox.Clear();
            dateTimePicker.ResetText();
        }

        private void purchaseDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.purchaseDataGridView.Rows[e.RowIndex].Cells["sl"].Value = (e.RowIndex + 1).ToString();
        }

        private int id;
        private void outletcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bool result = int.TryParse(outletcomboBox.SelectedIndex.ToString(), out id);
        }

        private void AutoBarcodeGenerate()
        {
            if (outletcomboBox.SelectedItem != null)
            {
                var item = itemComboBox.SelectedItem as ItemSetups;
                if (item == null)
                {
                    return;
                }
                var barcode = item.Code ;
                Bitmap bitmap = new Bitmap(barcode.Length*26, 85);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    Font oFont = new Font("IDAHC39M Code 39 Barcode", 15);
                    PointF pointF = new PointF(2f, 2f);
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush White = new SolidBrush(Color.White);
                    graphics.FillRectangle(White, 0, 0, bitmap.Width, bitmap.Height);
                    graphics.DrawString("*" + barcode + "*", oFont, black, pointF);
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    pictureBoxBarcode.Image = bitmap;
                    pictureBoxBarcode.Height = bitmap.Height;
                    pictureBoxBarcode.Width = bitmap.Width;
                }
            }
        }

        private void itemComboBox_TextChanged(object sender, EventArgs e)
        {
            //AutoBarcodeGenerate();
        }

        private void ClearAllForm()
        {
            itemComboBox.SelectedValue = -1;
            qtyTextBox .Clear();
            manualPriceTextBox.Clear();
            outletcomboBox.SelectedValue = -1;
            employeecomboBox.SelectedValue = -1;
            partyTypeComboBox.SelectedValue = -1;
            dateTimePicker.ResetText();
            remarksTextBox.Clear();

        }

        private void itemComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            AutoBarcodeGenerate();
            GetItemPriceInTextBox();
        }

        private int AutoCodeGenerate()
        {
            int counts = 1;
            counts = db.Employee.Include(c => c.Id).Count() + counts;
            int result = 11100 + counts;
            return result;
        }

        private void GetItemPriceInTextBox()
        {
            var price = itemComboBox.SelectedItem as ItemSetups;
            if (price == null)
            {
                return;
            }
            txtBoxCostPrice.Text = price.CostPrice.ToString();
        }

        private void purchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (purchaseDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //purchaseItemBindingSource.RemoveCurrent();
                     
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeUI barcode = new BarcodeUI();
            barcode.Show();
        }
    }
}
