using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Subject {

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SubjectInCourseAtSemesterAtCollege> SubjectInCourseAtSemesterAtColleges { get; set; }
        

    }
}
