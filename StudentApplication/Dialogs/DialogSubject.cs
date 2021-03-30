using StudentApp_Controller;
using StudentApp_Model;
using System;
using System.Windows.Forms;

namespace StudentApplication.Dialogs {
    public partial class DialogSubject : Form {

        private IMainDAL cmd = new MainDAL();
        private bool editUpdate;
        private MainForm mainForm;

        public DialogSubject(MainForm form) {

            InitializeComponent();

            mainForm = form;
            editUpdate = false;
            Text = "Add Subject";
            GRPBOX_Subject.Text = "Add Subject";
            BTN_DialogSubjectAdd.Text = "Add Subject";

            TXT_DialogSubjectName.MaxLength = cmd.GetMaxLengthOfField("Subjects", "Name");
        }

        public DialogSubject(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            editUpdate = true;
            Text = "Edit Subject";
            GRPBOX_Subject.Text = "Edit Subject";
            BTN_DialogSubjectAdd.Text = "Update Subject";
            LBL_DialogSubjectId.Text = row.Cells["SubjectId"].Value.ToString();

            TXT_DialogSubjectName.MaxLength = cmd.GetMaxLengthOfField("Subjects", "Name");

            TXT_DialogSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
        }

        private void BTN_DialogSubjectAdd_Click(object sender, EventArgs e) {

            bool pass = true;
            string msg = "";
            int i = 1;
            if (!ValidateInput.IsValid(TXT_DialogSubjectName)) {
                pass = false;
                msg += i + ". Subject Name must not be blank\n";
                i++;
            }
            if (!pass) {
                msg += "\nRequired fields must be valid.";
                MessageBox.Show(null, msg, "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            // If validation successful
            IMainDAL cmd = new MainDAL();
            if (editUpdate) {
                Subject subject = new Subject() {
                    Id = int.Parse(LBL_DialogSubjectId.Text),
                    Name = TXT_DialogSubjectName.Text
                };
                if (cmd.UpdateSubject(subject)) {
                    mainForm.GetView("Subjects");
                }
            } else {
                Subject subject = new Subject() {
                    Name = TXT_DialogSubjectName.Text
                };
                if (cmd.AddSubject(subject)) {
                    mainForm.GetView("Subjects");
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
