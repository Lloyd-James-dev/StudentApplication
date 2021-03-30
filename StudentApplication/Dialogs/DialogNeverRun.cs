using System.Windows.Forms;
using StudentApp_Controller;

namespace StudentApplication.Dialogs {
    public partial class DialogNeverRun : Form {

        private IMainDAL cmd = new MainDAL();

        public DialogNeverRun(string entity) {
            InitializeComponent();
            BuildView neverRunView;
            ColumnProperties columnProperties = new ColumnProperties();
            string name;

            if (entity.ToLower() == "course") {
                name = "Course";
                neverRunView = new BuildView() {
                    GridView = DGV_DialogNeverRun,
                    TabledData = cmd.CoursesNeverRun(),
                    DataGridViewColumns = new DataGridViewColumn[]{
                        columnProperties.courseCode,
                        columnProperties.courseName,
                        columnProperties.fee
                    }
                };
            } else if (entity.ToLower() == "subject") {
                name = "Subject";
                neverRunView = new BuildView() {
                    GridView = DGV_DialogNeverRun,
                    TabledData = cmd.SubjectsNeverRun(),
                    DataGridViewColumns = new DataGridViewColumn[]{
                        columnProperties.subjectId,
                        columnProperties.subjectName
                    }
                };
            } else {     // unit is default (entity.ToLower() == "unit")
                name = "Unit";
                neverRunView = new BuildView() {
                    GridView = DGV_DialogNeverRun,
                    TabledData = cmd.UnitsNeverRun(),
                    DataGridViewColumns = new DataGridViewColumn[]{
                        columnProperties.unitCode,
                        columnProperties.unitDescription
                    }
                };
            }
            neverRunView.Create();
            Text = string.Format("{0}s Never Run or Assigned", name);
            GRPBOX_NeverRun.Text = string.Format("{0}s Never Run or Assigned", name);
            LBL_DialogNeverRunResults.Text = string.Format("{0} {1}(s)", neverRunView.ResultCount.ToString(), name);
        }
    }
}
