namespace PointOfSale.UI
{
    partial class FrmSetupExpenseItem
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtExpenseItemDescription = new System.Windows.Forms.TextBox();
            this.txtExpenseItemCode = new System.Windows.Forms.TextBox();
            this.txtExpenseCategoryCode = new System.Windows.Forms.TextBox();
            this.txtExpenseItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdExpenseItems = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenseItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbExpenseCategory);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtExpenseItemDescription);
            this.groupBox1.Controls.Add(this.txtExpenseItemCode);
            this.groupBox1.Controls.Add(this.txtExpenseCategoryCode);
            this.groupBox1.Controls.Add(this.txtExpenseItemName);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense Item";
            // 
            // cmbExpenseCategory
            // 
            this.cmbExpenseCategory.FormattingEnabled = true;
            this.cmbExpenseCategory.Location = new System.Drawing.Point(146, 26);
            this.cmbExpenseCategory.Name = "cmbExpenseCategory";
            this.cmbExpenseCategory.Size = new System.Drawing.Size(315, 29);
            this.cmbExpenseCategory.TabIndex = 3;
            this.cmbExpenseCategory.SelectedIndexChanged += new System.EventHandler(this.cmbExpenseCategory_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(305, 255);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 29);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancle";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtExpenseItemDescription
            // 
            this.txtExpenseItemDescription.Location = new System.Drawing.Point(146, 128);
            this.txtExpenseItemDescription.Multiline = true;
            this.txtExpenseItemDescription.Name = "txtExpenseItemDescription";
            this.txtExpenseItemDescription.Size = new System.Drawing.Size(315, 102);
            this.txtExpenseItemDescription.TabIndex = 1;
            // 
            // txtExpenseItemCode
            // 
            this.txtExpenseItemCode.Location = new System.Drawing.Point(146, 95);
            this.txtExpenseItemCode.Name = "txtExpenseItemCode";
            this.txtExpenseItemCode.Size = new System.Drawing.Size(146, 27);
            this.txtExpenseItemCode.TabIndex = 1;
            // 
            // txtExpenseCategoryCode
            // 
            this.txtExpenseCategoryCode.Location = new System.Drawing.Point(298, 95);
            this.txtExpenseCategoryCode.Name = "txtExpenseCategoryCode";
            this.txtExpenseCategoryCode.ReadOnly = true;
            this.txtExpenseCategoryCode.Size = new System.Drawing.Size(163, 27);
            this.txtExpenseCategoryCode.TabIndex = 1;
            // 
            // txtExpenseItemName
            // 
            this.txtExpenseItemName.Location = new System.Drawing.Point(146, 62);
            this.txtExpenseItemName.Name = "txtExpenseItemName";
            this.txtExpenseItemName.Size = new System.Drawing.Size(315, 27);
            this.txtExpenseItemName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // grdExpenseItems
            // 
            this.grdExpenseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpenseItems.Location = new System.Drawing.Point(21, 344);
            this.grdExpenseItems.Name = "grdExpenseItems";
            this.grdExpenseItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExpenseItems.Size = new System.Drawing.Size(662, 302);
            this.grdExpenseItems.TabIndex = 1;
            this.grdExpenseItems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdExpenseItems_CellMouseDoubleClick);
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(475, 128);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(129, 19);
            this.idLabel.TabIndex = 0;
            this.idLabel.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(386, 255);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(82, 29);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // FrmSetupExpenseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 688);
            this.Controls.Add(this.grdExpenseItems);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSetupExpenseItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Item Setup form";
            this.Load += new System.EventHandler(this.FrmSetupExpenseItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenseItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExpenseItemDescription;
        private System.Windows.Forms.TextBox txtExpenseItemCode;
        private System.Windows.Forms.TextBox txtExpenseCategoryCode;
        private System.Windows.Forms.TextBox txtExpenseItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbExpenseCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdExpenseItems;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button updateButton;
    }
}