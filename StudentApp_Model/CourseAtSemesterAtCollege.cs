using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class CourseAtSemesterAtCollege {

        public string CourseCode { get; set; }
        public DateTime Year { get; set; }
        public bool SecondSemester { get; set; }
        public int CollegeId { get; set; }

        public Course Course { get; set; }
        public SemesterAtCollege SemesterAtCollege { get; set; }

        public ICollection<SubjectInCourseAtSemesterAtCollege> SubjectInCourseAtSemesterAtColleges { get; set; }
        public ICollection<RegisteredStudentEnrolInCourseAtSemesterAtCollege> RegisteredStudentEnrolInCourseAtSemesterAtColleges { get; set; }
        
    }
}
