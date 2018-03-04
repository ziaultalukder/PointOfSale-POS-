using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using PointOfSale.DatabaseContext;

namespace PointOfSale.UI
{
    public partial class BarcodeUI : Form
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        ReportDocument reportDocument = new CrystalReportBarcode();
        public BarcodeUI()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var codes = db.ItemSetups.Where(c => c.Code == txtBoxItemCode.Text);
            reportDocument.SetDataSource(codes);
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void btnAllShow_Click(object sender, EventArgs e)
        {
            var allItems = db.ItemSetups.ToList();
            reportDocument.SetDataSource(allItems);
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void BarcodeUI_Load(object sender, EventArgs e)
        {
            reportDocument.Load(@"E:\New Project File C#\PointOfSale-POS-\PointOfSale\CrystalReportBarcode.rpt");
        }
    }
}
