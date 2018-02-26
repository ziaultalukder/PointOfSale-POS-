using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Imaging;
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
    public partial class ItemSetupUI : Form
    {
        Models.ItemSetups itemSetup = new Models.ItemSetups();
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        ItemSetupManager itemSetupManager = new ItemSetupManager();
        public ItemSetupUI()
        {
            InitializeComponent();
            ShowLastCode();
        }
        
        private void ItemSetup_Load(object sender, EventArgs e)
        {
            catagoryComboBox.DataSource = db.SetupItemCatagories.ToList();
            catagoryComboBox.DisplayMember = "Name";
            catagoryComboBox.ValueMember = "Id";

            ClearAllForm();
            GetAllDataItemPartySetup();
        }
        private void browserButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please Select Image";
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.itemPictureBox.ImageLocation = openFileDialog.FileName;
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
            Random ran = new Random();
            if (IsFormValidated())
            {
                itemSetup.Name = nameTextBox.Text;
                itemSetup.CostPrice = Convert.ToDouble(costPriceTextBox.Text);
                itemSetup.SalesPrice = Convert.ToDouble(salesPriceTextBox.Text);
                itemSetup.Code = ran.Next().ToString();
                itemSetup.Description = descriptionTextBox.Text;
                itemSetup.Image = ConvertToFileByte(this.itemPictureBox.ImageLocation);
                itemSetup.CatagoryId = (int) catagoryComboBox.SelectedValue;


                //if (IsFormValidated()) return;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;


                var row = itemSetupManager.InsertSetupItemCatagory(itemSetup);
                if (row)
                {
                    MessageBox.Show("Item Setup Added");
                    GetAllDataItemPartySetup();
                }
                else
                {
                    MessageBox.Show("Item Setup Added Faild");
                }
                ClearAllForm();
            }
        }

        private bool IsFormValidated()
        {
            if (string.IsNullOrEmpty(catagoryComboBox.Text))
            {
                MessageBox.Show("Please Select A Catagory");
                return true;
            }
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Empty");
                return true;
            }
            if (costPriceTextBox.Text == String.Empty)
            {
                MessageBox.Show("Cost Price Field Empty");
                return true;
            }
            if (salesPriceTextBox.Text == String.Empty)
            {
                MessageBox.Show("Sales Price Field Empty");
                return true;
            }
            //else if (string.IsNullOrEmpty(codeTextBox.Text))
            //{
            //    MessageBox.Show("Code Field Empty");
            //    return;
            //}
            //else if (itemSetup.Code.Length <= 6)
            //{
            //    MessageBox.Show("Security Code Must Be 6 Disit");
            //    return;
            //}
            if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("description Field Empty");
                return true;
            }
            return true;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            GetAllDataItemPartySetup();
        }

        private void GetAllDataItemPartySetup()
        {
            //itmeSetupDataGridView.DataSource = db.SetupItem.ToList();

            var allItems = (from item in db.ItemSetups
                            join sic in db.SetupItemCatagories on item.CatagoryId equals sic.Id
                            select new
                            {
                                Sl = 0,
                                item.Name,
                                item.CostPrice,
                                item.SalesPrice,
                                item.Code,
                                item.Description,
                                item.Image,
                                CatagoryName = sic.Name,
                                CatagoryCode = sic.Code

                            }).ToList();
            itmeSetupDataGridView.DataSource = allItems.ToList();
        }

        private void itmeSetupDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idLabel.Text = itmeSetupDataGridView.CurrentRow.Cells[0].Value.ToString();
            nameTextBox.Text = itmeSetupDataGridView.CurrentRow.Cells[1].Value.ToString();
            costPriceTextBox.Text = itmeSetupDataGridView.CurrentRow.Cells[2].Value.ToString();
            salesPriceTextBox.Text = itmeSetupDataGridView.CurrentRow.Cells[3].Value.ToString();
            codeTextBox.Text = itmeSetupDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            descriptionTextBox.Text = itmeSetupDataGridView.CurrentRow.Cells[5].Value.ToString();
            byte[] imageData = (byte[])itmeSetupDataGridView.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(imageData);
            itemPictureBox.Image = Image.FromStream(ms);

            catagoryCodeTextBox.Text = itmeSetupDataGridView.SelectedRows[0].Cells[8].Value.ToString();

            updateButton.Enabled = true;
            deleteButton.Enabled = true;

        }

        private void itmeSetupDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //private void catagoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string valueCode = catagoryComboBox.Text;
        //    var catagoryCode = from codeValue in db.SetupItemCatagories
        //                       where codeValue.Code == valueCode
        //                       select codeValue;

        //    catagoryCodeTextBox.Text = catagoryCode.ToString();
        //}

        private void costPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar !='.')
            {
                e.Handled = true;
            }
        }

        private void salesPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                Models.ItemSetups itemSetup = new Models.ItemSetups();
                itemSetup.Id = Convert.ToInt32(idLabel.Text);
                itemSetup.Name = nameTextBox.Text;
                itemSetup.CostPrice = Convert.ToDouble(costPriceTextBox.Text);
                itemSetup.SalesPrice = Convert.ToDouble(salesPriceTextBox.Text);
                itemSetup.Code = codeTextBox.Text;
                itemSetup.Description = descriptionTextBox.Text;
                itemSetup.Image = ConvertToFileByte(this.itemPictureBox.ImageLocation);
                itemSetup.CatagoryId = (int) catagoryComboBox.SelectedValue;

                updateButton.Enabled = true;
                deleteButton.Enabled = true;

                var row = itemSetupManager.UpdateSetupItemCatagory(itemSetup);
                if (row)
                {
                    MessageBox.Show("Item Setup Updated Successfully");
                    GetAllDataItemPartySetup();
                }
                else
                {
                    MessageBox.Show("Item Setup Updated Faild");
                }
                ClearAllForm();
            }
        }

        private void ClearAllForm()
        {
            catagoryComboBox.SelectedValue = -1;
            nameTextBox.Clear();
            costPriceTextBox.Clear();
            salesPriceTextBox.Clear();
            codeTextBox.Clear();
            descriptionTextBox.Clear();
            itemPictureBox.Image = null;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllForm();
        }

        private void ShowLastCode()
        {
            var shows = db.ItemSetups.Max(c => c.Id);
            var result = db.ItemSetups.Where(c => c.Code == shows.ToString());
            codeTextBox.Text = result.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "Organization", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)itmeSetupDataGridView.SelectedRows[0].Cells["Id"].Value;
                if (db.ItemSetups.FirstOrDefault(c => c.Id == id) != null)
                {
                    itemSetup.IsDeleteMode = true;
                    db.SaveChanges();
                }
            }
            ClearAllForm();
            GetAllDataItemPartySetup();
        }

        //private void catagoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    string valueCode = catagoryComboBox.Text;
        //    var catagoryCode = from codeValue in db.SetupItemCatagories
        //                       where codeValue.Code == valueCode
        //                       select codeValue;

        //    catagoryCodeTextBox.Text = catagoryCode.ToString();
        //}
    }
}
