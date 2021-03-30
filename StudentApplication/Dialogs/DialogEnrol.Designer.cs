namespace StudentApplication.Dialogs {
    partial class DialogEnrol {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogEnrol));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogEnrolCancel = new System.Windows.Forms.Button();
            this.DGV_DialogEnrol = new System.Windows.Forms.DataGridView();
            this.LBL_DialogEnrolResults = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_DialogEnrol_Semester = new System.Windows.Forms.Label();
            this.LBL_DialogEnrol_College = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_DialogEnrol_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogEnrol)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrol Student in a Course";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_DialogEnrolCancel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DGV_DialogEnrol, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogEnrolResults, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTN_DialogEnrolCancel
            // 
            this.BTN_DialogEnrolCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_DialogEnrolCancel.AutoSize = true;
            this.BTN_DialogEnrolCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_DialogEnrolCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogEnrolCancel.Location = new System.Drawing.Point(5, 471);
            this.BTN_DialogEnrolCancel.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogEnrolCancel.Name = "BTN_DialogEnrolCancel";
            this.BTN_DialogEnrolCancel.Size = new System.Drawing.Size(82, 33);
            this.BTN_DialogEnrolCancel.TabIndex = 1;
            this.BTN_DialogEnrolCancel.Text = "Cancel";
            this.BTN_DialogEnrolCancel.UseVisualStyleBackColor = true;
            // 
            // DGV_DialogEnrol
            // 
            this.DGV_DialogEnrol.AllowUserToAddRows = false;
            this.DGV_DialogEnrol.AllowUserToDeleteRows = false;
            this.DGV_DialogEnrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_DialogEnrol, 2);
            this.DGV_DialogEnrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DialogEnrol.Location = new System.Drawing.Point(3, 98);
            this.DGV_DialogEnrol.MultiSelect = false;
            this.DGV_DialogEnrol.Name = "DGV_DialogEnrol";
            this.DGV_DialogEnrol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DialogEnrol.Size = new System.Drawing.Size(920, 362);
            this.DGV_DialogEnrol.TabIndex = 0;
            this.DGV_DialogEnrol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DialogEnrol_CellContentClick);
            this.DGV_DialogEnrol.CurrentCellDirtyStateChanged += new System.EventHandler(this.DGV_DialogEnrol_CurrentCellDirtyStateChanged);
            this.DGV_DialogEnrol.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_DialogEnrol_DataBindingComplete);
            // 
            // LBL_DialogEnrolResults
            // 
            this.LBL_DialogEnrolResults.AutoSize = true;
            this.LBL_DialogEnrolResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DialogEnrolResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogEnrolResults.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LBL_DialogEnrolResults.Location = new System.Drawing.Point(5, 75);
            this.LBL_DialogEnrolResults.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DialogEnrolResults.Name = "LBL_DialogEnrolResults";
            this.LBL_DialogEnrolResults.Size = new System.Drawing.Size(916, 20);
            this.LBL_DialogEnrolResults.TabIndex = 0;
            this.LBL_DialogEnrolResults.Text = "Subject(s)";
            this.LBL_DialogEnrolResults.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogEnrol_Semester, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogEnrol_College, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogEnrol_Name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 75);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LBL_DialogEnrol_Semester
            // 
            this.LBL_DialogEnrol_Semester.AutoSize = true;
            this.LBL_DialogEnrol_Semester.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogEnrol_Semester.Location = new System.Drawing.Point(141, 48);
            this.LBL_DialogEnrol_Semester.Name = "LBL_DialogEnrol_Semester";
            this.LBL_DialogEnrol_Semester.Size = new System.Drawing.Size(164, 24);
            this.LBL_DialogEnrol_Semester.TabIndex = 0;
            this.LBL_DialogEnrol_Semester.Text = "year and semester";
            // 
            // LBL_DialogEnrol_College
            // 
            this.LBL_DialogEnrol_College.AutoSize = true;
            this.LBL_DialogEnrol_College.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogEnrol_College.Location = new System.Drawing.Point(141, 24);
            this.LBL_DialogEnrol_College.Name = "LBL_DialogEnrol_College";
            this.LBL_DialogEnrol_College.Size = new System.Drawing.Size(68, 24);
            this.LBL_DialogEnrol_College.TabIndex = 0;
            this.LBL_DialogEnrol_College.Text = "college";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Semester:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "College:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBL_DialogEnrol_Name
            // 
            this.LBL_DialogEnrol_Name.AutoSize = true;
            this.LBL_DialogEnrol_Name.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogEnrol_Name.Location = new System.Drawing.Point(141, 0);
            this.LBL_DialogEnrol_Name.Name = "LBL_DialogEnrol_Name";
            this.LBL_DialogEnrol_Name.Size = new System.Drawing.Size(127, 24);
            this.LBL_DialogEnrol_Name.TabIndex = 0;
            this.LBL_DialogEnrol_Name.Text = "student name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DialogEnrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "DialogEnrol";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Enrol Student in a Course";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogEnrol)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_DialogEnrol_Name;
        private System.Windows.Forms.Label LBL_DialogEnrolResults;
        private System.Windows.Forms.DataGridView DGV_DialogEnrol;
        private System.Windows.Forms.Button BTN_DialogEnrolCancel;
        private System.Windows.Forms.Label LBL_DialogEnrol_Semester;
        private System.Windows.Forms.Label LBL_DialogEnrol_College;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}