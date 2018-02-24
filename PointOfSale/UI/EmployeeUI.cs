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
using System.Text.RegularExpressions;
using PointOfSale.DatabaseContext;
using PointOfSale.Manager;

namespace PointOfSale.UI
{
    public partial class EmployeeUI : Form
    {

        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        Models.Employee employee = new Models.Employee();
        private bool isUpadteMode = false;

        public EmployeeUI()
        {
            InitializeComponent();
            AutoCodeGenerate();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            outlateComboBox.DataSource = db.Outlates.ToList();
            outlateComboBox.DisplayMember = "Name";
            outlateComboBox.ValueMember = "Id";

            //GetEmployeeValue();
            LoadDataGridView();
            
            ClearAllForm();
        }

        private void GetEmployeeValue()
        {
            //SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            //dgvEmployees.DataSource = db.Employee.ToList();

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
            string photo = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Logo";
            ofd.Filter = "Logo File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photo = ofd.FileName;
                employeePictureBox.ImageLocation = photo;
            }
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Please Select Image";
            //openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            ofd.Multiselect = false;

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    this.employeePictureBox.ImageLocation = openFileDialog.FileName;
            //}
            FileStream fs = new FileStream(photo , FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            employee.Image = br.ReadBytes((int) fs.Length);
        }
        //private byte[] ConvertToFileByte(string iPath)
        //{
        //    //byte[] data = null;
        //    //FileInfo info = new FileInfo(iPath);
        //    //long numByte = info.Length;
        //    //FileStream fileStream = new FileStream(iPath, FileMode.Open, FileAccess.Read);
        //    //BinaryReader Br = new BinaryReader(fileStream);
        //    //data = Br.ReadBytes((int)numByte);
        //    //return data;
        //}

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!isUpadteMode)
            {
                TextBoxValue();
                bool isExistContact = db.Employee.Count(c => c.Contact == employee.Contact) > 0;
                bool isExistEmail = db.Employee.Count(x => x.Email == employee.Email) > 0;
                if (isExistContact)
                {
                    MessageBox.Show("Contact No Already Exits. Please another Contact No.");
                    return;
                }
                if (isExistEmail)
                {
                    MessageBox.Show("Email No Already Exist. Please another Email Address.");
                    return;
                }
                db.Employee.Add(employee);
                int rows = db.SaveChanges();
                if (rows>0)
                {
                    MessageBox.Show("Record Save Successfully.");
                }
                else
                {
                    MessageBox.Show("Record Save Failed.");
                }
            }
            if (isUpadteMode)
            {
                if (MessageBox.Show("Are You Sure to Update this Record","Information",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    TextBoxValue();
                    db.Employee.Attach(employee);
                    db.Entry( employee ).State = EntityState.Modified;
                    int rows = db.SaveChanges();
                    if (rows>0)
                    {
                        MessageBox.Show("Record Updated Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record Updated Failed.");
                    }
                }
            }
            LoadDataGridView();
            ClearAllForm();
           // Models.Employee employee = new Models.Employee();
            //employee.Name = nameTextBox.Text;
            //employee.Code = codeTextBox.Text;
            //employee.Contact = contactTextBox.Text;
            //employee.Email = emailTextBox.Text;
            //employee.JoinintDate = joiningDateTimePicker.Value;
            //employee.EmergencyNumber = emergencyTextBox.Text;
            //employee.FatherName = fatherNameTextBox.Text;
            //employee.MotherName = motherTextBox.Text;
            //employee.Nid = nidTextBox.Text;
            //employee.PresentAddress = presenTextBox.Text;
            //employee.PermanentAddress = permanentTextBox.Text;
            //employee.Image = ConvertToFileByte(this.employeePictureBox.ImageLocation);
            //employee.OutlateId = (int)outlateComboBox.SelectedValue;

            //EmployeeManager employeeManager = new EmployeeManager();



            //if (string.IsNullOrEmpty(outlateComboBox.Text))
            //{
            //    MessageBox.Show("Please Select an Outlate");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(nameTextBox.Text))
            //{
            //    MessageBox.Show("Name Field Empty");
            //    return;
            //}
            //else if (contactTextBox.Text == String.Empty)
            //{
            //    MessageBox.Show("Contact Field Empty");
            //    return;
            //}
            //else if (emergencyTextBox.Text == String.Empty)
            //{
            //    MessageBox.Show("Emergency Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(codeTextBox.Text))
            //{
            //    MessageBox.Show("Code Field Empty");
            //    return;
            //}
            //else if (employee.Code.Length <= 6)
            //{
            //    MessageBox.Show("Security Code Must Be 6 Disit");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(presenTextBox.Text))
            //{
            //    MessageBox.Show("Presentation Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(permanentTextBox.Text))
            //{
            //    MessageBox.Show("Permanent Address Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(emailTextBox.Text))
            //{
            //    MessageBox.Show("Email Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(fatherNameTextBox.Text))
            //{
            //    MessageBox.Show("Father Name Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(motherTextBox.Text))
            //{
            //    MessageBox.Show("Mother Name Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(nidTextBox.Text))
            //{
            //    MessageBox.Show("NID Field Empty");
            //    return;
            //}

            
            
            //var row = employeeManager.InsertEmployee(employee);
            //if (row)
            //{
            //    MessageBox.Show("Employee Inserted");
            //    GetEmployeeValue();
            //}
            //else
            //{
            //    MessageBox.Show("Employee Inserted Failed");
            //}
        }

        private void ClearAllForm()
        {
            nameTextBox.Clear();
            codeTextBox.Clear();
            outlateComboBox.SelectedIndex = -1;
            joiningDateTimePicker.ResetText();
            emailTextBox.Clear();
            txtBoxRefefence.Clear();
            emergencyTextBox.Clear();
            nidTextBox.Clear();
            fatherNameTextBox.Clear();
            motherTextBox.Clear();
            presenTextBox.Clear();
            permanentTextBox.Clear();
            employeePictureBox.Image = null;
            SetFormNewMode();
        }

        private void SetFormNewMode()
        {
            deleteButton.Visible = false;
            saveButton.Text = "Save";
            isUpadteMode = false;
        }

        private void LoadDataGridView()
        {
            var dgvShow = (from emplo in db.Employee
                join outlet in db.Outlates on emplo.OutlateId equals outlet.Id
                where emplo.Delete == false
                select new
                {
                    emplo.Id ,
                    OutlateName = outlet.Name ,
                    emplo.Name ,
                    emplo.Code ,
                    emplo.Contact ,
                    emplo.Email ,
                    emplo.Nid ,
                    emplo.Image ,
                    emplo.JoinintDate ,
                    emplo.FatherName ,
                    emplo.MotherName ,
                    emplo.PresentAddress ,
                    emplo.PermanentAddress 
                }).ToList();
            dgvEmployees.DataSource = dgvShow;
            var dataGridViewColumn = dgvEmployees.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            for (int i = 0; i < dgvEmployees.Columns.Count ; i++)
            {
                var column = dgvEmployees.Columns[i] as DataGridViewImageColumn;
                if (column == null) continue;
                column .ImageLayout = DataGridViewImageCellLayout.Stretch;
                break;
            }
            {
                
            }
        }

        private void TextBoxValue()
        {
            employee.Name = nameTextBox.Text;
            employee.OutlateId = (int) outlateComboBox.SelectedValue;
            employee.JoinintDate = joiningDateTimePicker.Value;
            employee.Contact = contactTextBox.Text;
            employee.Email = emailTextBox.Text;
            employee.Refarence = txtBoxRefefence.Text;
            employee.EmergencyNumber = emergencyTextBox.Text;
            employee.Nid = nidTextBox.Text;
            employee.FatherName = fatherNameTextBox.Text;
            employee.MotherName = motherTextBox.Text;
            employee.PresentAddress = presenTextBox.Text;
            employee.PermanentAddress = permanentTextBox.Text;
            employee.Image = employee.Image;
            employee.Code = codeTextBox.Text;
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

            ////Models.Employee employee = new Models.Employee();
            //employee.Id = Convert.ToInt32(idLabel.Text);
            //employee.Name = nameTextBox.Text;
            //employee.Code = codeTextBox.Text;
            //employee.Contact = contactTextBox.Text;
            //employee.Email = emailTextBox.Text;
            //employee.JoinintDate = joiningDateTimePicker.Value;
            //employee.EmergencyNumber = emergencyTextBox.Text;
            //employee.FatherName = fatherNameTextBox.Text;
            //employee.MotherName = motherTextBox.Text;
            //employee.Nid = nidTextBox.Text;
            //employee.PresentAddress = presenTextBox.Text;
            //employee.PermanentAddress = permanentTextBox.Text;
            //employee.Image = ConvertToFileByte(this.employeePictureBox.ImageLocation);
            //employee.OutlateId = (int)outlateComboBox.SelectedValue;

            //EmployeeManager employeeManager = new EmployeeManager();



            

            //if (string.IsNullOrEmpty(outlateComboBox.Text))
            //{
            //    MessageBox.Show("Please Select an Outlate");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(nameTextBox.Text))
            //{
            //    MessageBox.Show("Name Field Empty");
            //    return;
            //}
            //else if (contactTextBox.Text == String.Empty)
            //{
            //    MessageBox.Show("Contact Field Empty");
            //    return;
            //}
            //else if (emergencyTextBox.Text == String.Empty)
            //{
            //    MessageBox.Show("Emergency Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(codeTextBox.Text))
            //{
            //    MessageBox.Show("Code Field Empty");
            //    return;
            //}
            //else if (employee.Code.Length <= 6)
            //{
            //    MessageBox.Show("Security Code Must Be 6 Disit");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(presenTextBox.Text))
            //{
            //    MessageBox.Show("Presentation Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(permanentTextBox.Text))
            //{
            //    MessageBox.Show("Permanent Address Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(emailTextBox.Text))
            //{
            //    MessageBox.Show("Email Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(fatherNameTextBox.Text))
            //{
            //    MessageBox.Show("Father Name Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(motherTextBox.Text))
            //{
            //    MessageBox.Show("Mother Name Field Empty");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(nidTextBox.Text))
            //{
            //    MessageBox.Show("NID Field Empty");
            //    return;
            //}


            
            //var row = employeeManager.UpdatedEmployee(employee);
            //if (row)
            //{
            //    MessageBox.Show("Employee Updated Success");
            //    GetEmployeeValue();
            //}
            //else
            //{
            //    MessageBox.Show("Employee Updated Failed");
            //}
        }

        //private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void emergencyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void nidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{

        //}

        //private void deleteButton_Click(object sender, EventArgs e)
        //{

        //}

        private void AutoCodeGenerate()
        {
            int counts = 1;
            counts = db.Employee.Include(c => c.Id).Count() + counts;
            codeTextBox.Text = 1000 + counts.ToString();
        }

        private void dgvEmployees_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow !=null)
            {
                int dgvIndex = (int) dgvEmployees.CurrentRow.Cells["Id"].Value;
                var dgvObj = db.Employee.FirstOrDefault(c => c.Id == dgvIndex);
                employee = dgvObj;
            }
            if (employee !=null)
            {
                nameTextBox.Text = employee.Name;
                outlateComboBox.SelectedValue = employee.OutlateId;
                joiningDateTimePicker.Value = employee.JoinintDate;
                codeTextBox.Text = employee.Code;
                contactTextBox.Text = employee.Contact;
                emailTextBox.Text = employee.Email;
                txtBoxRefefence.Text = employee.Refarence;
                emergencyTextBox.Text = employee.EmergencyNumber;
                nidTextBox.Text = employee.Nid;
                fatherNameTextBox.Text = employee.FatherName;
                motherTextBox.Text = employee.MotherName;
                presenTextBox.Text = employee.PresentAddress;
                permanentTextBox.Text = employee.PermanentAddress;
                if (employee.Image !=null)
                {
                    byte [] data = employee.Image;
                    MemoryStream ms = new MemoryStream(data );
                    employeePictureBox.Image = Image.FromStream(ms);
                }
                else
                {
                    employeePictureBox.Image = null;
                }
            }
            SetFormUpdateMode();
        }

        private void SetFormUpdateMode()
        {
            deleteButton.Visible = true;
            saveButton.Text = "Update";
            isUpadteMode = true;
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string txtSearchByName = txtBoxSearch.Text;
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var emplo = (from emp in db.Employee
                where emp.Name.StartsWith(txtSearchByName)
                select new
                {
                    emp.Id,
                    OutletName = emp.Name,
                    emp.Name,
                    emp.Code,
                    emp.Contact,
                    emp.Email,
                    emp.Nid,
                    emp.Image,
                    emp.JoinintDate,
                    emp.FatherName,
                    emp.MotherName,
                    emp.PresentAddress,
                    emp.PermanentAddress
                }).ToList();
            dgvEmployees.DataSource = emplo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
