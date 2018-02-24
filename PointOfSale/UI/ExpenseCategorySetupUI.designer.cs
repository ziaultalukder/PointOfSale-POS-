namespace PointOfSalePersonal.UI
{
    partial class ExpenseCategorySetupUI
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
            this.grpSetupExpenseCategory = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSpliter = new System.Windows.Forms.Label();
            this.txtCategoryDiscription = new System.Windows.Forms.TextBox();
            this.txtCategoryCode = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbParentCategory = new System.Windows.Forms.ComboBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radChildCategory = new System.Windows.Forms.RadioButton();
            this.radRootCategory = new System.Windows.Forms.RadioButton();
            this.grdExpenseCategory = new System.Windows.Forms.DataGridView();
            this.grpSetupExpenseCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenseCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSetupExpenseCategory
            // 
            this.grpSetupExpenseCategory.Controls.Add(this.lblId);
            this.grpSetupExpenseCategory.Controls.Add(this.btnCancle);
            this.grpSetupExpenseCategory.Controls.Add(this.btnDelete);
            this.grpSetupExpenseCategory.Controls.Add(this.btnDetails);
            this.grpSetupExpenseCategory.Controls.Add(this.btnSave);
            this.grpSetupExpenseCategory.Controls.Add(this.lblSpliter);
            this.grpSetupExpenseCategory.Controls.Add(this.txtCategoryDiscription);
            this.grpSetupExpenseCategory.Controls.Add(this.txtCategoryCode);
            this.grpSetupExpenseCategory.Controls.Add(this.txtCategoryId);
            this.grpSetupExpenseCategory.Controls.Add(this.txtCategoryName);
            this.grpSetupExpenseCategory.Controls.Add(this.label5);
            this.grpSetupExpenseCategory.Controls.Add(this.cmbParentCategory);
            this.grpSetupExpenseCategory.Controls.Add(this.lblCategoryId);
            this.grpSetupExpenseCategory.Controls.Add(this.label4);
            this.grpSetupExpenseCategory.Controls.Add(this.label3);
            this.grpSetupExpenseCategory.Controls.Add(this.label2);
            this.grpSetupExpenseCategory.Controls.Add(this.idLabel);
            this.grpSetupExpenseCategory.Controls.Add(this.label1);
            this.grpSetupExpenseCategory.Controls.Add(this.radChildCategory);
            this.grpSetupExpenseCategory.Controls.Add(this.radRootCategory);
            this.grpSetupExpenseCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSetupExpenseCategory.Location = new System.Drawing.Point(12, 9);
            this.grpSetupExpenseCategory.Name = "grpSetupExpenseCategory";
            this.grpSetupExpenseCategory.Size = new System.Drawing.Size(568, 332);
            this.grpSetupExpenseCategory.TabIndex = 0;
            this.grpSetupExpenseCategory.TabStop = false;
            this.grpSetupExpenseCategory.Text = "Setup Expense Category";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 201);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 21);
            this.lblId.TabIndex = 6;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(152, 286);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 36);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "Refresh";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(332, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(419, 286);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 36);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Visible = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(240, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSpliter
            // 
            this.lblSpliter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpliter.Location = new System.Drawing.Point(17, 273);
            this.lblSpliter.Name = "lblSpliter";
            this.lblSpliter.Size = new System.Drawing.Size(495, 2);
            this.lblSpliter.TabIndex = 4;
            // 
            // txtCategoryDiscription
            // 
            this.txtCategoryDiscription.Location = new System.Drawing.Point(234, 175);
            this.txtCategoryDiscription.Multiline = true;
            this.txtCategoryDiscription.Name = "txtCategoryDiscription";
            this.txtCategoryDiscription.Size = new System.Drawing.Size(249, 55);
            this.txtCategoryDiscription.TabIndex = 3;
            // 
            // txtCategoryCode
            // 
            this.txtCategoryCode.Location = new System.Drawing.Point(234, 142);
            this.txtCategoryCode.Name = "txtCategoryCode";
            this.txtCategoryCode.Size = new System.Drawing.Size(249, 27);
            this.txtCategoryCode.TabIndex = 3;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(234, 57);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(249, 27);
            this.txtCategoryId.TabIndex = 3;
            this.txtCategoryId.Visible = false;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(234, 111);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(249, 27);
            this.txtCategoryName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category Description:";
            // 
            // cmbParentCategory
            // 
            this.cmbParentCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbParentCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParentCategory.FormattingEnabled = true;
            this.cmbParentCategory.Location = new System.Drawing.Point(234, 78);
            this.cmbParentCategory.Name = "cmbParentCategory";
            this.cmbParentCategory.Size = new System.Drawing.Size(249, 29);
            this.cmbParentCategory.TabIndex = 2;
            this.cmbParentCategory.Click += new System.EventHandler(this.cmbParentCategory_Click);
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(83, 57);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(110, 21);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Category ID:";
            this.lblCategoryId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parent Category:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(575, 109);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 21);
            this.idLabel.TabIndex = 1;
            this.idLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Type:";
            // 
            // radChildCategory
            // 
            this.radChildCategory.AutoSize = true;
            this.radChildCategory.Location = new System.Drawing.Point(385, 26);
            this.radChildCategory.Name = "radChildCategory";
            this.radChildCategory.Size = new System.Drawing.Size(147, 25);
            this.radChildCategory.TabIndex = 0;
            this.radChildCategory.TabStop = true;
            this.radChildCategory.Text = "Child Category";
            this.radChildCategory.UseVisualStyleBackColor = true;
            this.radChildCategory.CheckedChanged += new System.EventHandler(this.radChildCategory_CheckedChanged);
            // 
            // radRootCategory
            // 
            this.radRootCategory.AutoSize = true;
            this.radRootCategory.Location = new System.Drawing.Point(229, 26);
            this.radRootCategory.Name = "radRootCategory";
            this.radRootCategory.Size = new System.Drawing.Size(144, 25);
            this.radRootCategory.TabIndex = 0;
            this.radRootCategory.TabStop = true;
            this.radRootCategory.Text = "Root Category";
            this.radRootCategory.UseVisualStyleBackColor = true;
            this.radRootCategory.CheckedChanged += new System.EventHandler(this.radRootCategory_CheckedChanged);
            // 
            // grdExpenseCategory
            // 
            this.grdExpenseCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpenseCategory.Location = new System.Drawing.Point(12, 347);
            this.grdExpenseCategory.Name = "grdExpenseCategory";
            this.grdExpenseCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExpenseCategory.Size = new System.Drawing.Size(568, 308);
            this.grdExpenseCategory.TabIndex = 1;
            this.grdExpenseCategory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdExpenseCategory_CellMouseClick);
            this.grdExpenseCategory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdExpenseCategory_CellMouseDoubleClick);
            // 
            // ExpenseCategorySetupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 667);
            this.Controls.Add(this.grdExpenseCategory);
            this.Controls.Add(this.grpSetupExpenseCategory);
            this.Name = "ExpenseCategorySetupUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Category Setup Form";
            this.grpSetupExpenseCategory.ResumeLayout(false);
            this.grpSetupExpenseCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenseCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSetupExpenseCategory;
        private System.Windows.Forms.TextBox txtCategoryDiscription;
        private System.Windows.Forms.TextBox txtCategoryCode;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbParentCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radChildCategory;
        private System.Windows.Forms.RadioButton radRootCategory;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView grdExpenseCategory;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSpliter;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
    }
}