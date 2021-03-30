using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class RegisterStudentInSemesterAtCollege {

        public string StudentEmail { get; set; }
        public DateTime Year { get; set; }
        public bool SecondSemester { get; set; }
        public int CollegeId { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Student Student { get; set; }
        public SemesterAtCollege SemesterAtCollege { get; set; }

        public ICollection<RegisteredStudentEnrolInCourseAtSemesterAtCollege> RegisteredStudentEnrolInCourseAtSemesterAtColleges { get; set; }
        

    }
}
