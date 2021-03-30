using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Unit {

        public string UnitCode { get; set; }

        public string Description { get; set; }

        public ICollection<UnitInSubjectInCourseAtSemesterAtCollege> UnitInSubjectInCourseAtSemesterAtColleges { get; set; }
        public ICollection<UnitInCourse> UnitInCourses { get; set; }
    }
}
