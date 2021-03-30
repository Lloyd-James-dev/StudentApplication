using StudentApp_Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication {

    public class ColumnProperties {

        private static Font dataHeadFont = new Font("Calibri", 14F);
        private static Font dataCellFont = new Font("Calibri", 12F);
        public static Font rowTotalsFont = new Font("Calibri", 12F, FontStyle.Bold);
        public static Color dataHeadBackColour = SystemColors.Menu;
        private static Color dataHeadSelectColour = SystemColors.Menu;
        //private static Color dataCellBackColour = SystemColors.Menu;  // Unused
        private static Color dataCellAltBackColour = Color.WhiteSmoke;
        //private static Color dataCellSelectColour = SystemColors.Menu; // Unused
        public static Color defaultColour = Color.Black;
        public static Color disabledColour = Color.DarkGray;
        public static FlatStyle disabledStyle = FlatStyle.Flat;
        public static FlatStyle enabledStyle = FlatStyle.Standard;
        public static Color coreColour = Color.DarkRed;
        public static Color positiveAmountColour = Color.Black;
        public static Color negativeAmountColour = Color.DarkRed;
        public static Color pastForeColor = Color.DarkRed;
        public static Color futureForeColor = Color.DarkGreen;
        public static Color pastSelectionBackColor = Color.FromArgb(192, 0, 0);
        public static Color futureSelectionBackColor = Color.Green;
        private static DataGridViewContentAlignment DefaultAlignment = DataGridViewContentAlignment.MiddleLeft;
        public static DataGridViewCellStyle headCellStyle = new DataGridViewCellStyle {
            Font = dataHeadFont,
            BackColor = dataHeadBackColour,
            SelectionBackColor = dataHeadSelectColour,
            Alignment = DefaultAlignment
        };
        public static DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle {
            Font = dataCellFont,
            Alignment = DefaultAlignment,
            ForeColor = Color.Black
        };
        public static DataGridViewCellStyle altCellStyle = new DataGridViewCellStyle {
            Font = dataCellFont,
            BackColor = dataCellAltBackColour
        };
        public static DataGridViewCellStyle btnCellStyle = new DataGridViewCellStyle {
            Font = dataCellFont,
            Alignment = DataGridViewContentAlignment.MiddleCenter
        };
        public static int MinimumColumnWidth = 80;

        // TextBox Columns
        public DataGridViewColumn address = new DataGridViewTextBoxColumn {
            Name = "Address",
            HeaderText = "Address",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            FillWeight = 200
        };
        public DataGridViewColumn adminEmail = new DataGridViewTextBoxColumn {
            Name = "AdminEmail",
            HeaderText = "Email",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn adminFirstName = new DataGridViewTextBoxColumn {
            Name = "AdminFirstName",
            HeaderText = "First\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn adminFullName = new DataGridViewTextBoxColumn {
            Name = "AdminFullName",
            HeaderText = "Administrator",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn adminLastName = new DataGridViewTextBoxColumn {
            Name = "AdminLastName",
            HeaderText = "Last\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn city = new DataGridViewTextBoxColumn {
            Name = "City",
            HeaderText = "City",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            Width = 150
        };
        public DataGridViewColumn collegeId = new DataGridViewTextBoxColumn {
            Name = "CollegeId",
            HeaderText = "College\u00A0Id",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn collegeName = new DataGridViewTextBoxColumn {
            Name = "CollegeName",
            HeaderText = "College",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn core = new DataGridViewTextBoxColumn {
            Name = "Core",
            HeaderText = "Core",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            Width = 80
        };
        public DataGridViewColumn courseCode = new DataGridViewTextBoxColumn {
            Name = "CourseCode",
            HeaderText = "Course\u00A0Code",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            Width = 132
        };
        public DataGridViewColumn courseName = new DataGridViewTextBoxColumn {
            Name = "CourseName",
            HeaderText = "Course",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn coursePlusCode = new DataGridViewTextBoxColumn {
            Name = "CoursePlusCode",
            HeaderText = "CoursePlusCode",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            Visible = false
        };
        public DataGridViewColumn dateEnroled = new DataGridViewTextBoxColumn {
            Name = "DateEnroled",
            HeaderText = "Enroled",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "dd/MM/yyyy"
            },
            Width = 95
        };
        public DataGridViewColumn dateGraded = new DataGridViewTextBoxColumn {
            Name = "DateGraded",
            HeaderText = "Date\u00A0Graded",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "dd/MM/yyyy"
            }
        };
        public DataGridViewColumn dateRegistered = new DataGridViewTextBoxColumn {
            Name = "DateRegistered",
            HeaderText = "Registered",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "dd/MM/yyyy"
            }
        };
        public DataGridViewColumn dob = new DataGridViewTextBoxColumn {
            Name = "Dob",
            HeaderText = "Birthdate",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "dd/MM/yyyy"
            },
            Width = 106
        };
        public DataGridViewColumn email = new DataGridViewTextBoxColumn {
            Name = "Email",
            HeaderText = "Email",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn fee = new DataGridViewTextBoxColumn {
            Name = "Fee",
            HeaderText = "Fee",
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "c"
            },
            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        };
        public DataGridViewColumn firstName = new DataGridViewTextBoxColumn {
            Name = "FirstName",
            HeaderText = "First\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn firstTermBegin = new DataGridViewTextBoxColumn {
            Name = "FirstTermBegin",
            HeaderText = "1st\u00A0Term\u00A0Begin",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "dd/MM/yyyy"
            }
        };
        public DataGridViewColumn firstTermEnd = new DataGridViewTextBoxColumn {
            Name = "FirstTermEnd",
            HeaderText = "1st\u00A0Term\u00A0End",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "dd/MM/yyyy"
            }
        };
        public DataGridViewColumn gender = new DataGridViewTextBoxColumn {
            Name = "Gender",
            HeaderText = "Gender",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn grade = new DataGridViewTextBoxColumn {
            Name = "Grade",
            HeaderText = "Grade",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn isSecondSemester = new DataGridViewTextBoxColumn {
            Name = "IsSecondSemester",
            HeaderText = "Semester",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn lastName = new DataGridViewTextBoxColumn {
            Name = "LastName",
            HeaderText = "Last\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn mobile = new DataGridViewTextBoxColumn {
            Name = "Mobile",
            HeaderText = "Mobile\u00A0No.",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn period = new DataGridViewTextBoxColumn {
            Name = "Period",
            HeaderText = "Period",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn postCode = new DataGridViewTextBoxColumn {
            Name = "Postcode",
            HeaderText = "Postcode",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn rpl = new DataGridViewTextBoxColumn {
            Name = "RPL",
            HeaderText = "RPL",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn secondTermBegin = new DataGridViewTextBoxColumn {
            Name = "SecondTermBegin",
            HeaderText = "2nd\u00A0Term\u00A0Begin",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "dd/MM/yyyy"
            }
        };
        public DataGridViewColumn secondTermEnd = new DataGridViewTextBoxColumn {
            Name = "SecondTermEnd",
            HeaderText = "2nd\u00A0Term\u00A0End",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "dd/MM/yyyy"
            }
        };
        public DataGridViewColumn semesterKey = new DataGridViewTextBoxColumn {
            Name = "SemesterKey",
            HeaderText = "SemesterKey",
            Visible = false
        };
        public DataGridViewColumn semesterName = new DataGridViewTextBoxColumn {
            Name = "SemesterName",
            HeaderText = "Semester",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            Width = 140
        };
        public DataGridViewColumn state = new DataGridViewTextBoxColumn {
            Name = "State",
            HeaderText = "State",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn studentEmail = new DataGridViewTextBoxColumn {
            Name = "StudentEmail",
            HeaderText = "Email",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn studentFirstName = new DataGridViewTextBoxColumn {
            Name = "StudentFirstName",
            HeaderText = "First\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn studentFullName = new DataGridViewTextBoxColumn {
            Name = "StudentFullName",
            HeaderText = "Student",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn studentLastName = new DataGridViewTextBoxColumn {
            Name = "StudentLastName",
            HeaderText = "Last\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn subjectId = new DataGridViewTextBoxColumn {
            Name = "SubjectId",
            HeaderText = "Subject\u00A0Id",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };
        public DataGridViewColumn subjectName = new DataGridViewTextBoxColumn {
            Name = "SubjectName",
            HeaderText = "Subject",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn teacherEmail = new DataGridViewTextBoxColumn {
            Name = "TeacherEmail",
            HeaderText = "Email",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn teacherfirstName = new DataGridViewTextBoxColumn {
            Name = "TeacherFirstName",
            HeaderText = "First\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn teacherFullName = new DataGridViewTextBoxColumn {
            Name = "TeacherFullName",
            HeaderText = "Teacher",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn teacherLastName = new DataGridViewTextBoxColumn {
            Name = "TeacherLastName",
            HeaderText = "Last\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn unitCode = new DataGridViewTextBoxColumn {
            Name = "UnitCode",
            HeaderText = "Unit\u00A0Code",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            Width = 115
        };
        public DataGridViewColumn unitDescription = new DataGridViewTextBoxColumn {
            Name = "UnitDescription",
            HeaderText = "Description",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        public DataGridViewColumn year = new DataGridViewTextBoxColumn {
            Name = "Year",
            HeaderText = "Year",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        };

        // TextBox Columns for Transactions (Not Sortable)
        public DataGridViewColumn invoiceId = new DataGridViewTextBoxColumn {
            Name = "InvoiceId",
            HeaderText = "Invoice\u00A0Id",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "D8"
            },
            SortMode = DataGridViewColumnSortMode.NotSortable
        };
        public DataGridViewColumn receiptId = new DataGridViewTextBoxColumn {
            Name = "ReceiptId",
            HeaderText = "Receipt\u00A0Id",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "D8"
            },
            SortMode = DataGridViewColumnSortMode.NotSortable
        };
        public DataGridViewColumn transactionDate = new DataGridViewTextBoxColumn {
            Name = "TransactionDate",
            HeaderText = "Date",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "dd/MM/yyyy"
            },
            Width = 90,
            SortMode = DataGridViewColumnSortMode.NotSortable
        };
        public DataGridViewColumn studentFullName_Transactions = new DataGridViewTextBoxColumn {
            Name = "StudentFullName",
            HeaderText = "Student",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            SortMode = DataGridViewColumnSortMode.NotSortable
        };
        public DataGridViewColumn studentEmail_Transactions = new DataGridViewTextBoxColumn {
            Name = "StudentEmail",
            HeaderText = "Email",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            SortMode = DataGridViewColumnSortMode.NotSortable
        };
        public DataGridViewColumn semesterName_Transactions = new DataGridViewTextBoxColumn {
            Name = "SemesterName",
            HeaderText = "Semester",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            Width = 140,
            SortMode = DataGridViewColumnSortMode.NotSortable
        };
        public DataGridViewColumn collegeName_Transactions = new DataGridViewTextBoxColumn {
            Name = "CollegeName",
            HeaderText = "College",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            SortMode = DataGridViewColumnSortMode.NotSortable
        };
        public DataGridViewColumn courseCode_Transactions = new DataGridViewTextBoxColumn {
            Name = "CourseCode",
            HeaderText = "Course\u00A0Code",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            SortMode = DataGridViewColumnSortMode.NotSortable
        };
        public DataGridViewColumn amount = new DataGridViewTextBoxColumn {
            Name = "Amount",
            HeaderText = "Amount",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "c",
                ForeColor = Color.Black
            },
            SortMode = DataGridViewColumnSortMode.NotSortable
        };
        public DataGridViewColumn comments = new DataGridViewTextBoxColumn {
            Name = "Comments",
            HeaderText = "Comments",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            SortMode = DataGridViewColumnSortMode.NotSortable
        };

        // TextBox Columns for Dialogs (Auto-Size Column Mode = ColumnHeader)
        public DataGridViewColumn studentFirstName_Dialog = new DataGridViewTextBoxColumn {
            Name = "StudentFirstName",
            HeaderText = "First\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        };
        public DataGridViewColumn studentLastName_Dialog = new DataGridViewTextBoxColumn {
            Name = "StudentLastName",
            HeaderText = "Last\u00A0Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        };
        // TextBox Columns for Dialogs (Auto-Size Column Mode = Fill)
        public DataGridViewColumn semesterName_Dialog = new DataGridViewTextBoxColumn {
            Name = "SemesterName",
            HeaderText = "Semester",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };

        // CheckBox Columns
        public DataGridViewColumn competent_CheckBox = new DataGridViewCheckBoxColumn {
            Name = "Competent",
            HeaderText = "Competent",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            SortMode = DataGridViewColumnSortMode.Automatic
        };
        public DataGridViewColumn core_CheckBox = new DataGridViewCheckBoxColumn {
            Name = "Core",
            HeaderText = "Core",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            SortMode = DataGridViewColumnSortMode.Automatic
        };
        public DataGridViewColumn rpl_CheckBox = new DataGridViewCheckBoxColumn {
            Name = "RPL",
            HeaderText = "RPL",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            SortMode = DataGridViewColumnSortMode.Automatic
        };
        public DataGridViewColumn select_CheckBox = new DataGridViewCheckBoxColumn {
            Name = "Select",
            HeaderText = "✓\u00A0Select",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            ReadOnly = false,
            SortMode = DataGridViewColumnSortMode.Automatic
        };

        // Button Columns
        public ButtonColumn addReceipt = new ButtonColumn() {
            Name = "AddReceipt",
            HeaderText = "Add\u00A0Receipt",
            Text = "Add Receipt",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn addUnits = new ButtonColumn {
            Name = "AddUnits",
            HeaderText = "Add\u00A0Units",
            Text = "Add Units",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn assignCourse = new ButtonColumn {
            Name = "AssignCourse",
            HeaderText = "Assign\u00A0Course",
            Text = "Assign Course",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn assignUnits = new ButtonColumn {
            Name = "AssignUnits",
            HeaderText = "Assign\u00A0Units",
            Text = "Assign Units",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn delete = new ButtonColumn {
            Name = "Delete",
            HeaderText = "🗑\u00A0Delete",
            Text = "Delete",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn enrol = new ButtonColumn {
            Name = "Enrol",
            HeaderText = "Enrol\u00A0in\u00A0Course",
            Text = "Enrol",
            DefaultCellStyle = btnCellStyle
        };
        public ButtonColumn grades = new ButtonColumn {
            Name = "Grades",
            HeaderText = "Student\u00A0Grades",
            Text = "Grade Units",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn history = new ButtonColumn {
            Name = "History",
            HeaderText = "Course\u00A0History",
            Text = "Course History",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn joinCollege = new ButtonColumn {
            Name = "JoinCollege",
            HeaderText = "Join\u00A0College",
            Text = "Join College",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn joinSemester = new ButtonColumn {
            Name = "JoinSemester",
            HeaderText = "Join\u00A0Semester",
            Text = "Join Semester",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn linkSubjects = new ButtonColumn {
            Name = "LinkSubjects",
            HeaderText = "Link\u00A0Subjects",
            Text = "Link Subjects",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn register = new ButtonColumn {
            Name = "Register",
            HeaderText = "Register\u00A0Student",
            Text = "Register Student",
            DefaultCellStyle = btnCellStyle,
        };
        public ButtonColumn update = new ButtonColumn {
            Name = "Update",
            HeaderText = "🖊\u00A0Update/Edit",
            Text = "Edit Entry",
            DefaultCellStyle = btnCellStyle,
        };

        // ComboBox Columns
        public ComboBoxColumn subject = new ComboBoxColumn() {
            //ComboData = new MainDAL().ViewSubjectAssignments(semesterKey, collegeId, courseCode, 0, ""),    // code is inline
            Name = "Subject",
            HeaderText = "Subject",
            Key = "SubjectName",
            KeyValue = "SubjectId",
            DataPropertyName = "SubjectId",
            ValueType = typeof(int),
            Width = 200,
            DisplayIndex = 6, // includes hidden columns
            //MinimumWidth = 200,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            SortMode = DataGridViewColumnSortMode.Automatic
        };
        public ComboBoxColumn teacher = new ComboBoxColumn() {
            ComboData = new MainDAL().ComboViewAllTeachers(),
            Name = "TeacherName",
            HeaderText = "Teacher",
            Key = "TeacherName",
            KeyValue = "TeacherEmail",
            DataPropertyName = "TeacherEmail",
            ValueType = typeof(string),
            Width = 200,
            DisplayIndex = 7, // includes hidden columns
            //MinimumWidth = 200,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            SortMode = DataGridViewColumnSortMode.Automatic
        };

        // Hidden Columns
        public DataGridViewColumn collegeId_Hidden = new DataGridViewColumn {
            Name = "CollegeId",
            Visible = false
        };
        public DataGridViewColumn courseCode_Hidden = new DataGridViewColumn {
            Name = "CourseCode",
            Visible = false
        };
        public DataGridViewColumn firstTermBegin_Hidden = new DataGridViewTextBoxColumn {
            Name = "FirstTermBegin",
            Visible = false
        };
        public DataGridViewColumn firstTermEnd_Hidden = new DataGridViewTextBoxColumn {
            Name = "FirstTermEnd",
            Visible = false
        };
        public DataGridViewColumn isSecondSemester_Hidden = new DataGridViewColumn {
            Name = "IsSecondSemester",
            Visible = false
        };
        public DataGridViewColumn secondTermBegin_Hidden = new DataGridViewTextBoxColumn {
            Name = "SecondTermBegin",
            Visible = false
        };
        public DataGridViewColumn secondTermEnd_Hidden = new DataGridViewTextBoxColumn {
            Name = "SecondTermEnd",
            Visible = false
        };
        public DataGridViewColumn select_Hidden = new DataGridViewColumn {
            Name = "Select",
            Visible = false
        };
        public DataGridViewColumn semesterName_Hidden = new DataGridViewColumn {
            Name = "SemesterName",
            Visible = false
        };
        public DataGridViewColumn studentEmail_Hidden = new DataGridViewColumn {
            Name = "StudentEmail",
            Visible = false
        };
        public DataGridViewColumn subjectId_Hidden = new DataGridViewColumn {
            Name = "SubjectId",
            Visible = false
        };
        public DataGridViewColumn subjectName_Hidden = new DataGridViewColumn {
            Name = "SubjectName",
            Visible = false
        };
        public DataGridViewColumn teacherEmail_Hidden = new DataGridViewColumn {
            Name = "TeacherEmail",
            Visible = false
        };
        public DataGridViewColumn teacherFullName_Hidden = new DataGridViewColumn {
            Name = "TeacherFullName",
            Visible = false
        };
        public DataGridViewColumn year_Hidden = new DataGridViewColumn {
            Name = "Year",
            Visible = false
        };
    }
}