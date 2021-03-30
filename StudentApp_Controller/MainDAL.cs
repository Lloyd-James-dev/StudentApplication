using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using StudentApp_Model;

namespace StudentApp_Controller {
    public class MainDAL : IMainDAL {

        /* use the command below as the first line inside using(var context = ...) statement to log EF SQL
           context.Database.Log = Console.WriteLine;
           example found in SearchStudentFields(string x)
        */
        // Display Data
        // Entities
        public DataTable SearchStudentFields(string x) {
            using (var context = new StudentAppContext()) {
                //context.Database.Log = Console.WriteLine;
                return BuildDataTable(context.Students
                    .Where(o => 
                        o.User.Email.Contains(x) || 
                        o.User.FirstName.Contains(x) ||
                        o.User.LastName.Contains(x) ||
                        o.User.Address.Contains(x) ||
                        o.User.City.Contains(x) ||
                        o.User.State.Contains(x) ||
                        o.User.Postcode.Contains(x) ||
                        o.User.Dob.ToString().Contains(x) ||
                        o.User.Gender.Contains(x) ||
                        o.User.Mobile.Contains(x)
                    )
                    .Select(o => new {
                        o.User.FirstName,
                        o.User.LastName,
                        o.User.Email,
                        o.User.Address,
                        o.User.City,
                        o.User.State,
                        o.User.Postcode,
                        o.User.Dob,
                        o.User.Gender,
                        o.User.Mobile,
                        //Pass = o.User.Pass
                    })
                    .OrderBy(o => o.LastName)
                    .ThenBy(o => o.FirstName)
                    .ToList()
                );
            }
        }
        public DataTable SearchTeacherFields(string x) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Teachers
                    .Where(o =>
                        o.User.Email.Contains(x) ||
                        o.User.FirstName.Contains(x) ||
                        o.User.LastName.Contains(x) ||
                        o.User.Address.Contains(x) ||
                        o.User.City.Contains(x) ||
                        o.User.State.Contains(x) ||
                        o.User.Postcode.Contains(x) ||
                        o.User.Dob.ToString().Contains(x) ||
                        o.User.Gender.Contains(x) ||
                        o.User.Mobile.Contains(x)
                    )
                    .Select(o => new {
                        o.User.FirstName,
                        o.User.LastName,
                        o.User.Email,
                        o.User.Address,
                        o.User.City,
                        o.User.State,
                        o.User.Postcode,
                        o.User.Dob,
                        o.User.Gender,
                        o.User.Mobile,
                        //Pass = o.User.Pass
                    })
                    .OrderBy(o => o.LastName)
                    .ThenBy(o => o.FirstName)
                    .ToList()
                );
            }
        }
        public DataTable SearchAdminFields(string x) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Admins
                    .Where(o =>
                        o.User.Email.Contains(x) ||
                        o.User.FirstName.Contains(x) ||
                        o.User.LastName.Contains(x) ||
                        o.User.Address.Contains(x) ||
                        o.User.City.Contains(x) ||
                        o.User.State.Contains(x) ||
                        o.User.Postcode.Contains(x) ||
                        o.User.Dob.ToString().Contains(x) ||
                        o.User.Gender.Contains(x) ||
                        o.User.Mobile.Contains(x)
                    )
                    .Select(o => new {
                        o.User.FirstName,
                        o.User.LastName,
                        o.User.Email,
                        o.User.Address,
                        o.User.City,
                        o.User.State,
                        o.User.Postcode,
                        o.User.Dob,
                        o.User.Gender,
                        o.User.Mobile,
                        //Pass = o.User.Pass
                    })
                    .ToList()
                );
            }
        }
        public DataTable SearchSemesterFields(string x) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Semesters
                    .Select(o => new {
                        o.Year.Year,
                        IsSecondSemester = (o.SecondSemester ? 2 : 1).ToString(),
                        o.FirstTermBegin,
                        o.FirstTermEnd,
                        o.SecondTermBegin,
                        o.SecondTermEnd,
                        SemesterKey = o.Year.Year.ToString() + (o.SecondSemester ? 2 : 1).ToString(),
                        SemesterName = o.Year.Year.ToString() + " - " + "Semester " + (o.SecondSemester ? 2 : 1).ToString()
                    })
                    .Where(o => o.Year.ToString().Contains(x) ||
                        o.IsSecondSemester.ToString() .Contains(x)||
                        o.FirstTermBegin.ToString().Contains(x) ||
                        o.FirstTermEnd.ToString().Contains(x) ||
                        o.SecondTermBegin.ToString().Contains(x) ||
                        o.SecondTermEnd.ToString().Contains(x)
                    ).ToList()
                );
            }
        }
        public DataTable SearchCollegeFields(string x) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Colleges
                    .Where(o =>
                        o.Id.ToString().Contains(x) ||
                        o.Name.Contains(x) ||
                        o.Address.Contains(x) ||
                        o.City.Contains(x) ||
                        o.State.Contains(x) ||
                        o.Postcode.Contains(x)
                    )
                    .Select(o => new {
                        CollegeId = o.Id,
                        CollegeName = o.Name,
                        o.Address,
                        o.City,
                        o.State,
                        o.Postcode
                    })
                    .ToList()
                );
            }
        }
        public DataTable SearchCourseFields(string x) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Courses
                    .Where(o => o.CourseCode.Contains(x) || o.Name.Contains(x) || o.Fee.ToString().Contains(x))
                    .Select(o => new {
                        o.CourseCode,
                        CourseName = o.Name,
                        o.Fee
                    })
                    .ToList()
                );
            }
        }
        public DataTable SearchSubjectFields(string x) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Subjects
                    .Where(o => o.Id.ToString().Contains(x) || o.Name.Contains(x))
                    .Select(o => new {
                        SubjectId = o.Id,
                        SubjectName = o.Name
                    })
                    .ToList()
                );
            }
        }
        public DataTable SearchUnitFields(string x) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Units
                    .Where(o => o.UnitCode.Contains(x) || o.Description.Contains(x))
                    .Select(o => new {
                        o.UnitCode,
                        UnitDescription = o.Description
                    })
                    .ToList()
                );
            }
        }
        // Course Unit
        public DataTable ViewCourseUnit() {
            return ViewCourseUnit("", "");
        }
        public DataTable ViewCourseUnit(string courseCode, string unit) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.UnitInCourses
                    .Select(o => new {
                        CourseCode = o.CourseCode,
                        CourseName = o.Course.Name,
                        CoursePlusCode = o.CourseCode + " - " + o.Course.Name,
                        UnitCode = o.Unit.UnitCode,
                        Unit = o.Unit.Description,
                        Core = (o.Core ? "Core" : "Elective").ToString()
                    })
                    .Where(o => courseCode =="" ? o.Equals(o) : o.CourseCode.Contains(courseCode))
                    .Where(o => unit=="" ? o.Equals(o) : o.UnitCode.Contains(unit.Trim()) || o.Unit.Contains(unit.Trim()) || o.Core.Contains(unit.Trim()))
                    .OrderByDescending(o => o.CourseCode)
                    .ThenBy(o => o.Core)
                    .ThenBy(o => o.UnitCode)
                    .ToList()
                );
            }
        }
        // Course Assignments
        public DataTable ViewCollegeAssignments() {
            return ViewCollegeAssignments(0, 0);
        }
        public DataTable ViewCollegeAssignments(int semesterKey, int college) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.SemesterAtColleges
                    .Select(o => new {
                        // Semester columns
                        Year = o.Year,
                        IsSecondSemester = o.SecondSemester,
                        SemesterKey = o.Year.Year * 10 + (o.SecondSemester ? 2 : 1),
                        SemesterName = o.Year.Year.ToString() + " - " + "Semester " + (o.SecondSemester ? 2 : 1).ToString(),
                        // College columns
                        CollegeId = o.CollegeId,
                        CollegeName = o.College.Name
                    })
                    .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                    .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                    .OrderBy(o => o.SemesterName)
                    .ThenBy(o => o.CollegeName)
                    .ToList()
                );
            }
        }
        public DataTable ViewCourseAssignments() {
            return ViewCourseAssignments(0, 0, "");
        }
        public DataTable ViewCourseAssignments(int semesterKey, int college, string course) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.CourseAtSemesterAtColleges
                    .Select(o => new {
                        // Semester columns
                        Year = o.Year,
                        IsSecondSemester = o.SecondSemester,
                        SemesterKey = o.Year.Year * 10 + (o.SecondSemester ? 2 : 1),
                        SemesterName = o.Year.Year.ToString() + " - " + "Semester " + (o.SecondSemester ? 2 : 1).ToString(),
                        // College columns
                        CollegeId = o.CollegeId,
                        CollegeName = o.SemesterAtCollege.College.Name,
                        // Course columns
                        CourseCode = o.CourseCode,
                        CourseName = o.Course.Name,
                        CoursePlusCode = o.CourseCode + " - " + o.Course.Name
                    })
                    .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                    .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                    .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                    .OrderBy(o => o.SemesterName)
                    .ThenBy(o => o.CollegeName)
                    .ThenByDescending(o => o.CourseCode)
                    .ToList()
                );
            }
        }
        public DataTable ViewSubjectAssignments() {
            return ViewSubjectAssignments(0, 0, "", 0, "");
        }
        public DataTable ViewSubjectAssignments(int semesterKey, int college, string course, int subject, string teacher) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.SubjectInCourseAtSemesterAtColleges
                    .Select(o => new {
                        // Semester columns
                        Year = o.Year,
                        IsSecondSemester = o.SecondSemester,
                        SemesterKey = o.Year.Year * 10 + (o.SecondSemester ? 2 : 1),
                        SemesterName = o.Year.Year.ToString() + " - " + "Semester " + (o.SecondSemester ? 2 : 1).ToString(),
                        // College columns
                        CollegeId = o.CollegeId,
                        CollegeName = o.CourseAtSemesterAtCollege.SemesterAtCollege.College.Name,
                        // Course columns
                        CourseCode = o.CourseAtSemesterAtCollege.CourseCode,
                        CourseName = o.CourseAtSemesterAtCollege.Course.Name,
                        CoursePlusCode = o.CourseAtSemesterAtCollege.CourseCode + " - " + o.CourseAtSemesterAtCollege.Course.Name,
                        // Subject columns
                        SubjectId = o.SubjectId,
                        SubjectName = o.Subject.Name,
                        // Teacher colunms
                        //Teacher = o.Teacher.User.FirstName + " " + o.Teacher.User.LastName,
                        TeacherFullName = o.Teacher.User.LastName + ", " + o.Teacher.User.FirstName,
                        TeacherEmail = o.TeacherEmail
                    })
                    .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                    .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                    .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                    .Where(o => subject.Equals(0) ? o.Equals(o) : o.SubjectId.Equals(subject))
                    .Where(o => teacher.Equals("") ? o.Equals(o) : o.TeacherEmail.Equals(teacher))
                    .OrderBy(o => o.SemesterName)
                    .ThenBy(o => o.CollegeName)
                    .ThenByDescending(o => o.CourseCode)
                    .ThenBy(o => o.TeacherFullName)
                    .ThenBy(o => o.SubjectName)
                    .ToList()
                );
            }
        }
        public DataTable ViewUnitAssignments() {
            return ViewUnitAssignments(0, 0, "", 0, "", "");
        }
        public DataTable ViewUnitAssignments(int semesterKey, int college, string course, int subject, string teacher, string unit) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.UnitInSubjectInCourseAtSemesterAtColleges
                    .Join(context.UnitInCourses,
                        u => new { u.UnitCode, u.CourseCode },
                        c => new { c.UnitCode, c.CourseCode },
                        (u, c) => new {
                            // Semester columns
                            Year = u.Year,
                            IsSecondSemester = u.SecondSemester,
                            SemesterKey = u.Year.Year * 10 + (u.SecondSemester ? 2 : 1),
                            SemesterName = u.Year.Year.ToString() + " - " + "Semester " + (u.SecondSemester ? 2 : 1).ToString(),
                            // College columns
                            CollegeId = u.CollegeId,
                            CollegeName = u.SubjectInCourseAtSemesterAtCollege.CourseAtSemesterAtCollege.SemesterAtCollege.College.Name,
                            // Course columns
                            CourseCode = u.SubjectInCourseAtSemesterAtCollege.CourseAtSemesterAtCollege.CourseCode,
                            CourseName = u.SubjectInCourseAtSemesterAtCollege.CourseAtSemesterAtCollege.Course.Name,
                            CoursePlusCode = u.SubjectInCourseAtSemesterAtCollege.CourseAtSemesterAtCollege.CourseCode + " - " + u.SubjectInCourseAtSemesterAtCollege.CourseAtSemesterAtCollege.Course.Name,
                            // Subject columns
                            SubjectId = u.SubjectId,
                            SubjectName = u.SubjectInCourseAtSemesterAtCollege.Subject.Name,
                            // Teacher colunms
                            //Teacher = u.SubjectInCourseAtSemesterAtCollege.Teacher.User.FirstName + " " + u.SubjectInCourseAtSemesterAtCollege.Teacher.User.LastName,
                            TeacherFullName = u.SubjectInCourseAtSemesterAtCollege.Teacher.User.LastName + ", " + u.SubjectInCourseAtSemesterAtCollege.Teacher.User.FirstName,
                            TeacherEmail = u.SubjectInCourseAtSemesterAtCollege.TeacherEmail,
                            // Unit columns
                            UnitCode = c.Unit.UnitCode,
                            UnitDescription = c.Unit.Description,
                            Core = c.Core ? "Core" : "Elective"
                    })
                    .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                    .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                    .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                    .Where(o => subject.Equals(0) ? o.Equals(o) : o.SubjectId.Equals(subject))
                    .Where(o => teacher.Equals("") ? o.Equals(o) : o.TeacherEmail.Equals(teacher))
                    .Where(o => unit.Equals("") ? o.Equals(o) : o.UnitCode.Contains(unit.Trim()) || o.UnitDescription.Contains(unit.Trim()) || o.Core.Contains(unit.Trim()))
                    .OrderBy(o => o.SemesterName)
                    .ThenBy(o => o.CollegeName)
                    .ThenByDescending(o => o.CourseCode)
                    .ThenBy(o => o.TeacherFullName)
                    .ThenBy(o => o.SubjectName)
                    .ThenBy(o => o.Core)
                    .ThenBy(o => o.UnitCode)
                    .ToList()
                );
            }
        }
        // Student Registrations
        public DataTable ViewStudentRegistrations() {
            return ViewStudentRegistrations(0, 0, "");
        }
        public DataTable ViewStudentRegistrations(int semesterKey, int college, string student) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.RegisterStudentInSemesterAtColleges
                    .Select(r => new {
                        // Semester/College columns
                        Year = r.Year,
                        IsSecondSemester = r.SecondSemester,
                        SemesterName = r.Year.Year.ToString() + " - " + "Semester " + (r.SecondSemester ? 2 : 1).ToString(),
                        SemesterKey = r.Year.Year * 10 + (r.SecondSemester ? 2 : 1),
                        CollegeId = r.CollegeId,
                        CollegeName = r.SemesterAtCollege.College.Name,
                        // Student columns
                        DateRegistered = r.RegistrationDate,
                        StudentFullName = r.Student.User.LastName.ToUpper() + ", " + r.Student.User.FirstName,
                        StudentEmail = r.StudentEmail
                    })
                    .Where(o => student.Equals("") ? o.Equals(o) : o.StudentEmail.Equals(student))
                    .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                    .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                    .OrderBy(o => o.DateRegistered)
                    .ThenBy(o => o.StudentFullName)
                    .ThenBy(o => o.CollegeName)
                    .ThenBy(o => o.SemesterName)
                    .ToList()
                );
            }
        }
        public DataTable ViewStudentEnrolments() {
            return ViewStudentEnrolments(0, 0, "", "");
        }
        public DataTable ViewStudentEnrolments(int semesterKey, int college, string student, string course) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.RegisteredStudentEnrolInCourseAtSemesterAtColleges
                    .Select(r => new {
                        // Semester/College columns
                        Year = r.StudentYear,
                        IsSecondSemester = r.StudentSecondSemester,
                        SemesterName = r.StudentYear.Year.ToString() + " - " + "Semester " + (r.StudentSecondSemester ? 2 : 1).ToString(),
                        SemesterKey = r.StudentYear.Year * 10 + (r.StudentSecondSemester ? 2 : 1),
                        CollegeId = r.StudentCollegeId,
                        CollegeName = r.RegisterStudentInSemesterAtCollege.SemesterAtCollege.College.Name,
                        // Student columns
                        DateRegistered = r.RegisterStudentInSemesterAtCollege.RegistrationDate,
                        StudentFullName = r.RegisterStudentInSemesterAtCollege.Student.User.LastName.ToUpper() + ", " +
                                r.RegisterStudentInSemesterAtCollege.Student.User.FirstName,
                        //StudentFirstName = r.RegisterStudentInSemesterAtCollege.Student.User.FirstName,
                        //StudentLastName = r.RegisterStudentInSemesterAtCollege.Student.User.LastName,
                        StudentEmail = r.StudentEmail,
                        // Enrolment columns
                        DateEnroled = r.EnrolmentDate,
                        CourseCode = r.CourseCode,
                        CourseName = r.CourseAtSemesterAtCollege.Course.Name,
                        CoursePlusCode = r.CourseAtSemesterAtCollege.CourseCode + " - " + r.CourseAtSemesterAtCollege.Course.Name
                    })
                    .Where(o => student.Equals("") ? o.Equals(o) : o.StudentEmail.Equals(student))
                    .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                    .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                    .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                    .OrderBy(o => o.DateEnroled)
                    .ThenBy(o => o.StudentFullName)
                    .ThenBy(o => o.CollegeName)
                    .ThenBy(o => o.SemesterName)
                    //.ThenBy(o => o.DateEnroled)
                    .ToList()
                );
            }
        }
        public DataTable ViewStudentGrades() {
            return ViewStudentGrades(0, 0, "", "", "");
        }
        public DataTable ViewStudentGrades(int semesterKey, int college, string student, string course, string unit) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.RegisteredStudentEnrolInCourseAtSemesterAtColleges
                    .Join(context.StudentUnitGrades,
                        r => new { r.StudentEmail, r.StudentYear, r.StudentSecondSemester, r.StudentCollegeId },
                        s => new { s.StudentEmail, StudentYear = s.Year, StudentSecondSemester = s.SecondSemester, StudentCollegeId = s.CollegeId },
                        (r, s) => new {
                            // Semester/College columns
                            Year = r.StudentYear,
                            IsSecondSemester = r.StudentSecondSemester,
                            SemesterName = r.StudentYear.Year.ToString() + " - " + "Semester " + (r.StudentSecondSemester ? 2 : 1).ToString(),
                            SemesterKey = r.StudentYear.Year * 10 + (r.StudentSecondSemester ? 2 : 1),
                            CollegeId = r.StudentCollegeId,
                            CollegeName = r.RegisterStudentInSemesterAtCollege.SemesterAtCollege.College.Name,
                            // Student columns
                            DateRegistered = r.RegisterStudentInSemesterAtCollege.RegistrationDate,
                            StudentFullName = r.RegisterStudentInSemesterAtCollege.Student.User.LastName.ToUpper() + ", " +
                                   r.RegisterStudentInSemesterAtCollege.Student.User.FirstName,
                            //StudentFirstName = r.RegisterStudentInSemesterAtCollege.Student.User.FirstName,
                            //StudentLastName = r.RegisterStudentInSemesterAtCollege.Student.User.LastName,
                            StudentEmail = r.StudentEmail,
                            // Enrolment columns
                            DateEnroled = r.EnrolmentDate,
                            CourseCode = r.CourseCode,
                            CourseName = r.CourseAtSemesterAtCollege.Course.Name,
                            CoursePlusCode = r.CourseAtSemesterAtCollege.CourseCode + " - " + r.CourseAtSemesterAtCollege.Course.Name,
                            // Unit Grades
                            UnitCode = s.UnitCode,
                            UnitDescription = s.UnitInSubjectInCourseAtSemesterAtCollege.Unit.Description,
                            TeacherFullName = s.UnitInSubjectInCourseAtSemesterAtCollege.SubjectInCourseAtSemesterAtCollege.Teacher.User.LastName + ", " +
                                      s.UnitInSubjectInCourseAtSemesterAtCollege.SubjectInCourseAtSemesterAtCollege.Teacher.User.FirstName,
                            Grade = s.Grade ? "Pass" : "Fail",
                            RPL = s.RPL ? "RPL" : "―",
                            DateGraded = s.DateGraded
                    })
                    .Where(o => student.Equals("") ? o.Equals(o) : o.StudentEmail.Equals(student))
                    .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                    .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                    .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                    .Where(o => unit.Equals("") ? o.Equals(o) : o.UnitCode.Contains(unit.Trim()) || o.UnitDescription.Contains(unit.Trim()) || o.Grade.Contains(unit.Trim()))
                    .OrderBy(o => o.StudentFullName)
                    .ThenBy(o => o.DateEnroled)
                    .ThenBy(o => o.CourseCode)
                    .ToList()
                );
            }
        }
        // Transactions (Invoices and Receipts)
        public DataTable SearchInvoiceFields(int resultType, string student, int semesterKey, int college, string course) {
            using (var context = new StudentAppContext()) {

                var getTotals = context.Invoices
                        .Select(o => new {
                            InvoiceId = o.Id.ToString(),
                            ReceiptId = "",
                            Date = "",
                            Name = o.RegisteredStudentEnrolInCourseAtSemesterAtCollege.RegisterStudentInSemesterAtCollege.Student.User.LastName.ToUpper() + ", " +
                               o.RegisteredStudentEnrolInCourseAtSemesterAtCollege.RegisterStudentInSemesterAtCollege.Student.User.FirstName,
                            StudentEmail = o.StudentEmail,
                            Semester = o.StudentYear.Year.ToString() + " - " + "Semester " + (o.StudentSecondSemester ? 2 : 1).ToString(),
                            SemesterKey = o.StudentYear.Year * 10 + (o.StudentSecondSemester ? 2 : 1),
                            College = o.RegisteredStudentEnrolInCourseAtSemesterAtCollege.RegisterStudentInSemesterAtCollege.SemesterAtCollege.College.Name,
                            CollegeId = o.StudentCollegeId,
                            CourseCode = o.CourseCode,
                            CoursePlusCode = o.CourseCode + " - " + o.RegisteredStudentEnrolInCourseAtSemesterAtCollege.CourseAtSemesterAtCollege.Course.Name,
                            Amount = o.Amount,
                            Comments = o.Misc
                        })
                    .Union(context.Receipts
                        .Select(r => new {
                            InvoiceId = "",
                            ReceiptId = r.Id.ToString(),
                            Date = "",
                            Name = r.Invoice.Student.User.LastName.ToUpper() + ", " + r.Invoice.Student.User.FirstName,
                            StudentEmail = r.Invoice.StudentEmail,
                            Semester = r.Invoice.StudentYear.Year.ToString() + " - " + "Semester " + (r.Invoice.StudentSecondSemester ? 2 : 1).ToString(),
                            SemesterKey = r.Invoice.StudentYear.Year * 10 + (r.Invoice.StudentSecondSemester ? 2 : 1),
                            College = r.Invoice.RegisteredStudentEnrolInCourseAtSemesterAtCollege.RegisterStudentInSemesterAtCollege.SemesterAtCollege.College.Name,
                            CollegeId = r.Invoice.StudentCollegeId,
                            CourseCode = r.Invoice.CourseCode,
                            CoursePlusCode = r.Invoice.CourseCode + " - " + r.Invoice.RegisteredStudentEnrolInCourseAtSemesterAtCollege.CourseAtSemesterAtCollege.Course.Name,
                            Amount = r.Amount,
                            Comments = r.Misc
                        })
                    );
                var sumAmount = getTotals.AsEnumerable()
                        .Where(o => !resultType.Equals(2) ? o.Equals(o) : o.InvoiceId.Equals(""))
                        .Where(o => !resultType.Equals(1) ? o.Equals(o) : o.ReceiptId.Equals(""))
                        .Where(o => student.Equals("") ? o.Equals(o) : o.StudentEmail.Equals(student))
                        .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                        .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                        .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                        .Select(o => new {
                            Amount = o.Amount
                        }).Sum(o => o.Amount);

                var invoiceCount = getTotals.AsEnumerable()
                        .Where(o => !resultType.Equals(2) ? o.Equals(o) : o.InvoiceId.Equals(""))
                        .Where(o => !resultType.Equals(1) ? o.Equals(o) : o.ReceiptId.Equals(""))
                        .Where(o => student.Equals("") ? o.Equals(o) : o.StudentEmail.Equals(student))
                        .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                        .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                        .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                    .Select(o => new {
                        InvoiceId = o.InvoiceId != ""
                    }).Count(c => c.InvoiceId).ToString();

                var receiptCount = getTotals.AsEnumerable()
                        .Where(o => !resultType.Equals(2) ? o.Equals(o) : o.InvoiceId.Equals(""))
                        .Where(o => !resultType.Equals(1) ? o.Equals(o) : o.ReceiptId.Equals(""))
                        .Where(o => student.Equals("") ? o.Equals(o) : o.StudentEmail.Equals(student))
                        .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                        .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                        .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                    .Select(o => new {
                        ReceiptId = o.ReceiptId != ""
                    }).Count(c => c.ReceiptId).ToString();

                var query = from record in getTotals
                            group record by new {
                                record.Date
                            } into g
                            select new {
                                InvoiceId = "Invoices: " + invoiceCount,
                                ReceiptId = "Receipts: " + receiptCount,
                                TransactionDate = "",
                                StudentFullName = "",
                                StudentEmail = "",
                                SemesterName = "",
                                SemesterKey = 0,
                                CollegeName = "",
                                CollegeId = 0,
                                CourseCode = "Balance",
                                CoursePlusCode = "",
                                Amount = sumAmount,
                                Comments = ""
                            };

                return BuildDataTable(context.Invoices
                    .Select(o => new {
                        InvoiceId = (int?)o.Id,
                        ReceiptId = (int?)null,
                        TransactionDate = o.InvoiceDate.Year.ToString() + (o.InvoiceDate.Month < 10 ? "/0" : "/") + o.InvoiceDate.Month.ToString() + (o.InvoiceDate.Day < 10 ? "/0" : "/") + o.InvoiceDate.Day.ToString(),
                        StudentFullName = o.RegisteredStudentEnrolInCourseAtSemesterAtCollege.RegisterStudentInSemesterAtCollege.Student.User.LastName.ToUpper() + ", " +
                               o.RegisteredStudentEnrolInCourseAtSemesterAtCollege.RegisterStudentInSemesterAtCollege.Student.User.FirstName,
                        StudentEmail = o.StudentEmail,
                        SemesterName = o.StudentYear.Year.ToString() + " - " + "Semester " + (o.StudentSecondSemester ? 2 : 1).ToString(),
                        SemesterKey = o.StudentYear.Year * 10 + (o.StudentSecondSemester ? 2 : 1),
                        CollegeName = o.RegisteredStudentEnrolInCourseAtSemesterAtCollege.RegisterStudentInSemesterAtCollege.SemesterAtCollege.College.Name,
                        CollegeId = o.StudentCollegeId,
                        CourseCode = o.CourseCode,
                        CoursePlusCode = o.CourseCode + " - " + o.RegisteredStudentEnrolInCourseAtSemesterAtCollege.CourseAtSemesterAtCollege.Course.Name,
                        Amount = o.Amount,
                        Comments = o.Misc
                    })
                    .Union(context.Receipts
                        .Select(r => new {
                            InvoiceId = (int?)null,
                            ReceiptId = (int?)r.Id,
                            TransactionDate = r.ReceiptDate.Year.ToString() + (r.ReceiptDate.Month < 10 ? "/0" : "/") + r.ReceiptDate.Month.ToString() + (r.ReceiptDate.Day < 10 ? "/0" : "/") + r.ReceiptDate.Day.ToString(),
                            StudentFullName = r.Invoice.Student.User.LastName.ToUpper() + ", " + r.Invoice.Student.User.FirstName,
                            StudentEmail = r.Invoice.StudentEmail,
                            SemesterName = r.Invoice.StudentYear.Year.ToString() + " - " + "Semester " + (r.Invoice.StudentSecondSemester ? 2 : 1).ToString(),
                            SemesterKey = r.Invoice.StudentYear.Year * 10 + (r.Invoice.StudentSecondSemester ? 2 : 1),
                            CollegeName = r.Invoice.RegisteredStudentEnrolInCourseAtSemesterAtCollege.RegisterStudentInSemesterAtCollege.SemesterAtCollege.College.Name,
                            CollegeId = r.Invoice.StudentCollegeId,
                            CourseCode = r.Invoice.CourseCode,
                            CoursePlusCode = r.Invoice.CourseCode + " - " + r.Invoice.RegisteredStudentEnrolInCourseAtSemesterAtCollege.CourseAtSemesterAtCollege.Course.Name,
                            Amount = r.Amount,
                            Comments = r.Misc
                        })
                    )
                    .OrderBy(o => o.TransactionDate)
                    .ThenBy(o => o.ReceiptId)
                    .ThenBy(o => o.InvoiceId)
                    .Select(o => new {
                        InvoiceId = o.InvoiceId.ToString(), // Need to sort before converting to string
                        ReceiptId = o.ReceiptId.ToString(),
                        o.TransactionDate,
                        o.StudentFullName,
                        o.StudentEmail,
                        o.SemesterName,
                        o.SemesterKey,
                        o.CollegeName,
                        o.CollegeId,
                        o.CourseCode,
                        o.CoursePlusCode,
                        o.Amount,
                        o.Comments,
                    })
                        .Where(o => !resultType.Equals(2) ? o.Equals(o) : o.InvoiceId.Equals(""))
                        .Where(o => !resultType.Equals(1) ? o.Equals(o) : o.ReceiptId.Equals(""))
                        .Where(o => student.Equals("") ? o.Equals(o) : o.StudentEmail.Equals(student))
                        .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                        .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                        .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                    .ToList()
                    .Union(query)
                );
            }
        }

        // Entity Inserts
        public bool AddUser(object user) {
            using (var context = new StudentAppContext()) {
                if (user.GetType().Equals(typeof(Student))) {
                    context.Students.Add((Student)user);
                }
                if (user.GetType().Equals(typeof(Teacher))) {
                    context.Teachers.Add((Teacher)user);
                }
                if (user.GetType().Equals(typeof(Admin))) {
                    context.Admins.Add((Admin)user);
                }
                try {
                    context.SaveChanges();
                    return true;
                }
                catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe email address supplied is already in our database.\nThis entry has not been added.", "Error adding student!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Insert failed due to unknown error.\nThis entry has not been added.", "Error adding student!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                } 
            }
        }
        public bool AddSemester(Semester semester) {
            using (var context = new StudentAppContext()) {
                context.Semesters.Add(semester);
                try {
                    context.SaveChanges();
                    return true;
                } catch(DbUpdateException e) {
                    if(e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe semester supplied is already in our database.\nThis entry has not been added.", "Error adding semester!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Insert failed due to unknown error.\nThis entry has not been added.", "Error adding semester!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public bool AddCollege(College college) {
            using (var context = new StudentAppContext()) {
                context.Colleges.Add(college);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe college supplied is already in our database.\nThis entry has not been added.", "Error adding college!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Insert failed due to unknown error.\nThis entry has not been added.", "Error adding college!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public bool AddCourse(Course course) {
            using (var context = new StudentAppContext()) {
                context.Courses.Add(course);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe course supplied is already in our database.\nThis entry has not been added.", "Error adding course!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Insert failed due to unknown error.\nThis entry has not been added.", "Error adding course!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public bool AddSubject(Subject subject) {
            using (var context = new StudentAppContext()) {
                context.Subjects.Add(subject);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe subject supplied is already in our database.\nThis entry has not been added.", "Error adding subject!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Insert failed due to unknown error.\nThis entry has not been added.", "Error adding subject!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public bool AddUnit(Unit unit) {
            using (var context = new StudentAppContext()) {
                context.Units.Add(unit);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe unit supplied is already in our database.\nThis entry has not been added.", "Error adding unit!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Insert failed due to unknown error.\nThis entry has not been added.", "Error adding unit!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public bool AddInvoice(Invoice invoice) {
            using (var context = new StudentAppContext()) {
                context.Invoices.Add(invoice);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe invoice supplied is already in our database.\nThis entry has not been added.", "Error adding invoice!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Insert failed due to unknown error.\nThis entry has not been added.", "Error adding invoice!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public bool AddReceipt(Receipt receipt) {
            using (var context = new StudentAppContext()) {
                context.Receipts.Add(receipt);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe receipt supplied is already in our database.\nThis entry has not been added.", "Error adding receipt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Insert failed due to unknown error.\nThis entry has not been added.", "Error adding receipt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        // Entity Updates
        public bool UpdateUser(User user) {
            using (var context = new StudentAppContext()) {
                var result = context.Users
                    .FirstOrDefault(o => o.Email == user.Email);
                if (result != null) {
                    result.FirstName = user.FirstName;
                    result.LastName = user.LastName;
                    result.Address = user.Address;
                    result.City = user.City;
                    result.State = user.State;
                    result.Postcode = user.Postcode;
                    result.Dob = user.Dob;
                    result.Gender = user.Gender;
                    result.Mobile = user.Mobile;
                    result.Pass = user.Pass;
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been updated.", "Error updating student!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }
        public bool UpdateSemester(Semester semester) {
            using (var context = new StudentAppContext()) {
                var result = context.Semesters
                    .FirstOrDefault(o => o.Year == semester.Year && o.SecondSemester == semester.SecondSemester);
                if (result != null) {
                    result.FirstTermBegin = semester.FirstTermBegin;
                    result.FirstTermEnd = semester.FirstTermEnd;
                    result.SecondTermBegin = semester.SecondTermBegin;
                    result.SecondTermEnd = semester.SecondTermEnd;
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been updated.", "Error updating semester!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }
        public bool UpdateCollege(College college) {
            using (var context = new StudentAppContext()) {
                var result = context.Colleges
                    .FirstOrDefault(o => o.Id == college.Id);
                if (result != null) {
                    result.Name = college.Name;
                    result.Address = college.Address;
                    result.City = college.City;
                    result.State = college.State;
                    result.Postcode = college.Postcode;
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been updated.", "Error updating college!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }
        public bool UpdateCourse(Course course) {
            using (var context = new StudentAppContext()) {
                var result = context.Courses
                    .FirstOrDefault(o => o.CourseCode == course.CourseCode);
                if (result != null) {
                    result.Name = course.Name;
                    result.Fee = course.Fee;
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been updated.", "Error updating course!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }
        public bool UpdateSubject(Subject subject) {
            using (var context = new StudentAppContext()) {
                var result = context.Subjects
                    .FirstOrDefault(o => o.Id == subject.Id);
                if (result != null) {
                    result.Name = subject.Name;
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been updated.", "Error updating subject!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }
        public bool UpdateUnit(Unit unit) {
            using (var context = new StudentAppContext()) {
                var result = context.Units
                    .FirstOrDefault(o => o.UnitCode == unit.UnitCode);
                if (result != null) {
                    result.Description = unit.Description;
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been updated.", "Error updating unit!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }
        public bool UpdateInvoice(Invoice invoice) {
            using (var context = new StudentAppContext()) {
                var result = context.Invoices
                    .FirstOrDefault(o => o.Id == invoice.Id);
                if (result != null) {
                    result.StudentEmail = invoice.StudentEmail;
                    result.EnroledStudentEmail = invoice.EnroledStudentEmail;
                    result.StudentYear = invoice.StudentYear;
                    result.StudentSecondSemester = invoice.StudentSecondSemester;
                    result.StudentCollegeId = invoice.StudentCollegeId;
                    result.CourseCode = invoice.CourseCode;
                    result.CourseYear = invoice.CourseYear;
                    result.CourseSecondSemester = invoice.CourseSecondSemester;
                    result.CourseCollegeId = invoice.CourseCollegeId;
                    result.Amount = invoice.Amount;
                    result.Misc = invoice.Misc;
                    result.InvoiceDate = invoice.InvoiceDate;
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been updated.", "Error updating invoice!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }
        public bool UpdateReceipt(Receipt receipt) {
            using (var context = new StudentAppContext()) {
                var result = context.Receipts
                    .FirstOrDefault(o => o.Id == receipt.Id);
                if (result != null) {
                    result.InvoiceId = receipt.InvoiceId;
                    result.Amount = receipt.Amount;
                    result.Misc = receipt.Misc;
                    result.ReceiptDate = receipt.ReceiptDate;
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been updated.", "Error updating receipt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }
        // Entity Deletions
        public bool DeleteStudent(string student) {
            using (var context = new StudentAppContext()) {

                int count = context.RegisterStudentInSemesterAtColleges
                    .Where(o => o.StudentEmail.Equals(student))
                    .Count();

                if (count > 0) {
                    _ = MessageBox.Show(null, "Cannot delete Student with records of registrations.", "No Action Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Dispose();
                    return false;
                }
                DialogResult confirm = MessageBox.Show(null, "Are you sure you want to delete\n\n" + student, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK) {
                    context.Students
                        .Remove(
                            context.Students
                            .Where(o => o.UserEmail == student)
                            .Single()
                        );
                    context.Users
                        .Remove(
                            context.Users
                            .Where(o => o.Email == student)
                            .Single()
                        );
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException e) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                context.Dispose();
                return false;
            }
        }
        public bool DeleteTeacher(string teacher) {
            using (var context = new StudentAppContext()) {

                int count = context.SubjectInCourseAtSemesterAtColleges
                    .Where(o => o.TeacherEmail.Equals(teacher))
                    .Count();

                if (count > 0) {
                    _ = MessageBox.Show(null, "Cannot delete Teacher assigned to course(s).", "No Action Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Dispose();
                    return false;
                }
                DialogResult confirm = MessageBox.Show(null, "Are you sure you want to delete\n\n" + teacher, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK) {
                    context.Teachers
                        .Remove(
                            context.Teachers
                            .Where(o => o.UserEmail == teacher)
                            .Single()
                        );
                    context.Users
                        .Remove(
                            context.Users
                            .Where(o => o.Email == teacher)
                            .Single()
                        );
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException e) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                context.Dispose();
                return false;
            }
        }
        public bool DeleteAdmin(string admin) {
            using (var context = new StudentAppContext()) {

                int count = context.Admins
                    .Count();

                if (count < 2) {
                    _ = MessageBox.Show(null, "Cannot delete every administrator.", "No Action Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Dispose();
                    return false;
                }
                DialogResult confirm = MessageBox.Show(null, "Are you sure you want to delete\n\n" + admin, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK) {
                    context.Admins
                        .Remove(
                            context.Admins
                            .Where(o => o.UserEmail == admin)
                            .Single()
                        );
                    context.Users
                        .Remove(
                            context.Users
                            .Where(o => o.Email == admin)
                            .Single()
                        );
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException e) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                context.Dispose();
                return false;
            }
        }
        public bool DeleteSemester(int semesterKey) {
            DateTime year = new DateTime(semesterKey / 10, 1, 1).Date;
            bool sem = (semesterKey % 10).Equals(2);
            using (var context = new StudentAppContext()) {

                int count = context.SemesterAtColleges
                    .Where(o => o.Year.Equals(year) && o.SecondSemester.Equals(sem))
                    .Count();

                if (count > 0) {
                    _ = MessageBox.Show(null, "Cannot delete a semester that has been or is in use.", "No Action Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Dispose();
                    return false;
                }
                DialogResult confirm = MessageBox.Show(null, "Are you sure you want to delete\n\n" + "Semester " + (sem ? 2 : 1).ToString() + ", " + year.Year.ToString(), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK) {
                    context.Semesters
                        .Remove(
                            context.Semesters
                            .Where(o => o.Year.Equals(year) && o.SecondSemester.Equals(sem))
                            .Single()
                        );
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException e) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                context.Dispose();
                return false;
            }
        }
        public bool DeleteCollege(int collegeId, string college) {
            using (var context = new StudentAppContext()) {

                int count = context.SemesterAtColleges
                    .Where(o => o.CollegeId.Equals(collegeId))
                    .Count();

                if (count > 0) {
                    _ = MessageBox.Show(null, "Cannot delete a college that has been or is in use.", "No Action Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Dispose();
                    return false;
                }
                DialogResult confirm = MessageBox.Show(null, "Are you sure you want to delete\n\n" + college, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK) {
                    context.Colleges
                        .Remove(
                            context.Colleges
                            .Where(o => o.Id.Equals(collegeId))
                            .Single()
                        );
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException e) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                context.Dispose();
                return false;
            }
        }
        public bool DeleteCourse(string course) {
            using (var context = new StudentAppContext()) {

                int countCollege = context.CourseAtSemesterAtColleges
                    .Where(o => o.CourseCode.Equals(course))
                    .Count();

                int countState = context.UnitInCourses
                    .Where(o => o.CourseCode.Equals(course))
                    .Count();

                if (countCollege > 0 || countState > 0) {
                    _ = MessageBox.Show(null, "Cannot delete a course that has been\nor is in use or has units assigned.", "No Action Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Dispose();
                    return false;
                }
                DialogResult confirm = MessageBox.Show(null, "Are you sure you want to delete\n\n" + course, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK) {
                    context.Courses
                        .Remove(
                            context.Courses
                            .Where(o => o.CourseCode.Equals(course))
                            .Single()
                        );
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException e) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                context.Dispose();
                return false;
            }
        }
        public bool DeleteSubject(int subjectId, string subject) {
            using (var context = new StudentAppContext()) {

                int count = context.SubjectInCourseAtSemesterAtColleges
                    .Where(o => o.SubjectId.Equals(subjectId))
                    .Count();

                if (count > 0 ) {
                    _ = MessageBox.Show(null, "Cannot delete a subject that has been\nor is in use.", "No Action Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Dispose();
                    return false;
                }
                DialogResult confirm = MessageBox.Show(null, "Are you sure you want to delete\n\n" + subject, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK) {
                    context.Subjects
                        .Remove(
                            context.Subjects
                            .Where(o => o.Id.Equals(subjectId))
                            .Single()
                        );
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException e) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                context.Dispose();
                return false;
            }
        }
        public bool DeleteUnit(string unit) {
            using (var context = new StudentAppContext()) {

                int countCollege = context.UnitInSubjectInCourseAtSemesterAtColleges
                    .Where(o => o.UnitCode.Equals(unit))
                    .Count();

                int countState = context.UnitInCourses
                    .Where(o => o.UnitCode.Equals(unit))
                    .Count();

                if (countCollege > 0 || countState > 0) {
                    _ = MessageBox.Show(null, "Cannot delete a unit that has been\nor is in use or has units assigned.", "No Action Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Dispose();
                    return false;
                }
                DialogResult confirm = MessageBox.Show(null, "Are you sure you want to delete\n\n" + unit, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK) {
                    context.Units
                        .Remove(
                            context.Units
                            .Where(o => o.UnitCode.Equals(unit))
                            .Single()
                        );
                    try {
                        context.SaveChanges();
                        return true;
                    } catch (DbUpdateException e) {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                context.Dispose();
                return false;
            }
        }

        // Composite Key Inserts
        public bool AddSemesterAtCollege(SemesterAtCollege semesterAtCollege) {
            using (var context = new StudentAppContext()) {
                context.SemesterAtColleges.Add(semesterAtCollege);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe entry supplied is already in our database.\nEntry not added.", "Error adding record!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been added.", "Error adding record!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public bool AddCourseAtSemesterAtCollege(CourseAtSemesterAtCollege courseAtSemesterAtCollege) {
            using (var context = new StudentAppContext()) {
                context.CourseAtSemesterAtColleges.Add(courseAtSemesterAtCollege);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe entry supplied is already in our database.\nEntry not added.", "Error adding record!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been added.", "Error adding record!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public bool AddRegistration(RegisterStudentInSemesterAtCollege registerStudentInSemesterAtCollege) {
            using (var context = new StudentAppContext()) {
                context.RegisterStudentInSemesterAtColleges.Add(registerStudentInSemesterAtCollege);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe entry supplied is already in our database.\nEntry not added.", "Error adding record!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been added.", "Error adding record!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public bool AddEnrolment(RegisteredStudentEnrolInCourseAtSemesterAtCollege registeredStudentEnrolInCourseAtSemesterAtCollege, Invoice invoice) {
            using (var context = new StudentAppContext()) {
                context.RegisteredStudentEnrolInCourseAtSemesterAtColleges.Add(registeredStudentEnrolInCourseAtSemesterAtCollege);
                context.Invoices.Add(invoice);
                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    if (e.GetBaseException().Message.Contains("Violation of PRIMARY KEY constraint")) {
                        _ = MessageBox.Show(null, "Failed.\nThe entry supplied is already in our database.\nEntry not added.", "Error adding record!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        _ = MessageBox.Show(null, "Update failed due to unknown error.\nThis entry has not been added.", "Error adding record!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        // Composite Key Updates (performed as inserts and deletes)
        public bool ModifyCourseSubject(List<SubjectInCourseAtSemesterAtCollege> additions, List<SubjectInCourseAtSemesterAtCollege> deletions) {
            using (var context = new StudentAppContext()) {
                    
                foreach(var d in deletions) {
                    context.SubjectInCourseAtSemesterAtColleges
                        .Remove(
                            context.SubjectInCourseAtSemesterAtColleges
                            .Where(o => o.Year == d.Year)
                            .Where(o => o.SecondSemester == d.SecondSemester)
                            .Where(o => o.CollegeId == d.CollegeId)
                            .Where(o => o.CourseCode == d.CourseCode)
                            .Where(o => o.SubjectId == d.SubjectId)
                            .Single()
                        );
                }

                foreach (var a in additions) {
                    context.SubjectInCourseAtSemesterAtColleges
                        .Add(a);
                }

                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool ModifySubjectUnit(List<UnitInSubjectInCourseAtSemesterAtCollege> additions, List<UnitInSubjectInCourseAtSemesterAtCollege> deletions) {
            using (var context = new StudentAppContext()) {

                foreach (var d in deletions) {
                    context.UnitInSubjectInCourseAtSemesterAtColleges
                        .Remove(
                            context.UnitInSubjectInCourseAtSemesterAtColleges
                            .Where(o => o.Year == d.Year)
                            .Where(o => o.SecondSemester == d.SecondSemester)
                            .Where(o => o.CollegeId == d.CollegeId)
                            .Where(o => o.CourseCode == d.CourseCode)
                            .Where(o => o.SubjectId == d.SubjectId)
                            .Where(o => o.UnitCode == d.UnitCode)
                            .Single()
                        );
                }

                foreach (var a in additions) {
                    context.UnitInSubjectInCourseAtSemesterAtColleges
                        .Add(a);
                }

                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool ModifyUnitInCourse(List<UnitInCourse> additions, List<UnitInCourse> deletions) {
            using (var context = new StudentAppContext()) {

                foreach (var d in deletions) {
                    context.UnitInCourses
                        .Remove(
                            context.UnitInCourses
                            .Where(o => o.UnitCode == d.UnitCode)
                            .Where(o => o.CourseCode == d.CourseCode)
                            .Single()
                        );
                }

                foreach (var a in additions) {
                    context.UnitInCourses
                        .Add(a);
                }

                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool ModifyStudentGrades(List<StudentUnitGrade> additions, List<StudentUnitGrade> deletions) {
            using (var context = new StudentAppContext()) {

                foreach (var d in deletions) {
                    context.StudentUnitGrades
                        .Remove(
                            context.StudentUnitGrades
                            .Where(o => o.Year == d.Year)
                            .Where(o => o.SecondSemester == d.SecondSemester)
                            .Where(o => o.CollegeId == d.CollegeId)
                            .Where(o => o.CourseCode == d.CourseCode)
                            .Where(o => o.SubjectId == d.SubjectId)
                            .Where(o => o.UnitCode == d.UnitCode)
                            .Where(o => o.StudentEmail == d.StudentEmail)
                            .Single()
                        );
                }

                foreach (var a in additions) {
                    context.StudentUnitGrades
                        .Add(a);
                }

                try {
                    context.SaveChanges();
                    return true;
                } catch (DbUpdateException e) {
                    _ = MessageBox.Show(null, "Update failed due to unknown error.\nNo modifications have been made.\n\n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Course Allocations
        // DialogSemesterCollege (also Student Enrolments)
        public DataTable SemestersNotAssignedToCollege(int collegeId) {
            // SELECT s.Year, s.SecondSemester
            // FROM(
            //     SELECT ss.Year, ss.SecondSemester, CONCAT(Year(ss.Year), ss.SecondSemester) as compositeKey
            //     FROM Semesters as ss
            // ) AS s
            // WHERE compositeKey NOT IN(
            //     SELECT CONCAT(Year(Year), SecondSemester) as compositeKey
            //     FROM SemesterAtColleges
            //     WHERE CollegeId LIKE 2
            // )
            using (var context = new StudentAppContext()) {
                int currentKey = int.Parse(GetCurrentSemesterKey());
                return BuildDataTable(
                    context.Semesters
                    .Select(o => new {
                        Year = o.Year.Year,
                        IsSecondSemester = o.SecondSemester ? 2 : 1,
                        SemesterName = o.Year.Year.ToString() + " - " + "Semester " + (o.SecondSemester ? 2 : 1).ToString(),
                        SemesterKey = (o.Year.Year * 10) + (o.SecondSemester ? 2 : 1)
                    })
                    .Except(
                        context.SemesterAtColleges
                        .Where(o => o.CollegeId.Equals(collegeId))
                        .Select(o => new {
                            Year = o.Year.Year,
                            IsSecondSemester = o.SecondSemester ? 2 : 1,
                            SemesterName = o.Year.Year.ToString() + " - " + "Semester " + (o.SecondSemester ? 2 : 1).ToString(),
                            SemesterKey = (o.Year.Year * 10) + (o.SecondSemester ? 2 : 1)
                        })
                    )
                    .Where(o => o.SemesterKey > currentKey)
                );
            }
        }
        public DataTable CollegesNotOperatingDuringSemester(int semesterKey) {
            int year = semesterKey / 10;
            bool semester = (semesterKey % 10) == 2;
            using (var context = new StudentAppContext()) {
                return BuildDataTable(
                    context.Colleges
                    .Select(o => new {
                        CollegeId = o.Id,
                        CollegeName = o.Name,
                        o.Address,
                        o.City,
                        o.State,
                        o.Postcode
                    })
                    .Except(
                        context.SemesterAtColleges
                        .Where(o => o.Year.Year.Equals(year))
                        .Where(o => o.SecondSemester.Equals(semester))
                        .Select(o => new {
                            CollegeId = o.CollegeId,
                            CollegeName = o.College.Name,
                            o.College.Address,
                            o.College.City,
                            o.College.State,
                            o.College.Postcode
                        })
                    )
                );
            }
        }
        // DialogCollegeCourse
        public DataTable CoursesNotRunning(int semesterKey, int college) {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.UnitInCourses
                    .Select(o => new {
                        CourseCode = o.CourseCode,
                        CourseName = o.Course.Name
                    })
                    .Except(context.CourseAtSemesterAtColleges  // Except will only return distinct
                        .Where(o => o.Year.Year * 10 + (o.SecondSemester ? 2 : 1) == semesterKey)
                        .Where(o => o.CollegeId == college)
                        .Select(o => new {
                            CourseCode = o.CourseCode,
                            CourseName = o.Course.Name
                        })
                    )
                    .OrderBy(o => o.CourseCode)
                    .ToList()
                );
            }
        }
        public DataTable ComboViewAllTeachers() {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Teachers
                    .Select(o => new {
                        TeacherName = o.User.LastName + ", " + o.User.FirstName,
                        TeacherEmail = o.UserEmail
                    }).ToList()
                    .OrderBy(o => o.TeacherName)
                );
            }
        }
        // DialogCourseSubject
        public DataTable SpecialCourseSubject(int semesterKey, int college, string course) {
            using (var context = new StudentAppContext()) {
                var s = context.Subjects
                    .Select(o => new {
                        SemesterKey = (string)null,
                        CollegeId = (int?)null,
                        CourseCode = (string)null,
                        Id = o.Id,
                        Subject = o.Name,
                        TeacherName = (string)null,
                        TeacherEmail = (string)null,
                        Select = (bool)false
                    })
                    .ToList();

                var sc = context.SubjectInCourseAtSemesterAtColleges
                    .Select(o => new {
                        SemesterKey = (o.Year.Year * 10) + (o.SecondSemester ? 2 : 1),
                        CollegeId = o.CollegeId,
                        CourseCode = o.CourseAtSemesterAtCollege.CourseCode,
                        Id = o.SubjectId,
                        Subject = o.Subject.Name,
                        TeacherName = o.Teacher.User.LastName + ", " + o.Teacher.User.FirstName,
                        TeacherEmail = o.TeacherEmail,
                        Select = (bool)true
                    })
                    .Where(o => semesterKey.Equals(0) ? o.Equals(o) : o.SemesterKey.Equals(semesterKey))
                    .Where(o => college.Equals(0) ? o.Equals(o) : o.CollegeId.Equals(college))
                    .Where(o => course.Equals("") ? o.Equals(o) : o.CourseCode.Equals(course))
                    .ToList();

                var query = from subject in s
                            join available in sc on subject.Id equals available.Id into gj
                            from joined in gj.DefaultIfEmpty()
                            select new {
                                SemesterKey = subject?.SemesterKey ?? String.Empty,
                                CollegeId = joined?.CollegeId ?? 0,
                                CourseCode = joined?.CourseCode ?? String.Empty,
                                SubjectId = subject.Id,
                                SubjectName = subject?.Subject ?? String.Empty,
                                TeacherFullName = joined?.TeacherName ?? String.Empty,
                                TeacherEmail = joined?.TeacherEmail ?? String.Empty,
                                Select = joined?.Select ?? false
                            };
                return BuildDataTable(query
                    .OrderBy(o => o.SubjectName)
                    .OrderByDescending(o => o.Select)
                    .Distinct()
                    .ToList());
            }
        }
        // DialogSubjectUnit
        public DataTable SpecialSubjectUnit(int semesterKey, int collegeId, string courseCode) {
            int year = semesterKey / 10;
            bool semester2 = (semesterKey % 10).Equals(2);
            using (var context = new StudentAppContext()) {
                var us = context.UnitInSubjectInCourseAtSemesterAtColleges
                    .Where(o => o.CourseCode.Equals(courseCode))
                    .Where(o => o.Year.Year.Equals(year))
                    .Where(o => o.SecondSemester.Equals(semester2))
                    .Where(o => o.CollegeId.Equals(collegeId))
                    .Select(o => new {
                        o.CourseCode,
                        o.UnitCode,
                        o.Unit.Description,
                        SubjectId = (int?)o.SubjectId,
                        SubjectName = o.SubjectInCourseAtSemesterAtCollege.Subject.Name,
                        Core = (bool?)null,
                        Select = (bool)true
                    }).ToList();
                // Left outer join using lambda
                return BuildDataTable(context.UnitInCourses
                    .Select(o => new {
                        o.CourseCode,
                        o.UnitCode,
                        o.Unit.Description,
                        SubjectId = (int?)null,
                        SubjectName = (string)null,
                        Core = (bool?)o.Core,
                        Select = (bool)false
                    }).ToList()
                    .Where(o => o.CourseCode.Equals(courseCode))
                    .GroupJoin(
                        us,
                        unit => unit.UnitCode,
                        subject => subject.UnitCode,
                        (left, joined) => new { uc = left, us = joined })
                    .SelectMany(
                        left => left.us.DefaultIfEmpty(),
                        (left, joined) => new { 
                            CourseCode = left.uc.CourseCode, 
                            UnitCode = left.uc.UnitCode,
                            UnitDescription = left.uc.Description,
                            SubjectId = joined?.SubjectId ?? 0,
                            SubjectName = joined?.SubjectName ?? String.Empty,
                            Core = left.uc.Core.Equals(DBNull.Value) ? "" : left.uc.Core.Equals(true) ? "Core" : "Elective",
                            Select = joined?.Select ?? false
                        })
                    .OrderBy(o => o.UnitCode)
                    .OrderBy(o => o.Core)
                    .OrderByDescending(o => o.Select)
                    .Distinct()
                    .ToList()
                );
            }
        }

        // Student Enrolments
        // Dialog Register
        public DataTable AvailableStudentRegistrations(string student) {
            using (var context = new StudentAppContext()) {
                int currentKey = int.Parse(GetCurrentSemesterKey());
                return BuildDataTable(
                    context.SemesterAtColleges
                    .Select(o => new {
                        Year = o.Year.Year,
                        IsSecondSemester = o.SecondSemester ? 2 : 1,
                        SemesterKey = (o.Year.Year * 10) + (o.SecondSemester ? 2 : 1),
                        CollegeId = o.CollegeId,
                        CollegeName = o.College.Name
                    })
                    .Except(
                        context.RegisterStudentInSemesterAtColleges
                        .Where(o => o.StudentEmail.Equals(student))
                        .Select(o => new {
                            Year = o.Year.Year,
                            IsSecondSemester = o.SecondSemester ? 2 : 1,
                            SemesterKey = (o.Year.Year * 10) + (o.SecondSemester ? 2 : 1),
                            CollegeId = o.CollegeId,
                            CollegeName = o.SemesterAtCollege.College.Name
                        })
                    )
                    .Where(o => o.SemesterKey > currentKey)
                );
            }
        }
        public DataTable AllExceptRegisteredStudents(int semesterKey, int college) {
            using (var context = new StudentAppContext()) {
                //var registered = context.RegisterStudentInSemesterAtColleges
                //    .Where(o => o.Year.Year.ToString() + (o.SecondSemester ? 2 : 1).ToString() == semester)
                //    .Where(o => o.CollegeId == college)
                //    .Select(o => new {
                //        StudentFirstName = o.Student.User.FirstName,
                //        StudentLastName = o.Student.User.LastName,
                //        StudentEmail = o.StudentEmail
                //    });
                return BuildDataTable(
                    context.Students
                    .Select(o => new { 
                        StudentFirstName = o.User.FirstName,
                        StudentLastName = o.User.LastName,
                        StudentEmail = o.UserEmail
                    })
                    .Except(
                        context.RegisterStudentInSemesterAtColleges
                        .Where(o => (o.Year.Year * 10) + (o.SecondSemester ? 2 : 1) == semesterKey)
                        .Where(o => o.CollegeId == college)
                        .Select(o => new {
                            StudentFirstName = o.Student.User.FirstName,
                            StudentLastName = o.Student.User.LastName,
                            StudentEmail = o.StudentEmail
                        })
                    )
                    .OrderBy(o => o.StudentLastName)
                    .ThenBy(o => o.StudentFirstName)
                    .ToList()
                );
            }
        }
        // DialogEnrolment
        public DataTable DialogEnrolment(int semesterKey, int college, string student) {
            // select a.CourseCode, a.Year, a.SecondSemester, a.CollegeId, cast(isnull(b.Enroled, 0) as bit) as 'Enroled'
            // from (
            //     select CourseCode, Year, SecondSemester, CollegeId, null as 'Enroled'
            //     from CourseAtSemesterAtColleges
            // ) as a
            // left outer join(
            //     select CourseCode, CourseYear, CourseSecondSemester, CourseCollegeId, cast(1 as bit) as 'Enroled'
            //     from RegisteredStudentEnrolInCourseAtSemesterAtColleges
            //     where StudentEmail = 'lloyd.james2@studytafensw.edu.au'
            // ) as b 
            // on a.CourseCode = b.CourseCode 
            // and a.SecondSemester = b.CourseSecondSemester 
            // and a.Year = b.CourseYear
            // and a.CollegeId = b.CourseCollegeId
            // where a.CollegeId = 1 and cast(concat(year(a.Year), a.SecondSemester+1) as int) like 20202

            using (var context = new StudentAppContext()) {
                var enrol = context.CourseAtSemesterAtColleges
                    .Where(o => o.CollegeId.Equals(college))
                    .Select(o => new {
                        CourseCode = o.CourseCode,
                        Name = o.Course.Name,
                        Year = o.Year.Year,
                        SecondSemester =o.SecondSemester ? 2 : 1,
                        CollegeId = o.CollegeId,
                        College = o.SemesterAtCollege.College.Name,
                        Fee = o.Course.Fee,
                        Enroled = (string)null,
                        Select = (bool?)false
                    });
                var reg = context.RegisteredStudentEnrolInCourseAtSemesterAtColleges
                    .Where(o => o.StudentEmail.Equals(student))
                    .Where(o => o.CourseAtSemesterAtCollege.CollegeId.Equals(college))
                    .Select(o => new {
                        CourseCode = o.CourseCode,
                        Name = o.CourseAtSemesterAtCollege.Course.Name,
                        Year = o.CourseYear.Year,
                        SecondSemester = o.CourseSecondSemester ? 2 : 1,
                        CollegeId = o.CourseCollegeId,
                        College = o.CourseAtSemesterAtCollege.SemesterAtCollege.College.Name,
                        Fee = o.CourseAtSemesterAtCollege.Course.Fee,
                        Enroled = "Enroled",
                        Select = (bool?)true
                    });

                var query = (from c in enrol
                    join r in reg on new { c.Year, c.SecondSemester, c.CollegeId, c.CourseCode } 
                    equals new { r.Year, r.SecondSemester, r.CollegeId, r.CourseCode } into gj
                    from joined in gj.DefaultIfEmpty()
                    select new {
                        CourseCode = c.CourseCode,
                        CourseName = c.Name,
                        Year = c.Year,
                        IsSecondSemester = c.SecondSemester,
                        //CollegeId = c.CollegeId,
                        CollegeName = c.College,
                        Fee = c.Fee,
                        DateEnroled = c.Enroled == null ? joined.Enroled :"-",
                        Select = joined != null
                    })
                    .Where(o => (o.Year * 10) + o.IsSecondSemester == semesterKey)
                    .OrderByDescending(o => o.Select).ToList();
                return BuildDataTable(query);
            }
        }
        // DialogGrades
        public DataTable DialogGrades(int semesterKey, int college, string student, string course) {
            //select a.UnitCode, b.Grade, b.RPL, b.DateGraded
            //from (
            //    select u.UnitCode, cast(0 as bit) as Grade, cast(0 as bit) as RPL, null as DateGraded
            //    from UnitInSubjectInCourseAtSemesterAtColleges as u
            //    where u.CourseCode = @course
            //    and cast(concat(year(u.Year), u.SecondSemester+1) as int) = @semKey
            //    and u.CollegeId = @college
            //) as a
            //left outer join (
            //    select s.UnitCode, s.Grade, s.RPL, s.DateGraded
            //    from StudentUnitGrades as s
            //    where s.CourseCode = @course
            //    and cast(concat(year(s.Year), s.SecondSemester+1) as int) = @semKey
            //    and s.CollegeId = @college
            //    and s.StudentEmail = @email
            //) as b
            //on a.UnitCode = b.UnitCode
            using (var context = new StudentAppContext()) {
                var us = context.UnitInSubjectInCourseAtSemesterAtColleges
                    .Where(o => o.CourseCode.Equals(course))
                    .Where(o => (o.Year.Year * 10) + (o.SecondSemester ? 2 : 1) == semesterKey)
                    .Where(o => o.CollegeId.Equals(college))
                    .Select(o => new {
                        UnitCode = o.UnitCode,
                        Unit = o.Unit.Description,
                        Subject = o.SubjectInCourseAtSemesterAtCollege.Subject.Name,
                        SubjectId = o.SubjectId,
                        Competent = (bool?)false,
                        RPL = (bool?)false,
                        DateGraded = (DateTime?)null
                    });
                var sg = context.StudentUnitGrades
                    .Where(o => o.CourseCode.Equals(course))
                    .Where(o => (o.Year.Year * 10) + (o.SecondSemester ? 2 : 1) == semesterKey)
                    .Where(o => o.CollegeId.Equals(college))
                    .Where(o => o.StudentEmail.Equals(student))
                    .Select(o => new {
                        UnitCode = o.UnitCode,
                        Unit = o.UnitInSubjectInCourseAtSemesterAtCollege.Unit.Description,
                        Subject = o.UnitInSubjectInCourseAtSemesterAtCollege.SubjectInCourseAtSemesterAtCollege.Subject.Name,
                        SubjectId = o.SubjectId,
                        Competent = (bool?)o.Grade,
                        RPL = (bool?)o.RPL,
                        DateGraded = (DateTime?)o.DateGraded
                    });


                var query = from u in us
                    join s in sg on u.UnitCode
                    equals s.UnitCode into gj
                    from joined in gj.DefaultIfEmpty()
                    select new {
                        UnitCode = u.UnitCode,
                        UnitDescription = u.Unit,
                        SubjectName = u.Subject,
                        SubjectId = u.SubjectId,
                        Competent = joined.Competent == null ? false:true,
                        RPL = joined.RPL == null ? false : true,
                        DateGraded = (DateTime?)joined.DateGraded
                };

                return BuildDataTable(
                    query
                    .OrderBy(o => o.SubjectName)
                    .ThenByDescending(o => o.Competent)
                    .ThenByDescending(o => o.RPL)
                    .ThenBy(o => o.UnitCode)
                    .ToList()
                );
            }
        }

        // Course Assigned Units
        public DataTable DialogCourseUnitPopulateUnit(string courseCode, string filter) {
            using (var context = new StudentAppContext()) {
                var units = context.Units
                    .Select(o => new {
                        UnitCode = o.UnitCode,
                        Description = o.Description,
                        Core = (bool?)false,
                        Select = (bool?)false
                    });
                var unitincourses = context.UnitInCourses
                    .Where(o => o.CourseCode.Equals(courseCode))
                    .Select(o => new {
                        UnitCode = o.UnitCode,
                        Description = (string)null,
                        Core = (bool?)o.Core,
                        Select = (bool?)true
                    });
                var unitsLeftOuterJoinUnitInCourses = (
                        from unit in units
                        join unitincourse in unitincourses 
                        on unit.UnitCode equals unitincourse.UnitCode 
                        into left from right 
                        in left.DefaultIfEmpty()
                        select new {
                            UnitCode = unit.UnitCode,
                            UnitDescription = unit.Description,
                            Core = unit.Core.Equals(null) ? false : right.Core,
                            Select = right.Select != null
                        })
                        .Where(o => o.UnitCode.Contains(filter) || o.UnitDescription.Contains(filter))
                        .OrderByDescending(o => o.Select)
                        .ThenByDescending(o => o.Core)
                        .ThenBy(o => o.UnitCode)
                        .ToList();

                return BuildDataTable(unitsLeftOuterJoinUnitInCourses);
            }
        }

        // Transactions
        public decimal InvoiceBalance(string student, int semesterKey, int college, string course) {
            // SELECT a.StudentEmail, a.StudentYear, a.StudentSecondSemester, a.StudentCollegeId, a.CourseCode, SUM(a.Amount) as 'Owing on Invoice'
            // FROM(
            //     SELECT StudentEmail, StudentYear, StudentSecondSemester, StudentCollegeId, CourseCode, SUM(amount) as Amount
            //     FROM Invoices
            //     GROUP BY StudentEmail, StudentYear, StudentSecondSemester, StudentCollegeId, CourseCode
            //     UNION(
            //         SELECT i.StudentEmail, i.StudentYear, i.StudentSecondSemester, i.StudentCollegeId, i.CourseCode, SUM(r.Amount) as Amount
            //         FROM Receipts as r
            //         JOIN Invoices as i ON i.Id LIKE r.InvoiceId
            //         GROUP BY StudentEmail, StudentYear, StudentSecondSemester, StudentCollegeId, CourseCode
            //     )
            // ) as a
            // GROUP BY a.StudentEmail, a.StudentYear, a.StudentSecondSemester, a.StudentCollegeId, a.CourseCode
            // HAVING a.StudentEmail LIKE 'barbie@fence.com'
            //   AND YEAR(a.StudentYear) LIKE 2020
            //   AND a.StudentSecondSemester LIKE 1
            //   AND a.StudentCollegeId LIKE 1
            //   AND a.CourseCode LIKE 'ICT50718';

            using (var context = new StudentAppContext()) {
                var result = context.Invoices
                    .GroupBy(g => new {
                        g.StudentEmail,
                        g.StudentYear,
                        g.StudentSecondSemester,
                        g.StudentCollegeId,
                        g.CourseCode
                    })
                    .Select(o => new {
                        o.Key.StudentEmail,
                        o.Key.StudentYear,
                        o.Key.StudentSecondSemester,
                        o.Key.StudentCollegeId,
                        o.Key.CourseCode,
                        Amount = o.Sum(g => g.Amount)
                    })
                    .Union(
                        context.Receipts
                        .GroupBy(g => new {
                            g.Invoice.StudentEmail,
                            g.Invoice.StudentYear,
                            g.Invoice.StudentSecondSemester,
                            g.Invoice.StudentCollegeId,
                            g.Invoice.CourseCode
                        })
                        .Select(o => new {
                            o.Key.StudentEmail,
                            o.Key.StudentYear,
                            o.Key.StudentSecondSemester,
                            o.Key.StudentCollegeId,
                            o.Key.CourseCode,
                            Amount = o.Sum(g => g.Amount)
                        })
                    )
                    .GroupBy(g => new {
                        g.StudentEmail,
                        g.StudentYear,
                        g.StudentSecondSemester,
                        g.StudentCollegeId,
                        g.CourseCode
                    })
                    .Where(o => o.Key.StudentEmail.Equals(student))
                    .Where(o => (o.Key.StudentYear.Year * 10) + (o.Key.StudentSecondSemester ? 2 : 1) == semesterKey)
                    .Where(o => o.Key.StudentCollegeId.Equals(college))
                    .Where(o => o.Key.CourseCode.Equals(course))
                    .Select(o => o.Sum(g => g.Amount))
                    .FirstOrDefault();
                return result;
            }
        }

        // Custom Data Views
        // Teachers
        public DataTable TeacherHistory(string teacher) {
            /*
             select 
	            t.UserEmail, 
	            sic.CourseCode, 
	            year(sic.Year) as 'Year', 
	            iif(sic.SecondSemester=0,1,2) as 'Semester', 
	            sic.CollegeId
            from Teachers as t
            join SubjectInCourseAtSemesterAtColleges as sic 
            on t.UserEmail = sic.TeacherEmail
            where t.UserEmail = 'raj_batra@tafemail.com.au'
            order by 'Year', 'Semester';
            */
            using (var context = new StudentAppContext()) {
                var query = context.Teachers
                    .Select(o => new {
                        CourseCode = String.Empty,
                        CourseName = String.Empty,
                        SubjectName = String.Empty,
                        CollegeName = String.Empty,
                        SemesterName = String.Empty,
                        Period = String.Empty,
                        TeacherEmail = o.UserEmail,
                        TeacherFullName = o.User.LastName + ", " + o.User.FirstName,
                        SemesterKey = (int?)null
                    })
                    .Join(context.SubjectInCourseAtSemesterAtColleges,
                    t => t.TeacherEmail,
                    s => s.TeacherEmail,
                    (t,s) => new {
                        CourseCode = s.CourseCode,
                        CourseName = s.CourseAtSemesterAtCollege.Course.Name,
                        SubjectName = s.Subject.Name,
                        CollegeName = s.CourseAtSemesterAtCollege.SemesterAtCollege.College.Name,
                        SemesterName = s.Year.Year.ToString() + " - " + "Semester " + (s.SecondSemester ? 2 : 1).ToString(),
                        Period = String.Empty,
                        TeacherEmail = t.TeacherEmail,
                        TeacherFullName = t.TeacherFullName,
                        SemesterKey = (s.Year.Year * 10) + (s.SecondSemester ? 2 : 1)
                    })
                    .Where(o => o.TeacherEmail.Equals(teacher))
                    .OrderBy(o => o.SemesterKey)
                    .ToList();

                return BuildDataTable(query);
            }
        }
        // Courses, Subjects, Units
        public DataTable CoursesNeverRun() {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Courses
                    .Select(o => new {
                        CourseCode = o.CourseCode,
                        Name = o.Name,
                        Fee = o.Fee,
                        CollegeId = (int?)null
                    })
                    .GroupJoin(
                    context.CourseAtSemesterAtColleges,
                    c => c.CourseCode,
                    csc => csc.CourseCode,
                    (left, joined) => new { l = left, r = joined })
                    .SelectMany(
                        left => left.r.DefaultIfEmpty(),
                        (left, joined) => new {
                            CourseCode = left.l.CourseCode,
                            Name = left.l.Name,
                            Fee = left.l.Fee,
                            CollegeId = (int?)joined.CollegeId
                        })
                    .Where(o => o.CollegeId.Equals(null))
                    .Select(o => new {
                        CourseCode = o.CourseCode,
                        CourseName = o.Name,
                        Fee = o.Fee
                    })
                    .ToList()
                );
            }
        }
        public DataTable SubjectsNeverRun() {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Subjects
                    .Select(o => new {
                        Id = o.Id,
                        Name = o.Name,
                        CollegeId = (int?)null
                    })
                    .GroupJoin(
                    context.SubjectInCourseAtSemesterAtColleges,
                    s => s.Id,
                    sic => sic.SubjectId,
                    (left, joined) => new { l = left, r = joined })
                    .SelectMany(
                        left => left.r.DefaultIfEmpty(),
                        (left, joined) => new {
                            Id = left.l.Id,
                            Name = left.l.Name,
                            CollegeId = (int?)joined.CollegeId
                        })
                    .Where(o => o.CollegeId.Equals(null))
                    .Select(o => new {
                        SubjectId = o.Id,
                        SubjectName = o.Name
                    })
                    .ToList()
                );
            }
        }
        public DataTable UnitsNeverRun() {
            using (var context = new StudentAppContext()) {
                return BuildDataTable(context.Units
                    .Select(o => new {
                        UnitCode = o.UnitCode,
                        Description = o.Description,
                        CollegeId = (int?)null
                    })
                    .GroupJoin(
                    context.UnitInSubjectInCourseAtSemesterAtColleges,
                    u => u.UnitCode,
                    uis => uis.UnitCode,
                    (left, joined) => new { l = left, r = joined })
                    .SelectMany(
                        left => left.r.DefaultIfEmpty(),
                        (left, joined) => new {
                            UnitCode = left.l.UnitCode,
                            Description = left.l.Description,
                            CollegeId = (int?)joined.CollegeId
                        })
                    .Where(o => o.CollegeId.Equals(null))
                    .Select(o => new {
                        UnitCode = o.UnitCode,
                        UnitDescription = o.Description
                    })
                    .ToList()
                );
            }
        }

        // Other functions
        public string GetPass(string email) {
            using (var context = new StudentAppContext()) {
                var query = context.Users
                    .Where(o => o.Email.Equals(email))
                    .Select(o => new { Pass = o.Pass })
                    .FirstOrDefault();
                return query == null ? "" : query.Pass;
            }
        }
        public string GetCurrentSemesterKey() {
            using (var context = new StudentAppContext()) {
                var query = context.Semesters
                    .Where(o => o.FirstTermBegin < DateTime.Now)
                    .OrderByDescending(o => o.Year)
                    .ThenByDescending(o => o.SecondSemester)
                    .Select(o => new {
                        Current = o.Year.Year.ToString() + (o.SecondSemester ? 2 : 1).ToString()
                    })
                    .First();
                return query.Current;
            }
        }
        public string GetEarliestSemesterKeyOfCourse(string courseCode) {
            using (var context = new StudentAppContext()) {
                var query = context.CourseAtSemesterAtColleges
                    .Where(o => o.CourseCode.Equals(courseCode))
                    .OrderBy(o => o.Year)
                    .ThenBy(o => o.SecondSemester)
                    .Select(o => new {
                        semKey = o.Year.Year.ToString() + (o.SecondSemester ? 2 : 1).ToString()
                    })
                    .FirstOrDefault();
                return query == null ? "99999" : query.semKey;
            }
        }
        public int CountUnitsInCourse(int semesterKey, int collegeId, string courseCode) {
            DateTime year = new DateTime(semesterKey / 10, 1, 1);
            bool semester = (semesterKey % 10).Equals(2);
            using (var context = new StudentAppContext()) {
                int query = (context.UnitInSubjectInCourseAtSemesterAtColleges
                    .Where(o => o.Year.Equals(year))
                    .Where(o => o.SecondSemester.Equals(semester))
                    .Where(o => o.CollegeId.Equals(collegeId))
                    .Where(o => o.CourseCode.Equals(courseCode))
                    .Select(o => o.UnitCode))
                    .Count();
                return query;
            }
        }
        public int GetMaxLengthOfField(string entity, string field) {
            using (var context = new StudentAppContext()) {
                var objectContext = ((IObjectContextAdapter)context).ObjectContext;
                var container = objectContext.MetadataWorkspace.GetEntityContainer(objectContext.DefaultContainerName, DataSpace.CSpace);
                return (int)container.EntitySets[entity].ElementType.Properties[field].MaxLength;
            }
        }

        // *** Helper functions ***
        private DataTable BuildDataTable<T>(IEnumerable<T> result) {
            DataTable dataTable = new DataTable();
            PropertyInfo[] fields = null;
            if (result == null) return dataTable;
            foreach (T Record in result) {
                if (fields == null) {
                    fields = Record.GetType().GetProperties();
                    foreach (PropertyInfo prop in fields) {
                        Type colType = prop.PropertyType;
                        if (colType.IsGenericType && (colType.GetGenericTypeDefinition() == typeof(Nullable<>))) {
                            colType = colType.GetGenericArguments()[0];
                        }
                        dataTable.Columns.Add(new DataColumn(prop.Name, colType));
                    }
                }
                DataRow dataRow = dataTable.NewRow();
                foreach (PropertyInfo prop in fields) {
                    dataRow[prop.Name] = prop.GetValue(Record, null) ?? DBNull.Value;
                }
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }
    }
}
