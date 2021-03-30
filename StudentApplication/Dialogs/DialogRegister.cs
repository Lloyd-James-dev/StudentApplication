using StudentApp_Controller;
using StudentApp_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentApplication.Dialogs {
    public partial class DialogRegister : Form {

        private IMainDAL cmd = new MainDAL();
        private MainForm mainForm;
        private string college;
        private string semesterName;
        private SemesterKey semesterKey;
        private int collegeId;
        private string student;
        private string studentEmail;

        // From Student
        public DialogRegister(MainForm form, DataGridView dgv, int rowNumber) {

            InitializeComponent();

            // Add values to variables
            DataGridViewRow row = dgv.Rows[rowNumber];
            mainForm = form;
            studentEmail = row.Cells["Email"].Value.ToString();
            student = string.Format("{0} {1}", row.Cells["FirstName"].Value.ToString(), row.Cells["LastName"].Value.ToString());

            LBL_DialogRegister_Name.Text = "Student:";
            LBL_DialogRegister_Value.Text = student;
            LBL_DialogRegister_Semester.Visible = false;
            LBL_DialogRegister_SemesterValue.Visible = false;

            // Create DataGridView
            ColumnProperties columnProperties = new ColumnProperties();
            BuildView registerView = new BuildView() {
                GridView = DGV_DialogRegister,
                TabledData = cmd.AvailableStudentRegistrations(studentEmail),
                DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.year,
                            columnProperties.isSecondSemester,
                            columnProperties.semesterKey,
                            columnProperties.collegeId_Hidden,
                            columnProperties.collegeName
                        }
            };
            registerView.Create();

            // Sundry functions
            LBL_DialogRegisterResults.Text = string.Format("Select an entry from {0} available registration(s)", registerView.ResultCount.ToString());

        }

        // From Student Enrolments
        public DialogRegister(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            // Add values to variables
            mainForm = form;
            college = row.Cells["CollegeName"].Value.ToString();
            semesterName = row.Cells["SemesterName"].Value.ToString();
            semesterKey = new SemesterKey((int)row.Cells["SemesterKey"].Value);
            collegeId = (int)row.Cells["CollegeId"].Value;

            LBL_DialogRegister_Name.Text = "College:";
            LBL_DialogRegister_Value.Text = college;
            LBL_DialogRegister_Semester.Text = "Semester:";
            LBL_DialogRegister_SemesterValue.Text = semesterName;
            LBL_DialogRegister_Semester.Visible = true;
            LBL_DialogRegister_SemesterValue.Visible = true;

            // Create DataGridView
            ColumnProperties columnProperties = new ColumnProperties();
            BuildView registerView = new BuildView() {
                GridView = DGV_DialogRegister,
                TabledData = cmd.AllExceptRegisteredStudents(semesterKey.Key, collegeId),
                DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.studentFirstName_Dialog,
                            columnProperties.studentLastName_Dialog,
                            columnProperties.studentEmail
                        }
            };
            registerView.Create();

            // Sundry functions

            if (form.currentSemester.Key >= semesterKey.Key) {
                BTN_DialogRegisterAdd.Enabled = false;
                LBL_DialogRegisterResults.Text = string.Format("Cannot register in the past {0} unregistered students(s)", registerView.ResultCount.ToString());
            } else {
            LBL_DialogRegisterResults.Text = string.Format("Select a student from {0} unregistered students(s)", registerView.ResultCount.ToString());
            }

        }

        private void BTN_DialogRegisterAdd_Click(object sender, EventArgs e) {
            RegisterStudentInSemesterAtCollege regedStudent;
            if (LBL_DialogRegister_Name.Text.Contains("College")) {
                if (DGV_DialogRegister.SelectedRows[0].Index < 0) {
                    _ = MessageBox.Show(null, "A selection is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                regedStudent = new RegisterStudentInSemesterAtCollege() {
                    StudentEmail = DGV_DialogRegister.SelectedRows[0].Cells["StudentEmail"].Value.ToString(),
                    Year = new DateTime(semesterKey.Year, 1, 1).Date,
                    SecondSemester = semesterKey.Semester == 2,
                    CollegeId = collegeId,
                    RegistrationDate = DateTime.Now.Date
                };
                if (cmd.AddRegistration(regedStudent)) {
                    mainForm.GoToRegistrations(
                        semesterKey.Key,
                        collegeId,
                        DGV_DialogRegister.SelectedRows[0].Cells["StudentEmail"].Value.ToString()
                    );
                }
            } else {
                if (DGV_DialogRegister.SelectedRows[0].Index < 0) {
                    _ = MessageBox.Show(null, "A selection is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SemesterKey key = new SemesterKey((int)DGV_DialogRegister.SelectedRows[0].Cells["SemesterKey"].Value);
                regedStudent = new RegisterStudentInSemesterAtCollege() {
                    StudentEmail = studentEmail,
                    Year = new DateTime(key.Year, 1, 1).Date,
                    SecondSemester = key.Semester.Equals(2),
                    CollegeId = (int)DGV_DialogRegister.SelectedRows[0].Cells["CollegeId"].Value,
                    RegistrationDate = DateTime.Now.Date
                };
                if (cmd.AddRegistration(regedStudent)) {
                    mainForm.GoToRegistrations(
                        key.Key,
                        (int)DGV_DialogRegister.SelectedRows[0].Cells["CollegeId"].Value,
                        studentEmail
                    );
                }
            }
        }
    }
}
