using System;
using System.Windows.Forms;
using StudentApp_Model;
using StudentApp_Controller;

namespace StudentApplication.Dialogs {

    public partial class DialogSemester : Form {

        private readonly bool editUpdate;
        private readonly MainForm mainForm;

        public DialogSemester(MainForm form) {
            InitializeComponent();
            PopCombos();
            mainForm = form;
            editUpdate = false;
            DTP_DialogSemesterFirstTermStart.Enabled = false;
            DTP_DialogSemesterFirstTermEnd.Enabled = false;
            DTP_DialogSemesterSecondTermStart.Enabled = false;
            DTP_DialogSemesterSecondTermEnd.Enabled = false;
            CMB_DialogSemesterYear.Enabled = true;
            CMB_DialogSemesterSemester.Enabled = true;
            Text = "Add Semester";
            GRPBOX_Semester.Text = "Add Semester";
            BTN_DialogSemesterAdd.Text = "Add Semester";
        }

        public DialogSemester(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            PopCombos();

            mainForm = form;
            editUpdate = true;
            CMB_DialogSemesterYear.Enabled = false;
            CMB_DialogSemesterSemester.Enabled = false;

            Text = "Edit Semester";
            GRPBOX_Semester.Text = "Edit Semester";
            BTN_DialogSemesterAdd.Text = "Update Semester";

            CMB_DialogSemesterYear.SelectedItem = row.Cells["Year"].Value;
            CMB_DialogSemesterSemester.SelectedItem = int.Parse(row.Cells["IsSecondSemester"].Value.ToString());

            if (DateTime.TryParse(row.Cells["FirstTermBegin"].Value.ToString(), out DateTime startDate_1)) {
                DTP_DialogSemesterFirstTermStart.Value = startDate_1;
                DTP_DialogSemesterFirstTermStart.Checked = true;
            }
            if (DateTime.TryParse(row.Cells["FirstTermEnd"].Value.ToString(), out DateTime endDate_1)) {
                DTP_DialogSemesterFirstTermEnd.Value = endDate_1;
                DTP_DialogSemesterFirstTermEnd.Checked = true;
            }
            if (DateTime.TryParse(row.Cells["SecondTermBegin"].Value.ToString(), out DateTime startDate_2)) {
                DTP_DialogSemesterSecondTermStart.Value = startDate_2;
                DTP_DialogSemesterSecondTermStart.Checked = true;
            }
            if (DateTime.TryParse(row.Cells["SecondTermEnd"].Value.ToString(), out DateTime endDate_2)) {
                DTP_DialogSemesterSecondTermEnd.Value = endDate_2;
                DTP_DialogSemesterSecondTermEnd.Checked = true;
            }

        }

        private void PopCombos() {
            int thisYear = DateTime.Now.Year;
            for (int i = thisYear - 4 ; i < thisYear + 11; i++) {
                CMB_DialogSemesterYear.Items.Add(i);
            }
            CMB_DialogSemesterSemester.Items.Add(1);
            CMB_DialogSemesterSemester.Items.Add(2);
        }

        private void CMB_DialogSemesterYear_SelectedIndexChanged(object sender, EventArgs e) {

            int theYear = int.Parse(CMB_DialogSemesterYear.Text);

            DateTime DateMin = new DateTime(theYear, 1, 1);
            DateTime DateMax = new DateTime(theYear, 12, 31);

            if (ValidateInput.IsValid(new DateTime(theYear, 1, 1), DTP_DialogSemesterFirstTermStart)) {
                DTP_DialogSemesterFirstTermStart.MinDate = DateMin;
                DTP_DialogSemesterFirstTermStart.MaxDate = DateMax;
                DTP_DialogSemesterFirstTermEnd.MinDate = DateMin;
                DTP_DialogSemesterFirstTermEnd.MaxDate = DateMax;
                DTP_DialogSemesterSecondTermStart.MinDate = DateMin;
                DTP_DialogSemesterSecondTermStart.MaxDate = DateMax;
                DTP_DialogSemesterSecondTermEnd.MinDate = DateMin;
                DTP_DialogSemesterSecondTermEnd.MaxDate = DateMax;
            } else {
                DTP_DialogSemesterFirstTermStart.MaxDate = DateMax;
                DTP_DialogSemesterFirstTermStart.MinDate = DateMin;
                DTP_DialogSemesterFirstTermEnd.MaxDate = DateMax;
                DTP_DialogSemesterFirstTermEnd.MinDate = DateMin;
                DTP_DialogSemesterSecondTermStart.MaxDate = DateMax;
                DTP_DialogSemesterSecondTermStart.MinDate = DateMin;
                DTP_DialogSemesterSecondTermEnd.MaxDate = DateMax;
                DTP_DialogSemesterSecondTermEnd.MinDate = DateMin;
            }
            DTP_DialogSemesterFirstTermStart.Value = DateMin;
            DTP_DialogSemesterFirstTermEnd.Value = DateMin;
            DTP_DialogSemesterSecondTermStart.Value = DateMin;
            DTP_DialogSemesterSecondTermEnd.Value = DateMin;

            DTP_DialogSemesterFirstTermStart.Enabled = true;
            DTP_DialogSemesterFirstTermEnd.Enabled = true;
            DTP_DialogSemesterSecondTermStart.Enabled = true;
            DTP_DialogSemesterSecondTermEnd.Enabled = true;

            DTP_DialogSemesterFirstTermStart.Checked = false;
            DTP_DialogSemesterFirstTermEnd.Checked = false;
            DTP_DialogSemesterSecondTermStart.Checked = false;
            DTP_DialogSemesterSecondTermEnd.Checked = false;
        }
        private void BTN_DialogSemesterAdd_Click(object sender, EventArgs e) {
            bool pass = true;
            string msg = "";
            int i = 1;
            if (!ValidateInput.IsValid(CMB_DialogSemesterYear)) {
                pass = false;
                msg += i + ". A year must be selected\n";
                i++;
            }
            if (!ValidateInput.IsValid(CMB_DialogSemesterSemester)) {
                pass = false;
                msg += i + ". A semester must be selected\n";
                i++;
            }
            if (!ValidateInput.IsValid(DTP_DialogSemesterFirstTermStart)) {
                pass = false;
                msg += i + ". First term start date must be selected\n";
                i++;
            }
            if (!ValidateInput.IsValid(DTP_DialogSemesterFirstTermEnd)) {
                pass = false;
                msg += i + ". First term end date must be selected\n";
                i++;
            }
            if (ValidateInput.IsValid(DTP_DialogSemesterFirstTermStart) &&
                ValidateInput.IsValid(DTP_DialogSemesterFirstTermEnd) &&
                !ValidateInput.IsValid(DTP_DialogSemesterFirstTermStart, DTP_DialogSemesterFirstTermEnd)) {
                pass = false;
                msg += i + ". First term end date must be after start date\n";
                i++;
            }
            if (!ValidateInput.IsValid(DTP_DialogSemesterSecondTermStart)) {
                pass = false;
                msg += i + ". Second term start date must be selected\n";
                i++;
            }
            if (ValidateInput.IsValid(DTP_DialogSemesterFirstTermEnd) &&
                ValidateInput.IsValid(DTP_DialogSemesterSecondTermStart) &&
                !ValidateInput.IsValid(DTP_DialogSemesterFirstTermEnd, DTP_DialogSemesterSecondTermStart)) {
                pass = false;
                msg += i + ". Second term start date must be after first term\n";
                i++;
            }
            if (!ValidateInput.IsValid(DTP_DialogSemesterSecondTermEnd)) {
                pass = false;
                msg += i + ". Second term end date must be selected\n";
                i++;
            }
            if (ValidateInput.IsValid(DTP_DialogSemesterSecondTermStart) &&
                ValidateInput.IsValid(DTP_DialogSemesterSecondTermEnd) &&
                !ValidateInput.IsValid(DTP_DialogSemesterSecondTermStart, DTP_DialogSemesterSecondTermEnd)) {
                pass = false;
                msg += i + ". Second term end date must be after start date\n";
                i++;
            }
            if (!pass) {
                msg += "\nRequired fields must be valid.";
                MessageBox.Show(null, msg, "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            Semester semester = new Semester() {
                Year = new DateTime((int)CMB_DialogSemesterYear.SelectedItem, 1, 1),
                SecondSemester = ((int)CMB_DialogSemesterSemester.SelectedItem).Equals(2),
                FirstTermBegin = DTP_DialogSemesterFirstTermStart.Value.Date,
                FirstTermEnd = DTP_DialogSemesterFirstTermEnd.Value.Date,
                SecondTermBegin = DTP_DialogSemesterSecondTermStart.Value.Date,
                SecondTermEnd = DTP_DialogSemesterSecondTermEnd.Value.Date
            };
            IMainDAL cmd = new MainDAL();
            // If validation successful
            if (editUpdate) {
                if (cmd.UpdateSemester(semester)) {
                    mainForm.GetView("Semesters");
                }
            } else {
                if (cmd.AddSemester(semester)) {
                    mainForm.GetView("Semesters");
                }
            }
        }
    }
}
