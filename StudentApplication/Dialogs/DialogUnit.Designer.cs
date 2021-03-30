namespace StudentApplication.Dialogs {
    partial class DialogUnit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogUnit));
            this.GRPBOX_Unit = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_DialogUnitDesc = new System.Windows.Forms.TextBox();
            this.TXT_DialogUnitCode = new System.Windows.Forms.TextBox();
            this.LBL_DialogCollegeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DialogUnitAdd = new System.Windows.Forms.Button();
            this.BTN_DialogUnitCancel = new System.Windows.Forms.Button();
            this.GRPBOX_Unit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPBOX_Unit
            // 
            this.GRPBOX_Unit.Controls.Add(this.tableLayoutPanel1);
            this.GRPBOX_Unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRPBOX_Unit.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRPBOX_Unit.Location = new System.Drawing.Point(6, 3);
            this.GRPBOX_Unit.Name = "GRPBOX_Unit";
            this.GRPBOX_Unit.Size = new System.Drawing.Size(572, 275);
            this.GRPBOX_Unit.TabIndex = 0;
            this.GRPBOX_Unit.TabStop = false;
            this.GRPBOX_Unit.Text = "Add Unit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TXT_DialogUnitDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TXT_DialogUnitCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_DialogCollegeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 233);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(146, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "(lines will be truncated)";
            // 
            // TXT_DialogUnitDesc
            // 
            this.TXT_DialogUnitDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_DialogUnitDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DialogUnitDesc.Location = new System.Drawing.Point(146, 58);
            this.TXT_DialogUnitDesc.Margin = new System.Windows.Forms.Padding(5);
            this.TXT_DialogUnitDesc.Multiline = true;
            this.TXT_DialogUnitDesc.Name = "TXT_DialogUnitDesc";
            this.tableLayoutPanel1.SetRowSpan(this.TXT_DialogUnitDesc, 2);
            this.TXT_DialogUnitDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_DialogUnitDesc.Size = new System.Drawing.Size(415, 96);
            this.TXT_DialogUnitDesc.TabIndex = 2;
            // 
            // TXT_DialogUnitCode
            // 
            this.TXT_DialogUnitCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_DialogUnitCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DialogUnitCode.Location = new System.Drawing.Point(146, 21);
            this.TXT_DialogUnitCode.Margin = new System.Windows.Forms.Padding(5);
            this.TXT_DialogUnitCode.Name = "TXT_DialogUnitCode";
            this.TXT_DialogUnitCode.Size = new System.Drawing.Size(415, 27);
            this.TXT_DialogUnitCode.TabIndex = 1;
            this.TXT_DialogUnitCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_onKeyEnter);
            // 
            // LBL_DialogCollegeName
            // 
            this.LBL_DialogCollegeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_DialogCollegeName.AutoSize = true;
            this.LBL_DialogCollegeName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DialogCollegeName.Location = new System.Drawing.Point(34, 78);
            this.LBL_DialogCollegeName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LBL_DialogCollegeName.Name = "LBL_DialogCollegeName";
            this.LBL_DialogCollegeName.Size = new System.Drawing.Size(104, 23);
            this.LBL_DialogCollegeName.TabIndex = 0;
            this.LBL_DialogCollegeName.Text = "Description:";
            this.LBL_DialogCollegeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_DialogUnitAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_DialogUnitCancel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(141, 179);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(425, 54);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // BTN_DialogUnitAdd
            // 
            this.BTN_DialogUnitAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_DialogUnitAdd.AutoSize = true;
            this.BTN_DialogUnitAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_DialogUnitAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogUnitAdd.Location = new System.Drawing.Point(305, 10);
            this.BTN_DialogUnitAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogUnitAdd.Name = "BTN_DialogUnitAdd";
            this.BTN_DialogUnitAdd.Size = new System.Drawing.Size(115, 33);
            this.BTN_DialogUnitAdd.TabIndex = 1;
            this.BTN_DialogUnitAdd.Text = "Add Unit";
            this.BTN_DialogUnitAdd.UseVisualStyleBackColor = true;
            this.BTN_DialogUnitAdd.Click += new System.EventHandler(this.BTN_DialogUnitAdd_Click);
            // 
            // BTN_DialogUnitCancel
            // 
            this.BTN_DialogUnitCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_DialogUnitCancel.AutoSize = true;
            this.BTN_DialogUnitCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_DialogUnitCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DialogUnitCancel.Location = new System.Drawing.Point(5, 10);
            this.BTN_DialogUnitCancel.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DialogUnitCancel.Name = "BTN_DialogUnitCancel";
            this.BTN_DialogUnitCancel.Size = new System.Drawing.Size(82, 33);
            this.BTN_DialogUnitCancel.TabIndex = 2;
            this.BTN_DialogUnitCancel.Text = "Cancel";
            this.BTN_DialogUnitCancel.UseVisualStyleBackColor = true;
            // 
            // DialogUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.GRPBOX_Unit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 320);
            this.Name = "DialogUnit";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Text = "Add Unit";
            this.GRPBOX_Unit.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPBOX_Unit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_DialogCollegeName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TXT_DialogUnitCode;
        private System.Windows.Forms.TextBox TXT_DialogUnitDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_DialogUnitCancel;
        private System.Windows.Forms.Button BTN_DialogUnitAdd;
    }
}