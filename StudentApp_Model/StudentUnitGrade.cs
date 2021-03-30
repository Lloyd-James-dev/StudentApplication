using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class StudentUnitGrade {


        public string StudentEmail { get; set; }

        public string UnitCode { get; set; }
        public int SubjectId { get; set; }
        public string CourseCode { get; set; }
        public DateTime Year { get; set; }
        public bool SecondSemester { get; set; }
        public int CollegeId { get; set; }

        public Student Student { get; set; }
        public UnitInSubjectInCourseAtSemesterAtCollege UnitInSubjectInCourseAtSemesterAtCollege { get; set; }

        public bool Grade { get; set; }
        public bool RPL { get; set; }
        public DateTime DateGraded { get; set; }
        

    }
}
