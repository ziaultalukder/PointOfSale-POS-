namespace PointOfSale.UI
{
    partial class SuperShopDashboardUI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPartySetup = new System.Windows.Forms.Button();
            this.btnOutletSetup = new System.Windows.Forms.Button();
            this.btnItemSetup = new System.Windows.Forms.Button();
            this.btnItemCategorySetup = new System.Windows.Forms.Button();
            this.btnOrganizationSetup = new System.Windows.Forms.Button();
            this.btnExpenseCategorySetup = new System.Windows.Forms.Button();
            this.btnExpenseItemSetup = new System.Windows.Forms.Button();
            this.btnEmployeeSetup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExpenseOperations = new System.Windows.Forms.Button();
            this.btnSalesOperations = new System.Windows.Forms.Button();
            this.btnPurchaseOperations = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnStopckReport = new System.Windows.Forms.Button();
            this.btnIncomeReport = new System.Windows.Forms.Button();
            this.btnPurchaseReport = new System.Windows.Forms.Button();
            this.btnExpenseReport = new System.Windows.Forms.Button();
            this.btnPurchaseResult = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblDateToday = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Kozuka Gothic Pro EL", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(215, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(906, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Supper Shop Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(675, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 22);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(854, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnPartySetup);
            this.groupBox1.Controls.Add(this.btnOutletSetup);
            this.groupBox1.Controls.Add(this.btnItemSetup);
            this.groupBox1.Controls.Add(this.btnItemCategorySetup);
            this.groupBox1.Controls.Add(this.btnOrganizationSetup);
            this.groupBox1.Controls.Add(this.btnExpenseCategorySetup);
            this.groupBox1.Controls.Add(this.btnExpenseItemSetup);
            this.groupBox1.Controls.Add(this.btnEmployeeSetup);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(314, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Setup Item";
            // 
            // btnPartySetup
            // 
            this.btnPartySetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPartySetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartySetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPartySetup.Location = new System.Drawing.Point(197, 93);
            this.btnPartySetup.Name = "btnPartySetup";
            this.btnPartySetup.Size = new System.Drawing.Size(175, 39);
            this.btnPartySetup.TabIndex = 0;
            this.btnPartySetup.Text = "Party/Suplier Setup";
            this.btnPartySetup.UseVisualStyleBackColor = false;
            this.btnPartySetup.Click += new System.EventHandler(this.btnPartySetup_Click);
            // 
            // btnOutletSetup
            // 
            this.btnOutletSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOutletSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutletSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOutletSetup.Location = new System.Drawing.Point(9, 93);
            this.btnOutletSetup.Name = "btnOutletSetup";
            this.btnOutletSetup.Size = new System.Drawing.Size(173, 39);
            this.btnOutletSetup.TabIndex = 0;
            this.btnOutletSetup.Text = "Outlet/Branch Setup";
            this.btnOutletSetup.UseVisualStyleBackColor = false;
            this.btnOutletSetup.Click += new System.EventHandler(this.btnOutletSetup_Click);
            // 
            // btnItemSetup
            // 
            this.btnItemSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnItemSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnItemSetup.Location = new System.Drawing.Point(602, 93);
            this.btnItemSetup.Name = "btnItemSetup";
            this.btnItemSetup.Size = new System.Drawing.Size(168, 39);
            this.btnItemSetup.TabIndex = 0;
            this.btnItemSetup.Text = "Item Setup";
            this.btnItemSetup.UseVisualStyleBackColor = false;
            this.btnItemSetup.Click += new System.EventHandler(this.btnItemSetup_Click);
            // 
            // btnItemCategorySetup
            // 
            this.btnItemCategorySetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnItemCategorySetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemCategorySetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnItemCategorySetup.Location = new System.Drawing.Point(602, 26);
            this.btnItemCategorySetup.Name = "btnItemCategorySetup";
            this.btnItemCategorySetup.Size = new System.Drawing.Size(168, 39);
            this.btnItemCategorySetup.TabIndex = 0;
            this.btnItemCategorySetup.Text = "Item Category Setup";
            this.btnItemCategorySetup.UseVisualStyleBackColor = false;
            this.btnItemCategorySetup.Click += new System.EventHandler(this.btnItemCategorySetup_Click);
            // 
            // btnOrganizationSetup
            // 
            this.btnOrganizationSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOrganizationSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizationSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOrganizationSetup.Location = new System.Drawing.Point(9, 26);
            this.btnOrganizationSetup.Name = "btnOrganizationSetup";
            this.btnOrganizationSetup.Size = new System.Drawing.Size(173, 39);
            this.btnOrganizationSetup.TabIndex = 0;
            this.btnOrganizationSetup.Text = "Organization Setup";
            this.btnOrganizationSetup.UseVisualStyleBackColor = false;
            this.btnOrganizationSetup.Click += new System.EventHandler(this.btnOrganizationSetup_Click);
            // 
            // btnExpenseCategorySetup
            // 
            this.btnExpenseCategorySetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExpenseCategorySetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseCategorySetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExpenseCategorySetup.Location = new System.Drawing.Point(393, 26);
            this.btnExpenseCategorySetup.Name = "btnExpenseCategorySetup";
            this.btnExpenseCategorySetup.Size = new System.Drawing.Size(203, 39);
            this.btnExpenseCategorySetup.TabIndex = 0;
            this.btnExpenseCategorySetup.Text = "Expense Category Setup";
            this.btnExpenseCategorySetup.UseVisualStyleBackColor = false;
            this.btnExpenseCategorySetup.Click += new System.EventHandler(this.btnExpenseCategorySetup_Click);
            // 
            // btnExpenseItemSetup
            // 
            this.btnExpenseItemSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExpenseItemSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseItemSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExpenseItemSetup.Location = new System.Drawing.Point(393, 93);
            this.btnExpenseItemSetup.Name = "btnExpenseItemSetup";
            this.btnExpenseItemSetup.Size = new System.Drawing.Size(203, 39);
            this.btnExpenseItemSetup.TabIndex = 0;
            this.btnExpenseItemSetup.Text = "Expense Item Setup";
            this.btnExpenseItemSetup.UseVisualStyleBackColor = false;
            this.btnExpenseItemSetup.Click += new System.EventHandler(this.btnExpenseItemSetup_Click);
            // 
            // btnEmployeeSetup
            // 
            this.btnEmployeeSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEmployeeSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEmployeeSetup.Location = new System.Drawing.Point(197, 26);
            this.btnEmployeeSetup.Name = "btnEmployeeSetup";
            this.btnEmployeeSetup.Size = new System.Drawing.Size(175, 39);
            this.btnEmployeeSetup.TabIndex = 0;
            this.btnEmployeeSetup.Text = "Employee Setup";
            this.btnEmployeeSetup.UseVisualStyleBackColor = false;
            this.btnEmployeeSetup.Click += new System.EventHandler(this.btnEmployeeSetup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.btnExpenseOperations);
            this.groupBox2.Controls.Add(this.btnSalesOperations);
            this.groupBox2.Controls.Add(this.btnPurchaseOperations);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(325, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // btnExpenseOperations
            // 
            this.btnExpenseOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseOperations.Location = new System.Drawing.Point(556, 31);
            this.btnExpenseOperations.Name = "btnExpenseOperations";
            this.btnExpenseOperations.Size = new System.Drawing.Size(162, 38);
            this.btnExpenseOperations.TabIndex = 0;
            this.btnExpenseOperations.Text = "Expense Operation";
            this.btnExpenseOperations.UseVisualStyleBackColor = true;
            this.btnExpenseOperations.Click += new System.EventHandler(this.btnExpenseOperations_Click);
            // 
            // btnSalesOperations
            // 
            this.btnSalesOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesOperations.Location = new System.Drawing.Point(294, 31);
            this.btnSalesOperations.Name = "btnSalesOperations";
            this.btnSalesOperations.Size = new System.Drawing.Size(162, 38);
            this.btnSalesOperations.TabIndex = 0;
            this.btnSalesOperations.Text = "Sales Operation";
            this.btnSalesOperations.UseVisualStyleBackColor = true;
            this.btnSalesOperations.Click += new System.EventHandler(this.btnSalesOperations_Click);
            // 
            // btnPurchaseOperations
            // 
            this.btnPurchaseOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOperations.Location = new System.Drawing.Point(33, 30);
            this.btnPurchaseOperations.Name = "btnPurchaseOperations";
            this.btnPurchaseOperations.Size = new System.Drawing.Size(162, 39);
            this.btnPurchaseOperations.TabIndex = 0;
            this.btnPurchaseOperations.Text = "Purchase Operation";
            this.btnPurchaseOperations.UseVisualStyleBackColor = true;
            this.btnPurchaseOperations.Click += new System.EventHandler(this.btnPurchaseOperations_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Controls.Add(this.btnSalesReport);
            this.groupBox3.Controls.Add(this.btnStopckReport);
            this.groupBox3.Controls.Add(this.btnIncomeReport);
            this.groupBox3.Controls.Add(this.btnPurchaseReport);
            this.groupBox3.Controls.Add(this.btnExpenseReport);
            this.groupBox3.Controls.Add(this.btnPurchaseResult);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(335, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 131);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reports";
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Location = new System.Drawing.Point(551, 28);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(162, 39);
            this.btnSalesReport.TabIndex = 0;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnStopckReport
            // 
            this.btnStopckReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopckReport.Location = new System.Drawing.Point(551, 80);
            this.btnStopckReport.Name = "btnStopckReport";
            this.btnStopckReport.Size = new System.Drawing.Size(162, 39);
            this.btnStopckReport.TabIndex = 0;
            this.btnStopckReport.Text = "Stock Report";
            this.btnStopckReport.UseVisualStyleBackColor = true;
            this.btnStopckReport.Click += new System.EventHandler(this.btnStopckReport_Click);
            // 
            // btnIncomeReport
            // 
            this.btnIncomeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomeReport.Location = new System.Drawing.Point(284, 80);
            this.btnIncomeReport.Name = "btnIncomeReport";
            this.btnIncomeReport.Size = new System.Drawing.Size(162, 39);
            this.btnIncomeReport.TabIndex = 0;
            this.btnIncomeReport.Text = "Income Report";
            this.btnIncomeReport.UseVisualStyleBackColor = true;
            this.btnIncomeReport.Click += new System.EventHandler(this.btnIncomeReport_Click);
            // 
            // btnPurchaseReport
            // 
            this.btnPurchaseReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseReport.Location = new System.Drawing.Point(29, 80);
            this.btnPurchaseReport.Name = "btnPurchaseReport";
            this.btnPurchaseReport.Size = new System.Drawing.Size(162, 39);
            this.btnPurchaseReport.TabIndex = 0;
            this.btnPurchaseReport.Text = "Purchase Report";
            this.btnPurchaseReport.UseVisualStyleBackColor = true;
            this.btnPurchaseReport.Click += new System.EventHandler(this.btnPurchaseReport_Click);
            // 
            // btnExpenseReport
            // 
            this.btnExpenseReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseReport.Location = new System.Drawing.Point(283, 28);
            this.btnExpenseReport.Name = "btnExpenseReport";
            this.btnExpenseReport.Size = new System.Drawing.Size(162, 39);
            this.btnExpenseReport.TabIndex = 0;
            this.btnExpenseReport.Text = "Expense Report";
            this.btnExpenseReport.UseVisualStyleBackColor = true;
            this.btnExpenseReport.Click += new System.EventHandler(this.btnExpenseReport_Click);
            // 
            // btnPurchaseResult
            // 
            this.btnPurchaseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseResult.Location = new System.Drawing.Point(29, 28);
            this.btnPurchaseResult.Name = "btnPurchaseResult";
            this.btnPurchaseResult.Size = new System.Drawing.Size(162, 39);
            this.btnPurchaseResult.TabIndex = 0;
            this.btnPurchaseResult.Text = "Purchase Result";
            this.btnPurchaseResult.UseVisualStyleBackColor = true;
            this.btnPurchaseResult.Click += new System.EventHandler(this.btnPurchaseResult_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(738, 73);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(0, 20);
            this.lblCurrentTime.TabIndex = 2;
            // 
            // lblDateToday
            // 
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToday.Location = new System.Drawing.Point(919, 73);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(0, 20);
            this.lblDateToday.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SuperShopDashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDateToday);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SuperShopDashboardUI";
            this.Text = "Welcome to Supper Shop Management System Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPartySetup;
        private System.Windows.Forms.Button btnOutletSetup;
        private System.Windows.Forms.Button btnItemSetup;
        private System.Windows.Forms.Button btnItemCategorySetup;
        private System.Windows.Forms.Button btnOrganizationSetup;
        private System.Windows.Forms.Button btnExpenseCategorySetup;
        private System.Windows.Forms.Button btnExpenseItemSetup;
        private System.Windows.Forms.Button btnEmployeeSetup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExpenseOperations;
        private System.Windows.Forms.Button btnSalesOperations;
        private System.Windows.Forms.Button btnPurchaseOperations;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnStopckReport;
        private System.Windows.Forms.Button btnIncomeReport;
        private System.Windows.Forms.Button btnPurchaseReport;
        private System.Windows.Forms.Button btnExpenseReport;
        private System.Windows.Forms.Button btnPurchaseResult;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblDateToday;
        private System.Windows.Forms.Timer timer1;
    }
}