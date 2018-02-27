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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PointOfSale.UI
{
    public partial class SalesUI : Form
    {
        public SalesUI()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            SuperShopDatabaseContext db = new SuperShopDatabaseContext();

            itemComboBox.DataSource = db.ItemSetups.ToList();
            itemComboBox.DisplayMember = "Name";
            itemComboBox.ValueMember = "Id";
            //itemComboBox.SelectedIndex = -1;

            outletComboBox.DataSource = db.Outlates.ToList();
            outletComboBox.DisplayMember = "Name";
            outletComboBox.ValueMember = "Id";
            //outletComboBox.SelectedIndex = -1;

            employeeComboBox.DataSource = db.Employee.ToList();
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
            //employeeComboBox.SelectedIndex = -1;

            SalesItemInfor();
        }
        private void SalesItemInfor()
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            var SalesInfo = (from sl in db.Sales
                             join outl in db.Outlates on sl.OutletId equals outl.Id
                             join empl in db.Employee on sl.EmployeeId equals empl.Id
                             join party in db.PartySetup on sl.CustomerId equals party.Id
                             select new
                             {
                                 SaleNo = sl.SalesNumber,
                                 Outlet = outl.Name,
                                 SaleDate = sl.SalesDate,
                                 SoldBy = empl.Name,
                                 CustomerName = party.Name,
                                 CustomerNumber = party.Contact,
                                 TotalPrice = sl.TotalAmount,
                                 SubTotal = sl.Subtotal,
                                 Discount = sl.Discount,
                                 Vat = sl.Vat,
                                 Id = sl.Id
                             }).ToArray().LastOrDefault();

            if (SalesInfo != null)
            {
                salesNumberLabel.Text = SalesInfo.SaleNo;
                outlateLabel.Text = SalesInfo.Outlet;
                salesDateLabel.Text = SalesInfo.SaleDate.ToString();
                soldByLabel.Text = SalesInfo.SoldBy;
                customerNameLabel.Text = SalesInfo.CustomerName;
                customerContactLabel.Text = SalesInfo.CustomerNumber;
                subTotalLabel.Text = SalesInfo.SubTotal.ToString();
                discountLabel.Text = SalesInfo.Discount.ToString();
                vatLlabel.Text = SalesInfo.Vat.ToString();
                grandTotalLabel.Text = SalesInfo.TotalPrice.ToString();
                //int sl = 0;
                var salesItem = db.SalesItem.Where(c => c.SalesId == SalesInfo.Id)
                    .Select (c=>new
                    {
                        //SL=sl+1,
                        ItemName = c.ItemName,
                        Quantity = c.Quantity,
                        Price = c.Price,
                        LineTotal = c.LineTotal

                    }).ToList();
                salesItmdataGridView.DataSource = salesItem;
            }
        }

        private decimal discount = 0;
        private decimal vat = 0;
        private decimal totalPrice = 0;

        private void GetTotalAmmount()
        {
            decimal subTotalWithoutDiscount = TotalAmount() - discount;
            decimal vatAmount = (subTotalWithoutDiscount * vat) / 100;
            totalPrice = subTotalWithoutDiscount + vatAmount;
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = discountTextBox.Text;
            if (text != null)
            {
                decimal n;
                decimal.TryParse(text, out n);
                discount = n;
            }
            
            GetTotalAmmount();
            totalTakaTextBox.Text = totalPrice.ToString();
        }

        private void vatTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = vatTextBox.Text;
            if (text != null)
            {
                decimal n;
                decimal.TryParse(text, out n);
                vat = n;
            }

            GetTotalAmmount();
            totalTakaTextBox.Text = totalPrice.ToString();
        }
        private void subTotaltextBox_TextChanged(object sender, EventArgs e)
        {
            totalTakaTextBox.Text = TotalAmount().ToString();
        }
        private decimal TotalAmount()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
            return sum;
        }

        //int ids;
        private void customerNumberTextBox_Leave(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            string number = customerNumberTextBox.Text;
            var objPartySetup = db.PartySetup.FirstOrDefault(c => c.Contact == number);
            customerNameTextBox.Text = objPartySetup != null ? objPartySetup.Name : "Customer Not Fount";
            int ids = objPartySetup != null ? objPartySetup.Id:0;

            //string id = objPartySetup != null ? objPartySetup.Id :"fds"
            idLabel.Text = ids.ToString();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["sl"].Value = (e.RowIndex + 1).ToString();
        }

        List<SalesItem> SalesItemList = new List<SalesItem>();
        private void addButton_Click(object sender, EventArgs e)
        {
            SalesItem salesItm = new SalesItem();
            salesItm.ItemName = itemComboBox.Text;
            salesItm.Quantity = Convert.ToDecimal(qtyTextBox.Text);
            salesItm.Price = Convert.ToDecimal(priceTextBox.Text);
            salesItm.LineTotal = (Convert.ToDecimal(qtyTextBox.Text)* Convert.ToDecimal(priceTextBox.Text));

            SalesItemList.Add(salesItm);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SalesItemList;


            idTextBox.Text = TotalAmount().ToString();
            subTotaltextBox.Text = TotalAmount().ToString();
        }

        List<Sales> SalesList = new List<Sales>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();

            Random r = new Random();

            //Employee empl = new Employee();
            
            //empl.Name = customerNameTextBox.Text;
            //empl.Contact = customerNumberTextBox.Text;
            //db.Employee.Add(empl);
            //db.SaveChanges();
            



            Sales sales = new Sales();

            sales.TotalAmount = Convert.ToDecimal(totalTakaTextBox.Text);
            sales.Due         = Convert.ToDecimal(dueTextBox.Text);
            sales.Discount    = Convert.ToDecimal(discountTextBox.Text);
            sales.Vat         = Convert.ToDecimal(vatTextBox.Text);
            sales.SalesDate   = dateTimePicker1.Value;
            sales.Subtotal    = Convert.ToDecimal(subTotaltextBox.Text);
            sales.SalesNumber = r.Next().ToString();
            sales.SalesItmLst = SalesItemList;
            sales.OutletId    = (int)outletComboBox.SelectedValue;
            sales.EmployeeId  = (int)employeeComboBox.SelectedValue;
            sales.CustomerId  = Convert.ToInt32(idLabel.Text);
            SalesList.Add(sales);
            db.Sales.AddRange(SalesList);
            int row = db.SaveChanges();
            if (row > 0)
            {
                MessageBox.Show("Sales Item Inserted");
                SalesItemInfor();
            }


            //SalesList.Add(sales);
            //db.Sales.AddRange(SalesList);
            //db.SaveChanges();
            //if (sales.CustomerId == Convert.ToInt32(idLabel.Text))
            //{
            //    //sales.CustomerId = 0;
            //    SalesList.Add(sales);
            //    db.Sales.AddRange(SalesList);
            //    db.SaveChanges();
            //}
            //else
            //{
            //    sales.CustomerId = Convert.ToInt32(idLabel.Text);
            //    SalesList.Add(sales);
            //    db.Sales.AddRange(SalesList);
            //    db.SaveChanges();
            //}

        }


        public void GetDatagridViewPDF(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(columns.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = filename;
            saveFileDialoge.DefaultExt = ".pdf";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(saveFileDialoge.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 60f, 50f, 40f, 40f);
                    PdfWriter.GetInstance(pdfDoc, fileStream);
                    pdfDoc.Open();

                    iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance("shop-icon.png");
                    
                    Logo.ScaleToFit(120f, 120f);
                    pdfDoc.Add(Logo);

                    Paragraph p1 = new Paragraph();
                    p1.Add("Address: Mirpur - 10, Dhaka - 1216 \n");
                    p1.Add("Phone : 01728-388751 \n");
                    p1.Add("Email : shop@mail.com \n");
                    p1.Add("\n");
                    pdfDoc.Add(p1);

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    fileStream.Close();
                }
            }

        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            GetDatagridViewPDF(salesItmdataGridView, "test");
        }

        
    }
}
