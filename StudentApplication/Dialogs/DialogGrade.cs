using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApp_Model;

namespace StudentApplication.Dialogs {
    public partial class DialogGrade : Form {

        private IMainDAL cmd = new MainDAL();
        private int gradedCount = 0;
        private string semesterName;
        private SemesterKey semesterKey;
        private int collegeId;
        private string college;
        private string courseCode;
        private string course;
        private string email;
        private string name;
        private List<StudentUnitGrade> loadedGrades;
        private List<StudentUnitGrade> selectedGrades;
        private BuildView gradesView;

        public DialogGrade(MainForm form, DataGridViewRow row) {
            // Mainform currently unused - keeping dialog constructor params consistant

            InitializeComponent();

            semesterKey = new SemesterKey((int)row.Cells["SemesterKey"].Value);
            collegeId = (int)row.Cells["CollegeId"].Value;
            courseCode = row.Cells["CourseCode"].Value.ToString();
            email = row.Cells["StudentEmail"].Value.ToString();
            name = row.Cells["StudentFullName"].Value.ToString();
            college = row.Cells["CollegeName"].Value.ToString();
            semesterName = row.Cells["SemesterName"].Value.ToString();
            course = row.Cells["CourseName"].Value.ToString();

            LBL_DialogGrade_Name.Text = name;
            LBL_DialogGrade_College.Text = college;
            LBL_DialogGrade_Semester.Text = semesterName;
            LBL_DialogGrade_Course.Text = courseCode + " - " + course;

            ColumnProperties columnProperties = new ColumnProperties();
            gradesView = new BuildView() {
                GridView = DGV_DialogGrade,
                TabledData = cmd.DialogGrades(semesterKey.Key, collegeId, email, courseCode),
                DataGridViewColumns = new DataGridViewColumn[]{
                    columnProperties.unitCode,
                    columnProperties.unitDescription,
                    columnProperties.subjectName,
                    columnProperties.subjectId_Hidden,
                    columnProperties.competent_CheckBox,
                    columnProperties.rpl_CheckBox,
                    columnProperties.dateGraded
                },
                EditMode = DataGridViewEditMode.EditOnEnter
            };
            gradesView.Create();
            GetGradedUnits();
        }

        private void GetGradedUnits() {
            gradedCount = 0;
            loadedGrades = new List<StudentUnitGrade>();
            for (int i = 0; i < DGV_DialogGrade.Rows.Count; i++) {
                if ((bool)DGV_DialogGrade.Rows[i].Cells["Competent"].FormattedValue) {
                    StudentUnitGrade studentUnitGrade = new StudentUnitGrade() {
                        StudentEmail = email,
                        UnitCode = DGV_DialogGrade.Rows[i].Cells["UnitCode"].Value.ToString(),
                        SubjectId = (int)DGV_DialogGrade.Rows[i].Cells["SubjectId"].Value,
                        CourseCode = courseCode,
                        Year = new DateTime(semesterKey.Year, 1, 1),
                        SecondSemester = semesterKey.Semester.Equals(2),
                        CollegeId = collegeId,
                        Grade = (bool)DGV_DialogGrade.Rows[i].Cells["Competent"].FormattedValue,
                        RPL = (bool)DGV_DialogGrade.Rows[i].Cells["RPL"].FormattedValue,
                        DateGraded = DateTime.Parse(DGV_DialogGrade.Rows[i].Cells["DateGraded"].Value.ToString()).Date
                    };
                    loadedGrades.Add(studentUnitGrade);
                    gradedCount++;
                }
            }
            WriteResults();
        }
        private void WriteResults() {
            LBL_DialogGradeResults.Text = string.Format("{0} graded from {1} units", gradedCount.ToString(), gradesView.ResultCount.ToString());
        }

        private void DGV_DialogGrade_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            if (e.Exception.Message.Equals("Formatted value of the cell has a wrong type.")) {
                e.Cancel = true; // allowing null values
            } else {
                // Other DataError exceptions should be handled - none have been thrown dev/testing
                //e.ThrowException = true;
            }
        }
        private void DGV_DialogGrade_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DGV_DialogGrade.Columns[e.ColumnIndex].Name == "Competent" && e.RowIndex >= 0) {
                if ((bool)DGV_DialogGrade.Rows[e.RowIndex].Cells["Competent"].EditedFormattedValue) {
                    gradedCount++;

                } else {
                    DGV_DialogGrade.Rows[e.RowIndex].Cells["RPL"].Value = false;
                    gradedCount--;
                }
            }
            if (DGV_DialogGrade.Columns[e.ColumnIndex].Name == "RPL" && e.RowIndex >= 0) {
                // fails if not boolean - treating null values as false
                try {
                    if ((bool)DGV_DialogGrade.Rows[e.RowIndex].Cells["RPL"].EditedFormattedValue) {
                        if (!(bool)DGV_DialogGrade.Rows[e.RowIndex].Cells["Competent"].EditedFormattedValue) {
                            gradedCount++;
                        }
                        DGV_DialogGrade.Rows[e.RowIndex].Cells["Competent"].Value = true;
                    }
                } catch { }
            }
            WriteResults();
        }

        private void BTN_DialogGradeAdd_Click(object sender, EventArgs e) {
            selectedGrades = new List<StudentUnitGrade>();
            for (int i = 0; i < DGV_DialogGrade.Rows.Count; i++) {
                if ((bool)DGV_DialogGrade.Rows[i].Cells["Competent"].FormattedValue) {
                    StudentUnitGrade studentUnitGrade = new StudentUnitGrade() {
                        StudentEmail = email,
                        UnitCode = DGV_DialogGrade.Rows[i].Cells["UnitCode"].Value.ToString(),
                        SubjectId = (int)DGV_DialogGrade.Rows[i].Cells["SubjectId"].Value,
                        CourseCode = courseCode,
                        Year = new DateTime(semesterKey.Year, 1, 1),
                        SecondSemester = semesterKey.Semester.Equals(2),
                        CollegeId = collegeId,
                        Grade = (bool)DGV_DialogGrade.Rows[i].Cells["Competent"].FormattedValue,
                        RPL = (bool)DGV_DialogGrade.Rows[i].Cells["RPL"].FormattedValue,
                        DateGraded =
                            DGV_DialogGrade.Rows[i].Cells["DateGraded"].Value.Equals(DBNull.Value) ?
                            DateTime.Now.Date :
                            DateTime.Parse(DGV_DialogGrade.Rows[i].Cells["DateGraded"].Value.ToString()).Date
                    };
                    selectedGrades.Add(studentUnitGrade);
                }
            }
            var toAdd = selectedGrades
                .Select(o => new { o.StudentEmail, o.UnitCode, o.SubjectId, o.CourseCode, o.Year, o.SecondSemester, o.CollegeId, o.Grade, o.RPL, o.DateGraded })
                .Except(
                    loadedGrades
                    .Select(o => new { o.StudentEmail, o.UnitCode, o.SubjectId, o.CourseCode, o.Year, o.SecondSemester, o.CollegeId, o.Grade, o.RPL, o.DateGraded })
                );

            var toDelete = loadedGrades
                .Select(o => new { o.StudentEmail, o.UnitCode, o.SubjectId, o.CourseCode, o.Year, o.SecondSemester, o.CollegeId, o.Grade, o.RPL, o.DateGraded })
                .Except(
                    selectedGrades
                    .Select(o => new { o.StudentEmail, o.UnitCode, o.SubjectId, o.CourseCode, o.Year, o.SecondSemester, o.CollegeId, o.Grade, o.RPL, o.DateGraded })
                );
            if (toAdd.Count() < 1 && toDelete.Count() < 1) {
                _ = MessageBox.Show(null, "No modifications have been made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<StudentUnitGrade> a = new List<StudentUnitGrade>();
            List<StudentUnitGrade> d = new List<StudentUnitGrade>();
            if (toAdd.Count() > 0) {
                foreach (var item in toAdd) {
                    a.Add(new StudentUnitGrade {
                        StudentEmail = item.StudentEmail,
                        UnitCode = item.UnitCode,
                        SubjectId = item.SubjectId,
                        CourseCode = item.CourseCode,
                        Year = item.Year,
                        SecondSemester = item.SecondSemester,
                        CollegeId = item.CollegeId,
                        Grade = item.Grade,
                        RPL = item.RPL,
                        DateGraded = item.DateGraded
                    });
                }
            }
            if (toDelete.Count() > 0) {
                foreach (var item in toDelete) {
                    d.Add(new StudentUnitGrade {
                        StudentEmail = item.StudentEmail,
                        UnitCode = item.UnitCode,
                        SubjectId = item.SubjectId,
                        CourseCode = item.CourseCode,
                        Year = item.Year,
                        SecondSemester = item.SecondSemester,
                        CollegeId = item.CollegeId,
                        Grade = item.Grade,
                        RPL = item.RPL,
                        DateGraded = item.DateGraded
                    });
                }
            }
            if (cmd.ModifyStudentGrades(a, d)) {
                // no navigation required
            }
        }
    }
}
