namespace PointOfSale.UI
{
    partial class PurchaseUI
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
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.purchaseItemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outletcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.employeecomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.partyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.manualPriceTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancleButton = new System.Windows.Forms.Button();
            this.totalAmmountTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dueTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.itemAddedLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxCostPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.purchaseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextBox.Location = new System.Drawing.Point(311, 22);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(78, 23);
            this.qtyTextBox.TabIndex = 0;
            // 
            // itemComboBox
            // 
            this.itemComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(85, 21);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(178, 25);
            this.itemComboBox.TabIndex = 1;
            this.itemComboBox.SelectedValueChanged += new System.EventHandler(this.itemComboBox_SelectedValueChanged);
            this.itemComboBox.TextChanged += new System.EventHandler(this.itemComboBox_TextChanged);
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.AllowUserToAddRows = false;
            this.purchaseDataGridView.AllowUserToDeleteRows = false;
            this.purchaseDataGridView.AutoGenerateColumns = false;
            this.purchaseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sl,
            this.itemNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.lineTotalDataGridViewTextBoxColumn,
            this.Delete});
            this.purchaseDataGridView.DataSource = this.purchaseItemBindingSource2;
            this.purchaseDataGridView.Location = new System.Drawing.Point(44, 239);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.ReadOnly = true;
            this.purchaseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchaseDataGridView.Size = new System.Drawing.Size(665, 278);
            this.purchaseDataGridView.TabIndex = 2;
            this.purchaseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseDataGridView_CellContentClick);
            this.purchaseDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.purchaseDataGridView_RowPostPaint);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // sl
            // 
            this.sl.HeaderText = "Serial No";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineTotalDataGridViewTextBoxColumn
            // 
            this.lineTotalDataGridViewTextBoxColumn.DataPropertyName = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.HeaderText = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.Name = "lineTotalDataGridViewTextBoxColumn";
            this.lineTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // purchaseItemBindingSource2
            // 
            this.purchaseItemBindingSource2.DataSource = typeof(PointOfSale.Models.PurchaseItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qty";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarksTextBox.Location = new System.Drawing.Point(117, 233);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(239, 63);
            this.remarksTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Remarks";
            // 
            // outletcomboBox
            // 
            this.outletcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.outletcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.outletcomboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outletcomboBox.FormattingEnabled = true;
            this.outletcomboBox.Location = new System.Drawing.Point(117, 26);
            this.outletcomboBox.Name = "outletcomboBox";
            this.outletcomboBox.Size = new System.Drawing.Size(239, 29);
            this.outletcomboBox.TabIndex = 1;
            this.outletcomboBox.SelectedIndexChanged += new System.EventHandler(this.outletcomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Outlet";
            // 
            // employeecomboBox
            // 
            this.employeecomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.employeecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.employeecomboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeecomboBox.FormattingEnabled = true;
            this.employeecomboBox.Location = new System.Drawing.Point(117, 76);
            this.employeecomboBox.Name = "employeecomboBox";
            this.employeecomboBox.Size = new System.Drawing.Size(239, 29);
            this.employeecomboBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Employee";
            // 
            // partyTypeComboBox
            // 
            this.partyTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.partyTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.partyTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyTypeComboBox.FormattingEnabled = true;
            this.partyTypeComboBox.Items.AddRange(new object[] {
            "Customer",
            "Supplier"});
            this.partyTypeComboBox.Location = new System.Drawing.Point(117, 128);
            this.partyTypeComboBox.Name = "partyTypeComboBox";
            this.partyTypeComboBox.Size = new System.Drawing.Size(239, 29);
            this.partyTypeComboBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Supplier";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(117, 181);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(138, 26);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date";
            // 
            // manualPriceTextBox
            // 
            this.manualPriceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualPriceTextBox.Location = new System.Drawing.Point(491, 22);
            this.manualPriceTextBox.Name = "manualPriceTextBox";
            this.manualPriceTextBox.Size = new System.Drawing.Size(119, 23);
            this.manualPriceTextBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(626, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.remarksTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.outletcomboBox);
            this.groupBox1.Controls.Add(this.employeecomboBox);
            this.groupBox1.Controls.Add(this.partyTypeComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(822, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 311);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(645, 154);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 28);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancleButton
            // 
            this.cancleButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleButton.Location = new System.Drawing.Point(715, 154);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(77, 28);
            this.cancleButton.TabIndex = 6;
            this.cancleButton.Text = "Cancle";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // totalAmmountTextBox
            // 
            this.totalAmmountTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmmountTextBox.Location = new System.Drawing.Point(953, 382);
            this.totalAmmountTextBox.Name = "totalAmmountTextBox";
            this.totalAmmountTextBox.ReadOnly = true;
            this.totalAmmountTextBox.Size = new System.Drawing.Size(225, 27);
            this.totalAmmountTextBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(802, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total Ammount";
            // 
            // dueTextBox
            // 
            this.dueTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueTextBox.Location = new System.Drawing.Point(953, 438);
            this.dueTextBox.Name = "dueTextBox";
            this.dueTextBox.Size = new System.Drawing.Size(225, 27);
            this.dueTextBox.TabIndex = 0;
            this.dueTextBox.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(893, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Due";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total Item :";
            // 
            // itemAddedLabel
            // 
            this.itemAddedLabel.AutoSize = true;
            this.itemAddedLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemAddedLabel.Location = new System.Drawing.Point(161, 79);
            this.itemAddedLabel.Name = "itemAddedLabel";
            this.itemAddedLabel.Size = new System.Drawing.Size(0, 17);
            this.itemAddedLabel.TabIndex = 3;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(555, 539);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(151, 27);
            this.totalTextBox.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(416, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total Ammount";
            // 
            // txtBoxCostPrice
            // 
            this.txtBoxCostPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCostPrice.Location = new System.Drawing.Point(673, 22);
            this.txtBoxCostPrice.Name = "txtBoxCostPrice";
            this.txtBoxCostPrice.ReadOnly = true;
            this.txtBoxCostPrice.Size = new System.Drawing.Size(119, 23);
            this.txtBoxCostPrice.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(397, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Manual Price";
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBarcode.Location = new System.Drawing.Point(44, 71);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(219, 111);
            this.pictureBoxBarcode.TabIndex = 7;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = global::PointOfSale.Properties.Resources.save_as;
            this.saveButton.Location = new System.Drawing.Point(1066, 501);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 62);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PointOfSale.Properties.Resources.icons8_Barcode_32px;
            this.button1.Location = new System.Drawing.Point(276, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Barcode Generate";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchaseItemBindingSource
            // 
            this.purchaseItemBindingSource.DataSource = typeof(PointOfSale.Models.PurchaseItem);
            // 
            // purchaseItemBindingSource1
            // 
            this.purchaseItemBindingSource1.DataSource = typeof(PointOfSale.Models.PurchaseItem);
            // 
            // PurchaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 583);
            this.Controls.Add(this.pictureBoxBarcode);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemAddedLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.dueTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalAmmountTextBox);
            this.Controls.Add(this.txtBoxCostPrice);
            this.Controls.Add(this.manualPriceTextBox);
            this.Controls.Add(this.qtyTextBox);
            this.Name = "PurchaseUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Operation Screen";
            this.Load += new System.EventHandler(this.PurchaseUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox outletcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employeecomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox partyTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox manualPriceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.TextBox totalAmmountTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dueTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label itemAddedLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxCostPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource purchaseItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource purchaseItemBindingSource2;
        private System.Windows.Forms.BindingSource purchaseItemBindingSource1;
    }
}