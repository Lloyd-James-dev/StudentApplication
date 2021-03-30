using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model {

    public class UnitInCourse {


        public string UnitCode { get; set; }
        public string CourseCode { get; set; }

        public bool Core { get; set; }

        public Unit Unit { get; set; }
        public Course Course { get; set; }


    }
}
