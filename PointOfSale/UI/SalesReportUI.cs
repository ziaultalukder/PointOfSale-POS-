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

namespace PointOfSale.UI
{
    public partial class SalesReportUI : Form
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        public SalesReportUI()
        {
            InitializeComponent();
        }

        private void SalesReportUI_Load(object sender, EventArgs e)
        {
            cmbBoxOutlet.DataSource = db.Outlates.ToList();
            cmbBoxOutlet.DisplayMember = "Name";
            cmbBoxOutlet.ValueMember = "Id";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //int sl = 1;
            int id = (int)cmbBoxOutlet.SelectedValue;
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
            DateTime fromDate = this.fromDate.Value.Date;
            DateTime toDate = this.toDate.Value.Date;
            var dateCompare = db.Sales.Where(c => c.OutletId == id).AsEnumerable()
                .Where(c => c.SalesDate.Date >= fromDate && c.SalesDate <= toDate)

                .Select(c => new
                {
                    SLNo = sl++,
                    Date = c.SalesDate,
                    Total = c.TotalAmount

                }).ToList();


            dataGridViewSalesReport.DataSource = dateCompare;
            //int sl = 1;
            //DateTime fromDate = fromDate.Value.Date;
            //DateTime toDate = toDate.Value.Date;
            //var dateCompare = db.Sales.Where(c => c.OutletId == id).AsEnumerable()
            //    .Where(c => c.ExpenceDate.Date >= fromDate && c.ExpenceDate <= toDate)

            //    .Select(c => new
            //    {
            //        SLNo = sl++,
            //        Date = c.ExpenceDate,
            //        Total = c.TotalAmmount

            //    }).ToList();


            //dataGridViewSalesReport.DataSource = dateCompare;
        }
    }
}
