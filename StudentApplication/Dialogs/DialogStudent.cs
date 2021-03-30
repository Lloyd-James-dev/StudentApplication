using System;
using System.Windows.Forms;
using StudentApp_Model;
using StudentApp_Controller;

namespace StudentApplication.Dialogs {
    public partial class DialogStudent : Form {

        private IMainDAL cmd = new MainDAL();
        private bool editUpdate;
        private MainForm mainForm;
        private char passChar = '●'; // use a fixed width font compatible glyph

        // Add/Insert
        public DialogStudent(MainForm form) {

            InitializeComponent();

            mainForm = form;
            editUpdate = false;
            TXT_DialogStudentEmail.Enabled = true;
            Text = "Add Student";
            GRPBOX_User.Text = "Add Student";
            BTN_DialogStudentAdd.Text = "Add Student";
            TXT_DialogStudentPassword.PasswordChar = passChar;

            TXT_DialogStudentEmail.MaxLength = cmd.GetMaxLengthOfField("Users", "Email");
            TXT_DialogStudentFirstName.MaxLength = cmd.GetMaxLengthOfField("Users", "FirstName");
            TXT_DialogStudentLastName.MaxLength = cmd.GetMaxLengthOfField("Users", "LastName");
            TXT_DialogStudentAddress.MaxLength = cmd.GetMaxLengthOfField("Users", "Address");
            TXT_DialogStudentCity.MaxLength = cmd.GetMaxLengthOfField("Users", "City");
            TXT_DialogStudentState.MaxLength = cmd.GetMaxLengthOfField("Users", "State");
            TXT_DialogStudentPostcode.MaxLength = cmd.GetMaxLengthOfField("Users", "Postcode");
            TXT_DialogStudentMobile.MaxLength = cmd.GetMaxLengthOfField("Users", "Mobile");
            TXT_DialogStudentPassword.MaxLength = cmd.GetMaxLengthOfField("Users", "Pass");
            TXT_DialogStudentGender.MaxLength = cmd.GetMaxLengthOfField("Users", "Gender");
        }

        // Edit/Update
        public DialogStudent(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            editUpdate = true;
            TXT_DialogStudentEmail.Enabled = false;
            Text = "Edit Student";
            GRPBOX_User.Text = "Edit Student";
            BTN_DialogStudentAdd.Text = "Update Student";
            TXT_DialogStudentPassword.PasswordChar = passChar;

            TXT_DialogStudentEmail.MaxLength = cmd.GetMaxLengthOfField("Users", "Email");
            TXT_DialogStudentFirstName.MaxLength = cmd.GetMaxLengthOfField("Users", "FirstName");
            TXT_DialogStudentLastName.MaxLength = cmd.GetMaxLengthOfField("Users", "LastName");
            TXT_DialogStudentAddress.MaxLength = cmd.GetMaxLengthOfField("Users", "Address");
            TXT_DialogStudentCity.MaxLength = cmd.GetMaxLengthOfField("Users", "City");
            TXT_DialogStudentState.MaxLength = cmd.GetMaxLengthOfField("Users", "State");
            TXT_DialogStudentPostcode.MaxLength = cmd.GetMaxLengthOfField("Users", "Postcode");
            TXT_DialogStudentMobile.MaxLength = cmd.GetMaxLengthOfField("Users", "Mobile");
            TXT_DialogStudentPassword.MaxLength = cmd.GetMaxLengthOfField("Users", "Pass");
            TXT_DialogStudentGender.MaxLength = cmd.GetMaxLengthOfField("Users", "Gender");

            TXT_DialogStudentEmail.Text = row.Cells["Email"].Value.ToString();
            TXT_DialogStudentFirstName.Text = row.Cells["FirstName"].Value.ToString();
            TXT_DialogStudentLastName.Text = row.Cells["LastName"].Value.ToString();
            TXT_DialogStudentAddress.Text = row.Cells["Address"].Value.ToString();
            TXT_DialogStudentCity.Text = row.Cells["City"].Value.ToString();
            TXT_DialogStudentState.Text = row.Cells["State"].Value.ToString();
            TXT_DialogStudentPostcode.Text = row.Cells["Postcode"].Value.ToString();
            // Get Password has it's own function
            TXT_DialogStudentPassword.Text = cmd.GetPass(row.Cells["Email"].Value.ToString());

            string gender = row.Cells["Gender"].Value.ToString();
            if (gender == "Male") {
                RAD_DialogStudentGenderMale.Checked = true;
            } else if (gender == "Female") {
                RAD_DialogStudentGenderFemale.Checked = true;
            } else {
                RAD_DialogStudentGenderOther.Checked = true;
                TXT_DialogStudentGender.Enabled = true;
                TXT_DialogStudentGender.Text = row.Cells["Gender"].Value.ToString();
            }

            TXT_DialogStudentMobile.Text = row.Cells["Mobile"].Value.ToString();
            if (DateTime.TryParse(row.Cells["Dob"].Value.ToString(), out DateTime startDate)) {
                DTP_DialogStudentDOB.Value = startDate;
                DTP_DialogStudentDOB.Checked = true;
            } else {
                MessageBox.Show("Unable to load 'Birthdate' from database");
            }
        }

        // on load - attach event to gender radio button group
        private void DialogStudent_Load(object sender, EventArgs e) {
            RADGRP_DialogStudentGender.MouseClick += StudentDialogGender_MouseClick;
        }
        // Gender behaviour
        private void RAD_DialogStudentGender_CheckedChanged(object sender, EventArgs e) {
            if (RAD_DialogStudentGenderMale.Checked || RAD_DialogStudentGenderFemale.Checked) {
                TXT_DialogStudentGender.Enabled = false;
            } else {
                TXT_DialogStudentGender.Enabled = true;
                TXT_DialogStudentGender.Focus();
            }
        }
        // To be able to have a click event on a disabled item
        private void StudentDialogGender_MouseClick(object sender, MouseEventArgs e) {

            if (e.Location.X - TXT_DialogStudentGender.Location.X > 0 &&
                e.Location.X - TXT_DialogStudentGender.Location.X < TXT_DialogStudentGender.Width &&
                e.Location.Y - TXT_DialogStudentGender.Location.Y > 0 &&
                e.Location.Y - TXT_DialogStudentGender.Location.Y < TXT_DialogStudentGender.Height) {

                TXT_DialogStudentGender.Enabled = true;
                RAD_DialogStudentGenderOther.Checked = true;
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
        private void BTN_DialogStudentPassword_Click(object sender, EventArgs e) {
            TXT_DialogStudentPassword.PasswordChar = TXT_DialogStudentPassword.PasswordChar == '\0' ? passChar : '\0';
        }
        // Add
        private void BTN_DialogStudentAdd_Click(object sender, EventArgs e) {
            bool pass = true;
            string msg = "";
            int i = 1;
            if (!ValidateInput.IsValid(TXT_DialogStudentFirstName)) {
                pass = false;
                msg += i + ". First Name must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogStudentLastName)) {
                pass = false;
                msg += i + ". Last Name must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogStudentEmail, true)) {
                pass = false;
                msg += i + ". A valid Email address is required\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogStudentAddress)) {
                pass = false;
                msg += i + ". Street Address must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogStudentCity)) {
                pass = false;
                msg += i + ". City must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogStudentState)) {
                pass = false;
                msg += i + ". State must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogStudentPostcode, @"^\d{4}$")) {
                pass = false;
                msg += i + ". Postcode must contain 4 digits only\n";
                i++;
            }
            if (!ValidateInput.IsValid(RADGRP_DialogStudentGender)) {
                pass = false;
                msg += i + ". Gender must have a selection\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogStudentMobile)) {
                pass = false;
                msg += i + ". Mobile number must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(DTP_DialogStudentDOB)) {
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

            string gender = RAD_DialogStudentGenderMale.Checked ? "Male" :
                            RAD_DialogStudentGenderFemale.Checked ? "Female" :
                            TXT_DialogStudentGender.Text == "Identify as..." ||
                            TXT_DialogStudentGender.Text == "" ? "Not Specified" :
                            TXT_DialogStudentGender.Text;

            Student student = new Student() {
                UserEmail = TXT_DialogStudentEmail.Text,
                User = new User() {
                    Email = TXT_DialogStudentEmail.Text,            // "doug_degraves@crypt.com.au",
                    FirstName = TXT_DialogStudentFirstName.Text,    // "Doug",
                    LastName = TXT_DialogStudentLastName.Text,      // "DeGraves",
                    Address = TXT_DialogStudentAddress.Text,        // "13 Life Close",
                    City = TXT_DialogStudentCity.Text,              // "Rookwood",
                    State = TXT_DialogStudentState.Text,            // "NSW",
                    Postcode = TXT_DialogStudentPostcode.Text,      // "2141",
                    Gender = gender,                                // "Male",
                    Mobile = TXT_DialogStudentMobile.Text,          // "0400 666 666",
                    Dob = DTP_DialogStudentDOB.Value.Date,          // new DateTime(1966, 6, 6),
                    Pass = TXT_DialogStudentPassword.Text           // "ddeg"
                }
            };
            // If validation successful
            if (editUpdate) {
                if (cmd.UpdateUser(student.User)) { 
                    mainForm.GetView("Students");
                }
            } else {
                if (cmd.AddUser(student)) { 
                    mainForm.GetView("Students");
                }
            }
        }
    }
}
