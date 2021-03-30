using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApp_Model;

namespace StudentApplication.Dialogs {
    public partial class DialogSubjectUnit : Form {

        private IMainDAL cmd = new MainDAL();
        private readonly MainForm mainForm;
        private int coreCount = 0;
        private int deselectedCount = 0;
        private SemesterKey currentSemester;
        private SemesterKey semesterKey;
        private string semesterName;
        private int collegeId;
        private string college;
        private string courseCode;
        private string courseName;
        private List<UnitInSubjectInCourseAtSemesterAtCollege> loadedUnits;
        private List<UnitInSubjectInCourseAtSemesterAtCollege> selectedUnits;
        private BuildView subjectUnitView;
        private ColumnProperties columnProperties = new ColumnProperties() { };
        private ComboBoxColumn comboBoxColumn;

        public DialogSubjectUnit(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            // Add values to variables
            mainForm = form;
            currentSemester = mainForm.currentSemester;
            semesterKey = new SemesterKey(row.Cells["SemesterKey"].Value.ToString());
            semesterName = row.Cells["SemesterName"].Value.ToString();
            collegeId = (int)row.Cells["CollegeId"].Value;
            college = row.Cells["CollegeName"].Value.ToString();
            courseCode = row.Cells["CourseCode"].Value.ToString();
            courseName = row.Cells["CourseName"].Value.ToString();

            // Create DataGridView
            comboBoxColumn = columnProperties.subject;
            comboBoxColumn.ComboData = new MainDAL().ViewSubjectAssignments(semesterKey.Key, collegeId, courseCode, 0, "");
            subjectUnitView = new BuildView() {
                GridView = DGV_DialogSubjectUnit,
                TabledData = cmd.SpecialSubjectUnit(semesterKey.Key, collegeId, courseCode),
                DataGridViewColumns = new DataGridViewColumn[]{
                    columnProperties.courseCode_Hidden,
                    columnProperties.unitCode,
                    columnProperties.unitDescription,
                    columnProperties.subjectId_Hidden,
                    columnProperties.subjectName_Hidden,
                    columnProperties.core,
                    columnProperties.select_CheckBox
                },
                ComboBoxColumns = new ComboBoxColumn[] {
                    comboBoxColumn
                },
                EditMode = DataGridViewEditMode.EditOnEnter
            };
            comboBoxColumn.Create(); // Column must be added to grid on 'data binding complete'
            subjectUnitView.Create();

            // Sundry functions
            GetLoadedUnits();
            SelectCore();
            LBL_DialogSubjectUnit_Course.Text = courseCode + " - " + courseName;
            LBL_DialogSubjectUnit_College.Text = college;
            LBL_DialogSubjectUnit_Semester.Text = semesterName;
        }

        private void WriteResults() {
            if (currentSemester.Key >= semesterKey.Key) {
                BTN_DialogSubjectUnitAdd.Enabled = false;
                BTN_DialogSubjectUnitDeleteAll.Enabled = false;
                LBL_DialogSubjectUnitResults.Text = string.Format(
                    "Cannot modify a past instance of ({0} core + {1} elective) {2} selected from {3} units",
                    coreCount,
                    (subjectUnitView.ResultCount - (coreCount + deselectedCount)).ToString(),
                    (subjectUnitView.ResultCount - (deselectedCount)).ToString(), subjectUnitView.ResultCount.ToString()
                );
            } else {
                LBL_DialogSubjectUnitResults.Text = string.Format(
                    "({0} core + {1} elective) {2} selected from {3} units",
                    coreCount,
                    (subjectUnitView.ResultCount - (coreCount + deselectedCount)).ToString(),
                    (subjectUnitView.ResultCount - (deselectedCount)).ToString(), subjectUnitView.ResultCount.ToString()
                );
            }
        }

        private void SelectCore() {
            for (int i = 0; i < DGV_DialogSubjectUnit.Rows.Count; i++) {
                if (DGV_DialogSubjectUnit.Rows[i].Cells["Core"].Value.ToString() == "Core") {
                    DataGridViewCheckBoxCell chkCell = DGV_DialogSubjectUnit.Rows[i].Cells["Select"] as DataGridViewCheckBoxCell;
                    chkCell.Value = true;
                }
            }
        }
        private void SetEnabled() {
            coreCount = 0;
            deselectedCount = 0;
            for (int i = 0; i < DGV_DialogSubjectUnit.Rows.Count; i++) {

                // TODO this should mark core units as selected and highlight red for 

                if ((bool)DGV_DialogSubjectUnit.Rows[i].Cells["Select"].FormattedValue) {
                    ComboCellStyleEnabled(DGV_DialogSubjectUnit.Rows[i].Cells[comboBoxColumn.Name]);
                    if (DGV_DialogSubjectUnit.Rows[i].Cells["Core"].Value.ToString() == "Core") {
                        DGV_DialogSubjectUnit.Rows[i].Cells["Core"].Style.ForeColor = ColumnProperties.coreColour;
                        CheckCellStyleCore(DGV_DialogSubjectUnit.Rows[i].Cells["Select"]);
                        coreCount++;
                    } else {
                        DGV_DialogSubjectUnit.Rows[i].Cells["Select"].ReadOnly = false;
                    }
                } else {
                    ComboCellStyleDisabled(DGV_DialogSubjectUnit.Rows[i].Cells[comboBoxColumn.Name]);
                    DGV_DialogSubjectUnit.Rows[i].Cells["Select"].ReadOnly = false;
                    deselectedCount++;
                }
            }
            WriteResults();
        }
        private void GetLoadedUnits() {
            loadedUnits = new List<UnitInSubjectInCourseAtSemesterAtCollege>();
            for (int i = 0; i < DGV_DialogSubjectUnit.Rows.Count; i++) {
                if ((bool)DGV_DialogSubjectUnit.Rows[i].Cells["Select"].FormattedValue) {
                    UnitInSubjectInCourseAtSemesterAtCollege unitsInSubject = new UnitInSubjectInCourseAtSemesterAtCollege() {
                        Year = new DateTime(semesterKey.Year, 1, 1),
                        SecondSemester = semesterKey.Semester.Equals(2),
                        CollegeId = collegeId,
                        CourseCode = courseCode,
                        SubjectId = (int)DGV_DialogSubjectUnit.Rows[i].Cells["SubjectId"].Value,
                        UnitCode = DGV_DialogSubjectUnit.Rows[i].Cells["UnitCode"].Value.ToString()
                    };
                    loadedUnits.Add(unitsInSubject);
                }
            }
        }

        private void CheckCellStyleCore(DataGridViewCell cell) {
            DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
            chkCell.FlatStyle = ColumnProperties.disabledStyle;
            chkCell.Style.ForeColor = ColumnProperties.disabledColour;
            cell.ReadOnly = true;
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

        private void DGV_DialogSubjectUnit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            if (subjectUnitView.IsFormattingComplete) {
                // Adding ComboBoxColumn before SetEnabled() is Run
                if (DGV_DialogSubjectUnit.Columns[comboBoxColumn.Name] == null) {
                    subjectUnitView.AddComboBoxColumns();
                }
                SetEnabled();
            }
        }
        private void DGV_DialogSubjectUnit_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DGV_DialogSubjectUnit.Columns[e.ColumnIndex].Name == "Select" && e.RowIndex >= 0) {
                if (DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells["Select"].ReadOnly == false) {
                    if ((bool)DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells["Select"].EditedFormattedValue) {
                        ComboCellStyleEnabled(DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells[comboBoxColumn.Name]);
                        deselectedCount--;
                    } else {
                        // Hardcoded as int for this dialog
                        //if (DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells[comboBoxColumn.Name].ValueType.Equals(typeof(string))) {
                        //    DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells[comboBoxColumn.Name].Value = "";
                        //} else if (DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells[comboBoxColumn.Name].ValueType.Equals(typeof(int))) {
                        DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells[comboBoxColumn.Name].Value = 0;
                        //}
                        ComboCellStyleDisabled(DGV_DialogSubjectUnit.Rows[e.RowIndex].Cells[comboBoxColumn.Name]);
                        deselectedCount++;
                    }
                    WriteResults();
                }
            }
        }
        private void BTN_DialogSubjectUnitAdd_Click(object sender, EventArgs e) {
            if (currentSemester.Key >= semesterKey.Key) {
                _ = MessageBox.Show(null, "You cannot modify a course after it has commenced.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                return;
            }
            DataGridViewRow dgvRow;
            deselectedCount = 0;
            selectedUnits = new List<UnitInSubjectInCourseAtSemesterAtCollege>();
            for (int i = 0; i < DGV_DialogSubjectUnit.Rows.Count; i++) {
                dgvRow = DGV_DialogSubjectUnit.Rows[i];
                if ((bool)dgvRow.Cells["Select"].FormattedValue) {
                    if ((int)dgvRow.Cells["Subject"].Value == 0) {
                        _ = MessageBox.Show(null, "Each Selected Unit must have a Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    UnitInSubjectInCourseAtSemesterAtCollege unitsInSubject = new UnitInSubjectInCourseAtSemesterAtCollege() {
                        Year = new DateTime(semesterKey.Year, 1, 1),
                        SecondSemester = semesterKey.Semester.Equals(2),
                        CollegeId = collegeId,
                        CourseCode = courseCode,
                        SubjectId = (int)dgvRow.Cells["Subject"].Value,
                        UnitCode = dgvRow.Cells["UnitCode"].Value.ToString()
                    };
                    selectedUnits.Add(unitsInSubject);
                }
            }
            var toAdd = selectedUnits
                .Select(o => new { o.Year, o.SecondSemester, o.CollegeId, o.CourseCode, o.SubjectId, o.UnitCode })
                .Except(
                    loadedUnits
                    .Select(o => new { o.Year, o.SecondSemester, o.CollegeId, o.CourseCode, o.SubjectId, o.UnitCode })
                );

            var toDelete = loadedUnits
                .Select(o => new { o.Year, o.SecondSemester, o.CollegeId, o.CourseCode, o.SubjectId, o.UnitCode })
                .Except(
                    selectedUnits
                    .Select(o => new { o.Year, o.SecondSemester, o.CollegeId, o.CourseCode, o.SubjectId, o.UnitCode })
                );
            if (toAdd.Count() < 1 && toDelete.Count() < 1) {
                _ = MessageBox.Show(null, "No modifications have been made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //if (cmd.CountUnitsInCourse(semesterKey, collegeId, courseCode) > 0) {
            //    _ = MessageBox.Show(null, "Unassign all dependent units from this course instance before modifying subjects.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    DialogResult = DialogResult.Cancel;
            //    return;
            //}
            List<UnitInSubjectInCourseAtSemesterAtCollege> a = new List<UnitInSubjectInCourseAtSemesterAtCollege>();
            List<UnitInSubjectInCourseAtSemesterAtCollege> d = new List<UnitInSubjectInCourseAtSemesterAtCollege>();
            if (toAdd.Count() > 0) {
                foreach (var item in toAdd) {
                    a.Add(new UnitInSubjectInCourseAtSemesterAtCollege {
                        Year = item.Year,
                        SecondSemester = item.SecondSemester,
                        CollegeId = item.CollegeId,
                        CourseCode = item.CourseCode,
                        SubjectId = item.SubjectId,
                        UnitCode = item.UnitCode
                    });
                }
            }
            if (toDelete.Count() > 0) {
                foreach (var item in toDelete) {
                    d.Add(new UnitInSubjectInCourseAtSemesterAtCollege {
                        Year = item.Year,
                        SecondSemester = item.SecondSemester,
                        CollegeId = item.CollegeId,
                        CourseCode = item.CourseCode,
                        SubjectId = item.SubjectId,
                        UnitCode = item.UnitCode
                    });
                }
            }
            if (cmd.ModifySubjectUnit(a, d)) {
                mainForm.GoToUnitsInSubjects(semesterKey.Key, collegeId, courseCode);
            }

            DialogResult = DialogResult.OK;
        }
        private void BTN_DialogSubjectUnitDeleteAll_Click(object sender, EventArgs e) {
            if (currentSemester.Key >= semesterKey.Key) {
                _ = MessageBox.Show(null, "You cannot modify a course after it has commenced.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                return;
            }
            var result = MessageBox.Show(null, "Are you sure you want to delete all assigned units?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                if (cmd.ModifySubjectUnit(new List<UnitInSubjectInCourseAtSemesterAtCollege>(), loadedUnits)) {
                    mainForm.GoToSubjectsInCourses(semesterKey.Key, collegeId, courseCode);
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
