namespace PointOfSale.UI
{
    partial class BarcodeUI
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
            this.txtBoxItemCode = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAllShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNumberOfCopy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code:";
            // 
            // txtBoxItemCode
            // 
            this.txtBoxItemCode.Location = new System.Drawing.Point(108, 16);
            this.txtBoxItemCode.Name = "txtBoxItemCode";
            this.txtBoxItemCode.Size = new System.Drawing.Size(151, 24);
            this.txtBoxItemCode.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 58);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1103, 565);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(595, 13);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(92, 31);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAllShow
            // 
            this.btnAllShow.Location = new System.Drawing.Point(727, 14);
            this.btnAllShow.Name = "btnAllShow";
            this.btnAllShow.Size = new System.Drawing.Size(91, 29);
            this.btnAllShow.TabIndex = 3;
            this.btnAllShow.Text = "All Show";
            this.btnAllShow.UseVisualStyleBackColor = true;
            this.btnAllShow.Click += new System.EventHandler(this.btnAllShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number Of Copy:";
            // 
            // txtBoxNumberOfCopy
            // 
            this.txtBoxNumberOfCopy.Location = new System.Drawing.Point(408, 16);
            this.txtBoxNumberOfCopy.Name = "txtBoxNumberOfCopy";
            this.txtBoxNumberOfCopy.Size = new System.Drawing.Size(151, 24);
            this.txtBoxNumberOfCopy.TabIndex = 1;
            // 
            // BarcodeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 635);
            this.Controls.Add(this.btnAllShow);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtBoxNumberOfCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxItemCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BarcodeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Barcode Generate Screen";
            this.Load += new System.EventHandler(this.BarcodeUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxItemCode;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAllShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNumberOfCopy;
    }
}