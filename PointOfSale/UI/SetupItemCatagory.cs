using PointOfSale.Models;
using PointOfSale.Manager;
using PointOfSale.DatabaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI
{
    public partial class SetupItemCatagory : Form
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        Models.SetupItemCatagory setupItemCatagory = new Models.SetupItemCatagory();
        public SetupItemCatagory()
        {
            InitializeComponent();
            AutoCodeGenerate();
        }

        private void AutoCodeGenerate()
        {
            //int counts = 1;
            //counts = db.SetupItemCatagories.Include(c => c.Id).Count() + counts;
            //codeTextBox.Text = "1000" + counts;
        }
        private void imageBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please Select Image";
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.itemCatagoryPictureBox.ImageLocation = openFileDialog.FileName;
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
        private void radRootCategory_CheckedChanged(object sender, EventArgs e)
        {
            itemCatagoryComboBox.Hide();
            itemCatagoryComboBox.SelectedValue = 0;
        }
        private void radChildCategory_CheckedChanged(object sender, EventArgs e)
        {
            itemCatagoryComboBox.Show();
        }
        private void Savebutton_Click(object sender, EventArgs e)
        {

            

            setupItemCatagory.Name = nameTextBox.Text;
            setupItemCatagory.Code = codeTextBox.Text;
            setupItemCatagory.Description = descriptionTextBox.Text;
           // setupItemCatagory.Id = codeTextBox.Text;
            setupItemCatagory.Image = ConvertToFileByte(this.itemCatagoryPictureBox.ImageLocation);
            setupItemCatagory.CatagoryType = radRootCategory.Checked ? "Parent" : "Child";
            if (itemCatagoryComboBox.Text == "")
            {
                setupItemCatagory.Name = nameTextBox.Text;
            }
            else
            {
                setupItemCatagory.CatagoryId = (int)itemCatagoryComboBox.SelectedValue;
            }

            SetupItemCatagoryManager setupItemManager = new SetupItemCatagoryManager();


            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (setupItemCatagory.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("Description Field Empty");
                return;
            }
            


            var row = setupItemManager.InsertSetupItemCatagory(setupItemCatagory);
            if (row)
            {
                MessageBox.Show("Setup Item Catagory Inserted");
            }
            else
            {
                MessageBox.Show("Setup Item Catagory Inserted Failed");
            }
            btnDelete.Enabled = false;
            GetSetupItemCatagory();
        }
        
        private void SetupItemCatagory_Load(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            itemCatagoryComboBox.DataSource = db.SetupItemCatagories.ToList();
            itemCatagoryComboBox.ValueMember = "Name";
            itemCatagoryComboBox.ValueMember = "Id";

            GetSetupItemCatagory();
            ClearAllForm();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            //GetSetupItemCatagory();
        }

        private void GetSetupItemCatagory()
        {
            
            setupItemCatagoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            setupItemCatagoryDataGridView.RowTemplate.Height = 50;
            setupItemCatagoryDataGridView.AllowUserToAddRows = false;

            setupItemCatagoryDataGridView.DataSource =
                db.SetupItemCatagories.Select(
                    c =>
                        new
                        {
                            Id = c.Id,
                            Name = c.Name,
                            Code = c.Code,
                            Description = c.Description,
                            Images = c.Image,
                            CatagoryType = c.CatagoryType,
                            CatagoryId = c.CatagoryId
                        }).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Models.SetupItemCatagory setupItemCatagory = new Models.SetupItemCatagory();
            setupItemCatagory.Id           = Convert.ToInt32(idLabel.Text);
            setupItemCatagory.Name         = nameTextBox.Text;
            setupItemCatagory.Code         = codeTextBox.Text;
            setupItemCatagory.Description  = descriptionTextBox.Text;
            setupItemCatagory.Image        = ConvertToFileByte(this.itemCatagoryPictureBox.ImageLocation);
            setupItemCatagory.CatagoryType = radRootCategory.Checked ? "Parent" : "Child";
            if (itemCatagoryComboBox.Text == "")
            {
                setupItemCatagory.Name = nameTextBox.Text;
            }
            else
            {
                setupItemCatagory.CatagoryId = (int)itemCatagoryComboBox.SelectedValue;
            }

            SetupItemCatagoryManager sertupManager = new SetupItemCatagoryManager();



            if (string.IsNullOrEmpty(itemCatagoryComboBox.Text))
            {
                MessageBox.Show("Please Select an Outlate");
                return;
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (setupItemCatagory.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("Description Field Empty");
                return;
            }
            


            var row = sertupManager.UpdateItemCategory(setupItemCatagory);
            if (row)
            {
                MessageBox.Show("Setup Item Catagory Updated");
            }
            else
            {
                MessageBox.Show("Setup Item Catagory Updated failed");
            }

            //btnDelete.Visible = true;
            //btnUpdate.Visible = true;
            GetSetupItemCatagory();

        }

        private void setupItemCatagoryDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idLabel.Text            = setupItemCatagoryDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            nameTextBox.Text        = setupItemCatagoryDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            codeTextBox.Text        = setupItemCatagoryDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            descriptionTextBox.Text = setupItemCatagoryDataGridView.SelectedRows[0].Cells[3].Value.ToString();

            //itemCatagoryComboBox.Text = setupItemCatagoryDataGridView.SelectedRows[0].Cells[4].Value.ToString();

            byte[] imageData = (byte[])setupItemCatagoryDataGridView.SelectedRows[0].Cells[4].Value;
            MemoryStream ms = new MemoryStream(imageData);
            itemCatagoryPictureBox.Image = Image.FromStream(ms);


            //byte[] imageData = (byte[])setupItemCatagoryDataGridView.SelectedRows[0].Cells[5].Value;
            //MemoryStream ms = new MemoryStream(imageData);
            //itemCatagoryPictureBox.Image = Image.FromStream(ms);


            itemCatagoryComboBox.Text = setupItemCatagoryDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Models.SetupItemCatagory setupItemCatagory = new Models.SetupItemCatagory();
            //if (this.IsDelete)
            //{
            //    if (MessageBox.Show("Are You Sure to delete this Record", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
                    SetupItemCatagoryManager sicm = new SetupItemCatagoryManager();
                    setupItemCatagory.Id = Convert.ToInt32(idLabel.Text);
                    var rows = sicm.DeleteItemCategory(setupItemCatagory);
                    if (rows)
                    {
                        MessageBox.Show("Delete Successfully.");
                    }
            //    }
            //}
            GetSetupItemCatagory();
            ClearAllForm();
        }

        private void ClearAllForm()
        {
            itemCatagoryComboBox.SelectedIndex = -1;
            nameTextBox.Clear();
            codeTextBox.Clear();
            descriptionTextBox.Clear();
            itemCatagoryPictureBox.Image = null;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllForm();
        }
    }
}
