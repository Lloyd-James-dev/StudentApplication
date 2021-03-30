using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Invoice {

        public int Id { get; set; }

        public string StudentEmail { get; set; }

        public string EnroledStudentEmail { get; set; }
        public DateTime StudentYear { get; set; }
        public bool StudentSecondSemester { get; set; }
        public int StudentCollegeId { get; set; }

        public string CourseCode { get; set; }
        public DateTime CourseYear { get; set; }
        public bool CourseSecondSemester { get; set; }
        public int CourseCollegeId { get; set; }

        public Student Student { get; set; }
        public RegisteredStudentEnrolInCourseAtSemesterAtCollege RegisteredStudentEnrolInCourseAtSemesterAtCollege { get; set; }

        public decimal Amount { get; set; }
        public string Misc { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
    }
}
/*
EnroledStudentEmail
StudentYear
StudentSecondSemester
StudentCollegeId
CourseCode
CourseYear
CourseSecondSemester 
CourseCollegeId
Amount
Misc
InvoiceDate
*/