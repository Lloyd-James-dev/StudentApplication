using System;
using System.Windows.Forms;
using StudentApp_Model;
using StudentApp_Controller;

namespace StudentApplication.Dialogs {
    public partial class DialogAdmin : Form {

        private IMainDAL cmd = new MainDAL();
        private bool editUpdate;
        private MainForm mainForm;
        private char passChar = '●'; // use a fixed width font compatible glyph

        // Add/Insert
        public DialogAdmin(MainForm form) {

            InitializeComponent();

            mainForm = form;
            editUpdate = false;
            TXT_DialogAdminEmail.Enabled = true;
            Text = "Add Administrator";
            GRPBOX_Admin.Text = "Add Administrator";
            BTN_DialogAdminAdd.Text = "Add Administrator";
            TXT_DialogAdminPassword.PasswordChar = passChar;

            TXT_DialogAdminEmail.MaxLength = cmd.GetMaxLengthOfField("Users", "Email");
            TXT_DialogAdminFirstName.MaxLength = cmd.GetMaxLengthOfField("Users", "FirstName");
            TXT_DialogAdminLastName.MaxLength = cmd.GetMaxLengthOfField("Users", "LastName");
            TXT_DialogAdminAddress.MaxLength = cmd.GetMaxLengthOfField("Users", "Address");
            TXT_DialogAdminCity.MaxLength = cmd.GetMaxLengthOfField("Users", "City");
            TXT_DialogAdminState.MaxLength = cmd.GetMaxLengthOfField("Users", "State");
            TXT_DialogAdminPostcode.MaxLength = cmd.GetMaxLengthOfField("Users", "Postcode");
            TXT_DialogAdminMobile.MaxLength = cmd.GetMaxLengthOfField("Users", "Mobile");
            TXT_DialogAdminPassword.MaxLength = cmd.GetMaxLengthOfField("Users", "Pass");
            TXT_DialogAdminGender.MaxLength = cmd.GetMaxLengthOfField("Users", "Gender");
        }

        // Edit/Update
        public DialogAdmin(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            editUpdate = true;
            TXT_DialogAdminEmail.Enabled = false;
            Text = "Edit Administrator";
            GRPBOX_Admin.Text = "Edit Administrator";
            BTN_DialogAdminAdd.Text = "Update Administrator";
            TXT_DialogAdminPassword.PasswordChar = passChar;

            TXT_DialogAdminEmail.MaxLength = cmd.GetMaxLengthOfField("Users", "Email");
            TXT_DialogAdminFirstName.MaxLength = cmd.GetMaxLengthOfField("Users", "FirstName");
            TXT_DialogAdminLastName.MaxLength = cmd.GetMaxLengthOfField("Users", "LastName");
            TXT_DialogAdminAddress.MaxLength = cmd.GetMaxLengthOfField("Users", "Address");
            TXT_DialogAdminCity.MaxLength = cmd.GetMaxLengthOfField("Users", "City");
            TXT_DialogAdminState.MaxLength = cmd.GetMaxLengthOfField("Users", "State");
            TXT_DialogAdminPostcode.MaxLength = cmd.GetMaxLengthOfField("Users", "Postcode");
            TXT_DialogAdminMobile.MaxLength = cmd.GetMaxLengthOfField("Users", "Mobile");
            TXT_DialogAdminPassword.MaxLength = cmd.GetMaxLengthOfField("Users", "Pass");
            TXT_DialogAdminGender.MaxLength = cmd.GetMaxLengthOfField("Users", "Gender");

            TXT_DialogAdminEmail.Text = row.Cells["Email"].Value.ToString();
            TXT_DialogAdminFirstName.Text = row.Cells["FirstName"].Value.ToString();
            TXT_DialogAdminLastName.Text = row.Cells["LastName"].Value.ToString();
            TXT_DialogAdminAddress.Text = row.Cells["Address"].Value.ToString();
            TXT_DialogAdminCity.Text = row.Cells["City"].Value.ToString();
            TXT_DialogAdminState.Text = row.Cells["State"].Value.ToString();
            TXT_DialogAdminPostcode.Text = row.Cells["Postcode"].Value.ToString();
            // Get Password has it's own function
            TXT_DialogAdminPassword.Text = new MainDAL().GetPass(row.Cells["Email"].Value.ToString());

            string gender = row.Cells["Gender"].Value.ToString();
            if (gender == "Male") {
                RAD_DialogAdminGenderMale.Checked = true;
            } else if (gender == "Female") {
                RAD_DialogAdminGenderFemale.Checked = true;
            } else {
                RAD_DialogAdminGenderOther.Checked = true;
                TXT_DialogAdminGender.Enabled = true;
                TXT_DialogAdminGender.Text = row.Cells["Gender"].Value.ToString();
            }

            TXT_DialogAdminMobile.Text = row.Cells["Mobile"].Value.ToString();
            if (DateTime.TryParse(row.Cells["Dob"].Value.ToString(), out DateTime startDate)) {
                DTP_DialogAdminDOB.Value = startDate;
                DTP_DialogAdminDOB.Checked = true;
            } else {
                MessageBox.Show("Unable to load 'Birthdate' from database");
            }
        }

        // on load - attach event to gender radio button group
        private void DialogAdmin_Load(object sender, EventArgs e) {
            RADGRP_DialogAdminGender.MouseClick += AdminDialogGender_MouseClick;
        }
        // Gender behaviour
        private void RAD_DialogAdminGender_CheckedChanged(object sender, EventArgs e) {
            if (RAD_DialogAdminGenderMale.Checked || RAD_DialogAdminGenderFemale.Checked) {
                TXT_DialogAdminGender.Enabled = false;
            } else {
                TXT_DialogAdminGender.Enabled = true;
                TXT_DialogAdminGender.Focus();
            }
        }
        // To be able to have a click event on a disabled item
        private void AdminDialogGender_MouseClick(object sender, MouseEventArgs e) {

            if (e.Location.X - TXT_DialogAdminGender.Location.X > 0 &&
                e.Location.X - TXT_DialogAdminGender.Location.X < TXT_DialogAdminGender.Width &&
                e.Location.Y - TXT_DialogAdminGender.Location.Y > 0 &&
                e.Location.Y - TXT_DialogAdminGender.Location.Y < TXT_DialogAdminGender.Height) {
                TXT_DialogAdminGender.Enabled = true;
                RAD_DialogAdminGenderOther.Checked = true;
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
        private void BTN_DialogAdminPassword_Click(object sender, EventArgs e) {
            TXT_DialogAdminPassword.PasswordChar = TXT_DialogAdminPassword.PasswordChar == '\0' ? passChar : '\0';
        }
        // Add
        private void BTN_DialogAdminAdd_Click(object sender, EventArgs e) {
            bool pass = true;
            string msg = "";
            int i = 1;
            if (!ValidateInput.IsValid(TXT_DialogAdminFirstName)) {
                pass = false;
                msg += i + ". First Name must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogAdminLastName)) {
                pass = false;
                msg += i + ". Last Name must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogAdminEmail, true)) {
                pass = false;
                msg += i + ". A valid Email address is required\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogAdminAddress)) {
                pass = false;
                msg += i + ". Street Address must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogAdminCity)) {
                pass = false;
                msg += i + ". City must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogAdminState)) {
                pass = false;
                msg += i + ". State must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogAdminPostcode, @"^\d{4}$")) {
                pass = false;
                msg += i + ". Postcode must contain 4 digits only\n";
                i++;
            }
            if (!ValidateInput.IsValid(RADGRP_DialogAdminGender)) {
                pass = false;
                msg += i + ". Gender must have a selection\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogAdminMobile)) {
                pass = false;
                msg += i + ". Mobile number must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(DTP_DialogAdminDOB)) {
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

            string gender = RAD_DialogAdminGenderMale.Checked ? "Male" :
                            RAD_DialogAdminGenderFemale.Checked ? "Female" :
                            TXT_DialogAdminGender.Text == "Identify as..." ||
                            TXT_DialogAdminGender.Text == "" ? "Not Specified" :
                            TXT_DialogAdminGender.Text;

            Admin admin = new Admin() {
                UserEmail = TXT_DialogAdminEmail.Text,
                User = new User() {
                    Email = TXT_DialogAdminEmail.Text,            //"doug_degraves@crypt.com.au",
                    FirstName = TXT_DialogAdminFirstName.Text,    //"Doug",
                    LastName = TXT_DialogAdminLastName.Text,      //"DeGraves",
                    Address = TXT_DialogAdminAddress.Text,        //"13 Life Close",
                    City = TXT_DialogAdminCity.Text,              //"Rookwood",
                    State = TXT_DialogAdminState.Text,            //"NSW",
                    Postcode = TXT_DialogAdminPostcode.Text,      //"2141",
                    Gender = gender,                                //"Male",
                    Mobile = TXT_DialogAdminMobile.Text,          //"0400 666 666",
                    Dob = DTP_DialogAdminDOB.Value.Date,          //new DateTime(1966, 6, 6),
                    Pass = TXT_DialogAdminPassword.Text           //"ddeg"
                }
            };
            // If validation successful
            if (editUpdate) {
                cmd.UpdateUser(admin.User);
                mainForm.GetView("Administrators");
            } else {
                cmd.AddUser(admin);
                mainForm.GetView("Administrators");
            }
        }
    }
}
