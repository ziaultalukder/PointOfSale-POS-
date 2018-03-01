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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblDateToday = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnStopckReport = new System.Windows.Forms.Button();
            this.btnIncomeReport = new System.Windows.Forms.Button();
            this.btnPurchaseReport = new System.Windows.Forms.Button();
            this.btnExpenseReport = new System.Windows.Forms.Button();
            this.btnPurchaseResult = new System.Windows.Forms.Button();
            this.btnExpenseOperations = new System.Windows.Forms.Button();
            this.btnSalesOperations = new System.Windows.Forms.Button();
            this.btnPurchaseOperations = new System.Windows.Forms.Button();
            this.btnPartySetup = new System.Windows.Forms.Button();
            this.btnOutletSetup = new System.Windows.Forms.Button();
            this.btnItemSetup = new System.Windows.Forms.Button();
            this.btnItemCategorySetup = new System.Windows.Forms.Button();
            this.btnOrganizationSetup = new System.Windows.Forms.Button();
            this.btnExpenseCategorySetup = new System.Windows.Forms.Button();
            this.btnExpenseItemSetup = new System.Windows.Forms.Button();
            this.btnEmployeeSetup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(215, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Supper Shop Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(580, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 22);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(759, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
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
            this.groupBox1.Location = new System.Drawing.Point(264, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Setup Item";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.btnExpenseOperations);
            this.groupBox2.Controls.Add(this.btnSalesOperations);
            this.groupBox2.Controls.Add(this.btnPurchaseOperations);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(264, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
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
            this.groupBox3.Location = new System.Drawing.Point(264, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 152);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reports";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(643, 73);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(0, 20);
            this.lblCurrentTime.TabIndex = 2;
            // 
            // lblDateToday
            // 
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToday.Location = new System.Drawing.Point(824, 73);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(0, 20);
            this.lblDateToday.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Image = global::PointOfSale.Properties.Resources.sales_report;
            this.btnSalesReport.Location = new System.Drawing.Point(556, 28);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(162, 55);
            this.btnSalesReport.TabIndex = 15;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnStopckReport
            // 
            this.btnStopckReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopckReport.Image = global::PointOfSale.Properties.Resources.financial_report_stock_receipt_print_32;
            this.btnStopckReport.Location = new System.Drawing.Point(556, 89);
            this.btnStopckReport.Name = "btnStopckReport";
            this.btnStopckReport.Size = new System.Drawing.Size(162, 57);
            this.btnStopckReport.TabIndex = 16;
            this.btnStopckReport.Text = "Stock Report";
            this.btnStopckReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStopckReport.UseVisualStyleBackColor = true;
            this.btnStopckReport.Click += new System.EventHandler(this.btnStopckReport_Click);
            // 
            // btnIncomeReport
            // 
            this.btnIncomeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomeReport.Image = global::PointOfSale.Properties.Resources.x_05_32;
            this.btnIncomeReport.Location = new System.Drawing.Point(295, 89);
            this.btnIncomeReport.Name = "btnIncomeReport";
            this.btnIncomeReport.Size = new System.Drawing.Size(162, 57);
            this.btnIncomeReport.TabIndex = 14;
            this.btnIncomeReport.Text = "Income Report";
            this.btnIncomeReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncomeReport.UseVisualStyleBackColor = true;
            this.btnIncomeReport.Click += new System.EventHandler(this.btnIncomeReport_Click);
            // 
            // btnPurchaseReport
            // 
            this.btnPurchaseReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseReport.Image = global::PointOfSale.Properties.Resources.Purchase_Report;
            this.btnPurchaseReport.Location = new System.Drawing.Point(29, 89);
            this.btnPurchaseReport.Name = "btnPurchaseReport";
            this.btnPurchaseReport.Size = new System.Drawing.Size(162, 57);
            this.btnPurchaseReport.TabIndex = 12;
            this.btnPurchaseReport.Text = "Purchase Report";
            this.btnPurchaseReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchaseReport.UseVisualStyleBackColor = true;
            this.btnPurchaseReport.Click += new System.EventHandler(this.btnPurchaseReport_Click);
            // 
            // btnExpenseReport
            // 
            this.btnExpenseReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseReport.Image = global::PointOfSale.Properties.Resources.flat_seo_07_32;
            this.btnExpenseReport.Location = new System.Drawing.Point(294, 28);
            this.btnExpenseReport.Name = "btnExpenseReport";
            this.btnExpenseReport.Size = new System.Drawing.Size(162, 55);
            this.btnExpenseReport.TabIndex = 13;
            this.btnExpenseReport.Text = "Expense Report";
            this.btnExpenseReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpenseReport.UseVisualStyleBackColor = true;
            this.btnExpenseReport.Click += new System.EventHandler(this.btnExpenseReport_Click);
            // 
            // btnPurchaseResult
            // 
            this.btnPurchaseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseResult.Image = global::PointOfSale.Properties.Resources.check_cots_purchase_results_32;
            this.btnPurchaseResult.Location = new System.Drawing.Point(29, 28);
            this.btnPurchaseResult.Name = "btnPurchaseResult";
            this.btnPurchaseResult.Size = new System.Drawing.Size(162, 55);
            this.btnPurchaseResult.TabIndex = 11;
            this.btnPurchaseResult.Text = "Purchase Result";
            this.btnPurchaseResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchaseResult.UseVisualStyleBackColor = true;
            this.btnPurchaseResult.Click += new System.EventHandler(this.btnPurchaseResult_Click);
            // 
            // btnExpenseOperations
            // 
            this.btnExpenseOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseOperations.Image = global::PointOfSale.Properties.Resources.schedule_plan_expenses_income_32;
            this.btnExpenseOperations.Location = new System.Drawing.Point(556, 31);
            this.btnExpenseOperations.Name = "btnExpenseOperations";
            this.btnExpenseOperations.Size = new System.Drawing.Size(162, 54);
            this.btnExpenseOperations.TabIndex = 10;
            this.btnExpenseOperations.Text = "Expense Operation";
            this.btnExpenseOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpenseOperations.UseVisualStyleBackColor = true;
            this.btnExpenseOperations.Click += new System.EventHandler(this.btnExpenseOperations_Click);
            // 
            // btnSalesOperations
            // 
            this.btnSalesOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesOperations.Image = global::PointOfSale.Properties.Resources.flat_seo_44_32;
            this.btnSalesOperations.Location = new System.Drawing.Point(294, 31);
            this.btnSalesOperations.Name = "btnSalesOperations";
            this.btnSalesOperations.Size = new System.Drawing.Size(162, 54);
            this.btnSalesOperations.TabIndex = 9;
            this.btnSalesOperations.Text = "Sales Operation";
            this.btnSalesOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalesOperations.UseVisualStyleBackColor = true;
            this.btnSalesOperations.Click += new System.EventHandler(this.btnSalesOperations_Click);
            // 
            // btnPurchaseOperations
            // 
            this.btnPurchaseOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOperations.Image = global::PointOfSale.Properties.Resources.icons8_Purchase_Order_32px_1;
            this.btnPurchaseOperations.Location = new System.Drawing.Point(33, 30);
            this.btnPurchaseOperations.Name = "btnPurchaseOperations";
            this.btnPurchaseOperations.Size = new System.Drawing.Size(162, 55);
            this.btnPurchaseOperations.TabIndex = 8;
            this.btnPurchaseOperations.Text = "Purchase Operation";
            this.btnPurchaseOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchaseOperations.UseVisualStyleBackColor = true;
            this.btnPurchaseOperations.Click += new System.EventHandler(this.btnPurchaseOperations_Click);
            // 
            // btnPartySetup
            // 
            this.btnPartySetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPartySetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartySetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPartySetup.Image = global::PointOfSale.Properties.Resources.delivery_man_parcel;
            this.btnPartySetup.Location = new System.Drawing.Point(197, 93);
            this.btnPartySetup.Name = "btnPartySetup";
            this.btnPartySetup.Size = new System.Drawing.Size(175, 58);
            this.btnPartySetup.TabIndex = 3;
            this.btnPartySetup.Text = "Party/Suplier Setup";
            this.btnPartySetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPartySetup.UseVisualStyleBackColor = false;
            this.btnPartySetup.Click += new System.EventHandler(this.btnPartySetup_Click);
            // 
            // btnOutletSetup
            // 
            this.btnOutletSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOutletSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutletSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOutletSetup.Image = global::PointOfSale.Properties.Resources.elements_branch;
            this.btnOutletSetup.Location = new System.Drawing.Point(9, 93);
            this.btnOutletSetup.Name = "btnOutletSetup";
            this.btnOutletSetup.Size = new System.Drawing.Size(173, 58);
            this.btnOutletSetup.TabIndex = 1;
            this.btnOutletSetup.Text = "Outlet/Branch Setup";
            this.btnOutletSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOutletSetup.UseVisualStyleBackColor = false;
            this.btnOutletSetup.Click += new System.EventHandler(this.btnOutletSetup_Click);
            // 
            // btnItemSetup
            // 
            this.btnItemSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnItemSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnItemSetup.Image = global::PointOfSale.Properties.Resources.icons8_Ingredients_48px;
            this.btnItemSetup.Location = new System.Drawing.Point(620, 93);
            this.btnItemSetup.Name = "btnItemSetup";
            this.btnItemSetup.Size = new System.Drawing.Size(168, 58);
            this.btnItemSetup.TabIndex = 7;
            this.btnItemSetup.Text = "Item Setup";
            this.btnItemSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnItemSetup.UseVisualStyleBackColor = false;
            this.btnItemSetup.Click += new System.EventHandler(this.btnItemSetup_Click);
            // 
            // btnItemCategorySetup
            // 
            this.btnItemCategorySetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnItemCategorySetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemCategorySetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnItemCategorySetup.Image = global::PointOfSale.Properties.Resources.icons8_List_50px;
            this.btnItemCategorySetup.Location = new System.Drawing.Point(620, 26);
            this.btnItemCategorySetup.Name = "btnItemCategorySetup";
            this.btnItemCategorySetup.Size = new System.Drawing.Size(168, 61);
            this.btnItemCategorySetup.TabIndex = 6;
            this.btnItemCategorySetup.Text = "Item Category Setup";
            this.btnItemCategorySetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnItemCategorySetup.UseVisualStyleBackColor = false;
            this.btnItemCategorySetup.Click += new System.EventHandler(this.btnItemCategorySetup_Click);
            // 
            // btnOrganizationSetup
            // 
            this.btnOrganizationSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOrganizationSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizationSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOrganizationSetup.Image = global::PointOfSale.Properties.Resources.icons8_Organization_32px;
            this.btnOrganizationSetup.Location = new System.Drawing.Point(9, 26);
            this.btnOrganizationSetup.Name = "btnOrganizationSetup";
            this.btnOrganizationSetup.Size = new System.Drawing.Size(173, 61);
            this.btnOrganizationSetup.TabIndex = 0;
            this.btnOrganizationSetup.Text = "Organization Setup";
            this.btnOrganizationSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrganizationSetup.UseVisualStyleBackColor = false;
            this.btnOrganizationSetup.Click += new System.EventHandler(this.btnOrganizationSetup_Click);
            // 
            // btnExpenseCategorySetup
            // 
            this.btnExpenseCategorySetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExpenseCategorySetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseCategorySetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExpenseCategorySetup.Image = global::PointOfSale.Properties.Resources.xxx022_32;
            this.btnExpenseCategorySetup.Location = new System.Drawing.Point(393, 26);
            this.btnExpenseCategorySetup.Name = "btnExpenseCategorySetup";
            this.btnExpenseCategorySetup.Size = new System.Drawing.Size(203, 61);
            this.btnExpenseCategorySetup.TabIndex = 4;
            this.btnExpenseCategorySetup.Text = "Expense Category Setup";
            this.btnExpenseCategorySetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpenseCategorySetup.UseVisualStyleBackColor = false;
            this.btnExpenseCategorySetup.Click += new System.EventHandler(this.btnExpenseCategorySetup_Click);
            // 
            // btnExpenseItemSetup
            // 
            this.btnExpenseItemSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExpenseItemSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseItemSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExpenseItemSetup.Image = global::PointOfSale.Properties.Resources.line_spacing_paragraph;
            this.btnExpenseItemSetup.Location = new System.Drawing.Point(393, 93);
            this.btnExpenseItemSetup.Name = "btnExpenseItemSetup";
            this.btnExpenseItemSetup.Size = new System.Drawing.Size(203, 58);
            this.btnExpenseItemSetup.TabIndex = 5;
            this.btnExpenseItemSetup.Text = "Expense Item Setup";
            this.btnExpenseItemSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpenseItemSetup.UseVisualStyleBackColor = false;
            this.btnExpenseItemSetup.Click += new System.EventHandler(this.btnExpenseItemSetup_Click);
            // 
            // btnEmployeeSetup
            // 
            this.btnEmployeeSetup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEmployeeSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEmployeeSetup.Image = global::PointOfSale.Properties.Resources.business_meeting;
            this.btnEmployeeSetup.Location = new System.Drawing.Point(197, 26);
            this.btnEmployeeSetup.Name = "btnEmployeeSetup";
            this.btnEmployeeSetup.Size = new System.Drawing.Size(175, 61);
            this.btnEmployeeSetup.TabIndex = 2;
            this.btnEmployeeSetup.Text = "Employee Setup";
            this.btnEmployeeSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmployeeSetup.UseVisualStyleBackColor = false;
            this.btnEmployeeSetup.Click += new System.EventHandler(this.btnEmployeeSetup_Click);
            // 
            // SuperShopDashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
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