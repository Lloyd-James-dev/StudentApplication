namespace StudentApplication.Dialogs {
    partial class DialogCollegeCourse {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogCollegeCourse));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGV_DialogCollegeCourse = new System.Windows.Forms.DataGridView();
            this.LBL_DialogCollegeCourse_Results = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_DialogCollegeCourse_Semester = new System.Windows.Forms.Label();
            this.LBL_DialogCollegeCourse_College = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogCollegeCourseAdd = new System.Windows.Forms.Button();
            this.BTN_DialogCollegeCourseCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogCollegeCourse)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.groupBox1.Text = "Make a Course available at a College";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DGV_DialogCollegeCourse, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogCollegeCourse_Results, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGV_DialogCollegeCourse
            // 
            this.DGV_DialogCollegeCourse.AllowUserToAddRows = false;
            this.DGV_DialogCollegeCourse.AllowUserToDeleteRows = false;
            this.DGV_DialogCollegeCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_DialogCollegeCourse, 2);
            this.DGV_DialogCollegeCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DialogCollegeCourse.Location = new System.Drawing.Point(3, 73);
            this.DGV_DialogCollegeCourse.MultiSelect = false;
            this.DGV_DialogCollegeCourse.Name = "DGV_DialogCollegeCourse";
            this.DGV_DialogCollegeCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DialogCollegeCourse.Size = new System.Drawing.Size(920, 387);
            this.DGV_DialogCollegeCourse.TabIndex = 0;
            // 
            // LBL_DialogCollegeCourse_Results
            // 
            this.LBL_DialogCollegeCourse_Results.AutoSize = true;
            this.LBL_DialogCollegeCourse_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DialogCollegeCourse_Results.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCollegeCourse_Results.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LBL_DialogCollegeCourse_Results.Location = new System.Drawing.Point(5, 50);
            this.LBL_DialogCollegeCourse_Results.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DialogCollegeCourse_Results.Name = "LBL_DialogCollegeCourse_Results";
            this.LBL_DialogCollegeCourse_Results.Size = new System.Drawing.Size(916, 20);
            this.LBL_DialogCollegeCourse_Results.TabIndex = 0;
            this.LBL_DialogCollegeCourse_Results.Text = "Course(s)";
            this.LBL_DialogCollegeCourse_Results.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogCollegeCourse_Semester, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogCollegeCourse_College, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LBL_DialogCollegeCourse_Semester
            // 
            this.LBL_DialogCollegeCourse_Semester.AutoSize = true;
            this.LBL_DialogCollegeCourse_Semester.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCollegeCourse_Semester.Location = new System.Drawing.Point(141, 25);
            this.LBL_DialogCollegeCourse_Semester.Name = "LBL_DialogCollegeCourse_Semester";
            this.LBL_DialogCollegeCourse_Semester.Size = new System.Drawing.Size(164, 24);
            this.LBL_DialogCollegeCourse_Semester.TabIndex = 0;
            this.LBL_DialogCollegeCourse_Semester.Text = "year and semester";
            // 
            // LBL_DialogCollegeCourse_College
            // 
            this.LBL_DialogCollegeCourse_College.AutoSize = true;
            this.LBL_DialogCollegeCourse_College.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCollegeCourse_College.Location = new System.Drawing.Point(141, 0);
            this.LBL_DialogCollegeCourse_College.Name = "LBL_DialogCollegeCourse_College";
            this.LBL_DialogCollegeCourse_College.Size = new System.Drawing.Size(68, 24);
            this.LBL_DialogCollegeCourse_College.TabIndex = 0;
            this.LBL_DialogCollegeCourse_College.Text = "college";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 25);
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
            this.label2.Location = new System.Drawing.Point(58, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "College:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogCollegeCourseAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogCollegeCourseCancel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 463);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(926, 50);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BTN_DialogCollegeCourseAdd
            // 
            this.BTN_DialogCollegeCourseAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogCollegeCourseAdd.AutoSize = true;
            this.BTN_DialogCollegeCourseAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_DialogCollegeCourseAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogCollegeCourseAdd.Location = new System.Drawing.Point(806, 8);
            this.BTN_DialogCollegeCourseAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogCollegeCourseAdd.Name = "BTN_DialogCollegeCourseAdd";
            this.BTN_DialogCollegeCourseAdd.Size = new System.Drawing.Size(115, 33);
            this.BTN_DialogCollegeCourseAdd.TabIndex = 1;
            this.BTN_DialogCollegeCourseAdd.Text = "Assign Course";
            this.BTN_DialogCollegeCourseAdd.UseVisualStyleBackColor = true;
            this.BTN_DialogCollegeCourseAdd.Click += new System.EventHandler(this.BTN_DialogCollegeCourseAdd_Click);
            // 
            // BTN_DialogCollegeCourseCancel
            // 
            this.BTN_DialogCollegeCourseCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_DialogCollegeCourseCancel.AutoSize = true;
            this.BTN_DialogCollegeCourseCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_DialogCollegeCourseCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogCollegeCourseCancel.Location = new System.Drawing.Point(5, 8);
            this.BTN_DialogCollegeCourseCancel.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogCollegeCourseCancel.Name = "BTN_DialogCollegeCourseCancel";
            this.BTN_DialogCollegeCourseCancel.Size = new System.Drawing.Size(82, 33);
            this.BTN_DialogCollegeCourseCancel.TabIndex = 2;
            this.BTN_DialogCollegeCourseCancel.Text = "Cancel";
            this.BTN_DialogCollegeCourseCancel.UseVisualStyleBackColor = true;
            // 
            // DialogCollegeCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "DialogCollegeCourse";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Make a Course available at a College";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogCollegeCourse)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_DialogCollegeCourse_College;
        private System.Windows.Forms.Label LBL_DialogCollegeCourse_Semester;
        private System.Windows.Forms.Label LBL_DialogCollegeCourse_Results;
        private System.Windows.Forms.DataGridView DGV_DialogCollegeCourse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BTN_DialogCollegeCourseCancel;
        private System.Windows.Forms.Button BTN_DialogCollegeCourseAdd;
    }
}