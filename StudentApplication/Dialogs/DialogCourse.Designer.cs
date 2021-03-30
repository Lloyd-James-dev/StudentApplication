namespace StudentApplication.Dialogs {
    partial class DialogCourse {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogCourse));
            this.GRPBOX_Course = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TXT_DialogCourseFee = new System.Windows.Forms.TextBox();
            this.TXT_DialogCourseName = new System.Windows.Forms.TextBox();
            this.TXT_DialogCourseCode = new System.Windows.Forms.TextBox();
            this.LBL_DialogAdminAddress = new System.Windows.Forms.Label();
            this.LBL_DialogCollegeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogCourseAdd = new System.Windows.Forms.Button();
            this.BTN_DialogCourseCancel = new System.Windows.Forms.Button();
            this.GRPBOX_Course.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPBOX_Course
            // 
            this.GRPBOX_Course.Controls.Add(this.tableLayoutPanel1);
            this.GRPBOX_Course.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRPBOX_Course.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPBOX_Course.Location = new System.Drawing.Point(6, 3);
            this.GRPBOX_Course.Name = "GRPBOX_Course";
            this.GRPBOX_Course.Size = new System.Drawing.Size(572, 255);
            this.GRPBOX_Course.TabIndex = 0;
            this.GRPBOX_Course.TabStop = false;
            this.GRPBOX_Course.Text = "Add Course";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.TXT_DialogCourseFee, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TXT_DialogCourseName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TXT_DialogCourseCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogAdminAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogCollegeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 213);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TXT_DialogCourseFee
            // 
            this.TXT_DialogCourseFee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_DialogCourseFee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DialogCourseFee.Location = new System.Drawing.Point(146, 127);
            this.TXT_DialogCourseFee.Margin = new System.Windows.Forms.Padding(5);
            this.TXT_DialogCourseFee.Name = "TXT_DialogCourseFee";
            this.TXT_DialogCourseFee.Size = new System.Drawing.Size(415, 27);
            this.TXT_DialogCourseFee.TabIndex = 3;
            this.TXT_DialogCourseFee.Text = "0.00";
            this.TXT_DialogCourseFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_DialogCourseFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_onKeyEnter);
            // 
            // TXT_DialogCourseName
            // 
            this.TXT_DialogCourseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_DialogCourseName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DialogCourseName.Location = new System.Drawing.Point(146, 74);
            this.TXT_DialogCourseName.Margin = new System.Windows.Forms.Padding(5);
            this.TXT_DialogCourseName.Name = "TXT_DialogCourseName";
            this.TXT_DialogCourseName.Size = new System.Drawing.Size(415, 27);
            this.TXT_DialogCourseName.TabIndex = 2;
            this.TXT_DialogCourseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_onKeyEnter);
            // 
            // TXT_DialogCourseCode
            // 
            this.TXT_DialogCourseCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_DialogCourseCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DialogCourseCode.Location = new System.Drawing.Point(146, 21);
            this.TXT_DialogCourseCode.Margin = new System.Windows.Forms.Padding(5);
            this.TXT_DialogCourseCode.Name = "TXT_DialogCourseCode";
            this.TXT_DialogCourseCode.Size = new System.Drawing.Size(415, 27);
            this.TXT_DialogCourseCode.TabIndex = 1;
            this.TXT_DialogCourseCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_onKeyEnter);
            // 
            // LBL_DialogAdminAddress
            // 
            this.LBL_DialogAdminAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_DialogAdminAddress.AutoSize = true;
            this.LBL_DialogAdminAddress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogAdminAddress.Location = new System.Drawing.Point(96, 131);
            this.LBL_DialogAdminAddress.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LBL_DialogAdminAddress.Name = "LBL_DialogAdminAddress";
            this.LBL_DialogAdminAddress.Size = new System.Drawing.Size(42, 23);
            this.LBL_DialogAdminAddress.TabIndex = 0;
            this.LBL_DialogAdminAddress.Text = "Fee:";
            this.LBL_DialogAdminAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_DialogCollegeName
            // 
            this.LBL_DialogCollegeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_DialogCollegeName.AutoSize = true;
            this.LBL_DialogCollegeName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCollegeName.Location = new System.Drawing.Point(20, 78);
            this.LBL_DialogCollegeName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LBL_DialogCollegeName.Name = "LBL_DialogCollegeName";
            this.LBL_DialogCollegeName.Size = new System.Drawing.Size(118, 23);
            this.LBL_DialogCollegeName.TabIndex = 0;
            this.LBL_DialogCollegeName.Text = "Course Name:";
            this.LBL_DialogCollegeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_DialogCourseAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_DialogCourseCancel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(141, 159);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(425, 54);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // BTN_DialogCourseAdd
            // 
            this.BTN_DialogCourseAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogCourseAdd.AutoSize = true;
            this.BTN_DialogCourseAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_DialogCourseAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogCourseAdd.Location = new System.Drawing.Point(305, 10);
            this.BTN_DialogCourseAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogCourseAdd.Name = "BTN_DialogCourseAdd";
            this.BTN_DialogCourseAdd.Size = new System.Drawing.Size(115, 33);
            this.BTN_DialogCourseAdd.TabIndex = 1;
            this.BTN_DialogCourseAdd.Text = "Add Course";
            this.BTN_DialogCourseAdd.UseVisualStyleBackColor = true;
            this.BTN_DialogCourseAdd.Click += new System.EventHandler(this.BTN_DialogCourseAdd_Click);
            // 
            // BTN_DialogCourseCancel
            // 
            this.BTN_DialogCourseCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_DialogCourseCancel.AutoSize = true;
            this.BTN_DialogCourseCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_DialogCourseCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogCourseCancel.Location = new System.Drawing.Point(5, 10);
            this.BTN_DialogCourseCancel.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogCourseCancel.Name = "BTN_DialogCourseCancel";
            this.BTN_DialogCourseCancel.Size = new System.Drawing.Size(82, 33);
            this.BTN_DialogCourseCancel.TabIndex = 2;
            this.BTN_DialogCourseCancel.Text = "Cancel";
            this.BTN_DialogCourseCancel.UseVisualStyleBackColor = true;
            // 
            // DialogCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.GRPBOX_Course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "DialogCourse";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Add Course";
            this.GRPBOX_Course.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPBOX_Course;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_DialogCollegeName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LBL_DialogAdminAddress;
        private System.Windows.Forms.TextBox TXT_DialogCourseCode;
        private System.Windows.Forms.TextBox TXT_DialogCourseName;
        private System.Windows.Forms.TextBox TXT_DialogCourseFee;
        private System.Windows.Forms.Button BTN_DialogCourseCancel;
        private System.Windows.Forms.Button BTN_DialogCourseAdd;
    }
}