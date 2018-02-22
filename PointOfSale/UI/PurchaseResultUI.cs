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
    public partial class PurchaseResultUI : Form
    {
        public PurchaseResultUI()
        {
            InitializeComponent();
        }

        private void PurchaseResultUI_Load(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var purchreslt = (from purc in db.Purchases
                              join empl in db.Employee on purc.EmployeeId equals empl.Id
                              join ote in db.Outlates on purc.OutletId equals ote.Id
                              join supllir in db.PartySetup on purc.PartyTypeId equals supllir.Id
                              select new
                              {
                                  id = purc.Id,
                                  Number = purc.SalesNumber,
                                  date = purc.PurchaseDate,
                                  remarks = purc.Remarks,
                                  outlate = ote.Name,
                                  employe = empl.Name,
                                  supploer = supllir.Name

                              }).ToArray().LastOrDefault();

            int id = purchreslt.id;
            purchaseSerialNumberLabel.Text = purchreslt.Number;
            dateLabel.Text = purchreslt.date.ToString();
            remarksTextBox.Text = purchreslt.remarks;
            employeeLabel.Text = purchreslt.employe;
            outletLabel.Text = purchreslt.outlate;
            supplierLabel.Text = purchreslt.supploer;


            int sl = 0;
            var purchaseItms = db.PurchaseItems.Where(c => c.PurchaseId == id).Select(c=>new {SLNo=sl+1, ItemName = c.ItemName, Quantity = c.Quantity, Price=c.Price, LineTotal=c.LineTotal}) .ToList();
            pruchaseresultDataGridView.DataSource = purchaseItms;

        }
    }
}
