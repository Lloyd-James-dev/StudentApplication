using StudentApp_Controller;
using StudentApp_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication.Dialogs {
    public partial class DialogReceipt : Form {

        IMainDAL cmd = new MainDAL();
        private MainForm mainForm;
        private int invoiceId;
        private string student;
        private string studentEmail;
        private string semesterName;
        private int semesterKey;
        private string collegeName;
        private int collegeId;
        private string courseCode;
        private decimal balanceDue;

        public DialogReceipt(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            invoiceId = int.Parse(row.Cells["InvoiceId"].Value.ToString());
            student = row.Cells["StudentFullName"].Value.ToString();
            studentEmail = row.Cells["StudentEmail"].Value.ToString();
            semesterName = row.Cells["SemesterName"].Value.ToString();
            semesterKey = (int)row.Cells["SemesterKey"].Value;
            collegeName = row.Cells["CollegeName"].Value.ToString();
            collegeId = (int)row.Cells["CollegeId"].Value;
            courseCode = row.Cells["CourseCode"].Value.ToString();
            balanceDue = cmd.InvoiceBalance(studentEmail, semesterKey, collegeId, courseCode);

            TXT_DialogReceipt_Misc.MaxLength = cmd.GetMaxLengthOfField("Receipts", "Misc");

            LBL_DialogReceipt_InvoiceId.Text = string.Format("{0:D8}", invoiceId);
            LBL_DialogReceipt_Name.Text = student;
            LBL_DialogReceipt_Semester.Text = semesterName;
            LBL_DialogReceipt_College.Text = collegeName;
            LBL_DialogReceipt_Course.Text = courseCode;
            LBL_DialogReceipt_Balance.Text = string.Format("{0:C}", balanceDue);
            if (balanceDue < 0) {
                LBL_DialogReceipt_Balance.ForeColor = ColumnProperties.negativeAmountColour;
            } else {
                BTN_DialogReceipt_Add.Enabled = false;
            }
        }
        // Navigate on enter
        private void TextBox_onKeyEnter(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Return)) {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void BTN_DialogReceipt_Add_Click(object sender, EventArgs e) {
            decimal amount;
            if (!ValidateInput.IsValid(TXT_DialogReceipt_Amount, true, out amount)) {
                MessageBox.Show(null, "1. Amount must be valid\n\nRequired fields must be valid.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            if (amount == 0) {
                MessageBox.Show(null, "1. Amount must not zero.\n\nRequired fields must be valid.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            if ((balanceDue + amount) > 0) {
                MessageBox.Show(null, "1. Amount exceeds balance owing!\n\nPlease enter no more than required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
                return;
            }
            Receipt receipt = new Receipt() {
                InvoiceId = invoiceId,
                Amount = amount,
                Misc = TXT_DialogReceipt_Misc.Text,
                ReceiptDate = DateTime.Now.Date
            };
            // If validation successful
            if (cmd.AddReceipt(receipt)) {
                mainForm.GetView("Transactions");
            }
        }
    }
}
