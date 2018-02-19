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

            var maxId = db.Purchases;
        }
    }
}
