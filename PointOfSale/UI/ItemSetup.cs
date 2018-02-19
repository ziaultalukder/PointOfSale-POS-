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
    public partial class ItemSetup : Form
    {
        public ItemSetup()
        {
            InitializeComponent();
        }
        
        private void ItemSetup_Load(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            catagoryComboBox.DataSource = db.SetupItemCatagories.ToList();
            catagoryComboBox.DisplayMember = "Name";
            catagoryComboBox.ValueMember = "Id";


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

            
            
            Models.ItemSetups itemSetup = new Models.ItemSetups();
            itemSetup.Name = nameTextBox.Text;
            itemSetup.CostPrice =Convert.ToDouble(costPriceTextBox.Text);
            itemSetup.SalesPrice = Convert.ToDouble(salesPriceTextBox.Text);
            itemSetup.Code = codeTextBox.Text;
            itemSetup.Description = descriptionTextBox.Text;
            itemSetup.Image = ConvertToFileByte(this.itemPictureBox.ImageLocation);
            itemSetup.CatagoryId = (int)catagoryComboBox.SelectedValue;

            ItemSetupManager itemSetupManager = new ItemSetupManager();


            if (string.IsNullOrEmpty(catagoryComboBox.Text))
            {
                MessageBox.Show("Please Select A Catagory");
                return;
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (costPriceTextBox.Text == String.Empty)
            {
                MessageBox.Show("Cost Price Field Empty");
                return;
            }
            else if (salesPriceTextBox.Text == String.Empty)
            {
                MessageBox.Show("Sales Price Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (itemSetup.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("description Field Empty");
                return;
            }
            


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
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            GetAllDataItemPartySetup();
        }

        private void GetAllDataItemPartySetup()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
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

        }

        private void itmeSetupDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void catagoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueCode = catagoryComboBox.Text;
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var catagoryCode = from codeValue in db.SetupItemCatagories
                               where codeValue.Code == valueCode
                               select codeValue;

            catagoryCodeTextBox.Text = catagoryCode.ToString();
        }

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
            

            Models.ItemSetups itemSetup = new Models.ItemSetups();
            itemSetup.Id = Convert.ToInt32(idLabel.Text);
            itemSetup.Name = nameTextBox.Text;
            itemSetup.CostPrice = Convert.ToDouble(costPriceTextBox.Text);
            itemSetup.SalesPrice = Convert.ToDouble(salesPriceTextBox.Text);
            itemSetup.Code = codeTextBox.Text;
            itemSetup.Description = descriptionTextBox.Text;
            itemSetup.Image = ConvertToFileByte(this.itemPictureBox.ImageLocation);
            itemSetup.CatagoryId = (int)catagoryComboBox.SelectedValue;

            ItemSetupManager itemSetupManager = new ItemSetupManager();



            if (string.IsNullOrEmpty(catagoryComboBox.Text))
            {
                MessageBox.Show("Please Select A Catagory");
                return;
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (costPriceTextBox.Text == String.Empty)
            {
                MessageBox.Show("Cost Price Field Empty");
                return;
            }
            else if (salesPriceTextBox.Text == String.Empty)
            {
                MessageBox.Show("Sales Price Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (itemSetup.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("description Field Empty");
                return;
            }




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
        }

        private void catagoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();

            int catId = (int)catagoryComboBox.SelectedValue;
        }
    }
}
