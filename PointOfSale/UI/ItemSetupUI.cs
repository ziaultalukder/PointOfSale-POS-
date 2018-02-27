using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            string photo = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Photo";
            ofd.Filter = "Photo File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photo = ofd.FileName;
                itemPictureBox.ImageLocation = photo;
            }
            ofd.Multiselect = false;
            FileStream fs = new FileStream(photo, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            itemSetup.Image = br.ReadBytes((int)fs.Length);
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
            //Random ran = new Random();
            if (IsFormValidated())
            {
                TextBoxValues();

                bool isExitsName = db.ItemSetups.Count(c => c.Name == itemPictureBox.Name) > 0;
                if (isExitsName)
                {
                    WinMessageBox.ShowErrorMessage("Name is Already Exits, Please another Try.");
                    return;
                }

                var row = itemSetupManager.InsertSetupItemCatagory(itemSetup);
                if (row)
                {
                    WinMessageBox.ShowSuccessMessage("Item save successfully.");
                    GetAllDataItemPartySetup();
                }
                else
                {
                    WinMessageBox.ShowErrorMessage("Item save failed.");
                }
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
                ClearAllForm();
            }
        }

        private void TextBoxValues()
        {
            itemSetup.Name = nameTextBox.Text;
            itemSetup.CostPrice = Convert.ToDouble(costPriceTextBox.Text);
            itemSetup.SalesPrice = Convert.ToDouble(salesPriceTextBox.Text);
            itemSetup.Code = codeTextBox.Text;
            itemSetup.Description = descriptionTextBox.Text;
            itemSetup.Image = itemSetup.Image;
            itemSetup.CatagoryId = (int) catagoryComboBox.SelectedValue;
        }

        private bool IsFormValidated()
        {
            if (catagoryComboBox.SelectedIndex ==-1)
            {
                WinMessageBox.ShowErrorMessage("Catagory item select.");
                return false;
            }
            if (nameTextBox.Text.Trim()==string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Name is required.");
                return false;
            }
            if (costPriceTextBox.Text.Trim()==string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Cost price is required.");
                return false;
            }
            if (salesPriceTextBox.Text.Trim() == string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Sale price is required.");
                return false;
            }
            if (descriptionTextBox.Text.Trim() ==  string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Description is required.");
                return false;
            }
            return true;
        }

        //private void viewButton_Click(object sender, EventArgs e)
        //{
        //    GetAllDataItemPartySetup();
        //}

        private void GetAllDataItemPartySetup()
        {
            var item = (from items in db.ItemSetups
                        where items.IsDeleteMode == false
                        select new
                        {
                            items.Id,
                            items.Name,
                            items.Code,
                            items.CostPrice,
                            items.SalesPrice,
                            items.Image,
                            items.Description
                        }).ToList();
            itmeSetupDataGridView.DataSource = item;
            var dataGridViewColumn = itmeSetupDataGridView.Columns["Id"];
            if (dataGridViewColumn != null) //dataGridViewColumn.Visible = false;
            for (int i = 0; i < itmeSetupDataGridView.Columns.Count; i++)
            {
                var column = itmeSetupDataGridView.Columns[i] as DataGridViewImageColumn;
                if (column == null) continue;
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                break;
            }
            //itmeSetupDataGridView.Columns["Id"].Visible = false;
            //itmeSetupDataGridView.Columns["Image"].DataGridViewImageCellLayout.Stretch;

            //var allItems = (from item in db.ItemSetups
            //                join sic in db.SetupItemCatagories on item.CatagoryId equals sic.Id
            //                select new
            //                {
            //                    Sl = 0,
            //                    item.Name,
            //                    item.CostPrice,
            //                    item.SalesPrice,
            //                    item.Code,
            //                    item.Description,
            //                    item.Image,
            //                    CatagoryName = sic.Name,
            //                    CatagoryCode = sic.Code

            //                }).ToList();
            //itmeSetupDataGridView.DataSource = allItems.ToList();
        }

        //private void itmeSetupDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    idLabel.Text = itmeSetupDataGridView.CurrentRow.Cells[0].Value.ToString();
        //    nameTextBox.Text = itmeSetupDataGridView.CurrentRow.Cells[1].Value.ToString();
        //    costPriceTextBox.Text = itmeSetupDataGridView.CurrentRow.Cells[2].Value.ToString();
        //    salesPriceTextBox.Text = itmeSetupDataGridView.CurrentRow.Cells[3].Value.ToString();
        //    codeTextBox.Text = itmeSetupDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        //    descriptionTextBox.Text = itmeSetupDataGridView.CurrentRow.Cells[5].Value.ToString();
        //    byte[] imageData = (byte[])itmeSetupDataGridView.CurrentRow.Cells[6].Value;
        //    MemoryStream ms = new MemoryStream(imageData);
        //    itemPictureBox.Image = Image.FromStream(ms);

        //    catagoryCodeTextBox.Text = itmeSetupDataGridView.SelectedRows[0].Cells[8].Value.ToString();

        //    updateButton.Enabled = true;
        //    deleteButton.Enabled = true;

        //}

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
                if (MessageBox.Show("Are You Sure to Update this Record", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TextBoxValues();
                    //itemSetup.Name = nameTextBox.Text;
                    //itemSetup.CostPrice = Convert.ToDouble(costPriceTextBox.Text);
                    //itemSetup.SalesPrice = Convert.ToDouble(salesPriceTextBox.Text);
                    //itemSetup.Code = codeTextBox.Text;
                    //itemSetup.Description = descriptionTextBox.Text;
                    //itemSetup.Image = itemSetup.Image;
                    //itemSetup.CatagoryId = (int) catagoryComboBox.SelectedValue;

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
                    updateButton.Enabled = true;
                    deleteButton.Enabled = true;
                    ClearAllForm();
                }
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
            //var shows = db.ItemSetups.Max(c => c.Id);
            //var result = db.ItemSetups.Where(c => c.Code == shows.ToString());
            //codeTextBox.Text = result.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "Organization", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)itmeSetupDataGridView.SelectedRows[0].Cells["Id"].Value;
                if (db.ItemSetups.FirstOrDefault(c => c.Id == id) != null)
                {

                    itemSetup.IsDeleteMode = true;
                    db.Entry( itemSetup).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            ClearAllForm();
            GetAllDataItemPartySetup();
        }

        private void txtBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchItem = txtBoxSearch.Text;
            var data = (from ol in db.ItemSetups where ol.Name.Contains(searchItem) select ol).ToList();
            itmeSetupDataGridView.DataSource = data;
        }

        private void itmeSetupDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (itmeSetupDataGridView.CurrentRow != null)
            {
                int itemId = Convert.ToInt32(itmeSetupDataGridView.CurrentRow.Cells["Id"].Value);
                var itemRetrive = db.ItemSetups.FirstOrDefault(c => c.Id == itemId);
                itemSetup = itemRetrive;

                if (itemSetup != null)
                {
                    nameTextBox.Text = itemSetup.Name;
                    costPriceTextBox.Text = itemSetup.CostPrice.ToString();
                    salesPriceTextBox.Text = itemSetup.SalesPrice.ToString();
                    codeTextBox.Text = itemSetup.Code;
                    descriptionTextBox.Text = itemSetup.Description;
                    if (itemSetup.Image != null)
                    {
                        byte[] data = itemSetup.Image;
                        MemoryStream ms = new MemoryStream(data);
                        itemPictureBox.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        itemPictureBox.Image = null;
                    }
                    //itemPictureBox.Image = itemSetup.Image;



                }
                updateButton.Enabled = true;
                deleteButton.Enabled = true;

                //SetFormUpdateMode();
            }
        }

        private void AutoCodeGenerate()
        {
            int counts = 1;
            counts = db.ItemSetups.Include(c => c.Id).Count() + counts;
            codeTextBox.Text = 111000 + counts.ToString();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoCodeGenerate();
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
