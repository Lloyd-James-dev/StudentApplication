using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApp_Model;

namespace StudentApplication.Dialogs {
    public partial class DialogCourseUnit : Form {

        private IMainDAL cmd = new MainDAL();
        private MainForm mainForm;
        public static int totalCount;
        public int resultCount = 0;
        public int selectedCount = 0;
        public int coreCount = 0;
        string courseCode;
        string courseName;
        List<UnitInCourse> loadedUnits;
        List<UnitInCourse> selectedUnits;
        BuildView courseUnitView;

        // "form" currently unused - keeping dialog constructor params consistant
        public DialogCourseUnit(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            courseCode = row.Cells["CourseCode"].Value.ToString();
            courseName = row.Cells["CourseName"].Value.ToString();

            ColumnProperties columnProperties = new ColumnProperties();
            courseUnitView = new BuildView() {
                GridView = DGV_DialogCourseUnit,
                TabledData = cmd.DialogCourseUnitPopulateUnit(courseCode, ""),
                DataGridViewColumns = new DataGridViewColumn[]{
                    columnProperties.unitCode,
                    columnProperties.unitDescription,
                    columnProperties.core_CheckBox,
                    columnProperties.select_CheckBox
                },
                EditMode = DataGridViewEditMode.EditOnEnter
            };
            courseUnitView.Create();
            totalCount = courseUnitView.ResultCount;
            resultCount = courseUnitView.ResultCount;

            GetLoadedUnits();
            SetResultLabel();
            LBL_DialogCourseUnit.Text = string.Format("{0} - {1}", courseCode, courseName);
        }

        private void GetLoadedUnits() {
            DataGridViewRow dgvRow;
            loadedUnits = new List<UnitInCourse>();
            for (int i = 0; i < DGV_DialogCourseUnit.Rows.Count; i++) {
                dgvRow = DGV_DialogCourseUnit.Rows[i];
                if ((bool)dgvRow.Cells["Select"].FormattedValue) {
                    UnitInCourse unitsInCourse = new UnitInCourse() {
                        UnitCode = dgvRow.Cells["UnitCode"].Value.ToString(),
                        CourseCode = courseCode,
                        Core = (bool)dgvRow.Cells["Core"].Value
                    };
                    loadedUnits.Add(unitsInCourse);
                }
            }
        }
        private void SetResultLabel() {
            if (resultCount == totalCount) {
                LBL_DialogCourseUnitResult.Text = string.Format("{0} core {1} selected from {3} unit(s)",
                    coreCount.ToString(), selectedCount.ToString(), resultCount.ToString(), totalCount.ToString());
            } else {
                LBL_DialogCourseUnitResult.Text = string.Format("{0} core {1} selected from {2} filtered from {3} unit(s)",
                    coreCount.ToString(), selectedCount.ToString(), resultCount.ToString(), totalCount.ToString());
            }
        }
        private void StyleNullValues() {
            selectedCount = 0;
            coreCount = 0;
            for (int ii = 0; ii < DGV_DialogCourseUnit.Rows.Count; ii++) {
                if ((bool)DGV_DialogCourseUnit.Rows[ii].Cells["Select"].FormattedValue) {
                    selectedCount++;
                    if ((bool)DGV_DialogCourseUnit.Rows[ii].Cells["Core"].FormattedValue) {
                        coreCount++;
                    }
                } else {
                    CheckStyleNull(DGV_DialogCourseUnit.Rows[ii].Cells["Core"]);
                }
            }
        }
        private void ShowAssignedUnits() {
            DataGridViewRow dgvRow;
            List<string> core = new List<string>();
            List<string> elective = new List<string>();
            int count = 0;
            for (int i = 0; i < DGV_DialogCourseUnit.Rows.Count; i++) {

                dgvRow = DGV_DialogCourseUnit.Rows[i];
                if ((bool)dgvRow.Cells["Select"].FormattedValue) {
                    if ((bool)dgvRow.Cells["Core"].FormattedValue) {
                        count++;
                        core.Add(string.Format(
                            "{0}.\t{1}:\t{2}\n",
                            count,
                            dgvRow.Cells["UnitCode"].Value.ToString(),
                            dgvRow.Cells["UnitDescription"].Value.ToString()
                            ));
                    }
                }
            }
            for (int i = 0; i < DGV_DialogCourseUnit.Rows.Count; i++) {
                dgvRow = DGV_DialogCourseUnit.Rows[i];
                if ((bool)dgvRow.Cells["Select"].FormattedValue) {

                    if (!(bool)dgvRow.Cells["Core"].FormattedValue) {
                        count++;
                        elective.Add(string.Format(
                            "{0}.\t{1}:\t{2}\n",
                            count,
                            dgvRow.Cells["UnitCode"].Value.ToString(),
                            dgvRow.Cells["UnitDescription"].Value.ToString()
                            ));
                    }
                }
            }
            if (count > 0) {
                new DialogCourseUnitList(courseCode + " - " + courseName, core, elective).ShowDialog();
            } else {
                _ = MessageBox.Show("No units selected");
            }
        }

        private void CheckStyleTrue(DataGridViewCell cell) {
            DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
            chkCell.FlatStyle = ColumnProperties.enabledStyle;
            chkCell.Style.ForeColor = ColumnProperties.defaultColour;
            cell.Value = true;
            cell.ReadOnly = false;
        }
        private void CheckStyleFalse(DataGridViewCell cell) {
            DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
            chkCell.FlatStyle = ColumnProperties.enabledStyle;
            chkCell.Style.ForeColor = ColumnProperties.defaultColour;
            cell.Value = false;
            cell.ReadOnly = false;
        }
        private void CheckStyleNull(DataGridViewCell cell) {
            DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
            chkCell.FlatStyle = ColumnProperties.disabledStyle;
            chkCell.Style.ForeColor = ColumnProperties.disabledColour;
            // Set in event DGV_DialogCourseUnit_CellContentClick, setting this value here creates a stack overflow
            // cell.Value = false; 
            cell.ReadOnly = true;
        }

        // TODO - Searching resets selections - Must keep record of selections or search within DataGridView results and not make new DB request
        private void BTN_DialogCourseUnitUnit_Click(object sender, EventArgs e) {
            courseUnitView.TabledData = cmd.DialogCourseUnitPopulateUnit(courseCode, TXT_DialogCourseUnitUnit.Text.Trim());
            courseUnitView.Create();
            resultCount = courseUnitView.ResultCount;
            SetResultLabel();
        }
        private void BTN_DialogCourseUnitReset_Click(object sender, EventArgs e) {
            courseUnitView.TabledData = cmd.DialogCourseUnitPopulateUnit(courseCode, "");
            courseUnitView.Create();
            resultCount = courseUnitView.ResultCount;
            SetResultLabel();
            TXT_DialogCourseUnitUnit.Text = "";
        }
        private void BTN_DialogCourseUnitList_Click(object sender, EventArgs e) {
            ShowAssignedUnits();
        }

        private void DGV_DialogCourseUnit_Sorted(object sender, EventArgs e) {
            StyleNullValues();
        }
        private void DGV_DialogCourseUnit_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            if (e.Exception.Message.Equals("Formatted value of the cell has a wrong type.")) {
                e.Cancel = true; // allowing null values
            } else {
                // This exception should be handled - this has not been thrown once in dev/testing
                //e.ThrowException = true;
            }
        }
        private void DGV_DialogCourseUnit_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DGV_DialogCourseUnit.Columns[e.ColumnIndex].Name == "Select" && e.RowIndex >= 0) {
                if ((bool)DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Select"].EditedFormattedValue) {
                    CheckStyleTrue(DGV_DialogCourseUnit.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                    selectedCount++;
                    CheckStyleFalse(DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"]);
                } else {
                    CheckStyleFalse(DGV_DialogCourseUnit.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                    selectedCount--;
                    // fails if not boolean - catching null values
                    try {
                        if ((bool)DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"].EditedFormattedValue) {
                            DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"].Value = false;
                            coreCount--;
                        } else {
                            DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"].Value = false;
                        }
                    } catch {
                        // if value and/or type unknown
                        DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"].Value = false;
                    }
                    CheckStyleNull(DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"]);
                }
                SetResultLabel();
            }
            if (DGV_DialogCourseUnit.Columns[e.ColumnIndex].Name == "Core" && e.RowIndex >= 0) {
                if (DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"].ReadOnly == false) {
                    if ((bool)DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"].EditedFormattedValue) {
                        CheckStyleTrue(DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"]);
                        coreCount++;
                    } else {
                        CheckStyleFalse(DGV_DialogCourseUnit.Rows[e.RowIndex].Cells["Core"]);
                        coreCount--;
                    }
                }
                SetResultLabel();
            }
        }
        private void DGV_DialogCourseUnit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            if (courseUnitView.IsFormattingComplete) {
                StyleNullValues();
                SetResultLabel();
            }
        }
        // Navigate on enter
        private void TextBox_onKeyEnter(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Return)) {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void BTN_DialogCourseUnitAdd_Click(object sender, EventArgs e) {
            int compareSemesterKey = int.Parse(cmd.GetEarliestSemesterKeyOfCourse(courseCode));
            // review
            if (compareSemesterKey != 99999) {
                _ = MessageBox.Show(null, "You cannot modify a course after it has become available at a college.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                return;
            }

            selectedUnits = new List<UnitInCourse>();
            for (int i = 0; i < DGV_DialogCourseUnit.Rows.Count; i++) {
                if ((bool)DGV_DialogCourseUnit.Rows[i].Cells["Select"].FormattedValue) {
                    UnitInCourse unitsInCourse = new UnitInCourse() {
                        UnitCode = DGV_DialogCourseUnit.Rows[i].Cells["UnitCode"].Value.ToString(),
                        CourseCode = courseCode,
                        Core = (bool)DGV_DialogCourseUnit.Rows[i].Cells["Core"].FormattedValue
                    };
                    selectedUnits.Add(unitsInCourse);
                }
            }
            var toAdd = selectedUnits
                .Select(o => new { o.UnitCode, o.CourseCode, o.Core, })
                .Except(
                    loadedUnits
                    .Select(o => new { o.UnitCode, o.CourseCode, o.Core })
                );

            var toDelete = loadedUnits
                .Select(o => new { o.UnitCode, o.CourseCode, o.Core })
                .Except(
                    selectedUnits
                    .Select(o => new { o.UnitCode, o.CourseCode, o.Core })
                );
            if (toAdd.Count() < 1 && toDelete.Count() < 1) {
                _ = MessageBox.Show(null, "No modifications have been made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<UnitInCourse> a = new List<UnitInCourse>();
            List<UnitInCourse> d = new List<UnitInCourse>();
            if (toAdd.Count() > 0) {
                foreach (var item in toAdd) {
                    a.Add(new UnitInCourse {
                        UnitCode = item.UnitCode,
                        CourseCode = item.CourseCode,
                        Core = item.Core
                    });
                }
            }
            if (toDelete.Count() > 0) {
                foreach (var item in toDelete) {
                    d.Add(new UnitInCourse {
                        UnitCode = item.UnitCode,
                        CourseCode = item.CourseCode,
                        Core = item.Core
                    });
                }
            }
            if (cmd.ModifyUnitInCourse(a, d)) {
                if (mainForm.TABCTRL_Main.SelectedTab.Text.Equals("Courses")) {
                    mainForm.GetView("Courses");
                } else if (mainForm.TABCTRL_Main.SelectedTab.Text.Equals("Course Assigned Units")) {
                    mainForm.GetView("Course Assigned Units");
                }
            }
        }
    }
}
