using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model.Validation {
    public class SubjectInCourseAtSemesterAtCollegeValidation : AbstractValidator<SubjectInCourseAtSemesterAtCollege> {
        
        public SubjectInCourseAtSemesterAtCollegeValidation() {
            RuleFor(o => o.TeacherEmail).EmailAddress();
        }
    }
}
