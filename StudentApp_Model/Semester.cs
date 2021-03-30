using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class Semester {

        //public int Id { get; set; }

        public DateTime Year { get; set; }
        public bool SecondSemester { get; set; }
        public DateTime FirstTermBegin { get; set; }
        public DateTime FirstTermEnd { get; set; }
        public DateTime SecondTermBegin { get; set; }
        public DateTime SecondTermEnd { get; set; }

        public ICollection<SemesterAtCollege> SemesterAtColleges { get; set; }

    }
}
