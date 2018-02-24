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
    public partial class ExpenceReportUI : Form
    {
        public ExpenceReportUI()
        {
            InitializeComponent();
        }

        private void ExpenceReport_Load(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            outletComboBox.DataSource = db.Outlates.ToList();
            outletComboBox.DisplayMember = "Name";
            outletComboBox.ValueMember = "Id";




            

            //var outId = db.Outlates.ToArray();
            //foreach (var id in outId)
            //{
            //    int d = id.Id;
            //}
            
        }

        private void outletComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int outId = (int)outletComboBox.SelectedValue;
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var code = db.Outlates.Find(outId).Code;
            expenceCodeTextBox.Text = code;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            //int sl = 1;
            int id = (int)outletComboBox.SelectedValue;
            //DateTime fromDate = fromDateTimePicker.Value.Date;
            //DateTime toDate = toDateTimePicker.Value.Date;
            //var expnReport = (from expn in db.Expences
            //                  join expnitm in db.ExpenceItems on expn.Id equals expnitm.ExpenceId
            //                  join outl in db.Outlates on expn.OutletId equals outl.Id
            //                  where expn.OutletId == id
            //                  where expn.ExpenceDate >= fromDateTimePicker.Value && expn.ExpenceDate <= toDateTimePicker.Value
            //                  select new
            //                  {
            //                      SL = sl+1,
            //                      ItemName = expnitm.ItemName,
            //                      Dates = expn.ExpenceDate,
            //                      OutLet = outl.Name,
            //                      Description = expnitm.Remarks,
            //                      TotalExpences = expn.TotalAmmount
            //                  }).ToList();
            //expnReportDataGridView.DataSource = expnReport;




            //DateTime fromDate = fromDateTimePicker.Value.Date;
            //DateTime toDate = toDateTimePicker.Value.Date;
            //var all = (from expences in db.Expences.Where(o => o.OutletId == id).AsEnumerable()
            //          .Where(c => c.ExpenceDate.Date >= fromDateTimePicker.Value && c.ExpenceDate <= toDateTimePicker.Value)
            //           //join outlate in db.Outlates on expences.OutletId equals outlate.Id
            //           //join expnitms in db.ExpenceItems on expences.Id equals expnitms.ExpenceId
            //           select new
            //           {
            //               //SL = sl + 1,
            //               //ItemName = expnitm.ItemName,
            //               Dates = expences.ExpenceDate,
            //               //OutLet = outlate.Name,
            //               //Description = expnitms.Remarks,
            //               TotalExpences = expences.TotalAmmount
            //           }).ToList();



            //var alldate = db.Expences.Where(c => c.OutletId == id).AsEnumerable()
            //    .Where(c => c.ExpenceDate.Date >= fromDateTimePicker.Value && c.ExpenceDate <= toDateTimePicker.Value).ToList();


            //string description = expnReport;

            int sl = 1;
            DateTime fromDate = fromDateTimePicker.Value.Date;
            DateTime toDate = toDateTimePicker.Value.Date;
            var dateCompare = db.Expences.Where(c => c.OutletId == id).AsEnumerable()
                .Where(c => c.ExpenceDate.Date >= fromDateTimePicker.Value && c.ExpenceDate <= toDateTimePicker.Value)

                .Select(c => new
                {
                    SLNo = sl++,
                    Date = c.ExpenceDate,
                    Total = c.TotalAmmount

                }).ToList();


            expnReportDataGridView.DataSource = dateCompare;
        }
    }
}
