namespace StudentApplication.Dialogs {
    partial class DialogRegister {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogRegister));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGV_DialogRegister = new System.Windows.Forms.DataGridView();
            this.LBL_DialogRegisterResults = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_DialogRegister_SemesterValue = new System.Windows.Forms.Label();
            this.LBL_DialogRegister_Semester = new System.Windows.Forms.Label();
            this.LBL_DialogRegister_Value = new System.Windows.Forms.Label();
            this.LBL_DialogRegister_Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogRegisterAdd = new System.Windows.Forms.Button();
            this.BTN_DialogRegisterCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogRegister)).BeginInit();
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
            this.groupBox1.Text = "Register a Student at a College";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DGV_DialogRegister, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogRegisterResults, 0, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGV_DialogRegister
            // 
            this.DGV_DialogRegister.AllowUserToAddRows = false;
            this.DGV_DialogRegister.AllowUserToDeleteRows = false;
            this.DGV_DialogRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DialogRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DialogRegister.Location = new System.Drawing.Point(3, 73);
            this.DGV_DialogRegister.MultiSelect = false;
            this.DGV_DialogRegister.Name = "DGV_DialogRegister";
            this.DGV_DialogRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DialogRegister.Size = new System.Drawing.Size(920, 387);
            this.DGV_DialogRegister.TabIndex = 0;
            // 
            // LBL_DialogRegisterResults
            // 
            this.LBL_DialogRegisterResults.AutoSize = true;
            this.LBL_DialogRegisterResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DialogRegisterResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogRegisterResults.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LBL_DialogRegisterResults.Location = new System.Drawing.Point(5, 50);
            this.LBL_DialogRegisterResults.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DialogRegisterResults.Name = "LBL_DialogRegisterResults";
            this.LBL_DialogRegisterResults.Size = new System.Drawing.Size(916, 20);
            this.LBL_DialogRegisterResults.TabIndex = 0;
            this.LBL_DialogRegisterResults.Text = "Subject(s)";
            this.LBL_DialogRegisterResults.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogRegister_SemesterValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogRegister_Semester, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogRegister_Value, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LBL_DialogRegister_Name, 0, 0);
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
            // LBL_DialogRegister_SemesterValue
            // 
            this.LBL_DialogRegister_SemesterValue.AutoSize = true;
            this.LBL_DialogRegister_SemesterValue.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogRegister_SemesterValue.Location = new System.Drawing.Point(141, 25);
            this.LBL_DialogRegister_SemesterValue.Name = "LBL_DialogRegister_SemesterValue";
            this.LBL_DialogRegister_SemesterValue.Size = new System.Drawing.Size(57, 24);
            this.LBL_DialogRegister_SemesterValue.TabIndex = 0;
            this.LBL_DialogRegister_SemesterValue.Text = "name";
            this.LBL_DialogRegister_SemesterValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_DialogRegister_Semester
            // 
            this.LBL_DialogRegister_Semester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_DialogRegister_Semester.AutoSize = true;
            this.LBL_DialogRegister_Semester.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogRegister_Semester.Location = new System.Drawing.Point(42, 25);
            this.LBL_DialogRegister_Semester.Name = "LBL_DialogRegister_Semester";
            this.LBL_DialogRegister_Semester.Size = new System.Drawing.Size(93, 24);
            this.LBL_DialogRegister_Semester.TabIndex = 0;
            this.LBL_DialogRegister_Semester.Text = "Semester:";
            this.LBL_DialogRegister_Semester.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBL_DialogRegister_Value
            // 
            this.LBL_DialogRegister_Value.AutoSize = true;
            this.LBL_DialogRegister_Value.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogRegister_Value.Location = new System.Drawing.Point(141, 0);
            this.LBL_DialogRegister_Value.Name = "LBL_DialogRegister_Value";
            this.LBL_DialogRegister_Value.Size = new System.Drawing.Size(57, 24);
            this.LBL_DialogRegister_Value.TabIndex = 0;
            this.LBL_DialogRegister_Value.Text = "name";
            this.LBL_DialogRegister_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_DialogRegister_Name
            // 
            this.LBL_DialogRegister_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_DialogRegister_Name.AutoSize = true;
            this.LBL_DialogRegister_Name.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogRegister_Name.Location = new System.Drawing.Point(53, 0);
            this.LBL_DialogRegister_Name.Name = "LBL_DialogRegister_Name";
            this.LBL_DialogRegister_Name.Size = new System.Drawing.Size(82, 24);
            this.LBL_DialogRegister_Name.TabIndex = 0;
            this.LBL_DialogRegister_Name.Text = "Student:";
            this.LBL_DialogRegister_Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogRegisterAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_DialogRegisterCancel, 0, 0);
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
            // BTN_DialogRegisterAdd
            // 
            this.BTN_DialogRegisterAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogRegisterAdd.AutoSize = true;
            this.BTN_DialogRegisterAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_DialogRegisterAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogRegisterAdd.Location = new System.Drawing.Point(808, 8);
            this.BTN_DialogRegisterAdd.Name = "BTN_DialogRegisterAdd";
            this.BTN_DialogRegisterAdd.Size = new System.Drawing.Size(115, 33);
            this.BTN_DialogRegisterAdd.TabIndex = 1;
            this.BTN_DialogRegisterAdd.Text = "Submit";
            this.BTN_DialogRegisterAdd.UseVisualStyleBackColor = true;
            this.BTN_DialogRegisterAdd.Click += new System.EventHandler(this.BTN_DialogRegisterAdd_Click);
            // 
            // BTN_DialogRegisterCancel
            // 
            this.BTN_DialogRegisterCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_DialogRegisterCancel.AutoSize = true;
            this.BTN_DialogRegisterCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_DialogRegisterCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogRegisterCancel.Location = new System.Drawing.Point(3, 8);
            this.BTN_DialogRegisterCancel.Name = "BTN_DialogRegisterCancel";
            this.BTN_DialogRegisterCancel.Size = new System.Drawing.Size(82, 33);
            this.BTN_DialogRegisterCancel.TabIndex = 2;
            this.BTN_DialogRegisterCancel.Text = "Cancel";
            this.BTN_DialogRegisterCancel.UseVisualStyleBackColor = true;
            // 
            // DialogRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "DialogRegister";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Register a Student at a College";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DialogRegister)).EndInit();
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
        private System.Windows.Forms.Label LBL_DialogRegister_Name;
        private System.Windows.Forms.Label LBL_DialogRegister_Value;
        private System.Windows.Forms.Label LBL_DialogRegisterResults;
        private System.Windows.Forms.DataGridView DGV_DialogRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BTN_DialogRegisterCancel;
        private System.Windows.Forms.Button BTN_DialogRegisterAdd;
        private System.Windows.Forms.Label LBL_DialogRegister_SemesterValue;
        private System.Windows.Forms.Label LBL_DialogRegister_Semester;
    }
}