using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class SemesterAtCollege {

        public DateTime Year { get; set; }
        public bool SecondSemester { get; set; }

        public int CollegeId { get; set; }

        public Semester Semester { get; set; }
        public College College { get; set; }

        public ICollection<CourseAtSemesterAtCollege> CourseAtSemesterAtColleges { get; set; }
        public ICollection<RegisterStudentInSemesterAtCollege> RegisterStudentInSemesterAtColleges { get; set; }

    }
}
