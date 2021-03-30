using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class UnitInSubjectInCourseAtSemesterAtCollege {

        public string UnitCode { get; set; }
        public int SubjectId { get; set; }
        public string CourseCode { get; set; }
        public DateTime Year { get; set; }
        public bool SecondSemester { get; set; }
        public int CollegeId { get; set; }


        public Unit Unit { get; set; }
        public SubjectInCourseAtSemesterAtCollege SubjectInCourseAtSemesterAtCollege { get; set; }
        public ICollection<StudentUnitGrade> StudentUnitGrades { get; set; }

    }
}
