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
    public partial class PurchaseReportUI : Form
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        public PurchaseReportUI()
        {
            InitializeComponent();
        }

        private void PurchaseReportUI_Load(object sender, EventArgs e)
        {
            cmbBoxOutletName.DataSource = db.Outlates.ToList();
            cmbBoxOutletName.DisplayMember = "Name";
            cmbBoxOutletName.ValueMember = "Id";
        }
    }
}
