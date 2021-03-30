using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApp_Model;

namespace StudentApplication.Dialogs {
    public partial class DialogCourseSubject : Form {

        private IMainDAL cmd = new MainDAL();
        private MainForm mainForm;
        private int deselectedCount = 0;
        private SemesterKey currentSemester;
        private SemesterKey semesterKey;
        private string semesterName;
        private int collegeId;
        private string college;
        private string courseCode;
        private string courseName;
        private List<SubjectInCourseAtSemesterAtCollege> loadedSubjects;
        private List<SubjectInCourseAtSemesterAtCollege> selectedSubjects;
        private BuildView courseSubjectView;
        private ColumnProperties columnProperties = new ColumnProperties() { };
        private ComboBoxColumn comboBoxColumn;

        public DialogCourseSubject(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            // Add values to variables
            mainForm = form;
            currentSemester = mainForm.currentSemester;
            semesterKey = new SemesterKey((int)row.Cells["SemesterKey"].Value);
            semesterName = row.Cells["SemesterName"].Value.ToString();
            collegeId = (int)row.Cells["CollegeId"].Value;
            college = row.Cells["CollegeName"].Value.ToString();
            courseCode = row.Cells["CourseCode"].Value.ToString();
            courseName = row.Cells["CourseName"].Value.ToString();

            // Create DataGridView
            comboBoxColumn = columnProperties.teacher;
            courseSubjectView = new BuildView() {
                GridView = DGV_DialogCourseSubject,
                TabledData = cmd.SpecialCourseSubject(semesterKey.Key, collegeId, courseCode),
                DataGridViewColumns = new DataGridViewColumn[]{
                    columnProperties.semesterKey,
                    columnProperties.collegeId_Hidden,
                    columnProperties.courseCode_Hidden,
                    columnProperties.subjectId_Hidden,
                    columnProperties.subjectName,
                    columnProperties.teacherFullName_Hidden,
                    columnProperties.teacherEmail_Hidden,
                    columnProperties.select_CheckBox

                },
                ComboBoxColumns = new ComboBoxColumn[] {
                    comboBoxColumn
                },
                EditMode = DataGridViewEditMode.EditOnEnter
            };
            comboBoxColumn.Create(); // Column must be added on 'data binding complete'
            courseSubjectView.Create();

            // Sundry functions
            GetLoadedSubjects();
            LBL_DialogCourseSubject_Course.Text = courseCode + " - " + courseName;
            LBL_DialogCourseSubject_College.Text = college;
            LBL_DialogCourseSubject_Semester.Text = semesterName;
        }

        private void WriteResults() {
            if (mainForm.currentSemester.Key >= semesterKey.Key) {
                BTN_DialogCourseSubjectAdd.Enabled = false;
                LBL_DialogCourseSubjectResults.Text = string.Format(
                    "Cannot modify a past instance of {0} selected from {1} subjects", 
                    (courseSubjectView.ResultCount - deselectedCount).ToString(), 
                    courseSubjectView.ResultCount.ToString()
                );
            } else {
                LBL_DialogCourseSubjectResults.Text = string.Format(
                    "{0} selected from {1} subjects", 
                    (courseSubjectView.ResultCount - deselectedCount).ToString(), 
                    courseSubjectView.ResultCount.ToString()
                );
            }
        }
        private void SetEnabled() {
            deselectedCount = 0;
            for (int i = 0; i < DGV_DialogCourseSubject.Rows.Count; i++) {
                if ((bool)DGV_DialogCourseSubject.Rows[i].Cells["Select"].FormattedValue) {
                    ComboCellStyleEnabled(DGV_DialogCourseSubject.Rows[i].Cells[comboBoxColumn.Name]);
                } else {
                    deselectedCount++;
                    ComboCellStyleDisabled(DGV_DialogCourseSubject.Rows[i].Cells[comboBoxColumn.Name]);
                }
                DGV_DialogCourseSubject.Rows[i].Cells["Select"].ReadOnly = false;
            }
            WriteResults();
        }
        private void GetLoadedSubjects() {
            loadedSubjects = new List<SubjectInCourseAtSemesterAtCollege>();
            for (int i = 0; i < DGV_DialogCourseSubject.Rows.Count; i++) {
                if ((bool)DGV_DialogCourseSubject.Rows[i].Cells["Select"].FormattedValue) {
                    SubjectInCourseAtSemesterAtCollege subjectTeacher = new SubjectInCourseAtSemesterAtCollege() {
                        Year = new DateTime(semesterKey.Year, 1, 1),
                        SecondSemester = semesterKey.Semester.Equals(2),
                        CollegeId = collegeId,
                        CourseCode = courseCode,
                        SubjectId = (int)DGV_DialogCourseSubject.Rows[i].Cells["SubjectId"].Value,
                        TeacherEmail = DGV_DialogCourseSubject.Rows[i].Cells["TeacherName"].FormattedValue.ToString()
                    };
                    loadedSubjects.Add(subjectTeacher);
                }
            }
        }

        private void ComboCellStyleDisabled(DataGridViewCell cell) {
            DataGridViewComboBoxCell comboBoxCell = cell as DataGridViewComboBoxCell;
            comboBoxCell.FlatStyle = ColumnProperties.disabledStyle;
            comboBoxCell.Style.ForeColor = ColumnProperties.disabledColour;
            cell.ReadOnly = true;
        }
        private void ComboCellStyleEnabled(DataGridViewCell cell) {
            DataGridViewComboBoxCell comboBoxCell = cell as DataGridViewComboBoxCell;
            comboBoxCell.FlatStyle = ColumnProperties.enabledStyle;
            comboBoxCell.Style.ForeColor = ColumnProperties.defaultColour;
            cell.ReadOnly = false;
        }

        private void DGV_DialogCourseSubject_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            // Adding ComboBoxColumn before SetEnabled() is Run
            if (DGV_DialogCourseSubject.Columns[comboBoxColumn.Name] == null) {
                courseSubjectView.AddComboBoxColumns();
            }
            if (courseSubjectView.IsFormattingComplete) {
                SetEnabled();
            }
        }
        private void DGV_DialogCourseSubject_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DGV_DialogCourseSubject.Columns[e.ColumnIndex].Name == "Select" && e.RowIndex >= 0) {
                if ((bool)DGV_DialogCourseSubject.Rows[e.RowIndex].Cells["Select"].EditedFormattedValue) {
                    ComboCellStyleEnabled(DGV_DialogCourseSubject.Rows[e.RowIndex].Cells[comboBoxColumn.Name]);
                    deselectedCount--;
                } else {
                    // Hardcoded as string for this dialog
                    //if (DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells[comboBoxColumn.Name].ValueType.Equals(typeof(string))) {
                    DGV_DialogCourseSubject.Rows[e.RowIndex].Cells[comboBoxColumn.Name].Value = "";
                    //} else if (DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells[comboBoxColumn.Name].ValueType.Equals(typeof(int))) {
                    //    DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells[comboBoxColumn.Name].Value = 0;
                    //}
                    ComboCellStyleDisabled(DGV_DialogCourseSubject.Rows[e.RowIndex].Cells[comboBoxColumn.Name]);
                    deselectedCount++;
                }
                WriteResults();
            }
        }
        private void BTN_DialogCourseSubjectAdd_Click(object sender, EventArgs e) {
            if (currentSemester.Key >= semesterKey.Key) {
                _ = MessageBox.Show(null, "You cannot modify a course after it has commenced.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                return;
            }
            deselectedCount = 0;
            selectedSubjects = new List<SubjectInCourseAtSemesterAtCollege>();
            for (int i = 0; i < DGV_DialogCourseSubject.Rows.Count; i++) {
                if ((bool)DGV_DialogCourseSubject.Rows[i].Cells["Select"].FormattedValue) {
                    SubjectInCourseAtSemesterAtCollege subjectTeacher = new SubjectInCourseAtSemesterAtCollege() {
                        Year = new DateTime(semesterKey.Year, 1, 1),
                        SecondSemester = semesterKey.Semester.Equals(2),
                        CollegeId = collegeId,
                        CourseCode = courseCode,
                        SubjectId = (int)DGV_DialogCourseSubject.Rows[i].Cells["SubjectId"].Value,
                        TeacherEmail = DGV_DialogCourseSubject.Rows[i].Cells["TeacherName"].Value.ToString()
                    };
                    selectedSubjects.Add(subjectTeacher);
                    if (DGV_DialogCourseSubject.Rows[i].Cells["TeacherName"].Value.ToString() == "") {
                        _ = MessageBox.Show(null, "Each Selected Subject must have a Teacher.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            var toAdd = selectedSubjects
                .Select(o => new { o.Year, o.SecondSemester, o.CollegeId, o.CourseCode, o.SubjectId, o.TeacherEmail })
                .Except(
                    loadedSubjects
                    .Select(o => new { o.Year, o.SecondSemester, o.CollegeId, o.CourseCode, o.SubjectId, o.TeacherEmail })
                );

            var toDelete = loadedSubjects
                .Select(o => new { o.Year, o.SecondSemester, o.CollegeId, o.CourseCode, o.SubjectId, o.TeacherEmail })
                .Except(
                    selectedSubjects
                    .Select(o => new { o.Year, o.SecondSemester, o.CollegeId, o.CourseCode, o.SubjectId, o.TeacherEmail })
                );
            if (toAdd.Count() < 1 && toDelete.Count() < 1) {
                _ = MessageBox.Show(null, "No modifications have been made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmd.CountUnitsInCourse(semesterKey.Key, collegeId, courseCode) > 0) {
                _ = MessageBox.Show(null, "Unassign all dependent units from this course instance before modifying subjects.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                return;
            }
            List<SubjectInCourseAtSemesterAtCollege> a = new List<SubjectInCourseAtSemesterAtCollege>();
            List<SubjectInCourseAtSemesterAtCollege> d = new List<SubjectInCourseAtSemesterAtCollege>();
            if (toAdd.Count() > 0) {
                foreach (var item in toAdd) {
                    a.Add(new SubjectInCourseAtSemesterAtCollege {
                        Year = item.Year,
                        SecondSemester = item.SecondSemester,
                        CollegeId = item.CollegeId,
                        CourseCode = item.CourseCode,
                        SubjectId = item.SubjectId,
                        TeacherEmail = item.TeacherEmail
                    });
                }
            }
            if (toDelete.Count() > 0) {
                foreach (var item in toDelete) {
                    d.Add(new SubjectInCourseAtSemesterAtCollege {
                        Year = item.Year,
                        SecondSemester = item.SecondSemester,
                        CollegeId = item.CollegeId,
                        CourseCode = item.CourseCode,
                        SubjectId = item.SubjectId,
                        TeacherEmail = item.TeacherEmail
                    });
                }
            }
            if (cmd.ModifyCourseSubject(a, d)) {
                mainForm.GoToSubjectsInCourses(semesterKey.Key, collegeId, courseCode);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
