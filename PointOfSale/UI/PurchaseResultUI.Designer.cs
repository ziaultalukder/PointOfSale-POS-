namespace PointOfSale.UI
{
    partial class PurchaseResultUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseResultUI));
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.purchaseSerialNumberLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.outletLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pruchaseresultDataGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.pdfbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.purchaseResultPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruchaseresultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remarksTextBox.Location = new System.Drawing.Point(503, 118);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.ReadOnly = true;
            this.remarksTextBox.Size = new System.Drawing.Size(242, 65);
            this.remarksTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase Number :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.remarksTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.purchaseSerialNumberLabel);
            this.groupBox1.Controls.Add(this.employeeLabel);
            this.groupBox1.Controls.Add(this.supplierLabel);
            this.groupBox1.Controls.Add(this.outletLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Remarks :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Suplier :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Suplier :";
            // 
            // purchaseSerialNumberLabel
            // 
            this.purchaseSerialNumberLabel.AutoSize = true;
            this.purchaseSerialNumberLabel.Location = new System.Drawing.Point(178, 33);
            this.purchaseSerialNumberLabel.Name = "purchaseSerialNumberLabel";
            this.purchaseSerialNumberLabel.Size = new System.Drawing.Size(197, 21);
            this.purchaseSerialNumberLabel.TabIndex = 1;
            this.purchaseSerialNumberLabel.Text = "Serial Number / Bercode";
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(499, 71);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(58, 21);
            this.employeeLabel.TabIndex = 1;
            this.employeeLabel.Text = "Name";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(178, 121);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(58, 21);
            this.supplierLabel.TabIndex = 1;
            this.supplierLabel.Text = "Name";
            // 
            // outletLabel
            // 
            this.outletLabel.AutoSize = true;
            this.outletLabel.Location = new System.Drawing.Point(499, 33);
            this.outletLabel.Name = "outletLabel";
            this.outletLabel.Size = new System.Drawing.Size(50, 21);
            this.outletLabel.TabIndex = 1;
            this.outletLabel.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Outlet :";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(178, 77);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 21);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Purchase Date :";
            // 
            // pruchaseresultDataGridView
            // 
            this.pruchaseresultDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.pruchaseresultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pruchaseresultDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.pruchaseresultDataGridView.Location = new System.Drawing.Point(121, 362);
            this.pruchaseresultDataGridView.Name = "pruchaseresultDataGridView";
            this.pruchaseresultDataGridView.Size = new System.Drawing.Size(576, 382);
            this.pruchaseresultDataGridView.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(117, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Item Details";
            // 
            // pdfbutton
            // 
            this.pdfbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfbutton.Location = new System.Drawing.Point(622, 333);
            this.pdfbutton.Name = "pdfbutton";
            this.pdfbutton.Size = new System.Drawing.Size(75, 23);
            this.pdfbutton.TabIndex = 4;
            this.pdfbutton.Text = "PDF";
            this.pdfbutton.UseVisualStyleBackColor = true;
            this.pdfbutton.Click += new System.EventHandler(this.pdfbutton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(541, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // purchaseResultPrintDocument
            // 
            this.purchaseResultPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.purchaseResultPrintDocument_PrintPage);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Print Tutoral";
            // 
            // barcodeButton
            // 
            this.barcodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeButton.Location = new System.Drawing.Point(460, 333);
            this.barcodeButton.Name = "barcodeButton";
            this.barcodeButton.Size = new System.Drawing.Size(75, 23);
            this.barcodeButton.TabIndex = 4;
            this.barcodeButton.Text = "Barcode";
            this.barcodeButton.UseVisualStyleBackColor = true;
            this.barcodeButton.Click += new System.EventHandler(this.barcodeButton_Click);
            // 
            // PurchaseResultUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 756);
            this.Controls.Add(this.barcodeButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pdfbutton);
            this.Controls.Add(this.pruchaseresultDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Name = "PurchaseResultUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseResultUI";
            this.Load += new System.EventHandler(this.PurchaseResultUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruchaseresultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label purchaseSerialNumberLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label outletLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView pruchaseresultDataGridView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button pdfbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument purchaseResultPrintDocument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button barcodeButton;
    }
}