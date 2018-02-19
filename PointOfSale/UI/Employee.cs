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
using System.Text.RegularExpressions;
using PointOfSale.DatabaseContext;
using PointOfSale.Manager;

namespace PointOfSale.UI
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            outlateComboBox.DataSource = db.Outlates.ToList();
            outlateComboBox.DisplayMember = "Name";
            outlateComboBox.ValueMember = "Id";

            GetEmployeeValue();
        }

        private void GetEmployeeValue()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            dataGridView1.DataSource = db.Employee.ToList();

            //var allEmployee = (from empl in db.Employee join outlate in db.Outlates on empl.Id equals outlate.Id
            //                   select new
            //                   {
            //                       SL = empl.Id,
            //                       empl.Name,
            //                       empl.Code,
            //                       empl.Contact,
            //                       empl.Email,
            //                       empl.JoinintDate,
            //                       empl.EmergencyNumber,
            //                       empl.FatherName,
            //                       empl.MotherName,
            //                       empl.Nid,
            //                       empl.PresentAddress,
            //                       empl.PermanentAddress,
            //                       empl.Image,
            //                       OutlateName = outlate.Name
            //                   }).ToList(); 
            //dataGridView1.DataSource = allEmployee;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please Select Image";
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.employeePictureBox.ImageLocation = openFileDialog.FileName;
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
            Models.Employee employee = new Models.Employee();
            employee.Name = nameTextBox.Text;
            employee.Code = codeTextBox.Text;
            employee.Contact = contactTextBox.Text;
            employee.Email = emailTextBox.Text;
            employee.JoinintDate = joiningDateTimePicker.Value;
            employee.EmergencyNumber = emergencyTextBox.Text;
            employee.FatherName = fatherNameTextBox.Text;
            employee.MotherName = motherTextBox.Text;
            employee.Nid = nidTextBox.Text;
            employee.PresentAddress = presenTextBox.Text;
            employee.PermanentAddress = permanentTextBox.Text;
            employee.Image = ConvertToFileByte(this.employeePictureBox.ImageLocation);
            employee.OutlateId = (int)outlateComboBox.SelectedValue;

            EmployeeManager employeeManager = new EmployeeManager();



            if (string.IsNullOrEmpty(outlateComboBox.Text))
            {
                MessageBox.Show("Please Select an Outlate");
                return;
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (contactTextBox.Text == String.Empty)
            {
                MessageBox.Show("Contact Field Empty");
                return;
            }
            else if (emergencyTextBox.Text == String.Empty)
            {
                MessageBox.Show("Emergency Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (employee.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (string.IsNullOrEmpty(presenTextBox.Text))
            {
                MessageBox.Show("Presentation Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(permanentTextBox.Text))
            {
                MessageBox.Show("Permanent Address Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Email Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(fatherNameTextBox.Text))
            {
                MessageBox.Show("Father Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(motherTextBox.Text))
            {
                MessageBox.Show("Mother Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(nidTextBox.Text))
            {
                MessageBox.Show("NID Field Empty");
                return;
            }

            
            
            var row = employeeManager.InsertEmployee(employee);
            if (row)
            {
                MessageBox.Show("Employee Inserted");
                GetEmployeeValue();
            }
            else
            {
                MessageBox.Show("Employee Inserted Failed");
            }
        }
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string patterns = "^([0-9a-zA-Z]([-\\. \\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(emailTextBox.Text, patterns))
            {
                employeeErrorProvider.Clear();
            }
            else
            {
                employeeErrorProvider.SetError(this.emailTextBox, "Please Provide Valid Email");
                return;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            Models.Employee employee = new Models.Employee();
            employee.Id = Convert.ToInt32(idLabel.Text);
            employee.Name = nameTextBox.Text;
            employee.Code = codeTextBox.Text;
            employee.Contact = contactTextBox.Text;
            employee.Email = emailTextBox.Text;
            employee.JoinintDate = joiningDateTimePicker.Value;
            employee.EmergencyNumber = emergencyTextBox.Text;
            employee.FatherName = fatherNameTextBox.Text;
            employee.MotherName = motherTextBox.Text;
            employee.Nid = nidTextBox.Text;
            employee.PresentAddress = presenTextBox.Text;
            employee.PermanentAddress = permanentTextBox.Text;
            employee.Image = ConvertToFileByte(this.employeePictureBox.ImageLocation);
            employee.OutlateId = (int)outlateComboBox.SelectedValue;

            EmployeeManager employeeManager = new EmployeeManager();



            

            if (string.IsNullOrEmpty(outlateComboBox.Text))
            {
                MessageBox.Show("Please Select an Outlate");
                return;
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Empty");
                return;
            }
            else if (contactTextBox.Text == String.Empty)
            {
                MessageBox.Show("Contact Field Empty");
                return;
            }
            else if (emergencyTextBox.Text == String.Empty)
            {
                MessageBox.Show("Emergency Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Field Empty");
                return;
            }
            else if (employee.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (string.IsNullOrEmpty(presenTextBox.Text))
            {
                MessageBox.Show("Presentation Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(permanentTextBox.Text))
            {
                MessageBox.Show("Permanent Address Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Email Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(fatherNameTextBox.Text))
            {
                MessageBox.Show("Father Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(motherTextBox.Text))
            {
                MessageBox.Show("Mother Name Field Empty");
                return;
            }
            else if (string.IsNullOrEmpty(nidTextBox.Text))
            {
                MessageBox.Show("NID Field Empty");
                return;
            }


            
            var row = employeeManager.UpdatedEmployee(employee);
            if (row)
            {
                MessageBox.Show("Employee Updated Success");
                GetEmployeeValue();
            }
            else
            {
                MessageBox.Show("Employee Updated Failed");
            }
        }

        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void emergencyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void nidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idLabel.Text            = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nameTextBox.Text        = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            codeTextBox.Text        = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            contactTextBox.Text     = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            emailTextBox.Text       = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            joiningDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            emergencyTextBox.Text   = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            fatherNameTextBox.Text  = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            motherTextBox.Text      = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            nidTextBox.Text         = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            presenTextBox.Text      = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            permanentTextBox.Text   = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

            byte[] imageData =(byte[])dataGridView1.SelectedRows[0].Cells[12].Value;
            MemoryStream ms = new MemoryStream(imageData);
            employeePictureBox.Image = Image.FromStream(ms);

            outlateComboBox.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();


        }
    }
}
