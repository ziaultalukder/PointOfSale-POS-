using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
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
    public partial class OrganaizationUI : Form
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        Models.Organaization organaization = new Models.Organaization();
        OrganaizationManager organaizationManager = new OrganaizationManager();
        private bool isUpdateMode = false;
        public OrganaizationUI()
        {
            InitializeComponent();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            string logo = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Logo";
            ofd.Filter = "Logo File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                logo = ofd.FileName;
                organaizationPictureBox.ImageLocation = logo;
            }
            FileStream fs = new FileStream(logo, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            organaization.Image = br.ReadBytes((int)fs.Length);
        }
  
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValidated())
            {
                if (!isUpdateMode)
                {
                    GetTextBoxValue();
                    bool isExitOrganizationName = db.Organaization.Count(c => c.Name == organaization.Name) > 0;
                    if (isExitOrganizationName)
                    {
                        MessageBox.Show("Organization Name is Exit ? Please Anather name Try.");
                        return;
                    }
                    db.Organaization.Add(organaization);
                    db.SaveChanges();
                    WinMessageBox.ShowSuccessMessage("Record save successfully");
                }
                if (isUpdateMode)
                {
                    GetTextBoxValue();
                    bool isExitOrganizationName = db.Organaization.Count(c => c.Name == organaization.Name) > 1;
                    if (isExitOrganizationName)
                    {
                        MessageBox.Show("Organization Name is Exit ? Please Anather name Try.");
                        return;
                    }
                    db.Organaization.Attach(organaization);
                    db.Entry( organaization ).State = EntityState.Modified;
                    db.SaveChanges();
                    WinMessageBox.ShowSuccessMessage("Record update successfully");
                }
                ClearAllForm();
                ViewDataGridOrganaization();
            }
        }

        private void GetTextBoxValue()
        {
            organaization.Name = nameTextBox.Text;
            organaization.Contact = contactTextBox.Text;
            organaization.Description = addressTextBox.Text;
            organaization.Image = organaization.Image;
            organaization.Code = codeTextBox.Text;
        }

        private void AutoCodeShow()
        { 
             int count = 1;
            count = db.Organaization.Include(c => c.Id).Count() + count;
            //var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            codeTextBox.Text = "1000" + count.ToString();


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
            //    MessageBox.Show("Organaization Name Already Exist");
            //    return false;
            //}
            //if (organaizationManager.IsContactNoAlreadyExist(organaization.Contact))
            //{
            //    MessageBox.Show("Organization Contact No Already Exist");
            //    return false;
            //}
            return true;
        }

        private void Organaization_Load(object sender, EventArgs e)
        {
            ClearAllForm();
            ViewDataGridOrganaization();
        }
        

        private void ViewDataGridOrganaization()
        {
            var dgvShow = (from organaization in db.Organaization
                where (organaization.IsDelete == false)
                select new
                {
                    organaization.Id,
                    organaization.Name,
                    organaization.Code,
                    organaization.Contact,
                    organaization.Description,
                    organaization.Image
                }).ToList();
            organaizationdataGridView.DataSource = dgvShow;
            var dataGridViewColumn = organaizationdataGridView.Columns["Id"];
            if (dataGridViewColumn != null) //dataGridViewColumn.Visible = false;
            for (int i = 0; i < organaizationdataGridView.Columns.Count; i++)
            {
                var column = organaizationdataGridView.Columns[i] as DataGridViewImageColumn;
                if (column == null) continue;
                column .ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            //organaizationdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                int id = (int)organaizationdataGridView.SelectedRows[0].Cells["Id"].Value;
                if (db.Organaization.FirstOrDefault(c=> c.Id == id) !=null )
                {
                    organaization.IsDelete = true;
                    db.SaveChanges();
                }
            }
            ClearAllForm();
            ViewDataGridOrganaization();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllForm();
        }
        private void ClearAllForm()
        {
            nameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            organaizationPictureBox.Image = null;
            codeTextBox.Text = "";
            SetFormNewMode();
        }

        private void SetFormNewMode()
        {
            isUpdateMode = false;
            saveButton.Text = "Save";
            deleteButton.Enabled = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoCodeShow();
        }

        private void organaizationdataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (organaizationdataGridView.CurrentRow != null)
            {
                int dgvIndex = (int)organaizationdataGridView.CurrentRow.Cells["Id"].Value;
                var getDgv = db.Organaization.FirstOrDefault(c => c.Id == dgvIndex);
                organaization = getDgv;
                if (organaization != null)
                {
                    nameTextBox.Text = organaization.Name;
                    codeTextBox.Text = organaization.Code;
                    contactTextBox.Text = organaization.Contact;
                    addressTextBox.Text = organaization.Description;
                    if (organaization.Image != null)
                    {
                        GetPhoto();
                    }
                    else
                    {
                        organaizationPictureBox.Image = null;
                    }
                }
                SetFormUpdateMode();
            }
            //nameTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            //codeTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            //contactTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            //addressTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            //if (organaizationdataGridView.SelectedRows[0].Cells[4].Value != null)
            //{
            //    GetPhoto();
            //}
            //else
            //{
            //    organaizationPictureBox.Image = null;
            //}
            ////organaizationPictureBox.Image = organaizationdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            //SetFormUpdateMode();
        }

        private void SetFormUpdateMode()
        {
            saveButton.Text = "Update";
            deleteButton.Enabled = true;
            isUpdateMode = true;
        }

        private void GetPhoto()
        {
            byte[] data = organaization.Image;
            MemoryStream ms = new MemoryStream(data);
            organaizationPictureBox.Image = Image.FromStream(ms);
        }
    }
}
