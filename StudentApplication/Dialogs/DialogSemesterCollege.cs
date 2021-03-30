using System;
using System.Data;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApp_Model;

namespace StudentApplication.Dialogs {
    public partial class DialogSemesterCollege : Form {

        private MainForm mainForm;
        private IMainDAL cmd = new MainDAL();
        private SemesterKey semesterKey;
        private string semesterName;
        private int collegeId;
        private string collegeName;
        ColumnProperties columnProperties = new ColumnProperties();
        BuildView semesterCollegeView;

        // From College
        public DialogSemesterCollege(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            collegeId = (int)row.Cells["CollegeId"].Value;
            collegeName = row.Cells["CollegeName"].Value.ToString();

            LBL_DialogSemesterCollege_Name.Text = "College:";
            LBL_DialogSemesterCollege_Value.Text = collegeName;

            semesterCollegeView = new BuildView() {
                GridView = DGV_SemesterCollege,
                TabledData = cmd.SemestersNotAssignedToCollege(collegeId),
                DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.year,
                            columnProperties.isSecondSemester,
                            columnProperties.semesterKey,
                            columnProperties.semesterName_Dialog
                        }
            };
            semesterCollegeView.Create();

            if (semesterCollegeView.ResultCount < 1) {
                LBL_DialogSemesterCollege_Results.Text = "No available Semester(s)";
                BTN_DialogSemesterCollegeAdd.Enabled = false;
            } else {
                LBL_DialogSemesterCollege_Results.Text = semesterCollegeView.ResultCount.ToString() + " available Semester(s)";
            }
        }
        // From Semester - alternate signature
        public DialogSemesterCollege(MainForm form, DataGridView dgv, int rowNumber) {

            InitializeComponent();

            mainForm = form;
            DataGridViewRow row = dgv.Rows[rowNumber];
            semesterKey = new SemesterKey(row.Cells["SemesterKey"].Value.ToString());
            semesterName = row.Cells["SemesterName"].Value.ToString();

            LBL_DialogSemesterCollege_Name.Text = "Semester:";
            LBL_DialogSemesterCollege_Value.Text = semesterName;

            semesterCollegeView = new BuildView() {
                GridView = DGV_SemesterCollege,
                TabledData = cmd.CollegesNotOperatingDuringSemester(semesterKey.Key),
                DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.collegeId_Hidden,
                            columnProperties.collegeName,
                            columnProperties.address,
                            columnProperties.city,
                            columnProperties.state,
                            columnProperties.postCode,
                            columnProperties.semesterKey
                        }
            };
            semesterCollegeView.Create();


            if (semesterCollegeView.ResultCount < 1) {
                LBL_DialogSemesterCollege_Results.Text = "No available College(s)";
                BTN_DialogSemesterCollegeAdd.Enabled = false;
            } else {
                if (mainForm.currentSemester.Key >= semesterKey.Key) {
                    BTN_DialogSemesterCollegeAdd.Enabled = false;
                    LBL_DialogSemesterCollege_Results.Text = "Cannot operate in the past " + semesterCollegeView.ResultCount.ToString() + " College(s)";

                } else {
                    LBL_DialogSemesterCollege_Results.Text = semesterCollegeView.ResultCount.ToString() + " available College(s)";
                }
            }
        }

        private void BTN_DialogSemesterCollegeAdd_Click(object sender, EventArgs e) {
            if (LBL_DialogSemesterCollege_Name.Text.Contains("College")) {
                if (DGV_SemesterCollege.SelectedRows[0].Index < 0) {
                    _ = MessageBox.Show(null, "A selection is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                semesterKey = new SemesterKey(DGV_SemesterCollege.SelectedRows[0].Cells["SemesterKey"].Value.ToString());
                SemesterAtCollege semesterAtCollege = new SemesterAtCollege() {
                    Year = new DateTime(semesterKey.Year, 1, 1),
                    SecondSemester = semesterKey.Semester == 2,
                    CollegeId = collegeId
                };
                if (cmd.AddSemesterAtCollege(semesterAtCollege)) {
                    mainForm.GoToSemesterAtCollege(semesterKey.Key, collegeId);
                }
            } else if (LBL_DialogSemesterCollege_Name.Text.Contains("Semester")) {
                if (DGV_SemesterCollege.SelectedRows[0].Index < 0) {
                    _ = MessageBox.Show(null, "A selection is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                collegeId = (int)DGV_SemesterCollege.SelectedRows[0].Cells["CollegeId"].Value;
                SemesterAtCollege semesterAtCollege = new SemesterAtCollege() {
                    Year = new DateTime(semesterKey.Year, 1, 1),
                    SecondSemester = semesterKey.Semester == 2,
                    CollegeId = collegeId
                };
                if (cmd.AddSemesterAtCollege(semesterAtCollege)) {
                    mainForm.GoToSemesterAtCollege(semesterKey.Key, collegeId);
                }
            }
        }
    }
}
                // // which is preferred ??
                // object objectThatIsAlwaysAnInt = 2;
                // int myInt;
                // myInt = int.TryParse(objectThatIsAlwaysAnInt.ToString(), out int result) ? result : 0;
                // myInt = int.Parse(objectThatIsAlwaysAnInt.ToString());
                // myInt = (int)objectThatIsAlwaysAnInt;
