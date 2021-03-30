using System;
using System.Windows.Forms;
using StudentApp_Model;
using StudentApp_Controller;

namespace StudentApplication.Dialogs {
    public partial class DialogTeacher : Form {

        private IMainDAL cmd = new MainDAL();
        private bool editUpdate;
        private MainForm mainForm;
        private char passChar = '●'; // use a fixed width font compatible glyph

        // Add/Insert
        public DialogTeacher(MainForm form) {

            InitializeComponent();

            mainForm = form;
            editUpdate = false;
            TXT_DialogTeacherEmail.Enabled = true;
            Text = "Add Teacher";
            GRPBOX_DialogTeacher.Text = "Add Teacher";
            BTN_DialogTeacherAdd.Text = "Add Teacher";
            TXT_DialogTeacherPassword.PasswordChar = passChar;

            TXT_DialogTeacherEmail.MaxLength = cmd.GetMaxLengthOfField("Users", "Email");
            TXT_DialogTeacherFirstName.MaxLength = cmd.GetMaxLengthOfField("Users", "FirstName");
            TXT_DialogTeacherLastName.MaxLength = cmd.GetMaxLengthOfField("Users", "LastName");
            TXT_DialogTeacherAddress.MaxLength = cmd.GetMaxLengthOfField("Users", "Address");
            TXT_DialogTeacherCity.MaxLength = cmd.GetMaxLengthOfField("Users", "City");
            TXT_DialogTeacherState.MaxLength = cmd.GetMaxLengthOfField("Users", "State");
            TXT_DialogTeacherPostcode.MaxLength = cmd.GetMaxLengthOfField("Users", "Postcode");
            TXT_DialogTeacherMobile.MaxLength = cmd.GetMaxLengthOfField("Users", "Mobile");
            TXT_DialogTeacherPassword.MaxLength = cmd.GetMaxLengthOfField("Users", "Pass");
            TXT_DialogTeacherGender.MaxLength = cmd.GetMaxLengthOfField("Users", "Gender");
        }

        // Edit/Update
        public DialogTeacher(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            editUpdate = true;
            TXT_DialogTeacherEmail.Enabled = false;
            Text = "Edit Teacher";
            GRPBOX_DialogTeacher.Text = "Edit Teacher";
            BTN_DialogTeacherAdd.Text = "Update Teacher";
            TXT_DialogTeacherPassword.PasswordChar = passChar;

            TXT_DialogTeacherEmail.MaxLength = cmd.GetMaxLengthOfField("Users", "Email");
            TXT_DialogTeacherFirstName.MaxLength = cmd.GetMaxLengthOfField("Users", "FirstName");
            TXT_DialogTeacherLastName.MaxLength = cmd.GetMaxLengthOfField("Users", "LastName");
            TXT_DialogTeacherAddress.MaxLength = cmd.GetMaxLengthOfField("Users", "Address");
            TXT_DialogTeacherCity.MaxLength = cmd.GetMaxLengthOfField("Users", "City");
            TXT_DialogTeacherState.MaxLength = cmd.GetMaxLengthOfField("Users", "State");
            TXT_DialogTeacherPostcode.MaxLength = cmd.GetMaxLengthOfField("Users", "Postcode");
            TXT_DialogTeacherMobile.MaxLength = cmd.GetMaxLengthOfField("Users", "Mobile");
            TXT_DialogTeacherPassword.MaxLength = cmd.GetMaxLengthOfField("Users", "Pass");
            TXT_DialogTeacherGender.MaxLength = cmd.GetMaxLengthOfField("Users", "Gender");

            TXT_DialogTeacherEmail.Text = row.Cells["Email"].Value.ToString();
            TXT_DialogTeacherFirstName.Text = row.Cells["FirstName"].Value.ToString();
            TXT_DialogTeacherLastName.Text = row.Cells["LastName"].Value.ToString();
            TXT_DialogTeacherAddress.Text = row.Cells["Address"].Value.ToString();
            TXT_DialogTeacherCity.Text = row.Cells["City"].Value.ToString();
            TXT_DialogTeacherState.Text = row.Cells["State"].Value.ToString();
            TXT_DialogTeacherPostcode.Text = row.Cells["Postcode"].Value.ToString();
            // Get Password has it's own function
            TXT_DialogTeacherPassword.Text = new MainDAL().GetPass(row.Cells["Email"].Value.ToString());

            string gender = row.Cells["Gender"].Value.ToString();
            if (gender == "Male") {
                RAD_DialogTeacherGenderMale.Checked = true;
            } else if (gender == "Female") {
                RAD_DialogTeacherGenderFemale.Checked = true;
            } else {
                RAD_DialogTeacherGenderOther.Checked = true;
                TXT_DialogTeacherGender.Enabled = true;
                TXT_DialogTeacherGender.Text = row.Cells["Gender"].Value.ToString();
            }

            TXT_DialogTeacherMobile.Text = row.Cells["Mobile"].Value.ToString();
            if (DateTime.TryParse(row.Cells["Dob"].Value.ToString(), out DateTime startDate)) {
                DTP_DialogTeacherDOB.Value = startDate;
                DTP_DialogTeacherDOB.Checked = true;
            } else {
                MessageBox.Show("Unable to load 'Birthdate' from database");
            }
            BTN_DialogTeacherAdd.Text = "Update Teacher";
        }

        // on load - attach event to gender radio button group
        private void DialogTeacher_Load(object sender, EventArgs e) {
            RADGRP_DialogTeacherGender.MouseClick += TeacherDialogGender_MouseClick;
        }
        // Gender behaviour
        private void RAD_DialogTeacherGender_CheckedChanged(object sender, EventArgs e) {
            if (RAD_DialogTeacherGenderMale.Checked || RAD_DialogTeacherGenderFemale.Checked) {
                TXT_DialogTeacherGender.Enabled = false;
            } else {
                TXT_DialogTeacherGender.Enabled = true;
                TXT_DialogTeacherGender.Focus();
            }
        }
        // To be able to have a click event on a disabled item
        private void TeacherDialogGender_MouseClick(object sender, MouseEventArgs e) {

            if (e.Location.X - TXT_DialogTeacherGender.Location.X > 0 &&
                e.Location.X - TXT_DialogTeacherGender.Location.X < TXT_DialogTeacherGender.Width &&
                e.Location.Y - TXT_DialogTeacherGender.Location.Y > 0 &&
                e.Location.Y - TXT_DialogTeacherGender.Location.Y < TXT_DialogTeacherGender.Height) {

                TXT_DialogTeacherGender.Enabled = true;
                RAD_DialogTeacherGenderOther.Checked = true;
            }
        }
        // Navigate on enter
        private void TextBox_onKeyEnter(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Return)) {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        // Show/hide password
        private void BTN_DialogTeacherPassword_Click(object sender, EventArgs e) {
            TXT_DialogTeacherPassword.PasswordChar = TXT_DialogTeacherPassword.PasswordChar == '\0' ? passChar : '\0';
        }
        // Add
        private void BTN_DialogTeacherAdd_Click(object sender, EventArgs e) {
            bool pass = true;
            string msg = "";
            int i = 1;
            if (!ValidateInput.IsValid(TXT_DialogTeacherFirstName)) {
                pass = false;
                msg += i + ". First Name must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogTeacherLastName)) {
                pass = false;
                msg += i + ". Last Name must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogTeacherEmail, true)) {
                pass = false;
                msg += i + ". A valid Email address is required\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogTeacherAddress)) {
                pass = false;
                msg += i + ". Street Address must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogTeacherCity)) {
                pass = false;
                msg += i + ". City must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogTeacherState)) {
                pass = false;
                msg += i + ". State must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogTeacherPostcode, @"^\d{4}$")) {
                pass = false;
                msg += i + ". Postcode must contain 4 digits only\n";
                i++;
            }
            if (!ValidateInput.IsValid(RADGRP_DialogTeacherGender)) {
                pass = false;
                msg += i + ". Gender must have a selection\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogTeacherMobile)) {
                pass = false;
                msg += i + ". Mobile number must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(DTP_DialogTeacherDOB)) {
                pass = false;
                msg += i + ". A Birthdate must be selected\n";
                i++;
            }
            if (!pass) {
                msg += "\nRequired fields must be valid.";
                MessageBox.Show(null, msg, "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            string gender = RAD_DialogTeacherGenderMale.Checked ? "Male" :
                            RAD_DialogTeacherGenderFemale.Checked ? "Female" :
                            TXT_DialogTeacherGender.Text == "Identify as..." ||
                            TXT_DialogTeacherGender.Text == "" ? "Not Specified" :
                            TXT_DialogTeacherGender.Text;

            Teacher teacher = new Teacher() {
                UserEmail = TXT_DialogTeacherEmail.Text,
                User = new User() {
                    Email = TXT_DialogTeacherEmail.Text,            // "doug_degraves@crypt.com.au",
                    FirstName = TXT_DialogTeacherFirstName.Text,    // "Doug",
                    LastName = TXT_DialogTeacherLastName.Text,      // "DeGraves",
                    Address = TXT_DialogTeacherAddress.Text,        // "13 Life Close",
                    City = TXT_DialogTeacherCity.Text,              // "Rookwood",
                    State = TXT_DialogTeacherState.Text,            // "NSW",
                    Postcode = TXT_DialogTeacherPostcode.Text,      // "2141",
                    Gender = gender,                                // "Male",
                    Mobile = TXT_DialogTeacherMobile.Text,          // "0400 666 666",
                    Dob = DTP_DialogTeacherDOB.Value.Date,          // new DateTime(1966, 6, 6),
                    Pass = TXT_DialogTeacherPassword.Text           // "ddeg"
                }
            };
            // If validation successful
            if (editUpdate) {
                cmd.UpdateUser(teacher.User);
                mainForm.GetView("Teachers");
            } else {
                cmd.AddUser(teacher);
                mainForm.GetView("Teachers");
            }
        }
    }
}
