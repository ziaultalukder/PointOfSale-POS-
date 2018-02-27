using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.DatabaseContext;
using PointOfSale.Manager;

namespace PointOfSale.UI
{
    public partial class OutlateUI : Form
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        OutlateManager outlateManager = new OutlateManager();
        Models.Outlate outlate = new Models.Outlate();
        public OutlateUI()
        {
            InitializeComponent();
        }
        
        private void Outlate_Load(object sender, EventArgs e)
        {
            outlateComboBox.DataSource = db.Organaization.ToList();
            outlateComboBox.DisplayMember = "Name";
            outlateComboBox.ValueMember = "Id";

            deleteButton.Enabled = false;
            updateButton.Enabled = false;

            GetOutlateValue();
            Clear();
        }

        private void GetOutlateValue()
        {
            
            //outlateDataGridView.DataSource = db.Outlates.ToList();

            var outlates = (from Ol in db.Outlates
                            join org in db.Organaization on Ol.OrganaizationId equals org.Id
                            select new
                            {
                                SL = Ol.Id,
                                Ol.Name,
                                Ol.Code,
                                Ol.Contact,
                                Ol.Address,
                                Organaization = org.Name
                            }).ToList();
            outlateDataGridView.DataSource = outlates;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValidated())
            {
                //Random r = new Random();
                outlate.Name = nameTextBox.Text;
                outlate.Code = codeTextBox.Text;
                outlate.Contact = contactTextBox.Text;
                outlate.Address = addressTextBox.Text;
                outlate.OrganaizationId = (int)outlateComboBox.SelectedValue;
                bool isNameExits = db.Outlates.Count(c => c.Name == outlate.Name) > 0;
                if (isNameExits)
                {
                    WinMessageBox.ShowErrorMessage("Outlat/Branch name is already exits, Please another name Try.");
                    return;
                }
                var row = outlateManager.Insertoutlate(outlate);
                if (row)
                {
                    WinMessageBox.ShowSuccessMessage("Outlet/Branch record save successfully.");
                    GetOutlateValue();
                    Clear();
                }
                else
                {
                    WinMessageBox.ShowErrorMessage("Outlet/Branch record save failed.");
                }
                deleteButton.Enabled = false;
                updateButton.Enabled = false;
            }
        }

        private bool IsFormValidated()
        {
            if (outlateComboBox.SelectedIndex == -1)
            {
                WinMessageBox.ShowErrorMessage("Organization name is select.");
                return false;
            }
            if (nameTextBox.Text.Trim()==string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Outlet/Branch name is required.");
                nameTextBox.Focus();
                return false;
            }
            if (contactTextBox.Text.Trim()==string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Contact number is required.");
                contactTextBox.Focus();
                return false;
            }
            if (addressTextBox.Text.Trim()==string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Address line is required.");
                addressTextBox.Focus();
                return false;
            }
            return true;
        }

        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (IsFormValidated())
            {
                outlate.Id = Convert.ToInt32(idLabel.Text);
                outlate.Name = nameTextBox.Text;
                outlate.Code = codeTextBox.Text;
                outlate.Contact = contactTextBox.Text;
                outlate.Address = addressTextBox.Text;

                outlate.OrganaizationId = (int) outlateComboBox.SelectedValue;
                bool isNameExits = db.Outlates.Count(c => c.Name == outlate.Name) > 1;
                if (isNameExits)
                {
                    WinMessageBox.ShowErrorMessage("Outlat/Branch name is already exits, Please another name Try.");
                    return;
                }

                var row = outlateManager.Updateoutlate(outlate);
                if (row)
                {
                    MessageBox.Show("Outlate/Branch is Updated");
                    GetOutlateValue();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Outlate Updated Failed");
                }
                deleteButton.Enabled = true;
                updateButton.Enabled = true;
            }
        }

        private void outlateDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            idLabel.Text = outlateDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            nameTextBox.Text = outlateDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            codeTextBox.Text = outlateDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            contactTextBox.Text = outlateDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            addressTextBox.Text = outlateDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            outlateComboBox.Text = outlateDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            deleteButton.Enabled = true;
            updateButton.Enabled = true;
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchItem = searchTextBox.Text;
            var data = (from ol in db.Outlates where ol.Name.Contains(searchItem) select ol).ToList();
           outlateDataGridView.DataSource = data;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            outlate.Id = Convert.ToInt32(idLabel.Text);
            var row = outlateManager.DeleteOutlet(outlate);
            if (row)
            {
                MessageBox.Show("Delete Successfully.");
            }
            GetOutlateValue();
            Clear();
        }

        private void Clear()
        {
            nameTextBox.Clear();
            outlateComboBox.SelectedValue = -1;
            codeTextBox .Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();
            //deleteButton.Enabled = false;
            //updateButton.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void AutoCodeShow()
        {
            int count = 1;
            count = db.Outlates.Include(c => c.Id).Count() + count;
            //var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            codeTextBox.Text = "2000" + count.ToString();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoCodeShow();
        }
    }
}
