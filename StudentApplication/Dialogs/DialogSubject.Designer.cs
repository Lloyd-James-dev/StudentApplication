namespace StudentApplication.Dialogs {
    partial class DialogSubject {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSubject));
            this.GRPBOX_Subject = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TXT_DialogSubjectName = new System.Windows.Forms.TextBox();
            this.LBL_DialogSubjectId = new System.Windows.Forms.Label();
            this.LBL_DialogCollegeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogSubjectAdd = new System.Windows.Forms.Button();
            this.BTN_DialogSubjectCancel = new System.Windows.Forms.Button();
            this.GRPBOX_Subject.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPBOX_Subject
            // 
            this.GRPBOX_Subject.Controls.Add(this.tableLayoutPanel1);
            this.GRPBOX_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRPBOX_Subject.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPBOX_Subject.Location = new System.Drawing.Point(6, 3);
            this.GRPBOX_Subject.Name = "GRPBOX_Subject";
            this.GRPBOX_Subject.Size = new System.Drawing.Size(572, 255);
            this.GRPBOX_Subject.TabIndex = 0;
            this.GRPBOX_Subject.TabStop = false;
            this.GRPBOX_Subject.Text = "Add Subject";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.TXT_DialogSubjectName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogSubjectId, 1, 0);
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
            // TXT_DialogSubjectName
            // 
            this.TXT_DialogSubjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_DialogSubjectName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DialogSubjectName.Location = new System.Drawing.Point(146, 74);
            this.TXT_DialogSubjectName.Margin = new System.Windows.Forms.Padding(5);
            this.TXT_DialogSubjectName.Name = "TXT_DialogSubjectName";
            this.TXT_DialogSubjectName.Size = new System.Drawing.Size(415, 27);
            this.TXT_DialogSubjectName.TabIndex = 1;
            this.TXT_DialogSubjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_onKeyEnter);
            // 
            // LBL_DialogSubjectId
            // 
            this.LBL_DialogSubjectId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_DialogSubjectId.AutoSize = true;
            this.LBL_DialogSubjectId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogSubjectId.Location = new System.Drawing.Point(144, 25);
            this.LBL_DialogSubjectId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LBL_DialogSubjectId.Name = "LBL_DialogSubjectId";
            this.LBL_DialogSubjectId.Size = new System.Drawing.Size(141, 23);
            this.LBL_DialogSubjectId.TabIndex = 0;
            this.LBL_DialogSubjectId.Text = "(auto-generated)";
            this.LBL_DialogSubjectId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_DialogCollegeName
            // 
            this.LBL_DialogCollegeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_DialogCollegeName.AutoSize = true;
            this.LBL_DialogCollegeName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCollegeName.Location = new System.Drawing.Point(17, 78);
            this.LBL_DialogCollegeName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LBL_DialogCollegeName.Name = "LBL_DialogCollegeName";
            this.LBL_DialogCollegeName.Size = new System.Drawing.Size(121, 23);
            this.LBL_DialogCollegeName.TabIndex = 0;
            this.LBL_DialogCollegeName.Text = "Subject Name:";
            this.LBL_DialogCollegeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_DialogSubjectAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_DialogSubjectCancel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(141, 159);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(425, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BTN_DialogSubjectAdd
            // 
            this.BTN_DialogSubjectAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogSubjectAdd.AutoSize = true;
            this.BTN_DialogSubjectAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_DialogSubjectAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogSubjectAdd.Location = new System.Drawing.Point(305, 10);
            this.BTN_DialogSubjectAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogSubjectAdd.Name = "BTN_DialogSubjectAdd";
            this.BTN_DialogSubjectAdd.Size = new System.Drawing.Size(115, 33);
            this.BTN_DialogSubjectAdd.TabIndex = 1;
            this.BTN_DialogSubjectAdd.Text = "Add Subject";
            this.BTN_DialogSubjectAdd.UseVisualStyleBackColor = true;
            this.BTN_DialogSubjectAdd.Click += new System.EventHandler(this.BTN_DialogSubjectAdd_Click);
            // 
            // BTN_DialogSubjectCancel
            // 
            this.BTN_DialogSubjectCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_DialogSubjectCancel.AutoSize = true;
            this.BTN_DialogSubjectCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_DialogSubjectCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogSubjectCancel.Location = new System.Drawing.Point(5, 10);
            this.BTN_DialogSubjectCancel.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogSubjectCancel.Name = "BTN_DialogSubjectCancel";
            this.BTN_DialogSubjectCancel.Size = new System.Drawing.Size(82, 33);
            this.BTN_DialogSubjectCancel.TabIndex = 2;
            this.BTN_DialogSubjectCancel.Text = "Cancel";
            this.BTN_DialogSubjectCancel.UseVisualStyleBackColor = true;
            // 
            // DialogSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.GRPBOX_Subject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "DialogSubject";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Add Subject";
            this.GRPBOX_Subject.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPBOX_Subject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LBL_DialogCollegeName;
        private System.Windows.Forms.Label LBL_DialogSubjectId;
        private System.Windows.Forms.TextBox TXT_DialogSubjectName;
        private System.Windows.Forms.Button BTN_DialogSubjectCancel;
        private System.Windows.Forms.Button BTN_DialogSubjectAdd;
    }
}