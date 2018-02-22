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
    public partial class POSManagementSystem : Form
    {
        public POSManagementSystem()
        {
            InitializeComponent();
        }

        private void btnExpenseCategorySetup_Click(object sender, EventArgs e)
        {
            FrmExpenseCategorySetup expenseCategorySetup = new FrmExpenseCategorySetup();
            expenseCategorySetup.Show();
        }

        private void btnPartySetup_Click(object sender, EventArgs e)
        {
            PartySetup partySetup = new PartySetup();
            partySetup.Show();
        }

        private void btnItemCategorySetup_Click(object sender, EventArgs e)
        {
            SetupItemCatagory setupItemCatagory = new SetupItemCatagory();
            setupItemCatagory.Show();
        }

        private void btnItemSetup_Click(object sender, EventArgs e)
        {
            ItemSetup itemSetup = new ItemSetup();
            itemSetup.Show();
        }

        private void btnOrganizationSetup_Click(object sender, EventArgs e)
        {
            Organaization organaization = new Organaization();
            organaization.Show();
        }

        private void btnOutletSetup_Click(object sender, EventArgs e)
        {
            Outlate outlate = new Outlate();
            outlate.Show();
        }

        private void btnEmployeeSetup_Click(object sender, EventArgs e)
        {
            EmployeeUI employee = new EmployeeUI();
            employee.Show();
        }

        private void btnExpenseItemSetup_Click(object sender, EventArgs e)
        {
            FrmSetupExpenseItem frmSetupExpenseItem = new FrmSetupExpenseItem();
            frmSetupExpenseItem.Show();
        }

        private void btnSalesOperations_Click(object sender, EventArgs e)
        {
            SalesUI sales = new SalesUI();
            sales.Show();
        }

        private void btnExpenseOperations_Click(object sender, EventArgs e)
        {
            ExpenceUI exp = new ExpenceUI();
            exp.Show();
        }

        private void btnPurchaseOperations_Click(object sender, EventArgs e)
        {
            PurchaseUI purchase = new PurchaseUI();
            purchase.Show();
        }

        private void btnPurchaseResult_Click(object sender, EventArgs e)
        {
            PurchaseResultUI purchaseResult = new PurchaseResultUI();
            purchaseResult.Show();
        }

        private void btnExpenseReport_Click(object sender, EventArgs e)
        {
            ExpenceReportUI expnUI = new ExpenceReportUI();
            expnUI.Show();
        }
    }
}
