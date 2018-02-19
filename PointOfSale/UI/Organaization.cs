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
using PointOfSale.DatabaseContext;
using PointOfSale.Manager;

namespace PointOfSale.UI
{
    public partial class Organaization : Form
    {
        public Organaization()
        {
            InitializeComponent();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please Select Image";
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.organaizationPictureBox.ImageLocation = openFileDialog.FileName;
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

        private void ClearTextField()
        {
            nameTextBox.Clear();
            codeTextBox.Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            Models.Organaization organaization = new Models.Organaization();
            organaization.Name = nameTextBox.Text;
            organaization.Code = r.Next().ToString();
            organaization.Contact = contactTextBox.Text;
            organaization.Description = addressTextBox.Text;
            organaization.Image = ConvertToFileByte(this.organaizationPictureBox.ImageLocation);
            OrganaizationManager organaizationManager = new OrganaizationManager();

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Emplty");
                return;
            }
            //else if (string.IsNullOrEmpty(codeTextBox.Text))
            //{
            //    MessageBox.Show("Code Field Emplty");
            //    return;
            //}
            else if (organaization.Code.Length < 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }else if (organaizationManager.IsNameAlreadyExist(organaization.Name))
            {
                MessageBox.Show("Organaization Already Exist");
                return;
            }
            

            var row = organaizationManager.InsertOrganaization(organaization);
            if (row)
            {
                MessageBox.Show("Organaization Inserted");
                ViewOrganaization();
                ClearTextField();
            }
        }

        private void Organaization_Load(object sender, EventArgs e)
        {
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
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            organaizationdataGridView.DataSource = db.Organaization.ToList();
        }
        
        private void updateButton_Click(object sender, EventArgs e)
        {
            Models.Organaization organaization = new Models.Organaization();
            organaization.Id = Convert.ToInt32(idLabel.Text);
            organaization.Name = nameTextBox.Text;
            organaization.Code = AutoCodeGenerate();
            organaization.Contact = contactTextBox.Text;
            organaization.Description = addressTextBox.Text;
            organaization.Image = ConvertToFileByte(this.organaizationPictureBox.ImageLocation);
            OrganaizationManager organaizationManager = new OrganaizationManager();

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Emplty");
                return;
            }
            else if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Field Emplty");
                return;
            }
            else if (organaization.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (organaizationManager.IsNameAlreadyExist(organaization.Name))
            {
                MessageBox.Show("Organaization Already Exist");
                return;
            }


            var row = organaizationManager.UpdateOrganaization(organaization);
            if (row)
            {
                MessageBox.Show("Organaization Updated Successfully");
                ViewOrganaization();
            }
        }

        private void organaizationdataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idLabel.Text = organaizationdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            nameTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            codeTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            contactTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            addressTextBox.Text = organaizationdataGridView.SelectedRows[0].Cells[4].Value.ToString();

            byte[] imageData = (byte[]) organaizationdataGridView.SelectedRows[0].Cells[5].Value;
            MemoryStream MS = new MemoryStream(imageData);
            organaizationPictureBox.Image = Image.FromStream(MS);
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
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            Models.Organaization organaization = new Models.Organaization();
            int Id = Convert.ToInt32(idLabel.Text);

            var delId = db.Organaization.FirstOrDefault(c => c.Id == Id);
            //DialogResult dialogResult = MessageBox.Show("Are You Sure", "Delete Confirmation",  MessageBoxIcon.Question);
        }
    }
}
