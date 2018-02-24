using PointOfSale.DatabaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI
{
    public partial class ExpenseOpUI : Form
    {
        public ExpenseOpUI()
        {
            InitializeComponent();
            GetcmbExpenseItem();
            GetcmbOrganization();
            GetcmbOutlet();
            GetcmbEmployee();
        }

        private void GetcmbEmployee()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            cmbEmployee.DataSource = db.Employee.ToList();
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.SelectedIndex = -1;
        }

        private void GetcmbOutlet()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            cmbOutlet.DataSource = db.Outlates.ToList();
            cmbOutlet.DisplayMember = "Name";
            cmbOutlet.ValueMember = "Id";
            cmbOutlet.SelectedIndex = -1;
        }

        private void GetcmbOrganization()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            cmbOrganization.DataSource = db.Organaization.ToList();
            cmbOrganization.DisplayMember = "Name";
            cmbOrganization.ValueMember = "Id";
            cmbOrganization.SelectedIndex = -1;
        }

        private void GetcmbExpenseItem()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            cmbExpenseItem.DataSource = db.ExpenseItem.ToList();
            cmbExpenseItem.DisplayMember = "Name";
            cmbExpenseItem.ValueMember = "Id";
            cmbExpenseItem.SelectedIndex = -1;
        }
    }
}
