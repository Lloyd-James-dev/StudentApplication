namespace StudentApplication.Dialogs {
    partial class DialogGrade {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogGrade));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGV_DialogGrade = new System.Windows.Forms.DataGridView();
            this.LBL_DialogGradeResults = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_DialogGrade_Course = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_DialogGrade_Semester = new System.Windows.Forms.Label();
            this.LBL_DialogGrade_College = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_DialogGrade_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogGradeAdd = new System.Windows.Forms.Button();
            this.BTN_DialogGradeCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogGrade)).BeginInit();
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
            this.groupBox1.Text = "Grade Student";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DGV_DialogGrade, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogGradeResults, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGV_DialogGrade
            // 
            this.DGV_DialogGrade.AllowUserToAddRows = false;
            this.DGV_DialogGrade.AllowUserToDeleteRows = false;
            this.DGV_DialogGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DialogGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DialogGrade.Location = new System.Drawing.Point(3, 123);
            this.DGV_DialogGrade.MultiSelect = false;
            this.DGV_DialogGrade.Name = "DGV_DialogGrade";
            this.DGV_DialogGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DialogGrade.Size = new System.Drawing.Size(920, 337);
            this.DGV_DialogGrade.TabIndex = 0;
            this.DGV_DialogGrade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DialogGrade_CellContentClick);
            this.DGV_DialogGrade.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGV_DialogGrade_DataError);
            // 
            // LBL_DialogGradeResults
            // 
            this.LBL_DialogGradeResults.AutoSize = true;
            this.LBL_DialogGradeResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DialogGradeResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogGradeResults.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LBL_DialogGradeResults.Location = new System.Drawing.Point(5, 100);
            this.LBL_DialogGradeResults.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DialogGradeResults.Name = "LBL_DialogGradeResults";
            this.LBL_DialogGradeResults.Size = new System.Drawing.Size(916, 20);
            this.LBL_DialogGradeResults.TabIndex = 0;
            this.LBL_DialogGradeResults.Text = "Subject(s)";
            this.LBL_DialogGradeResults.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogGrade_Course, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogGrade_Semester, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogGrade_College, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogGrade_Name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LBL_DialogGrade_Course
            // 
            this.LBL_DialogGrade_Course.AutoSize = true;
            this.LBL_DialogGrade_Course.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogGrade_Course.Location = new System.Drawing.Point(141, 75);
            this.LBL_DialogGrade_Course.Name = "LBL_DialogGrade_Course";
            this.LBL_DialogGrade_Course.Size = new System.Drawing.Size(199, 24);
            this.LBL_DialogGrade_Course.TabIndex = 0;
            this.LBL_DialogGrade_Course.Text = "course code and name";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Course:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBL_DialogGrade_Semester
            // 
            this.LBL_DialogGrade_Semester.AutoSize = true;
            this.LBL_DialogGrade_Semester.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogGrade_Semester.Location = new System.Drawing.Point(141, 50);
            this.LBL_DialogGrade_Semester.Name = "LBL_DialogGrade_Semester";
            this.LBL_DialogGrade_Semester.Size = new System.Drawing.Size(164, 24);
            this.LBL_DialogGrade_Semester.TabIndex = 0;
            this.LBL_DialogGrade_Semester.Text = "year and semester";
            // 
            // LBL_DialogGrade_College
            // 
            this.LBL_DialogGrade_College.AutoSize = true;
            this.LBL_DialogGrade_College.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogGrade_College.Location = new System.Drawing.Point(141, 25);
            this.LBL_DialogGrade_College.Name = "LBL_DialogGrade_College";
            this.LBL_DialogGrade_College.Size = new System.Drawing.Size(68, 24);
            this.LBL_DialogGrade_College.TabIndex = 0;
            this.LBL_DialogGrade_College.Text = "college";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 50);
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
            this.label2.Location = new System.Drawing.Point(58, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "College:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBL_DialogGrade_Name
            // 
            this.LBL_DialogGrade_Name.AutoSize = true;
            this.LBL_DialogGrade_Name.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogGrade_Name.Location = new System.Drawing.Point(141, 0);
            this.LBL_DialogGrade_Name.Name = "LBL_DialogGrade_Name";
            this.LBL_DialogGrade_Name.Size = new System.Drawing.Size(127, 24);
            this.LBL_DialogGrade_Name.TabIndex = 0;
            this.LBL_DialogGrade_Name.Text = "student name";
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogGradeAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogGradeCancel, 0, 0);
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
            // BTN_DialogGradeAdd
            // 
            this.BTN_DialogGradeAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogGradeAdd.AutoSize = true;
            this.BTN_DialogGradeAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_DialogGradeAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogGradeAdd.Location = new System.Drawing.Point(806, 8);
            this.BTN_DialogGradeAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogGradeAdd.Name = "BTN_DialogGradeAdd";
            this.BTN_DialogGradeAdd.Size = new System.Drawing.Size(115, 33);
            this.BTN_DialogGradeAdd.TabIndex = 1;
            this.BTN_DialogGradeAdd.Text = "Submit";
            this.BTN_DialogGradeAdd.UseVisualStyleBackColor = true;
            this.BTN_DialogGradeAdd.Click += new System.EventHandler(this.BTN_DialogGradeAdd_Click);
            // 
            // BTN_DialogGradeCancel
            // 
            this.BTN_DialogGradeCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_DialogGradeCancel.AutoSize = true;
            this.BTN_DialogGradeCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_DialogGradeCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogGradeCancel.Location = new System.Drawing.Point(5, 8);
            this.BTN_DialogGradeCancel.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogGradeCancel.Name = "BTN_DialogGradeCancel";
            this.BTN_DialogGradeCancel.Size = new System.Drawing.Size(82, 33);
            this.BTN_DialogGradeCancel.TabIndex = 2;
            this.BTN_DialogGradeCancel.Text = "Cancel";
            this.BTN_DialogGradeCancel.UseVisualStyleBackColor = true;
            // 
            // DialogGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "DialogGrade";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Grade Student";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogGrade)).EndInit();
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
        private System.Windows.Forms.Label LBL_DialogGrade_Course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_DialogGrade_Semester;
        private System.Windows.Forms.Label LBL_DialogGrade_College;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_DialogGrade_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_DialogGradeResults;
        private System.Windows.Forms.DataGridView DGV_DialogGrade;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BTN_DialogGradeCancel;
        private System.Windows.Forms.Button BTN_DialogGradeAdd;
    }
}