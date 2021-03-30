using System.Windows.Forms;
using StudentApp_Controller;

namespace StudentApplication.Dialogs {
    public partial class DialogTeachingHistory : Form {

        private IMainDAL cmd = new MainDAL();
        private SemesterKey currentSemester;
        private bool isSetPeriodComplete = false;

        public DialogTeachingHistory(DataGridViewRow row) {

            InitializeComponent();

            currentSemester = new SemesterKey(cmd.GetCurrentSemesterKey());
            string email = row.Cells["Email"].Value.ToString();
            string name = row.Cells["FirstName"].Value.ToString() + " " + row.Cells["LastName"].Value.ToString();

            ColumnProperties columnProperties = new ColumnProperties();
            BuildView historyView = new BuildView() {
                GridView = DGV_DialogTeachingHistory,
                TabledData = cmd.TeacherHistory(email),
                DataGridViewColumns = new DataGridViewColumn[]{
                    columnProperties.courseCode,
                    columnProperties.courseName,
                    columnProperties.subjectName,
                    columnProperties.collegeName,
                    columnProperties.semesterName,
                    columnProperties.period,
                    columnProperties.teacherEmail_Hidden,
                    columnProperties.teacherFullName_Hidden,
                    columnProperties.semesterKey
                }
            };
            historyView.Create();
            historyView.GridView.MultiSelect = true;

            SetPeriod();
            LBL_TeachingHistory_Name.Text =  name;
            LBL_DialogTeacherHistoryResults.Text = string.Format("{0} Course(s)", historyView.ResultCount.ToString());
        }

        private void SetPeriod() {
            isSetPeriodComplete = false;
            for (int i = 0; i < DGV_DialogTeachingHistory.Rows.Count; i++) {
                if ((int)DGV_DialogTeachingHistory.Rows[i].Cells["SemesterKey"].Value < currentSemester.Key) {
                    DGV_DialogTeachingHistory.Rows[i].Cells["Period"].Value = "Past";
                } else if ((int)DGV_DialogTeachingHistory.Rows[i].Cells["SemesterKey"].Value > currentSemester.Key) {
                    DGV_DialogTeachingHistory.Rows[i].Cells["Period"].Value = "Future";
                } else {
                    DGV_DialogTeachingHistory.Rows[i].Cells["Period"].Value = "Present";
                }
                isSetPeriodComplete = i.Equals(DGV_DialogTeachingHistory.Rows.Count - 1);
            }
        }
        private void StyleRows() {
            for (int i = 0; i < DGV_DialogTeachingHistory.Rows.Count; i++) {
                if ((int)DGV_DialogTeachingHistory.Rows[i].Cells["SemesterKey"].Value < currentSemester.Key) {
                    RowPastStyle(DGV_DialogTeachingHistory.Rows[i]);
                } else if ((int)DGV_DialogTeachingHistory.Rows[i].Cells["SemesterKey"].Value > currentSemester.Key) {
                    RowFutureStyle(DGV_DialogTeachingHistory.Rows[i]);
                }
            }
        }
        private void RowPastStyle(DataGridViewRow row) {
            row.HeaderCell.Style.SelectionBackColor = ColumnProperties.pastSelectionBackColor;
            for (int i = 0; i < row.Cells.Count; i++) {
                DataGridViewCell cell = row.Cells[i];
                cell.Style.ForeColor = ColumnProperties.pastForeColor;
                cell.Style.SelectionBackColor = ColumnProperties.pastSelectionBackColor;
            }
        }
        private void RowFutureStyle(DataGridViewRow row) {
            row.HeaderCell.Style.SelectionBackColor = ColumnProperties.futureSelectionBackColor;
            for (int i = 0; i < row.Cells.Count; i++) {
                DataGridViewCell cell = row.Cells[i];
                cell.Style.ForeColor = ColumnProperties.futureForeColor;
                cell.Style.SelectionBackColor = ColumnProperties.futureSelectionBackColor;
            }
        }

        private void DGV_DialogTeacherHistory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            // run once only
            if (isSetPeriodComplete) {
                StyleRows();
            }

        }
    }
}
