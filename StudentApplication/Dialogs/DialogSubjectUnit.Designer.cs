namespace StudentApplication.Dialogs {
    partial class DialogSubjectUnit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSubjectUnit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGV_DialogSubjectUnit = new System.Windows.Forms.DataGridView();
            this.LBL_DialogSubjectUnitResults = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_DialogSubjectUnit_Semester = new System.Windows.Forms.Label();
            this.LBL_DialogSubjectUnit_College = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_DialogSubjectUnit_Course = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogSubjectUnitAdd = new System.Windows.Forms.Button();
            this.BTN_DialogSubjectUnitDeleteAll = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogSubjectUnit)).BeginInit();
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
            this.groupBox1.Text = "Assign Units Associated with a Course to Subjects Taught";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DGV_DialogSubjectUnit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogSubjectUnitResults, 0, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGV_DialogSubjectUnit
            // 
            this.DGV_DialogSubjectUnit.AllowUserToAddRows = false;
            this.DGV_DialogSubjectUnit.AllowUserToDeleteRows = false;
            this.DGV_DialogSubjectUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_DialogSubjectUnit, 3);
            this.DGV_DialogSubjectUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DialogSubjectUnit.Location = new System.Drawing.Point(3, 98);
            this.DGV_DialogSubjectUnit.MultiSelect = false;
            this.DGV_DialogSubjectUnit.Name = "DGV_DialogSubjectUnit";
            this.DGV_DialogSubjectUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DialogSubjectUnit.Size = new System.Drawing.Size(920, 362);
            this.DGV_DialogSubjectUnit.TabIndex = 0;
            this.DGV_DialogSubjectUnit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DialogSubjectUnit_CellContentClick);
            this.DGV_DialogSubjectUnit.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_DialogSubjectUnit_DataBindingComplete);
            // 
            // LBL_DialogSubjectUnitResults
            // 
            this.LBL_DialogSubjectUnitResults.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LBL_DialogSubjectUnitResults, 2);
            this.LBL_DialogSubjectUnitResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DialogSubjectUnitResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogSubjectUnitResults.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LBL_DialogSubjectUnitResults.Location = new System.Drawing.Point(5, 75);
            this.LBL_DialogSubjectUnitResults.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DialogSubjectUnitResults.Name = "LBL_DialogSubjectUnitResults";
            this.LBL_DialogSubjectUnitResults.Size = new System.Drawing.Size(916, 20);
            this.LBL_DialogSubjectUnitResults.TabIndex = 0;
            this.LBL_DialogSubjectUnitResults.Text = "Unit(s)";
            this.LBL_DialogSubjectUnitResults.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogSubjectUnit_Semester, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogSubjectUnit_College, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogSubjectUnit_Course, 1, 0);
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
            // LBL_DialogSubjectUnit_Semester
            // 
            this.LBL_DialogSubjectUnit_Semester.AutoSize = true;
            this.LBL_DialogSubjectUnit_Semester.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogSubjectUnit_Semester.Location = new System.Drawing.Point(141, 48);
            this.LBL_DialogSubjectUnit_Semester.Name = "LBL_DialogSubjectUnit_Semester";
            this.LBL_DialogSubjectUnit_Semester.Size = new System.Drawing.Size(164, 24);
            this.LBL_DialogSubjectUnit_Semester.TabIndex = 0;
            this.LBL_DialogSubjectUnit_Semester.Text = "year and semester";
            // 
            // LBL_DialogSubjectUnit_College
            // 
            this.LBL_DialogSubjectUnit_College.AutoSize = true;
            this.LBL_DialogSubjectUnit_College.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogSubjectUnit_College.Location = new System.Drawing.Point(141, 24);
            this.LBL_DialogSubjectUnit_College.Name = "LBL_DialogSubjectUnit_College";
            this.LBL_DialogSubjectUnit_College.Size = new System.Drawing.Size(68, 24);
            this.LBL_DialogSubjectUnit_College.TabIndex = 0;
            this.LBL_DialogSubjectUnit_College.Text = "college";
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
            // LBL_DialogSubjectUnit_Course
            // 
            this.LBL_DialogSubjectUnit_Course.AutoSize = true;
            this.LBL_DialogSubjectUnit_Course.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogSubjectUnit_Course.Location = new System.Drawing.Point(141, 0);
            this.LBL_DialogSubjectUnit_Course.Name = "LBL_DialogSubjectUnit_Course";
            this.LBL_DialogSubjectUnit_Course.Size = new System.Drawing.Size(117, 24);
            this.LBL_DialogSubjectUnit_Course.TabIndex = 0;
            this.LBL_DialogSubjectUnit_Course.Text = "course name";
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
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogSubjectUnitAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogSubjectUnitDeleteAll, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 463);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(926, 50);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BTN_DialogSubjectUnitAdd
            // 
            this.BTN_DialogSubjectUnitAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogSubjectUnitAdd.AutoSize = true;
            this.BTN_DialogSubjectUnitAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogSubjectUnitAdd.Location = new System.Drawing.Point(790, 8);
            this.BTN_DialogSubjectUnitAdd.Name = "BTN_DialogSubjectUnitAdd";
            this.BTN_DialogSubjectUnitAdd.Size = new System.Drawing.Size(133, 33);
            this.BTN_DialogSubjectUnitAdd.TabIndex = 1;
            this.BTN_DialogSubjectUnitAdd.Text = "Apply Changes";
            this.BTN_DialogSubjectUnitAdd.UseVisualStyleBackColor = true;
            this.BTN_DialogSubjectUnitAdd.Click += new System.EventHandler(this.BTN_DialogSubjectUnitAdd_Click);
            // 
            // BTN_DialogSubjectUnitDeleteAll
            // 
            this.BTN_DialogSubjectUnitDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_DialogSubjectUnitDeleteAll.AutoSize = true;
            this.BTN_DialogSubjectUnitDeleteAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogSubjectUnitDeleteAll.Location = new System.Drawing.Point(418, 8);
            this.BTN_DialogSubjectUnitDeleteAll.Name = "BTN_DialogSubjectUnitDeleteAll";
            this.BTN_DialogSubjectUnitDeleteAll.Size = new System.Drawing.Size(88, 33);
            this.BTN_DialogSubjectUnitDeleteAll.TabIndex = 0;
            this.BTN_DialogSubjectUnitDeleteAll.TabStop = false;
            this.BTN_DialogSubjectUnitDeleteAll.Text = "DeleteAll";
            this.BTN_DialogSubjectUnitDeleteAll.UseVisualStyleBackColor = true;
            this.BTN_DialogSubjectUnitDeleteAll.Click += new System.EventHandler(this.BTN_DialogSubjectUnitDeleteAll_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.AutoSize = true;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DialogSubjectUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "DialogSubjectUnit";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Assign Units Associated with a Course to Subjects Taught";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogSubjectUnit)).EndInit();
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
        private System.Windows.Forms.Label LBL_DialogSubjectUnit_Semester;
        private System.Windows.Forms.Label LBL_DialogSubjectUnit_College;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_DialogSubjectUnit_Course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LBL_DialogSubjectUnitResults;
        public System.Windows.Forms.DataGridView DGV_DialogSubjectUnit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_DialogSubjectUnitDeleteAll;
        private System.Windows.Forms.Button BTN_DialogSubjectUnitAdd;
    }
}