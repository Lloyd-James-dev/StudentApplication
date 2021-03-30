namespace StudentApplication.Dialogs {
    partial class DialogCourseSubject {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogCourseSubject));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGV_DialogCourseSubject = new System.Windows.Forms.DataGridView();
            this.LBL_DialogCourseSubjectResults = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_DialogCourseSubject_Semester = new System.Windows.Forms.Label();
            this.LBL_DialogCourseSubject_College = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_DialogCourseSubject_Course = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogCourseSubjectAdd = new System.Windows.Forms.Button();
            this.BTN_DialogCourseSubjectCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogCourseSubject)).BeginInit();
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
            this.groupBox1.Text = "Link Subjects with a Course and Assign Teachers";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DGV_DialogCourseSubject, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogCourseSubjectResults, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
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
            // DGV_DialogCourseSubject
            // 
            this.DGV_DialogCourseSubject.AllowUserToAddRows = false;
            this.DGV_DialogCourseSubject.AllowUserToDeleteRows = false;
            this.DGV_DialogCourseSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_DialogCourseSubject, 2);
            this.DGV_DialogCourseSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DialogCourseSubject.Location = new System.Drawing.Point(3, 98);
            this.DGV_DialogCourseSubject.Name = "DGV_DialogCourseSubject";
            this.DGV_DialogCourseSubject.Size = new System.Drawing.Size(920, 362);
            this.DGV_DialogCourseSubject.TabIndex = 0;
            this.DGV_DialogCourseSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DialogCourseSubject_CellContentClick);
            this.DGV_DialogCourseSubject.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_DialogCourseSubject_DataBindingComplete);
            // 
            // LBL_DialogCourseSubjectResults
            // 
            this.LBL_DialogCourseSubjectResults.AutoSize = true;
            this.LBL_DialogCourseSubjectResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DialogCourseSubjectResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCourseSubjectResults.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LBL_DialogCourseSubjectResults.Location = new System.Drawing.Point(5, 75);
            this.LBL_DialogCourseSubjectResults.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DialogCourseSubjectResults.Name = "LBL_DialogCourseSubjectResults";
            this.LBL_DialogCourseSubjectResults.Size = new System.Drawing.Size(916, 20);
            this.LBL_DialogCourseSubjectResults.TabIndex = 0;
            this.LBL_DialogCourseSubjectResults.Text = "Subject(s)";
            this.LBL_DialogCourseSubjectResults.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogCourseSubject_Semester, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogCourseSubject_College, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogCourseSubject_Course, 1, 0);
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
            // LBL_DialogCourseSubject_Semester
            // 
            this.LBL_DialogCourseSubject_Semester.AutoSize = true;
            this.LBL_DialogCourseSubject_Semester.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCourseSubject_Semester.Location = new System.Drawing.Point(141, 48);
            this.LBL_DialogCourseSubject_Semester.Name = "LBL_DialogCourseSubject_Semester";
            this.LBL_DialogCourseSubject_Semester.Size = new System.Drawing.Size(164, 24);
            this.LBL_DialogCourseSubject_Semester.TabIndex = 0;
            this.LBL_DialogCourseSubject_Semester.Text = "year and semester";
            // 
            // LBL_DialogCourseSubject_College
            // 
            this.LBL_DialogCourseSubject_College.AutoSize = true;
            this.LBL_DialogCourseSubject_College.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCourseSubject_College.Location = new System.Drawing.Point(141, 24);
            this.LBL_DialogCourseSubject_College.Name = "LBL_DialogCourseSubject_College";
            this.LBL_DialogCourseSubject_College.Size = new System.Drawing.Size(68, 24);
            this.LBL_DialogCourseSubject_College.TabIndex = 0;
            this.LBL_DialogCourseSubject_College.Text = "college";
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
            // LBL_DialogCourseSubject_Course
            // 
            this.LBL_DialogCourseSubject_Course.AutoSize = true;
            this.LBL_DialogCourseSubject_Course.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCourseSubject_Course.Location = new System.Drawing.Point(141, 0);
            this.LBL_DialogCourseSubject_Course.Name = "LBL_DialogCourseSubject_Course";
            this.LBL_DialogCourseSubject_Course.Size = new System.Drawing.Size(117, 24);
            this.LBL_DialogCourseSubject_Course.TabIndex = 0;
            this.LBL_DialogCourseSubject_Course.Text = "course name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogCourseSubjectAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogCourseSubjectCancel, 0, 0);
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
            // BTN_DialogCourseSubjectAdd
            // 
            this.BTN_DialogCourseSubjectAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogCourseSubjectAdd.AutoSize = true;
            this.BTN_DialogCourseSubjectAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogCourseSubjectAdd.Location = new System.Drawing.Point(806, 8);
            this.BTN_DialogCourseSubjectAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogCourseSubjectAdd.Name = "BTN_DialogCourseSubjectAdd";
            this.BTN_DialogCourseSubjectAdd.Size = new System.Drawing.Size(115, 33);
            this.BTN_DialogCourseSubjectAdd.TabIndex = 1;
            this.BTN_DialogCourseSubjectAdd.Text = "Link Subjects";
            this.BTN_DialogCourseSubjectAdd.UseVisualStyleBackColor = true;
            this.BTN_DialogCourseSubjectAdd.Click += new System.EventHandler(this.BTN_DialogCourseSubjectAdd_Click);
            // 
            // BTN_DialogCourseSubjectCancel
            // 
            this.BTN_DialogCourseSubjectCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_DialogCourseSubjectCancel.AutoSize = true;
            this.BTN_DialogCourseSubjectCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_DialogCourseSubjectCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogCourseSubjectCancel.Location = new System.Drawing.Point(5, 8);
            this.BTN_DialogCourseSubjectCancel.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogCourseSubjectCancel.Name = "BTN_DialogCourseSubjectCancel";
            this.BTN_DialogCourseSubjectCancel.Size = new System.Drawing.Size(82, 33);
            this.BTN_DialogCourseSubjectCancel.TabIndex = 2;
            this.BTN_DialogCourseSubjectCancel.Text = "Cancel";
            this.BTN_DialogCourseSubjectCancel.UseVisualStyleBackColor = true;
            // 
            // DialogCourseSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "DialogCourseSubject";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Link Subjects with a Course and Assign Teachers";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogCourseSubject)).EndInit();
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
        private System.Windows.Forms.Label LBL_DialogCourseSubject_Semester;
        private System.Windows.Forms.Label LBL_DialogCourseSubject_College;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_DialogCourseSubject_Course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_DialogCourseSubjectResults;
        private System.Windows.Forms.DataGridView DGV_DialogCourseSubject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BTN_DialogCourseSubjectCancel;
        private System.Windows.Forms.Button BTN_DialogCourseSubjectAdd;
    }
}