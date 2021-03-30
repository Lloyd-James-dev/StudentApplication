using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApp_Model;

namespace StudentApplication.Dialogs {
    public partial class DialogCollege : Form {

        private bool editUpdate;
        private MainForm mainForm;
        IMainDAL cmd = new MainDAL();

        public DialogCollege(MainForm form) {

            InitializeComponent();
            mainForm = form;
            editUpdate = false;
            Text = "Add College";
            GRPBOX_College.Text = "Add College";
            BTN_DialogCollegeAdd.Text = "Add College";

            TXT_DialogCollegeName.MaxLength = cmd.GetMaxLengthOfField("Colleges", "Name");
            TXT_DialogCollegeAddress.MaxLength = cmd.GetMaxLengthOfField("Colleges", "Address");
            TXT_DialogCollegeCity.MaxLength = cmd.GetMaxLengthOfField("Colleges", "City");
            TXT_DialogCollegeState.MaxLength = cmd.GetMaxLengthOfField("Colleges", "State");
            TXT_DialogCollegePostcode.MaxLength = cmd.GetMaxLengthOfField("Colleges", "Postcode");
        }

        public DialogCollege(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            editUpdate = true;
            Text = "Edit College";
            GRPBOX_College.Text = "Edit College";
            BTN_DialogCollegeAdd.Text = "Update College";

            TXT_DialogCollegeName.MaxLength = cmd.GetMaxLengthOfField("Colleges", "Name");
            TXT_DialogCollegeAddress.MaxLength = cmd.GetMaxLengthOfField("Colleges", "Address");
            TXT_DialogCollegeCity.MaxLength = cmd.GetMaxLengthOfField("Colleges", "City");
            TXT_DialogCollegeState.MaxLength = cmd.GetMaxLengthOfField("Colleges", "State");
            TXT_DialogCollegePostcode.MaxLength = cmd.GetMaxLengthOfField("Colleges", "Postcode");

            LBL_DialogCollegeId.Text = row.Cells["CollegeId"].Value.ToString();
            TXT_DialogCollegeName.Text = row.Cells["CollegeName"].Value.ToString();
            TXT_DialogCollegeAddress.Text = row.Cells["Address"].Value.ToString();
            TXT_DialogCollegeCity.Text = row.Cells["City"].Value.ToString();
            TXT_DialogCollegeState.Text = row.Cells["State"].Value.ToString();
            TXT_DialogCollegePostcode.Text = row.Cells["Postcode"].Value.ToString();
        }
        private void BTN_DialogCollegeAdd_Click(object sender, EventArgs e) {
            bool pass = true;
            string msg = "";
            int i = 1;
            if (!ValidateInput.IsValid(TXT_DialogCollegeName)) {
                pass = false;
                msg += i + ". Name must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogCollegeAddress)) {
                pass = false;
                msg += i + ". Street Address must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogCollegeCity)) {
                pass = false;
                msg += i + ". City must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogCollegeState)) {
                pass = false;
                msg += i + ". State must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogCollegePostcode, @"^\d{4}$")) {
                pass = false;
                msg += i + ". Postcode must contain 4 digits only\n";
                i++;
            }
            if (!pass) {
                msg += "\nRequired fields must be valid.";
                MessageBox.Show(null, msg, "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            // If validation successful
            if (editUpdate) {
                College college = new College() {
                    Id = int.Parse(LBL_DialogCollegeId.Text),
                    Name = TXT_DialogCollegeName.Text,
                    Address = TXT_DialogCollegeAddress.Text,
                    City = TXT_DialogCollegeCity.Text,
                    State = TXT_DialogCollegeState.Text,
                    Postcode = TXT_DialogCollegePostcode.Text
                };
                if (cmd.UpdateCollege(college)) {
                    mainForm.GetView("Colleges");
                }
            } else {
                College college = new College() {
                    Name = TXT_DialogCollegeName.Text,
                    Address = TXT_DialogCollegeAddress.Text,
                    City = TXT_DialogCollegeCity.Text,
                    State = TXT_DialogCollegeState.Text,
                    Postcode = TXT_DialogCollegePostcode.Text
                };
                if (cmd.AddCollege(college)) {
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
