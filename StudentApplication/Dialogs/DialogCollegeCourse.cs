using System;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApp_Model;

namespace StudentApplication.Dialogs {
    public partial class DialogCollegeCourse : Form {

        private IMainDAL cmd = new MainDAL();
        private MainForm mainForm;
        private string college;
        private string semesterName;
        private SemesterKey semesterKey;
        private int collegeId;

        public DialogCollegeCourse(MainForm form, DataGridViewRow row) {

            InitializeComponent();

            mainForm = form;
            college = row.Cells["CollegeName"].Value.ToString();
            semesterName = row.Cells["SemesterName"].Value.ToString();
            semesterKey = new SemesterKey((int)row.Cells["SemesterKey"].Value);
            collegeId = (int)row.Cells["CollegeId"].Value;

            ColumnProperties columnProperties = new ColumnProperties();
            BuildView collegeCourseView = new BuildView() {
                GridView = DGV_DialogCollegeCourse,
                TabledData = cmd.CoursesNotRunning(semesterKey.Key, collegeId),
                DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.courseCode,
                            columnProperties.courseName
                        }
            };
            collegeCourseView.Create();
            // TODO - On hold whilst deciding how TAB navigation should operate
            // collegeCourseView.GridView.TabStop = true;

            LBL_DialogCollegeCourse_College.Text = college;
            LBL_DialogCollegeCourse_Semester.Text = semesterName;

            if (form.currentSemester.Key >= semesterKey.Key) {
                BTN_DialogCollegeCourseAdd.Enabled = false;
                LBL_DialogCollegeCourse_Results.Text = string.Format("Cannot assign in the past {0} course(s)", collegeCourseView.ResultCount.ToString());
            } else {
                LBL_DialogCollegeCourse_Results.Text = string.Format("{0} available course(s)", collegeCourseView.ResultCount.ToString());
            }


        }

        private void BTN_DialogCollegeCourseAdd_Click(object sender, EventArgs e) {
            if (DGV_DialogCollegeCourse.SelectedRows.Count > 0) {
                string courseCode = DGV_DialogCollegeCourse.SelectedRows[0].Cells["CourseCode"].Value.ToString();
                CourseAtSemesterAtCollege courseAtSemesterAtCollege = new CourseAtSemesterAtCollege() {
                    Year = new DateTime(semesterKey.Year, 1, 1),
                    SecondSemester = semesterKey.Semester.Equals(2),
                    CollegeId = collegeId,
                    CourseCode = courseCode
                };
                if (cmd.AddCourseAtSemesterAtCollege(courseAtSemesterAtCollege)) {
                    mainForm.GoToCoursesAtColleges(semesterKey.Key, collegeId, courseCode);
                }
            }
        }
    }
}
