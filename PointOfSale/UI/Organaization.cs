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
using PointOfSale.DatabaseContext;
using PointOfSale.Manager;
using PointOfSale.Models;

namespace PointOfSale.UI
{
    public partial class Organaization : Form
    {
        //SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        Models.Organaization organaization = new Models.Organaization();
        public Organaization()
        {
            InitializeComponent();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Logo";
            ofd.Filter = "Logo File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                organaizationPictureBox.Image = new Bitmap(ofd.FileName);
            }
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Please Select Image";
            //openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            ////openFileDialog.Multiselect = false;

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    this.organaizationPictureBox.ImageLocation = openFileDialog.FileName;
            //}
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

        private void ClearTextField()
        {
            //nameTextBox.Clear();
            //codeTextBox.Clear();
            //contactTextBox.Clear();
            //addressTextBox.Clear();
            //organaizationPictureBox.Image = null;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValidated())
            {
                organaization.Name = nameTextBox.Text;
                organaization.Code = AutoCodeShow();
                organaization.Contact = contactTextBox.Text;
                organaization.Description = addressTextBox.Text;
                organaization.Image = (organaizationPictureBox.Image == null) ? null : ImageManipulation.GetPhoto(organaizationPictureBox);
                using (SuperShopDatabaseContext db = new SuperShopDatabaseContext())
                {
                    if (organaization.Id ==0) //Insert
                    {
                        db.Organaization.Add(organaization);
                        db.SaveChanges();
                    }
                    else //Update
                    {
                        db.Entry(organaization).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    //db.SaveChanges();
                }
                Clear();
                ViewOrganaization();
                WinMessageBox.ShowSuccessMessage("Record save successfully");
            }
            //Random r = new Random();

            
            
            //organaization.Image = ConvertToFileByte(this.organaizationPictureBox.ImageLocation);
            //OrganaizationManager organaizationManager = new OrganaizationManager();

            ////if (IsFormValidated(organaizationManager)) return;
            

            //var row = organaizationManager.InsertOrganaization(organaization);
            //if (row)
            //{
            //    MessageBox.Show("Organaization save successfully");
            //    ViewOrganaization();
            //    ClearTextField();
            //}
        }
        private string AutoCodeShow()
        {
            using (SuperShopDatabaseContext db = new SuperShopDatabaseContext())
            {
                int count = 1;
                count = db.Organaization.DefaultIfEmpty().Max(c => c == null ? 0 : c.Id);
                //var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
                var result = "1000" + count;
                return result;
            }
            
        }

        private bool IsFormValidated()
        {
            if (nameTextBox.Text.Trim() == string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Organization name is required.");
                nameTextBox.Focus();
                return false;
            }
            if (addressTextBox.Text.Trim() == string.Empty)
            {
                WinMessageBox.ShowErrorMessage("Organization address is required.");
                addressTextBox.Focus();
                return false;
            }
            //if (organaizationManager.IsNameAlreadyExist(organaization.Name))
            //{
            //    MessageBox.Show("Organaization Already Exist");
            //    return true;
            //}
            return true;
        }

        private void Organaization_Load(object sender, EventArgs e)
        {
            Clear();
            ViewOrganaization();
            //codeTextBox.Text= AutoCodeGenerate();
        }
        private string AutoCodeGenerate()
        {
            Random r = new Random();
            string code = r.Next().ToString();
            return code;
        }

        private void ViewOrganaization()
        {
            organaizationdataGridView.AutoGenerateColumns = false;
            using (SuperShopDatabaseContext db = new SuperShopDatabaseContext())
            {
                organaizationdataGridView.DataSource = db.Organaization.ToList<Models.Organaization>();
            }
        }
        
        private void updateButton_Click(object sender, EventArgs e)
        {
            //Models.Organaization organaization = new Models.Organaization();
            //organaization.Id = Convert.ToInt32(idLabel.Text);
            //organaization.Name = nameTextBox.Text;
            //organaization.Code = AutoCodeGenerate();
            //organaization.Contact = contactTextBox.Text;
            //organaization.Description = addressTextBox.Text;
            //organaization.Image = ConvertToFileByte(this.organaizationPictureBox.ImageLocation);
            //OrganaizationManager organaizationManager = new OrganaizationManager();

            //if (string.IsNullOrEmpty(nameTextBox.Text))
            //{
            //    MessageBox.Show("Name Field Emplty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(codeTextBox.Text))
            //{
            //    MessageBox.Show("Code Field Emplty");
            //    return;
            //}
            //else if (organaization.Code.Length <= 6)
            //{
            //    MessageBox.Show("Security Code Must Be 6 Disit");
            //    return;
            //}
            //else if (organaizationManager.IsNameAlreadyExist(organaization.Name))
            //{
            //    MessageBox.Show("Organaization Already Exist");
            //    return;
            //}


            //var row = organaizationManager.UpdateOrganaization(organaization);
            //if (row)
            //{
            //    MessageBox.Show("Organaization Updated Successfully");
            //    ViewOrganaization();
            //    ClearTextField();
            //}
        }

        private void organaizationdataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (organaizationdataGridView.CurrentRow.Index != -1)
            {
                organaization.Id = Convert.ToInt32(organaizationdataGridView.CurrentRow.Cells["Id"].Value);
                using (SuperShopDatabaseContext db = new SuperShopDatabaseContext())
                {
                    organaization = db.Organaization.Where(c => c.Id == organaization.Id).FirstOrDefault();
                    nameTextBox.Text = organaization.Name;
                    codeTextBox.Text = organaization.Code;
                    contactTextBox.Text = organaization.Contact;
                    addressTextBox.Text = organaization.Description;
                    byte[] imageData = organaization.Image;
                    MemoryStream MS = new MemoryStream(imageData);
                    organaizationPictureBox.Image = Image.FromStream(MS);
                }
                //nameTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                //codeTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                //contactTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                //addressTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[4].Value.ToString();

                //byte[] imageData = (byte[]) organaizationdataGridView.SelectedRows[0].Cells[5].Value;
                //MemoryStream MS = new MemoryStream(imageData);
                //organaizationPictureBox.Image = Image.FromStream(MS);

                saveButton.Text = "Update";
                deleteButton.Enabled = true;
            }
        }

        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var data = (from org in db.Organaization where org.Name.Contains(textBox1.Text) select org).ToList();
            organaizationdataGridView.DataSource = data;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "Are You Sure to Delete this Record ?","Organization",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                using (SuperShopDatabaseContext db = new SuperShopDatabaseContext())
                {
                    var entry = db.Entry(organaization);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Organaization.Attach(organaization);
                        db.Organaization.Remove(organaization);
                        db.SaveChanges();
                        
                        MessageBox.Show("Delete Successfully.");
                        ViewOrganaization();
                        Clear();
                    }
                }
            }
            //SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            //Models.Organaization organaization = new Models.Organaization();
            //int id = Convert.ToInt32(idLabel.Text);

            //var delId = db.Organaization.FirstOrDefault(c => c.Id == id);
            //if ((delId)
            //{
            //    MessageBox.Show("Are You Sure to Delete this Record", "Delete Confirmation", MessageBoxButtons.YesNo);
            //}
            ////DialogResult dialogResult = MessageBox.Show("Are You Sure", "Delete Confirmation",  MessageBoxIcon.Question);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearTextField();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            nameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            organaizationPictureBox.Image = null;
            saveButton.Text = "Save";
            deleteButton.Enabled = false;
            organaization.Id = 0;
        }

        //private void organaizationdataGridView_DoubleClick(object sender, EventArgs e)
        //{
        //    //if (organaizationdataGridView.CurrentRow.Index != -1)
        //    //{
        //    //    organaization.Id = Convert .ToInt32(organaizationdataGridView.CurrentRow.Cells["Id"].Value);
        //    //    using (SuperShopDatabaseContext db = new SuperShopDatabaseContext())
        //    //    {
        //    //        organaization = db.Organaization.Where(c => c.Id == organaization.Id).FirstOrDefault();
        //    //        nameTextBox.Text = organaization.Name;
        //    //        codeTextBox.Text = organaization.Code;
        //    //        contactTextBox.Text = organaization.Contact;
        //    //        addressTextBox.Text = organaization.Description;
        //    //        //byte[] imageData = (byte[])organaization.Image;
        //    //        //MemoryStream MS = new MemoryStream(imageData);
        //    //        //organaizationPictureBox.Image = Image.FormStrem(MS);
        //    //        //organaizationPictureBox.Image = ImageManipulation.PutPhoto((Image);
        //    //        byte[] imageData = (byte[])organaizationdataGridView.SelectedRows[0].Cells[5].Value;
        //    //        MemoryStream MS = new MemoryStream(imageData);
        //    //        organaizationPictureBox.Image = Image.FromStream(MS);
        //    //    }
        //    //    saveButton.Text = "Update";
        //    //    deleteButton.Enabled = true;
        //    //}
        //}
    }
}
