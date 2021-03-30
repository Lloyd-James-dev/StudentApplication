using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Teacher {

        public string UserEmail { get; set; }

        public User User { get; set; }

        public ICollection<SubjectInCourseAtSemesterAtCollege> SubjectInCourseAtSemesterAtColleges { get; set; }

    }
}
