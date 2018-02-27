namespace PointOfSale.UI
{
    partial class ItemSetupUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSetupUI));
            this.itmeSetupDataGridView = new System.Windows.Forms.DataGridView();
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            this.browserButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.costPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.catagoryComboBox = new System.Windows.Forms.ComboBox();
            this.catagoryCodeTextBox = new System.Windows.Forms.TextBox();
            this.salesPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.costPriceRrrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itmeSetupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPriceRrrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // itmeSetupDataGridView
            // 
            this.itmeSetupDataGridView.AllowUserToAddRows = false;
            this.itmeSetupDataGridView.AllowUserToDeleteRows = false;
            this.itmeSetupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itmeSetupDataGridView.ColumnHeadersHeight = 33;
            this.itmeSetupDataGridView.Location = new System.Drawing.Point(25, 382);
            this.itmeSetupDataGridView.Name = "itmeSetupDataGridView";
            this.itmeSetupDataGridView.ReadOnly = true;
            this.itmeSetupDataGridView.RowTemplate.Height = 50;
            this.itmeSetupDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itmeSetupDataGridView.Size = new System.Drawing.Size(861, 191);
            this.itmeSetupDataGridView.TabIndex = 30;
            this.itmeSetupDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itmeSetupDataGridView_CellClick);
            this.itmeSetupDataGridView.DoubleClick += new System.EventHandler(this.itmeSetupDataGridView_DoubleClick);
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemPictureBox.BackgroundImage")));
            this.itemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPictureBox.Location = new System.Drawing.Point(683, 12);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(203, 189);
            this.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPictureBox.TabIndex = 28;
            this.itemPictureBox.TabStop = false;
            // 
            // browserButton
            // 
            this.browserButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserButton.Location = new System.Drawing.Point(738, 228);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(148, 40);
            this.browserButton.TabIndex = 5;
            this.browserButton.Text = "Browse Image";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.Click += new System.EventHandler(this.browserButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(396, 324);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 40);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(275, 324);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(109, 40);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(26, 324);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(127, 238);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(320, 61);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(127, 197);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(149, 27);
            this.codeTextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sales Price";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(127, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(320, 27);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // costPriceTextBox
            // 
            this.costPriceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPriceTextBox.Location = new System.Drawing.Point(127, 105);
            this.costPriceTextBox.Name = "costPriceTextBox";
            this.costPriceTextBox.Size = new System.Drawing.Size(320, 27);
            this.costPriceTextBox.TabIndex = 2;
            this.costPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costPriceTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cost Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Catagory";
            // 
            // catagoryComboBox
            // 
            this.catagoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.catagoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.catagoryComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryComboBox.FormattingEnabled = true;
            this.catagoryComboBox.Location = new System.Drawing.Point(127, 13);
            this.catagoryComboBox.Name = "catagoryComboBox";
            this.catagoryComboBox.Size = new System.Drawing.Size(320, 29);
            this.catagoryComboBox.TabIndex = 0;
            // 
            // catagoryCodeTextBox
            // 
            this.catagoryCodeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryCodeTextBox.Location = new System.Drawing.Point(297, 197);
            this.catagoryCodeTextBox.Name = "catagoryCodeTextBox";
            this.catagoryCodeTextBox.ReadOnly = true;
            this.catagoryCodeTextBox.Size = new System.Drawing.Size(150, 27);
            this.catagoryCodeTextBox.TabIndex = 21;
            // 
            // salesPriceTextBox
            // 
            this.salesPriceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesPriceTextBox.Location = new System.Drawing.Point(127, 151);
            this.salesPriceTextBox.Name = "salesPriceTextBox";
            this.salesPriceTextBox.Size = new System.Drawing.Size(320, 27);
            this.salesPriceTextBox.TabIndex = 3;
            this.salesPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salesPriceTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Description";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(123, 360);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 21);
            this.idLabel.TabIndex = 10;
            this.idLabel.Visible = false;
            // 
            // costPriceRrrorProvider
            // 
            this.costPriceRrrorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Search By Name";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(652, 343);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(234, 24);
            this.txtBoxSearch.TabIndex = 10;
            this.txtBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSearch_KeyPress);
            // 
            // ItemSetupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 586);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.catagoryComboBox);
            this.Controls.Add(this.itmeSetupDataGridView);
            this.Controls.Add(this.itemPictureBox);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.catagoryCodeTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.salesPriceTextBox);
            this.Controls.Add(this.costPriceTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ItemSetupUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Setup Screen";
            this.Load += new System.EventHandler(this.ItemSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itmeSetupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPriceRrrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itmeSetupDataGridView;
        private System.Windows.Forms.PictureBox itemPictureBox;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox costPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox catagoryComboBox;
        private System.Windows.Forms.TextBox catagoryCodeTextBox;
        private System.Windows.Forms.TextBox salesPriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ErrorProvider costPriceRrrorProvider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label label7;
    }
}