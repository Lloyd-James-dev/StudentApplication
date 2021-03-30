using System;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApp_Model;

namespace StudentApplication.Dialogs {
    public partial class DialogUnit : Form {

        private IMainDAL cmd = new MainDAL();
        private bool editUpdate;
        private MainForm mainForm;

        public DialogUnit(MainForm form) {

            InitializeComponent();

            mainForm = form;
            editUpdate = false;
            TXT_DialogUnitCode.Enabled = true;
            Text = "Add Unit";
            GRPBOX_Unit.Text = "Add Unit";
            BTN_DialogUnitAdd.Text = "Add Unit";

            TXT_DialogUnitCode.MaxLength = cmd.GetMaxLengthOfField("Units", "UnitCode");
            TXT_DialogUnitDesc.MaxLength = cmd.GetMaxLengthOfField("Units", "Description");
        }

        public DialogUnit(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            editUpdate = true;
            TXT_DialogUnitCode.Enabled = false;
            BTN_DialogUnitAdd.Text = "Update Unit";
            Text = "Edit Unit";
            GRPBOX_Unit.Text = "Edit Unit";

            TXT_DialogUnitCode.MaxLength = cmd.GetMaxLengthOfField("Units", "UnitCode");
            TXT_DialogUnitDesc.MaxLength = cmd.GetMaxLengthOfField("Units", "Description");

            TXT_DialogUnitCode.Text = row.Cells["UnitCode"].Value.ToString();
            TXT_DialogUnitDesc.Text = row.Cells["UnitDescription"].Value.ToString();
        }
        // Navigate on enter
        private void TextBox_onKeyEnter(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Return)) {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void BTN_DialogUnitAdd_Click(object sender, EventArgs e) {

            bool pass = true;
            string msg = "";
            int i = 1;
            if (!ValidateInput.IsValid(TXT_DialogUnitCode)) {
                pass = false;
                msg += i + ". Unit Code must not be blank\n";
                i++;
            }
            if (!ValidateInput.IsValid(TXT_DialogUnitDesc)) {
                pass = false;
                msg += i + ". Description must not be blank\n";
                i++;
            }
            if (!pass) {
                msg += "\nRequired fields must be valid.";
                MessageBox.Show(null, msg, "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            Unit unit = new Unit() {
                UnitCode = TXT_DialogUnitCode.Text,
                Description = TXT_DialogUnitDesc.Text
            };
            // If validation successful
            if (editUpdate) {
                if (cmd.UpdateUnit(unit)) {
                    mainForm.GetView("Units");
                }
            } else {
                if (cmd.AddUnit(unit)) {
                    mainForm.GetView("Units");
                }
            }
        }
    }
}
