using StudentApp_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace StudentApp_Controller {
    public interface IMainDAL {

        DataTable SearchStudentFields(string x);
        DataTable SearchTeacherFields(string x);
        DataTable SearchAdminFields(string x);
        DataTable SearchSemesterFields(string x);
        DataTable SearchCollegeFields(string x);
        DataTable SearchCourseFields(string x);
        DataTable SearchSubjectFields(string x);
        DataTable SearchUnitFields(string x);

        DataTable ViewCollegeAssignments();
        DataTable ViewCollegeAssignments(int semesterKey, int college);
        DataTable ViewCourseAssignments();
        DataTable ViewCourseAssignments(int semesterKey, int college, string course);
        DataTable ViewSubjectAssignments();
        DataTable ViewSubjectAssignments(int semesterKey, int college, string course, int subject, string teacher);
        DataTable ViewUnitAssignments();
        DataTable ViewUnitAssignments(int semesterKey, int college, string course, int subject, string teacher, string unit);

        DataTable ViewStudentRegistrations();
        DataTable ViewStudentRegistrations(int semesterKey, int college, string student);
        DataTable ViewStudentEnrolments();
        DataTable ViewStudentEnrolments(int semesterKey, int college, string student, string course);
        DataTable ViewStudentGrades();
        DataTable ViewStudentGrades(int semesterKey, int college, string student, string course, string unit);

        DataTable ViewCourseUnit();
        DataTable ViewCourseUnit(string courseCode, string unit);

        DataTable SearchInvoiceFields(int resultType, string student, int semesterKey, int college, string course);

        bool AddUser(object user);
        bool AddSemester(Semester semester);
        bool AddCollege(College college);
        bool AddCourse(Course course);
        bool AddSubject(Subject subject);
        bool AddUnit(Unit unit);
        bool AddInvoice(Invoice invoice);
        bool AddReceipt(Receipt receipt);

        bool UpdateUser(User user);
        bool UpdateSemester(Semester semester);
        bool UpdateCollege(College college);
        bool UpdateCourse(Course course);
        bool UpdateSubject(Subject subject);
        bool UpdateUnit(Unit unit);
        bool UpdateInvoice(Invoice invoice);
        bool UpdateReceipt(Receipt receipt);

        bool DeleteStudent(string student);
        bool DeleteTeacher(string teacher);
        bool DeleteAdmin(string admin);
        bool DeleteSemester(int semesterKey);
        bool DeleteCollege(int collegeId, string college);
        bool DeleteCourse(string course);
        bool DeleteSubject(int subject, string name);
        bool DeleteUnit(string unit);

        bool AddSemesterAtCollege(SemesterAtCollege semesterAtCollege);
        bool AddCourseAtSemesterAtCollege(CourseAtSemesterAtCollege courseAtSemesterAtCollege);
        bool AddRegistration(RegisterStudentInSemesterAtCollege registerStudentInSemesterAtCollege);
        bool AddEnrolment(RegisteredStudentEnrolInCourseAtSemesterAtCollege registeredStudentEnrolInCourseAtSemesterAtCollege, Invoice invoice);

        bool ModifyCourseSubject(List<SubjectInCourseAtSemesterAtCollege> additions, List<SubjectInCourseAtSemesterAtCollege> deletions);
        bool ModifySubjectUnit(List<UnitInSubjectInCourseAtSemesterAtCollege> additions, List<UnitInSubjectInCourseAtSemesterAtCollege> deletions);
        bool ModifyUnitInCourse(List<UnitInCourse> additions, List<UnitInCourse> deletions);
        bool ModifyStudentGrades(List<StudentUnitGrade> additions, List<StudentUnitGrade> deletions);

        DataTable SemestersNotAssignedToCollege(int collegeId);
        DataTable CollegesNotOperatingDuringSemester(int semesterKey);
        DataTable CoursesNotRunning(int semesterKey, int college);
        DataTable ComboViewAllTeachers();
        DataTable SpecialCourseSubject(int semesterKey, int college, string course);
        DataTable SpecialSubjectUnit(int semesterKey, int collegeId, string courseCode);

        DataTable AvailableStudentRegistrations(string student);
        DataTable AllExceptRegisteredStudents(int semester, int college);
        DataTable DialogEnrolment(int semesterKey, int college, string student);
        DataTable DialogGrades(int semesterKey, int college, string student, string course);

        DataTable DialogCourseUnitPopulateUnit(string courseCode, string filter);

        decimal InvoiceBalance(string student, int semesterKey, int college, string course);

        DataTable TeacherHistory(string teacher);
        DataTable CoursesNeverRun();
        DataTable SubjectsNeverRun();
        DataTable UnitsNeverRun();

        string GetPass(string email);
        string GetCurrentSemesterKey();
        string GetEarliestSemesterKeyOfCourse(string courseCode);
        int CountUnitsInCourse(int semesterKey, int collegeId, string courseCode);
        int GetMaxLengthOfField(string entity, string field);
    }
}