using System;
using System.Windows.Forms;
using StudentApp_Model;
using StudentApp_Controller;

namespace StudentApplication.Dialogs {
    public partial class DialogEnrol : Form {

        private IMainDAL cmd = new MainDAL();
        private readonly MainForm mainForm;
        private SemesterKey currentSemester;
        private int availableCount;
        private int enroledCount;
        private string semesterName;
        private SemesterKey semesterKey;
        private int collegeId;
        private string college;
        private string name;
        private string email;
        private decimal fee;
        private BuildView enrolView;
        private ColumnProperties columnProperties;

        public DialogEnrol(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            // Add values to variables
            mainForm = form;
            name = row.Cells["StudentFullName"].Value.ToString();
            college = row.Cells["CollegeName"].Value.ToString();
            semesterName = row.Cells["SemesterName"].Value.ToString();
            email = row.Cells["StudentEmail"].Value.ToString();
            semesterKey = new SemesterKey((int)row.Cells["SemesterKey"].Value);
            collegeId = (int)row.Cells["CollegeId"].Value;
            currentSemester = mainForm.currentSemester;
            LBL_DialogEnrol_Name.Text = name;
            LBL_DialogEnrol_College.Text = college;
            LBL_DialogEnrol_Semester.Text = semesterName;

            // Create DataGridView
            columnProperties = new ColumnProperties() { };
            enrolView = new BuildView() {
                GridView = DGV_DialogEnrol,
                TabledData = cmd.DialogEnrolment(semesterKey.Key, collegeId, email),
                DataGridViewColumns = new DataGridViewColumn[]{
                    columnProperties.courseCode,
                    columnProperties.courseName,
                    columnProperties.year,
                    columnProperties.isSecondSemester,
                    columnProperties.collegeName,
                    columnProperties.fee,
                    columnProperties.dateEnroled,
                    columnProperties.select_Hidden
                },
                ButtonColumns = new ButtonColumn[] {
                    columnProperties.enrol
                }
            };
            enrolView.Create();

            // Sundry functions
            DGV_DialogEnrol.CurrentCellDirtyStateChanged += new EventHandler(DGV_DialogEnrol_CurrentCellDirtyStateChanged);
        }

        private void WriteResults() {
            LBL_DialogEnrolResults.Text = string.Format("{0} enrolment(s) and {1} available course(s)", enroledCount.ToString(), (availableCount).ToString());
        }
        private void SetEnabled() {
            enroledCount = 0;
            availableCount = enrolView.ResultCount;
            for (int i = 0; i < DGV_DialogEnrol.RowCount; i++) {
                if ((bool)DGV_DialogEnrol.Rows[i].Cells["Select"].FormattedValue) {
                    for (int ii = 0; ii < DGV_DialogEnrol.ColumnCount; ii++) {
                        if (DGV_DialogEnrol.Rows[i].Cells[ii].OwningColumn.Name == "Enrol") {
                            ButtonCellStyleEnroled(DGV_DialogEnrol.Rows[i].Cells["Enrol"]);
                            enroledCount++;
                            availableCount--;
                        } else {
                            CellStyleDisabled(DGV_DialogEnrol.Rows[i].Cells[DGV_DialogEnrol.Rows[i].Cells[ii].OwningColumn.Index]);
                        }
                    }
                } else if (currentSemester.Key >= semesterKey.Key) {
                    for (int ii = 0; ii < DGV_DialogEnrol.ColumnCount; ii++) {
                        if (DGV_DialogEnrol.Rows[i].Cells[ii].OwningColumn.Name == "Enrol") {
                            ButtonCellStyleEnroled(DGV_DialogEnrol.Rows[i].Cells["Enrol"]);
                            availableCount--;
                        } else {
                            CellStyleDisabled(DGV_DialogEnrol.Rows[i].Cells[DGV_DialogEnrol.Rows[i].Cells[ii].OwningColumn.Index]);
                        }
                    }
                }
            }
            WriteResults();
        }
        // style cells
        private void ButtonCellStyleEnroled(DataGridViewCell cell) {
            DataGridViewDisableButtonCell btnCell = cell as DataGridViewDisableButtonCell;
            btnCell.Style = ColumnProperties.btnCellStyle;
            btnCell.FlatStyle = ColumnProperties.disabledStyle;
            btnCell.Style.ForeColor = ColumnProperties.disabledColour;
            btnCell.Enabled = false;
            cell.ReadOnly = true;
        }
        private void CellStyleDisabled(DataGridViewCell cell) {
            cell.Style.ForeColor = ColumnProperties.disabledColour;
            cell.ReadOnly = true;
        }

        private void DGV_DialogEnrol_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1 &&
                DGV_DialogEnrol.Rows[e.RowIndex].Cells["Enrol"].ColumnIndex == e.ColumnIndex &&
                DGV_DialogEnrol.Rows[e.RowIndex].Cells["Enrol"].ReadOnly == false) {
                if (ValidateInput.IsValid(DGV_DialogEnrol.Rows[e.RowIndex].Cells["Fee"].Value.ToString(), out decimal result)) {
                    fee = result;
                }
                EnrolStudent(DGV_DialogEnrol.Rows[e.RowIndex].Cells["CourseCode"].Value.ToString());
            }
        }
        private void DGV_DialogEnrol_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            SetEnabled();
        }
        // This event handler manually raises the CellValueChanged event by calling the CommitEdit method.
        private void DGV_DialogEnrol_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (DGV_DialogEnrol.IsCurrentCellDirty) {
                DGV_DialogEnrol.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void EnrolStudent(string courseCode) {
            DateTime year = new DateTime(semesterKey.Year, 1, 1);
            bool semester = semesterKey.Semester == 2;

            RegisteredStudentEnrolInCourseAtSemesterAtCollege enrolStudent = new RegisteredStudentEnrolInCourseAtSemesterAtCollege() {
                StudentEmail = email,
                StudentYear = year,
                StudentSecondSemester = semester,
                StudentCollegeId = collegeId,
                CourseCode = courseCode,
                CourseYear = year,
                CourseSecondSemester = semester,
                CourseCollegeId = collegeId,
                EnrolmentDate = DateTime.Now.Date
            };
            Invoice invoice = new Invoice() {
                StudentEmail = email,
                EnroledStudentEmail = email,
                StudentYear = year,
                StudentSecondSemester = semester,
                StudentCollegeId = collegeId,
                CourseCode = courseCode,
                CourseYear = year,
                CourseSecondSemester = semester,
                CourseCollegeId = collegeId,
                Amount = 0 - fee,
                Misc = "",
                InvoiceDate = DateTime.Now.Date
            };

            var result = MessageBox.Show(null, string.Format("You will be Invoiced {0:C} for this Enrolment.", fee), "Confirm Enrolment", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                if (cmd.AddEnrolment(enrolStudent, invoice)) {
                    mainForm.GoToEnrolments(semesterKey.Key, collegeId, email);
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
