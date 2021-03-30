using System;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApp_Model;

namespace StudentApplication.Dialogs {
    public partial class DialogCourse : Form {

        private IMainDAL cmd = new MainDAL();
        private readonly bool editUpdate;
        private readonly MainForm mainForm;

        public DialogCourse(MainForm form) {

            InitializeComponent();

            mainForm = form;
            editUpdate = false;
            TXT_DialogCourseCode.Enabled = true;
            Text = "Add Course";
            GRPBOX_Course.Text = "Add Course";
            BTN_DialogCourseAdd.Text = "Add Course";

            TXT_DialogCourseCode.MaxLength = cmd.GetMaxLengthOfField("Courses", "CourseCode");
            TXT_DialogCourseName.MaxLength = cmd.GetMaxLengthOfField("Courses", "Name");
        }

        public DialogCourse(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            editUpdate = true;
            TXT_DialogCourseCode.Enabled = false;
            Text = "Edit Course";
            GRPBOX_Course.Text = "Edit Course";
            BTN_DialogCourseAdd.Text = "Update Course";

            TXT_DialogCourseCode.MaxLength = cmd.GetMaxLengthOfField("Courses", "CourseCode");
            TXT_DialogCourseName.MaxLength = cmd.GetMaxLengthOfField("Courses", "Name");

            TXT_DialogCourseCode.Text = row.Cells["CourseCode"].Value.ToString();
            TXT_DialogCourseName.Text = row.Cells["CourseName"].Value.ToString();
            TXT_DialogCourseFee.Text = string.Format("{0:C}", row.Cells["Fee"].Value);
        }

        private void BTN_DialogCourseAdd_Click(object sender, EventArgs e) {

            bool pass = true;
            string msg = "";
            int i = 1;
            if (!ValidateInput.IsValid(TXT_DialogCourseCode)) {
                pass = false;
                msg += i + ". Course Code must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogCourseName)) {
                pass = false;
                msg += i + ". Course Name must not be blank\n";
                i++;
            }

            // Send tmpCourseFee to function and not TXT_DialogCourseFee.Text
            decimal tmpCourseFee;
            if (!ValidateInput.IsValid(TXT_DialogCourseFee, true, out tmpCourseFee)) {
                pass = false;
                msg += i + ". Fee Must be a valid amount\n";
                i++;
            }
            if (!pass) {
                msg += "\nRequired fields must be valid.";
                MessageBox.Show(null, msg, "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            Course course = new Course() {
                CourseCode = TXT_DialogCourseCode.Text,
                Name = TXT_DialogCourseName.Text,
                Fee = tmpCourseFee
            };
            // If validation successful
            if (editUpdate) {
                if (cmd.UpdateCourse(course)){
                    mainForm.GetView("Colleges");
                }
            } else {
                if (cmd.AddCourse(course)) {
                    mainForm.GetView("Colleges");
                }
            }
        }
        // Navigate on enter
        private void TextBox_onKeyEnter(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Return)) {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
