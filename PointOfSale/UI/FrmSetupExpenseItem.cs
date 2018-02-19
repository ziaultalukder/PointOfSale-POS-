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
    public partial class FrmSetupExpenseItem : Form
    {
        private void FrmSetupExpenseItem_Load(object sender, EventArgs e)
        {
            GetDataExpenceItem();
        }
        public FrmSetupExpenseItem()
        {
            InitializeComponent();
            GetExpenseCategoryCmbBoxItems();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTxtBoxs();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExpenseItem expenseItem = new ExpenseItem();
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
            else if (string.IsNullOrEmpty(txtExpenseItemDescription.Text))
            {
                MessageBox.Show("Description Field Empty");
                return;
            }
            

            expenseItem.CategoryCode = (int)cmbExpenseCategory.SelectedValue;
            expenseItem.Code = txtExpenseItemCode.Text;
            expenseItem.Description = txtExpenseItemDescription.Text;
            expenseItem.Name =txtExpenseItemName.Text;

            var row = expenseItemManager.InsertExpenseItem(expenseItem);
            if (row)
            {
                MessageBox.Show("Data Inserted Successfully");
                ClearTxtBoxs();
                GetDataExpenceItem();
            }
            else
            {
                MessageBox.Show("Data Inserted Failed");
            }
        }
        private void ClearTxtBoxs()
        {
            txtExpenseCategoryCode.Clear();
            txtExpenseItemCode.Clear();
            txtExpenseItemDescription.Clear();
            txtExpenseItemName.Clear();
        }
        private void GetExpenseCategoryCmbBoxItems()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            cmbExpenseCategory.DataSource = db.ExpenseCategory.ToList();
            cmbExpenseCategory.DisplayMember = "CategoryName";
            cmbExpenseCategory.ValueMember = "Id";
            cmbExpenseCategory.SelectedIndex = -1;

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GetDataExpenceItem();
        }

        private void GetDataExpenceItem()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            grdExpenseItems.DataSource = db.ExpenseItem.ToList();
        }

        private void cmbExpenseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ExpenseItem expenseItem = new ExpenseItem();
            //ExpenseItemManager expenseItemManager = new ExpenseItemManager();
            //txtExpenseCategoryCode.Text = cmbExpenseCategory.SelectedValue.ToString();
        }

        private void grdExpenseItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idLabel.Text = grdExpenseItems.SelectedRows[0].Cells[0].Value.ToString();
            txtExpenseItemName.Text = grdExpenseItems.SelectedRows[0].Cells[1].Value.ToString();
            txtExpenseItemCode.Text = grdExpenseItems.SelectedRows[0].Cells[2].Value.ToString();
            txtExpenseItemDescription.Text = grdExpenseItems.SelectedRows[0].Cells[3].Value.ToString();
            cmbExpenseCategory.Text = grdExpenseItems.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ExpenseItem expenseItem = new ExpenseItem();
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
            else if (string.IsNullOrEmpty(txtExpenseItemDescription.Text))
            {
                MessageBox.Show("Description Field Empty");
                return;
            }

            expenseItem.Id = Convert.ToInt32(idLabel.Text);
            expenseItem.CategoryCode = (int)cmbExpenseCategory.SelectedValue;
            expenseItem.Code = txtExpenseItemCode.Text;
            expenseItem.Description = txtExpenseItemDescription.Text;
            expenseItem.Name = txtExpenseItemName.Text;

            var row = expenseItemManager.UpdateExpense(expenseItem);
            if (row)
            {
                MessageBox.Show("Data Updated Successfully");
                ClearTxtBoxs();
                GetDataExpenceItem();
            }
            else
            {
                MessageBox.Show("Data Updated Failed");
            }
        }
    }
}
