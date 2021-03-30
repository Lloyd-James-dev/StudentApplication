using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Course {
        
        public string CourseCode { get; set; }

        public string Name { get; set; }
        public decimal Fee { get; set; }

        public ICollection<CourseAtSemesterAtCollege> CourseAtSemesterAtColleges { get; set; }
        public ICollection<UnitInCourse> UnitInCourses { get; set; }

    }
}
