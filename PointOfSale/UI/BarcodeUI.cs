using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            string varCode = txtBoxItemCode.Text;
            string varQty = txtBoxNumberOfCopy.Text;
            //var data = (from ol in db.Outlates where ol.Name.Contains(searchItem) select ol).ToList();

            //var codes = db.ItemSetups.Where(c => c.Code == searchItem);
            var data = (from co in db.ItemSetups where co.Code.Contains(varCode) select co).ToList();
            //for (int i = 1; i < int.Parse(varQty); i++)
            //{
            //    //data = data + "(from co in db.ItemSetups where co.Code.Contains(varCode) select co).ToList()";
            //    //var numberofQty = data + data;
            //}
            reportDocument.SetDataSource(data);
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
