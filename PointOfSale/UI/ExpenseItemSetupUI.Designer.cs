namespace PointOfSale.UI
{
    partial class ExpenseItemSetupUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbExpenseCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtExpenseItemDescription = new System.Windows.Forms.TextBox();
            this.txtExpenseItemCode = new System.Windows.Forms.TextBox();
            this.txtExpenseCategoryCode = new System.Windows.Forms.TextBox();
            this.txtExpenseItemName = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdExpenseItems = new System.Windows.Forms.DataGridView();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenseItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSrc);
            this.groupBox1.Controls.Add(this.cmbExpenseCategory);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtExpenseItemDescription);
            this.groupBox1.Controls.Add(this.txtExpenseItemCode);
            this.groupBox1.Controls.Add(this.txtExpenseCategoryCode);
            this.groupBox1.Controls.Add(this.txtExpenseItemName);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense Item";
            // 
            // cmbExpenseCategory
            // 
            this.cmbExpenseCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbExpenseCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbExpenseCategory.FormattingEnabled = true;
            this.cmbExpenseCategory.Location = new System.Drawing.Point(171, 26);
            this.cmbExpenseCategory.Name = "cmbExpenseCategory";
            this.cmbExpenseCategory.Size = new System.Drawing.Size(437, 29);
            this.cmbExpenseCategory.TabIndex = 3;
            this.cmbExpenseCategory.SelectedIndexChanged += new System.EventHandler(this.cmbExpenseCategory_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(286, 221);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(408, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(514, 221);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtExpenseItemDescription
            // 
            this.txtExpenseItemDescription.Location = new System.Drawing.Point(171, 138);
            this.txtExpenseItemDescription.Multiline = true;
            this.txtExpenseItemDescription.Name = "txtExpenseItemDescription";
            this.txtExpenseItemDescription.Size = new System.Drawing.Size(437, 72);
            this.txtExpenseItemDescription.TabIndex = 1;
            // 
            // txtExpenseItemCode
            // 
            this.txtExpenseItemCode.Location = new System.Drawing.Point(340, 100);
            this.txtExpenseItemCode.Name = "txtExpenseItemCode";
            this.txtExpenseItemCode.Size = new System.Drawing.Size(268, 27);
            this.txtExpenseItemCode.TabIndex = 1;
            // 
            // txtExpenseCategoryCode
            // 
            this.txtExpenseCategoryCode.Location = new System.Drawing.Point(171, 100);
            this.txtExpenseCategoryCode.Name = "txtExpenseCategoryCode";
            this.txtExpenseCategoryCode.ReadOnly = true;
            this.txtExpenseCategoryCode.Size = new System.Drawing.Size(163, 27);
            this.txtExpenseCategoryCode.TabIndex = 1;
            // 
            // txtExpenseItemName
            // 
            this.txtExpenseItemName.Location = new System.Drawing.Point(171, 62);
            this.txtExpenseItemName.Name = "txtExpenseItemName";
            this.txtExpenseItemName.Size = new System.Drawing.Size(437, 27);
            this.txtExpenseItemName.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(35, 179);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(129, 19);
            this.idLabel.TabIndex = 0;
            this.idLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // grdExpenseItems
            // 
            this.grdExpenseItems.AllowUserToOrderColumns = true;
            this.grdExpenseItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdExpenseItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdExpenseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpenseItems.Location = new System.Drawing.Point(21, 344);
            this.grdExpenseItems.Name = "grdExpenseItems";
            this.grdExpenseItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExpenseItems.Size = new System.Drawing.Size(662, 302);
            this.grdExpenseItems.TabIndex = 1;
            this.grdExpenseItems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdExpenseItems_CellMouseDoubleClick);
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Location = new System.Drawing.Point(415, 262);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(193, 27);
            this.textBoxSrc.TabIndex = 88;
            this.textBoxSrc.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quick Search";
            // 
            // ExpenseItemSetupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 688);
            this.Controls.Add(this.grdExpenseItems);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExpenseItemSetupUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Item Setup Screen";
            this.Load += new System.EventHandler(this.ExpenseItemSetupUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenseItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExpenseItemDescription;
        private System.Windows.Forms.TextBox txtExpenseItemCode;
        private System.Windows.Forms.TextBox txtExpenseItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbExpenseCategory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdExpenseItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtExpenseCategoryCode;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.Label label5;
    }
}