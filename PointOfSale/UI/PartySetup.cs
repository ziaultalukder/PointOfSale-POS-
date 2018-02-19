using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class PartySetup : Form
    {
        public PartySetup()
        {
            InitializeComponent();
        }
        // Browse Image
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please Select Image";
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.partyPictureBox.ImageLocation = openFileDialog.FileName;
            }

        }
        private byte[] ConvertToFileByte(string iPath)
        {
            byte[] data = null;
            FileInfo info = new FileInfo(iPath);
            long numByte = info.Length;
            FileStream fileStream = new FileStream(iPath, FileMode.Open, FileAccess.Read);
            BinaryReader Br = new BinaryReader(fileStream);
            data = Br.ReadBytes((int)numByte);
            return data;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Models.PartySetup partySetup = new Models.PartySetup();
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


            partySetup.Image = ConvertToFileByte(this.partyPictureBox.ImageLocation);

            
            PartyManager partyManager = new PartyManager();



            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (contactTextBox.Text == String.Empty)
            {
                MessageBox.Show("Contact Field Empty");
                return;
            } 
            else if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (partySetup.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Address Field Emplty");
                return;
            }
            

            var row = partyManager.InsertParty(partySetup);
            if (row)
            {
                MessageBox.Show("Data Inserted Successfully");
                GetViewdata();
            }
            else
            {
                MessageBox.Show("Data Inserted Failed");
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            GetViewdata();
        }

        private void GetViewdata()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            partyDataGridView.DataSource = db.PartySetup.ToList();
        }

        private void partyDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idLabel.Text             = partyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            nameTextBox.Text         = partyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            contactTextBox.Text      = partyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            codeTextBox.Text         = partyDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            emailTextBox.Text        = partyDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            addressTextBox.Text      = partyDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            //customerRadioButton.Text = partyDataGridView.SelectedRows[0].Cells[8].Value.ToString();

            byte[] imageData = (byte[])partyDataGridView.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(imageData);
            partyPictureBox.Image = Image.FromStream(ms);

            updateButton.Visible = true;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Models.PartySetup partySetup = new Models.PartySetup();
            partySetup.Id = Convert.ToInt32(idLabel.Text); 
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
            
            
            partySetup.Image = ConvertToFileByte(this.partyPictureBox.ImageLocation);

            PartyManager partyManager = new PartyManager();


            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (contactTextBox.Text == String.Empty)
            {
                MessageBox.Show("Contact Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (partySetup.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Address Field Emplty");
                return;
            }


            var row = partyManager.UpdateParty(partySetup);
            if (row)
            {
                MessageBox.Show("Party Updated Successfully");
                SuperShopDatabaseContext db = new SuperShopDatabaseContext();
                partyDataGridView.DataSource = db.PartySetup.ToList();
            }
            else
            {
                MessageBox.Show("Party Updated Failed");
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var data =
                (from party in db.PartySetup where party.Contact.Contains(searchTextBox.Text) select party).ToList();
            partyDataGridView.DataSource = data;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Models.PartySetup partySetup = new Models.PartySetup();
            partySetup.Id = Convert.ToInt32(idLabel.Text);
            PartyManager partyManager = new PartyManager();
            
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Deleted Party", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var row = partyManager.DeleteSetupParty(partySetup);
            }
            else
            {
                MessageBox.Show("delete Failed");
            }
        }

        private void PartySetup_Load(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            partyDataGridView.DataSource = db.PartySetup.ToList();




        }

        private void partyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
