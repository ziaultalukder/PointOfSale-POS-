using PointOfSale.Models;
using PointOfSale.Manager;
using PointOfSale.DatabaseContext;
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
    public partial class FrmExpenseCategorySetup : Form
    {
        public FrmExpenseCategorySetup()
        {
            InitializeComponent();
        }

        private void FrmExpenseCategorySetup_Load(object sender, EventArgs e)
        {
            GetExpenseCatagory();
        }

        private void radChildCategory_CheckedChanged(object sender, EventArgs e)
        {
            cmbParentCategory.Show();
        }

        private void radRootCategory_CheckedChanged(object sender, EventArgs e)
        {
            cmbParentCategory.Hide();
            cmbParentCategory.SelectedIndex=-1;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtCategoryCode.Text = "";
            txtCategoryDiscription.Text = "";
            txtCategoryName.Text = "";
        }

        private void cmbParentCategory_Click(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            cmbParentCategory.DataSource = db.ExpenseCategory.ToList();
            cmbParentCategory.DisplayMember = "CategoryName";
            cmbParentCategory.ValueMember = "CategoryCode";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ExpenseCategory expenseCategory = new ExpenseCategory();
            ExpenseCategoryManager expenseCategoryManager = new ExpenseCategoryManager();

            expenseCategory.CategoryCode =Convert.ToInt32(txtCategoryCode.Text);
            expenseCategory.categoryDescription = txtCategoryDiscription.Text;
            expenseCategory.CategoryName = txtCategoryName.Text;
            expenseCategory.CategoryType = GetCategoryType();

            if (cmbParentCategory.SelectedIndex!=-1)
            {
                expenseCategory.Parentid = (int)cmbParentCategory.SelectedValue;
            }



            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(txtCategoryCode.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(txtCategoryDiscription.Text))
            {
                MessageBox.Show("Description Field Emptyt");
                return;
            }


            var row = expenseCategoryManager.InsertExpenseCategory(expenseCategory);
            if (row)
            {
                MessageBox.Show("Data Inserted Successfully");
                GetExpenseCatagory();
            }
            else
            {
                MessageBox.Show("Data Inserted Failed");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GetExpenseCatagory();
        }

        private void GetExpenseCatagory()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            grdExpenseCategory.DataSource = db.ExpenseCategory.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ExpenseCategory expenseCategory = new ExpenseCategory();
            ExpenseCategoryManager expenseCategoryManager = new ExpenseCategoryManager();

            expenseCategory.Id =Convert.ToInt32(idLabel.Text);
            expenseCategory.CategoryCode = Convert.ToInt32(txtCategoryCode.Text);
            expenseCategory.categoryDescription = txtCategoryDiscription.Text;
            expenseCategory.CategoryName = txtCategoryName.Text;
            expenseCategory.CategoryType = GetCategoryType();

            if (cmbParentCategory.SelectedIndex != -1)
            {
                expenseCategory.Parentid = (int)cmbParentCategory.SelectedValue;
            }



            if (string.IsNullOrEmpty(cmbParentCategory.Text))
            {
                MessageBox.Show("Please Select an Outlate");
                return;
            }
            else if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(txtCategoryCode.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(txtCategoryDiscription.Text))
            {
                MessageBox.Show("Description Field Emptyt");
                return;
            }


            var row = expenseCategoryManager.UpdateExpenseCategory(expenseCategory);
            if (row)
            {
                MessageBox.Show("Data Updated Successfully");
                GetExpenseCatagory();
            }
            else
            {
                MessageBox.Show("Data Updated Failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private string GetCategoryType()
        {
            string expCatType;
            if (radRootCategory.Checked)
            {
                expCatType = "Root";
            }
            else if (radChildCategory.Checked)
            {
                expCatType = "Child";
            }
            else
                expCatType = "Please Select a Radio Button";
            return expCatType;
        }

        private void cmbParentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdExpenseCategory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idLabel.Text = grdExpenseCategory.SelectedRows[0].Cells[0].Value.ToString();
            txtCategoryName.Text = grdExpenseCategory.SelectedRows[0].Cells[1].Value.ToString();
            txtCategoryCode.Text = grdExpenseCategory.SelectedRows[0].Cells[2].Value.ToString();
            txtCategoryDiscription.Text = grdExpenseCategory.SelectedRows[0].Cells[3].Value.ToString();
            if (cmbParentCategory.Text == "")
            {
                cmbParentCategory.Text = "It is a Root Catagory";
            }
            else
            {
                cmbParentCategory.Text = grdExpenseCategory.SelectedRows[0].Cells[5].Value.ToString();
            }
            
        }
    }
}
