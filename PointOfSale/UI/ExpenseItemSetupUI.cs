using PointOfSale.DatabaseContext;
using PointOfSale.Manager;
using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI
{
    public partial class ExpenseItemSetupUI : Form
    {
        private SuperShopDatabaseContext db;
        private void ExpenseItemSetupUI_Load(object sender, EventArgs e)
        {
            
        }
        public ExpenseItemSetupUI()
        {
            InitializeComponent();
            RefreshAll();

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }
        //private void btnCancel_Click(object sender, EventArgs e)
        //{}

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExpenseCategoryItems expenseItem = new ExpenseCategoryItems();
            ExpenseItemManager expenseItemManager = new ExpenseItemManager();
            using (db = new SuperShopDatabaseContext())
            {

                if (string.IsNullOrEmpty(cmbExpenseCategory.Text))
                {
                    MessageBox.Show("Please Select an Catagory");
                    return;
                }
                if (string.IsNullOrEmpty(txtExpenseItemName.Text))
                {
                    MessageBox.Show("Name Field is Empty");
                    return;
                }
                else
                {
                    string testName = txtExpenseItemName.Text;
                    bool isNameExist = db.ExpenseCategoryItems.Count(c => c.Name == testName) > 0;
                    if (isNameExist)
                    {
                        MessageBox.Show("Name is Allready Exist");
                        return;
                    }
                    expenseItem.Name = txtExpenseItemName.Text;
                }
                expenseItem.CategoryCode = (int)cmbExpenseCategory.SelectedValue;
                if (string.IsNullOrEmpty(txtExpenseItemCode.Text))
                {
                    MessageBox.Show("code Field is Empty");
                    return;
                }
                int testCode = Convert.ToInt32(txtExpenseItemCode.Text);
                if (testCode < 1000000 || testCode > 9999999)
                {
                    MessageBox.Show("Please enter the Code Between 100000 to 99999999!!!");
                    return;
                }
                //SuperShopDatabaseContext db = new SuperShopDatabaseContext();
                else
                {
                    bool isCodeExist = db.ExpenseCategoryItems.Count(c => c.Code == testCode.ToString()) > 0;
                    if (isCodeExist)
                    {
                        MessageBox.Show("Code is Allready Exist");
                        return;
                    }
                    expenseItem.Code = txtExpenseItemCode.Text;
                }
                expenseItem.Description = "ExpenseCategory:: " + cmbExpenseCategory.Text.ToString() + Environment.NewLine + txtExpenseItemDescription.Text;
                expenseItem.IsDelete = false;
                //expenseItem.ExpenseCategory.CategoryName = cmbExpenseCategory.Text.ToString();
                var row = expenseItemManager.InsertExpenseCategoryItems(expenseItem);
                if (row)
                {
                    MessageBox.Show("Data Inserted Successfully");
                    RefreshAll();
                    //GetgrdExpenceItem();
                }
                else
                {
                    MessageBox.Show("Data Inserted Failed");
                }
            }
        }
        //private void updateButton_Click(object sender, EventArgs e)
        //{        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ExpenseCategoryItems expenseItem = new ExpenseCategoryItems();
            ExpenseItemManager expenseItemManager = new ExpenseItemManager();
            if (string.IsNullOrEmpty(cmbExpenseCategory.Text))
            {
                MessageBox.Show("Please Select an Catagory");
                return;
            }
            else if (string.IsNullOrEmpty(txtExpenseItemName.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(txtExpenseItemCode.Text))
            {
                MessageBox.Show("code Field Empty");
                return;
            }
            expenseItem.Id = Convert.ToInt32(idLabel.Text);
            expenseItem.Code =  txtExpenseItemCode.Text;
            expenseItem.CategoryCode = Convert.ToInt32(txtExpenseCategoryCode.Text);
            expenseItem.Description = "ExpenseCategory:: " + cmbExpenseCategory.Text.ToString() + Environment.NewLine + txtExpenseItemDescription.Text;
            expenseItem.Name = txtExpenseItemName.Text;
            expenseItem.IsDelete = false;
            var row = expenseItemManager.UpdateExpenseCategoryItems(expenseItem);
            if (row)
            {
                MessageBox.Show("Row Updated Successfully");
                RefreshAll();
            }
            else
            {
                MessageBox.Show("Row Update Failed");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExpenseCategoryItems expenseItem = new ExpenseCategoryItems();
            ExpenseItemManager expenseItemManager = new ExpenseItemManager();

            //if (string.IsNullOrEmpty(cmbExpenseCategory.Text))
            //{
            //    MessageBox.Show("Please Select an Catagory");
            //    return;
            //}
            if (string.IsNullOrEmpty(txtExpenseItemName.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(txtExpenseItemCode.Text))
            {
                MessageBox.Show("code Field Empty");
                return;
            }
            expenseItem.Id = Convert.ToInt32(idLabel.Text);
            expenseItem.Code = txtExpenseItemCode.Text;
            expenseItem.CategoryCode = Convert.ToInt32(txtExpenseCategoryCode.Text);
            expenseItem.Description = "ExpenseCategory:: " + cmbExpenseCategory.Text.ToString() + Environment.NewLine + txtExpenseItemDescription.Text;
            expenseItem.Name = txtExpenseItemName.Text;
            expenseItem.IsDelete = true;
            var row = expenseItemManager.UpdateExpenseCategoryItems(expenseItem);
            if (row)
            {
                MessageBox.Show("Row Deleted Successfully");
                RefreshAll();
            }
            else
            {
                MessageBox.Show("Row Deleted Failed");
            }
           
        }

        private void RefreshAll()
        {
            txtExpenseCategoryCode.Clear();
            txtExpenseItemCode.Clear();
            txtExpenseItemDescription.Clear();
            txtExpenseItemName.Clear();
            cmbExpenseCategory.SelectedIndex = -1;
            cmbExpenseCategory.Text = "";
            grdExpenseItems.DataSource = null;
            GetgrdExpenceItem();
            GetExpenseCategoryCmbBoxItems();
            //ShowItemCode();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnSave.Show();
        }
        private void GetExpenseCategoryCmbBoxItems()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            cmbExpenseCategory.DataSource = db.ExpenseCategory.ToList();
            cmbExpenseCategory.DisplayMember = "CategoryName";
            cmbExpenseCategory.ValueMember = "CategoryCode";
            cmbExpenseCategory.SelectedIndex = -1;

        }

        private void GetgrdExpenceItem()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            //grdExpenseItems.DataSource = db.ExpenseCategoryItems.ToList();
            var dgvExpItem = (from expCat in db.ExpenseCategoryItems
                             where expCat.IsDelete == false
                             select expCat).ToList();
            grdExpenseItems.DataSource = dgvExpItem;
            grdExpenseItems.Columns[0].Visible = false;
            grdExpenseItems.Columns[4].Visible = false;
            grdExpenseItems.Columns[6].Visible = false;

        }

        private void cmbExpenseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ExpenseItem expenseItem = new ExpenseItem();
            //ExpenseItemManager expenseItemManager = new ExpenseItemManager();
            //txtExpenseCategoryCode.Text = cmbExpenseCategory.SelectedValue.ToString();
            ShowCategoryCode();
            ShowItemCode();
        }

        private void grdExpenseItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idLabel.Text = grdExpenseItems.SelectedRows[0].Cells[0].Value.ToString();
            txtExpenseItemName.Text = grdExpenseItems.SelectedRows[0].Cells[1].Value.ToString();
            txtExpenseItemCode.Text = grdExpenseItems.SelectedRows[0].Cells[2].Value.ToString();
            txtExpenseItemDescription.Text = grdExpenseItems.SelectedRows[0].Cells[3].Value.ToString();
            txtExpenseCategoryCode.Text = grdExpenseItems.SelectedRows[0].Cells[4].Value.ToString();
            cmbExpenseCategory.SelectedValue = grdExpenseItems.SelectedRows[0].Cells[4].Value;
            btnSave.Hide();
            btnUpdate.Show();
            btnDelete.Show();
        }
                
        private void ShowCategoryCode()
        {
            using (db = new SuperShopDatabaseContext())
            {
                //SuperShopDatabaseContext db = new SuperShopDatabaseContext();
                if (string.IsNullOrEmpty(cmbExpenseCategory.Text))
                {
                    txtExpenseCategoryCode.Text = "Select a Category";
                }
                else
                {
                    string selectedCategory = cmbExpenseCategory.Text;
                    string categoryCode = "0000";
                    //var category = db.ExpenseCategory.Where(c => c.CategoryName == selectedCategory).FirstOrDefault();
                    //if (category != null)
                    //{
                    //    categoryCode = category.CategoryCode.ToString();
                    //}
                    categoryCode = cmbExpenseCategory.SelectedValue.ToString();
                    txtExpenseCategoryCode.Text = categoryCode;
                }
            }
        }
        private void ShowItemCode()
        {
            using (db = new SuperShopDatabaseContext())
            {
                //SuperShopDatabaseContext db = new SuperShopDatabaseContext();
                int  items = db.ExpenseCategoryItems.Count() + 1;
                string itemCode="";
                if (items<10)
                {
                    itemCode = "00" + items;
                }
                else if (items < 100)
                {
                    itemCode = "0" + items;
                }
                else 
                {
                    itemCode =items.ToString();
                }
                txtExpenseItemCode.Text = cmbExpenseCategory.SelectedValue + itemCode;
            }
        }
    }
}
