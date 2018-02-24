namespace PointOfSale.UI
{
    partial class ExpenceReportUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.outletComboBox = new System.Windows.Forms.ComboBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expenceCodeTextBox = new System.Windows.Forms.TextBox();
            this.expnReportDataGridView = new System.Windows.Forms.DataGridView();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.printButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.expnReportDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outlet :";
            // 
            // outletComboBox
            // 
            this.outletComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.outletComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.outletComboBox.FormattingEnabled = true;
            this.outletComboBox.Location = new System.Drawing.Point(156, 47);
            this.outletComboBox.Name = "outletComboBox";
            this.outletComboBox.Size = new System.Drawing.Size(233, 29);
            this.outletComboBox.TabIndex = 1;
            this.outletComboBox.SelectionChangeCommitted += new System.EventHandler(this.outletComboBox_SelectionChangeCommitted);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(560, 37);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(293, 27);
            this.fromDateTimePicker.TabIndex = 2;
            // 
            // expenceCodeTextBox
            // 
            this.expenceCodeTextBox.Location = new System.Drawing.Point(156, 104);
            this.expenceCodeTextBox.Name = "expenceCodeTextBox";
            this.expenceCodeTextBox.ReadOnly = true;
            this.expenceCodeTextBox.Size = new System.Drawing.Size(233, 27);
            this.expenceCodeTextBox.TabIndex = 3;
            // 
            // expnReportDataGridView
            // 
            this.expnReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expnReportDataGridView.Location = new System.Drawing.Point(26, 243);
            this.expnReportDataGridView.Name = "expnReportDataGridView";
            this.expnReportDataGridView.Size = new System.Drawing.Size(868, 488);
            this.expnReportDataGridView.TabIndex = 4;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(812, 198);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(82, 32);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expenceCodeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.outletComboBox);
            this.groupBox1.Controls.Add(this.toDateTimePicker);
            this.groupBox1.Controls.Add(this.fromDateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expence Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Expence Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "To Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "From Date :";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(560, 103);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(293, 27);
            this.toDateTimePicker.TabIndex = 2;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(812, 747);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(82, 32);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // ExpenceReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 791);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.expnReportDataGridView);
            this.Name = "ExpenceReportUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpenceReport";
            this.Load += new System.EventHandler(this.ExpenceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expnReportDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox outletComboBox;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.TextBox expenceCodeTextBox;
        private System.Windows.Forms.DataGridView expnReportDataGridView;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button printButton;
    }
}