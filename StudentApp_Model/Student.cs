using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Student {

        public string UserEmail { get; set; }

        public User User { get; set; }

        public ICollection<RegisterStudentInSemesterAtCollege> RegisterStudentInSemesterAtColleges { get; set; }
        public ICollection<StudentUnitGrade> StudentUnitGrades { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

    }
}
