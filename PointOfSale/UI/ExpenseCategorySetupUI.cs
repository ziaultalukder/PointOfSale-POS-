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
    public partial class ExpenseCategorySetupUI : Form
    {
        int selectedId;
        int OldCode;
        ExpenseCategory expenseCategory = new ExpenseCategory();
        ExpenseCategoryManager expenseCategoryManager = new ExpenseCategoryManager();

        public ExpenseCategorySetupUI()
        {
            InitializeComponent();
            radRootCategory.Checked = true;
            //LoadparentCategoryComboBox();
            AutoCodeShow();
            this.grdExpenseCategory.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdExpenseCategory_RowPostPaint);
            LoadgrdExpenseCatagory();
            this.txtCategoryCode.KeyPress += new KeyPressEventHandler(txtCategoryCode_KeyPress);
        }
        private void grdExpenseCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(grdExpenseCategory.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        private void txtCategoryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void radChildCategory_CheckedChanged(object sender, EventArgs e)
        {
            cmbParentCategory.Show();
            LoadparentCategoryComboBox();
            cmbParentCategory.SelectedIndex = -1;
            lblSelectParent.Show();
        }

        private void radRootCategory_CheckedChanged(object sender, EventArgs e)
        {
            ClearCmbParentCatagory();
            this.cmbParentCategory.Hide();
            lblSelectParent.Hide();
            //AutoCodeShow();
            //RootAutoCodeShow();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            RefreshAll();
            AutoCodeShow();

        }

        private void cmbParentCategory_Click(object sender, EventArgs e)
        {
            LoadparentCategoryComboBox();
            //cmbParentCategory.SelectedIndex = -1;
        }
        private void cmbParentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AutoCodeShow();
            //ChildAutoCodeShow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();

            if (string.IsNullOrEmpty(txtCategoryId.Text))
            {
                if (string.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show("Name Field Empty");
                    return;
                }
                string testName = txtCategoryName.Text;
                bool isNameExist = db.ExpenseCategory.Count(c => c.CategoryName == testName) > 0;
                if (isNameExist)
                {
                    MessageBox.Show("Name is Allready Exist");
                    return;
                } 
                expenseCategory.CategoryName = txtCategoryName.Text;
                if(radRootCategory.Checked==false && radChildCategory.Checked==false)
                    {
                    MessageBox.Show("Please Select a Category Type Check box.");
                    return;
                    }
                //expenseCategory.CategoryType = GetCategoryType();
                int isInt; 
                if (string.IsNullOrEmpty(txtCategoryCode.Text))
                {
                    MessageBox.Show("Code Field Empty");
                    return;
                }
                bool isInteger = int.TryParse(txtCategoryCode.Text.Trim(), out isInt);
                if (!isInteger)
                {
                    MessageBox.Show("Please enter the Numbers only, Between 1000 to 9999!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    int testCode=Convert.ToInt32(txtCategoryCode.Text);
                    if (testCode<1000 || testCode>9999)
                    {
                        MessageBox.Show("Please enter the Code Between 1000 to 9999!!!");
                        return;
                    }
                    //SuperShopDatabaseContext db = new SuperShopDatabaseContext();
                    bool isCodeExist = db.ExpenseCategory.Count(c => c.CategoryCode == testCode) > 0;
                    if (isCodeExist)
                    {
                        MessageBox.Show("Code is Allready Exist");
                        return;
                    } 
                    expenseCategory.CategoryCode = Convert.ToInt32(txtCategoryCode.Text);
                }
                expenseCategory.CategoryDescription = txtCategoryDiscription.Text;
                InsertParentCategory();
                if (radChildCategory.Checked == true && cmbParentCategory.SelectedIndex == -1)
                {
                    //MessageBox.Show("Please review Category Type and Parent Caregory!");
                    return;
                }
                expenseCategory.IsDelete = false;
                DialogResult dialogResult=MessageBox.Show("Are you sure want to save ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    //InsertParentCategory();

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
                }
                RefreshAll();
            }
                //Update Method
            else
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
                //if (expenseCategory.CategoryCode!=Convert.ToInt32(txtCategoryCode.Text))
                //{
                int isInt;
                if (string.IsNullOrEmpty(txtCategoryCode.Text))
                {
                    MessageBox.Show("Code Field Empty");
                    return;
                }
                bool isInteger = int.TryParse(txtCategoryCode.Text.Trim(), out isInt);
                if (!isInteger)
                {
                    MessageBox.Show("Please enter the Numbers only, Between 1000 to 9999!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    int testCode = Convert.ToInt32(txtCategoryCode.Text);
                    if (testCode < 1000 || testCode > 9999)
                    {
                        MessageBox.Show("Please enter the Code Between 1000 to 9999!!!");
                        return;
                    }
                    //SuperShopDatabaseContext db = new SuperShopDatabaseContext();
                    bool isCodeUnchanged = testCode != OldCode;
                    //bool isCodeSame = db.ExpenseCategory.Count(c => c.CategoryCode == OldCode && c.Id == selectedId) > 0;
                    bool isCodeExist = db.ExpenseCategory.Count(c => c.CategoryCode == testCode) > 0;
                    if (isCodeUnchanged)
                    {
                        if (isCodeExist)
                        {
                            MessageBox.Show("Code is Allready Exist");
                            return;
                        }

                    }
                    expenseCategory.CategoryCode = Convert.ToInt32(txtCategoryCode.Text);
                }
                //}
//                expenseCategory.CategoryCode = Convert.ToInt32(txtCategoryCode.Text);

                //if (string.IsNullOrEmpty(txtCategoryDiscription.Text))
                //{
                //    MessageBox.Show("Description Field Emptyt");
                //    return;
                //}
                expenseCategory.CategoryDescription = txtCategoryDiscription.Text;
                if (radRootCategory.Checked == false && radChildCategory.Checked == false)
                {
                    MessageBox.Show("Please Select a Category Type Check box.");
                    return;
                }
                //expenseCategory.CategoryType = GetCategoryType();
                InsertParentCategory();
                if (radChildCategory.Checked == true && cmbParentCategory.SelectedIndex == -1)
                {
                    //MessageBox.Show("Please review Category Type and Parent Caregory!");
                    return;
                }
                expenseCategory.IsDelete = false;
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
            AutoCodeShow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            expenseCategory.Id = Convert.ToInt32(txtCategoryId.Text);
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Name Field Empty!! /n Which one do you want to Delete?");
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
             DialogResult dialogResult=MessageBox.Show("Are you sure want to Delete?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (dialogResult == DialogResult.Yes)
             {
                 expenseCategory.IsDelete = true;
             }

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
            if (Index > -1)
            {
                DataGridViewRow selectedRow = grdExpenseCategory.Rows[Index];
                txtCategoryId.Text = selectedRow.Cells[0].Value.ToString();
                txtCategoryName.Text = selectedRow.Cells[1].Value.ToString();
                txtCategoryCode.Text = selectedRow.Cells[2].Value.ToString();
                txtCategoryCode.Text = selectedRow.Cells[2].Value.ToString();
                OldCode = (int)selectedRow.Cells[2].Value;
                if (selectedRow.Cells[4].Value != null)
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
            grdExpenseCategory.DataSource = null;
            LoadgrdExpenseCatagory();
        }
        private void LoadparentCategoryComboBox()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            //this.cmbParentCategory.DataSource = db.ExpenseCategory.ToList();
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
            cmbParentCategory.DisplayMember = "CategoryName";
            cmbParentCategory.ValueMember = "Id";
        }
        private string GetCategoryType()
        {
            string expCatType="";
            if (radRootCategory.Checked)
            {
                expCatType = "Root";
            }
            else if (radChildCategory.Checked)
            {
                expCatType = "Child";
            }
            //else
            //{
            //    MessageBox.Show("Please Select a Radio Button");
            //    //return;
            //}
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
            if (radRootCategory.Checked)
            {
                expenseCategory.CategoryType = "Root";
                expenseCategory.Parentid = null;
                expenseCategory.ParentName = "";
            }
            else if (radChildCategory.Checked==true && cmbParentCategory.SelectedIndex != -1)
            {
                expenseCategory.CategoryType = "Child";
                expenseCategory.Parentid = (int)cmbParentCategory.SelectedValue;
                expenseCategory.ParentName = cmbParentCategory.Text;
            }
            else
            MessageBox.Show("Please review Category Type and Parent Caregory!");
            //return;            
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
            if (Index > -1)
            {
                DataGridViewRow selectedRow = grdExpenseCategory.Rows[Index];
                selectedId = (int)selectedRow.Cells[0].Value;
                btnDetails.Visible = true;
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var dgvExpCat = (from expCat in db.ExpenseCategory
                             where expCat.Id == selectedId
                             select expCat).ToList();
            grdExpenseCategory.DataSource = dgvExpCat;
            grdExpenseCategory.Columns[0].Visible = false;


        }
        //private void RootAutoCodeShow()
        //{
        //    SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        //    int RootCount = 0;
        //    RootCount = db.ExpenseCategory.Where(c => c.CategoryType == "Root").Count() +10;

        //    string RootCode = (RootCount + "00").ToString();
        //    txtCategoryCode.Text= RootCode;
        //}

        //private void ChildAutoCodeShow()
        //{
        //    SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        //    if (string.IsNullOrEmpty(cmbParentCategory.Text))
        //    {
        //        txtCategoryCode.Text = "Please select a Parent Category";
        //    }
        //    else
        //    {
        //        string selectedParent = cmbParentCategory.Text;
        //        string Count;
        //        Count = (db.ExpenseCategory.Where(c => c.ParentName == selectedParent).Count() + 1).ToString();
        //        string parentCode = "0000";              
        //        var parent = db.ExpenseCategory.Where(c => c.CategoryName == selectedParent).FirstOrDefault();
        //        if(parent!=null)
        //        {
        //            parentCode = parent.CategoryCode.ToString();
        //        }
        //        txtCategoryCode.Text = parentCode + Count;
        //    }
        //}
        private void AutoCodeShow()
        {
            Random random = new Random();
            var AutoCode = random.Next(1001,9999);
            txtCategoryCode.Text = AutoCode.ToString();
        }

        private void grdExpenseCategory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
