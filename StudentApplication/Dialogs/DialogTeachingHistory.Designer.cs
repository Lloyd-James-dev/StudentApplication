namespace StudentApplication.Dialogs {
    partial class DialogTeachingHistory {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogTeachingHistory));
            this.GRPBOX_TeachingHistory = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogTeacherHistoryClose = new System.Windows.Forms.Button();
            this.LBL_DialogTeacherHistoryResults = new System.Windows.Forms.Label();
            this.DGV_DialogTeachingHistory = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_TeachingHistory_Name = new System.Windows.Forms.Label();
            this.GRPBOX_TeachingHistory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogTeachingHistory)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPBOX_TeachingHistory
            // 
            this.GRPBOX_TeachingHistory.Controls.Add(this.tableLayoutPanel1);
            this.GRPBOX_TeachingHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRPBOX_TeachingHistory.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPBOX_TeachingHistory.Location = new System.Drawing.Point(6, 3);
            this.GRPBOX_TeachingHistory.Name = "GRPBOX_TeachingHistory";
            this.GRPBOX_TeachingHistory.Size = new System.Drawing.Size(932, 555);
            this.GRPBOX_TeachingHistory.TabIndex = 0;
            this.GRPBOX_TeachingHistory.TabStop = false;
            this.GRPBOX_TeachingHistory.Text = "Teaching History";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_DialogTeacherHistoryClose, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogTeacherHistoryResults, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DGV_DialogTeachingHistory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTN_DialogTeacherHistoryClose
            // 
            this.BTN_DialogTeacherHistoryClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogTeacherHistoryClose.AutoSize = true;
            this.BTN_DialogTeacherHistoryClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_DialogTeacherHistoryClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogTeacherHistoryClose.Location = new System.Drawing.Point(790, 471);
            this.BTN_DialogTeacherHistoryClose.Name = "BTN_DialogTeacherHistoryClose";
            this.BTN_DialogTeacherHistoryClose.Size = new System.Drawing.Size(133, 33);
            this.BTN_DialogTeacherHistoryClose.TabIndex = 1;
            this.BTN_DialogTeacherHistoryClose.Text = "Close Dialog";
            this.BTN_DialogTeacherHistoryClose.UseVisualStyleBackColor = true;
            // 
            // LBL_DialogTeacherHistoryResults
            // 
            this.LBL_DialogTeacherHistoryResults.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LBL_DialogTeacherHistoryResults, 2);
            this.LBL_DialogTeacherHistoryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DialogTeacherHistoryResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogTeacherHistoryResults.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LBL_DialogTeacherHistoryResults.Location = new System.Drawing.Point(5, 50);
            this.LBL_DialogTeacherHistoryResults.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DialogTeacherHistoryResults.Name = "LBL_DialogTeacherHistoryResults";
            this.LBL_DialogTeacherHistoryResults.Size = new System.Drawing.Size(916, 20);
            this.LBL_DialogTeacherHistoryResults.TabIndex = 0;
            this.LBL_DialogTeacherHistoryResults.Text = "Course(s)";
            this.LBL_DialogTeacherHistoryResults.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DGV_DialogTeachingHistory
            // 
            this.DGV_DialogTeachingHistory.AllowUserToAddRows = false;
            this.DGV_DialogTeachingHistory.AllowUserToDeleteRows = false;
            this.DGV_DialogTeachingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DialogTeachingHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DialogTeachingHistory.Location = new System.Drawing.Point(3, 73);
            this.DGV_DialogTeachingHistory.Name = "DGV_DialogTeachingHistory";
            this.DGV_DialogTeachingHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DialogTeachingHistory.Size = new System.Drawing.Size(920, 387);
            this.DGV_DialogTeachingHistory.TabIndex = 0;
            this.DGV_DialogTeachingHistory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_DialogTeacherHistory_DataBindingComplete);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LBL_TeachingHistory_Name, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_TeachingHistory_Name
            // 
            this.LBL_TeachingHistory_Name.AutoSize = true;
            this.LBL_TeachingHistory_Name.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TeachingHistory_Name.Location = new System.Drawing.Point(141, 0);
            this.LBL_TeachingHistory_Name.Name = "LBL_TeachingHistory_Name";
            this.LBL_TeachingHistory_Name.Size = new System.Drawing.Size(125, 24);
            this.LBL_TeachingHistory_Name.TabIndex = 0;
            this.LBL_TeachingHistory_Name.Text = "teacher name";
            this.LBL_TeachingHistory_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DialogTeachingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.GRPBOX_TeachingHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "DialogTeachingHistory";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Teaching History";
            this.GRPBOX_TeachingHistory.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogTeachingHistory)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPBOX_TeachingHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBL_DialogTeacherHistoryResults;
        private System.Windows.Forms.DataGridView DGV_DialogTeachingHistory;
        private System.Windows.Forms.Button BTN_DialogTeacherHistoryClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_TeachingHistory_Name;
    }
}