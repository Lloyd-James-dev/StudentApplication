using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentApp_Controller;
using StudentApplication.Dialogs;

namespace StudentApplication {
    public partial class MainForm : Form {

        // temporary debugging vars
        //int testInt_A = 0;
        //int testInt_B = 0;
        //int testInt_C = 0;

        private IMainDAL cmd = new MainDAL();
        private static string titleText = "TAFE - Technical And Futher Education";
        public SemesterKey currentSemester;
        BuildView unitCourseView;
        BuildView transactionsView;
        BuildView courseAllocationsView;
        BuildView studentEnrolmentsView;
        BuildView semesterView;

        FlowLayoutPanel FLP_CourseAllocations;
        Label LBL_CourseAllocationsTitle_00;
        Label LBL_CourseAllocationsTitle_01;
        Label LBL_CourseAllocationsTitle_02;
        Label LBL_CourseAllocationsTitle_03;
        Label LBL_CourseAllocationsTitle_04;
        Label LBL_CourseAllocationsTitle_05;
        Label LBL_CourseAllocationsTitle_06;
        Label LBL_CourseAllocationsTitle_07;
        Label LBL_CourseAllocationsTitle_08;
        Label LBL_CourseAllocationsTitle_09;
        Label LBL_CourseAllocationsTitle_10;

        FlowLayoutPanel FLP_StudentEnrolments;
        Label LBL_StudentEnrolmentsTitle_00;
        Label LBL_StudentEnrolmentsTitle_01;
        Label LBL_StudentEnrolmentsTitle_02;
        Label LBL_StudentEnrolmentsTitle_03;
        Label LBL_StudentEnrolmentsTitle_04;
        Label LBL_StudentEnrolmentsTitle_05;
        Label LBL_StudentEnrolmentsTitle_06;
        Label LBL_StudentEnrolmentsTitle_07;
        Label LBL_StudentEnrolmentsTitle_08;

        FlowLayoutPanel FLP_CourseUnits;
        Label LBL_CourseUnitsTitle_00;
        Label LBL_CourseUnitsTitle_01;
        Label LBL_CourseUnitsTitle_02;

        // Styling
        string manyToMany = "⪫\u2006\u0336⪪";
        string anyToMany = "⚬ \u0336⪪";
        string oneToOne = "⟊\u2006\u0336\u2006⟊";
        Color activeColour = Color.Firebrick;
        Color passiveColour = SystemColors.ControlText;
        Font titleBold = new Font("Calibri", 21.75f, FontStyle.Bold);
        Font titleReg = new Font("Calibri", 21.75f);

        public MainForm() {

            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Text = titleText;
            currentSemester = new SemesterKey(cmd.GetCurrentSemesterKey());
            GetView("Students");

            #region titles
            FLP_CourseAllocations = new FlowLayoutPanel() {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Location = new System.Drawing.Point(6, 0),
                Margin = new System.Windows.Forms.Padding(0),
                Padding = new System.Windows.Forms.Padding(0),
                Size = new System.Drawing.Size(1258, 40),
                Anchor = ((System.Windows.Forms.AnchorStyles)(((
                    System.Windows.Forms.AnchorStyles.Top |
                    System.Windows.Forms.AnchorStyles.Left) |
                    System.Windows.Forms.AnchorStyles.Right)))
            };
            GRPBOX_CourseAllocations.Controls.Add(FLP_CourseAllocations);
            FLP_CourseAllocations.BringToFront();
            LBL_CourseAllocationsTitle_00 = new Label() {
                Text = "Semesters",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true
            };
            LBL_CourseAllocationsTitle_01 = new Label() {
                Text = manyToMany,
                ForeColor = activeColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true
            };
            LBL_CourseAllocationsTitle_02 = new Label() {
                Text = "Colleges",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true
            };
            LBL_CourseAllocationsTitle_03 = new Label() {
                Text = anyToMany,
                ForeColor = passiveColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_CourseAllocationsTitle_04 = new Label() {
                Text = "Courses",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_CourseAllocationsTitle_05 = new Label() {
                Text = anyToMany,
                ForeColor = passiveColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_CourseAllocationsTitle_06 = new Label() {
                Text = "Subjects",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_CourseAllocationsTitle_07 = new Label() {
                Text = oneToOne,
                ForeColor = passiveColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_CourseAllocationsTitle_08 = new Label() {
                Text = "Teachers",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_CourseAllocationsTitle_09 = new Label() {
                Text = anyToMany,
                ForeColor = passiveColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_CourseAllocationsTitle_10 = new Label() {
                Text = "Units",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            FLP_CourseAllocations.SuspendLayout();
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_00);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_01);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_02);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_03);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_04);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_05);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_06);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_07);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_08);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_09);
            FLP_CourseAllocations.Controls.Add(LBL_CourseAllocationsTitle_10);
            FLP_CourseAllocations.ResumeLayout();

            FLP_StudentEnrolments = new FlowLayoutPanel() {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Location = new System.Drawing.Point(6, 0),
                Margin = new System.Windows.Forms.Padding(0),
                Padding = new System.Windows.Forms.Padding(0),
                Size = new System.Drawing.Size(1258, 40),
                Anchor = ((System.Windows.Forms.AnchorStyles)(((
                    System.Windows.Forms.AnchorStyles.Top |
                    System.Windows.Forms.AnchorStyles.Left) |
                    System.Windows.Forms.AnchorStyles.Right)))
            };
            GRPBOX_StudentEnrolments.Controls.Add(FLP_StudentEnrolments);
            LBL_StudentEnrolmentsTitle_00 = new Label() {
                Text = "Semesters",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true
            };
            LBL_StudentEnrolmentsTitle_01 = new Label() {
                Text = manyToMany,
                ForeColor = activeColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true
            };
            LBL_StudentEnrolmentsTitle_02 = new Label() {
                Text = "Colleges",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true
            };
            LBL_StudentEnrolmentsTitle_03 = new Label() {
                Text = anyToMany,
                ForeColor = passiveColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_StudentEnrolmentsTitle_04 = new Label() {
                Text = "Registrations",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_StudentEnrolmentsTitle_05 = new Label() {
                Text = anyToMany,
                ForeColor = passiveColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_StudentEnrolmentsTitle_06 = new Label() {
                Text = "Enrolments",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_StudentEnrolmentsTitle_07 = new Label() {
                Text = anyToMany,
                ForeColor = passiveColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            LBL_StudentEnrolmentsTitle_08 = new Label() {
                Text = "Grades",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true,
                Enabled = false
            };
            FLP_StudentEnrolments.SuspendLayout();
            FLP_StudentEnrolments.Controls.Add(LBL_StudentEnrolmentsTitle_00);
            FLP_StudentEnrolments.Controls.Add(LBL_StudentEnrolmentsTitle_01);
            FLP_StudentEnrolments.Controls.Add(LBL_StudentEnrolmentsTitle_02);
            FLP_StudentEnrolments.Controls.Add(LBL_StudentEnrolmentsTitle_03);
            FLP_StudentEnrolments.Controls.Add(LBL_StudentEnrolmentsTitle_04);
            FLP_StudentEnrolments.Controls.Add(LBL_StudentEnrolmentsTitle_05);
            FLP_StudentEnrolments.Controls.Add(LBL_StudentEnrolmentsTitle_06);
            FLP_StudentEnrolments.Controls.Add(LBL_StudentEnrolmentsTitle_07);
            FLP_StudentEnrolments.Controls.Add(LBL_StudentEnrolmentsTitle_08);
            FLP_StudentEnrolments.ResumeLayout();

            FLP_CourseUnits = new FlowLayoutPanel() {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Location = new System.Drawing.Point(6, 0),
                Margin = new System.Windows.Forms.Padding(0),
                Padding = new System.Windows.Forms.Padding(0),
                Size = new System.Drawing.Size(1258, 40),
                Anchor = ((System.Windows.Forms.AnchorStyles)(((
                    System.Windows.Forms.AnchorStyles.Top |
                    System.Windows.Forms.AnchorStyles.Left) |
                    System.Windows.Forms.AnchorStyles.Right)))
            };
            GRPBOX_CourseUnit.Controls.Add(FLP_CourseUnits);
            LBL_CourseUnitsTitle_00 = new Label() {
                Text = "Courses",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                Location = new System.Drawing.Point(0, 0),
                BackColor = Color.White,
                AutoSize = true
            };
            LBL_CourseUnitsTitle_01 = new Label() {
                Text = manyToMany,
                ForeColor = activeColour,
                Font = titleReg,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true
            };
            LBL_CourseUnitsTitle_02 = new Label() {
                Text = "Units",
                ForeColor = passiveColour,
                Font = titleBold,
                Margin = new System.Windows.Forms.Padding(0),
                BackColor = Color.White,
                AutoSize = true
            };
            FLP_CourseUnits.SuspendLayout();
            FLP_CourseUnits.Controls.Add(LBL_CourseUnitsTitle_00);
            FLP_CourseUnits.Controls.Add(LBL_CourseUnitsTitle_01);
            FLP_CourseUnits.Controls.Add(LBL_CourseUnitsTitle_02);
            FLP_CourseUnits.ResumeLayout();
            #endregion

            CHKBOX_CourseAllocations_Course.Checked = false;
            CHKBOX_CourseAllocations_Subject.Checked = false;
            CHKBOX_CourseAllocations_Teacher.Checked = false;
            CHKBOX_CourseAllocations_Unit.Checked = false;

            CHKBOX_StudentEnrolments_Registration.Checked = false;
            CHKBOX_StudentEnrolments_Enrolment.Checked = false;
            CHKBOX_StudentEnrolments_Grade.Checked = false;

            TBL_CourseAllocations_Course.Enabled = false;
            TBL_CourseAllocations_Subject.Enabled = false;
            TBL_CourseAllocations_Teacher.Enabled = false;
            TBL_CourseAllocations_Unit.Enabled = false;

            TBL_StudentEnrolments_Registration.Enabled = false;
            TBL_StudentEnrolments_Enrolment.Enabled = false;
            TBL_StudentEnrolments_Grade.Enabled = false;

            LBL_CourseAllocations_Refresh.Visible = false;
            LBL_StudentEnrolments_Refresh.Visible = false;
            LBL_Transactions_Refresh.Visible = false;
            LBL_CourseUnit_Refresh.Visible = false;

            GRPBOX_CourseAllocations.Text = " ";
            GRPBOX_CourseUnit.Text = " ";
            GRPBOX_StudentEnrolments.Text = " ";
        }

        // Displaying data in dataTables
        public void GetView(string page, params object[] filters) {
            ColumnProperties columnProperties = new ColumnProperties() { };
            DataView dataView;
            DataTable dataTable;
            string results;
            switch (page) {
                case "Students":
                    if (filters.Length < 1) {
                        filters = new object[] { "" };
                    }
                    BuildView studentView = new BuildView() {
                        GridView = DGV_Students,
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.firstName,
                            columnProperties.lastName,
                            columnProperties.email,
                            columnProperties.address,
                            columnProperties.city,
                            columnProperties.state,
                            columnProperties.postCode,
                            columnProperties.dob ,
                            columnProperties.gender,
                            columnProperties.mobile
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.update,
                            columnProperties.delete,
                            columnProperties.register
                        },
                        TabledData = cmd.SearchStudentFields(filters[0].ToString())
                    };
                    studentView.Create();
                    WriteResults(LBL_Students_Result, "students", studentView.ResultCount);
                    break;
                case "Teachers":
                    if (filters.Length < 1) {
                        filters = new object[] { "" };
                    }
                    BuildView teacherView = new BuildView() {
                        GridView = DGV_Teachers,
                        TabledData = cmd.SearchTeacherFields(filters[0].ToString()),
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.firstName,
                            columnProperties.lastName,
                            columnProperties.email,
                            columnProperties.address,
                            columnProperties.city,
                            columnProperties.state,
                            columnProperties.postCode,
                            columnProperties.dob ,
                            columnProperties.gender,
                            columnProperties.mobile
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.update,
                            columnProperties.delete,
                            columnProperties.history
                        }
                    };
                    teacherView.Create();
                    WriteResults(LBL_Teachers_Result, "teachers", teacherView.ResultCount);
                    break;
                case "Administrators":
                    if (filters.Length < 1) {
                        filters = new object[] { "" };
                    }
                    BuildView adminView = new BuildView() {
                        GridView = DGV_Admins,
                        TabledData = cmd.SearchAdminFields(filters[0].ToString()),
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.firstName,
                            columnProperties.lastName,
                            columnProperties.email,
                            columnProperties.address,
                            columnProperties.city,
                            columnProperties.state,
                            columnProperties.postCode,
                            columnProperties.dob ,
                            columnProperties.gender,
                            columnProperties.mobile
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.update,
                            columnProperties.delete
                        }
                    };
                    adminView.Create();
                    WriteResults(LBL_Admins_Result, "administrators", adminView.ResultCount);
                    break;
                case "Semesters":
                    if (filters.Length < 1) {
                        filters = new object[] { "" };
                    }
                    semesterView = new BuildView() {
                        GridView = DGV_Semesters,
                        TabledData = cmd.SearchSemesterFields(filters[0].ToString()),
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.year,
                            columnProperties.isSecondSemester,
                            columnProperties.firstTermBegin,
                            columnProperties.firstTermEnd,
                            columnProperties.secondTermBegin,
                            columnProperties.secondTermEnd,
                            columnProperties.semesterKey,
                            columnProperties.semesterName_Hidden
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.update,
                            columnProperties.delete,
                            columnProperties.joinCollege
                        }
                    };
                    semesterView.Create();
                    WriteResults(LBL_Semesters_Result, "semesters", semesterView.ResultCount);
                    break;
                case "Colleges":
                    if (filters.Length < 1) {
                        filters = new object[] { "" };
                    }
                    BuildView collegeView = new BuildView() {
                        GridView = DGV_Colleges,
                        TabledData = cmd.SearchCollegeFields(filters[0].ToString()),
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.collegeId,
                            columnProperties.collegeName,
                            columnProperties.address,
                            columnProperties.city,
                            columnProperties.state,
                            columnProperties.postCode
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.update,
                            columnProperties.delete,
                            columnProperties.joinSemester
                        }
                    };
                    collegeView.Create();
                    WriteResults(LBL_Colleges_Result, "colleges", collegeView.ResultCount);
                    break;
                case "Courses":
                    if (filters.Length < 1) {
                        filters = new object[] { "" };
                    }
                    BuildView courseView = new BuildView() {
                        GridView = DGV_Courses,
                        TabledData = cmd.SearchCourseFields(filters[0].ToString()),
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.courseCode,
                            columnProperties.courseName,
                            columnProperties.fee
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.update,
                            columnProperties.delete,
                            columnProperties.assignUnits
                        }
                    };
                    courseView.Create();
                    WriteResults(LBL_Courses_Result, "courses", courseView.ResultCount);
                    break;
                case "Subjects":
                    if (filters.Length < 1) {
                        filters = new object[] { "" };
                    }
                    BuildView subjectView = new BuildView() {
                        GridView = DGV_Subjects,
                        TabledData = cmd.SearchSubjectFields(filters[0].ToString()),
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.subjectId,
                            columnProperties.subjectName
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.update,
                            columnProperties.delete
                        }
                    };
                    subjectView.Create();
                    WriteResults(LBL_Subjects_Result, "subjects", subjectView.ResultCount);
                    break;
                case "Units":
                    if (filters.Length < 1) {
                        filters = new object[] { "" };
                    }
                    BuildView unitView = new BuildView() {
                        GridView = DGV_Units,
                        TabledData = cmd.SearchUnitFields(filters[0].ToString()),
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.unitCode,
                            columnProperties.unitDescription
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.update,
                            columnProperties.delete
                        }
                    };
                    unitView.Create();
                    WriteResults(LBL_Units_Result, "units", unitView.ResultCount);
                    break;
                case "Transactions":
                    //testInt_A = 0;
                    //testInt_B = 0;
                    //testInt_C = 0;
                    Updating(LBL_Transactions_Refresh, "Updating...");
                    dataView = GetTransactionsView();
                    dataTable = dataView.ToTable();
                    transactionsView = new BuildView() {
                        GridView = DGV_Transactions,
                        TabledData = dataTable,
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.invoiceId,
                            columnProperties.receiptId,
                            columnProperties.transactionDate,
                            columnProperties.studentFullName_Transactions,
                            columnProperties.studentEmail_Transactions,
                            columnProperties.semesterName_Transactions,
                            columnProperties.semesterKey,
                            columnProperties.collegeName_Transactions,
                            columnProperties.collegeId_Hidden,
                            columnProperties.courseCode_Transactions,
                            columnProperties.coursePlusCode,
                            columnProperties.amount,
                            columnProperties.comments
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.addReceipt
                        }
                    };
                    transactionsView.Create();
                    Transactions_Combos(dataView);
                    DGV_Transactions.CurrentCellDirtyStateChanged += new EventHandler(DGV_Transactions_CurrentCellDirtyStateChanged);
                    WriteResults(LBL_Transactions_Result, "transactions", transactionsView.ResultCount - 1); // removing totals row
                    LBL_Transactions_Refresh.Visible = false;
                    break;
                case "Course Allocations":
                    Updating(LBL_CourseAllocations_Refresh, "Updating...");
                    dataView = GetCourseAllocationsView();
                    dataTable = dataView.ToTable();
                    if (CHKBOX_CourseAllocations_Unit.Checked) {
                        courseAllocationsView = new BuildView() {
                            GridView = DGV_CourseAllocations,
                            TabledData = dataTable,
                            DataGridViewColumns = new DataGridViewColumn[] {
                                columnProperties.year_Hidden,
                                columnProperties.isSecondSemester_Hidden,
                                columnProperties.semesterName,
                                columnProperties.semesterKey,
                                columnProperties.collegeId_Hidden,
                                columnProperties.collegeName,
                                columnProperties.courseCode,
                                columnProperties.courseName,
                                columnProperties.coursePlusCode,
                                columnProperties.subjectId_Hidden,
                                columnProperties.subjectName,
                                columnProperties.teacherFullName,
                                columnProperties.teacherEmail_Hidden,
                                columnProperties.unitCode,
                                columnProperties.unitDescription,
                                columnProperties.core
                           }
                        };
                        results = "units assigned to subjects";
                        //GRPBOX_CourseAllocations.Text = "🔍 Search Units assigned to Subjects";
                    } else if (CHKBOX_CourseAllocations_Teacher.Checked) {
                        courseAllocationsView = new BuildView() {
                            GridView = DGV_CourseAllocations,
                            TabledData = dataTable,
                            DataGridViewColumns = new DataGridViewColumn[] {
                                columnProperties.year_Hidden,
                                columnProperties.isSecondSemester_Hidden,
                                columnProperties.semesterName,
                                columnProperties.semesterKey,
                                columnProperties.collegeId_Hidden,
                                columnProperties.collegeName,
                                columnProperties.courseCode,
                                columnProperties.courseName,
                                columnProperties.coursePlusCode,
                                columnProperties.subjectId_Hidden,
                                columnProperties.subjectName,
                                columnProperties.teacherFullName,
                                columnProperties.teacherEmail
                            },
                            ButtonColumns = new ButtonColumn[] {
                                columnProperties.addUnits
                            }
                        };
                        results = "teachers assigned to a subject in courses";
                        //GRPBOX_CourseAllocations.Text = "🔍 Search Teachers assigned to Subjects";
                    } else if (CHKBOX_CourseAllocations_Subject.Checked) {
                        courseAllocationsView = new BuildView() {
                            GridView = DGV_CourseAllocations,
                            TabledData = dataTable,
                            DataGridViewColumns = new DataGridViewColumn[] {
                                columnProperties.year_Hidden,
                                columnProperties.isSecondSemester_Hidden,
                                columnProperties.semesterName,
                                columnProperties.semesterKey,
                                columnProperties.collegeId_Hidden,
                                columnProperties.collegeName,
                                columnProperties.courseCode,
                                columnProperties.courseName,
                                columnProperties.coursePlusCode,
                                columnProperties.subjectId_Hidden,
                                columnProperties.subjectName,
                                columnProperties.teacherFullName_Hidden,
                                columnProperties.teacherEmail_Hidden
                            },
                            ButtonColumns = new ButtonColumn[] {
                                columnProperties.addUnits
                            }
                        };
                        results = "subjects in courses";
                        //GRPBOX_CourseAllocations.Text = "🔍 Search Subjects in Courses";
                    } else if (CHKBOX_CourseAllocations_Course.Checked) {
                        courseAllocationsView = new BuildView() {
                            GridView = DGV_CourseAllocations,
                            TabledData = dataTable,
                            DataGridViewColumns = new DataGridViewColumn[] {
                                columnProperties.year_Hidden,
                                columnProperties.isSecondSemester_Hidden,
                                columnProperties.semesterName,
                                columnProperties.semesterKey,
                                columnProperties.collegeId_Hidden,
                                columnProperties.collegeName,
                                columnProperties.courseCode,
                                columnProperties.courseName,
                                columnProperties.coursePlusCode
                            },
                            ButtonColumns = new ButtonColumn[] {
                                columnProperties.linkSubjects
                            }
                        };
                        results = "courses assigned to colleges during semesters";
                        //GRPBOX_CourseAllocations.Text = "🔍 Search Courses assigned to Colleges during Semesters";
                    } else {
                        courseAllocationsView = new BuildView() {
                            GridView = DGV_CourseAllocations,
                            TabledData = dataTable,
                            DataGridViewColumns = new DataGridViewColumn[] {
                                columnProperties.year_Hidden,
                                columnProperties.isSecondSemester_Hidden,
                                columnProperties.semesterName,
                                columnProperties.semesterKey,
                                columnProperties.collegeId_Hidden,
                                columnProperties.collegeName
                            },
                            ButtonColumns = new ButtonColumn[] {
                                columnProperties.assignCourse
                            }
                        };
                        results = "colleges operating during semesters";
                        //GRPBOX_CourseAllocations.Text = "🔍 Search Colleges operating during Semesters";
                    }
                    courseAllocationsView.Create();
                    WriteResults(LBL_CourseAllocations_Result, results, courseAllocationsView.ResultCount);
                    CourseAllocations_Combos(dataView);
                    LBL_CourseAllocations_Refresh.Visible = false;
                    break;
                case "Student Enrolments":
                    Updating(LBL_StudentEnrolments_Refresh, "Updating...");
                    dataView = GetStudentEnrolmentsView();
                    dataTable = dataView.ToTable();
                    if (CHKBOX_StudentEnrolments_Grade.Checked) {
                        studentEnrolmentsView = new BuildView() {
                            GridView = DGV_StudentEnrolments,
                            TabledData = dataTable,
                            DataGridViewColumns = new DataGridViewColumn[] {
                                columnProperties.studentFullName,
                                columnProperties.studentEmail,
                                columnProperties.dateRegistered,
                                columnProperties.year_Hidden,
                                columnProperties.isSecondSemester_Hidden,
                                columnProperties.semesterName,
                                columnProperties.semesterKey,
                                columnProperties.collegeId_Hidden,
                                columnProperties.collegeName,
                                columnProperties.dateEnroled,
                                columnProperties.courseCode,
                                columnProperties.courseName,
                                columnProperties.coursePlusCode,
                                columnProperties.unitCode,
                                columnProperties.unitDescription,
                                columnProperties.teacherFullName,
                                columnProperties.grade,
                                columnProperties.rpl,
                                columnProperties.dateGraded
                            }
                        };
                        results = "student grades";
                        //GRPBOX_StudentEnrolments.Text = "🔍 Search Student Grades";
                    } else if (CHKBOX_StudentEnrolments_Enrolment.Checked) {
                        studentEnrolmentsView = new BuildView() {
                            GridView = DGV_StudentEnrolments,
                            TabledData = dataTable,
                            DataGridViewColumns = new DataGridViewColumn[]{
                                columnProperties.studentFullName,
                                columnProperties.studentEmail,
                                columnProperties.dateRegistered,
                                columnProperties.year_Hidden,
                                columnProperties.isSecondSemester_Hidden,
                                columnProperties.semesterName,
                                columnProperties.semesterKey,
                                columnProperties.collegeId_Hidden,
                                columnProperties.collegeName,
                                columnProperties.dateEnroled,
                                columnProperties.courseCode,
                                columnProperties.courseName,
                                columnProperties.coursePlusCode
                            },
                            ButtonColumns = new ButtonColumn[] {
                                columnProperties.grades
                            }
                        };
                        results = "course enrolments";
                        //GRPBOX_StudentEnrolments.Text = "🔍 Search Course Enrolments";
                    } else if (CHKBOX_StudentEnrolments_Registration.Checked) {
                        studentEnrolmentsView = new BuildView() {
                            GridView = DGV_StudentEnrolments,
                            TabledData = dataTable,
                            DataGridViewColumns = new DataGridViewColumn[] {
                                columnProperties.studentFullName,
                                columnProperties.studentEmail,
                                columnProperties.dateRegistered,
                                columnProperties.year_Hidden,
                                columnProperties.isSecondSemester_Hidden,
                                columnProperties.semesterName,
                                columnProperties.semesterKey,
                                columnProperties.collegeId_Hidden,
                                columnProperties.collegeName
                            },
                            ButtonColumns = new ButtonColumn[] {
                                columnProperties.enrol
                            }
                        };
                        results = "student registrations";
                        //GRPBOX_StudentEnrolments.Text = "🔍 Search Student Registrations";
                    } else {
                        studentEnrolmentsView = new BuildView() {
                            GridView = DGV_StudentEnrolments,
                            TabledData = dataTable,
                            DataGridViewColumns = new DataGridViewColumn[] {
                                columnProperties.year_Hidden,
                                columnProperties.isSecondSemester_Hidden,
                                columnProperties.semesterName,
                                columnProperties.semesterKey,
                                columnProperties.collegeId_Hidden,
                                columnProperties.collegeName
                            },
                            ButtonColumns = new ButtonColumn[] {
                                columnProperties.register
                            }
                        };
                        results = "colleges operating during semesters";
                        //GRPBOX_StudentEnrolments.Text = "🔍 Search Colleges operating during Semesters";
                    }
                    studentEnrolmentsView.Create();
                    WriteResults(LBL_StudentEnrolments_Result, results, studentEnrolmentsView.ResultCount);
                    StudentEnrolments_Combos(dataView);
                    LBL_StudentEnrolments_Refresh.Visible = false;
                    break;
                case "Course Assigned Units":
                    Updating(LBL_CourseUnit_Refresh, "Updating...");
                    dataView = GetCourseUnitView();
                    dataTable = dataView.ToTable();
                    unitCourseView = new BuildView() {
                        GridView = DGV_CourseUnit,
                        TabledData = dataTable,
                        DataGridViewColumns = new DataGridViewColumn[]{
                            columnProperties.courseCode,
                            columnProperties.courseName,
                            columnProperties.coursePlusCode,
                            columnProperties.unitCode,
                            columnProperties.unitDescription,
                            columnProperties.core
                        },
                        ButtonColumns = new ButtonColumn[] {
                            columnProperties.update
                        }
                    };
                    unitCourseView.Create();
                    WriteResults(LBL_CourseUnit_Result, "assigned units", unitCourseView.ResultCount);
                    CourseUnit_Combos(dataView);
                    LBL_CourseUnit_Refresh.Visible = false;
                    break;
                default:
                    break;
            }
        }

        // Dynamic Navigation
        public void GoToSemesterAtCollege(int semesterKey, int collegeId) {
            ResetFilters_CourseAllocations();
            CHKBOX_CourseAllocations_Unit.Checked = false;
            CHKBOX_CourseAllocations_Teacher.Checked = false;
            CHKBOX_CourseAllocations_Subject.Checked = false;
            CHKBOX_CourseAllocations_Course.Checked = false;
            TABCTRL_Main.SelectTab("TAB_CourseAllocations");
            CMB_CourseAllocations_Semester.SelectedValue = semesterKey;
            CMB_CourseAllocations_College.SelectedValue = collegeId;
            GetView("Course Allocations");
        }
        public void GoToCoursesAtColleges(int semesterKey, int collegeId, string corseCode) {
            ResetFilters_CourseAllocations();
            CHKBOX_CourseAllocations_Unit.Checked = false;
            CHKBOX_CourseAllocations_Teacher.Checked = false;
            CHKBOX_CourseAllocations_Subject.Checked = false;
            CHKBOX_CourseAllocations_Course.Checked = true;
            PrePopCourseAllocationCombos();
            GetView("Course Allocations"); // Must first populate for correct filtering
            TABCTRL_Main.SelectTab("TAB_CourseAllocations");
            CMB_CourseAllocations_Semester.SelectedValue = semesterKey;
            CMB_CourseAllocations_College.SelectedValue = collegeId;
            CMB_CourseAllocations_Course.SelectedValue = corseCode;
            GetView("Course Allocations");
        }
        public void GoToSubjectsInCourses(int semesterKey, int collegeId, string corseCode) {
            ResetFilters_CourseAllocations();
            CHKBOX_CourseAllocations_Unit.Checked = false;
            CHKBOX_CourseAllocations_Teacher.Checked = true;
            CHKBOX_CourseAllocations_Subject.Checked = true;
            CHKBOX_CourseAllocations_Course.Checked = true;
            TABCTRL_Main.SelectTab("TAB_CourseAllocations");
            CMB_CourseAllocations_Semester.SelectedValue = semesterKey;
            CMB_CourseAllocations_College.SelectedValue = collegeId;
            CMB_CourseAllocations_Course.SelectedValue = corseCode;
            GetView("Course Allocations");
        }
        public void GoToUnitsInSubjects(int semesterKey, int collegeId, string corseCode) {
            ResetFilters_CourseAllocations();
            CHKBOX_CourseAllocations_Unit.Checked = true;
            CHKBOX_CourseAllocations_Teacher.Checked = true;
            CHKBOX_CourseAllocations_Subject.Checked = true;
            CHKBOX_CourseAllocations_Course.Checked = true;
            TABCTRL_Main.SelectTab("TAB_CourseAllocations");
            CMB_CourseAllocations_Semester.SelectedValue = semesterKey;
            CMB_CourseAllocations_College.SelectedValue = collegeId;
            CMB_CourseAllocations_Course.SelectedValue = corseCode;
            GetView("Course Allocations");
        }
        public void GoToRegistrations(int semesterKey, int collegeId, string studentEmail) {
            ResetFilters_StudentEnrolments();
            CHKBOX_StudentEnrolments_Grade.Checked = false;
            CHKBOX_StudentEnrolments_Enrolment.Checked = false;
            CHKBOX_StudentEnrolments_Registration.Checked = true;
            PrePopStudentEnrolmentsCombos();
            GetView("Student Enrolments"); // Must first populate for correct filtering
            TABCTRL_Main.SelectTab("TAB_Enrolments");
            CMB_StudentEnrolments_Semester.SelectedValue = semesterKey;
            CMB_StudentEnrolments_College.SelectedValue = collegeId;
            CMB_StudentEnrolments_Registration.SelectedValue = studentEmail;
            GetView("Student Enrolments");
        }
        public void GoToEnrolments(int semesterKey, int collegeId, string studentEmail) {
            ResetFilters_StudentEnrolments();
            CHKBOX_StudentEnrolments_Grade.Checked = false;
            CHKBOX_StudentEnrolments_Enrolment.Checked = true;
            CHKBOX_StudentEnrolments_Registration.Checked = true;
            TABCTRL_Main.SelectTab("TAB_Enrolments");
            CMB_StudentEnrolments_Semester.SelectedValue = semesterKey;
            CMB_StudentEnrolments_College.SelectedValue = collegeId;
            CMB_StudentEnrolments_Registration.SelectedValue = studentEmail;
            GetView("Student Enrolments");
        }

        // Views for composite tables
        private DataView GetCourseUnitView() {
            DataView view = CMB_CourseUnit_Course.SelectedIndex < 0 ?
                new DataView(cmd.ViewCourseUnit()) :
                new DataView(cmd.ViewCourseUnit(CMB_CourseUnit_Course.SelectedValue.ToString(), TXT_CourseUnit_Unit.Text));
            return view;
        }
        private DataView GetCourseAllocationsView() {
            DataView view;
            int semVal =
                CMB_CourseAllocations_Semester.SelectedIndex > 0 ?
                int.Parse(CMB_CourseAllocations_Semester.SelectedValue.ToString()) :
                0;
            int colVal =
                CMB_CourseAllocations_College.SelectedIndex > 0 ?
                int.Parse(CMB_CourseAllocations_College.SelectedValue.ToString()) :
                0;
            string crsVal =
                CMB_CourseAllocations_Course.SelectedIndex > 0 ?
                CMB_CourseAllocations_Course.SelectedValue.ToString() :
                "";
            int subVal =
                CMB_CourseAllocations_Subject.SelectedIndex > 0 ?
                int.Parse(CMB_CourseAllocations_Subject.SelectedValue.ToString()) :
                0;
            string tutVal =
                CMB_CourseAllocations_Teacher.SelectedIndex > 0 ?
                CMB_CourseAllocations_Teacher.SelectedValue.ToString() :
                "";
            if (CHKBOX_CourseAllocations_Unit.Checked) {
                view = new DataView(cmd.ViewUnitAssignments(semVal, colVal, crsVal, subVal, tutVal, TXT_CourseAllocations_Unit.Text));
            } else if (CHKBOX_CourseAllocations_Teacher.Checked) {
                view = new DataView(cmd.ViewSubjectAssignments(semVal, colVal, crsVal, subVal, tutVal));
                TXT_CourseAllocations_Unit.Text = "";
            } else if (CHKBOX_CourseAllocations_Subject.Checked) {
                view = new DataView(cmd.ViewSubjectAssignments(semVal, colVal, crsVal, subVal, tutVal));
                ResetCombo(CMB_CourseAllocations_Teacher);
                TXT_CourseAllocations_Unit.Text = "";
            } else if (CHKBOX_CourseAllocations_Course.Checked) {
                view = new DataView(cmd.ViewCourseAssignments(semVal, colVal, crsVal));
                ResetCombo(CMB_CourseAllocations_Subject);
                ResetCombo(CMB_CourseAllocations_Teacher);
                TXT_CourseAllocations_Unit.Text = "";
            } else {
                view = new DataView(cmd.ViewCollegeAssignments(semVal, colVal));
                ResetCombo(CMB_CourseAllocations_Course);
                ResetCombo(CMB_CourseAllocations_Subject);
                ResetCombo(CMB_CourseAllocations_Teacher);
                TXT_CourseAllocations_Unit.Text = "";
            }
            return view;
        }
        private DataView GetStudentEnrolmentsView() {
            DataView view;
            int semVal =
                CMB_StudentEnrolments_Semester.SelectedIndex > 0 ?
                int.Parse(CMB_StudentEnrolments_Semester.SelectedValue.ToString()) :
                0;
            int colVal =
                CMB_StudentEnrolments_College.SelectedIndex > 0 ?
                int.Parse(CMB_StudentEnrolments_College.SelectedValue.ToString()) :
                0;
            string stdVal =
                CMB_StudentEnrolments_Registration.SelectedIndex > 0 ?
                CMB_StudentEnrolments_Registration.SelectedValue.ToString() :
                "";
            string crsVal =
                CMB_StudentEnrolments_Enrolment.SelectedIndex > 0 ?
                CMB_StudentEnrolments_Enrolment.SelectedValue.ToString() :
                "";
            if (CHKBOX_StudentEnrolments_Grade.Checked) {
                view = new DataView(cmd.ViewStudentGrades(semVal, colVal, stdVal, crsVal, TXT_StudentEnrolments_Grade.Text));
            } else if (CHKBOX_StudentEnrolments_Enrolment.Checked) {
                view = new DataView(cmd.ViewStudentEnrolments(semVal, colVal, stdVal, crsVal));
                TXT_StudentEnrolments_Grade.Text = "";
            } else if (CHKBOX_StudentEnrolments_Registration.Checked) {
                view = new DataView(cmd.ViewStudentRegistrations(semVal, colVal, stdVal));
                TXT_StudentEnrolments_Grade.Text = "";
                ResetCombo(CMB_StudentEnrolments_Enrolment);
            } else {
                view = new DataView(cmd.ViewCollegeAssignments(semVal, colVal));
                TXT_StudentEnrolments_Grade.Text = "";
                ResetCombo(CMB_StudentEnrolments_Enrolment);
                ResetCombo(CMB_StudentEnrolments_Registration);
            }
            return view;
        }
        private DataView GetTransactionsView() {
            DataView view;
            int invVal =
                CMB_Transactions_Invoice.SelectedIndex > 0 ?
                int.Parse(CMB_Transactions_Invoice.SelectedIndex.ToString()) :
                0;
            string stdVal =
                CMB_Transactions_Student.SelectedIndex > 0 ?
                CMB_Transactions_Student.SelectedValue.ToString() :
                "";
            int semVal =
                CMB_Transactions_Semester.SelectedIndex > 0 ?
                int.Parse(CMB_Transactions_Semester.SelectedValue.ToString()) :
                0;
            int colVal =
                CMB_Transactions_College.SelectedIndex > 0 ?
                int.Parse(CMB_Transactions_College.SelectedValue.ToString()) :
                0;
            string crsVal =
                CMB_Transactions_Course.SelectedIndex > 0 ?
                CMB_Transactions_Course.SelectedValue.ToString() :
                "";
            view = new DataView(cmd.SearchInvoiceFields(invVal, stdVal, semVal,colVal,crsVal));
            return view;
        }

        /* These functions now performed in GetView() - may be refactored
        //private void CourseAllocations() {
        //    DataTable dataTable;
        //    DataView dataView = GetCourseAllocationsView();
        //    ColumnProperties columnProperties = new ColumnProperties() { };
        //    ButtonColumn[] buttons;

        //    Updating(LBL_CourseAllocationsRefresh, "Updating...");
        //    List<string> showColumns = new List<string> { "Year", "IsSecondSemester", "SemesterKey", "SemesterName", "CollegeId", "CollegeName" };
        //    string results = "colleges operating during semesters";
        //    GRPBOX_CourseAllocations.Text = "🔍 Colleges operating during Semesters";
        //    buttons = new ButtonColumn[] { columnProperties.assignCourse };


        //    if (CHKBOX_CourseAllocations_Course.Checked) {
        //        showColumns.Add("CourseCode");
        //        showColumns.Add("CourseName");
        //        results = "courses assigned to colleges during semesters";
        //        GRPBOX_CourseAllocations.Text = "🔍 Courses assigned to Colleges during Semesters";
        //        buttons = new ButtonColumn[] { columnProperties.linkSubjects };
        //    }
        //    if (CHKBOX_CourseAllocations_Subject.Checked) {
        //        showColumns.Add("SubjectName");
        //        results = "subjects in courses";
        //        GRPBOX_CourseAllocations.Text = "🔍 Subjects in Courses";
        //        buttons = new ButtonColumn[] { columnProperties.addUnits };
        //    }
        //    if (CHKBOX_CourseAllocations_Teacher.Checked) {
        //        showColumns.Add("TeacherFullName");
        //        showColumns.Add("TeacherEmail");
        //        results = "teachers assigned to a subject in courses";
        //        GRPBOX_CourseAllocations.Text = "🔍 Teachers assigned to Subjects";
        //        buttons = new ButtonColumn[] { columnProperties.addUnits };
        //    }
        //    if (CHKBOX_CourseAllocations_Unit.Checked) {
        //        showColumns.Add("UnitCode");
        //        showColumns.Add("UnitDescription");
        //        showColumns.Add("Core");
        //        results = "units assigned to subjects";
        //        GRPBOX_CourseAllocations.Text = "🔍 Units assigned to Subjects";
        //        buttons = new ButtonColumn[] { };
        //    }

        //    dataTable = dataView.Count < 1 ? dataView.ToTable(false) : dataView.ToTable(false, showColumns.ToArray());
        //    GetView("Course Allocations", dataTable, buttons, results);

        //    //FormatDGV(DGV_CourseAllocations, dataTable);
        //    //if (loadCombos) {
        //    CourseAllocations_Combos(dataView);
        //    //}
        //    //LBL_CourseAllocationsSearchRequest.Text = string.Format("Viewing {0} {1}", resultCount, results); ;
        //}
        //private void InvoiceReceipts() {
        //    DataView dataView = CMB_Transactions_Student.SelectedIndex < 0 ?
        //        new DataView(cmd.SearchInvoiceFields("")) :
        //        new DataView(cmd.SearchInvoiceFields(CMB_Transactions_Student.SelectedValue.ToString()));
        //    DataTable dataTable = dataView.ToTable(false);
        //    GetView("Transactions", dataTable);
        //    Transactions_Combos(dataView);
        //}
        //private void UnitCourse() {
        //    List<string> showColumns = new List<string> { "CourseCode", "Course", "UnitCode", "Unit", "Core" };
        //    string results = "Viewing Course Assigned Units";
        //    string resultFilter = "";
        //    DataTable dataTable;
        //    DataView dataView = GetCourseUnitView();
        //    dataTable = dataView.Count < 1 ? dataView.ToTable(false) : dataView.ToTable(false, showColumns.ToArray());
        //    //FormatDGV(DGV_UnitCourse, dataTable);
        //    //if (loadCombos) {
        //    CourseUnit_Combos(dataView);
        //    //}
        //    LBL_UnitCourseSearchRequest.Text = string.Format("{0} ({1})", results + resultFilter, resultCount);
        //}
        //private void StudentEnrolments() {
        //    DataTable dataTable;
        //    DataView dataView = GetStudentEnrolmentsView();
        //    ColumnProperties columnProperties = new ColumnProperties() { };
        //    ButtonColumn[] buttons;

        //    Updating(LBL_StudentEnrolmentsRefresh, "Updating...");
        //    List<string> showColumns = new List<string> { "Year", "IsSecondSemester", "SemesterKey", "SemesterName", "CollegeId", "CollegeName" };
        //    string results = "colleges operating during semesters";
        //    GRPBOX_StudentEnrolments.Text = "🔍 Colleges operating during Semesters";
        //    buttons = new ButtonColumn[] { columnProperties.register };

        //    if (CHKBOX_StudentEnrolments_Registration.Checked) {
        //        showColumns.Add("StudentFullName");
        //        //showColumns.Add("FirstName");
        //        //showColumns.Add("LastName");
        //        showColumns.Add("StudentEmail");
        //        showColumns.Add("DateRegistered");
        //        results = "Viewing Student Registrations";
        //        GRPBOX_StudentEnrolments.Text = "🔍 Showing Student Registrations";
        //        buttons = new ButtonColumn[] { columnProperties.enrol };
        //    }

        //    if (CHKBOX_StudentEnrolments_Enrolment.Checked) {
        //        showColumns.Add("DateEnroled");
        //        showColumns.Add("CourseCode");
        //        showColumns.Add("CourseName");
        //        results = "Viewing Course Enrolments";
        //        GRPBOX_StudentEnrolments.Text = "🔍 Showing Course Enrolments";
        //        buttons = new ButtonColumn[] { columnProperties.grades };
        //    }
        //    if (CHKBOX_StudentEnrolments_Grade.Checked) {
        //        showColumns.Add("UnitCode");
        //        showColumns.Add("UnitDescription");
        //        showColumns.Add("TeacherFullName");
        //        showColumns.Add("Grade");
        //        showColumns.Add("RPL");
        //        showColumns.Add("DateGraded");
        //        results = "Viewing Student Grades";
        //        GRPBOX_StudentEnrolments.Text = "🔍 Showing Student Grades";
        //        buttons = new ButtonColumn[] { };
        //    }
        //    //string resultFilter = "";


        //    dataTable = dataView.Count < 1 ? dataView.ToTable(false) : dataView.ToTable(false, showColumns.ToArray());
        //    GetView("Student Enrolments", dataTable, buttons, results);

        //    //FormatDGV(DGV_StudentEnrol, dataTable);
        //    //if (loadCombos) {
        //    StudentEnrolments_Combos(dataView);
        //    //}
        //    //LBL_StudentEnrolSearchRequest.Text = string.Format("{0} ({1})", results + resultFilter, resultCount);
        //}
        */

        // Reset filter functions
        private void ResetFilters_CourseUnit() {
            CMB_CourseUnit_Course.SelectedValue = "";
            TXT_CourseUnit_Unit.Text = "";
        }
        private void ResetFilters_StudentEnrolments() {
            CMB_StudentEnrolments_Semester.SelectedValue = 0;
            CMB_StudentEnrolments_College.SelectedValue = 0;
            CMB_StudentEnrolments_Registration.SelectedValue = "";
            CMB_StudentEnrolments_Enrolment.SelectedValue = "";
            TXT_StudentEnrolments_Grade.Text = "";
        }
        private void ResetFilters_CourseAllocations() {
            CMB_CourseAllocations_Semester.SelectedValue = 0;
            CMB_CourseAllocations_College.SelectedValue = 0;
            CMB_CourseAllocations_Course.SelectedValue = "";
            CMB_CourseAllocations_Subject.SelectedValue = 0;
            CMB_CourseAllocations_Teacher.SelectedValue = "";
            TXT_CourseAllocations_Unit.Text = "";
        }
        private void ResetFilters_Transactions() {
            CMB_Transactions_Invoice.SelectedIndex = 0;
            CMB_Transactions_Student.SelectedValue = 0;
            CMB_Transactions_Semester.SelectedValue = 0;
            CMB_Transactions_College.SelectedValue = 0;
            CMB_Transactions_Course.SelectedValue = "";
        }

        // ComboBox functions
        private void PrePopCourseAllocationCombos() {
            PopCombo(CMB_CourseAllocations_Semester, null, null, null, false);
            PopCombo(CMB_CourseAllocations_College, null, null, null, false);
            PopCombo(CMB_CourseAllocations_Course, null, null, null, false);
            PopCombo(CMB_CourseAllocations_Subject, null, null, null, false);
            PopCombo(CMB_CourseAllocations_Teacher, null, null, null, false);
        }
        private void PrePopStudentEnrolmentsCombos() {
            PopCombo(CMB_StudentEnrolments_Semester, null, null, null, false);
            PopCombo(CMB_StudentEnrolments_College, null, null, null, false);
            //if (CMB_StudentEnrolments_Registration.Items.Count < 1) { 
                PopCombo(CMB_StudentEnrolments_Registration, null, null, null, false);
            //}
            PopCombo(CMB_StudentEnrolments_Enrolment, null, null, null, false);
        }
        private void PrePopTransactionCombos() {
            CMB_Transactions_Invoice.DisplayMember = "Key";
            CMB_Transactions_Invoice.ValueMember = "Value";
            CMB_Transactions_Invoice.Items.Add(new KeyValuePair<string, int>("Invoice and Receipts", 0));
            CMB_Transactions_Invoice.Items.Add(new KeyValuePair<string, int>("Invoices only", 1));
            CMB_Transactions_Invoice.Items.Add(new KeyValuePair<string, int>("Receipts only", 2));
            CMB_Transactions_Invoice.SelectedIndex = 0;
            PopCombo(CMB_Transactions_Student, null, null, null, false);
            PopCombo(CMB_Transactions_Semester, null, null, null, false);
            PopCombo(CMB_Transactions_College, null, null, null, false);
            PopCombo(CMB_Transactions_Course, null, null, null, false);
        }
        private void CourseAllocations_Combos(DataView dataView) {
            // Semester and college combos always get refreshed if they have not been selected
            if (CMB_CourseAllocations_Semester.SelectedIndex < 1 && courseAllocationsView.ResultCount > 0) {
                dataView.Sort = "SemesterName";
                PopCombo(CMB_CourseAllocations_Semester, dataView, "SemesterName", "SemesterKey", true);
            }
            if (CMB_CourseAllocations_College.SelectedIndex < 1 && courseAllocationsView.ResultCount > 0) {
                dataView.Sort = "CollegeName";
                PopCombo(CMB_CourseAllocations_College, dataView, "CollegeName", "CollegeId", true);
            }
            // When Course enabled and subject disabled
            // Course combo is refreshed if it has not been selected 
            // whilst resetting subject, teacher and unit
            if (CHKBOX_CourseAllocations_Course.Checked && !CHKBOX_CourseAllocations_Subject.Checked && courseAllocationsView.ResultCount > 0) {
                if (CMB_CourseAllocations_Course.SelectedIndex < 1) {
                    dataView.Sort = "CourseCode";
                    PopCombo(CMB_CourseAllocations_Course, dataView, "CoursePlusCode", "CourseCode", false);
                }
            }
            // When Subject enabled and Teacher disabled
            // Course and Subject combo are refreshed if they have not been selected 
            // whilst resetting teacher and unit
            if (CHKBOX_CourseAllocations_Subject.Checked && !CHKBOX_CourseAllocations_Teacher.Checked && courseAllocationsView.ResultCount > 0) {
                if (CMB_CourseAllocations_Course.SelectedIndex < 1) {
                    dataView.Sort = "CourseCode";
                    PopCombo(CMB_CourseAllocations_Course, dataView, "CoursePlusCode", "CourseCode", false);
                }
                if (CMB_CourseAllocations_Subject.SelectedIndex < 1) {
                    dataView.Sort = "SubjectName";
                    PopCombo(CMB_CourseAllocations_Subject, dataView, "SubjectName", "SubjectId", true);
                }
            }
            // When Teacher enabled and Unit disabled
            // Course and Subject and Teacher combo are refreshed if they have not been selected 
            // whilst resetting unit
            if (CHKBOX_CourseAllocations_Teacher.Checked && !CHKBOX_CourseAllocations_Unit.Checked && courseAllocationsView.ResultCount > 0) {
                if (CMB_CourseAllocations_Course.SelectedIndex < 1) {
                    dataView.Sort = "CourseCode";
                    PopCombo(CMB_CourseAllocations_Course, dataView, "CoursePlusCode", "CourseCode", false);
                }
                if (CMB_CourseAllocations_Subject.SelectedIndex < 1) {
                    dataView.Sort = "SubjectName";
                    PopCombo(CMB_CourseAllocations_Subject, dataView, "SubjectName", "SubjectId", true);
                }
                if (CMB_CourseAllocations_Teacher.SelectedIndex < 1) {
                    dataView.Sort = "TeacherFullName";
                    PopCombo(CMB_CourseAllocations_Teacher, dataView, "TeacherFullName", "TeacherEmail", false);
                }
            }
            // When Unit selected
            // All combos are refreshed if they have not been selected
            if (CHKBOX_CourseAllocations_Unit.Checked && courseAllocationsView.ResultCount > 0) {
                if (CMB_CourseAllocations_Course.SelectedIndex < 1) {
                    dataView.Sort = "CourseCode";
                    PopCombo(CMB_CourseAllocations_Course, dataView, "CoursePlusCode", "CourseCode", false);
                }
                if (CMB_CourseAllocations_Subject.SelectedIndex < 1) {
                    dataView.Sort = "SubjectName";
                    PopCombo(CMB_CourseAllocations_Subject, dataView, "SubjectName", "SubjectId", true);
                }
                if (CMB_CourseAllocations_Teacher.SelectedIndex < 1) {
                    dataView.Sort = "TeacherFullName";
                    PopCombo(CMB_CourseAllocations_Teacher, dataView, "TeacherFullName", "TeacherEmail", false);
                }
            }
        }
        private void StudentEnrolments_Combos(DataView dataView) {
            // Semester and college combos always get refreshed if they have not been selected
            if (CMB_StudentEnrolments_Semester.SelectedIndex < 1 && studentEnrolmentsView.ResultCount > 0) {
                dataView.Sort = "SemesterName";
                PopCombo(CMB_StudentEnrolments_Semester, dataView, "SemesterName", "SemesterKey", true);
            }
            if (CMB_StudentEnrolments_College.SelectedIndex < 1 && studentEnrolmentsView.ResultCount > 0) {
                dataView.Sort = "CollegeName";
                PopCombo(CMB_StudentEnrolments_College, dataView, "CollegeName", "CollegeId", true);
            }
            // Student, Semester and college combos always get refreshed if they have not been selected
            if (CHKBOX_StudentEnrolments_Registration.Checked && !CHKBOX_StudentEnrolments_Enrolment.Checked && studentEnrolmentsView.ResultCount > 0) {
                if (CMB_StudentEnrolments_Registration.SelectedIndex < 1) {
                    dataView.Sort = "StudentFullName";
                    PopCombo(CMB_StudentEnrolments_Registration, dataView, "StudentFullName", "StudentEmail", false);
                }
            }
            // When Course enabled and subject disabled
            // Course combo is refreshed if it has not been selected 
            // whilst  and unit
            if (CHKBOX_StudentEnrolments_Enrolment.Checked && !CHKBOX_StudentEnrolments_Grade.Checked && studentEnrolmentsView.ResultCount > 0) {
                if (CMB_StudentEnrolments_Registration.SelectedIndex < 1) {
                    dataView.Sort = "StudentFullName";
                    PopCombo(CMB_StudentEnrolments_Registration, dataView, "StudentFullName", "StudentEmail", false);
                }
                if (CMB_StudentEnrolments_Enrolment.SelectedIndex < 1) {
                    dataView.Sort = "CourseCode";
                    PopCombo(CMB_StudentEnrolments_Enrolment, dataView, "CoursePlusCode", "CourseCode", false);
                }
            }
            // When Unit selected
            // All combos are refreshed if they have not been selected
            if (CHKBOX_StudentEnrolments_Grade.Checked && studentEnrolmentsView.ResultCount > 0) {
                if (CMB_StudentEnrolments_Registration.SelectedIndex < 1) {
                    dataView.Sort = "StudentFullName";
                    PopCombo(CMB_StudentEnrolments_Registration, dataView, "StudentFullName", "StudentEmail", false);
                }
                if (CMB_StudentEnrolments_Enrolment.SelectedIndex < 1) {
                    dataView.Sort = "CourseCode";
                    PopCombo(CMB_StudentEnrolments_Enrolment, dataView, "CoursePlusCode", "CourseCode", false);
                }
            }
        }
        private void Transactions_Combos(DataView dataView) {
            if (CMB_Transactions_Student.SelectedIndex < 1) {
                // Removes empty row (totals)
                for (int i = 0; i < dataView.ToTable().Rows.Count; i++) {
                    if (dataView.ToTable().Rows[i]["StudentFullName"].ToString().ToLower().Equals("")) {
                        dataView.Table.Rows.RemoveAt(i);
                    }
                }
                dataView.Sort = "StudentFullName";
                PopCombo(CMB_Transactions_Student, dataView, "StudentFullName", "StudentEmail", false);
            }
            if (CMB_Transactions_Semester.SelectedIndex < 1) {
                for (int i = 0; i < dataView.ToTable().Rows.Count; i++) {
                    if (dataView.ToTable().Rows[i]["SemesterKey"].Equals(0)) {
                        dataView.Table.Rows.RemoveAt(i);
                    }
                }
                dataView.Sort = "SemesterName";
                PopCombo(CMB_Transactions_Semester, dataView, "SemesterName", "SemesterKey", true);
            }
            if (CMB_Transactions_College.SelectedIndex < 1) {
                for (int i = 0; i < dataView.ToTable().Rows.Count; i++) {
                    if (dataView.ToTable().Rows[i]["CollegeId"].Equals(0)) {
                        dataView.Table.Rows.RemoveAt(i);
                    }
                }
                dataView.Sort = "CollegeName";
                PopCombo(CMB_Transactions_College, dataView, "CollegeName", "CollegeId", true);
            }
            if (CMB_Transactions_Course.SelectedIndex < 1) {
                for (int i = 0; i < dataView.ToTable().Rows.Count; i++) {
                    if (dataView.ToTable().Rows[i]["CourseCode"].Equals("")) {
                        dataView.Table.Rows.RemoveAt(i);
                    }
                }
                dataView.Sort = "CoursePlusCode";
                PopCombo(CMB_Transactions_Course, dataView, "CoursePlusCode", "CourseCode", false);
            }
        }
        private void CourseUnit_Combos(DataView dataView) {
            if (CMB_CourseUnit_Course.SelectedIndex < 1 && unitCourseView.ResultCount > 0) {
                dataView.Sort = "CoursePlusCode";
                PopCombo(CMB_CourseUnit_Course, dataView, "CoursePlusCode", "CourseCode", false);
            }
        }
        private void ResetCombo(ComboBox comboBox) {
            PopCombo(comboBox, null, null, null, false);
            comboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Generic function to populate a combo<br/>
        /// Requires ComboBox, DataView, values for display and value members and if value is an int
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="dataView"></param>
        /// <param name="displayMember"></param>
        /// <param name="valueMember"></param>
        /// <param name="isInt"></param>
        public void PopCombo(ComboBox comboBox, DataView dataView, string displayMember, string valueMember, bool isInt) {
            if (dataView != null) {
                DataTable dataTable = dataView.ToTable(true, displayMember, valueMember);
                DataRow dataRow = dataTable.NewRow();
                dataRow[displayMember] = "-- No selection --";
                dataRow[valueMember] = isInt ? dataRow[valueMember] = 0 : dataRow[valueMember] = "";
                dataTable.Rows.InsertAt(dataRow, 0);
                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
                comboBox.SelectedIndex = 0;
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            } else {
                comboBox.DataSource = null;
                comboBox.Items.Clear();
                comboBox.Items.Add(new { Name = "-- No selection --", Value = 0 });
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "Value";
                comboBox.SelectedValue = 0;
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        // Write results
        private void WriteResults(Label label, string search, int count) {
            label.Text = string.Format("Viewing {0} ({1})", search, count);
        }

        // Disable button cell of grid  -  Currently Unused - WIP
        private void ButtonCellStyle_Disabled(DataGridViewCell cell) {
            DataGridViewDisableButtonCell btnCell = cell as DataGridViewDisableButtonCell;
            btnCell.Style = ColumnProperties.btnCellStyle;
            btnCell.FlatStyle = ColumnProperties.disabledStyle;
            btnCell.Style.ForeColor = ColumnProperties.disabledColour;
            btnCell.Enabled = false;
            cell.ReadOnly = true;
        }

        // Events
        // Student actions
        private void BTN_Students_Filter_Click(object sender, EventArgs e) {
            GetView("Students", TXT_Students_Student.Text);
        }
        private void BTN_Students_Reset_Click(object sender, EventArgs e) {
            TXT_Students_Student.Text = "";
            GetView("Students");
        }
        private void BTN_Students_Add_Click(object sender, EventArgs e) {
            new DialogStudent(this).ShowDialog();
        }
        // Teacher actions
        private void BTN_Teachers_Filter_Click(object sender, EventArgs e) {
            GetView("Teachers", TXT_Teachers_Teacher.Text);
        }
        private void BTN_Teachers_Reset_Click(object sender, EventArgs e) {
            TXT_Teachers_Teacher.Text = "";
            GetView("Teachers");
        }
        private void BTN_Teachers_Add_Click(object sender, EventArgs e) {
            new DialogTeacher(this).ShowDialog();
        }
        // Admin actions
        private void BTN_Admins_Filter_Click(object sender, EventArgs e) {
            GetView("Administrators", TXT_Admins_Admin.Text);
        }
        private void BTN_Admins_Reset_Click(object sender, EventArgs e) {
            TXT_Admins_Admin.Text = "";
            GetView("Administrators");
        }
        private void BTN_Admins_Add_Click(object sender, EventArgs e) {
            new DialogAdmin(this).ShowDialog();
        }
        // Semester actions
        private void BTN_Semesters_Filter_Click(object sender, EventArgs e) {
            GetView("Semesters", TXT_Semesters_Semester.Text);
        }
        private void BTN_Semesters_Reset_Click(object sender, EventArgs e) {
            TXT_Semesters_Semester.Text = "";
            GetView("Semesters");
        }
        private void BTN_Semesters_Add_Click(object sender, EventArgs e) {
            new DialogSemester(this).ShowDialog();
        }
        /* Currently Unused - WIP
        private void DGV_Semesters_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            //if (semesterView.IsFormattingComplete) { 
            //    for (int i = 0; i < DGV_Semesters.RowCount; i++) {
            //        if ((int)DGV_Semesters.Rows[i].Cells["SemesterKey"].Value <= currentSemester.Key) {
            //            ButtonCellStyle_Disabled(DGV_Semesters.Rows[i].Cells["JoinCollege"]);
            //        }
            //    }
            //}
        }
        */
        // College actions
        private void BTN_Colleges_Filter_Click(object sender, EventArgs e) {
            GetView("Colleges", TXT_Colleges_College.Text);
        }
        private void BTN_Colleges_Reset_Click(object sender, EventArgs e) {
            TXT_Colleges_College.Text = "";
            GetView("Colleges");
        }
        private void BTN_Colleges_Add_Click(object sender, EventArgs e) {
            new DialogCollege(this).ShowDialog();
        }
        // Course actions
        private void BTN_Courses_Filter_Click(object sender, EventArgs e) {
            GetView("Courses", TXT_Courses_Course.Text);
        }
        private void BTN_Courses_Reset_Click(object sender, EventArgs e) {
            TXT_Courses_Course.Text = "";
            GetView("Courses");
        }
        private void BTN_Courses_Add_Click(object sender, EventArgs e) {
            new DialogCourse(this).ShowDialog();
        }
        private void BTN_Courses_Unused_Click(object sender, EventArgs e) {
            new DialogNeverRun("course").ShowDialog();
        }
        // Subject actions
        private void BTN_Subjects_Filter_Click(object sender, EventArgs e) {
            GetView("Subjects", TXT_Subjects_Subject.Text);
        }
        private void BTN_Subjects_Reset_Click(object sender, EventArgs e) {
            TXT_Subjects_Subject.Text = "";
            GetView("Subjects");
        }
        private void BTN_Subjects_Add_Click(object sender, EventArgs e) {
            new DialogSubject(this).ShowDialog();
        }
        private void BTN_Subjects_Unused_Click(object sender, EventArgs e) {
            new DialogNeverRun("subject").ShowDialog();
        }
        // Unit actions
        private void BTN_Units_Filter_Click(object sender, EventArgs e) {
            GetView("Units", TXT_Units_Unit.Text);
        }
        private void BTN_Units_Reset_Click(object sender, EventArgs e) {
            TXT_Units_Unit.Text = "";
            GetView("Units");
        }
        private void BTN_Units_Add_Click(object sender, EventArgs e) {
            new DialogUnit(this).ShowDialog();
        }
        private void BTN_Units_Unused_Click(object sender, EventArgs e) {
            new DialogNeverRun("unit").ShowDialog();
        }
        // Transactions actions
        private void BTN_Transactions_Filter_Click(object sender, EventArgs e) {
            GetView("Transactions");
        }
        private void BTN_Transactions_Reset_Click(object sender, EventArgs e) {
            ResetFilters_Transactions();
            GetView("Transactions");
        }
        private void BTN_Transactions_Receipt_Add_Click(object sender, EventArgs e) {
            // To be completed in future revisions
        }
        private void BTN_Transactions_Invoice_Add_Click(object sender, EventArgs e) {
            // To be completed in future revisions
        }
        private void Transactions_SelectionChangeCommitted(object sender, EventArgs e) {
            LBL_Transactions_Refresh.Visible = true;
        }
        private void DGV_Transactions_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (DGV_Transactions.IsCurrentCellDirty) {
                DGV_Transactions.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void DGV_Transactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            // CellFormatting is called way too many times - must find a way to limit executions
            //testInt_A++; // debugging var
            if (DGV_Transactions.Columns[e.ColumnIndex].Name == "Amount") {
                //testInt_B++; // debugging var
                if (transactionsView.IsFormattingComplete) {
                    //testInt_C++; // debugging var
                    if (decimal.TryParse(DGV_Transactions.Rows[e.RowIndex].Cells["Amount"].Value.ToString(), out _)) {
                        if ((decimal)DGV_Transactions.Rows[e.RowIndex].Cells["Amount"].Value < 0m) {
                            DGV_Transactions.Rows[e.RowIndex].Cells["Amount"].Style.ForeColor = ColumnProperties.negativeAmountColour;
                        } else {
                            DGV_Transactions.Rows[e.RowIndex].Cells["Amount"].Style.ForeColor = ColumnProperties.positiveAmountColour;
                        }
                    }
                    for (int i = 0; i < DGV_Transactions.RowCount; i++) {
                        if (DGV_Transactions.Rows[i].Cells["ReceiptId"].Value.ToString() != "") {
                            ButtonCellStyle_Disabled(DGV_Transactions.Rows[i].Cells["AddReceipt"]);
                        }
                    }
                }
            }
            // Debug - output to console
            //Console.WriteLine(string.Format(
            //    "-\n{0,-25}: {1}\n{2,-25}: {3}\n{4,-25}: {5}",
            //    "CellFormatting", testInt_A,
            //    "Column", testInt_B,
            //    "isComplete", testInt_C
            //    ));
            // First Run:-
            // CellFormatting           : 2861
            // Column                   : 340
            // isComplete               : 340

            // Subsequent runs:-
            // CellFormatting           : 18891
            // Column                   : 1997
            // isComplete               : 80
        }
        private void DGV_Transactions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            DGV_Transactions.Rows[DGV_Transactions.RowCount - 1].DefaultCellStyle.Font = ColumnProperties.rowTotalsFont;
            if (transactionsView.IsFormattingComplete) {
                foreach (DataGridViewColumn col in DGV_Transactions.Columns) {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }
        // Student Enrolment actions
        private void BTN_StudentEnrolments_Filter_Click(object sender, EventArgs e) {
            GetView("Student Enrolments");
        }
        private void BTN_StudentEnrolments_Reset_Click(object sender, EventArgs e) {
            ResetFilters_StudentEnrolments();
            GetView("Student Enrolments");
        }
        private void StudentEnrolments_CheckedChanged(object sender, EventArgs e) {
            LBL_StudentEnrolments_Refresh.Visible = true;
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name) {
                case "CHKBOX_StudentEnrolments_Registration":
                    if (checkBox.Checked) {
                        LBL_StudentEnrolmentsTitle_03.ForeColor = activeColour;
                        LBL_StudentEnrolmentsTitle_01.ForeColor = passiveColour;
                    } else {
                        LBL_StudentEnrolmentsTitle_01.ForeColor = activeColour;
                    }
                    TBL_StudentEnrolments_Registration.Enabled = checkBox.Checked;

                    LBL_StudentEnrolmentsTitle_03.Enabled = checkBox.Checked;
                    LBL_StudentEnrolmentsTitle_04.Enabled = checkBox.Checked;
                    break;
                case "CHKBOX_StudentEnrolments_Enrolment":
                    if (checkBox.Checked) {
                        TBL_StudentEnrolments_Enrolment.Enabled = true;
                        CHKBOX_StudentEnrolments_Registration.Checked = true;
                        CHKBOX_StudentEnrolments_Registration.Enabled = false;

                        LBL_StudentEnrolmentsTitle_05.ForeColor = activeColour;
                        LBL_StudentEnrolmentsTitle_03.ForeColor = passiveColour;
                    } else {
                        LBL_StudentEnrolmentsTitle_03.ForeColor = activeColour;
                    }
                    TBL_StudentEnrolments_Enrolment.Enabled = checkBox.Checked;
                    CHKBOX_StudentEnrolments_Registration.Enabled = !checkBox.Checked;

                    LBL_StudentEnrolmentsTitle_05.Enabled = checkBox.Checked;
                    LBL_StudentEnrolmentsTitle_06.Enabled = checkBox.Checked;
                    break;
                case "CHKBOX_StudentEnrolments_Grade":
                    if (checkBox.Checked) {
                        TBL_StudentEnrolments_Registration.Enabled = true;
                        CHKBOX_StudentEnrolments_Registration.Checked = true;
                        CHKBOX_StudentEnrolments_Registration.Enabled = false;

                        TBL_StudentEnrolments_Enrolment.Enabled = true;
                        CHKBOX_StudentEnrolments_Enrolment.Checked = true;
                        CHKBOX_StudentEnrolments_Enrolment.Enabled = false;

                        LBL_StudentEnrolmentsTitle_07.ForeColor = activeColour;
                        LBL_StudentEnrolmentsTitle_05.ForeColor = passiveColour;
                    } else {
                        LBL_StudentEnrolmentsTitle_05.ForeColor = activeColour;
                    }
                    TBL_StudentEnrolments_Grade.Enabled = checkBox.Checked;
                    CHKBOX_StudentEnrolments_Enrolment.Enabled = !checkBox.Checked;

                    LBL_StudentEnrolmentsTitle_07.Enabled = checkBox.Checked;
                    LBL_StudentEnrolmentsTitle_08.Enabled = checkBox.Checked;
                    break;
                default:
                    break;
            }
        }
        private void StudentEnrolments_SelectionChangeCommitted(object sender, EventArgs e) {
            LBL_StudentEnrolments_Refresh.Visible = true;

        }
        /* Currently Unused - WIP
        private void DGV_StudentEnrolments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            // Unused at present due to performace issues
            //if(DGV_StudentEnrol.Columns.Contains("Grade")){ 
            //    if (DGV_StudentEnrol.Rows[e.RowIndex].Cells["Grade"].Value != null &&
            //        !string.IsNullOrWhiteSpace(DGV_StudentEnrol.Rows[e.RowIndex].Cells["Grade"].Value.ToString()) &&
            //        DGV_StudentEnrol.Rows[e.RowIndex].Cells["Grade"].Value.GetType() == typeof(string)
            //        ) {
            //        if (DGV_StudentEnrol.Rows[e.RowIndex].Cells["Grade"].Value.ToString() == "Pass") {
            //            DGV_StudentEnrol.Rows[e.RowIndex].Cells["Grade"].Style = new DataGridViewCellStyle { ForeColor = Color.Green };
            //        } else {
            //            DGV_StudentEnrol.Rows[e.RowIndex].Cells["Grade"].Style = new DataGridViewCellStyle { ForeColor = Color.DarkRed };
            //        }
            //    }
            //}
        }
        private void DGV_StudentEnrolments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            //if (studentEnrolmentsView.IsFormattingComplete) {
            //    for (int i = 0; i < DGV_StudentEnrolments.RowCount; i++) {
            //        if (int.Parse(DGV_StudentEnrolments.Rows[i].Cells["SemesterKey"].Value.ToString()) <= currentSemester.Key &&
            //            CHKBOX_StudentEnrolments_Registration.Checked == false) {
            //            ButtonCellStyle_Disabled(DGV_StudentEnrolments.Rows[i].Cells["Register"]);
            //        }
            //    }
            //}
        }
        */
        // Course Allocation actions
        private void BTN_CourseAllocations_Filter_Click(object sender, EventArgs e) {
            GetView("Course Allocations");
        }
        private void BTN_CourseAllocations_Reset_Click(object sender, EventArgs e) {
            ResetFilters_CourseAllocations();
            GetView("Course Allocations");
        }
        private void CourseAllocations_CheckedChanged(object sender, EventArgs e) {
            LBL_CourseAllocations_Refresh.Visible = true;
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name) {
                case "CHKBOX_CourseAllocations_Course":
                    if (checkBox.Checked) {
                        LBL_CourseAllocationsTitle_03.ForeColor = activeColour;
                        LBL_CourseAllocationsTitle_01.ForeColor = passiveColour;
                    } else {
                        LBL_CourseAllocationsTitle_01.ForeColor = activeColour;
                    }
                    TBL_CourseAllocations_Course.Enabled = checkBox.Checked;

                    LBL_CourseAllocationsTitle_03.Enabled = checkBox.Checked;
                    LBL_CourseAllocationsTitle_04.Enabled = checkBox.Checked;
                    break;
                case "CHKBOX_CourseAllocations_Subject":
                    if (checkBox.Checked) {
                        TBL_CourseAllocations_Course.Enabled = true;
                        CHKBOX_CourseAllocations_Course.Checked = true;
                        CHKBOX_CourseAllocations_Course.Enabled = false;

                        LBL_CourseAllocationsTitle_05.ForeColor = activeColour;
                        LBL_CourseAllocationsTitle_03.ForeColor = passiveColour;
                    } else {
                        LBL_CourseAllocationsTitle_03.ForeColor = activeColour;
                    }
                    TBL_CourseAllocations_Subject.Enabled = checkBox.Checked;
                    CHKBOX_CourseAllocations_Course.Enabled = !checkBox.Checked;

                    LBL_CourseAllocationsTitle_05.Enabled = checkBox.Checked;
                    LBL_CourseAllocationsTitle_06.Enabled = checkBox.Checked;
                    break;
                case "CHKBOX_CourseAllocations_Teacher":
                    if (checkBox.Checked) {
                        TBL_CourseAllocations_Course.Enabled = true;
                        CHKBOX_CourseAllocations_Course.Checked = true;
                        CHKBOX_CourseAllocations_Course.Enabled = false;

                        TBL_CourseAllocations_Subject.Enabled = true;
                        CHKBOX_CourseAllocations_Subject.Checked = true;
                        CHKBOX_CourseAllocations_Subject.Enabled = false;
                        LBL_CourseAllocationsTitle_07.ForeColor = activeColour;
                        LBL_CourseAllocationsTitle_05.ForeColor = passiveColour;
                    } else {
                        LBL_CourseAllocationsTitle_05.ForeColor = activeColour;
                    }
                    TBL_CourseAllocations_Teacher.Enabled = checkBox.Checked;
                    CHKBOX_CourseAllocations_Subject.Enabled = !checkBox.Checked;

                    LBL_CourseAllocationsTitle_07.Enabled = checkBox.Checked;
                    LBL_CourseAllocationsTitle_08.Enabled = checkBox.Checked;
                    break;
                case "CHKBOX_CourseAllocations_Unit":
                    if (checkBox.Checked) {
                        TBL_CourseAllocations_Course.Enabled = true;
                        CHKBOX_CourseAllocations_Course.Checked = true;
                        CHKBOX_CourseAllocations_Course.Enabled = false;

                        TBL_CourseAllocations_Subject.Enabled = true;
                        CHKBOX_CourseAllocations_Subject.Checked = true;
                        CHKBOX_CourseAllocations_Subject.Enabled = false;

                        TBL_CourseAllocations_Teacher.Enabled = true;
                        CHKBOX_CourseAllocations_Teacher.Checked = true;
                        CHKBOX_CourseAllocations_Teacher.Enabled = false;

                        LBL_CourseAllocationsTitle_09.ForeColor = activeColour;
                        LBL_CourseAllocationsTitle_07.ForeColor = passiveColour;
                    } else {
                        LBL_CourseAllocationsTitle_07.ForeColor = activeColour;
                    }
                    TBL_CourseAllocations_Unit.Enabled = checkBox.Checked;
                    CHKBOX_CourseAllocations_Teacher.Enabled = !checkBox.Checked;

                    LBL_CourseAllocationsTitle_09.Enabled = checkBox.Checked;
                    LBL_CourseAllocationsTitle_10.Enabled = checkBox.Checked;
                    break;
                default:
                    break;
            }
        }
        private void CourseAllocations_SelectionChangeCommitted(object sender, EventArgs e) {
            LBL_CourseAllocations_Refresh.Visible = true;
        }
        /* Currently Unused - WIP
        private void DGV_CourseAllocations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            //if (courseAllocationsView.IsFormattingComplete) {
            //    for (int i = 0; i < DGV_CourseAllocations.RowCount; i++) {
            //        if (int.Parse(DGV_CourseAllocations.Rows[i].Cells["SemesterKey"].Value.ToString()) <= currentSemester.Key &&
            //            CHKBOX_CourseAllocations_Course.Checked == false) {
            //            ButtonCellStyle_Disabled(DGV_CourseAllocations.Rows[i].Cells["AssignCourse"]);
            //        }
            //    }
            //}
        }
        */
        // Course Assigned Units actions
        private void BTN_CourseUnit_Filter_Click(object sender, EventArgs e) {
            GetView("Course Assigned Units");
        }
        private void BTN_CourseUnit_Reset_Click(object sender, EventArgs e) {
            ResetFilters_CourseUnit();
            GetView("Course Assigned Units");
        }
        private void CourseUnit_SelectionChangeCommitted(object sender, EventArgs e) {
            LBL_CourseUnit_Refresh.Visible = true;
        }
        // Global events
        private void TABCTRL_Main_Selected(object sender, TabControlEventArgs e) {
            switch (e.TabPage.Text) {
                case "Students":
                    if (DGV_Students.DataSource == null) {
                        GetView("Students");
                    }
                    break;
                case "Teachers":
                    if (DGV_Teachers.DataSource == null) {
                        GetView("Teachers");
                    }
                    break;
                case "Administrators":
                    if (DGV_Admins.DataSource == null) {
                        GetView("Administrators");
                    }
                    break;
                case "Semesters":
                    if (DGV_Semesters.DataSource == null) {
                        GetView("Semesters");
                    }
                    break;
                case "Colleges":
                    if (DGV_Colleges.DataSource == null) {
                        GetView("Colleges");
                    }
                    break;
                case "Courses":
                    if (DGV_Courses.DataSource == null) {
                        GetView("Courses");
                    }
                    break;
                case "Subjects":
                    if (DGV_Subjects.DataSource == null) {
                        GetView("Subjects");
                    }
                    break;
                case "Units":
                    if (DGV_Units.DataSource == null) {
                        GetView("Units");
                    }
                    break;

                case "Transactions":
                    if (DGV_Transactions.DataSource == null) {
                        PrePopTransactionCombos();
                        GetView("Transactions");
                    }
                    break;
                case "Course Allocations":
                    if (DGV_CourseAllocations.DataSource == null) {
                        PrePopCourseAllocationCombos();
                        GetView("Course Allocations");
                    }
                    break;
                case "Course Assigned Units":
                    if (DGV_CourseUnit.DataSource == null) {
                        GetView("Course Assigned Units");
                    }
                    break;
                case "Student Enrolments":
                    if (DGV_StudentEnrolments.DataSource == null) {
                        PrePopStudentEnrolmentsCombos();
                        GetView("Student Enrolments");
                    }
                    break;
                default:
                    break;
            }
        }
        private void All_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView dgv;
            if (sender is DataGridView view) {
                dgv = view;
                if ("Update" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    switch (dgv.Name) {
                        case "DGV_Students":
                            new DialogStudent(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            break;
                        case "DGV_Admins":
                            new DialogAdmin(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            break;
                        case "DGV_Teachers":
                            new DialogTeacher(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            break;
                        case "DGV_Semesters":
                            new DialogSemester(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            break;
                        case "DGV_Colleges":
                            new DialogCollege(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            break;
                        case "DGV_Courses":
                            new DialogCourse(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            break;
                        case "DGV_Subjects":
                            new DialogSubject(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            break;
                        case "DGV_Units":
                            new DialogUnit(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            break;
                        case "DGV_CourseUnit":
                            new DialogCourseUnit(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            break;
                        default:
                            break;
                    }
                } else if ("Delete" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    switch (dgv.Name) {
                        case "DGV_Students":
                            if (cmd.DeleteStudent(DGV_Students.Rows[e.RowIndex].Cells["Email"].Value.ToString())) {
                                GetView("Students");
                            }
                            break;
                        case "DGV_Teachers":
                            if (cmd.DeleteTeacher(DGV_Teachers.Rows[e.RowIndex].Cells["Email"].Value.ToString())) {
                                GetView("Students");
                            }
                            break;
                        case "DGV_Admins":
                            if (cmd.DeleteAdmin(DGV_Admins.Rows[e.RowIndex].Cells["Email"].Value.ToString())) {
                                GetView("Admins");
                            }
                            break;
                        case "DGV_Semesters":
                            if (cmd.DeleteSemester((int)DGV_Semesters.Rows[e.RowIndex].Cells["SemesterKey"].Value)) {
                                GetView("Semesters");
                            }
                            break;
                        case "DGV_Colleges":
                            if (cmd.DeleteCollege((int)DGV_Colleges.Rows[e.RowIndex].Cells["CollegeId"].Value, DGV_Colleges.Rows[e.RowIndex].Cells["CollegeName"].Value.ToString())) {
                                GetView("Colleges");
                            }
                            break;
                        case "DGV_Courses":
                            if (cmd.DeleteCourse(DGV_Courses.Rows[e.RowIndex].Cells["CourseCode"].Value.ToString())) {
                                GetView("Courses");
                            }
                            break;
                        case "DGV_Subjects":
                            if (cmd.DeleteSubject((int)DGV_Subjects.Rows[e.RowIndex].Cells["SubjectId"].Value, DGV_Subjects.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString())) {
                                GetView("Subjects");
                            }
                            break;
                        case "DGV_Units":
                            if (cmd.DeleteUnit(DGV_Units.Rows[e.RowIndex].Cells["UnitCode"].Value.ToString())) {
                                GetView("Units");
                            }
                            break;
                    }
                } else if ("History" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    new DialogTeachingHistory(dgv.Rows[e.RowIndex]).ShowDialog();
                } else if ("AssignCourse" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly != true) { // exclude disabled buttons
                        new DialogCollegeCourse(this, dgv.Rows[e.RowIndex]).ShowDialog();
                    }
                } else if ("LinkSubjects" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    new DialogCourseSubject(this, dgv.Rows[e.RowIndex]).ShowDialog();
                } else if ("AddUnits" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    new DialogSubjectUnit(this, dgv.Rows[e.RowIndex]).ShowDialog();
                } else if ("AssignUnits" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    new DialogCourseUnit(this, dgv.Rows[e.RowIndex]).ShowDialog();
                } else if ("Register" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    switch (dgv.Name) {
                        case "DGV_Students":
                            new DialogRegister(this, dgv, e.RowIndex).ShowDialog(); // Alternate constructor
                            break;
                        case "DGV_StudentEnrolments":
                            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly != true) { // exclude disabled buttons
                                new DialogRegister(this, dgv.Rows[e.RowIndex]).ShowDialog();
                            }
                            break;
                        default:
                            break;
                    }
                } else if ("Enrol" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    new DialogEnrol(this, dgv.Rows[e.RowIndex]).ShowDialog();
                } else if ("Grades" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    new DialogGrade(this, dgv.Rows[e.RowIndex]).ShowDialog();
                } else if ("JoinCollege" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly != true) {  // exclude disabled buttons
                        new DialogSemesterCollege(this, dgv, e.RowIndex).ShowDialog(); // Alternate constructor
                    }
                } else if ("JoinSemester" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    new DialogSemesterCollege(this, dgv.Rows[e.RowIndex]).ShowDialog();
                } else if ("AddReceipt" == dgv.Columns[e.ColumnIndex].Name && e.RowIndex > -1) {
                    if (dgv.Rows[e.RowIndex].Cells["AddReceipt"].ReadOnly == false) {
                        new DialogReceipt(this, dgv.Rows[e.RowIndex]).ShowDialog();
                    }
                }
            }
        }
        private void CheckPanel_Click(object sender, EventArgs e) {
            string name = sender is Panel pnl ? pnl.Name :
                   sender is Label lbl ? lbl.Name :
                   sender is CheckBox chk ? chk.Name :
                   string.Empty;
            if (name.Contains("StudentEnrolments_Registration")) {
                if (CHKBOX_StudentEnrolments_Registration.Enabled) {
                    CHKBOX_StudentEnrolments_Registration.Checked = !CHKBOX_StudentEnrolments_Registration.Checked;
                }
            } else if (name.Contains("StudentEnrolments_Enrolment")) {
                if (CHKBOX_StudentEnrolments_Enrolment.Enabled) {
                    CHKBOX_StudentEnrolments_Enrolment.Checked = !CHKBOX_StudentEnrolments_Enrolment.Checked;
                }
            } else if (name.Contains("StudentEnrolments_Grade")) {
                if (CHKBOX_StudentEnrolments_Grade.Enabled) {
                    CHKBOX_StudentEnrolments_Grade.Checked = !CHKBOX_StudentEnrolments_Grade.Checked;
                }
            } else if (name.Contains("CourseAllocations_Course")) {
                if (CHKBOX_CourseAllocations_Course.Enabled) {
                    CHKBOX_CourseAllocations_Course.Checked = !CHKBOX_CourseAllocations_Course.Checked;
                }
            } else if (name.Contains("CourseAllocations_Subject")) {
                if (CHKBOX_CourseAllocations_Subject.Enabled) {
                    CHKBOX_CourseAllocations_Subject.Checked = !CHKBOX_CourseAllocations_Subject.Checked;
                }
            } else if (name.Contains("CourseAllocations_Teacher")) {
                if (CHKBOX_CourseAllocations_Teacher.Enabled) {
                    CHKBOX_CourseAllocations_Teacher.Checked = !CHKBOX_CourseAllocations_Teacher.Checked;
                }
            } else if (name.Contains("CourseAllocations_Unit")) {
                if (CHKBOX_CourseAllocations_Unit.Enabled) {
                    CHKBOX_CourseAllocations_Unit.Checked = !CHKBOX_CourseAllocations_Unit.Checked;
                }
            }
        }
        // Navigate on enter
        private void TextBox_onKeyEnter(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Return)) {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void ToggleChecked_onKeyEnter(object sender, KeyEventArgs e) {
            // To be able to check item with keyboard navigation
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return)) {
                if (sender is RadioButton) {
                    RadioButton rad = (RadioButton)sender;
                    rad.Checked = !rad.Checked;
                } else if(sender is CheckBox) {
                    CheckBox chk = (CheckBox)sender;
                    chk.Checked = !chk.Checked;
                }
            }
        }
        private void TSM_HelpAbout_Click(object sender, EventArgs e) {
            new DialogAbout().ShowDialog();
        }
        private void TSM_FileExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void TSM_FileExportCSV_Click(object sender, EventArgs e) {
            // TODO
        }

        // To be refactored 
        private void Updating(Label label, string txt) {
            string prev = label.Text;
            label.Text = txt;
            label.Invalidate();
            label.Update();
            label.Refresh();
            Application.DoEvents();
            label.Text = prev;
        }

        private void GRPBOX_Transactions_Course_Enter(object sender, EventArgs e) {

        }
    }
}
