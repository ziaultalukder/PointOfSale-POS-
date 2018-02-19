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
using PointOfSale.Models;

namespace PointOfSale.UI
{
    public partial class ExpenceUI : Form
    {
        public ExpenceUI()
        {
            InitializeComponent();
        }
        private void ExpenceUI_Load(object sender, EventArgs e)
        {
            ExpenceDataGridView.AutoGenerateColumns = false;

            SuperShopDatabaseContext db = new SuperShopDatabaseContext();

            ExpenceitemComboBox.DataSource = db.ItemSetups.ToList();
            ExpenceitemComboBox.DisplayMember = "Name";
            ExpenceitemComboBox.ValueMember = "Id";
            ExpenceitemComboBox.SelectedIndex = -1;


            outletcomboBox.DataSource = db.Outlates.ToList();
            outletcomboBox.DisplayMember = "Name";
            outletcomboBox.ValueMember = "Id";
            outletcomboBox.SelectedIndex = -1;


            employeecomboBox.DataSource = db.Employee.ToList();
            employeecomboBox.DisplayMember = "Name";
            employeecomboBox.ValueMember = "Id";
            employeecomboBox.SelectedIndex = -1;
        }
        private void purchaseDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.ExpenceDataGridView.Rows[e.RowIndex].Cells["sl"].Value = (e.RowIndex+1).ToString();
        }
        

        List<ExpenceItems> ExpenceItmList = new List<ExpenceItems>();
        private void addButton_Click(object sender, EventArgs e)
        {
            ExpenceItems expItm = new ExpenceItems();
            expItm.ItemName = ExpenceitemComboBox.Text;
            expItm.Remarks  = remarksTextBox.Text;
            expItm.Quantity = Convert.ToDecimal(qtyTextBox.Text);
            expItm.Price = Convert.ToDecimal(priceTextBox.Text);
            expItm.LineTotal = (Convert.ToDecimal(qtyTextBox.Text)* Convert.ToDecimal(priceTextBox.Text));

            ExpenceItmList.Add(expItm);
            ExpenceDataGridView.DataSource = null;
            ExpenceDataGridView.DataSource = ExpenceItmList;

            totalTextBox.Text = TotalAmount().ToString();
            totalAmmountTextBox.Text = TotalAmount().ToString();
        }
        private decimal TotalAmount()
        {
            decimal sum = 0;
            for (int i = 0; i < ExpenceDataGridView.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(ExpenceDataGridView.Rows[i].Cells[5].Value);
            }
            return sum;
        }
        List<Expence> ExpenceList = new List<Expence>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Expence expence = new Expence();
            expence.TotalAmmount = Convert.ToDecimal(totalAmmountTextBox.Text);
            expence.Due = Convert.ToDecimal(dueTextBox.Text);
            expence.Date = dateTimePicker.Value;
            expence.ExpenceList = ExpenceItmList;


            expence.OutletId = (int)outletcomboBox.SelectedIndex;
            expence.EmployeeId = (int)employeecomboBox.SelectedIndex;
            expence.ItemId = (int)ExpenceitemComboBox.SelectedIndex;

            ExpenceList.Add(expence);

            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Expences.AddRange(ExpenceList);
            db.SaveChanges();
        }
        private int outletId;
        private void outletcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool result = int.TryParse(outletcomboBox.SelectedIndex.ToString(), out outletId);
        }
        private int employeeId;
        private void employeecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool result = int.TryParse(employeecomboBox.SelectedIndex.ToString(), out employeeId);
        }
    }
}
