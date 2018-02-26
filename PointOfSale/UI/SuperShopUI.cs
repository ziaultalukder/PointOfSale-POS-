using PointOfSale.Models;
using PointOfSale.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.UI;


namespace PointOfSale.UI
{
    public partial class SuperShopUI : Form
    {
        public SuperShopUI()
        {
            InitializeComponent();
            timer1.Start();
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
            lblDateToday.Text = DateTime.Now.ToLongDateString();
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

        private void btnExpenseCategorySetup_Click(object sender, EventArgs e)
        {
            ExpenseCategorySetupUI expenseCategorySetup = new ExpenseCategorySetupUI();
            expenseCategorySetup.Show();
        }

        private void btnExpenseItemSetup_Click(object sender, EventArgs e)
        {
            ExpenseItemSetupUI setupExpenseItem = new ExpenseItemSetupUI();
            setupExpenseItem.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnExpenseOperations_Click(object sender, EventArgs e)
        {
            //ExpenseOpUI expenseOperation = new ExpenseOpUI();
            //expenseOperation.Show();
            ExpenceUI exp = new ExpenceUI();
            exp.Show();
        }

        private void btnSalesOperations_Click(object sender, EventArgs e)
        {
            SalesUI salesOperation = new SalesUI();
            salesOperation.Show();
        }

        private void btnPurchaseOperations_Click(object sender, EventArgs e)
        {
            PurchaseUI purchase = new PurchaseUI();
            purchase.Show();
        }

        private void btnPurchaseResult_Click(object sender, EventArgs e)
        {
            PurchaseResultUI purchaseOperation = new PurchaseResultUI();
            purchaseOperation.Show();
        }

        private void btnPurchaseReport_Click(object sender, EventArgs e)
        {

        }

        private void btnExpenseReport_Click(object sender, EventArgs e)
        {
            ExpenceReportUI expnUI = new ExpenceReportUI();
            expnUI.Show();
        }

        private void btnIncomeReport_Click(object sender, EventArgs e)
        {

        }

        private void btnStopckReport_Click(object sender, EventArgs e)
        {

        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {

        }
    }
}
