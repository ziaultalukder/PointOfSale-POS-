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

namespace PointOfSalePersonal.UI
{
    public partial class ExpenseCategorySetupUI : Form
    {
        int selectedId;
        ExpenseCategory expenseCategory = new ExpenseCategory();
        ExpenseCategoryManager expenseCategoryManager = new ExpenseCategoryManager();

        public ExpenseCategorySetupUI()
        {
            InitializeComponent();
            LoadparentCategoryComboBox();
            LoadgrdExpenseCatagory();
            this.txtCategoryCode.KeyPress += new KeyPressEventHandler(txtCategoryCode_KeyPress);
        }
        private void txtCategoryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void radChildCategory_CheckedChanged(object sender, EventArgs e)
        {
            //cmbParentCategory.SelectedIndex = -1;
            cmbParentCategory.Show();
            LoadparentCategoryComboBox();
        }

        private void radRootCategory_CheckedChanged(object sender, EventArgs e)
        {
            ClearCmbParentCatagory();
            this.cmbParentCategory.Hide();
        }



        private void btnCancle_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void cmbParentCategory_Click(object sender, EventArgs e)
        {
            LoadparentCategoryComboBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryId.Text))
            {
                if (string.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show("Name Field Empty");
                    return;
                }
                expenseCategory.CategoryName = txtCategoryName.Text;
                expenseCategory.CategoryType = GetCategoryType();
                int isInt; 
                if (string.IsNullOrEmpty(txtCategoryCode.Text))
                {
                    MessageBox.Show("Code Field Empty");
                    return;
                }
                bool isInteger = int.TryParse(txtCategoryCode.Text.Trim(), out isInt);
                if (!isInteger)
                {
                    MessageBox.Show("Invalid Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int testCode=Convert.ToInt32(txtCategoryCode.Text);
                    SuperShopDatabaseContext db = new SuperShopDatabaseContext();
                    bool isCodeExist = db.ExpenseCategory.Count(c => c.CategoryCode == testCode) > 0;
                    if (isCodeExist)
                    {
                        MessageBox.Show("Code is Allready Exist");
                        return;
                    } 
                    expenseCategory.CategoryCode = Convert.ToInt32(txtCategoryCode.Text);
                }
                expenseCategory.CategoryDescription = txtCategoryDiscription.Text;
                expenseCategory.IsDelete = false;
                DialogResult dialogResult=MessageBox.Show("Are you sure want to save ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult==DialogResult.Yes)
                {
                    InsertParentCategory();
                }
                var row = expenseCategoryManager.InsertExpenseCategory(expenseCategory);
                if (row)
                {
                    MessageBox.Show("Data Inserted Successfully");
                    LoadgrdExpenseCatagory();
                }
                else
                {
                    MessageBox.Show("Data Inserted Failed");
                }
                RefreshAll();
            }
                //Update Method
            else
            {
                expenseCategory.Id =Convert.ToInt32(txtCategoryId.Text);
                if (string.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show("Name Field Empty");
                    return;
                }
                expenseCategory.CategoryName = txtCategoryName.Text;
                if (string.IsNullOrEmpty(txtCategoryCode.Text))
                {
                    MessageBox.Show("Code Field Empty");
                    return;
                }
                expenseCategory.CategoryCode = Convert.ToInt32(txtCategoryCode.Text);
                //if (string.IsNullOrEmpty(txtCategoryDiscription.Text))
                //{
                //    MessageBox.Show("Description Field Emptyt");
                //    return;
                //}
                expenseCategory.CategoryDescription = txtCategoryDiscription.Text;
                expenseCategory.CategoryType = GetCategoryType();
                expenseCategory.IsDelete = false;
                InsertParentCategory();
                //if (cmbParentCategory.SelectedIndex != -1)
                //{
                //    expenseCategory.Parentid = (int)cmbParentCategory.SelectedValue;
                //    expenseCategory.ParentName = cmbParentCategory.Text;
                //}

                var row = expenseCategoryManager.UpdateExpenseCategory(expenseCategory);
                if (row)
                {
                    MessageBox.Show("Data Updated Successfully");
                    LoadgrdExpenseCatagory();
                }
                else
                {
                    MessageBox.Show("Data Updated Failed");
                }
                RefreshAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            expenseCategory.Id = Convert.ToInt32(txtCategoryId.Text);
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            expenseCategory.CategoryName = txtCategoryName.Text;
            if (string.IsNullOrEmpty(txtCategoryCode.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            expenseCategory.CategoryCode = Convert.ToInt32(txtCategoryCode.Text);
            expenseCategory.CategoryDescription = txtCategoryDiscription.Text;
            expenseCategory.CategoryType = GetCategoryType();
            if (cmbParentCategory.SelectedIndex != -1)
            {
                expenseCategory.Parentid = (int)cmbParentCategory.SelectedValue;
                expenseCategory.ParentName = cmbParentCategory.Text;
            }
            expenseCategory.IsDelete = true;

            var row = expenseCategoryManager.UpdateExpenseCategory(expenseCategory);
            if (row)
            {
                MessageBox.Show("Data Deleted Successfully");
                LoadgrdExpenseCatagory();
            }
            else
            {
                MessageBox.Show("Data Not Deleted !!!!");
            }
            RefreshAll();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadgrdExpenseCatagory();
        }

        private void grdExpenseCategory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = grdExpenseCategory.Rows[Index];
            txtCategoryId.Text= selectedRow.Cells[0].Value.ToString();
            txtCategoryName.Text = selectedRow.Cells[1].Value.ToString();
            txtCategoryCode.Text = selectedRow.Cells[2].Value.ToString();

            if (selectedRow.Cells[4].Value!=null)
                {
                    this.cmbParentCategory.Text = selectedRow.Cells[4].Value.ToString();
                } 
            else
                {
                    this.cmbParentCategory.Text = "";
                }
            this.txtCategoryDiscription.Text = selectedRow.Cells[5].Value.ToString();
            if (selectedRow.Cells[3].Value.ToString() == "Root")
            {
                this.radRootCategory.Checked = true;
                ClearCmbParentCatagory();
            }
            else if (selectedRow.Cells[3].Value.ToString() == "Child")
            { this.radChildCategory.Checked = true; }

            //lblCategoryId.Show();
            txtCategoryId.Hide();
            btnSave.Text = "Update";
            btnDelete.Visible = true;
        }
        private void RefreshAll()
        {
            txtCategoryCode.Text = "";
            txtCategoryDiscription.Text = "";
            txtCategoryName.Text = "";
            txtCategoryId.Text = "";
            btnSave.Text = "Save";
            btnDelete.Visible = false;
            radRootCategory.Checked = false;
            radChildCategory.Checked = false;
            lblCategoryId.Hide();
            txtCategoryId.Hide();
            cmbParentCategory.SelectedIndex = -1;
            cmbParentCategory.Text = "";
            //LoadgrdExpenseCatagory();
        }
        private void LoadparentCategoryComboBox()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var cmbParentCat = (from expCat in db.ExpenseCategory
                             where expCat.IsDelete == false
                             select new
                             {
                                 expCat.Id,
                                 expCat.CategoryName,
                                 expCat.CategoryCode,
                                 expCat.CategoryType,
                                 expCat.ParentName,
                                 expCat.CategoryDescription,
                             }).ToList();
            cmbParentCategory.DataSource = cmbParentCat;
            //this.cmbParentCategory.DataSource = db.ExpenseCategory.ToList();
            cmbParentCategory.DisplayMember = "CategoryName";
            cmbParentCategory.ValueMember = "Id";
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
        private void LoadgrdExpenseCatagory()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var dgvExpCat = (from expCat in db.ExpenseCategory
                             where expCat.IsDelete == false
                             select new
                             {
                                 Sl=expCat.Id,
                                 expCat.CategoryName,
                                 expCat.CategoryCode,
                                 expCat.CategoryType,
                                 expCat.ParentName,
                                 expCat.CategoryDescription,
                             }).ToList();
            grdExpenseCategory.DataSource = dgvExpCat;
            grdExpenseCategory.Columns[0].Visible = false;
            //var dgvColumn = grdExpenseCategory.Columns["Id"];
            //if (dgvColumn != null)
            //    dgvColumn.Visible = false;
            //for (int i=0;i<grdExpenseCategory.Columns.Count; i++)
            //{
            //    var column = grdExpenseCategory.Columns[i];
            //}
        }
        private void InsertParentCategory()
        {
            if (cmbParentCategory.SelectedIndex != -1)
            {
                expenseCategory.Parentid = (int)cmbParentCategory.SelectedValue;
                expenseCategory.ParentName = cmbParentCategory.Text;
            }
            else if (radRootCategory.Checked)
            {
                expenseCategory.Parentid = null;
                expenseCategory.ParentName = "";
            }
        }
        private void ClearCmbParentCatagory()
        {
            this.cmbParentCategory.DataSource = null;
            this.cmbParentCategory.DataBindings.Clear();
            this.cmbParentCategory.Text = "";
            this.cmbParentCategory.SelectedIndex = -1;
        }

        private void grdExpenseCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = grdExpenseCategory.Rows[Index];
            selectedId = (int)selectedRow.Cells[0].Value;
            btnDetails.Visible = true;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            //---
            var dgvExpCat = (from expCat in db.ExpenseCategory
                             where expCat.Id == selectedId
                             select expCat).ToList();
            grdExpenseCategory.DataSource = dgvExpCat;
            //grdExpenseCategory.Columns[0].Visible = false;
        }
    }
}
