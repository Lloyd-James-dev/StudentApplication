using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class RegisteredStudentEnrolInCourseAtSemesterAtCollege {

        public string StudentEmail { get; set; }
        public DateTime StudentYear { get; set; }
        public bool StudentSecondSemester { get; set; }
        public int StudentCollegeId { get; set; }

        public string CourseCode { get; set; }
        public DateTime CourseYear { get; set; }
        public bool CourseSecondSemester { get; set; }
        public int CourseCollegeId { get; set; }

        public DateTime EnrolmentDate { get; set; }

        public RegisterStudentInSemesterAtCollege RegisterStudentInSemesterAtCollege { get; set; }
        public CourseAtSemesterAtCollege CourseAtSemesterAtCollege { get; set; }

        public ICollection<Invoice> Invoices { get; set; }

    }
}
