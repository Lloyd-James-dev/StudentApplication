using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class SubjectInCourseAtSemesterAtCollege {

        public int SubjectId { get; set; }
        public string CourseCode { get; set; }
        public DateTime Year { get; set; }
        public bool SecondSemester { get; set; }
        public int CollegeId { get; set; }

        public string TeacherEmail { get; set; }

        public Subject Subject { get; set; }
        public CourseAtSemesterAtCollege CourseAtSemesterAtCollege { get; set; }
        public Teacher Teacher { get; set; }
        
        public ICollection<UnitInSubjectInCourseAtSemesterAtCollege> UnitInSubjectInCourseAtSemesterAtColleges { get; set; }
        

    }
}
