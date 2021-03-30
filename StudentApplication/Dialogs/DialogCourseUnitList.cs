using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication.Dialogs {
    public partial class DialogCourseUnitList : Form {

        public DialogCourseUnitList(string course, List<string> core, List<string> elective) {
            InitializeComponent();
            LBL_DialogCourseUnitList.Text = course;
            LBX_DialogCourseUnitListCore.DataSource = core;
            LBX_DialogCourseUnitListElective.DataSource = elective;
        }
    }
}
