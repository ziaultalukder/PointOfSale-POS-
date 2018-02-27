using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.DatabaseContext;
using PointOfSale.Manager;

namespace PointOfSale.UI
{
    public partial class PartySetupUI : Form
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        Models.PartySetup partySetup = new Models.PartySetup();
        PartyManager partyManager = new PartyManager();
        public PartySetupUI()
        {
            InitializeComponent();
            ClearAllForm();
        }
        // Browse Image
        private void button5_Click(object sender, EventArgs e)
        {
            string photo = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Photo";
            ofd.Filter = "Photo File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photo = ofd.FileName;
                partyPictureBox.ImageLocation = photo;
            }
            ofd.Multiselect = false;
            FileStream fs = new FileStream(photo, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            partySetup.Image = br.ReadBytes((int)fs.Length);

        }
       
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValidated())
            {
                partySetup.Name = nameTextBox.Text;
                partySetup.Contact = contactTextBox.Text;
                partySetup.Code = codeTextBox.Text;
                partySetup.Email = emailTextBox.Text;
                partySetup.Address = addressTextBox.Text;
                partySetup.DataTime = partyDateTimePicker.Value;

                if (customerCheckBox.Checked && supplierCheckBox.Checked)
                {
                    partySetup.Customer = customerCheckBox.Text;
                    partySetup.Supplier = supplierCheckBox.Text;
                }
                else if (supplierCheckBox.Checked)
                {
                    partySetup.Supplier = supplierCheckBox.Text;
                }
                else if (customerCheckBox.Checked)
                {
                    partySetup.Customer = customerCheckBox.Text;
                }

                partySetup.Image = partySetup.Image;


                //if (IsFormValidated()) return;
                var row = partyManager.InsertParty(partySetup);
                if (row)
                {
                    //codeTextBox.Text = partySetup.Code;
                    WinMessageBox.ShowSuccessMessage("Record save is successfully.");
                    GetViewdata();
                    ClearAllForm();
                    //updateButton.Enabled = false;
                    //deleteButton.Enabled = false;
                }
                else
                {
                    WinMessageBox.ShowErrorMessage("Record save is failed !");
                }
            }
        }

        private bool IsFormValidated()
        {
            if (nameTextBox.Text.Trim()==string .Empty)
            {
                WinMessageBox.ShowErrorMessage("Name is required.");
                nameTextBox.Focus();
                return false;
            }
            if (contactTextBox.Text.Trim() == string .Empty)
            {
                WinMessageBox.ShowErrorMessage("Contact number is required.");
                contactTextBox.Focus();
                return false;
            }
            if (emailTextBox.Text.Trim() == string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Email address is required.");
                emailTextBox.Focus();
                return false;
            }
            if (addressTextBox.Text.Trim()==string .Empty)
            {
                WinMessageBox.ShowErrorMessage("Address line is required.");
                addressTextBox.Focus();
                return false;
            }
            return true;
        }
        private void GetViewdata()
        {
            var dgvShow = (from partySetup in db.PartySetup
                           where (partySetup.IsDeleteMode == false)
                           select new
                           {
                               partySetup.Id,
                               partySetup.Name,
                               partySetup.Code,
                               partySetup.Email,
                               partySetup.Address,
                               partySetup.Image,
                               partySetup.DataTime,
                               partySetup.Customer,
                               partySetup.Supplier
                           }).ToList();
            partyDataGridView.DataSource = dgvShow;
            var dataGridViewColumn = partyDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) //dataGridViewColumn.Visible = false;
                for (int i = 0; i < partyDataGridView.Columns.Count; i++)
                {
                    var column = partyDataGridView.Columns[i] as DataGridViewImageColumn;
                    if (column == null) continue;
                    column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (IsFormValidated())
            {
                if (MessageBox.Show("Are You Sure to Update this Record", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //partySetup.Id = Convert.ToInt32(idLabel.Text);
                    partySetup.Name = nameTextBox.Text;
                    partySetup.Contact = contactTextBox.Text;
                    partySetup.Code = codeTextBox.Text;
                    partySetup.Email = emailTextBox.Text;
                    partySetup.Address = addressTextBox.Text;
                    partySetup.DataTime = partyDateTimePicker.Value;

                    if (customerCheckBox.Checked)
                    {
                        partySetup.Customer = customerCheckBox.Text;
                    }
                    else
                    {
                        partySetup.Supplier = supplierCheckBox.Text;
                    }

                    partySetup.Image = partySetup.Image;

                    var row = partyManager.UpdateParty(partySetup);
                    if (row)
                    {
                        WinMessageBox.ShowSuccessMessage("Record update is successfully.");
                        GetViewdata();
                    }
                    else
                    {
                        MessageBox.Show("Party Updated Failed");
                    }
                    ClearAllForm();
                }
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var data = (from party in db.PartySetup where party.Contact.Contains(searchTextBox.Text) select party).ToList();
            partyDataGridView.DataSource = data;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "Organization", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedId = (int)partyDataGridView.CurrentRow.Cells["Id"].Value;
                var updateParty = db.PartySetup.FirstOrDefault(c => c.Id == selectedId);
                if (selectedId != 0)
                {
                    updateParty.IsDeleteMode = true;
                    db.SaveChanges();
                    WinMessageBox.ShowSuccessMessage("Record delete is successfully.");
                }
            }
            GetViewdata();
            ClearAllForm();
            
        }

        private void PartySetup_Load(object sender, EventArgs e)
        {
            GetViewdata();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string patterns = "^([0-9a-zA-Z]([-\\. \\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(emailTextBox.Text, patterns))
            {
                partySetupRrrorProvider.Clear();
            }
            else
            {
                partySetupRrrorProvider.SetError(this.emailTextBox, "Please Provide Valid Email");
                return;
            }
        }

        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllForm();
        }

        private void ClearAllForm()
        {
            nameTextBox.Clear();
            contactTextBox.Clear();
            emailTextBox.Clear();
            codeTextBox.Clear();
            addressTextBox.Clear();
            partyDateTimePicker.ResetText();
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            partyPictureBox.Image = null;
        }

        private void partyPictureBox_DoubleClick(object sender, EventArgs e)
        {
            string photo = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Photo";
            ofd.Filter = "Photo File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photo = ofd.FileName;
                partyPictureBox.ImageLocation = photo;
            }
            ofd.Multiselect = false;
            FileStream fs = new FileStream(photo, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            partySetup.Image = br.ReadBytes((int)fs.Length);
        }

        private void AutoCodeGenerate()
        {
            int counts = 1;
            counts = db.Employee.Include(c => c.Id).Count() + counts;
            codeTextBox.Text = 100000 + counts.ToString();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoCodeGenerate();
        }

        private void partyDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (partyDataGridView.CurrentRow != null)
            {
                int dgvIndex = (int)partyDataGridView.CurrentRow.Cells["Id"].Value;
                var dgvObj = db.PartySetup.FirstOrDefault(c => c.Id == dgvIndex);
                partySetup = dgvObj;
            }
            if (partySetup != null)
            {
                nameTextBox.Text = partySetup.Name;
                contactTextBox.Text = partySetup.Contact;
                emailTextBox.Text = partySetup.Email;
                codeTextBox.Text = partySetup.Code;
                addressTextBox.Text = partySetup.Address;
                partyDateTimePicker.Value = partySetup.DataTime;
                if (partySetup.Image != null)
                {
                    byte[] data = partySetup.Image;
                    MemoryStream ms = new MemoryStream(data);
                    partyPictureBox.Image = Image.FromStream(ms);
                }
                else
                {
                    partyPictureBox.Image = null;
                }
                updateButton.Visible = true;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            //SetFormUpdateMode();
        }
    }
}
