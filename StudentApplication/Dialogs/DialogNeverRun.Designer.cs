namespace StudentApplication.Dialogs {
    partial class DialogNeverRun {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogNeverRun));
            this.GRPBOX_NeverRun = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogNeverRunOK = new System.Windows.Forms.Button();
            this.DGV_DialogNeverRun = new System.Windows.Forms.DataGridView();
            this.LBL_DialogNeverRunResults = new System.Windows.Forms.Label();
            this.GRPBOX_NeverRun.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogNeverRun)).BeginInit();
            this.SuspendLayout();
            // 
            // GRPBOX_NeverRun
            // 
            this.GRPBOX_NeverRun.Controls.Add(this.tableLayoutPanel1);
            this.GRPBOX_NeverRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRPBOX_NeverRun.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPBOX_NeverRun.Location = new System.Drawing.Point(6, 3);
            this.GRPBOX_NeverRun.Name = "GRPBOX_NeverRun";
            this.GRPBOX_NeverRun.Size = new System.Drawing.Size(932, 555);
            this.GRPBOX_NeverRun.TabIndex = 0;
            this.GRPBOX_NeverRun.TabStop = false;
            this.GRPBOX_NeverRun.Text = "Courses Never Run or Assigned";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_DialogNeverRunOK, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DGV_DialogNeverRun, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogNeverRunResults, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTN_DialogNeverRunOK
            // 
            this.BTN_DialogNeverRunOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogNeverRunOK.AutoSize = true;
            this.BTN_DialogNeverRunOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_DialogNeverRunOK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogNeverRunOK.Location = new System.Drawing.Point(806, 471);
            this.BTN_DialogNeverRunOK.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogNeverRunOK.Name = "BTN_DialogNeverRunOK";
            this.BTN_DialogNeverRunOK.Size = new System.Drawing.Size(115, 33);
            this.BTN_DialogNeverRunOK.TabIndex = 1;
            this.BTN_DialogNeverRunOK.Text = "Close Dialog";
            this.BTN_DialogNeverRunOK.UseVisualStyleBackColor = true;
            // 
            // DGV_DialogNeverRun
            // 
            this.DGV_DialogNeverRun.AllowUserToAddRows = false;
            this.DGV_DialogNeverRun.AllowUserToDeleteRows = false;
            this.DGV_DialogNeverRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_DialogNeverRun, 2);
            this.DGV_DialogNeverRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DialogNeverRun.Location = new System.Drawing.Point(3, 48);
            this.DGV_DialogNeverRun.Name = "DGV_DialogNeverRun";
            this.DGV_DialogNeverRun.Size = new System.Drawing.Size(920, 412);
            this.DGV_DialogNeverRun.TabIndex = 0;
            // 
            // LBL_DialogNeverRunResults
            // 
            this.LBL_DialogNeverRunResults.AutoSize = true;
            this.LBL_DialogNeverRunResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DialogNeverRunResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogNeverRunResults.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LBL_DialogNeverRunResults.Location = new System.Drawing.Point(5, 25);
            this.LBL_DialogNeverRunResults.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DialogNeverRunResults.Name = "LBL_DialogNeverRunResults";
            this.LBL_DialogNeverRunResults.Size = new System.Drawing.Size(916, 20);
            this.LBL_DialogNeverRunResults.TabIndex = 0;
            this.LBL_DialogNeverRunResults.Text = "Subject(s)";
            this.LBL_DialogNeverRunResults.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DialogNeverRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.GRPBOX_NeverRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "DialogNeverRun";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Never Run";
            this.GRPBOX_NeverRun.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogNeverRun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPBOX_NeverRun;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBL_DialogNeverRunResults;
        private System.Windows.Forms.DataGridView DGV_DialogNeverRun;
        private System.Windows.Forms.Button BTN_DialogNeverRunOK;
    }
}