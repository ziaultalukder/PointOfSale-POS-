using PointOfSale.UI;
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
    public partial class LogInUI : Form
    {
        public LogInUI()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == null)
            {
                MessageBox.Show("Please Fill Up User Name");
            }
            if (txtPassword.Text == null)
            {
                MessageBox.Show("Please Fill Up Password");
            }
            else
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                if (userName == "BKIICT" && password == "admin")
                {
                    SuperShopDashboardUI posManagementSystem = new SuperShopDashboardUI();
                    posManagementSystem.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password");
                }

            }
        }
    }
}
