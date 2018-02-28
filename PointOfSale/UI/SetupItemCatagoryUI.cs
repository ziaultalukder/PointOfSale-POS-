using PointOfSale.Models;
using PointOfSale.Manager;
using PointOfSale.DatabaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI
{
    public partial class SetupItemCatagoryUI : Form
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        Models.SetupItemCatagory setupItemCatagory = new Models.SetupItemCatagory();
        SetupItemCatagoryManager setupItemManager = new SetupItemCatagoryManager();
        public SetupItemCatagoryUI()
        {
            InitializeComponent();
            AutoCodeGenerate();
        }

        private void AutoCodeGenerate()
        {
            int counts = 1;
            counts = db.SetupItemCatagories.Include(c => c.Id).Count() + counts;
            codeTextBox.Text = "110010" + counts;
        }
        private void imageBrowseButton_Click(object sender, EventArgs e)
        {
            string photo = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Photo";
            ofd.Filter = "Photo File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photo = ofd.FileName;
                itemCatagoryPictureBox.ImageLocation = photo;
            }
            ofd.Multiselect = false;
            FileStream fs = new FileStream(photo, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            setupItemCatagory.Image = br.ReadBytes((int)fs.Length);

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Please Select Image";
            //openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            //openFileDialog.Multiselect = false;

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    this.itemCatagoryPictureBox.ImageLocation = openFileDialog.FileName;
            //}
        }
        //private byte[] ConvertToFileByte(string iPath)
        //{
        //    byte[] data = null;
        //    if (iPath != null)
        //    {
        //        FileInfo info = new FileInfo(iPath);
        //        long numByte = info.Length;
        //        FileStream fileStream = new FileStream(iPath, FileMode.Open, FileAccess.Read);
        //        BinaryReader Br = new BinaryReader(fileStream);
        //        data = Br.ReadBytes((int)numByte);
        //    }
        //    return data;
        //}
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
            if (IsFormValidated())
            {
                setupItemCatagory.Name = nameTextBox.Text;
                setupItemCatagory.Code = codeTextBox.Text;
                setupItemCatagory.Description = descriptionTextBox.Text;
                setupItemCatagory.Image = setupItemCatagory.Image;
                setupItemCatagory.CatagoryType = radRootCategory.Checked ? "Parent" : "Child";
                if (itemCatagoryComboBox.Text == "")
                {
                    setupItemCatagory.Name = nameTextBox.Text;
                }
                else
                {
                    setupItemCatagory.CatagoryId = (int) itemCatagoryComboBox.SelectedValue;
                }

                //if (IsFormValidated()) return;

                var row = setupItemManager.InsertSetupItemCatagory(setupItemCatagory);
                if (row)
                {
                    WinMessageBox.ShowSuccessMessage("Item catagory save is successfully.");
                }
                else
                {
                    WinMessageBox.ShowErrorMessage("Item catagory save is failed.");
                }
                btnDelete.Enabled = false;
                GetSetupItemCatagory();
            }
        }

        private bool IsFormValidated()
        {
            if (nameTextBox.Text.Trim() == string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Name is required.");
                return false;
            }
            if (descriptionTextBox.Text.Trim()==string .Empty)
            {
                WinMessageBox.ShowErrorMessage("Description is required.");
                return false;
            }
            
            return true;
        }

        private void SetupItemCatagory_Load(object sender, EventArgs e)
        {
            itemCatagoryComboBox.DataSource = db.SetupItemCatagories.ToList();
            itemCatagoryComboBox.ValueMember = "Name";
            itemCatagoryComboBox.ValueMember = "Id";

            GetSetupItemCatagory();
            ClearAllForm();
        }

        private void GetSetupItemCatagory()
        {
            List<SetupItemCatagoryView> gridDtaList = new List<SetupItemCatagoryView>();
            
            setupItemCatagoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            setupItemCatagoryDataGridView.RowTemplate.Height = 50;
            setupItemCatagoryDataGridView.AllowUserToAddRows = false;
            var test = db.SetupItemCatagories.ToList();
            //var data = db.SetupItemCatagories.Select(
            //        c =>
            //            new
            //            {
            //                Id = c.Id,
            //                Name = c.Name,
            //                Code = c.Code,
            //                Description = c.Description,
            //                Images = c.Image,
            //                CatagoryType = c.CatagoryType,
            //                CatagoryId = c.CatagoryId
            //            }).ToList();

            foreach (var item  in test)
            {
                var newData = new SetupItemCatagoryView
                {
                    Id = item.Id,
                    Image = item.Image,
                    Name = item.Name,
                    Code = item.Code,
                    Description = item.Description,
                    CatagoryId = item.CatagoryId
                };

                var path = GetSetupItemCatagoryPath(item, new List<string>());
                path.Reverse();
                newData.CatagoryPath = path.Aggregate((i, j) => i + " > " + j);
                gridDtaList.Add(newData);
            }
            setupItemCatagoryDataGridView.DataSource = gridDtaList;
            if (setupItemCatagoryDataGridView.Columns != null)
            {
                var column = setupItemCatagoryDataGridView.Columns[5] as DataGridViewImageColumn;
                if (column != null) column.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }


            // = DataGridViewImageCellLayout.Stretch;
        }

        private List<string> GetSetupItemCatagoryPath(SetupItemCatagory model, List<string> name)
        {
            name.Add(model.Name);

            if (model.CatagoryId != null)
            {
                GetSetupItemCatagoryPath(model.Catagory, name);
            }
            return name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsFormValidated())
            {
                setupItemCatagory.Name = nameTextBox.Text;
                setupItemCatagory.Code = codeTextBox.Text;
                setupItemCatagory.Description = descriptionTextBox.Text;
                setupItemCatagory.Image = setupItemCatagory.Image;
                setupItemCatagory.CatagoryType = radRootCategory.Checked ? "Parent" : "Child";
                if (itemCatagoryComboBox.Text == "")
                {
                    setupItemCatagory.Name = nameTextBox.Text;
                }
                else
                {
                    setupItemCatagory.CatagoryId = (int) itemCatagoryComboBox.SelectedValue;
                }

                var row = setupItemManager.UpdateItemCategory(setupItemCatagory);
                if (row)
                {
                    WinMessageBox.ShowSuccessMessage("Item Catagory Updated Successfully.");
                    GetSetupItemCatagory();
                }
                else
                {
                    WinMessageBox.ShowErrorMessage("Item Catagory Updated Failed.");
                }
            }

            //btnDelete.Visible = true;
            //btnUpdate.Visible = true;
            
        }

        //private void setupItemCatagoryDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    idLabel.Text            = setupItemCatagoryDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        //    nameTextBox.Text        = setupItemCatagoryDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        //    codeTextBox.Text        = setupItemCatagoryDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        //    descriptionTextBox.Text = setupItemCatagoryDataGridView.SelectedRows[0].Cells[3].Value.ToString();

        //    //itemCatagoryComboBox.Text = setupItemCatagoryDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            
        //        byte[] imageData = (byte[]) setupItemCatagoryDataGridView.SelectedRows[0].Cells[4].Value;
        //        MemoryStream ms = new MemoryStream(imageData);
        //        itemCatagoryPictureBox.Image = Image.FromStream(ms);
           

        //    //byte[] imageData = (byte[])setupItemCatagoryDataGridView.SelectedRows[0].Cells[5].Value;
        //    //MemoryStream ms = new MemoryStream(imageData);
        //    //itemCatagoryPictureBox.Image = Image.FromStream(ms);


        //    itemCatagoryComboBox.Text = setupItemCatagoryDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        //    btnDelete.Enabled = true;
        //    btnUpdate.Enabled = true;
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "Organization", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)setupItemCatagoryDataGridView.SelectedRows[0].Cells["Id"].Value;
                if (db.SetupItemCatagories.FirstOrDefault(c => c.Id == id) != null)
                {

                    setupItemCatagory.IsDeleteMode = true;
                    db.Entry(setupItemCatagory).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            //Models.SetupItemCatagory setupItemCatagory = new Models.SetupItemCatagory();
            //if (this.IsDelete)
            //{
            //    if (MessageBox.Show("Are You Sure to delete this Record", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        SetupItemCatagoryManager sicm = new SetupItemCatagoryManager();
            //        setupItemCatagory.Id = Convert.ToInt32(idLabel.Text);
            //        var rows = sicm.DeleteItemCategory(setupItemCatagory);
            //        if (rows)
            //        {
            //            MessageBox.Show("Delete Successfully.");
            //        }
            ////    }
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoCodeGenerate();
        }

        private void setupItemCatagoryDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (setupItemCatagoryDataGridView.CurrentRow != null)
            {
                int dgvIndex = (int)setupItemCatagoryDataGridView.CurrentRow.Cells["Id"].Value;
                var dgvObj = db.SetupItemCatagories.FirstOrDefault(c => c.Id == dgvIndex);
                setupItemCatagory  = dgvObj;
            }
            if (setupItemCatagory != null)
            {
                nameTextBox.Text = setupItemCatagory.Name;
                codeTextBox.Text = setupItemCatagory.Code;
                descriptionTextBox.Text = setupItemCatagory.Description;
                if (setupItemCatagory.Image != null)
                {
                    byte[] data = setupItemCatagory.Image;
                    MemoryStream ms = new MemoryStream(data);
                    itemCatagoryPictureBox.Image = Image.FromStream(ms);
                }
                else
                {
                    itemCatagoryPictureBox.Image = null;
                }
            }
            //SetFormUpdateMode();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
