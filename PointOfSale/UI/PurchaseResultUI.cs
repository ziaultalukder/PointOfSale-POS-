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


        public void GetDatagridViewPDF(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf,14,iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(columns.HeaderText,text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase ( cell.Value.ToString(), text));
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = filename;
            saveFileDialoge.DefaultExt = ".pdf";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(saveFileDialoge.FileName,FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 60f, 50f, 40f, 40f);
                    PdfWriter.GetInstance(pdfDoc, fileStream);
                    pdfDoc.Open();

                    iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance("shop-icon.png");
                    //Logo.ScalePercent(50f);
                    //Logo.SetAbsolutePosition(pdfDoc.PageSize.Width -36f -150f, pdfDoc.PageSize.Height -36f -216.6f);

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

        private void pdfbutton_Click(object sender, EventArgs e)
        {

           GetDatagridViewPDF(pruchaseresultDataGridView,"test");
        }
        private void purchaseResultPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.pruchaseresultDataGridView.Width, this.pruchaseresultDataGridView.Height);
            pruchaseresultDataGridView.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, this.pruchaseresultDataGridView.Width, this.pruchaseresultDataGridView.Height));
            e.Graphics.DrawImage(bitmap, 50, 150);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = purchaseResultPrintDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void barcodeButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
