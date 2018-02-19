using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.DatabaseContext;
using PointOfSale.Manager;

namespace PointOfSale.UI
{
    public partial class Outlate : Form
    {
        public Outlate()
        {
            InitializeComponent();
        }
        
        private void Outlate_Load(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            outlateComboBox.DataSource = db.Organaization.ToList();
            outlateComboBox.DisplayMember = "Name";
            outlateComboBox.ValueMember = "Id";

            GetOutlateValue();
        }

        private void GetOutlateValue()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            //outlateDataGridView.DataSource = db.Outlates.ToList();

            var outlates = (from Ol in db.Outlates
                            join org in db.Organaization on Ol.OrganaizationId equals org.Id
                            select new
                            {
                                SL = Ol.Id,
                                Ol.Name,
                                Ol.Code,
                                Ol.Contact,
                                Ol.Address,
                                Organaization = org.Name,

                            }).ToList();
            outlateDataGridView.DataSource = outlates;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            Models.Outlate outlate = new Models.Outlate();
            outlate.Name = nameTextBox.Text;
            outlate.Code = r.Next().ToString();
            outlate.Contact = contactTextBox.Text;
            outlate.Address = addressTextBox.Text;
            outlate.OrganaizationId = (int)outlateComboBox.SelectedValue;

            OutlateManager outlateManager = new OutlateManager();


            if(string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Field Emplty");
                return;
            }
            //else if (string.IsNullOrEmpty(codeTextBox.Text))
            //{
            //    MessageBox.Show("Code Field Emplty");
            //    return;
            //}
            //else if (outlate.Code.Length <= 6)
            //{
            //    MessageBox.Show("Security Code Must Be 6 Disit");
            //    return;
            //}
            else if (string.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("Contact Field Emplty");
                return;
            }
            else if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Address Field Emplty");
                return;
            }
            
            var row = outlateManager.Insertoutlate(outlate);
            if (row)
            {
                MessageBox.Show("Outlate Inserted");
                GetOutlateValue();
            }
            else
            {
                MessageBox.Show("Outlate Inserted Failed");
            }
        }

        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        
        private void updateButton_Click(object sender, EventArgs e)
        {
            Models.Outlate outlate = new Models.Outlate();
            outlate.Id = Convert.ToInt32(idLabel.Text);
            outlate.Name = nameTextBox.Text;
            outlate.Code = codeTextBox.Text;
            outlate.Contact = contactTextBox.Text;
            outlate.Address = addressTextBox.Text;
            outlate.OrganaizationId = (int)outlateComboBox.SelectedValue;

            OutlateManager outlateManager = new OutlateManager();


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
            else if (outlate.Code.Length <= 6)
            {
                MessageBox.Show("Security Code Must Be 6 Disit");
                return;
            }
            else if (string.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("Contact Field Emplty");
                return;
            }
            else if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Address Field Emplty");
                return;
            }

            var row = outlateManager.Updateoutlate(outlate);
            if (row)
            {
                MessageBox.Show("Outlate Updated");
                GetOutlateValue();
            }
            else
            {
                MessageBox.Show("Outlate Updated Failed");
            }
        }

        private void outlateDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idLabel.Text = outlateDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            nameTextBox.Text = outlateDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            codeTextBox.Text = outlateDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            contactTextBox.Text = outlateDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            addressTextBox.Text = outlateDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            outlateComboBox.Text = outlateDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchItem = searchTextBox.Text;
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var data = (from ol in db.Outlates where ol.Name.Contains(searchItem) select ol).ToList();
           outlateDataGridView.DataSource = data;
        }
    }
}
