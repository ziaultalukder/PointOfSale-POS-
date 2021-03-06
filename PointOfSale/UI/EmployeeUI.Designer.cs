﻿namespace PointOfSale.UI
{
    partial class EmployeeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUI));
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.employeeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.outlateComboBox = new System.Windows.Forms.ComboBox();
            this.joiningDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emergencyTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nidTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.presenTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.permanentTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.motherTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tabControlEmployee = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBoxRefefence = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printPreviewDialogEmployee = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentEmployee = new System.Drawing.Printing.PrintDocument();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.employeePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDialogEmployee = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeErrorProvider)).BeginInit();
            this.tabControlEmployee.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(17, 412);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowTemplate.Height = 45;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(979, 173);
            this.dgvEmployees.TabIndex = 3;
            this.dgvEmployees.DoubleClick += new System.EventHandler(this.dgvEmployees_DoubleClick);
            // 
            // employeeErrorProvider
            // 
            this.employeeErrorProvider.ContainerControl = this;
            // 
            // outlateComboBox
            // 
            this.outlateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.outlateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.outlateComboBox.FormattingEnabled = true;
            this.outlateComboBox.Location = new System.Drawing.Point(180, 97);
            this.outlateComboBox.Name = "outlateComboBox";
            this.outlateComboBox.Size = new System.Drawing.Size(282, 24);
            this.outlateComboBox.TabIndex = 2;
            // 
            // joiningDateTimePicker
            // 
            this.joiningDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joiningDateTimePicker.Location = new System.Drawing.Point(180, 134);
            this.joiningDateTimePicker.Name = "joiningDateTimePicker";
            this.joiningDateTimePicker.Size = new System.Drawing.Size(192, 23);
            this.joiningDateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outlat/Branch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(180, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(282, 23);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact No:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(180, 60);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(282, 23);
            this.codeTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reference:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(180, 171);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(192, 23);
            this.contactTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Emergency Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Father Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mother Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Joining Data:";
            // 
            // emergencyTextBox
            // 
            this.emergencyTextBox.Location = new System.Drawing.Point(193, 33);
            this.emergencyTextBox.Name = "emergencyTextBox";
            this.emergencyTextBox.Size = new System.Drawing.Size(198, 23);
            this.emergencyTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(180, 210);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(282, 23);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "NID:";
            // 
            // nidTextBox
            // 
            this.nidTextBox.Location = new System.Drawing.Point(193, 87);
            this.nidTextBox.Name = "nidTextBox";
            this.nidTextBox.Size = new System.Drawing.Size(198, 23);
            this.nidTextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(572, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Present Address:";
            // 
            // presenTextBox
            // 
            this.presenTextBox.Location = new System.Drawing.Point(731, 39);
            this.presenTextBox.Multiline = true;
            this.presenTextBox.Name = "presenTextBox";
            this.presenTextBox.Size = new System.Drawing.Size(215, 62);
            this.presenTextBox.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(572, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Permanent Address:";
            // 
            // permanentTextBox
            // 
            this.permanentTextBox.Location = new System.Drawing.Point(731, 131);
            this.permanentTextBox.Multiline = true;
            this.permanentTextBox.Name = "permanentTextBox";
            this.permanentTextBox.Size = new System.Drawing.Size(215, 61);
            this.permanentTextBox.TabIndex = 1;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(193, 142);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(282, 23);
            this.fatherNameTextBox.TabIndex = 1;
            // 
            // motherTextBox
            // 
            this.motherTextBox.Location = new System.Drawing.Point(193, 195);
            this.motherTextBox.Name = "motherTextBox";
            this.motherTextBox.Size = new System.Drawing.Size(282, 23);
            this.motherTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(15, 348);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 30);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(885, 168);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(96, 30);
            this.BrowseButton.TabIndex = 6;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(118, 348);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(91, 30);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // tabControlEmployee
            // 
            this.tabControlEmployee.Controls.Add(this.tabPage1);
            this.tabControlEmployee.Controls.Add(this.tabPage2);
            this.tabControlEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlEmployee.Location = new System.Drawing.Point(9, 19);
            this.tabControlEmployee.Name = "tabControlEmployee";
            this.tabControlEmployee.SelectedIndex = 0;
            this.tabControlEmployee.Size = new System.Drawing.Size(995, 323);
            this.tabControlEmployee.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.employeePictureBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.BrowseButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.joiningDateTimePicker);
            this.tabPage1.Controls.Add(this.outlateComboBox);
            this.tabPage1.Controls.Add(this.txtBoxRefefence);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(this.contactTextBox);
            this.tabPage1.Controls.Add(this.codeTextBox);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Official Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBoxRefefence
            // 
            this.txtBoxRefefence.Location = new System.Drawing.Point(180, 246);
            this.txtBoxRefefence.Name = "txtBoxRefefence";
            this.txtBoxRefefence.Size = new System.Drawing.Size(282, 23);
            this.txtBoxRefefence.TabIndex = 1;
            this.txtBoxRefefence.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.fatherNameTextBox);
            this.tabPage2.Controls.Add(this.emergencyTextBox);
            this.tabPage2.Controls.Add(this.nidTextBox);
            this.tabPage2.Controls.Add(this.permanentTextBox);
            this.tabPage2.Controls.Add(this.motherTextBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.presenTextBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(987, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personal Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(223, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(839, 382);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(151, 20);
            this.txtBoxSearch.TabIndex = 1;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.txtBoxSearch.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(718, 381);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Quick Search:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(698, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Search by Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(839, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // printPreviewDialogEmployee
            // 
            this.printPreviewDialogEmployee.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogEmployee.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogEmployee.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogEmployee.Enabled = true;
            this.printPreviewDialogEmployee.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogEmployee.Icon")));
            this.printPreviewDialogEmployee.Name = "printPreviewDialogEmployee";
            this.printPreviewDialogEmployee.Visible = false;
            // 
            // printDocumentEmployee
            // 
            this.printDocumentEmployee.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentEmployee_PrintPage);
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Image = global::PointOfSale.Properties.Resources.icons8_PDF_32px_1;
            this.btnPDF.Location = new System.Drawing.Point(597, 344);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(91, 62);
            this.btnPDF.TabIndex = 6;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::PointOfSale.Properties.Resources.icons8_Print_32px_1;
            this.btnPrint.Location = new System.Drawing.Point(492, 344);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 62);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // employeePictureBox
            // 
            this.employeePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeePictureBox.BackgroundImage")));
            this.employeePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeePictureBox.Location = new System.Drawing.Point(808, 3);
            this.employeePictureBox.Name = "employeePictureBox";
            this.employeePictureBox.Size = new System.Drawing.Size(173, 150);
            this.employeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePictureBox.TabIndex = 5;
            this.employeePictureBox.TabStop = false;
            this.employeePictureBox.DoubleClick += new System.EventHandler(this.employeePictureBox_DoubleClick);
            // 
            // button1
            // 
            this.button1.Image = global::PointOfSale.Properties.Resources.icons8_Forward_Button_32px___Copy;
            this.button1.Location = new System.Drawing.Point(887, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next Page";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Image = global::PointOfSale.Properties.Resources.icons8_Back_Arrow_32px;
            this.button2.Location = new System.Drawing.Point(7, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Previous Page";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDialogEmployee
            // 
            this.printDialogEmployee.UseEXDialog = true;
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 600);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.tabControlEmployee);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Name = "EmployeeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Screen";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeErrorProvider)).EndInit();
            this.tabControlEmployee.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ErrorProvider employeeErrorProvider;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TabControl tabControlEmployee;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox employeePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker joiningDateTimePicker;
        private System.Windows.Forms.ComboBox outlateComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox emergencyTextBox;
        private System.Windows.Forms.TextBox nidTextBox;
        private System.Windows.Forms.TextBox permanentTextBox;
        private System.Windows.Forms.TextBox motherTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox presenTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBoxRefefence;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogEmployee;
        private System.Drawing.Printing.PrintDocument printDocumentEmployee;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.PrintDialog printDialogEmployee;
    }
}